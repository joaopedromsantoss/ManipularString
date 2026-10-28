using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Contains / String
            //string texto = "Este tipo de variável é alfanumérica.";

            //if (texto.Contains("tipo"))
            //{
            //  label1.Text = "Contém.";
            //}
            //else
            //{
            //    label1.Text = "Não contém.";
            //}
            #endregion

            #region To Upper
            //string nome = "joao";

            //string nomeMaiusculo = nome.ToUpper();

            //label1.Text = nomeMaiusculo;
            #endregion

            #region To Lower
            //string nome = "Joao";

            //string nomeMin = nome.ToLower();

            //label1.Text = nomeMin;
            #endregion

            #region IndexOf / LastIndexOf
            //string nome = "Gabriel Artigas";

            //int indice = nome.IndexOf('a', 5, 4);

            //int indice = nome.LastIndexOf('a');

            //label1.Text = "Indice: " + indice;

            #endregion

            #region Insert / Replace
            //string nome = "Gabriel Artigas";

            //string nomeFinal = nome.Insert(7, " Lucas");

            //string nomeFinal = nome.Replace("Artigas", "Silva");

            //label1.Text = nomeFinal;
            #endregion

            #region Length / SubString
            //string nome = "Juliana";

            //int tam = nome.Length;
            //label1.Text = "O nome " + nome + " contém " + tam + " letras";

            //for (int i = 0; i < nome.Length; i++)
            //{
            //label1.Text += nome[i] + "\n";
            //}

            //string parte = nome.Substring(0, 7);
            //string parte = nome.Substring(nome.IndexOf(" "));
            //label1.Text = parte;
            #endregion

            #region Split
            //string nomes = "Frederico_+_Alfredo_+_Affonso_+_Glória";

            //string[] separador = { "_+_" };

            //string[] res = nomes.Split(separador, StringSplitOptions.None);

            //foreach (string nome in res)
            //{
            //    label1.Text += nome + "\n";
            //}
            #endregion

            #region StartsWith / EndsWith
            //string nome = "Manoel";

            //bool res = nome.StartsWith("man", StringComparison.OrdinalIgnoreCase);

            //bool res = nome.EndsWith("el", StringComparison.OrdinalIgnoreCase);
            //if (res)
            // {
            //label1.Text = "Positivo";

            //}
            //else 
            //{
            //label1.Text = "Negativo";
            //}
            #endregion

            #region Trim / TrimStart / TrimEnd

            //string mensagem = " -_5  Olá Mário _--   ";
            //char[] c = { ' ', '-', '_', '5' };
            //label1.Text = ">" + mensagem.Trim(c) + "<";

            //string mensagem = "  Olá Mário   ";
            //label1.Text = ">" + mensagem.TrimStart() + "<";

            //string mensagem = "  Olá Mário   ";
            //label1.Text = ">" + mensagem.TrimEnd() + "<";

            //string mensagem = "  Olá Mário   ";
            //label1.Text = ">" + mensagem.Trim() + "<";

            #endregion

            #region Equals / CompareTo
            //string nome = "Gabriel";

            //string nome2 = "Lucas";

            //if (nome.Equals("Gabriel"))
            //{
            //    label1.Text = "Positivo";
            //}
            //else
            //{
            //    label1.Text = "Negativo";
            //}

            //label1.Text = nome.CompareTo(nome2).ToString();
            #endregion

            #region Format
            decimal valor = 19.95m;
            int temp = 32;

            //string s = String.Format("O valor do produto é {0:C2} e a temperatura é {1}", valor, temp);

            //string s = String.Format("Hoje é {0:d} e são {0:t}", DateTime.Now);

            //string s = $"O valor do produto é {valor:C2} e a temperatura é {temp}";

            //label1.Text = s;
            #endregion

        }
    }
}
