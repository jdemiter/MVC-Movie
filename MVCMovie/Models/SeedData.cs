using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCmovie.Data;

namespace MVCmovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =
       new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                //look for any records, if there are records do nothing
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-01-11"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 7.99M
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    },
                     new Movie
                     {
                         Title = "Sunshine Cleaning",
                         ReleaseDate = DateTime.Parse("2009-3-7"),
                         Genre = "Comedy-Drama",
                         Price = 3.99M
                     },
                     new Movie
                     {
                         Title = "Welcome to Me",
                         ReleaseDate = DateTime.Parse("2014-9-5"),
                         Genre = "Drama",
                         Price = 10.99M
                     }
                     );
                context.SaveChanges();
            }
        }
    }
}