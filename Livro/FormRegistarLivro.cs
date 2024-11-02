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

        #region Métodos

        private void LimparForm()
        {
            txtISBN.Clear();
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

        private void ProcurarLivros(string criterio)
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
            FROM Livro 
            WHERE 
                Titulo LIKE @Criterio 
                OR ISBN = TRY_CONVERT(int, @Criterio)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Criterio", "%" + criterio + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewProcura.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum livro foi encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar o livro: " + ex.Message);
            }
        }

        #endregion

        #region UI

        private void btnRegistarLivro_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();

                    // Validação Código Estante (FK)
                    string estanteQuery = "SELECT COUNT(*) FROM Estante WHERE Codigo_Estante = @CodigoEstante";
                    SqlCommand estanteCmd = new SqlCommand(estanteQuery, con);
                    estanteCmd.Parameters.AddWithValue("@CodigoEstante", txtCodigoEstante.Text);

                    int estanteCount = (int)estanteCmd.ExecuteScalar();
                    if (estanteCount == 0)
                    {
                        MessageBox.Show("O Código de Estante inserido é inválido. Por favor, selecione um código válido.");
                        return;
                    }

                    // Verificar se o livro já existe (pelo Título ou ISBN)
                    string checkLivroQuery = "SELECT Quantidade FROM Livro WHERE Titulo = @Titulo";
                    SqlCommand checkLivroCmd = new SqlCommand(checkLivroQuery, con);
                    checkLivroCmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);

                    object quantidadeExistenteObj = checkLivroCmd.ExecuteScalar();

                    if (quantidadeExistenteObj != null)
                    {
                        int quantidadeExistente = Convert.ToInt32(quantidadeExistenteObj);
                        int novaQuantidade = quantidadeExistente + int.Parse(txtQuantidade.Text);

                        string updateLivroQuery = "UPDATE Livro SET Quantidade = @Quantidade WHERE Titulo = @Titulo";
                        SqlCommand updateLivroCmd = new SqlCommand(updateLivroQuery, con);
                        updateLivroCmd.Parameters.AddWithValue("@Quantidade", novaQuantidade);
                        updateLivroCmd.Parameters.AddWithValue("@Titulo", txtTitulo.Text);

                        updateLivroCmd.ExecuteNonQuery();
                        MessageBox.Show("Quantidade atualizada com sucesso!");
                    }
                    else
                    {
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
                        MessageBox.Show("Livro registrado com sucesso!");
                    }

                    LimparForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar o livro: " + ex.Message);
            }
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void btnProcurarLivro_Click(object sender, EventArgs e)
        {
            string criterioBusca = txtTituloProcura.Text.Trim();
            if (string.IsNullOrEmpty(criterioBusca))
            {
                MessageBox.Show("Procura aqui o livro através do Título ou do ISBN");
                return;
            }

            ProcurarLivros(criterioBusca);
        }

        private void btnLimparProcura_Click(object sender, EventArgs e)
        {
            txtTituloProcura.Clear();
        }

        #endregion

    }
}
