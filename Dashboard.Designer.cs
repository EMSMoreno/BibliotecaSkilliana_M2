namespace BibliotecaSkilliana_M2
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            menuStrip2 = new MenuStrip();
            livrosToolStripMenuItem = new ToolStripMenuItem();
            registarLivroToolStripMenuItem = new ToolStripMenuItem();
            editarLivroToolStripMenuItem = new ToolStripMenuItem();
            apagarLivroToolStripMenuItem = new ToolStripMenuItem();
            estanteToolStripMenuItem = new ToolStripMenuItem();
            registarEstanteToolStripMenuItem = new ToolStripMenuItem();
            editarEstanteToolStripMenuItem = new ToolStripMenuItem();
            apagarEstanteToolStripMenuItem = new ToolStripMenuItem();
            secçãoToolStripMenuItem = new ToolStripMenuItem();
            registarSecçãoToolStripMenuItem = new ToolStripMenuItem();
            editarSecçãoToolStripMenuItem = new ToolStripMenuItem();
            apagarSecçãoToolStripMenuItem = new ToolStripMenuItem();
            autorToolStripMenuItem = new ToolStripMenuItem();
            registarAutorToolStripMenuItem = new ToolStripMenuItem();
            editarAutorToolStripMenuItem = new ToolStripMenuItem();
            apagarAutorToolStripMenuItem = new ToolStripMenuItem();
            empréstimoToolStripMenuItem = new ToolStripMenuItem();
            registarEmpréstimoToolStripMenuItem = new ToolStripMenuItem();
            editarEmpréstimoToolStripMenuItem = new ToolStripMenuItem();
            apagarEmpréstimoToolStripMenuItem = new ToolStripMenuItem();
            sócioToolStripMenuItem = new ToolStripMenuItem();
            registarSócioToolStripMenuItem = new ToolStripMenuItem();
            editarSócioToolStripMenuItem = new ToolStripMenuItem();
            apagarSócioToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            registarFuncionárioToolStripMenuItem = new ToolStripMenuItem();
            editarFuncionárioToolStripMenuItem = new ToolStripMenuItem();
            apagarFuncionárioToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label2 = new Label();
            btnGestãoLivro = new Button();
            btnGestãoSócio = new Button();
            btnGestaoEmprestimo = new Button();
            btnGestaoFuncionário = new Button();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnGestaoEstante = new Button();
            btnGestãoSecção = new Button();
            btnGestãoAutor = new Button();
            menuStrip2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 78);
            label1.Name = "label1";
            label1.Size = new Size(293, 30);
            label1.TabIndex = 0;
            label1.Text = "Bem-vindos à Biblioteca Skilliana.\r\nPor favor, escolhe uma das opções, no menu superior.\r\n";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { livrosToolStripMenuItem, estanteToolStripMenuItem, secçãoToolStripMenuItem, autorToolStripMenuItem, empréstimoToolStripMenuItem, sócioToolStripMenuItem, funcionárioToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(805, 24);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // livrosToolStripMenuItem
            // 
            livrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registarLivroToolStripMenuItem, editarLivroToolStripMenuItem, apagarLivroToolStripMenuItem });
            livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            livrosToolStripMenuItem.Size = new Size(45, 20);
            livrosToolStripMenuItem.Text = "Livro";
            // 
            // registarLivroToolStripMenuItem
            // 
            registarLivroToolStripMenuItem.Name = "registarLivroToolStripMenuItem";
            registarLivroToolStripMenuItem.Size = new Size(145, 22);
            registarLivroToolStripMenuItem.Text = "Registar Livro";
            registarLivroToolStripMenuItem.Click += registarLivroToolStripMenuItem_Click;
            // 
            // editarLivroToolStripMenuItem
            // 
            editarLivroToolStripMenuItem.Name = "editarLivroToolStripMenuItem";
            editarLivroToolStripMenuItem.Size = new Size(145, 22);
            editarLivroToolStripMenuItem.Text = "Editar Livro";
            editarLivroToolStripMenuItem.Click += editarLivroToolStripMenuItem_Click;
            // 
            // apagarLivroToolStripMenuItem
            // 
            apagarLivroToolStripMenuItem.Name = "apagarLivroToolStripMenuItem";
            apagarLivroToolStripMenuItem.Size = new Size(145, 22);
            apagarLivroToolStripMenuItem.Text = "Apagar Livro";
            apagarLivroToolStripMenuItem.Click += apagarLivroToolStripMenuItem_Click;
            // 
            // estanteToolStripMenuItem
            // 
            estanteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registarEstanteToolStripMenuItem, editarEstanteToolStripMenuItem, apagarEstanteToolStripMenuItem });
            estanteToolStripMenuItem.Name = "estanteToolStripMenuItem";
            estanteToolStripMenuItem.Size = new Size(57, 20);
            estanteToolStripMenuItem.Text = "Estante";
            // 
            // registarEstanteToolStripMenuItem
            // 
            registarEstanteToolStripMenuItem.Name = "registarEstanteToolStripMenuItem";
            registarEstanteToolStripMenuItem.Size = new Size(157, 22);
            registarEstanteToolStripMenuItem.Text = "Registar Estante";
            registarEstanteToolStripMenuItem.Click += registarEstanteToolStripMenuItem_Click;
            // 
            // editarEstanteToolStripMenuItem
            // 
            editarEstanteToolStripMenuItem.Name = "editarEstanteToolStripMenuItem";
            editarEstanteToolStripMenuItem.Size = new Size(157, 22);
            editarEstanteToolStripMenuItem.Text = "Editar Estante";
            editarEstanteToolStripMenuItem.Click += editarEstanteToolStripMenuItem_Click;
            // 
            // apagarEstanteToolStripMenuItem
            // 
            apagarEstanteToolStripMenuItem.Name = "apagarEstanteToolStripMenuItem";
            apagarEstanteToolStripMenuItem.Size = new Size(157, 22);
            apagarEstanteToolStripMenuItem.Text = "Apagar Estante";
            apagarEstanteToolStripMenuItem.Click += apagarEstanteToolStripMenuItem_Click;
            // 
            // secçãoToolStripMenuItem
            // 
            secçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registarSecçãoToolStripMenuItem, editarSecçãoToolStripMenuItem, apagarSecçãoToolStripMenuItem });
            secçãoToolStripMenuItem.Name = "secçãoToolStripMenuItem";
            secçãoToolStripMenuItem.Size = new Size(56, 20);
            secçãoToolStripMenuItem.Text = "Secção";
            // 
            // registarSecçãoToolStripMenuItem
            // 
            registarSecçãoToolStripMenuItem.Name = "registarSecçãoToolStripMenuItem";
            registarSecçãoToolStripMenuItem.Size = new Size(156, 22);
            registarSecçãoToolStripMenuItem.Text = "Registar Secção";
            registarSecçãoToolStripMenuItem.Click += registarSecçãoToolStripMenuItem_Click;
            // 
            // editarSecçãoToolStripMenuItem
            // 
            editarSecçãoToolStripMenuItem.Name = "editarSecçãoToolStripMenuItem";
            editarSecçãoToolStripMenuItem.Size = new Size(156, 22);
            editarSecçãoToolStripMenuItem.Text = "Editar Secção";
            editarSecçãoToolStripMenuItem.Click += editarSecçãoToolStripMenuItem_Click;
            // 
            // apagarSecçãoToolStripMenuItem
            // 
            apagarSecçãoToolStripMenuItem.Name = "apagarSecçãoToolStripMenuItem";
            apagarSecçãoToolStripMenuItem.Size = new Size(156, 22);
            apagarSecçãoToolStripMenuItem.Text = "Apagar Secção";
            apagarSecçãoToolStripMenuItem.Click += apagarSecçãoToolStripMenuItem_Click;
            // 
            // autorToolStripMenuItem
            // 
            autorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registarAutorToolStripMenuItem, editarAutorToolStripMenuItem, apagarAutorToolStripMenuItem });
            autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            autorToolStripMenuItem.Size = new Size(49, 20);
            autorToolStripMenuItem.Text = "Autor";
            // 
            // registarAutorToolStripMenuItem
            // 
            registarAutorToolStripMenuItem.Name = "registarAutorToolStripMenuItem";
            registarAutorToolStripMenuItem.Size = new Size(149, 22);
            registarAutorToolStripMenuItem.Text = "Registar Autor";
            registarAutorToolStripMenuItem.Click += registarAutorToolStripMenuItem_Click;
            // 
            // editarAutorToolStripMenuItem
            // 
            editarAutorToolStripMenuItem.Name = "editarAutorToolStripMenuItem";
            editarAutorToolStripMenuItem.Size = new Size(149, 22);
            editarAutorToolStripMenuItem.Text = "Editar Autor";
            editarAutorToolStripMenuItem.Click += editarAutorToolStripMenuItem_Click;
            // 
            // apagarAutorToolStripMenuItem
            // 
            apagarAutorToolStripMenuItem.Name = "apagarAutorToolStripMenuItem";
            apagarAutorToolStripMenuItem.Size = new Size(149, 22);
            apagarAutorToolStripMenuItem.Text = "Apagar Autor";
            apagarAutorToolStripMenuItem.Click += apagarAutorToolStripMenuItem_Click;
            // 
            // empréstimoToolStripMenuItem
            // 
            empréstimoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registarEmpréstimoToolStripMenuItem, editarEmpréstimoToolStripMenuItem, apagarEmpréstimoToolStripMenuItem });
            empréstimoToolStripMenuItem.Name = "empréstimoToolStripMenuItem";
            empréstimoToolStripMenuItem.Size = new Size(83, 20);
            empréstimoToolStripMenuItem.Text = "Empréstimo";
            // 
            // registarEmpréstimoToolStripMenuItem
            // 
            registarEmpréstimoToolStripMenuItem.Name = "registarEmpréstimoToolStripMenuItem";
            registarEmpréstimoToolStripMenuItem.Size = new Size(183, 22);
            registarEmpréstimoToolStripMenuItem.Text = "Registar Empréstimo";
            registarEmpréstimoToolStripMenuItem.Click += registarEmpréstimoToolStripMenuItem_Click;
            // 
            // editarEmpréstimoToolStripMenuItem
            // 
            editarEmpréstimoToolStripMenuItem.Name = "editarEmpréstimoToolStripMenuItem";
            editarEmpréstimoToolStripMenuItem.Size = new Size(183, 22);
            editarEmpréstimoToolStripMenuItem.Text = "Editar Empréstimo";
            editarEmpréstimoToolStripMenuItem.Click += editarEmpréstimoToolStripMenuItem_Click;
            // 
            // apagarEmpréstimoToolStripMenuItem
            // 
            apagarEmpréstimoToolStripMenuItem.Name = "apagarEmpréstimoToolStripMenuItem";
            apagarEmpréstimoToolStripMenuItem.Size = new Size(183, 22);
            apagarEmpréstimoToolStripMenuItem.Text = "Apagar Empréstimo";
            apagarEmpréstimoToolStripMenuItem.Click += apagarEmpréstimoToolStripMenuItem_Click;
            // 
            // sócioToolStripMenuItem
            // 
            sócioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registarSócioToolStripMenuItem, editarSócioToolStripMenuItem, apagarSócioToolStripMenuItem });
            sócioToolStripMenuItem.Name = "sócioToolStripMenuItem";
            sócioToolStripMenuItem.Size = new Size(48, 20);
            sócioToolStripMenuItem.Text = "Sócio";
            // 
            // registarSócioToolStripMenuItem
            // 
            registarSócioToolStripMenuItem.Name = "registarSócioToolStripMenuItem";
            registarSócioToolStripMenuItem.Size = new Size(148, 22);
            registarSócioToolStripMenuItem.Text = "Registar Sócio";
            registarSócioToolStripMenuItem.Click += registarSócioToolStripMenuItem_Click;
            // 
            // editarSócioToolStripMenuItem
            // 
            editarSócioToolStripMenuItem.Name = "editarSócioToolStripMenuItem";
            editarSócioToolStripMenuItem.Size = new Size(148, 22);
            editarSócioToolStripMenuItem.Text = "Editar Sócio";
            editarSócioToolStripMenuItem.Click += editarSócioToolStripMenuItem_Click;
            // 
            // apagarSócioToolStripMenuItem
            // 
            apagarSócioToolStripMenuItem.Name = "apagarSócioToolStripMenuItem";
            apagarSócioToolStripMenuItem.Size = new Size(148, 22);
            apagarSócioToolStripMenuItem.Text = "Apagar Sócio";
            apagarSócioToolStripMenuItem.Click += apagarSócioToolStripMenuItem_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registarFuncionárioToolStripMenuItem, editarFuncionárioToolStripMenuItem, apagarFuncionárioToolStripMenuItem });
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(82, 20);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // registarFuncionárioToolStripMenuItem
            // 
            registarFuncionárioToolStripMenuItem.Name = "registarFuncionárioToolStripMenuItem";
            registarFuncionárioToolStripMenuItem.Size = new Size(182, 22);
            registarFuncionárioToolStripMenuItem.Text = "Registar Funcionário";
            registarFuncionárioToolStripMenuItem.Click += registarFuncionárioToolStripMenuItem_Click;
            // 
            // editarFuncionárioToolStripMenuItem
            // 
            editarFuncionárioToolStripMenuItem.Name = "editarFuncionárioToolStripMenuItem";
            editarFuncionárioToolStripMenuItem.Size = new Size(182, 22);
            editarFuncionárioToolStripMenuItem.Text = "Editar Funcionário";
            editarFuncionárioToolStripMenuItem.Click += editarFuncionárioToolStripMenuItem_Click;
            // 
            // apagarFuncionárioToolStripMenuItem
            // 
            apagarFuncionárioToolStripMenuItem.Name = "apagarFuncionárioToolStripMenuItem";
            apagarFuncionárioToolStripMenuItem.Size = new Size(182, 22);
            apagarFuncionárioToolStripMenuItem.Text = "Apagar Funcionário";
            apagarFuncionárioToolStripMenuItem.Click += apagarFuncionárioToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 543);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 41);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(173, 14);
            label2.Name = "label2";
            label2.Size = new Size(446, 17);
            label2.TabIndex = 1;
            label2.Text = "@2024 WorldSkills Portugal Regional Exam - Portugal, September 2024";
            // 
            // btnGestãoLivro
            // 
            btnGestãoLivro.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnGestãoLivro.FlatStyle = FlatStyle.Flat;
            btnGestãoLivro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGestãoLivro.Location = new Point(173, 159);
            btnGestãoLivro.Name = "btnGestãoLivro";
            btnGestãoLivro.Size = new Size(204, 77);
            btnGestãoLivro.TabIndex = 66;
            btnGestãoLivro.Text = "Gestão de Livros 📖";
            btnGestãoLivro.UseVisualStyleBackColor = true;
            btnGestãoLivro.Click += btnGestãoLivro_Click;
            // 
            // btnGestãoSócio
            // 
            btnGestãoSócio.FlatAppearance.BorderColor = Color.Lime;
            btnGestãoSócio.FlatStyle = FlatStyle.Flat;
            btnGestãoSócio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGestãoSócio.Location = new Point(52, 270);
            btnGestãoSócio.Name = "btnGestãoSócio";
            btnGestãoSócio.Size = new Size(196, 77);
            btnGestãoSócio.TabIndex = 67;
            btnGestãoSócio.Text = "Gestão de Sócios 👔";
            btnGestãoSócio.UseVisualStyleBackColor = true;
            btnGestãoSócio.Click += btnGestãoSócio_Click;
            // 
            // btnGestaoEmprestimo
            // 
            btnGestaoEmprestimo.FlatAppearance.BorderColor = Color.Gold;
            btnGestaoEmprestimo.FlatStyle = FlatStyle.Flat;
            btnGestaoEmprestimo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGestaoEmprestimo.Location = new Point(417, 159);
            btnGestaoEmprestimo.Name = "btnGestaoEmprestimo";
            btnGestaoEmprestimo.Size = new Size(202, 77);
            btnGestaoEmprestimo.TabIndex = 68;
            btnGestaoEmprestimo.Text = "Gestão de Empréstimos 📚";
            btnGestaoEmprestimo.UseVisualStyleBackColor = true;
            btnGestaoEmprestimo.Click += btnGestaoEmprestimo_Click;
            // 
            // btnGestaoFuncionário
            // 
            btnGestaoFuncionário.FlatAppearance.BorderColor = Color.Crimson;
            btnGestaoFuncionário.FlatStyle = FlatStyle.Flat;
            btnGestaoFuncionário.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGestaoFuncionário.Location = new Point(288, 270);
            btnGestaoFuncionário.Name = "btnGestaoFuncionário";
            btnGestaoFuncionário.Size = new Size(196, 77);
            btnGestaoFuncionário.TabIndex = 69;
            btnGestaoFuncionário.Text = "Gestão de Funcionários \U0001f9cd";
            btnGestaoFuncionário.UseVisualStyleBackColor = true;
            btnGestaoFuncionário.Click += btnGestaoFuncionário_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(591, 111);
            label3.Name = "label3";
            label3.Size = new Size(205, 30);
            label3.TabIndex = 70;
            label3.Text = "Add filtros pelos q estao por entregar.\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 40);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 71;
            label4.Text = "label é os cards";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(637, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(159, 70);
            groupBox1.TabIndex = 72;
            groupBox1.TabStop = false;
            // 
            // btnGestaoEstante
            // 
            btnGestaoEstante.FlatAppearance.BorderColor = Color.DarkViolet;
            btnGestaoEstante.FlatStyle = FlatStyle.Flat;
            btnGestaoEstante.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGestaoEstante.Location = new Point(535, 270);
            btnGestaoEstante.Name = "btnGestaoEstante";
            btnGestaoEstante.Size = new Size(209, 77);
            btnGestaoEstante.TabIndex = 73;
            btnGestaoEstante.Text = "Gestão de Estantes 🔖";
            btnGestaoEstante.UseVisualStyleBackColor = true;
            btnGestaoEstante.Click += btnGestaoEstante_Click;
            // 
            // btnGestãoSecção
            // 
            btnGestãoSecção.FlatAppearance.BorderColor = Color.Orange;
            btnGestãoSecção.FlatStyle = FlatStyle.Flat;
            btnGestãoSecção.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGestãoSecção.Location = new Point(173, 393);
            btnGestãoSecção.Name = "btnGestãoSecção";
            btnGestãoSecção.Size = new Size(204, 77);
            btnGestãoSecção.TabIndex = 74;
            btnGestãoSecção.Text = "Gestão de Secções 📑";
            btnGestãoSecção.UseVisualStyleBackColor = true;
            btnGestãoSecção.Click += btnGestãoSecção_Click;
            // 
            // btnGestãoAutor
            // 
            btnGestãoAutor.FlatAppearance.BorderColor = Color.Black;
            btnGestãoAutor.FlatStyle = FlatStyle.Flat;
            btnGestãoAutor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGestãoAutor.Location = new Point(417, 393);
            btnGestãoAutor.Name = "btnGestãoAutor";
            btnGestãoAutor.Size = new Size(203, 77);
            btnGestãoAutor.TabIndex = 75;
            btnGestãoAutor.Text = "Gestão de Autores ✍️";
            btnGestãoAutor.UseVisualStyleBackColor = true;
            btnGestãoAutor.Click += btnGestãoAutor_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 583);
            Controls.Add(btnGestãoAutor);
            Controls.Add(btnGestãoSecção);
            Controls.Add(btnGestaoEstante);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(btnGestaoFuncionário);
            Controls.Add(btnGestaoEmprestimo);
            Controls.Add(btnGestãoSócio);
            Controls.Add(btnGestãoLivro);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(menuStrip2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Dashboard";
            Text = "Dashboard";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem livrosToolStripMenuItem;
        private ToolStripMenuItem registarLivroToolStripMenuItem;
        private ToolStripMenuItem editarLivroToolStripMenuItem;
        private ToolStripMenuItem apagarLivroToolStripMenuItem;
        private ToolStripMenuItem estanteToolStripMenuItem;
        private ToolStripMenuItem registarEstanteToolStripMenuItem;
        private ToolStripMenuItem editarEstanteToolStripMenuItem;
        private ToolStripMenuItem apagarEstanteToolStripMenuItem;
        private ToolStripMenuItem secçãoToolStripMenuItem;
        private ToolStripMenuItem registarSecçãoToolStripMenuItem;
        private ToolStripMenuItem editarSecçãoToolStripMenuItem;
        private ToolStripMenuItem apagarSecçãoToolStripMenuItem;
        private ToolStripMenuItem autorToolStripMenuItem;
        private ToolStripMenuItem registarAutorToolStripMenuItem;
        private ToolStripMenuItem editarAutorToolStripMenuItem;
        private ToolStripMenuItem apagarAutorToolStripMenuItem;
        private ToolStripMenuItem empréstimoToolStripMenuItem;
        private ToolStripMenuItem registarEmpréstimoToolStripMenuItem;
        private ToolStripMenuItem editarEmpréstimoToolStripMenuItem;
        private ToolStripMenuItem apagarEmpréstimoToolStripMenuItem;
        private ToolStripMenuItem sócioToolStripMenuItem;
        private ToolStripMenuItem registarSócioToolStripMenuItem;
        private ToolStripMenuItem editarSócioToolStripMenuItem;
        private ToolStripMenuItem apagarSócioToolStripMenuItem;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem registarFuncionárioToolStripMenuItem;
        private ToolStripMenuItem editarFuncionárioToolStripMenuItem;
        private ToolStripMenuItem apagarFuncionárioToolStripMenuItem;
        private Panel panel1;
        private Label label2;
        private Button btnGestãoLivro;
        private Button btnGestãoSócio;
        private Button btnGestaoEmprestimo;
        private Button btnGestaoFuncionário;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Button btnGestaoEstante;
        private Button btnGestãoSecção;
        private Button btnGestãoAutor;
    }
}
