using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Emprestimo
{
    public partial class FormRegistarEmprestimo : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormRegistarEmprestimo()
        {
            InitializeComponent();
        }

        private void FormRegistarEmprestimo_Load(object sender, EventArgs e)
        {
            CarregarEmprestimos();
            CarregarFuncionarios();
        }

        #region Métodos

        private void RegistarEmprestimo()
        {
            if (comboBoxFuncionarioID.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleciona um Funcionário.");
                return;
            }

            int numeroSocio;
            if (!int.TryParse(txtNumeroSocio.Text, out numeroSocio))
            {
                MessageBox.Show("Por favor, insira um número de sócio válido.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "INSERT INTO Emprestimo (Data_Registro, Data_Prevista_Devolucao, Numero_Socio, ID_Funcionario) VALUES (@dataRegistro, @dataPrevistaDevolucao, @numeroSocio, @idFuncionario)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@dataRegistro", DateTime.Now);
                    cmd.Parameters.AddWithValue("@dataPrevistaDevolucao", dateTimePickerDataDevolucao.Value);
                    cmd.Parameters.AddWithValue("@numeroSocio", numeroSocio);
                    cmd.Parameters.AddWithValue("@idFuncionario", Convert.ToInt32(comboBoxFuncionarioID.SelectedValue));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empréstimo registrado com sucesso!");

                    CarregarEmprestimos();
                    LimparForm();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Erro ao registar o Empréstimo: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
        }

        private bool EmprestimoExists(int numeroSocio)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Emprestimo WHERE Numero_Socio = @numeroSocio";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@numeroSocio", numeroSocio);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar Empréstimo: " + ex.Message);
                return false;
            }
        }

        private void CarregarEmprestimos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT * FROM Emprestimo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewEmprestimos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar empréstimos: " + ex.Message);
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
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comboBoxFuncionarioID.DisplayMember = "Nome";
                    comboBoxFuncionarioID.ValueMember = "ID_Funcionario";
                    comboBoxFuncionarioID.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionários: " + ex.Message);
            }
        }

        private void ProcurarEmprestimo()
        {
            int numeroSocio;
            if (int.TryParse(txtEmprestimoIDProcura.Text, out numeroSocio))
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT * FROM Emprestimo WHERE Numero_Socio = @numeroSocio";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@numeroSocio", numeroSocio);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewProcura.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Empréstimo encontrado!");
                    }
                    else
                    {
                        MessageBox.Show("Empréstimo não encontrado.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Número do sócio inválido.");
            }
        }

        private void LimparForm()
        {
            txtNumeroSocio.Clear();
            dateTimePickerDataDevolucao.Value = DateTime.Now;
        }

        #endregion

        #region UI

        private void btnRegistarEmprestimo_Click(object sender, EventArgs e)
        {
            RegistarEmprestimo();
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void btnProcurarEmprestimos_Click(object sender, EventArgs e)
        {
            ProcurarEmprestimo();
        }

        #endregion

    }
}
