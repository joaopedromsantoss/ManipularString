using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            // Array
            string[] nomes = new string[3];
            nomes[0] = "Gabriel";
            nomes[1] = "Arthur";
            nomes[2] = "Marcela";
            
            // Lista Genérica
            List<string> nomes2 = new List<string>();
            
            nomes2.Add("Lukas");
            nomes2.Add("Ana");
            nomes2.AddRange(nomes);

            //if (nomes2.Remove("Lukas"))
            //{
            //    MessageBox.Show("Lucas removido com sucesso");
            //}
            //else
            //{
            //    MessageBox.Show("Não foi possível remover");
            //}

            nomes2.Sort(); // ordena em ordem alfabética

            nomes2.Insert(2, "João");

            nomes2.RemoveAt(1);
            
            foreach (string nome in nomes2) 
            {
                lista.Items.Add(nome);
            }

        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro", "Moto", "Avião", "Helicoptero", "Barco"
            };

            //if (veiculos.Add("Cavalo"))
            //{
            //    MessageBox.Show("Item adicionado");
            //}
            //else
            //{
            //    MessageBox.Show("Item não Sadicionado");
            //}

            //MessageBox.Show(veiculos.ElementAt(2));
            //MessageBox.Show(veiculos.First());
            //MessageBox.Show(veiculos.Last());

            foreach (string veiculo in veiculos)
            {
                lista.Items.Add(veiculo);
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                {150, "Alfredo" },
                {50, "Balduino" },
                {200, "Carlos Magno" },
                {250, "Carlos Magno" },
            };

            alunos.Add(100, "Marcos");

            //if(alunos.ContainsKey(150))
            //{
            //    MessageBox.Show("Contém a chave 150");
            //}
            //else
            //{
            //    MessageBox.Show("Não contém a chave 150");
            //}


            
            //KeyValuePair<int, string> primeiro = alunos.First();
            //MessageBox.Show("Primeiro " + primeiro.Key + " " + primeiro.Value);



            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item.Key + " = " + item.Value);
            }
        }

        private void SortedList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                {27, "Gabriel" },
                {10, "Léo" },
                {17, "Maria" },
            };

            alunos.Add(14, "Glória");
            //alunos.Reverse(); Ordena do maior para o menor 

            foreach (KeyValuePair<int, string> aluno in alunos)
            {
                lista.Items.Add(aluno.Key + " " + aluno.Value);
            }
        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            {
                {4512, "Gabriel" },
                {1542, "Arthur" },
                {2145, "Marcelo" },
            };

            alunos.Add(3000, "Catarina");

            foreach (KeyValuePair<int, string> aluno in alunos.Reverse())
            {
                lista.Items.Add(aluno.Key + " " + aluno.Value);
            }
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            SortedSet<string> nomes = new SortedSet<string>()
            {
                "Maros", "Gabriel", "Danny", "Flávio", "Beatriz"
            };

            if (!nomes.Add("Danny"))
            {
                MessageBox.Show("Não podes repetir o nome");
            }

            nomes.Add("CLara");
            //nomes.Remove("Beatriz");
            //MessageBox.Show(nomes.ElementAt(0));

            foreach (string item in nomes) 
            {
                lista.Items.Add(item);
            }

        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Gabriel");
            fila.Enqueue("Danny");
            fila.Enqueue("Arthur");

            MessageBox.Show(fila.Count.ToString());

            foreach (string item in fila)
            {
                lista.Items.Add(item);
            }

            //MessageBox.Show("Primeiro da fila: " + fila.Peek());
            //MessageBox.Show(fila.Count.ToString());

            //MessageBox.Show("Primeiro da fila: "+ fila.Dequeue()); apaga o primeiro registro da "fila"
            //MessageBox.Show(fila.Count.ToString());
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            Stack<string> pilha = new Stack<string>();

            pilha.Push("Gabriel");
            pilha.Push("Joao");
            pilha.Push("Mario");

            //MessageBox.Show(pilha.Count.ToString());

            foreach(string item in pilha)
            {
                lista.Items.Add(item);
            }
        }
    }
}
