using MoviesAPI.Entities;

namespace MoviesAPI.Interfaces;

public interface IMovie
{
	List<Movie> GetMovies();
	void SetMovie(Movie movie);
	void UpdateMovie(Movie movie);
	void DeleteMovie(int id);
}