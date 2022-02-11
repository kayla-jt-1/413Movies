using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _413Movies.Models
{
    public class MovieResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; } //Primary key
        [Required]
        [MaxLength(35)]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        [MaxLength(35)]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }



        //optional fields
        public bool Edited { get; set; }
        [MaxLength(35)]
        public string Lent { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
