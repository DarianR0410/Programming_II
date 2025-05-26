using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Domain.Entities;

[Table ("Books")]
public class Book
{
    [Column ("idBook" , TypeName = "int")]
    public int idBook { get; set; }
    [Column ("isbn", TypeName = "varchar(255)")]
    public String isbn { get; set; } 
    [Column ("title", TypeName = "varchar(255)")]
    public String title { get; set; }
    [Column ("author", TypeName = "varchar(255)")]
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