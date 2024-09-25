using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BibliotecaSkilliana_M2.Socio
{
    public partial class FormEditarSocio : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["BibliotecaSkilliana"].ConnectionString;
        private int socioId; // Para armazenar o ID do sócio a ser editado

        public FormEditarSocio()
        {
            InitializeComponent();
            CarregarSocios(); // Carrega os sócios ao inicializar o formulário
            dataGridViewSocios.CellClick += DataGridView1_CellClick; // Associa o evento
        }

        private void CarregarSocios()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT * FROM Socio"; // Ajuste conforme necessário
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewSocios.DataSource = dt;

                    // Opcional: Ajuste as colunas para exibir somente as necessárias
                    dataGridViewSocios.Columns["ID_Funcionario"].Visible = false; // Se não quiser exibir o ID do funcionário
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar sócios: " + ex.Message);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                // Obtém a linha selecionada
                DataGridViewRow row = dataGridViewSocios.Rows[e.RowIndex];

                // Preenche as TextBoxes com os dados da linha
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtNumeroCartaoCidadao.Text = row.Cells["Numero_Cartao_Cidadao"].Value.ToString();
                txtMorada.Text = row.Cells["Morada"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtTelefone.Text = row.Cells["Telefone"].Value.ToString();
                dtpDataNascimento.Value = Convert.ToDateTime(row.Cells["Data_Nascimento"].Value);
                cmbEstado.SelectedItem = row.Cells["Estado"].Value.ToString(); // Assegure-se de que o estado está na lista
                txtIDFuncionario.Text = row.Cells["ID_Funcionario"].Value.ToString();

                // Armazena o ID do sócio para edição
                socioId = Convert.ToInt32(row.Cells["Numero_Socio"].Value); // Supondo que esta é a coluna do ID
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string numeroCartaoCidadao = txtNumeroCartaoCidadao.Text;
                string morada = txtMorada.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                DateTime dataNascimento = dtpDataNascimento.Value;
                string estado = cmbEstado.SelectedItem.ToString(); // Obtendo o estado selecionado
                int idFuncionario = int.Parse(txtIDFuncionario.Text); // ID do funcionário

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "UPDATE Socio SET Nome = @Nome, Numero_Cartao_Cidadao = @Numero_Cartao_Cidadao, Morada = @Morada, " +
                                   "Email = @Email, Telefone = @Telefone, Data_Nascimento = @Data_Nascimento, Estado = @Estado, " +
                                   "ID_Funcionario = @ID_Funcionario WHERE Numero_Socio = @Numero_Socio";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Numero_Cartao_Cidadao", numeroCartaoCidadao);
                    cmd.Parameters.AddWithValue("@Morada", morada);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Telefone", telefone);
                    cmd.Parameters.AddWithValue("@Data_Nascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@Estado", estado);
                    cmd.Parameters.AddWithValue("@ID_Funcionario", idFuncionario);
                    cmd.Parameters.AddWithValue("@Numero_Socio", socioId); // ID do sócio que será atualizado

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sócio atualizado com sucesso!");
                    this.Close(); // Fecha o formulário
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar sócio: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário sem alterações
        }
    }
}
