using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace BibliotecaSkilliana_M2
{
    public partial class FormLogin : Form
    {
        public class Utilizador
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }

        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

        public FormLogin()
        {
            InitializeComponent();
        }

        #region Métodos / Create User

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string username = txtUsernameNew.Text;
            string password = txtPasswordNew.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("O Username e a Password são de preenchimento obrigatório!");
                return;
            }

            string salt;
            string hashedPassword = PasswordHasher.HashPassword(password, out salt);

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "INSERT INTO Utilizadores (Nome, Password, Role) VALUES (@Nome, @Pass, 'espetador')";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nome", username);
                        cmd.Parameters.AddWithValue("@Pass", hashedPassword);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Utilizador criado com sucesso!");
                            txtUsernameNew.Text = "";
                            txtPasswordNew.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Erro ao criar utilizador! Tente novamente!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static class PasswordHasher
        {
            // Método para criar o hash da password e gerar o salt
            public static string HashPassword(string password, out string salt)
            {
                byte[] saltBytes = new byte[16];
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(saltBytes);
                }
                salt = Convert.ToBase64String(saltBytes);

                return HashPasswordWithSalt(password, salt);
            }

            // Método para gerar o hash da password com o salt fornecido
            public static string HashPasswordWithSalt(string password, string salt)
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        builder.Append(b.ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsernameNew.Clear();
            txtPasswordNew.Clear();
        }

        #endregion

        #region Metodos / Login User

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text; // Captura o nome de utilizador
            string pass = txtPassword.Text; // Captura a password

            // Verifica se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Preenche todos os campos.");
                return; // Sai do método se os campos estiverem vazios
            }

            // Chama o método de login e verifica se é bem-sucedido
            if (LoginUser(user, pass))
            {
                MessageBox.Show("Login bem-sucedido! Bem-vindo aos Cinemas Skillianos!");
                this.Hide(); // Esconde o formulário de login
                txtUsername.Text = ""; // Limpa o campo de utilizador
                txtPassword.Text = ""; // Limpa o campo de password
                new Dashboard().Show(); // Abre o formulário principal
            }
            else
            {
                MessageBox.Show("Nome de utilizador ou password inválidos."); // Mensagem de erro
            }
        }

        private bool LoginUser(string username, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // Query para selecionar a password hasheada do utilizador
                    string query = "SELECT Password FROM Utilizadores WHERE Nome = @Nome";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nome", username); // Adiciona o parâmetro de nome

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Pega a password armazenada
                                string storedHash = reader["Password"].ToString();

                                // Verifica a password fornecida comparando com a hasheada
                                if (VerifyPassword(password, storedHash))
                                {
                                    return true; // Login bem-sucedido
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message); // Mostra erro se houver
            }

            return false; // Se não encontrou o utilizador ou a password não corresponde
        }

        // Função para verificar a password
        private bool VerifyPassword(string password, string storedHash)
        {
            // Gera o hash da password fornecida
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Converte para hexadecimal
                }
                string hash = builder.ToString();

                // Comparar a hash gerada com a armazenada
                return hash == storedHash; // Retorna verdadeiro se corresponder
            }
        }

        #endregion
    }
}
