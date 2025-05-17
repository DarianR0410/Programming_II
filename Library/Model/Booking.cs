namespace Library;

public class Booking
{ 
    private DateTime bookingDate { get; set; }
    
    private Book book;
    private User user;
    
    public Booking()
    {
        book = new Book();
        user = new User();
        this.bookingDate = bookingDate;
    }

    public void BookingABook()
    {
        // Here goes the logic to book a book.
    }
}