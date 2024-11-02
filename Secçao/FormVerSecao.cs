using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BibliotecaSkilliana_M2.Livro;

namespace BibliotecaSkilliana_M2.Secçao
{
    public partial class FormVerSecao : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormVerSecao()
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

                        if (dataGridView1.Columns["btnApagar"] == null)
                        {
                            DataGridViewButtonColumn btnApagar = new DataGridViewButtonColumn();
                            btnApagar.Name = "btnApagar";
                            btnApagar.HeaderText = "Ação";
                            btnApagar.Text = "Apagar";
                            btnApagar.UseColumnTextForButtonValue = true;
                            dataGridView1.Columns.Add(btnApagar);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar secções: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnApagar"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Tens a certeza que queres apagar esta secção?",
                                                    "Confirmação",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        int secaoId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Codigo_Secao"].Value);

                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            con.Open();
                            string deleteQuery = "DELETE FROM Secao WHERE Codigo_Secao = @id";
                            SqlCommand cmd = new SqlCommand(deleteQuery, con);
                            cmd.Parameters.AddWithValue("@id", secaoId);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Secção apagada com sucesso!");
                            LoadSecoes();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao apagar a secção: " + ex.Message);
                    }
                }
            }
        }

        private void btnAdicionarSecao_Click(object sender, EventArgs e)
        {
            using (FormRegistarSecao formRegistarSecao = new FormRegistarSecao())
            { formRegistarSecao.ShowDialog(); }
        }

        private void btnEditarSecao_Click(object sender, EventArgs e)
        {
            using (FormEditarSecao formEditarSecao = new FormEditarSecao())
            { formEditarSecao.ShowDialog(); }
        }
    }
}
