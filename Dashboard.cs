using BibliotecaSkilliana_M2.Emprestimo;
using BibliotecaSkilliana_M2.Funcionario;
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

        #region Menu Strip - Empr�stimo

        private void registarEmpr�stimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formRegistarEmprestimo = new FormRegistarEmprestimo())
            { formRegistarEmprestimo.ShowDialog(); }
        }

        private void editarEmpr�stimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formEditarSocio = new FormEditarEmprestimo())
            { formEditarSocio.ShowDialog(); }
        }

        private void apagarEmpr�stimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formEditarSocio = new FormApagarEmprestimo())
            { formEditarSocio.ShowDialog(); }
        }

        #endregion

        #region Menu Strip - S�cio

        private void registarS�cioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formRegistarSocio = new FormRegistarSocio())
            { formRegistarSocio.ShowDialog(); }
        }

        private void editarS�cioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formEditarSocio = new FormEditarSocio())
            { formEditarSocio.ShowDialog(); }
        }

        private void apagarS�cioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formApagarSocio = new FormApagarSocio())
            { formApagarSocio.ShowDialog(); }
        }

        #endregion

        #region Menu Strip - Funcion�rio

        private void registarFuncion�rioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formRegistarFuncionario = new FormRegistarFuncionario())
            { formRegistarFuncionario.ShowDialog(); }
        }

        private void editarFuncion�rioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formEditarFuncionario = new FormEditarFuncionario())
            { formEditarFuncionario.ShowDialog(); }
        }

        private void apagarFuncion�rioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formApagarFuncionario = new FormApagarFuncionario())
            { formApagarFuncionario.ShowDialog(); }
        }

        #endregion

    }
}