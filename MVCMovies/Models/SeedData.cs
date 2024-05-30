using Microsoft.EntityFrameworkCore;
using MVCMovies.Data;

namespace MVCMovies.Models
{
	public class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new MVCMoviesContext(
				serviceProvider.GetRequiredService<
					DbContextOptions<MVCMoviesContext>>()))
			{
				// Look for any movies.
				if (context.Movie.Any())
				{
					return;   // DB has been seeded
				}
				context.Movie.AddRange(
					new Movie
					{
						Title = "When Harry Met Sally",
						RelaseDate = DateTime.Parse("1989-2-12"),
						Description = "NR",
						Genre = "Romantic Comedy",
						Price = 7.99M,
						Rating = "R"
					},
					new Movie
					{
						Title = "Ghostbusters ",
						RelaseDate = DateTime.Parse("1984-3-13"),
						Description = "NR",
						Genre = "Comedy",
						Price = 8.99M,
						Rating = "R"
					},
					new Movie
					{
						Title = "Ghostbusters 2",
						RelaseDate = DateTime.Parse("1986-2-23"),
						Description = "NR",
						Genre = "Comedy",
						Price = 9.99M,
						Rating = "R"
					},
					new Movie
					{
						Title = "Rio Bravo",
						RelaseDate = DateTime.Parse("1959-4-15"),
						Description = "NR",
						Genre = "Western",
						Price = 3.99M,
						Rating = "R"
					}
				);
				context.SaveChanges();
			}
		}
	}
}
