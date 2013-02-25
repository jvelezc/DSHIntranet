namespace DSH.Intranet.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    //the original method signature was
    //internal sealed class Configuration : DbMigrationsConfiguration<DSHIntranetDbContext>
    public class Configuration : DbMigrationsConfiguration<DSHIntranetDbContext>//this way I can add to Global.Asax
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;//lets me remove columns with data loss
        }

        protected override void Seed(DSH.Intranet.Data.DSHIntranetDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
