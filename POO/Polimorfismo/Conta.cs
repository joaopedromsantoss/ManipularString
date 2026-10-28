using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
     class CaixaEletronico : IConta
    {
        public string usuario { get; set; }

        public void Depositar()
        {

        }

        public void Sacar()
        {

        }

        public void Saldo()
        {

        }

        public void SolicitarEmprestimo()
        {

        }
    }

    interface IConta
    {
        string usuario { get; set; }
        void Depositar();
        void Sacar();
        void Saldo();
    }
}
