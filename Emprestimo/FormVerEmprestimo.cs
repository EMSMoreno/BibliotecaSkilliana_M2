using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Emprestimo
{
    public partial class FormVerEmprestimo : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormVerEmprestimo()
        {
            InitializeComponent();
        }

        #region Métodos

        private void FormRegistarEmprestimo_Load(object sender, EventArgs e)
        {
            CarregarEmprestimos();
        }

        private void CarregarEmprestimos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT * FROM Emprestimo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar empréstimos: " + ex.Message);
            }
        }

        #endregion

        #region UI

        private void btnAdicionarEmprestimo_Click(object sender, EventArgs e)
        {
            using (FormRegistarEmprestimo formRegistarEmprestimo = new FormRegistarEmprestimo())
            { formRegistarEmprestimo.ShowDialog(); }
        }

        private void btnEditarEmprestimo_Click(object sender, EventArgs e)
        {
            using (FormEditarEmprestimo formEditarEmprestimo = new FormEditarEmprestimo())
            { formEditarEmprestimo.ShowDialog(); }
        }

        private void btnApagarEmprestimo_Click(object sender, EventArgs e)
        {
            using (FormApagarEmprestimo formApagarEmprestimo = new FormApagarEmprestimo())
            { formApagarEmprestimo.ShowDialog(); }
        }

        #endregion
    }
}
