using BibliotecaSkilliana_M2.Livro;
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

namespace BibliotecaSkilliana_M2.Autor
{
    public partial class FormVerAutor : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormVerAutor()
        {
            InitializeComponent();
        }

        private void FormRegistarAutor_Load(object sender, EventArgs e)
        {
            CarregarAutores();
        }

        private void CarregarAutores()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT * FROM Autor";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum autor encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar autores: " + ex.Message);
            }
        }

        private void btnAdicionarAutor_Click(object sender, EventArgs e)
        {
            using (FormRegistarAutor formRegistarAutor = new FormRegistarAutor())
            { formRegistarAutor.ShowDialog(); }
        }

        private void btnEditarAutor_Click(object sender, EventArgs e)
        {
            using (FormEditarAutor formEditarAutor = new FormEditarAutor())
            { formEditarAutor.ShowDialog(); }
        }

        private void btnApagarAutor_Click(object sender, EventArgs e)
        {
            using (FormApagarAutor formApagarAutor = new FormApagarAutor())
            { formApagarAutor.ShowDialog(); }
        }
    }
}
