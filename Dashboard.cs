using BibliotecaSkilliana_M2.Autor;
using BibliotecaSkilliana_M2.Emprestimo;
using BibliotecaSkilliana_M2.Estante;
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

        // Chamar os CRUDS

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

        #endregion

        #region Menu Strip - Estante

        private void registarEstanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formRegistarEstante = new FormRegistarEstante())
            { formRegistarEstante.ShowDialog(); }
        }

        private void editarEstanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formEditarEstante = new FormEditarEstante())
            { formEditarEstante.ShowDialog(); }
        }

        private void apagarEstanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formApagarEstante = new FormApagarEstante())
            { formApagarEstante.ShowDialog(); }
        }

        #endregion

        #region Menu Strip - Autor

        private void registarAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formRegistarAutor = new FormRegistarAutor())
            { formRegistarAutor.ShowDialog(); }
        }

        private void editarAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formEditarAutor = new FormEditarAutor())
            { formEditarAutor.ShowDialog(); }
        }

        private void apagarAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formApagarAutor = new FormApagarAutor())
            { formApagarAutor.ShowDialog(); }
        }

        #endregion

        private void btnGestãoLivro_Click(object sender, EventArgs e)
        {
            using (FormVerLivro formVerLivro = new FormVerLivro())
            { formVerLivro.ShowDialog(); }
        }

        private void btnGestãoSócio_Click(object sender, EventArgs e)
        {
            using (FormVerSocio formVerSocio = new FormVerSocio())
            { formVerSocio.ShowDialog(); }
        }

        private void btnGestaoEmprestimo_Click(object sender, EventArgs e)
        {
            using (FormVerEmprestimo formVerEmprestimo = new FormVerEmprestimo())
            { formVerEmprestimo.ShowDialog(); }
        }

        private void btnGestaoFuncionário_Click(object sender, EventArgs e)
        {
            using (FormVerFuncionario formVerFuncionario = new FormVerFuncionario())
            { formVerFuncionario.ShowDialog(); }
        }

        private void btnGestãoAutor_Click(object sender, EventArgs e)
        {
            using (FormVerAutor formVerAutor = new FormVerAutor())
            { formVerAutor.ShowDialog(); }
        }

        private void btnGestãoSecção_Click(object sender, EventArgs e)
        {
            using (FormVerSecao formVerSecao = new FormVerSecao())
            { formVerSecao.ShowDialog(); }
        }

        private void btnGestaoEstante_Click(object sender, EventArgs e)
        {
            using (FormVerEstante formVerEstante = new FormVerEstante())
            { formVerEstante.ShowDialog(); }
        }
    }
}
