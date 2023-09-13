using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FilterApp.Models
{
    public class SoccerContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }

    public class SoccerDbInitializer : DropCreateDatabaseAlways<SoccerContext> {
        protected override void Seed(SoccerContext context)
        {
            Team t1 = new Team { Name = "TestTeam1"};
            Team t2 = new Team { Name = "TestTeam2"};
            context.Teams.Add(t1);
            context.Teams.Add(t2);
            context.SaveChanges();

            Player pl1 = new Player { Name = "TestPlayer1", Age = 24, Position = "TestPosition", Team = t1};
            Player pl2 = new Player { Name = "TestPlayer2", Age = 24, Position = "TestPosition", Team = t1};
            Player pl3 = new Player { Name = "TestPlayer3", Age = 24, Position = "TestPosition", Team = t2};
            Player pl4 = new Player { Name = "TestPlayer4", Age = 24, Position = "TestPosition", Team = t1};
            Player pl5 = new Player { Name = "TestPlayer5", Age = 24, Position = "TestPosition", Team = t2};
            Player pl6 = new Player { Name = "TestPlayer6", Age = 24, Position = "TestPosition", Team = t2};
            context.Players.AddRange(new List<Player> { pl1, pl2, pl3, pl4, pl5, pl6 });
            context.SaveChanges();
        }
    }
}