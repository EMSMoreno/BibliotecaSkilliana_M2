using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Socio
{
    public partial class FormEditarSocio : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormEditarSocio()
        {
            InitializeComponent();
        }

        private void FormEditarSocio_Load(object sender, EventArgs e)
        {
            CarregarSocios();
            CarregarEstados();
            CarregarFuncionarios();
        }

        private void CarregarSocios()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT * FROM Socio";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewSocios.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Sócios: " + ex.Message);
            }
        }

        private void CarregarEstados()
        {
            try
            {
                // Estados são predefinidos
                var estados = new[] { "Ativo", "Inativo" };
                cmbEstado.DataSource = estados;
                cmbEstado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Estados: " + ex.Message);
            }
        }

        private void CarregarFuncionarios()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT ID_Funcionario, Nome FROM Funcionario";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbFuncionario.DataSource = dt;
                    cmbFuncionario.DisplayMember = "Nome";
                    cmbFuncionario.ValueMember = "ID_Funcionario";
                    cmbFuncionario.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Funcionários: " + ex.Message);
            }
        }

        private void dataGridViewSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSocios.Rows[e.RowIndex];

                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtNumeroCartaoCidadao.Text = row.Cells["Numero_Cartao_Cidadao"].Value.ToString();
                txtMorada.Text = row.Cells["Morada"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtTelefone.Text = row.Cells["Telefone"].Value.ToString();
                dtpDataNascimento.Value = Convert.ToDateTime(row.Cells["Data_Nascimento"].Value);
                cmbEstado.SelectedItem = row.Cells["Estado"].Value.ToString();
                cmbFuncionario.SelectedValue = row.Cells["ID_Funcionario"].Value;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewSocios.CurrentRow != null)
            {
                try
                {
                    DataGridViewRow row = dataGridViewSocios.CurrentRow;

                    string nome = txtNome.Text;
                    string numeroCartaoCidadao = txtNumeroCartaoCidadao.Text;
                    string morada = txtMorada.Text;
                    string email = txtEmail.Text;
                    string telefone = txtTelefone.Text;
                    DateTime dataNascimento = dtpDataNascimento.Value;
                    string estado = cmbEstado.SelectedItem.ToString();
                    int idFuncionario = (int)cmbFuncionario.SelectedValue;
                    int numeroSocio = Convert.ToInt32(row.Cells["Numero_Socio"].Value);

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
                        cmd.Parameters.AddWithValue("@Numero_Socio", numeroSocio);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sócio atualizado com sucesso!");
                        LimparForm();
                        CarregarSocios();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar sócio: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleciona um Sócio para atualizar.");
            }
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void LimparForm()
        {
            txtNome.Clear();
            txtNumeroCartaoCidadao.Clear();
            txtMorada.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            cmbEstado.SelectedIndex = -1;
            cmbFuncionario.SelectedIndex = -1;
        }
    }
}
