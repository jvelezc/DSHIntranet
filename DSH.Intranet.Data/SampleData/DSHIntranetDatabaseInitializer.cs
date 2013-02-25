using DSH.Intranet.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Chad Corrin, 2/22/13 - Class for seeding in sample data
/// </summary>
namespace DSH.Intranet.Data
{
    public class DSHIntranetDatabaseInitializer : DropCreateDatabaseIfModelChanges<DSHIntranetDbContext>
    {
        protected override void Seed(DSHIntranetDbContext context)
        {
            #region Fields

            List<Security> security;

            #endregion

            #region Seed Methods

            security = new List<Security>
            {
                new Security { SecurityID = 1, Password = "ExposedPassword", UserName = "ExposedUsername"},
                new Security { SecurityID = 2, Password = "ExposedPassword2", UserName = "ExposedUsername2"},
                new Security { SecurityID = 3, Password = "ExposedPassword3", UserName = "ExposedUsername3"},
                new Security { SecurityID = 4, Password = "ExposedPassword4", UserName = "ExposedUsername4"},
                new Security { SecurityID = 5, Password = "ExposedPassword5", UserName = "ExposedUsername5"},
                new Security { SecurityID = 6, Password = "ExposedPassword6", UserName = "ExposedUsername6"}
            };

            security.ForEach(item => context.Security.Add(item));
            context.SaveChanges();

            #endregion
    }}
}
