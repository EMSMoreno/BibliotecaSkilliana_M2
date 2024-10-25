using System.Configuration;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Funcionario
{
    public partial class FormApagarFuncionario : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormApagarFuncionario()
        {
            InitializeComponent();
        }

        private void FormRegistarSecao_Load(object sender, EventArgs e)
        {
            CarregarFuncionarios();
        }

        private void CarregarFuncionarios()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT Nome FROM Funcionario";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbFuncionarios.Items.Clear();

                    while (reader.Read())
                    {
                        cmbFuncionarios.Items.Add(reader["Nome"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnApagarFuncionario_Click(object sender, EventArgs e)
        {
            if (cmbFuncionarios.SelectedItem == null)
            {
                MessageBox.Show("Selecione um funcionário para apagar.");
                return;
            }

            string funcionarioSelecionado = cmbFuncionarios.SelectedItem.ToString();

            if (MessageBox.Show($"Tens a certeza que queres apagar o funcionário {funcionarioSelecionado}?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        string query = "DELETE FROM Funcionario WHERE Nome = @Nome";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Nome", funcionarioSelecionado);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Funcionário apagado com sucesso!");
                            CarregarFuncionarios();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao apagar o funcionário. Parace que esse Funcionário não foi encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
    }
}
