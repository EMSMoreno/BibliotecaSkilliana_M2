using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Socio
{
    public partial class FormVerSocio : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormVerSocio()
        {
            InitializeComponent();
        }

        #region Métodos

        private void FormVerSocio_Load(object sender, EventArgs e)
        {
            CarregarSocios();
        }

        private void CarregarSocios()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT * FROM Socio";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
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
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar sócios: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnApagar"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Tens a certeza que queres apagar este sócio?",
                                                    "Confirmação",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        int Numerosocio = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Numero_Socio"].Value);

                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            con.Open();
                            string deleteQuery = "DELETE FROM Socio WHERE Numero_Socio = @id";
                            SqlCommand cmd = new SqlCommand(deleteQuery, con);
                            cmd.Parameters.AddWithValue("@id", Numerosocio);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Sócio apagado com sucesso!");
                            CarregarSocios();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao apagar o sócio: " + ex.Message);
                    }
                }
            }
        }

        #endregion

        #region UI

        private void btnAdicionarSocio_Click(object sender, EventArgs e)
        {
            using (FormRegistarSocio formRegistarSocio = new FormRegistarSocio())
            { formRegistarSocio.ShowDialog(); }
        }

        private void btnEditarSocio_Click(object sender, EventArgs e)
        {
            using (FormEditarSocio formEditarSocio = new FormEditarSocio())
            { formEditarSocio.ShowDialog(); }
        }

        #endregion


    }
}
