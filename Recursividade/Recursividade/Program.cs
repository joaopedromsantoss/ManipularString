using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recursiva recursiva = new Recursiva();
            recursiva.ExecutarRecursivo("Hello World!", 4);

            Console.ReadKey();
        }
    }
}
