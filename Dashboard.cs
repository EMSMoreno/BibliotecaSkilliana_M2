using BibliotecaSkilliana_M2.Emprestimo;
using BibliotecaSkilliana_M2.Funcionario;
using BibliotecaSkilliana_M2.Livro;
using BibliotecaSkilliana_M2.Secçao;
using BibliotecaSkilliana_M2.Socio;

namespace BibliotecaSkilliana_M2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        //fazer primeiros 4 CRUDS

        #region Menu Strip - Empréstimo

        private void registarEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formRegistarEmprestimo = new FormRegistarEmprestimo())
            { formRegistarEmprestimo.ShowDialog(); }
        }

        private void editarEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formEditarSocio = new FormEditarEmprestimo())
            { formEditarSocio.ShowDialog(); }
        }

        private void apagarEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formEditarSocio = new FormApagarEmprestimo())
            { formEditarSocio.ShowDialog(); }
        }

        #endregion

        #region Menu Strip - Sócio

        private void registarSócioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formRegistarSocio = new FormRegistarSocio())
            { formRegistarSocio.ShowDialog(); }
        }

        private void editarSócioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formEditarSocio = new FormEditarSocio())
            { formEditarSocio.ShowDialog(); }
        }

        private void apagarSócioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formApagarSocio = new FormApagarSocio())
            { formApagarSocio.ShowDialog(); }
        }

        #endregion

        #region Menu Strip - Funcionário

        private void registarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formRegistarFuncionario = new FormRegistarFuncionario())
            { formRegistarFuncionario.ShowDialog(); }
        }

        private void editarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formEditarFuncionario = new FormEditarFuncionario())
            { formEditarFuncionario.ShowDialog(); }
        }

        private void apagarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formApagarFuncionario = new FormApagarFuncionario())
            { formApagarFuncionario.ShowDialog(); }
        }

        #endregion

        #region Menu Strip - Livro

        private void registarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formRegistarLivro = new FormRegistarLivro())
            { formRegistarLivro.ShowDialog(); }
        }

        private void editarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formEditarLivro = new FormEditarLivro())
            { formEditarLivro.ShowDialog(); }
        }

        private void apagarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formApagarLivro = new FormApagarLivro())
            { formApagarLivro.ShowDialog(); }
        }

        #endregion

        #region Menu Strip - Secção

        private void registarSecçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formRegistarSecao = new FormRegistarSecao())
            { formRegistarSecao.ShowDialog(); }
        }

        #endregion

        private void editarSecçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formEditarSecao = new FormEditarSecao())
            { formEditarSecao.ShowDialog(); }
        }

        private void apagarSecçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formApagarSecao = new FormApagarSecao())
            { formApagarSecao.ShowDialog(); }
        }
    }
}
