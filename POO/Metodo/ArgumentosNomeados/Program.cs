using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentosNomeados
{
    internal class Program
    {
        static void Enviar(string destino, string titulo, string assunto)
        {
            Console.WriteLine($"{destino} - {titulo} - {assunto}");
        }
        static void Main(string[] args)
        {
            // defini o valor, passando o argumento e dois pontos
            Enviar(destino: "john@gmail.com", assunto: "Teste", titulo: "Urgente");
        }
    }
}
