using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\nWelcome to our library!");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Register a new user");
                Console.WriteLine("2. Register a new book");
                Console.WriteLine("3. Borrow a book");
                Console.WriteLine("4. Return a book");
                Console.WriteLine("5. Show available books");
                Console.WriteLine("6. Show all borrowed books and borrowers");
                Console.WriteLine("7. Show borrowed books by a specific user");
                Console.WriteLine("8. Exit");
                Console.Write("Select an option: ");

                string? option = Console.ReadLine();
                if (!int.TryParse(option, out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 8.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        User newUser = new User();
                        Console.WriteLine(library.RegisterUser(newUser));
                        break;

                    case 2:
                        Book newBook = new Book();
                        Console.WriteLine(library.RegisterBook(newBook));
                        break;

                    case 3:
                        library.BorrowBook();
                        break;

                    case 4:
                        library.ReturnBook();
                        break;

                    case 5:
                        library.ShowAvailableBooks();
                        break;

                    case 6:
                        library.ShowBorrowedBooks();
                        break;

                    case 7:
                        library.ShowBorrowedBooksByUser();
                        break;

                    case 8:
                        Console.Write("Would you like to exit? (Y/N): ");
                        string? answer = Console.ReadLine();

                        if (!string.IsNullOrEmpty(answer) && answer.Trim().ToUpper() == "Y")
                        {
                            Console.WriteLine("Thanks for using our services. Goodbye!");
                            isRunning = false;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}