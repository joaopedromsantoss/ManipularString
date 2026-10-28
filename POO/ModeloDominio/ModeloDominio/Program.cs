using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClienteRico cliente = new ClienteRico(5,"",null);

            Console.WriteLine($"{cliente.Id} {cliente.Nome} {cliente.Endereco}");
            Console.ReadLine();
        }

        //private static ClienteAnemico ClienteAnemicoTeste()
        //{
        //    ClienteAnemico cliente = new ClienteAnemico();
        //    cliente.Id = -1;
        //    cliente.Nome = "";
        //    cliente.Endereco = null;

        //    Console.WriteLine($"{cliente.Id} {cliente.Nome} {cliente.Endereco}");
        //    Console.ReadLine();
        //}
    }
}
