using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Autor
{
    public partial class FormEditarAutor : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormEditarAutor()
        {
            InitializeComponent();
        }

        private void FormEditarAutor_Load(object sender, EventArgs e)
        {
            LoadAutores();
            LoadSecoes();
        }

        private void LoadAutores()
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = @"
                    SELECT
                        ID_Autor,   
                        Nome, 
                        Data_Nascimento, 
                        Biografia, 
                        Facebook, 
                        Instagram, 
                        X_Twitter, 
                        Codigo_Secao 
                    FROM Autor";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewAutores.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar autores: " + ex.Message);
            }
        }

        private void LoadSecoes()
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT Codigo_Secao, Descricao FROM Secao";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbCodSecao.DataSource = dt;
                    cmbCodSecao.DisplayMember = "Descricao";
                    cmbCodSecao.ValueMember = "Codigo_Secao";
                    cmbCodSecao.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar seções: " + ex.Message);
            }
        }

        private void LimparForm()
        {
            txtNomeAutor.Clear();
            dtpDataNasc.Value = DateTime.Now;
            txtBiografia.Clear();
            txtFacebook.Clear();
            txtInstagram.Clear();
            txtTwitter.Clear();
            cmbCodSecao.SelectedIndex = -1;
            dataGridViewAutores.ClearSelection();
        }

        private void dataGridViewAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewAutores.Rows[e.RowIndex];

                int autorId = (int)row.Cells["ID_Autor"].Value;

                txtNomeAutor.Text = row.Cells["Nome"].Value.ToString();
                dtpDataNasc.Value = Convert.ToDateTime(row.Cells["Data_Nascimento"].Value);
                txtBiografia.Text = row.Cells["Biografia"].Value.ToString();
                txtFacebook.Text = row.Cells["Facebook"].Value.ToString();
                txtInstagram.Text = row.Cells["Instagram"].Value.ToString();
                txtTwitter.Text = row.Cells["X_Twitter"].Value.ToString();
                cmbCodSecao.SelectedValue = row.Cells["Codigo_Secao"].Value;
            }
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void btnEditarAutor_Click(object sender, EventArgs e)
        {
            if (dataGridViewAutores.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um autor.");
                return;
            }

            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    int autorId = (int)dataGridViewAutores.CurrentRow.Cells["ID_Autor"].Value;

                    string query = @"
                UPDATE Autor
                SET 
                    Nome = @Nome, 
                    Data_Nascimento = @DataNascimento, 
                    Biografia = @Biografia, 
                    Facebook = @Facebook, 
                    Instagram = @Instagram, 
                    X_Twitter = @Twitter, 
                    Codigo_Secao = @Secao
                WHERE ID_Autor = @Id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nome", txtNomeAutor.Text);
                    cmd.Parameters.AddWithValue("@DataNascimento", dtpDataNasc.Value);
                    cmd.Parameters.AddWithValue("@Biografia", txtBiografia.Text);
                    cmd.Parameters.AddWithValue("@Facebook", txtFacebook.Text);
                    cmd.Parameters.AddWithValue("@Instagram", txtInstagram.Text);
                    cmd.Parameters.AddWithValue("@Twitter", txtTwitter.Text);
                    cmd.Parameters.AddWithValue("@Secao", cmbCodSecao.SelectedValue);
                    cmd.Parameters.AddWithValue("@Id", autorId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Autor atualizado com sucesso!");

                    LoadAutores();
                    LimparForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o autor: " + ex.Message);
            }
        }


    }
}
