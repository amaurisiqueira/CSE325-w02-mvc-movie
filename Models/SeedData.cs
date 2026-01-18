using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
  public static void Initialize(IServiceProvider serviceProvider)
  {
    using (var context = new MvcMovieContext(
        serviceProvider.GetRequiredService<
            DbContextOptions<MvcMovieContext>>()))
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
        ReleaseDate = DateTime.Parse("1989-07-21"),  // Fecha real de estreno
        Genre = "Romantic Comedy",
        Rating = "R",
        Price = 7.99M
      },
new Movie
{
  Title = "Ghostbusters",
  ReleaseDate = DateTime.Parse("1984-06-08"),
  Genre = "Comedy",
  Rating = "PG",  // Era PG en 1984 (PG-13 no existía aún)
  Price = 8.99M
},
new Movie
{
  Title = "Ghostbusters 2",
  ReleaseDate = DateTime.Parse("1989-06-16"),
  Genre = "Comedy",
  Rating = "PG",
  Price = 9.99M
},
new Movie
{
  Title = "Rio Bravo",
  ReleaseDate = DateTime.Parse("1959-04-04"),
  Genre = "Western",
  Rating = "NR",  // Not Rated (películas antiguas pre-MPAA moderna no tenían rating obligatorio)
  Price = 3.99M
},
new Movie
{
  Title = "Back to the Future Part III",
  ReleaseDate = DateTime.Parse("1990-05-25"),
  Genre = "Western",
  Rating = "PG",
  Price = 4.99M
},
new Movie
{
  Title = "Cowboys & Aliens",
  ReleaseDate = DateTime.Parse("2011-07-29"),
  Genre = "Western",
  Rating = "PG-13",
  Price = 5.99M
},
new Movie
{
  Title = "Django Unchained",
  ReleaseDate = DateTime.Parse("2012-12-25"),
  Genre = "Western",
  Rating = "R",
  Price = 6.99M
},
new Movie
{
  Title = "The Revenant",
  ReleaseDate = DateTime.Parse("2015-12-25"),
  Genre = "Western",
  Rating = "R",
  Price = 7.49M
},
new Movie
{
  Title = "Hell or High Water",
  ReleaseDate = DateTime.Parse("2016-08-12"),
  Genre = "Western",
  Rating = "R",
  Price = 5.49M
}

      );
      context.SaveChanges();
    }
  }
}