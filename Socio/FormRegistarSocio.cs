using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Socio
{
    public partial class FormRegistarSocio : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormRegistarSocio()
        {
            InitializeComponent();
        }

        private void FormRegistarSocio_Load(object sender, EventArgs e)
        {
            CarregarEstados();
            CarregarSocios();
            CarregarFuncionarios();
        }

        private void btnRegistarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string numeroCartaoCidadao = txtNumeroCartaoCidadao.Text;
                string morada = txtMorada.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                DateTime dataNascimento = dtpDataNascimento.Value;
                string estado = cmbEstado.SelectedItem.ToString();

                if (cmbFuncionario.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleciona um funcionário.");
                    return;
                }

                int idFuncionario = ((KeyValuePair<int, string>)cmbFuncionario.SelectedItem).Key;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "INSERT INTO Socio (Nome, Numero_Cartao_Cidadao, Morada, Email, Telefone, Data_Nascimento, Estado, ID_Funcionario) " +
                                   "VALUES (@Nome, @Numero_Cartao_Cidadao, @Morada, @Email, @Telefone, @Data_Nascimento, @Estado, @ID_Funcionario)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Numero_Cartao_Cidadao", numeroCartaoCidadao);
                    cmd.Parameters.AddWithValue("@Morada", morada);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Telefone", telefone);
                    cmd.Parameters.AddWithValue("@Data_Nascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@Estado", estado);
                    cmd.Parameters.AddWithValue("@ID_Funcionario", idFuncionario);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sócio registado com sucesso!");
                    LimparCampos();
                    CarregarEstados();
                    CarregarSocios();
                    CarregarFuncionarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registar Sócio: " + ex.Message);
            }
        }

        private void CarregarSocios()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT * FROM Socio";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewSocios.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar sócios: " + ex.Message);
            }
        }

        private void CarregarEstados()
        {
            cmbEstado.Items.Add("Ativo");
            cmbEstado.Items.Add("Inativo");
            cmbEstado.SelectedIndex = 0;
        }

        private void CarregarFuncionarios()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT ID_Funcionario, Nome FROM Funcionario";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    Dictionary<int, string> funcionarios = new Dictionary<int, string>();

                    while (reader.Read())
                    {
                        funcionarios.Add(reader.GetInt32(0), reader.GetString(1));
                    }

                    cmbFuncionario.DataSource = new BindingSource(funcionarios, null);
                    cmbFuncionario.DisplayMember = "Value";
                    cmbFuncionario.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionários: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtNumeroCartaoCidadao.Clear();
            txtMorada.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            cmbEstado.SelectedIndex = 0;
            cmbFuncionario.SelectedIndex = 0;
        }

        private void btnProcurarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = textBoxSociosProcura.Text.Trim();

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT * FROM Socio WHERE Nome LIKE @Criterio OR Numero_Cartao_Cidadao LIKE @Criterio";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Criterio", "%" + criterio + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewPesquisaSocios.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum sócio foi encontrado com base nesse critério. Tenta novamente.");
                    }

                    LimparCamposProcura();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar sócios: " + ex.Message);
            }
        }

        private void btnLimparFormProcura_Click(object sender, EventArgs e)
        {
            LimparCamposProcura();
        }

        private void LimparCamposProcura()
        {
            textBoxSociosProcura.Clear();
        }
    }
}
