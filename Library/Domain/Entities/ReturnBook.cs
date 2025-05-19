namespace Library;

public class ReturnBook
{
    private DateTime returnDate { get; set; }
    
    private Book book;
    private User user;
    private BookingBook _bookingBook;
    
    public ReturnBook()
    {
        this.returnDate = returnDate;
        user = new User();
        book = new Book();
        _bookingBook = new BookingBook();
    }
    
    public void ReturnABook()
    {
        // Here goes the logic to return a book.
        Console.WriteLine("Book returned successfully.");
    }

    public void SetReturnDate(DateTime returnDate)
    {
        this.returnDate = returnDate;
    }
    
}