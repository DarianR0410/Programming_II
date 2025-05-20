namespace Library.Domain.Entities;

public class BookingBook
{
    public int idBorrow { get; set; }
    public DateTime borrowDate { get; set; }
    public DateTime ? returnDate { get; set; }
    private Book book;
    private User user;
    

    public BookingBook()
    {
        
    }
    public BookingBook(Book book, User user)
    {
        book = new Book();
        user = new User();
        this.borrowDate = borrowDate;
        this.returnDate = returnDate;
    }

    public void BorrowingABook(String title, String isbn, String author)
    {
        Console.WriteLine("Welcome!");
        Console.WriteLine("Please provide us the name of the book you would like to take: ");
        title = Console.ReadLine();
        
        Console.WriteLine("I see the book you are looking for is...");
        Console.WriteLine("ISBN: "+ isbn);
        Console.WriteLine("Title: "+ title);
        Console.WriteLine("Author: "+ author);
        
        Console.WriteLine("Would you like to book this book? (y/n)");
        String answer = Console.ReadLine();

        if (answer.Equals("Y"))
        {
            Console.WriteLine("You have successfully borrowed the book.");
        }
        else
        {
            Console.WriteLine("Thanks for using our services!");
        }
    }

    public void ReturnABook()
    {
        // Here goes the logic of returning a book.
    }
    
    public void SetBorrowDate(DateTime date)
    {
        this.borrowDate = date;
    }
}