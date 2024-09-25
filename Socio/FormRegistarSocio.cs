using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BibliotecaSkilliana_M2.Socio
{
    public partial class FormRegistarSocio : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["BibliotecaSkilliana"].ConnectionString;

        public FormRegistarSocio()
        {
            InitializeComponent();
            CarregarEstados();
            CarregarSocios();
        }

        private void btnRegistarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores dos campos
                string nome = txtNome.Text;
                string numeroCartaoCidadao = txtNumeroCartaoCidadao.Text;
                string morada = txtMorada.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                DateTime dataNascimento = dtpDataNascimento.Value;
                string estado = cmbEstado.SelectedItem.ToString(); // Obtendo o estado selecionado

                // Caso você ainda esteja usando um ID de funcionário, você pode manter esta linha
                int idFuncionario = int.Parse(txtIDFuncionario.Text);

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    // Omita a coluna de identidade da instrução INSERT
                    string query = "INSERT INTO Socio (Nome, Numero_Cartao_Cidadao, Morada, Email, Telefone, Data_Nascimento, Estado, ID_Funcionario) " +
                                   "VALUES (@Nome, @Numero_Cartao_Cidadao, @Morada, @Email, @Telefone, @Data_Nascimento, @Estado, @ID_Funcionario)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Numero_Cartao_Cidadao", numeroCartaoCidadao);
                    cmd.Parameters.AddWithValue("@Morada", morada);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Telefone", telefone);
                    cmd.Parameters.AddWithValue("@Data_Nascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@Estado", estado); // Armazena o estado como string
                    cmd.Parameters.AddWithValue("@ID_Funcionario", idFuncionario);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sócio registrado com sucesso!");
                    LimparCampos(); // Chama um método para limpar os campos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar sócio: " + ex.Message);
            }
        }

        private void CarregarSocios()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT * FROM Socio"; // Ajuste a consulta conforme necessário
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewSocios.DataSource = dt; // Atribui o DataTable como fonte de dados
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar sócios: " + ex.Message);
            }
        }

        private void CarregarEstados()
        {
            // Adiciona as opções de estado diretamente
            cmbEstado.Items.Add("Ativo");
            cmbEstado.Items.Add("Inativo");

            // Define o estado padrão
            cmbEstado.SelectedIndex = 0; // Seleciona "Ativo" por padrão
        }

        private void LimparCampos()
        {
            txtNumeroSocio.Clear();
            txtNome.Clear();
            txtNumeroCartaoCidadao.Clear();
            txtMorada.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            dtpDataNascimento.Value = DateTime.Now; // Define a data atual
            cmbEstado.SelectedIndex = 0; // Retorna para "Ativo" por padrão
            txtIDFuncionario.Clear();
        }
    }
}
