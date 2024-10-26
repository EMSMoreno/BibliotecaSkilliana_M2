using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Autor
{
    public partial class FormApagarAutor : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormApagarAutor()
        {
            InitializeComponent();
        }

        private void FormApagarAutor_Load(object sender, EventArgs e)
        {
            LoadAutores();
        }

        private void LoadAutores()
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT Nome FROM Autor";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbAutores.DataSource = dt;
                    cmbAutores.DisplayMember = "Nome";
                    cmbAutores.ValueMember = "Nome";
                    cmbAutores.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar autores: " + ex.Message);
            }
        }

        private void btnApagarAutor_Click(object sender, EventArgs e)
        {
            if (cmbAutores.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um autor para apagar.");
                return;
            }

            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "DELETE FROM Autor WHERE Nome = @Nome";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nome", cmbAutores.SelectedValue.ToString());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Autor apagado com sucesso!");
                        LoadAutores();
                    }
                    else
                    {
                        MessageBox.Show("Autor não encontrado ou não pôde ser apagado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar o autor: " + ex.Message);
            }
        }
    }
}