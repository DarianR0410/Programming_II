namespace Library;

public class ReturnBook
{
    private DateTime returnDate { get; set; }
    
    private Book book;
    private User user;
    private Booking booking;

    public ReturnBook()
    {
        this.returnDate = returnDate;
        user = new User();
        book = new Book();
        booking = new Booking();
    }
    
    public void ReturnABook()
    {
        // Here goes the logic to return a book.
        Console.WriteLine("Book returned successfully.");
    }
    
}