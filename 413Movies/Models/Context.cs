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
                new Category { CategoryId = 1, CategoryName = "Family" }
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
                    CategoryId = 1,
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
