using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string conexao = "Server=.\\TIDSCI_1;User Id=sa;Password=tid@125632;";

            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                conn.Open();
                MessageBox.Show("Conectado com sucesso");

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = "IF DB_ID('cursocsharp_db') IS NULL\r\nBEGIN\r\n    CREATE DATABASE cursocsharp_db;\r\nEND";

                cmd.ExecuteNonQuery();
                lblResult.Text = "Base de dados criado com sucesso";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conexao = "Server=.\\TIDSCI_1;User Id=sa; database = cursocsharp_db;Password=tid@125632;";

            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                int id = new Random(DateTime.Now.Millisecond).Next(0,1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                cmd.CommandText = "INSERT INTO Pessoas VALUES (" + id +", '" + nome + "', '" +  email + "')";

                cmd.ExecuteNonQuery();
                lblResult.Text = "Registro criado com sucesso";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            string conexao = "Server=.\\TIDSCI_1;User Id=sa; database = cursocsharp_db;Password=tid@125632;";

            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                conn.Open();
                MessageBox.Show("Tabela criada com sucesso");

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = "CREATE TABLE Pessoas (\r\n    id INT NOT NULL,\r\n    nome VARCHAR(100),\r\n    email VARCHAR(150),\r\n    CONSTRAINT PK_Pessoas PRIMARY KEY (id)\r\n);";

                cmd.ExecuteNonQuery();
                lblResult.Text = "Tabela criado com sucesso";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            
            string conexao = "Server=.\\TIDSCI_1;User Id=sa; database = cursocsharp_db;Password=tid@125632;";

            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                string query = "select * from cursocsharp_db.dbo.Pessoas";

                if(txtNome.Text != "")
                {
                    query = "select * from cursocsharp_db.dbo.Pessoas WHERE nome LIKE '" + txtNome.Text + "'";
                }

                DataTable dados = new DataTable();

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexao);
                    
                conn.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    lista.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                lista.Rows.Clear();
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            string conexao = "Server=.\\TIDSCI_1;User Id=sa; database = cursocsharp_db;Password=tid@125632;";

            SqlConnection conn = new SqlConnection(conexao);

            try
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                int id = (int)lista.SelectedRows[0].Cells[0].Value;

                cmd.CommandText = "DELETE FROM Pessoas WHERE id = '" + id + "'";

                cmd.ExecuteNonQuery();

                lblResult.Text = "Registro excluido com sucesso";
                cmd.Dispose();
            
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string conexao = "Server=.\\TIDSCI_1;User Id=sa; database = cursocsharp_db;Password=tid@125632;";

            SqlConnection conn = new SqlConnection(conexao);

            try
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                int id = (int)lista.SelectedRows[0].Cells[0].Value;
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                string query = "UPDATE Pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id = '" + id + "'";

                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

                lblResult.Text = "Registro alterado com sucesso";
                cmd.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
