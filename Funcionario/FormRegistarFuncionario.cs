using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace BibliotecaSkilliana_M2.Funcionario
{
    public partial class FormRegistarFuncionario : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormRegistarFuncionario()
        {
            InitializeComponent();
        }

        private void FormRegistarFuncionario_Load(object sender, EventArgs e)
        {
            LoadFuncionarios();
            LoadTipoFuncionario();
            LoadEstadoFuncionario();
        }

        private void LoadFuncionarios()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = @"
                    SELECT 
                        ID_Funcionario, 
                        Nome, 
                        Morada, 
                        Telefone, 
                        Email, 
                        Data_Nascimento, 
                        Numero_Funcionario, 
                        Tipo, 
                        Estado 
                    FROM Funcionario";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os Funcionários: " + ex.Message);
            }
        }

        private void LoadTipoFuncionario()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT DISTINCT Tipo FROM Funcionario";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbTipoFunc.Items.Add(reader["Tipo"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tipos de funcionário: " + ex.Message);
            }
        }

        private void LoadEstadoFuncionario()
        {
            try
            {
                cmbEstadoFunc.Items.Add("Ativo");
                cmbEstadoFunc.Items.Add("Inativo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os estados do Funcionário: " + ex.Message);
            }
        }

        private void btnRegistarFuncionario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeFunc.Text) ||
                string.IsNullOrWhiteSpace(txtMoradaFunc.Text) ||
                string.IsNullOrWhiteSpace(txtTelefoneFunc.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroFunc.Text) ||
                string.IsNullOrWhiteSpace(txtEmailFunc.Text) ||
                cmbTipoFunc.SelectedItem == null ||
                cmbEstadoFunc.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "INSERT INTO Funcionario (Nome, Morada, Telefone, Data_Nascimento, Numero_Funcionario, Tipo, Estado, Email) " +
                                   "VALUES (@Nome, @Morada, @Telefone, @Data_Nascimento, @NumeroFuncionario, @Tipo, @Estado, @Email)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Nome", txtNomeFunc.Text);
                    cmd.Parameters.AddWithValue("@Morada", txtMoradaFunc.Text);
                    cmd.Parameters.AddWithValue("@Telefone", txtTelefoneFunc.Text);
                    cmd.Parameters.AddWithValue("@Data_Nascimento", dtpDataNasc.Value);
                    cmd.Parameters.AddWithValue("@NumeroFuncionario", txtNumeroFunc.Text);
                    cmd.Parameters.AddWithValue("@Tipo", cmbTipoFunc.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Estado", cmbEstadoFunc.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Email", txtEmailFunc.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Funcionário registado com sucesso!");
                        LimparForm();
                        LoadFuncionarios();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao registar o Funcionário.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void LimparForm()
        {
            txtIDFunc.Clear();
            txtNomeFunc.Clear();
            txtMoradaFunc.Clear();
            txtTelefoneFunc.Clear();
            txtEmailFunc.Clear();
            txtNumeroFunc.Clear();
            dtpDataNasc.Value = DateTime.Now;
            cmbTipoFunc.SelectedIndex = -1;
            cmbEstadoFunc.SelectedIndex = -1;
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

    }
}
