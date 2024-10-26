using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Emprestimo
{
    public partial class FormEditarEmprestimo : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormEditarEmprestimo()
        {
            InitializeComponent();
        }

        private void FormEditarEmprestimo_Load(object sender, EventArgs e)
        {
            CarregarEmprestimos();
            CarregarFuncionarios();
        }

        private void CarregarEmprestimos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT * FROM Emprestimo";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewEmprestimos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Empréstimos: " + ex.Message);
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

                    comboBoxFuncionarioID.DataSource = dt;
                    comboBoxFuncionarioID.DisplayMember = "Nome";
                    comboBoxFuncionarioID.ValueMember = "ID_Funcionario";
                    comboBoxFuncionarioID.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Funcionários: " + ex.Message);
            }
        }

        private void dataGridViewEmprestimos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEmprestimos.Rows[e.RowIndex];

                dateTimePickerDataRegisto.Value = Convert.ToDateTime(row.Cells["Data_Registro"].Value);
                dateTimePickerDataDevolucao.Value = Convert.ToDateTime(row.Cells["Data_Prevista_Devolucao"].Value);
                txtNumeroSocio.Text = row.Cells["Numero_Socio"].Value.ToString();
                comboBoxFuncionarioID.SelectedValue = row.Cells["ID_Funcionario"].Value;
            }
        }

        private void btnEditarEmprestimo_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmprestimos.CurrentRow != null)
            {
                try
                {
                    DataGridViewRow row = dataGridViewEmprestimos.CurrentRow;
                    DateTime dataRegistro = dateTimePickerDataRegisto.Value;
                    DateTime dataPrevistaDevolucao = dateTimePickerDataDevolucao.Value;
                    int numeroSocio = Convert.ToInt32(txtNumeroSocio.Text);
                    int idFuncionario = Convert.ToInt32(comboBoxFuncionarioID.SelectedValue);

                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        string query = "UPDATE Emprestimo SET Data_Registro = @dataRegistro, Data_Prevista_Devolucao = @dataPrevistaDevolucao, " +
                                       "Numero_Socio = @numeroSocio, ID_Funcionario = @idFuncionario";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@dataRegistro", dataRegistro);
                        cmd.Parameters.AddWithValue("@dataPrevistaDevolucao", dataPrevistaDevolucao);
                        cmd.Parameters.AddWithValue("@numeroSocio", numeroSocio);
                        cmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Empréstimo atualizado com sucesso!");
                        LimparForm();
                        CarregarEmprestimos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o empréstimo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleciona um Empréstimo para atualizar.");
            }
        }

        private void LimparForm()
        {
            txtNumeroSocio.Clear();
            comboBoxFuncionarioID.SelectedIndex = -1;
            dateTimePickerDataRegisto.Value = DateTime.Now;
            dateTimePickerDataDevolucao.Value = DateTime.Now;
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            LimparForm();
        }
    }
}
