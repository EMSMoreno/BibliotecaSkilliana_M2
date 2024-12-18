﻿using System.Configuration;
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

        #region Métodos

        private void FormRegistarEmprestimo_Load(object sender, EventArgs e)
        {
            CarregarFuncionarios();
            CarregarEstados();
        }

        private void CarregarFuncionarios()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT ID_Funcionario, Nome FROM Funcionario WHERE Estado = 'Ativo'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cbFuncionario.DataSource = dt;
                    cbFuncionario.DisplayMember = "Nome";
                    cbFuncionario.ValueMember = "ID_Funcionario";
                    cbFuncionario.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os funcionários: " + ex.Message);
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

        private void RegistarEmprestimo()
        {

            if (cbFuncionario.SelectedValue == null)
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

            if (cbEstado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um estado.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "INSERT INTO Emprestimo (Data_Registro, Data_Prevista_Devolucao, Numero_Socio, ID_Funcionario, Estado) VALUES (@dataRegistro, @dataPrevistaDevolucao, @numeroSocio, @idFuncionario, @estado)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@dataRegistro", DateTime.Now);
                    cmd.Parameters.AddWithValue("@dataPrevistaDevolucao", dateTimePickerDataDevolucao.Value);
                    cmd.Parameters.AddWithValue("@numeroSocio", numeroSocio);
                    cmd.Parameters.AddWithValue("@idFuncionario", Convert.ToInt32(cbFuncionario.SelectedValue));
                    cmd.Parameters.AddWithValue("@estado", cbEstado.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empréstimo registrado com sucesso!");

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

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Empréstimo não encontrado!");
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
            cbFuncionario.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            dateTimePickerDataDevolucao.Value = DateTime.Now;
            dateTimePickerDataRegisto.Value = DateTime.Now;
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
