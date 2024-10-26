using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaSkilliana_M2.Autor
{
    public partial class FormRegistarAutor : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormRegistarAutor()
        {
            InitializeComponent();
        }

        private void FormRegistarAutor_Load(object sender, EventArgs e)
        {
            CarregarSecoes();
            CarregarAutores();
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

                    cmbCodSecao.DataSource = dt;
                    cmbCodSecao.DisplayMember = "Descricao";
                    cmbCodSecao.ValueMember = "Codigo_Secao";
                    cmbCodSecao.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar seções: " + ex.Message);
            }
        }

        private void CarregarAutores()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT * FROM Autor";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewAutores.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum autor encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar autores: " + ex.Message);
            }
        }

        private void RegistarAutor()
        {
            if (cmbCodSecao.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione uma seção.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "INSERT INTO Autor (Nome, Data_Nascimento, Biografia, Facebook, Instagram, X_Twitter, Codigo_Secao) " +
                                   "VALUES (@Nome, @DataNascimento, @Biografia, @Facebook, @Instagram, @Twitter, @Secao)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Nome", txtNomeAutor.Text);
                    cmd.Parameters.AddWithValue("@DataNascimento", dtpDataNasc.Value);
                    cmd.Parameters.AddWithValue("@Biografia", txtBiografia.Text);
                    cmd.Parameters.AddWithValue("@Facebook", txtFacebook.Text);
                    cmd.Parameters.AddWithValue("@Instagram", txtInstagram.Text);
                    cmd.Parameters.AddWithValue("@Twitter", txtTwitter.Text);
                    cmd.Parameters.AddWithValue("@Secao", cmbCodSecao.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Autor registrado com sucesso!");

                    LimparForm();
                    CarregarAutores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar autor: " + ex.Message);
            }
        }

        private void LimparForm()
        {
            txtNomeAutor.Clear();
            dtpDataNasc.Value = DateTime.Now;
            txtBiografia.Clear();
            txtFacebook.Clear();
            txtInstagram.Clear();
            txtTwitter.Clear();
            cmbCodSecao.SelectedIndex = -1;
        }

#endregion

        #region UI

        private void btnRegistarAutor_Click(object sender, EventArgs e)
        {
            RegistarAutor();
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

#endregion
    }
}
