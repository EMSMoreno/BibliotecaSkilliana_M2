using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Estante
{
    public partial class FormEditarEstante : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormEditarEstante()
        {
            InitializeComponent();
        }

        private void FormEditarEstante_Load(object sender, EventArgs e)
        {
            CarregarEstantes();
            CarregarSecoes();
        }

        private void CarregarEstantes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = @"
                SELECT e.Codigo_Estante, e.Descricao, s.Descricao AS Secao
                FROM Estante e
                JOIN Secao s ON e.Secao = s.Codigo_Secao";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewEstantes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar estantes: " + ex.Message);
            }
        }

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

                    comboBoxSecao.DataSource = dt;
                    comboBoxSecao.DisplayMember = "Descricao";
                    comboBoxSecao.ValueMember = "Codigo_Secao";
                    comboBoxSecao.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar seções: " + ex.Message);
            }
        }

        private void dataGridViewEstantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEstantes.Rows[e.RowIndex];

                txtDescricao.Text = row.Cells["Descricao"].Value.ToString();
                comboBoxSecao.SelectedValue = row.Cells["Codigo_Estante"].Value;
            }
        }

        private void btnEditarEstante_Click(object sender, EventArgs e)
        {
            if (comboBoxSecao.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleciona uma estante.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "UPDATE Estante SET Descricao = @Descricao WHERE Codigo_Estante = @CodigoEstante";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@CodigoEstante", comboBoxSecao.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Estante atualizada com sucesso!");

                    LimparForm();
                    CarregarEstantes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar estante: " + ex.Message);
            }
        }

        private void LimparForm()
        {
            txtDescricao.Clear();
            comboBoxSecao.SelectedIndex = -1;
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            LimparForm();
        }
    }
}