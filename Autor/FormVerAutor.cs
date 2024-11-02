using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Autor
{
    public partial class FormVerAutor : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormVerAutor()
        {
            InitializeComponent();
        }

        private void FormRegistarAutor_Load(object sender, EventArgs e)
        {
            CarregarAutores();
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
                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum autor encontrado.");
                    }

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
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar autores: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnApagar"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Tens a certeza que queres apagar este autor?",
                                                    "Confirmação",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        int autorId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID_Autor"].Value);

                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            con.Open();
                            string deleteQuery = "DELETE FROM Autor WHERE ID_Autor = @id";
                            SqlCommand cmd = new SqlCommand(deleteQuery, con);
                            cmd.Parameters.AddWithValue("@id", autorId);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Autor apagado com sucesso!");
                            CarregarAutores();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao apagar o autor: " + ex.Message);
                    }
                }
            }
        }

        private void btnAdicionarAutor_Click(object sender, EventArgs e)
        {
            using (FormRegistarAutor formRegistarAutor = new FormRegistarAutor())
            { formRegistarAutor.ShowDialog(); }
        }

        private void btnEditarAutor_Click(object sender, EventArgs e)
        {
            using (FormEditarAutor formEditarAutor = new FormEditarAutor())
            { formEditarAutor.ShowDialog(); }
        }

    }
}
