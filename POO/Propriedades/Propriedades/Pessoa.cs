using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    class Pessoa
    {
        private string nome;
        private string genero;
        private int idade;

        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; }

        public string Genero
        { 
            set
            {
                genero = value;
                System.Console.WriteLine(genero);
            }
        }

        public int Idade
        {
            set 
            {
                if(value < 18) 
                {
                    System.Console.WriteLine("Idade tem que ser maior que 18");
                }
                else 
                {
                    idade = value;
                }
            }
            get 
            {  
                return idade; 
            }
        }
    }
}
