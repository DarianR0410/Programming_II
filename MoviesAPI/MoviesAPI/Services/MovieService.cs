using Microsoft.EntityFrameworkCore;
using MoviesAPI.Context;
using MoviesAPI.Entities;
using MoviesAPI.Interfaces;

namespace MoviesAPI.Services;

public class MovieService : IMovie
{

	public readonly MovieAPIContext _context;

	public MovieService(MovieAPIContext context)
	{
		this._context = context;
	}
	
	public List<Movie> GetMovies()
	{
		return _context.Movie.ToList();
	}

	public void SetMovie(Movie movie)
	{
		_context.Add(movie);
		_context.SaveChanges();
	}

	public void UpdateMovie(Movie movie)
	{
		_context.Entry(movie).State = EntityState.Modified;
		_context.SaveChanges();
	}

	public void DeleteMovie(int id)
	{
		var remove = _context.Movie.Find(id);
		_context.Movie.Remove(remove);
		_context.SaveChanges();
	}
}