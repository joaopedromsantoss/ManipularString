using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Mensagem a ser impressa", "Titulo da msg");

            //DialogResult res = MessageBox.Show("texto msg", "titulo", MessageBoxButtons.OKCancel);

            //if (res == DialogResult.OK) 
            //{ 
            //    label1.Text = "Clicou em OK";
            //}
            //else
            //{
            //    label1.Text = "Clicou em Cancelar";
            //}

            //MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            MessageBox.Show("Mensagem", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Random r = new Random(DateTime.Now.Millisecond);

            int valor = r.Next(100);
            double valor2 = r.NextDouble() * 100;

            label1.Text = "Número: " + valor2;
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            //label1.Text = TimeSpan.FromMinutes(60).ToString();

            //label1.Text = TimeSpan.FromTicks(100000).ToString();

            //label1.Text = TimeSpan.TicksPerMinute.ToString();

            TimeSpan inicio = new TimeSpan(5, 30, 30);

            TimeSpan fim = new TimeSpan(18, 25, 0);

            //TimeSpan intervalo = fim - inicio; // OR
            TimeSpan intervalo = fim.Subtract(inicio);

            label1.Text = intervalo.ToString();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Today.ToString();
            //label1.Text = DateTime.Now.ToString();
            //label1.Text = DateTime.DaysInMonth(2020,07).ToString();
            //label1.Text = DateTime.IsLeapYear(2020).ToString();  retorna  ano bisexto
            //label1.Text = DateTime.Now.ToLongDateString();
            //label1.Text = DateTime.Now.ToShortDateString();
            //label1.Text = DateTime.Now.ToLongTimeString();
            //label1.Text = DateTime.Now.ToShortTimeString();
            //label1.Text = DateTime.Now.ToUniversalTime().ToString();
            //label1.Text = DateTime.Now.ToString("dd-MM-yy HH:mm:ss");

            DateTime data = new DateTime(1985, 01, 10, 14, 35, 30);
            //label1.Text = data.AddYears(2).ToString();
            TimeSpan tempo = new TimeSpan(5, 10, 5, 20);

            label1.Text = data.Add(tempo).ToString();
        }
    }
}
