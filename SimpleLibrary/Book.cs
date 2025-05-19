using System;

namespace SimpleLibrary;

public class Book
{
	public long Isbn { get; set; }
	public string Title { get; set; } = string.Empty;
	public string Author { get; set; } = string.Empty;
	public string Status { get; set; } = "Available";
	public int IdBorrower { get; set; }

	public Book() {}

	public Book(long isbn, string title, string author)
	{
		Isbn = isbn;
		Title = title;
		Author = author;
	}

	public void BookInformation()
	{
		Console.WriteLine("ISBN: " + Isbn);
		Console.WriteLine("Title: " + Title);
		Console.WriteLine("Author: " + Author);
	}

	public void SetBookInformation(long isbn, string title, string author)
	{
		Isbn = isbn;
		Title = title;
		Author = author;
	}
}
