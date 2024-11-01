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

namespace BibliotecaSkilliana_M2.Estante
{
    public partial class FormVerEstante : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormVerEstante()
        {
            InitializeComponent();
        }

        private void FormRegistarEstante_Load(object sender, EventArgs e)
        {
            CarregarEstantes();
        }

        private void CarregarEstantes(string busca = null)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT * FROM Estante";

                    if (!string.IsNullOrEmpty(busca))
                    {
                        query += " WHERE Descricao LIKE @busca";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    if (!string.IsNullOrEmpty(busca))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@busca", "%" + busca + "%");
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (string.IsNullOrEmpty(busca))
                    {
                        dataGridView1.DataSource = dt;
                    }
                    

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma estante encontrada.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar estantes: " + ex.Message);
            }
        }

        private void btnAdicionarEstante_Click(object sender, EventArgs e)
        {
            using (FormRegistarEstante formRegistarEstante = new FormRegistarEstante())
            { formRegistarEstante.ShowDialog(); }
        }

        private void btnEditarEstante_Click(object sender, EventArgs e)
        {
            using (FormEditarEstante formEditarEstante = new FormEditarEstante())
            { formEditarEstante.ShowDialog(); }
        }

        private void btnApagarEstante_Click(object sender, EventArgs e)
        {
            using (FormApagarEstante formApagarEstante = new FormApagarEstante())
            { formApagarEstante.ShowDialog(); }
        }
    }

}
