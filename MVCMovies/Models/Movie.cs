using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovies.Models
{
	public class Movie
	{
		public int Id { get; set; }
		[Display(Name = "Movie Title")]
		public string? Title { get; set; }
		[Display(Name = "Movie Description")]
		public string? Description { get; set; }
		[Display(Name = "Release Date")]
		[DataType(DataType.Date)]
		public DateTime RelaseDate { get; set; }
		[Display(Name = "Movie Genre")]
		public string? Genre { get; set; }
		[Display(Name = "Movie Price")]
		[Column(TypeName = "decimal(18, 2)")]
		public decimal Price { get; set; }
		public string? Rating { get; set; }
	}
}
