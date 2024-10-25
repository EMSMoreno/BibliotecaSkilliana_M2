using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaSkilliana_M2.Secçao
{
    public partial class FormEditarSecao : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormEditarSecao()
        {
            InitializeComponent();
        }

        private void FormEditarSecao_Load(object sender, EventArgs e)
        {
            CarregarSecoes();
        }

        private void CarregarSecoes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT Codigo_Secao, Descricao FROM Secao";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as Secções: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCodSecao.Text = row.Cells["Codigo_Secao"].Value.ToString();
                txtDescricaoSecao.Text = row.Cells["Descricao"].Value.ToString();
            }
        }

        private void btnEditarSecao_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "UPDATE Secao SET Descricao = @Descricao WHERE Codigo_Secao = @CodigoSecao";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Descricao", txtDescricaoSecao.Text);
                    cmd.Parameters.AddWithValue("@CodigoSecao", txtCodSecao.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Secção atualizada com sucesso!");
                        CarregarSecoes();
                        LimparForm();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar a Secção.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar alterações da Secção: " + ex.Message);
            }
        }

        private void LimparForm()
        {
            txtCodSecao.Clear();
            txtDescricaoSecao.Clear();
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            LimparForm();
        }
    }
}
