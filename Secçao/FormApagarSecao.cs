using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Secçao
{
    public partial class FormApagarSecao : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormApagarSecao()
        {
            InitializeComponent();
        }

        private void FormApagarSecao_Load(object sender, EventArgs e)
        {
            CarregarSecoes();
        }

        private void CarregarSecoes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT Descricao FROM Secao";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBoxSecoes.DisplayMember = "Descricao";
                    comboBoxSecoes.ValueMember = "Descricao";
                    comboBoxSecoes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as Secções: " + ex.Message);
            }
        }

        private void btnApagarSecao_Click(object sender, EventArgs e)
        {
            if (comboBoxSecoes.SelectedItem == null)
            {
                MessageBox.Show("Seleciona uma Secção para apagar.");
                return;
            }

            string descricaoSelecionada = comboBoxSecoes.SelectedValue.ToString();

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "DELETE FROM Secao WHERE Descricao = @Descricao";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Descricao", descricaoSelecionada);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Secção apagada com sucesso!");
                        CarregarSecoes();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao apagar a secção. Alguma coisa aconteceu.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar a Secção: " + ex.Message);
            }
        }
    }
}
