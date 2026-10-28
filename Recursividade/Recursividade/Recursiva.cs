using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Recursiva
    {
        // Método não recursivo
        public void Executar(string mensagem, int qtde)
        {
            for(int i = 0; i < qtde; i++)
            {
                Console.WriteLine(mensagem);
            }
        }
    
        // Método recursivo
        public void ExecutarRecursivo(string mensagem, int qtde)
        {
            if (qtde > 0)
            {
                Console.WriteLine(mensagem);
                ExecutarRecursivo(mensagem, qtde - 1);
            }
        }
    }
}
