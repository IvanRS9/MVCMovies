using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCMovies.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; } = new List<Movie>();
        public SelectList? Genres { get; set; } = new SelectList(new List<string>());
        public string? MovieGenre { get; set; } = String.Empty;
        public string? SearchString { get; set; } = String.Empty;
    }
}
