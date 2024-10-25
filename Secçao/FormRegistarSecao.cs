using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Secçao
{
    public partial class FormRegistarSecao : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormRegistarSecao()
        {
            InitializeComponent();
        }

        private void FormRegistarSecao_Load(object sender, EventArgs e)
        {
            LoadSecoes();
        }

        private void LoadSecoes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT Codigo_Secao, Descricao FROM Secao";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar secções: " + ex.Message);
            }
        }

        private void btnRegistarSecao_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = @"INSERT INTO Secao (Descricao) VALUES (@Descricao)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Descricao", txtDescricaoSecao.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Secção registada com sucesso!");

                        LimparForm();
                        LoadSecoes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registar a Secção: " + ex.Message);
            }
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void LimparForm()
        {
            txtCodSecao.Clear();
            txtDescricaoSecao.Clear();
        }

        private void btnProcurarSecao_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    string query = @"
                SELECT Codigo_Secao, Descricao 
                FROM Secao 
                WHERE Descricao LIKE @Descricao";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Descricao", "%" + txtDescricaoProcura.Text + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridViewProcura.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma Seção foi encontrada.");
                            dataGridViewProcura.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar a Secção: " + ex.Message);
            }
        }

        private void btnLimparProcuraSecao_Click(object sender, EventArgs e)
        {
            LimparForm();
        }
    }
}
