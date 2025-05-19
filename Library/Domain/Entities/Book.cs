namespace Library;

public class Book
{
    private int idBook { get; set; }
    private String isbn { get; set; }
    private String title { get; set; }
    private String author { get; set; }
    
    public Book()
    {
        this.idBook = idBook;
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