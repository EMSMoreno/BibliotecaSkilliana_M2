using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaSkilliana_M2.Livro
{
    public partial class FormEditarLivro : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormEditarLivro()
        {
            InitializeComponent();
        }

        private void FormEditarLivro_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtISBN.Text = row.Cells["ISBN"].Value.ToString();
                txtTitulo.Text = row.Cells["Titulo"].Value.ToString();
                dtpDataLancamento.Value = Convert.ToDateTime(row.Cells["Data_Lancamento"].Value);
                txtSinopse.Text = row.Cells["Sinopse"].Value.ToString();
                txtEdicao.Text = row.Cells["Edicao"].Value.ToString();
                txtEditora.Text = row.Cells["Editora"].Value.ToString();
                txtIdioma.Text = row.Cells["Idioma"].Value.ToString();
                txtNumeroPaginas.Text = row.Cells["Numero_Paginas"].Value.ToString();
                txtEstado.Text = row.Cells["Estado"].Value.ToString();
                txtCodigoEstante.Text = row.Cells["Codigo_Estante"].Value.ToString();
                txtQuantidade.Text = row.Cells["Quantidade"].Value.ToString();
            }
        }

        private void btnEditarLivro_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = @"
                UPDATE Livro
                SET 
                    Titulo = @Titulo, 
                    Data_Lancamento = @DataLancamento, 
                    Sinopse = @Sinopse, 
                    Edicao = @Edicao, 
                    Editora = @Editora, 
                    Idioma = @Idioma, 
                    Numero_Paginas = @NumeroPaginas, 
                    Estado = @Estado, 
                    Codigo_Estante = @CodigoEstante, 
                    Quantidade = @Quantidade
                WHERE ISBN = @ISBN";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
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

                    MessageBox.Show("Livro Atualizado com Sucesso!");
                    LoadLivros();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o livro: " + ex.Message);
            }
        }
    }
}
