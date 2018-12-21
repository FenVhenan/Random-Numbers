namespace DWD273_W5_L3_CrawJessica.Migrations
{
    using DWD273_W5_L3_CrawJessica.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DWD273_W5_L3_CrawJessica.Models.RandNumDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DWD273_W5_L3_CrawJessica.Models.RandNumDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            
        }
    }
}
