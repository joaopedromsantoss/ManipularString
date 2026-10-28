using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Arquivo
{
    public partial class Arquivo : Form
    {
        public Arquivo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pasta = "C:\\Curso CSHARP Pessoal\\";
            string arquivo = "TESTE.txt";

            //bool res = File.Exists(pasta + arquivo);

            //label1.Text = res.ToString();

            //File.Delete(pasta + arquivo);


            //File.Create(pasta + arquivo).Close(); //depois de criar  o arquivo, ele "fecha" o comando de criação;

            //if (!File.Exists(pasta + arquivo))
            //{
            //    File.Create(pasta + arquivo).Close();
            //    label1.Text = "Criado";
            //}
            //else
            //{
            //    label1.Text = "Já existe";
            //}

            //if (File.Exists(pasta + arquivo)) 
            //{
            //    File.Copy(pasta + arquivo, pasta + "TESTE2.txt", true); // true = sobrescreve o arquivo se ele já existir
            //    label1.Text = "Arquivo copiado";
            //}
            //else
            //{
            //    label1.Text = "Arquivo não existe";
            //}

            //File.Move(pasta + arquivo, pasta + "Movido.txt"); Move = move o arquivo para outro local, ou renomeia o arquivo
            //label1.Text = "Arquivo movido";

            //File.Move(pasta + arquivo, pasta + "Destino\\" + arquivo);

            //File.WriteAllText(pasta + arquivo, "Conteúdo do arquivo", Encoding.Default); // escreve/sobrescreve o conteúdo no arquivo

            //File.ReadAllText(pasta + arquivo, Encoding.Default); // lê o conteúdo do arquivo

            //File.SetCreationTime(pasta + arquivo, DateTime.Now); // altera a data de criação do arquivo
        }
    }
}

// File.Exists()
// File.Create()
// File.Move()
// File.Copy()
// File.WriteAllText()
// File.ReadAllText()
