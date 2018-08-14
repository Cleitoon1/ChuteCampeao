namespace ChuteCampeao.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Context.ChuteCampeaoContext>
    {
        public Configuration()
        {
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.ChuteCampeaoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
