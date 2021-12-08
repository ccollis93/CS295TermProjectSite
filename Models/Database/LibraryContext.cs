using GameBaseSite.Models.Database;
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
        //creates the context for the "Library" which is the database I use to store the site's data
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }


        //User Table
        public DbSet<UserModel> User { get; set; }

        //Game Table
        public DbSet<GameModel> Games { get; set; }

        //UserGames Table
        public DbSet<UserGameModel> UsrGames { get; set; }

        public DbSet<ProfileGameModel> ProfileGames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //populate the User table from SeedData
            modelBuilder.Entity<UserModel>().HasData(SeedData.GetUsers());

            //populate the game table from SeedData          
            modelBuilder.Entity<GameModel>().HasData(SeedData.GetGames());

            //populate the UserGame table from SeedData
            modelBuilder.Entity<UserGameModel>().HasKey(u => new { u.UserId, u.GameId});
            modelBuilder.Entity<UserGameModel>().HasData(SeedData.GetUserGames());

            
            modelBuilder.Entity<ProfileGameModel>().HasData(SeedData.GetProfileGames());
           

            

            /*  This is now in SeedData. Saving this here in case it doesn't work
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
                      Type = "Power"
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
                      Type = "Brainy"
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
                      Type = "Casual"
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
                      Type = "OldSchool"
                  },
                  new GameModel
                  {
                      GameId = 5,
                      Title = "Escape From Tarkov",
                      Genre = "Survival Horror",
                      EsrbRating = "M",
                      UserRating = 9,
                      Status = "",
                      Review = "",
                      Type = "Power"
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
                      Type = "Casual"
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
                      Type = "Brainy"
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
                      Type = "OldSchool"
                  }
                  );
              */
        }
             
    }
}
