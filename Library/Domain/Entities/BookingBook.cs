using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Domain.Entities;

[Table ("BookingBook")]
public class BookingBook
{
    [Column ("idBorrow")]
    [Key]
    public int idBorrow { get; set; }
    [Column ("borrowDate")]
    public DateTime borrowDate { get; set; }
    [Column ("returnDate")]
    public DateTime ? returnDate { get; set; }
    
    [Column ("idBook")]
    [ForeignKey("book_FK")]
    public int idBook { get; set; }
    
    public Book book { get; set; }
    
    [Column ("idUser")]
    [ForeignKey("user_FK")]
    public int idUser { get; set; }
    
    public User user { get; set; }
    

    public BookingBook()
    {
        
    }
    
}