using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BibliotecaSkilliana_M2.Livro;

namespace BibliotecaSkilliana_M2.Secçao
{
    public partial class FormVerSecao : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormVerSecao()
        {
            InitializeComponent();
        }

        private void FormRegistarSecao_Load(object sender, EventArgs e)
        {
            LoadSecoes();
        }

        private void LoadSecoes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT Codigo_Secao, Descricao FROM Secao";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar secções: " + ex.Message);
            }
        }

        private void btnAdicionarSecao_Click(object sender, EventArgs e)
        {
            using (FormRegistarSecao formRegistarSecao = new FormRegistarSecao())
            { formRegistarSecao.ShowDialog(); }
        }

        private void btnEditarSecao_Click(object sender, EventArgs e)
        {
            using (FormEditarSecao formEditarSecao = new FormEditarSecao())
            { formEditarSecao.ShowDialog(); }
        }

        private void btnApagarSecao_Click(object sender, EventArgs e)
        {
            using (FormApagarSecao formApagarSecao = new FormApagarSecao())
            { formApagarSecao.ShowDialog(); }
        }
    }
}
