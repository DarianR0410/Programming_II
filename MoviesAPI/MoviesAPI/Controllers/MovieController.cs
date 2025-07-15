using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Entities;
using MoviesAPI.Interfaces;


namespace MoviesAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieController : Controller
{
	public readonly IMovie _movieService;
	
	public MovieController(IMovie movieService)
	{
		this._movieService = movieService;
	}

	[HttpGet("GetListOfMovies")]
	public List<Movie> GetMovie()
	{
		return _movieService.GetMovies();
	}

	[HttpPost("AddMovies")]
	public void SetMovie(Movie movie)
	{
		_movieService.SetMovie(movie);
	}

	[HttpPut("UpdateMovies")]
	public void UpdateMovie(Movie movie)
	{
		_movieService.UpdateMovie(movie);
	}

	[HttpDelete("DeleteMovies")]
	public void DeleteMovie(int id)
	{
		_movieService.DeleteMovie(id);
	}
	
}