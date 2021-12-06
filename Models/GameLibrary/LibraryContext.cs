using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameBaseSite.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }


        public DbSet<GameModel> Games { get; set; }

        //public DbSet<UserGameModel> UserGames { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameModel>().HasData(
                new GameModel
                {
                    GameId = 1,
                    Title = "Quake",
                    Genre = "First Person Shooter",
                    EsrbRating = "M",
                    UserRating = 10,
                    Status = "",
                    Review = "",
                    Type = "Power",

                },
                new GameModel
                {
                    GameId = 2,
                    Title = "Crusader Kings III",
                    Genre = "Paradox Grand Strategy",
                    EsrbRating = "M",
                    UserRating = 9,
                    Status = "",
                    Review = "",
                    Type = "Brainy",
                },

                new GameModel
                {
                    GameId = 3,
                    Title = "Vegas Casino Collections",
                    Genre = "Casino Games",
                    EsrbRating = "T",
                    UserRating = 5,
                    Status = "",
                    Review = "",
                    Type = "Casual",
                },
                new GameModel
                {
                    GameId = 4,
                    Title = "Waluigi World 2",
                    Genre = "2d Platformer",
                    EsrbRating = "E",
                    UserRating = 10,
                    Status = "",
                    Review = "",
                    Type = "OldSchool",
                },
                new GameModel
                {
                    GameId = 5,
                    Title = "Escape From Tarkov",
                    Genre = "Survival Horro, First Person Shooter",
                    EsrbRating = "M",
                    UserRating = 9,
                    Status = "",
                    Review = "",
                    Type = "Power",
                },
                new GameModel
                {
                    GameId = 6,
                    Title = "Bloons TD -1",
                    Genre = "Tower Defense",
                    EsrbRating = "E",
                    UserRating = 7,
                    Status = "",
                    Review = "",
                    Type = "Casual",
                },
                new GameModel
                {
                    GameId = 7,
                    Title = "The Initiate",
                    Genre = "Adventure Puzzle",
                    EsrbRating = "T",
                    UserRating = 6,
                    Status = "",
                    Review = "",
                    Type = "Brainy",
                },
                new GameModel
                {
                    GameId = 8,
                    Title = "Mr.Peck-Mon",
                    Genre = "Arcade",
                    EsrbRating = "E",
                    UserRating = 4,
                    Status = "",
                    Review = "",
                    Type = "OldSchool",
                }
                ) ;           
        }
      
    }
}
