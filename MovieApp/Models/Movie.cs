using System;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required, MaxLength(250)]
        public string Titel { get; set; }

        public int Year { get; set; }

        public double Rate { get; set; }

        [Required, MaxLength(250)]

        public String Storeline { get; set; }
        [Required]
        public byte[] poster { get; set; }

        public byte GenreId { get; set; }
        public byte Genre { get; set; }


    }
}
