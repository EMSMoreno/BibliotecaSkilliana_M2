using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Estante
{
    public partial class FormVerEstante : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormVerEstante()
        {
            InitializeComponent();
        }

        private void FormRegistarEstante_Load(object sender, EventArgs e)
        {
            CarregarEstantes();
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
                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhuma estante encontrada.");
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
                MessageBox.Show("Erro ao carregar as estantes: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnApagar"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Tens a certeza que quueres apagar esta estante?",
                                                    "Confirmação",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        int estanteId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID_Estante"].Value);

                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            con.Open();
                            string deleteQuery = "DELETE FROM Estante WHERE ID_Estante = @id";
                            SqlCommand cmd = new SqlCommand(deleteQuery, con);
                            cmd.Parameters.AddWithValue("@id", estanteId);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Estante apagada com sucesso!");
                            CarregarEstantes();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao apagar a estante: " + ex.Message);
                    }
                }
            }
        }

        private void btnAdicionarEstante_Click(object sender, EventArgs e)
        {
            using (FormRegistarEstante formRegistarEstante = new FormRegistarEstante())
            { formRegistarEstante.ShowDialog(); }
        }

        private void btnEditarEstante_Click(object sender, EventArgs e)
        {
            using (FormEditarEstante formEditarEstante = new FormEditarEstante())
            { formEditarEstante.ShowDialog(); }
        }

    }

}
