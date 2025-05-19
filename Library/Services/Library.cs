namespace Library;

public class Library
{
    private Book book;
    private User user;
    private BorrowBook borrowBook;
    private ReturnBook returnBook;
    private AvailableBooks availableBooks;

    public Library()
    {
        book = new Book();
        user = new User();
        borrowBook = new BorrowBook();
        returnBook = new ReturnBook();
        availableBooks = new AvailableBooks();
    }
    public void ShowAvailableBooks()
    {
        availableBooks.ShowAvailableBooks();
    }
    
    public void BookingABook()
    {
        //borrowBook.BorrowingABook();
    }
    
    public void ReturnABook()
    {
        returnBook.ReturnABook();
    }
    
    public void RegisterUser()
    {
        user.RegisterUser();
    }
    
    public void UserInformation()
    {
        user.UserInformation();
    }
    
    
    
}