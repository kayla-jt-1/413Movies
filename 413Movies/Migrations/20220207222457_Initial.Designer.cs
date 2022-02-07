﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _413Movies.Models;

namespace _413Movies.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220207222457_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("_413Movies.Models.MovieResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(35);

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(35);

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT")
                        .HasMaxLength(35);

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Family",
                            Director = "Hayao Miyazaki",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Howl's Moving Castle",
                            Year = 2004
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Family",
                            Director = "Hayao Miyazaki",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "G",
                            Title = "Kiki's Delivery Service",
                            Year = 1989
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Fantasy/Adventure",
                            Director = "Hayao Miyazaki",
                            Edited = false,
                            Lent = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Porco Rosso",
                            Year = 1992
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
