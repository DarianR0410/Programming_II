namespace Library.Domain.Entities;

public class Library
{
    private Book book;
    private User user;
    private BookingBook _bookingBook;

    public Library()
    {
        book = new Book();
        user = new User();
        _bookingBook = new BookingBook();
    }
    
    public void BookingABook()
    {
        //borrowBook.BorrowingABook();
    }
    
    public void RegisterUser()
    {
        // Here comes the logic to register the users.
    }
    
    public void UserInformation()
    {
        user.UserInformation();
    }
    
    
    
}