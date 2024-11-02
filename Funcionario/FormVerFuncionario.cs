using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Funcionario
{
    public partial class FormVerFuncionario : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormVerFuncionario()
        {
            InitializeComponent();
        }

        private void FormRegistarFuncionario_Load(object sender, EventArgs e)
        {
            LoadFuncionarios();
        }

        private void LoadFuncionarios()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = @"
                    SELECT 
                        ID_Funcionario, 
                        Nome, 
                        Morada, 
                        Telefone, 
                        Email, 
                        Data_Nascimento, 
                        Numero_Funcionario, 
                        Tipo, 
                        Estado 
                    FROM Funcionario";
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
                MessageBox.Show("Erro ao carregar os Funcionários: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnApagar"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Tens a certeza que queres apagar este funcionário?",
                                                    "Confirmação",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        int funcionarioId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID_Funcionario"].Value);

                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            con.Open();
                            string deleteQuery = "DELETE FROM Funcionario WHERE ID_Funcionario = @id";
                            SqlCommand cmd = new SqlCommand(deleteQuery, con);
                            cmd.Parameters.AddWithValue("@id", funcionarioId);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Funcionário apagado com sucesso!");
                            LoadFuncionarios();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao apagar o funcionário: " + ex.Message);
                    }
                }
            }
        }

        private void btnAdicionarSocio_Click(object sender, EventArgs e)
        {
            using (FormRegistarFuncionario formRegistarFuncionario = new FormRegistarFuncionario())
            { formRegistarFuncionario.ShowDialog(); }
        }

        private void btnEditarSocio_Click(object sender, EventArgs e)
        {
            using (FormEditarFuncionario formEditarFuncionario = new FormEditarFuncionario())
            { formEditarFuncionario.ShowDialog(); }

        }
    }
}
