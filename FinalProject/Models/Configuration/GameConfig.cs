using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class GameConfig : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> entity)
        {
            entity.HasData(
                    new Game { GameId = 1, Name = "Stardew Valley", Year = 2016, GenreId = 1, Description = "A farming simulation game primarily inspired by the Harvest Moon video game series. At the start of the game, players create a character, who becomes the recipient of a plot of land and a small house once owned by their grandfather in a small town called Pelican Town." },
                    new Game { GameId = 2, Name = "Northgard", Year = 2018, GenreId = 2, Description = "A strategy game based on Norse mythology in which you control a clan of Vikings vying for the control of a mysterious newfound continent." },
                    new Game { GameId = 3, Name = "Valorant", Year = 2020, GenreId = 3, Description = "A tactical shooting game involving two teams with 5 players in each team. Every player can sign in and play remotely from anywhere in the world. Every game has 25 rounds and the team that wins 13 of them first wins the game. Players can choose their in-game characters called agents at the start of the game." },
                    new Game { GameId = 4, Name = "League of Legends", Year = 2009, GenreId = 4, Description = "A team-based strategy game where two teams of five powerful champions face off to destroy the other's base. Choose from over 140 champions to make epic plays, secure kills, and take down towers as you battle your way to victory." },
                    new Game { GameId = 5, Name = "The Elder Scrolls V: Skyrim", Year = 2011, GenreId = 5, Description = "An action role-playing game, playable from either a first or third-person perspective. The player may freely roam over the land of Skyrim—an open world environment consisting of wilderness expanses, dungeons, caves, cities, towns, fortresses, and villages." },
                    new Game { GameId = 6, Name = "Madden NFL 19", Year = 2018, GenreId = 6, Description = "An American football sports video game based on the National Football League (NFL), developed and published by EA Sports." },
                    new Game { GameId = 7, Name = "Tetris", Year = 1984, GenreId = 7, Description = "A tile-matching puzzle game, developed in the Soviet Union in 1984. The game has a simple goal of destroying lines of block before it reaches the top." },
                    new Game { GameId = 8, Name = "Assassin's Creed Origins", Year = 2017, GenreId = 8, Description = "An action-adventure stealth game played from a third-person perspective. Players complete quests—linear scenarios with set objectives to progress through the story. ... As the players explore the world, they encounter different non-playable characters who need assistance from Bayek." },
                    new Game { GameId = 9, Name = "Until Dawn", Year = 2015, GenreId = 9, Description = "A 2015 interactive drama horror video game developed by Supermassive Games and published by Sony Computer Entertainment for the PlayStation 4. Players assume control of eight young adults who have to survive on Blackwood Mountain when their lives are threatened. The game features a hyperlink cinema-esque for its multilinear narratives and butterfly effect system in which players must make choices that may change the story. All playable characters can survive or die, depending on the choices made. Players explore the environment from a third-person perspective and find clues that may help solve the mystery." },
                    new Game { GameId = 10, Name = "Hollow Knight", Year = 2017, GenreId = 10, Description = "A 2D Metroidvania action-adventure game, that takes place in Hallownest, a fictional ancient kingdom. The player controls an insect-like, silent, and nameless knight while exploring the underground world." }
                );
        }
    }
}
