namespace Library.Domain.Entities;

public class Book
{
    public int idBook { get; set; }
    public String isbn { get; set; }
    public String title { get; set; }
    public String author {get; set; }
    

    public Book()
    {
        
    }
    
    public Book(String isbn, String title, String author)
    {
        this.isbn = isbn;
        this.author = author;
        this.title = title;

    }

    public void BookInformation()
    {
        Console.WriteLine("ISBN: " + isbn);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        
    }

    public void SetBookInformation(String isbn, String title, String author)
    {
        this.isbn = isbn;
        this.title = title;
        this.author = author;
    }
    
}