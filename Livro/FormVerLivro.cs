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
