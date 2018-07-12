namespace GOTHouses.Migrations
{
    using GOTHouses.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GOTHouses.Models.GOTHousesDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GOTHouses.Models.GOTHousesDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var house = new List<Houses>
            {
                new Houses { Id=1, Name="", Symbol="", Description="" } 
                 
            };

            var character = new List<Characters>
                {

                new Characters{Id=1, Name="", Family="", HouseFK=1, Photo="", Video="",  Description=""}

            };
        }
    }
}
