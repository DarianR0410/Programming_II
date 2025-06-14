using Data;
using Domain.Entities;

namespace Business;

public class Library
{
	public BookDal BookDal;
	public UserDal UserDal;

	public Library()
	{
		BookDal = new BookDal();
		UserDal = new UserDal();
	}

	public bool BorrowBook()
	{
		return BookDal.BorrowBook();
	}

	public bool ReturnBook()
	{
		return BookDal.ReturnBook(); 
	}

	public void ShowAvailableBooks()
	{
		 BookDal.ShowAvailableBooks();
	}

	public void ShowBorrowedBooks()
	{
		BookDal.ShowBorrowedBooks();
	}

	public void ShowBorrowedBooksByUser()
	{
		BookDal.ShowBorrowedBooksByUser();
	}

	public string RegisterBook(Book book)
	{
		return BookDal.RegisterBook(book);
	}

	public string RegisterUser(User user)
	{
		return UserDal.RegisterUser(user);
	}
}