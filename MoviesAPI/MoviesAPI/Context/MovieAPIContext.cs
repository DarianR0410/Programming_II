using Microsoft.EntityFrameworkCore;
using MoviesAPI.Entities;

namespace MoviesAPI.Context;

public class MovieAPIContext : DbContext
{
	public MovieAPIContext(DbContextOptions<MovieAPIContext> options) : base(options)
	{
		
	}
	
	public DbSet<Movie> Movie { get; set; }
}