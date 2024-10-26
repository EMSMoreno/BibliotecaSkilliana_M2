namespace BibliotecaSkilliana_M2.Autor
{
    partial class FormApagarAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApagarAutor));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            lblEditarLivro = new Label();
            cmbAutores = new ComboBox();
            btnApagarAutor = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 64);
            panel2.TabIndex = 57;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(69, 12);
            label9.Name = "label9";
            label9.Size = new Size(313, 30);
            label9.TabIndex = 0;
            label9.Text = "Bem-vindos à Livraria Skilliana";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 41);
            panel1.TabIndex = 58;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(169, 14);
            label8.Name = "label8";
            label8.Size = new Size(446, 17);
            label8.TabIndex = 1;
            label8.Text = "@2024 WorldSkills Portugal Regional Exam - Portugal, September 2024";
            // 
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(69, 100);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(233, 21);
            lblEditarLivro.TabIndex = 61;
            lblEditarLivro.Text = "Menu Autores - Apagar Autor";
            // 
            // cmbAutores
            // 
            cmbAutores.FlatStyle = FlatStyle.Flat;
            cmbAutores.FormattingEnabled = true;
            cmbAutores.Location = new Point(254, 196);
            cmbAutores.Name = "cmbAutores";
            cmbAutores.Size = new Size(233, 23);
            cmbAutores.TabIndex = 62;
            cmbAutores.Text = "Selecione o Autor a Apagar";
            // 
            // btnApagarAutor
            // 
            btnApagarAutor.FlatAppearance.BorderColor = Color.Red;
            btnApagarAutor.FlatStyle = FlatStyle.Flat;
            btnApagarAutor.Location = new Point(254, 285);
            btnApagarAutor.Name = "btnApagarAutor";
            btnApagarAutor.Size = new Size(233, 36);
            btnApagarAutor.TabIndex = 63;
            btnApagarAutor.Text = "Apagar Autor";
            btnApagarAutor.UseVisualStyleBackColor = true;
            btnApagarAutor.Click += btnApagarAutor_Click;
            // 
            // FormApagarAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnApagarAutor);
            Controls.Add(cmbAutores);
            Controls.Add(lblEditarLivro);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormApagarAutor";
            Text = "FormApagarAutor";
            Load += FormApagarAutor_Load;
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
        private Label label9;
        private Panel panel1;
        private Label label8;
        private Label lblEditarLivro;
        private ComboBox cmbAutores;
        private Button btnApagarAutor;
    }
}