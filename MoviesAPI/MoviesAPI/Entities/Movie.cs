using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesAPI.Entities;

public class Movie
{
	[Key]
	[Column("IdMovie")]
	public int IdMovie { get; set; }
	public string Title { get; set; }
	public string ReleaseYear { get; set; }
	public string Genre { get; set; }
	public string Director { get; set; }
	public int Rate { get; set; }
	public string MovieUrl { get; set; }
	public string TrailerUrl { get; set; }
}