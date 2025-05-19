using System;
using System.Collections.Generic;

namespace SimpleLibrary;

using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    private List<Book> libraryBooks;
    private List<User> libraryUsers;

    public Library()
    {
        libraryBooks = new List<Book>();
        libraryUsers = new List<User>();
    }

    public bool BorrowBook()
    {
        Console.WriteLine("Would you like to borrow a book? (Y/N)");
        string? answer = Console.ReadLine();

        if (!string.IsNullOrEmpty(answer) && answer.Trim().ToUpper() == "Y")
        {
            Console.WriteLine("Please provide the title of the book you would like to borrow: ");
            string? title = Console.ReadLine();

            Console.WriteLine("Please provide your user ID: ");
            if (!int.TryParse(Console.ReadLine(), out int idUser))
            {
                Console.WriteLine("Invalid user ID.");
                return false;
            }
            
            Book? bookToBorrow = libraryBooks.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (bookToBorrow == null)
            {
                Console.WriteLine("Book not found.");
                return false;
            }

            if (bookToBorrow.Status == "Borrowed")
            {
                Console.WriteLine("The book is already borrowed.");
                return false;
            }
            
            User? user = libraryUsers.FirstOrDefault(u => u.IdUser == idUser);
            if (user == null)
            {
                Console.WriteLine("User not found.");
                return false;
            }

            bookToBorrow.Status = "Borrowed";
            bookToBorrow.IdBorrower = idUser;
            Console.WriteLine($"Book '{bookToBorrow.Title}' borrowed successfully by user {user.Name} {user.LastName}.");

            return true;
        }
        else
        {
            Console.WriteLine("Thanks for using our services.");
            return false;
        }
    }

    public bool ReturnBook()
    {
        Console.WriteLine("Would you like to return a book? (Y/N)");
        string? answer = Console.ReadLine();

        if (!string.IsNullOrEmpty(answer) && answer.Trim().ToUpper() == "Y")
        {
            Console.WriteLine("Please provide the title of the book you would like to return: ");
            string? title = Console.ReadLine();

            Console.WriteLine("Please provide your user ID: ");
            if (!int.TryParse(Console.ReadLine(), out int idUser))
            {
                Console.WriteLine("Invalid user ID.");
                return false;
            }

            Book? bookToReturn = libraryBooks.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (bookToReturn == null)
            {
                Console.WriteLine("Book not found.");
                return false;
            }

            if (bookToReturn.Status == "Available")
            {
                Console.WriteLine("The book is not currently borrowed.");
                return false;
            }

            if (bookToReturn.IdBorrower != idUser)
            {
                Console.WriteLine("This user did not borrow the book.");
                return false;
            }

            bookToReturn.Status = "Available";
            bookToReturn.IdBorrower = 0;
            Console.WriteLine($"Book '{bookToReturn.Title}' returned successfully.");

            return true;
        }
        else
        {
            Console.WriteLine("Thanks for using our services.");
            return false;
        }
    }

    public void ShowAvailableBooks()
    {
        Console.WriteLine("Available books in the library:");
        var availableBooks = libraryBooks.Where(b => b.Status == "Available").ToList();

        if (!availableBooks.Any())
        {
            Console.WriteLine("No books available at the moment.");
        }
        else
        {
            foreach (var book in availableBooks)
            {
                book.BookInformation();
                Console.WriteLine();
            }
        }
    }

    public void ShowBorrowedBooks()
    {
        Console.WriteLine("Borrowed books and their borrowers:");

        var borrowedBooks = libraryBooks.Where(b => b.Status == "Borrowed").ToList();

        if (!borrowedBooks.Any())
        {
            Console.WriteLine("No books are currently borrowed.");
            return;
        }

        foreach (var book in borrowedBooks)
        {
            var borrower = libraryUsers.FirstOrDefault(u => u.IdUser == book.IdBorrower);
            Console.WriteLine($"Book: {book.Title}");
            Console.WriteLine($"Borrowed by: {(borrower != null ? borrower.Name + " " + borrower.LastName : "Unknown user")}");
            Console.WriteLine();
        }
    }

    public void ShowBorrowedBooksByUser()
    {
        Console.WriteLine("Enter the user ID to see their borrowed books:");
        if (!int.TryParse(Console.ReadLine(), out int idUser))
        {
            Console.WriteLine("Invalid user ID.");
            return;
        }

        var user = libraryUsers.FirstOrDefault(u => u.IdUser == idUser);

        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        var borrowedBooks = libraryBooks.Where(b => b.IdBorrower == idUser && b.Status == "Borrowed").ToList();

        if (!borrowedBooks.Any())
        {
            Console.WriteLine($"User {user.Name} {user.LastName} has no borrowed books.");
            return;
        }

        Console.WriteLine($"Books borrowed by {user.Name} {user.LastName}:");
        foreach (var book in borrowedBooks)
        {
            book.BookInformation();
            Console.WriteLine();
        }
    }

    public string RegisterBook(Book book)
    {
        Console.WriteLine("Welcome to our library!");
        Console.WriteLine("To register a book with us, please provide the following information: ");

        Console.Write("What's the ISBN? ");
        if (!long.TryParse(Console.ReadLine(), out long isbn))
        {
            return "Invalid ISBN.";
        }

        Console.Write("What's the title of the book? ");
        string? title = Console.ReadLine();

        Console.Write("Who's the author of the book? ");
        string? author = Console.ReadLine();

        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
        {
            return "Title and author cannot be empty.";
        }

        book.SetBookInformation(isbn, title, author);
        book.Status = "Available";
        book.IdBorrower = 0;
        libraryBooks.Add(book);

        return "The book has been successfully registered.";
    }

    public string RegisterUser(User user)
    {
        Console.WriteLine("Welcome to our library!");
        Console.WriteLine("To register with us, please provide the following information: ");

        Console.Write("What's your ID? ");
        if (!int.TryParse(Console.ReadLine(), out int idUser))
        {
            return "Invalid ID.";
        }

        Console.Write("What's your first name? ");
        string? name = Console.ReadLine();

        Console.Write("What's your last name? ");
        string? lastName = Console.ReadLine();

        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName))
        {
            return "Name and last name cannot be empty.";
        }

        user.SetUserInformation(idUser, name, lastName);
        libraryUsers.Add(user);

        return "User registered successfully.";
    }
}
