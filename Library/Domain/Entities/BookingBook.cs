namespace Library;

public class BookingBook
{ 
    private DateTime borrowDate { get; set; }
    
    private Book book;
    private User user;
    
    public BookingBook()
    {
        book = new Book();
        user = new User();
        this.borrowDate = borrowDate;
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
    
    public void SetBorrowDate(DateTime date)
    {
        this.borrowDate = date;
    }
}