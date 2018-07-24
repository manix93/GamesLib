using System.Collections.Generic;

namespace GamesLib.Models
{
    public class Translate
    {
        public int code { get; set; }
        public string lang { get; set; }
        public IList<string> text { get; set; }
    }
}