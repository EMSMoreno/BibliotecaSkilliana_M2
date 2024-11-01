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

        #region Métodos

        private void LimparForm()
        {
            txtCodSecao.Clear();
            txtDescricaoSecao.Clear();
        }

        #endregion

        #region UI

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

        #endregion
    }
}
