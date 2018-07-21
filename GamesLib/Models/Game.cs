using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GamesLib.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public ICollection<Genre> Genres { get; set; }
    }
}