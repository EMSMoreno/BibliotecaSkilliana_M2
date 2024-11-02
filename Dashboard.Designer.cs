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
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 38);
            label1.Name = "label1";
            label1.Size = new Size(302, 30);
            label1.TabIndex = 0;
            label1.Text = "Bem-vindos à Biblioteca Skilliana.\r\nPor favor, escolhe uma das opções, no menu superior.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 456);
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
            btnGestãoLivro.Location = new Point(181, 116);
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
            btnGestãoSócio.Location = new Point(60, 227);
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
            btnGestaoEmprestimo.Location = new Point(425, 116);
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
            btnGestaoFuncionário.Location = new Point(296, 227);
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
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(205, 30);
            label3.TabIndex = 70;
            label3.Text = "Add filtros pelos q estao por entregar.\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 36);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 71;
            label4.Text = "label é os cards";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 12);
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
            btnGestaoEstante.Location = new Point(543, 227);
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
            btnGestãoSecção.Location = new Point(181, 350);
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
            btnGestãoAutor.Location = new Point(425, 350);
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
            ClientSize = new Size(805, 496);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
