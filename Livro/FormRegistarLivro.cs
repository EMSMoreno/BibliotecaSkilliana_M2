using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaSkilliana_M2.Livro
{
    public partial class FormRegistarLivro : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormRegistarLivro()
        {
            InitializeComponent();
        }

        private void FormRegistarLivro_Load(object sender, EventArgs e)
        {
            LoadLivros();
        }

        private void LoadLivros()
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = @"
                SELECT 
                    ISBN, 
                    Titulo, 
                    Data_Lancamento, 
                    Sinopse, 
                    Edicao, 
                    Editora, 
                    Idioma, 
                    Numero_Paginas, 
                    Estado, 
                    Codigo_Estante, 
                    Quantidade 
                FROM Livro";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Livros: " + ex.Message);
            }
        }

        private void btnRegistarLivro_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = @"
                INSERT INTO Livro
                (Titulo, Data_Lancamento, Sinopse, Edicao, Editora, Idioma, Numero_Paginas, Estado, Codigo_Estante, Quantidade)
                VALUES
                (@Titulo, @DataLancamento, @Sinopse, @Edicao, @Editora, @Idioma, @NumeroPaginas, @Estado, @CodigoEstante, @Quantidade)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                    cmd.Parameters.AddWithValue("@DataLancamento", dtpDataLancamento.Value);
                    cmd.Parameters.AddWithValue("@Sinopse", txtSinopse.Text);
                    cmd.Parameters.AddWithValue("@Edicao", txtEdicao.Text);
                    cmd.Parameters.AddWithValue("@Editora", txtEditora.Text);
                    cmd.Parameters.AddWithValue("@Idioma", txtIdioma.Text);
                    cmd.Parameters.AddWithValue("@NumeroPaginas", txtNumeroPaginas.Text);
                    cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
                    cmd.Parameters.AddWithValue("@CodigoEstante", txtCodigoEstante.Text);
                    cmd.Parameters.AddWithValue("@Quantidade", txtQuantidade.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Livro registado com sucesso!");
                    LimparForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar o livro: " + ex.Message);
            }
        }

        private void LimparForm()
        {
            txtTitulo.Clear();
            dtpDataLancamento.Value = DateTime.Now;
            txtSinopse.Clear();
            txtEdicao.Clear();
            txtEditora.Clear();
            txtIdioma.Clear();
            txtNumeroPaginas.Clear();
            txtEstado.Clear();
            txtCodigoEstante.Clear();
            txtQuantidade.Clear();
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            LimparForm();
        }
    }
}
