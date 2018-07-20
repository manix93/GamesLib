using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GamesLib.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}