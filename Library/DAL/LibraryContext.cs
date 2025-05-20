using Pomelo.EntityFrameworkCore.MySql; 
using Microsoft.EntityFrameworkCore;
using Library.Domain.Entities;

namespace Library.DAL;

public class LibraryContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<BookingBook> Bookings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Correct method name
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql( 
                "Server=localhost;Database=libname;User=root;Password=yourpassword;", 
                new MySqlServerVersion(new Version(9, 2, 0))); 
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.ToTable("books");
            entity.HasKey(b => b.idBook)
                .HasName("Book_PK");
            entity.Property(b => b.isbn)
                .IsRequired()
                .HasMaxLength(13)
                .HasColumnName("ISBN");
            entity.Property(b => b.title)
                .HasColumnName("Title")
                .IsRequired()
                .HasMaxLength(255);
            entity.Property(b => b.author)
                .HasColumnName("Author")
                .IsRequired()
                .HasMaxLength(255);
            
        });


        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users");
            entity.HasKey(u => u.idUser)
                .HasName("User_PK");
            entity.Property(u => u.name)
                .HasColumnName("FirstName")
                .IsRequired()
                .HasMaxLength(255);
            entity.Property(u => u.lastName)
                .HasColumnName("LastName")
                .IsRequired()
                .HasMaxLength(255);

        });


        modelBuilder.Entity<BookingBook>(entity =>
        {
            entity.ToTable("book_books");
            entity.HasKey(bb => bb.idBorrow)
                .HasName("BookingBook_PK");
            entity.Property(bb => bb.borrowDate)
                .HasColumnName("BorrowDate")
                .IsRequired();
            entity.Property(bb => bb.returnDate)
                .HasColumnName("ReturnDate");
        });

    }

}