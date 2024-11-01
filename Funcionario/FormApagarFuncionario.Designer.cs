namespace BibliotecaSkilliana_M2.Funcionario
{
    partial class FormApagarFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApagarFuncionario));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lblEditarLivro = new Label();
            cmbFuncionarios = new ComboBox();
            btnApagarFuncionario = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 64);
            panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(11, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 12);
            label2.Name = "label2";
            label2.Size = new Size(313, 30);
            label2.TabIndex = 0;
            label2.Text = "Bem-vindos à Livraria Skilliana";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 411);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 41);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(172, 15);
            label1.Name = "label1";
            label1.Size = new Size(446, 17);
            label1.TabIndex = 1;
            label1.Text = "@2024 WorldSkills Portugal Regional Exam - Portugal, September 2024";
            // 
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(69, 120);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(320, 21);
            lblEditarLivro.TabIndex = 77;
            lblEditarLivro.Text = "Menu Funcionários - Apagar Funcionário";
            // 
            // cmbFuncionarios
            // 
            cmbFuncionarios.FormattingEnabled = true;
            cmbFuncionarios.Location = new Point(247, 197);
            cmbFuncionarios.Name = "cmbFuncionarios";
            cmbFuncionarios.Size = new Size(300, 23);
            cmbFuncionarios.TabIndex = 78;
            cmbFuncionarios.Text = "Selecione o Funcionário a Apagar";
            // 
            // btnApagarFuncionario
            // 
            btnApagarFuncionario.FlatAppearance.BorderColor = Color.Red;
            btnApagarFuncionario.FlatStyle = FlatStyle.Flat;
            btnApagarFuncionario.Location = new Point(328, 279);
            btnApagarFuncionario.Name = "btnApagarFuncionario";
            btnApagarFuncionario.Size = new Size(171, 30);
            btnApagarFuncionario.TabIndex = 97;
            btnApagarFuncionario.Text = "Apagar Funcionário";
            btnApagarFuncionario.UseVisualStyleBackColor = true;
            btnApagarFuncionario.Click += btnApagarFuncionario_Click;
            // 
            // FormApagarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnApagarFuncionario);
            Controls.Add(cmbFuncionarios);
            Controls.Add(lblEditarLivro);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormApagarFuncionario";
            Text = "FormApagarFuncionario";
            Load += FormRegistarSecao_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label lblEditarLivro;
        private ComboBox cmbFuncionarios;
        private Button btnApagarFuncionario;
    }
}