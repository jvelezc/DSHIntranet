using DSH.Intranet.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Chad Corrin, 2/22/13 - Main DB Context Class. Add in table mapping & dbsets below
/// </summary>
namespace DSH.Intranet.Data
{
    public class DSHIntranetDbContext : DbContext
    {
        // Declare Db sets
        public DbSet<Security> Security { get; set; }


        public DSHIntranetDbContext() : base(nameOrConnectionString: "DSHIntranet") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Use singular table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Map these class names to the table names in the created database
            modelBuilder.Entity<Security>().ToTable("Security");
        }
    }
}
