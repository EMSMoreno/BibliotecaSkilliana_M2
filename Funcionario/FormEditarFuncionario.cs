using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaSkilliana_M2.Funcionario
{
    public partial class FormEditarFuncionario : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormEditarFuncionario()
        {
            InitializeComponent();
        }

        private void FormRegistarSecao_Load(object sender, EventArgs e)
        {
            LoadFuncionarios();
            CarregarComboBoxes();
        }

        private void LoadFuncionarios()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT ID_Funcionario, Nome, Morada, Telefone, Data_Nascimento, Numero_Funcionario, Tipo, Estado, Email FROM Funcionario";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionários: " + ex.Message);
            }
        }

        private void CarregarComboBoxes()
        {
            // Carregar Tipos de Funcionário
            cmbTipoFunc.Items.Clear();
            cmbTipoFunc.Items.Add("Administrador");
            cmbTipoFunc.Items.Add("Bibliotecario");
            cmbTipoFunc.Items.Add("Armazenista");

            // Carregar Estados
            cmbEstadoFunc.Items.Clear();
            cmbEstadoFunc.Items.Add("Ativo");
            cmbEstadoFunc.Items.Add("Inativo");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtIDFunc.Text = row.Cells["ID_Funcionario"].Value.ToString();
                txtNomeFunc.Text = row.Cells["Nome"].Value.ToString();
                txtMoradaFunc.Text = row.Cells["Morada"].Value.ToString();
                txtTelefoneFunc.Text = row.Cells["Telefone"].Value.ToString();
                txtNumeroFunc.Text = row.Cells["Numero_Funcionario"].Value.ToString();
                txtEmailFunc.Text = row.Cells["Email"].Value.ToString();
                dtpDataNasc.Value = Convert.ToDateTime(row.Cells["Data_Nascimento"].Value);

                // Selecionar o tipo de funcionário
                string tipoFuncionario = row.Cells["Tipo"].Value.ToString();
                cmbTipoFunc.SelectedItem = tipoFuncionario;

                // Selecionar o estado
                string estado = row.Cells["Estado"].Value.ToString();
                cmbEstadoFunc.SelectedItem = estado;
            }
        }

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDFunc.Text) ||
               string.IsNullOrWhiteSpace(txtNomeFunc.Text) ||
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
                    string query = "UPDATE Funcionario SET Nome = @Nome, Morada = @Morada, Telefone = @Telefone, " +
                                   "Data_Nascimento = @Data_Nascimento, Numero_Funcionario = @NumeroFuncionario, Tipo = @Tipo, Estado = @Estado, Email = @Email " +
                                   "WHERE ID_Funcionario = @ID_Funcionario";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@ID_Funcionario", txtIDFunc.Text);
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
                        MessageBox.Show("Funcionário atualizado com sucesso!");
                        LoadFuncionarios();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar o funcionário.");
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
            txtNumeroFunc.Clear();
            txtEmailFunc.Clear();
            cmbTipoFunc.SelectedIndex = -1;
            cmbEstadoFunc.SelectedIndex = -1;
            dtpDataNasc.Value = DateTime.Now;
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            LimparForm();
        }
    }
}
