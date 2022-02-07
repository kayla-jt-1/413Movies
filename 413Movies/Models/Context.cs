using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413Movies.Models
{
    public class Context : DbContext 
    {
        //constructor
        public Context (DbContextOptions<Context> options) : base (options) 
        { 
            //leave blank for now
        }
        public DbSet<MovieResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieId = 1,
                    Category = "Family",
                    Title = "Howl's Moving Castle",
                    Year = 2004,
                    Director = "Hayao Miyazaki",
                    Rating = "PG",
                    Edited = false,
                    Lent = "",
                    Notes = "",
                },
                new MovieResponse
                {
                    MovieId = 2,
                    Category = "Family",
                    Title = "Kiki's Delivery Service",
                    Year = 1989,
                    Director = "Hayao Miyazaki",
                    Rating = "G",
                    Edited = false,
                    Lent = "",
                    Notes = "",
                },
                new MovieResponse
                {
                    MovieId = 3,
                    Category = "Fantasy/Adventure",
                    Title = "Porco Rosso",
                    Year = 1992,
                    Director = "Hayao Miyazaki",
                    Rating = "PG",
                    Edited = false,
                    Lent = "",
                    Notes = "",
                }
            ); ;
        }
    }
}
