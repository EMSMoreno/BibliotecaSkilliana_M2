using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaSkilliana_M2.Livro
{
    public partial class FormVerLivro : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormVerLivro()
        {
            InitializeComponent();
        }

        private void FormVerLivro_Load(object sender, EventArgs e)
        {
            LoadLivros();
            AddDeleteButtonColumn();
        }

        private void LoadLivros()
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = @"
                SELECT 
                    ISBN, 
                    Titulo, 
                    Data_Lancamento, 
                    Sinopse, 
                    Edicao, 
                    Editora, 
                    Idioma, 
                    Numero_Paginas, 
                    Estado, 
                    Codigo_Estante, 
                    Quantidade 
                FROM Livro";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Livros: " + ex.Message);
            }
        }

        private void DeleteLivro(int rowIndex)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string isbn = dataGridView1.Rows[rowIndex].Cells["ISBN"].Value.ToString();
                    string query = "DELETE FROM Livro WHERE ISBN = @ISBN";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ISBN", isbn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Livro apagado com sucesso!");
                    LoadLivros(); // Recarrega os livros para atualizar o DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar o livro: " + ex.Message);
            }
        }

        private void AddDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnDeleteColumn = new DataGridViewButtonColumn();
            btnDeleteColumn.HeaderText = "Apagar";
            btnDeleteColumn.Name = "btnDelete";
            btnDeleteColumn.Text = "Apagar";
            btnDeleteColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(btnDeleteColumn);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Tem a certeza de que pretende apagar este livro?",
                                                     "Confirmar Eliminação",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteLivro(e.RowIndex);
                }
            }
        }

        private void btnAdicionarLivro_Click(object sender, EventArgs e)
        {
            using (FormRegistarLivro formRegistarLivro = new FormRegistarLivro())
            { formRegistarLivro.ShowDialog(); }
        }

        private void btnEditarLivro_Click(object sender, EventArgs e)
        {
            using (FormEditarLivro formEditarLivro = new FormEditarLivro())
            { formEditarLivro.ShowDialog(); }
        }

        private void btnApagarLivro_Click(object sender, EventArgs e)
        {
            using (FormApagarLivro formApagarLivro = new FormApagarLivro())
            { formApagarLivro.ShowDialog(); }
        }
    }
}
