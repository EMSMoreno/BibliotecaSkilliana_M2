using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BibliotecaSkilliana_M2.Socio
{
    public partial class FormApagarSocio : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormApagarSocio()
        {
            InitializeComponent();
        }

        private void FormApagarSocio_Load(object sender, EventArgs e)
        {
            CarregarSocios();
        }

        private void CarregarSocios()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT Nome FROM Socio";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbSocios.Items.Add(reader["Nome"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar sócios: " + ex.Message);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeSocio = cmbSocios.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(nomeSocio))
                {
                    MessageBox.Show("Por favor, selecione um sócio para apagar.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "DELETE FROM Socio WHERE Nome = @Nome";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nome", nomeSocio);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sócio apagado com sucesso!");
                        cmbSocios.Items.Remove(nomeSocio);
                    }
                    else
                    {
                        MessageBox.Show("Sócio não encontrado. Tenta novamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar sócio: " + ex.Message);
            }
        }
    }
}
