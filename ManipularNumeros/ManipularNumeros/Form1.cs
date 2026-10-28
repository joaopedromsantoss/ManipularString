using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region TryParse
            //int num;
            //bool res = int.TryParse("198", out num);
            //if (res)
            //{
            //    lblResultado.Text = num.ToString();
            //}else 
            //{
            //    lblResultado.Text = "Erro na conversão";
            //}
            #endregion

            //double num = 120.5524;

            //lblResultado.Text = num.ToString("#.00");

            #region ToString / Convert.ToString
            //int num = 10;
            /*lblResultado.Text = num.ToString("x");*/ // hex
            /*lblResultado.Text = num.ToString("d");*/ // dec
            /*lblResultado.Text = num.ToString("C");*/ // Monetario

            //lblResultado.Text = Convert.ToString(num, 16);
            #endregion

            #region Math
            double p1 = Math.PI;
            double seno = Math.Sin(3);
            double coseno = Math.Cos(3);
            double potencia = Math.Pow(2,2);
            double raizQuadrada = Math.Sqrt(49);
            double inteiro = Math.Truncate(49.80);

            //lblResultado.Text = p1.ToString("#.00");
            lblResultado.Text = potencia.ToString();
            #endregion
        }
    }
}
