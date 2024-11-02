using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Emprestimo
{
    public partial class FormVerEmprestimo : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormVerEmprestimo()
        {
            InitializeComponent();
        }

        #region Métodos

        private void FormRegistarEmprestimo_Load(object sender, EventArgs e)
        {
            CarregarEmprestimos();
        }

        private void CarregarEmprestimos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT * FROM Emprestimo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (!dataGridView1.Columns.Contains("btnApagar"))
                    {
                        AddDeleteButtonColumn();
                    }

                    if (!dataGridView1.Columns.Contains("DevolverButton"))
                    {
                        AddReturnButtonColumn();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar empréstimos: " + ex.Message);
            }
        }

        private void AddDeleteButtonColumn()
        {
            DataGridViewButtonColumn btnApagar = new DataGridViewButtonColumn
            {
                HeaderText = "Apagar",
                Name = "btnApagar",
                Text = "Apagar",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(btnApagar);
        }

        private void AddReturnButtonColumn()
        {
            DataGridViewButtonColumn devolverButton = new DataGridViewButtonColumn
            {
                HeaderText = "Devolver",
                Name = "DevolverButton",
                Text = "Devolver",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(devolverButton);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnApagar"].Index && e.RowIndex >= 0)
            {
                int idEmprestimo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID_Emprestimo"].Value);
                var confirmResult = MessageBox.Show("Tem a certeza de que deseja apagar este empréstimo?",
                                                     "Confirmar Exclusão",
                                                     MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    ApagarEmprestimo(idEmprestimo);
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns["DevolverButton"].Index && e.RowIndex >= 0)
            {
                int idEmprestimo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID_Emprestimo"].Value);
                DevolverEmprestimo(idEmprestimo);
            }
        }

        private void ApagarEmprestimo(int idEmprestimo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "DELETE FROM Emprestimo WHERE ID_Emprestimo = @IDEmprestimo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IDEmprestimo", idEmprestimo);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Empréstimo apagado com sucesso!");
                        CarregarEmprestimos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao apagar o empréstimo.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar o empréstimo: " + ex.Message);
            }
        }

        private void DevolverEmprestimo(int idEmprestimo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    string query = @"
            UPDATE Emprestimo 
            SET Estado = 'Devolvido', Data_Devolucao = @DataDevolucao
            WHERE ID_Emprestimo = @IDEmprestimo AND Estado = 'Ativo'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@DataDevolucao", DateTime.Now);
                    cmd.Parameters.AddWithValue("@IDEmprestimo", idEmprestimo);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Empréstimo devolvido com sucesso!");
                        CarregarEmprestimos();
                    }
                    else
                    {
                        MessageBox.Show("Erro: O empréstimo já foi devolvido ou não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao devolver o empréstimo: " + ex.Message);
            }
        }

        #endregion

        #region UI

        private void btnAdicionarEmprestimo_Click(object sender, EventArgs e)
        {
            using (FormRegistarEmprestimo formRegistarEmprestimo = new FormRegistarEmprestimo())
            { formRegistarEmprestimo.ShowDialog(); }
        }

        private void btnEditarEmprestimo_Click(object sender, EventArgs e)
        {
            using (FormEditarEmprestimo formEditarEmprestimo = new FormEditarEmprestimo())
            { formEditarEmprestimo.ShowDialog(); }
        }

        #endregion
    }
}
