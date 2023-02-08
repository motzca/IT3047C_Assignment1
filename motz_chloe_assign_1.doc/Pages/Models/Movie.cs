﻿using System;
using System.ComponentModel.DataAnnotations;

namespace motz_chloe_assign_1.doc.Pages.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1889, 2050, ErrorMessage = "Year must be between 1889 and now.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Please enter a genre.")]
        public string GenreId { get; set; }
        public Genre Genre { get; set; }

        public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();
    }
}
