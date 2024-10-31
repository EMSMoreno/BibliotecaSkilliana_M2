using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using BibliotecaSkilliana_M2.Emprestimo;

namespace BibliotecaSkilliana_M2.Funcionario
{
    public partial class FormVerFuncionario : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormVerFuncionario()
        {
            InitializeComponent();
        }

        private void FormRegistarFuncionario_Load(object sender, EventArgs e)
        {
            LoadFuncionarios();
        }

        private void LoadFuncionarios()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = @"
                    SELECT 
                        ID_Funcionario, 
                        Nome, 
                        Morada, 
                        Telefone, 
                        Email, 
                        Data_Nascimento, 
                        Numero_Funcionario, 
                        Tipo, 
                        Estado 
                    FROM Funcionario";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os Funcionários: " + ex.Message);
            }
        }

        private void btnAdicionarSocio_Click(object sender, EventArgs e)
        {
            using (FormRegistarFuncionario formRegistarFuncionario = new FormRegistarFuncionario())
            { formRegistarFuncionario.ShowDialog(); }
        }

        private void btnEditarSocio_Click(object sender, EventArgs e)
        {
            using (FormEditarFuncionario formEditarFuncionario = new FormEditarFuncionario())
            { formEditarFuncionario.ShowDialog(); }

        }

        private void btnApagarSocio_Click(object sender, EventArgs e)
        {
            using (FormApagarFuncionario formApagarFuncionario = new FormApagarFuncionario())
            { formApagarFuncionario.ShowDialog(); }
        }
    }
}
