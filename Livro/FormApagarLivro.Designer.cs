namespace BibliotecaSkilliana_M2.Livro
{
    partial class FormApagarLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApagarLivro));
            btnApagarLivro = new Button();
            cmbLivros = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            lblApagarLivro = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnApagarLivro
            // 
            btnApagarLivro.FlatAppearance.BorderColor = Color.Red;
            btnApagarLivro.FlatStyle = FlatStyle.Flat;
            btnApagarLivro.Location = new Point(293, 299);
            btnApagarLivro.Name = "btnApagarLivro";
            btnApagarLivro.Size = new Size(237, 36);
            btnApagarLivro.TabIndex = 3;
            btnApagarLivro.Text = "Apagar Livro";
            btnApagarLivro.UseVisualStyleBackColor = true;
            btnApagarLivro.Click += btnApagarLivro_Click;
            // 
            // cmbLivros
            // 
            cmbLivros.FlatStyle = FlatStyle.Flat;
            cmbLivros.FormattingEnabled = true;
            cmbLivros.Location = new Point(293, 199);
            cmbLivros.Name = "cmbLivros";
            cmbLivros.Size = new Size(237, 23);
            cmbLivros.TabIndex = 2;
            cmbLivros.Text = "Selecione o Livro a Apagar";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 41);
            panel1.TabIndex = 4;
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
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 64);
            panel2.TabIndex = 5;
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
            // lblApagarLivro
            // 
            lblApagarLivro.AutoSize = true;
            lblApagarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblApagarLivro.Location = new Point(69, 111);
            lblApagarLivro.Name = "lblApagarLivro";
            lblApagarLivro.Size = new Size(214, 21);
            lblApagarLivro.TabIndex = 13;
            lblApagarLivro.Text = "Menu Livros - Apagar Livro";
            // 
            // FormApagarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblApagarLivro);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnApagarLivro);
            Controls.Add(cmbLivros);
            Name = "FormApagarLivro";
            Text = "FormApagarLivro";
            Load += FormApagarLivro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnApagarLivro;
        private ComboBox cmbLivros;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label lblApagarLivro;
    }
}