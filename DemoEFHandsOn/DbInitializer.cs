using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DemoEFHandsOn
{
    public class DbInitializer:CreateDatabaseIfNotExists<CadCliDataContext>
    {
        protected override void Seed(CadCliDataContext context)
        {
            var clientes = new List<Cliente>() {
                new Cliente() { Nome = "Fabiano", Idade = 38},
                new Cliente() { Nome = "Priscila", Idade=39},
                new Cliente() { Nome = "Raphael", Idade = 18}
            };

            context.Cliente.AddRange(clientes);
            context.SaveChanges();
        }
    }
}
