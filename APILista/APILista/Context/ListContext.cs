using APILista.Entities;
using Microsoft.EntityFrameworkCore;


namespace APILista.Context;

public class ListContext : DbContext
{
	public ListContext(DbContextOptions<ListContext> options): base(options) {
		
	}
	
	public DbSet<People> People {get; set;}
	public DbSet<Animal> Animal {get; set;}
}