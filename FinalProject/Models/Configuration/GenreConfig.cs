using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> entity)
        {
            entity.HasData(
                    new Genre { GenreId = 1, Name = "Sandbox" },
                    new Genre { GenreId = 2, Name = "RTS" },
                    new Genre { GenreId = 3, Name = "FPS" },
                    new Genre { GenreId = 4, Name = "MOBA" },
                    new Genre { GenreId = 5, Name = "RPG" },
                    new Genre { GenreId = 6, Name = "Sports" },
                    new Genre { GenreId = 7, Name = "Puzzle" },
                    new Genre { GenreId = 8, Name = "Action-Adventure" },
                    new Genre { GenreId = 9, Name = "Horror" }
                    new Genre { GenreId = 10, Name = "Platformer" }
                );
        }
    }
}
