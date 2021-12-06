using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Genre
    {
        public Genre()
        {
            Games = new List<Game>();
        }
        public int GenreId { get; set; }

        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
