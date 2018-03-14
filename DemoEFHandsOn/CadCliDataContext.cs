using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEFHandsOn
{
    public class CadCliDataContext: DbContext
    {
        public CadCliDataContext():base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DemoEF6HandsOn;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Cliente> Cliente { get; set; }

    }
}
