using System.Collections.Generic;
using GamesLib.Models;

namespace GamesLib.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GamesLib.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GamesLib.Models.ApplicationDbContext context)
        {
            #region GENRES
            context.Genres.AddOrUpdate(c => c.Id,
                new Genre() { Name = "MMO"},
                new Genre() { Name = "Simulation"},
                new Genre() { Name = "Stealth"},
                new Genre() { Name = "Adventure"},
                new Genre() { Name = "RTS"},
                new Genre() { Name = "Action"},
                new Genre() { Name = "Combat"},
                new Genre() { Name = "FPS"},
                new Genre() { Name = "Sport"},
                new Genre() { Name = "Racing"},
                new Genre() { Name = "RPG"}
            );
            #endregion

            context.Games.AddOrUpdate(g => g.Id,
                new Game()
                {
                    Title = "World of Warcraft",
                    Description = "World of Warcraft® is an online role-playing experience set in the award-winning Warcraft universe. Players assume the roles of Warcraft heroes as they explore, adventure, and quest across a vast world. Being \"Massively Multiplayer,\" World of Warcraft allows thousands of players to interact within the same world. Whether adventuring together or fighting against each other in epic battles, players will form friendships, forge alliances, and compete with enemies for power and glory.",
                    ReleaseDate = new DateTime(2004, 10, 1),
                    Genres = new List<Genre>()
                    {
                        context.Genres.SingleOrDefault(c => c.Name.Equals("MMO")),
                        context.Genres.SingleOrDefault(c => c.Name.Equals("Action")),
                        context.Genres.SingleOrDefault(c => c.Name.Equals("RPG"))
                    }
                }
                );
        }
    }
}
