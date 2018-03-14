using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEFHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            ObterTodos();
            //Adicionar();
            //Alterar();
            //Excluir();
            //ObterTodos();
            PesquisarPorNome();

            Console.ReadLine();

        }

        private static void PesquisarPorNome()
        {
            using (var ctx = new CadCliDataContext())
            {
                //var priscila = (from p in ctx.Cliente
                //               where p.Nome.Contains("Priscila")
                //               select p).FirstOrDefault();

                var priscila2 = ctx.Cliente.FirstOrDefault(p => p.Nome.Contains("Priscila"));

                if(priscila2!=null)
                    Console.WriteLine($"Achou o cliente de id: {priscila2.Id}");
            }
        }

        private static void Excluir()
        {
            using (var ctx = new CadCliDataContext())
            {
                var cli1 = ctx.Cliente.Find(1);
                ctx.Cliente.Remove(cli1);
                ctx.SaveChanges();
            }
        }

        private static void Alterar()
        {
            using (var ctx = new CadCliDataContext())
            {
                //var cli3 = ctx.Cliente.Find(3);
                //cli3.Nome = $"Cliente alterado - {DateTime.Now.ToShortTimeString()}";

                var cli1 = new Cliente() { Id=1, Nome = $"Cliente alterado - {DateTime.Now.ToShortTimeString()}", Idade= 20};
                ctx.Entry(cli1).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        private static void Adicionar()
        {
            var cliente = new Cliente() { Nome=$"Nome - {new Random().Next(100)}", Idade = new Random().Next(50)};

            using (var ctx = new CadCliDataContext())
            {
                ctx.Cliente.Add(cliente);
                ctx.SaveChanges();
            }

            Console.WriteLine($"Cliente {cliente.Nome} cadastrado com sucesso!");

        }

        private static void ObterTodos()
        {
            using (var ctx = new CadCliDataContext())
            {
                var clientes = ctx.Cliente.ToList();

                foreach (var cli in clientes)
                {
                    Console.WriteLine($"Id: {cli.Id} | Nome: {cli.Nome} | Idade: {cli.Idade}");
                }
            }
        }
    }
}
