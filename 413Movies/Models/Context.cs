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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Family" },
                new Category { CategoryId = 2, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 3, CategoryName = "Comedy" },
                new Category { CategoryId = 4, CategoryName = "Drama" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Television" },
                new Category { CategoryId = 7, CategoryName = "VHS" }
                );
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieId = 1,
                    CategoryId = 1,
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
                    CategoryId = 1,
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
                    CategoryId = 2,
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
