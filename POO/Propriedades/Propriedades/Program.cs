using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("José");
            p1.Genero = "masculino";
            p1.Idade = 120;

            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Idade);
;        }
    }
}
