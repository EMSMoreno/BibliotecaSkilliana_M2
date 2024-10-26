using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaSkilliana_M2.Estante
{
    public partial class FormApagarEstante : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormApagarEstante()
        {
            InitializeComponent();
        }

        private void FormApagarEstante_Load(object sender, EventArgs e)
        {
            CarregarEstantes();
        }

        private void CarregarEstantes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT Codigo_Estante, Descricao FROM Estante";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBoxEstantes.DataSource = dt;
                    comboBoxEstantes.DisplayMember = "Descricao";
                    comboBoxEstantes.ValueMember = "Codigo_Estante";
                    comboBoxEstantes.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar estantes: " + ex.Message);
            }
        }

        private void btnApagarEstante_Click(object sender, EventArgs e)
        {
            if(comboBoxEstantes.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleciona uma estante.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "DELETE FROM Estante WHERE Codigo_Estante = @CodigoEstante";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CodigoEstante", comboBoxEstantes.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Estante apagada com sucesso!");

                    CarregarEstantes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar a Estante: " + ex.Message);
            }
        }
    }
}
