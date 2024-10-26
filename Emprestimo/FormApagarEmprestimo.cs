using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Emprestimo
{
    public partial class FormApagarEmprestimo : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormApagarEmprestimo()
        {
            InitializeComponent();
        }

        private void FormEditarEmprestimo_Load(object sender, EventArgs e)
        {
            CarregarEmprestimos();
        }

        #region Métodos

        private void CarregarEmprestimos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT ID_Emprestimo, CONCAT(Numero_Socio, ' - ', Data_Registro) AS Descricao FROM Emprestimo";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBoxEmprestimos.DataSource = dt;
                    comboBoxEmprestimos.DisplayMember = "Descricao";
                    comboBoxEmprestimos.ValueMember = "ID_Emprestimo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar empréstimos: " + ex.Message);
            }
        }

        private void ApagarEmprestimo()
        {
            if (comboBoxEmprestimos.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleciona um empréstimo para apagar.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "DELETE FROM Emprestimo WHERE ID_Emprestimo = @idEmprestimo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@idEmprestimo", comboBoxEmprestimos.SelectedValue);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Empréstimo apagado com sucesso!");
                        CarregarEmprestimos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao apagar o empréstimo. Tente novamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar o empréstimo: " + ex.Message);
            }
        }

        #endregion

        #region UI

        private void btnApagarEmprestimo_Click(object sender, EventArgs e)
        {
            ApagarEmprestimo();
        }

        #endregion
    }
}
