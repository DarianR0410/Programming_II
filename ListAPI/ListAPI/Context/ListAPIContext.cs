using ListAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListAPI.Context;

public class ListAPIContext : DbContext
{
	public ListAPIContext(DbContextOptions<ListAPIContext> options): base(options) {
		
	}
	
	public DbSet<People> People {get; set;}
	public DbSet<Animal> Animal {get; set;}
	
}