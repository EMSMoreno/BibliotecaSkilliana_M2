using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BibliotecaSkilliana_M2.Socio
{
    public partial class FormApagarSocio : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["BibliotecaSkilliana"].ConnectionString;

        public FormApagarSocio()
        {
            InitializeComponent();
            CarregarSocios(); // Carrega os sócios ao inicializar o formulário
        }

        private void CarregarSocios()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT Nome FROM Socio"; // Ajuste conforme necessário
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbSocios.Items.Add(reader["Nome"].ToString()); // Adiciona os nomes dos sócios à ComboBox
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
                string nomeSocio = cmbSocios.SelectedItem?.ToString(); // Obtém o nome do sócio selecionado

                if (string.IsNullOrEmpty(nomeSocio))
                {
                    MessageBox.Show("Por favor, selecione um sócio para apagar.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "DELETE FROM Socio WHERE Nome = @Nome"; // Ajuste a condição conforme necessário
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nome", nomeSocio);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sócio apagado com sucesso!");
                        cmbSocios.Items.Remove(nomeSocio); // Remove o sócio da lista
                    }
                    else
                    {
                        MessageBox.Show("Sócio não encontrado.");
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
