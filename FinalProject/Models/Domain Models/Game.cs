using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Game
    {
        public int GameId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1900, 3000, ErrorMessage = "Year must be after 1888.")]
        public int? Year { get; set; }
        
        [Required(ErrorMessage = "Please select a genre.")]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; }

    }
}

