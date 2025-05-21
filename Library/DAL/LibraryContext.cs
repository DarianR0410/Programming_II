using Pomelo.EntityFrameworkCore.MySql; 
using Microsoft.EntityFrameworkCore;
using Library.Domain.Entities;

namespace Library.DAL;

public class LibraryContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<BookingBook> Bookings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql( 
                "Server=localhost;Database=libname;User=root;Password=Darian0110;", 
                new MySqlServerVersion(new Version(9, 2, 0))); 
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }

}