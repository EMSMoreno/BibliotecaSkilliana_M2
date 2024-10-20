using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaSkilliana_M2.Livro
{
    public partial class FormApagarLivro : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["LibSkilliana_EduardoMoreno"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public FormApagarLivro()
        {
            InitializeComponent();
        }

        private void FormApagarLivro_Load(object sender, EventArgs e)
        {
            LoadLivrosComboBox();
        }

        private void LoadLivrosComboBox()
        {
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    string query = "SELECT ISBN, Titulo FROM Livro";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbLivros.DisplayMember = "Titulo";
                    cmbLivros.ValueMember = "ISBN";
                    cmbLivros.DataSource = dt;

                    cmbLivros.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar livros: " + ex.Message);
            }
        }

        private void btnApagarLivro_Click(object sender, EventArgs e)
        {
            if (cmbLivros.SelectedIndex != -1)
            {
                try
                {
                    using (con = new SqlConnection(cs))
                    {
                        con.Open();
                        string query = "DELETE FROM Livro WHERE ISBN = @ISBN";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@ISBN", cmbLivros.SelectedValue);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Livro apagado com sucesso!");
                            LoadLivrosComboBox();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao apagar o livro.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar o livro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um livro para apagar.");
            }
        }
    }
}
