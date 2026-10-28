using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosOpcionais
{
    internal class Program
    {
        static int Somar(int x, int y=20, int z = 30, int w = 40)
        {
            return x + y + z + w;
        }
        static void Main(string[] args)
        {
            var resultado1 = Somar(100);
            var resultado2 = Somar(100,200);
            var resultado3 = Somar(100,200,300);
            var resultado4 = Somar(100, 200, 300,400);

            Console.WriteLine($"{resultado1}");
            Console.WriteLine($"{resultado2}");
            Console.WriteLine($"{resultado3}");
            Console.WriteLine($"{resultado4}");
        }
    }
}
