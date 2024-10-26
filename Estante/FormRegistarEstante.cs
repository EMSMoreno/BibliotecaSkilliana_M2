using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Estante
{
    public partial class FormRegistarEstante : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormRegistarEstante()
        {
            InitializeComponent();
        }

        private void FormRegistarEstante_Load(object sender, EventArgs e)
        {
            CarregarSecoes();
            CarregarEstantes();
        }

        #region Métodos

        private void CarregarSecoes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT Codigo_Secao, Descricao FROM Secao";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBoxSecao.DataSource = dt;
                    comboBoxSecao.DisplayMember = "Descricao";
                    comboBoxSecao.ValueMember = "Codigo_Secao";
                    comboBoxSecao.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar seções: " + ex.Message);
            }
        }

        private void CarregarEstantes(string busca = null)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT * FROM Estante";

                    if (!string.IsNullOrEmpty(busca))
                    {
                        query += " WHERE Descricao LIKE @busca";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    if (!string.IsNullOrEmpty(busca))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@busca", "%" + busca + "%");
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (string.IsNullOrEmpty(busca))
                    {
                        dataGridViewEstantes.DataSource = dt;
                    }
                    else
                    {
                        dataGridViewProcura.DataSource = dt;
                    }

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma estante encontrada.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar estantes: " + ex.Message);
            }
        }

        private void RegistarEstante()
        {
            if (comboBoxSecao.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione uma seção.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "INSERT INTO Estante (Descricao, Secao) VALUES (@descricao, @secao)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@secao", comboBoxSecao.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Estante registrada com sucesso!");

                    LimparForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar estante: " + ex.Message);
            }
        }

        private void LimparForm()
        {
            txtDescricao.Clear();
            comboBoxSecao.SelectedIndex = -1;
        }

        private void LimparFormProcura()
        {
            txtProcuraDescricao.Clear();
            comboBoxSecao.SelectedIndex = -1;
        }

        #endregion

        #region UI

        private void btnRegistarEstante_Click(object sender, EventArgs e)
        {
            RegistarEstante();
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void btnProcuraEstante_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProcuraDescricao.Text))
            {
                MessageBox.Show("Por favor, insira uma descrição para procurar.");
                return;
            }

            CarregarEstantes(txtProcuraDescricao.Text);
        }

        private void btnLimparFormProcura_Click(object sender, EventArgs e)
        {
            LimparFormProcura();
        }

        #endregion
    }
}
