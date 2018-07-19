using System.Collections.Generic;

namespace GamesLib.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}