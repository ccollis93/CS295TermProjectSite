using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameBaseSite.Models.Database
{
    public static class SeedData
    {
        public static List<UserModel> GetUsers()
        {
            List<UserModel> users = new List<UserModel>();

            users.Add(new UserModel
            {
                UserId = "111",
                UserName = "GameDude01",
                PlayStyle = "Power",
                FavoriteGame = "PC Building Simulator"
            });

            users.Add(new UserModel
            {
                UserId = "222",
                UserName = "starchild",
                PlayStyle = "Brainy",
                FavoriteGame = "The Impossible Game"
            });

            users.Add(new UserModel
            {
                UserId = "333",
                UserName = "MomOfThree",
                PlayStyle = "Casual",
                FavoriteGame = "Candy Crush"
            });

            users.Add(new UserModel
            {
                UserId = "444",
                UserName = "corvetteFan1963",
                PlayStyle = "OldSchool",
                FavoriteGame = "Asteroids"
            });

            return users;
        }

        public static List<UserGameModel> GetUserGames()
        {
            List<UserGameModel> userGames = new List<UserGameModel>();

            userGames.Add(new UserGameModel
            {
                GameId = "1",
                UserId = "222",
                 Title = "Quake"
            });

            userGames.Add(new UserGameModel
            {
                GameId = "2",
                UserId = "111",
                Title = "Crusader Kings III",
            });

            userGames.Add(new UserGameModel
            {
                GameId = "5",
                UserId = "111",
                Title = "Escape From Tarkov"

            });

            userGames.Add(new UserGameModel
            {
                GameId = "2",
                UserId = "222",
                Title = "Crusader Kings III",
            });

            userGames.Add(new UserGameModel
            {
                GameId = "4",
                UserId = "222",
                Title = "Waluigi World 2"
            });

            userGames.Add(new UserGameModel
            {
                GameId = "7",
                UserId = "111",
                Title = "The Initiate",
            });

            userGames.Add(new UserGameModel
            {
                GameId = "6",
                UserId = "333",
                Title = "Bloons TD -1"
            });

            userGames.Add(new UserGameModel
            {
                GameId = "3",
                UserId = "333",
                Title = "Vegas Casino Collections"
            });

            userGames.Add(new UserGameModel
            {
                GameId = "8",
                UserId = "444",
                Title = "Mr.Peck-Mon"
            });

            userGames.Add(new UserGameModel
            {
                GameId = "4",
                UserId = "444",
                Title = "Waluigi World 2"
            });

            userGames.Add(new UserGameModel
            {
                GameId = "1",
                UserId = "444",
                Title = "Quake",
            });

            return userGames;
        }

        
        public static List<GameModel> GetGames()
        {
            List<GameModel> games = new List<GameModel>();

            games.Add(new GameModel
            {
                GameId = "1",
                Title = "Quake",
                Genre = "First Person Shooter",
                EsrbRating = "M",                            
                Type = "Power"
            });

            games.Add(new GameModel
            {
                GameId = "2",
                Title = "Crusader Kings III",
                Genre = "Paradox Grand Strategy",
                EsrbRating = "M",
                Type = "Brainy"
            });

            games.Add(new GameModel
            {
                GameId = "3",
                Title = "Vegas Casino Collections",
                Genre = "Casino Games",
                EsrbRating = "T",
                Type = "Casual"
            });

            games.Add(new GameModel
            {
                GameId = "4",
                Title = "Waluigi World 2",
                Genre = "2d Platformer",
                EsrbRating = "E",
                Type = "OldSchool"
            });

            games.Add(new GameModel
            {
                GameId = "5",
                Title = "Escape From Tarkov",
                Genre = "Survival Horror",
                EsrbRating = "M",
                Type = "Power"
            });

            games.Add(new GameModel
            {
                GameId = "6",
                Title = "Bloons TD -1",
                Genre = "Tower Defense",
                EsrbRating = "E",
                Type = "Casual"
            });

            games.Add(new GameModel
            {
                GameId = "7",
                Title = "The Initiate",
                Genre = "Adventure Puzzle",
                EsrbRating = "T",
                Type = "Brainy"
            });

            games.Add(new GameModel
            {
                GameId = "8",
                Title = "Mr.Peck-Mon",
                Genre = "Arcade",
                EsrbRating = "E",
                Type = "OldSchool"
            });

            return games;
        }

        public static List<ProfileGameModel> GetProfileGames()
        {
            List<ProfileGameModel> profileGames = new List<ProfileGameModel>();

            profileGames.Add(new ProfileGameModel
            {
                GameId = "4",
                Title = "Waluigi World 2",
                Genre = "2d Platformer",
                EsrbRating = "E",
                Type = "OldSchool"
            });

            profileGames.Add(new ProfileGameModel
            {
                GameId = "5",
                Title = "Escape From Tarkov",
                Genre = "Survival Horror",
                EsrbRating = "M",
                Type = "Power"
            });

            profileGames.Add(new ProfileGameModel
            {
                GameId = "2",
                Title = "Crusader Kings III",
                Genre = "Paradox Grand Strategy",
                EsrbRating = "M",
                Type = "Brainy"
            });

            profileGames.Add(new ProfileGameModel
            {
                GameId = "3",
                Title = "Vegas Casino Collections",
                Genre = "Casino Games",
                EsrbRating = "T",
                Type = "Casual"
            });

            return profileGames;
        }
    }
}
