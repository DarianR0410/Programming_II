namespace Library.Domain.Entities;

public class BorrowABook
{
	public Book book { get; set; }
	public User user { get; set; }
	public BookingBook bookingBook { get; set; }
	private List<Book> books;

	public BorrowABook()
	{
		book = new Book();
		user = new User();
		bookingBook = new BookingBook();
		books = new List<Book>();
	}

	public void BorrowBook()
	{
		// This will manage the logic to borrow a book.
	}
	
	public void ReturnBook()
	{
		// This will manage the logic to return a book.
	}

	public void AvailableBooks()
	{
		
	}

	public void RentedBooks()
	{
		
	}

	public void RegisterBooks()
	{
		Console.WriteLine("Welcome to our Library!");
		Console.WriteLine("To register a book, pleease enter the book information:");
		Console.Write("ISBN:");
		String isbn = Console.ReadLine();
		Console.Write("Title:");
		String title = Console.ReadLine();
		Console.Write("Author:");
		String author = Console.ReadLine();

		if (isbn.Length == 0 || title.Length == 0 || author.Length == 0)

		{
			throw new ArgumentException("Book information cannot be emptyy.");
		} else
		{
			books.Add(book);
		}
		
		books = new List<Book>
		{
			new Book("978-3-16-148410-0", "The Great Gatsby", "F. Scott Fitzgerald"),
			new Book("978-0-14-118263-6", "1984", "George Orwell"),
			new Book("978-0-06-112008-4", "To Kill a Mockingbird", "Harper Lee"),
			new Book("978-0-7432-7356-5", "The Catcher in the Rye", "J.D. Salinger"),
			new Book("978-0-395-19398-0", "The Lord of the Rings", "J.R.R. Tolkien"),
			new Book("978-0-452-28423-4", "Pride and Prejudice", "Jane Austen")
		};
	}
}