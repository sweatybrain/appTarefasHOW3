using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tarefotas2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            atualizaGrid();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "afazeres";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaGrid();
            dgvTarefas.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10);
        }

        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM tarefas";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgvTarefas.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgvTarefas.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//data
                    row.Cells[2].Value = reader.GetString(2);//tarefa
                    row.Cells[3].Value = reader.GetInt32(3);//ativo
                    dgvTarefas.Rows.Add(row);//adiciona linha na tabelinha

                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void limparCampos()
        {
            tbId.Clear();
            tbData.Clear();
            tbTarefa.Clear();

        }

        private void dgvTarefas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "INSERT INTO tarefas (dataTarefa, tarefaTarefa)" + "VALUES('" + tbData.Text + "', '" + tbTarefa.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                atualizaGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void dgvTarefas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTarefas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvTarefas.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                tbId.Text = dgvTarefas.Rows[e.RowIndex].Cells["colId"].FormattedValue.ToString();
                tbData.Text = dgvTarefas.Rows[e.RowIndex].Cells["colData"].FormattedValue.ToString();
                tbTarefa.Text = dgvTarefas.Rows[e.RowIndex].Cells["colTarefa"].FormattedValue.ToString();
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE tarefas SET dataTarefa='" + tbData.Text + "',tarefaTarefa='"+ tbTarefa.Text + "' " + " WHERE idTarefa = " + tbId.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "DELETE FROM tarefas WHERE idTarefa = " + tbId.Text + "";


                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

