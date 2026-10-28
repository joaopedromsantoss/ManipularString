using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Diretorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string path = @"C:\Curso CSHARP Pessoal\";

            bool res = Directory.Exists(path + "logan");

            lista.Items.Add(res);

            //if (res == false)
            //    Directory.CreateDirectory(path + "logan");

            //if (res == true)
            //    Directory.Delete(path + "logan");

            //if (res == true)
            //    Directory.Move(path + "logan", path + "destino\\loganCopia");

            //string[] dirs = Directory.GetDirectories(path);

            //foreach (string dir in dirs) 
            //{ 
            //    lista.Items.Add(dir);
            //}

            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                lista.Items.Add(file);
            }
        }
    }
}
