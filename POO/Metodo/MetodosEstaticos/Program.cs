using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Soma = " + Calculadora.Somar(8, 2));
            Console.WriteLine("Subtração = " + Calculadora.Subtrair(8, 2));

            Console.ReadLine();
        }
    }
}
