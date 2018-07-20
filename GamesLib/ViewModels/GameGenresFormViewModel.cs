using System.Collections.Generic;
using GamesLib.Models;

namespace GamesLib.ViewModels
{
    public class GameGenresFormViewModel
    {
        public Game Game { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public IEnumerable<int> SelectedGenres { get; set; }
    }
}