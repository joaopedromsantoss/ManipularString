using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Metodo
{
    internal class Program
    {
        static public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static public double Somar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        static public int Somar(int numero1, int numero2, int numero3)
        {
            return numero1 + numero2 + numero3;
        }

        static public int Somar(params int[] numeros)
        {
            var resultado = 0;
            foreach (var numero in numeros) 
                resultado = resultado + numero;
            return resultado;
        }

        static void Main(string[] args)
        {
            var resultado1 = Somar(100, 200);

            Console.ReadLine();

        }
    }
}
