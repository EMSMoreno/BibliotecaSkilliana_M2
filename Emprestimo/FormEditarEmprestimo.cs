using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BibliotecaSkilliana_M2.Emprestimo
{
    public partial class FormEditarEmprestimo : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormEditarEmprestimo()
        {
            InitializeComponent();
        }

        #region Métodos

        private void FormEditarEmprestimo_Load(object sender, EventArgs e)
        {
            CarregarEmprestimos();
            CarregarFuncionarios();
            CarregarEstados();
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

        private void CarregarEstados()
        {
            try
            {
                cbEstado.Items.Clear();
                cbEstado.Items.Add("Ativo");
                cbEstado.Items.Add("Inativo");
                cbEstado.Items.Add("Devolvido");

                cbEstado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os estados do empréstimo: " + ex.Message);
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

                string estado = row.Cells["Estado"].Value.ToString();
                cbEstado.SelectedItem = estado; 
            }
        }

        private void LimparForm()
        {
            txtNumeroSocio.Clear();
            comboBoxFuncionarioID.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            dateTimePickerDataRegisto.Value = DateTime.Now;
            dateTimePickerDataDevolucao.Value = DateTime.Now;
        }

        private void EstenderEmprestimo(int idEmprestimo, DateTime novaDataDevolucao)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "UPDATE Emprestimo SET Data_Prevista_Devolucao = @novaDataDevolucao WHERE ID_Emprestimo = @idEmprestimo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@novaDataDevolucao", novaDataDevolucao);
                    cmd.Parameters.AddWithValue("@idEmprestimo", idEmprestimo);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data de devolução estendida com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao estender a data de devolução.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao estender a data de devolução: " + ex.Message);
            }
        }

        #endregion

        #region UI

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
                    string estado = cbEstado.SelectedItem?.ToString();

                    if (dataPrevistaDevolucao < dataRegistro)
                    {
                        MessageBox.Show("A data de devolução não pode ser anterior à data de registro.");
                        return;
                    }

                    if (string.IsNullOrEmpty(estado))
                    {
                        MessageBox.Show("Por favor, selecione um estado.");
                        return;
                    }

                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        string query = "UPDATE Emprestimo SET Data_Registro = @dataRegistro, Data_Prevista_Devolucao = @dataPrevistaDevolucao, " +
                                       "Numero_Socio = @numeroSocio, ID_Funcionario = @idFuncionario, Estado = @estado WHERE ID_Emprestimo = @idEmprestimo";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@dataRegistro", dataRegistro);
                        cmd.Parameters.AddWithValue("@dataPrevistaDevolucao", dataPrevistaDevolucao);
                        cmd.Parameters.AddWithValue("@numeroSocio", numeroSocio);
                        cmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@idEmprestimo", Convert.ToInt32(row.Cells["ID_Emprestimo"].Value));

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

        private void btnEstenderEmprestimo_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmprestimos.CurrentRow != null)
            {
                try
                {
                    DataGridViewRow row = dataGridViewEmprestimos.CurrentRow;
                    DateTime novaDataDevolucao = dateTimePickerDataDevolucao.Value;

                    DateTime dataRegistro = Convert.ToDateTime(row.Cells["Data_Registro"].Value);
                    if (novaDataDevolucao < dataRegistro)
                    {
                        MessageBox.Show("A nova data de devolução não pode ser anterior à data de registro.");
                        return;
                    }

                    int idEmprestimo = Convert.ToInt32(row.Cells["ID_Emprestimo"].Value);
                    EstenderEmprestimo(idEmprestimo, novaDataDevolucao);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao estender o empréstimo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleciona um Empréstimo para estender.");
            }
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        #endregion
    }
}
