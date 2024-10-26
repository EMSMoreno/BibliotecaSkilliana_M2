namespace BibliotecaSkilliana_M2.Estante
{
    partial class FormApagarEstante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApagarEstante));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            lblApagarLivro = new Label();
            btnApagarEstante = new Button();
            comboBoxEstantes = new ComboBox();
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
            panel2.Size = new Size(799, 64);
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
            panel1.Size = new Size(799, 41);
            panel1.TabIndex = 58;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(220, 14);
            label8.Name = "label8";
            label8.Size = new Size(446, 17);
            label8.TabIndex = 1;
            label8.Text = "@2024 WorldSkills Portugal Regional Exam - Portugal, September 2024";
            // 
            // lblApagarLivro
            // 
            lblApagarLivro.AutoSize = true;
            lblApagarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblApagarLivro.Location = new Point(69, 108);
            lblApagarLivro.Name = "lblApagarLivro";
            lblApagarLivro.Size = new Size(214, 21);
            lblApagarLivro.TabIndex = 61;
            lblApagarLivro.Text = "Menu Livros - Apagar Livro";
            // 
            // btnApagarEstante
            // 
            btnApagarEstante.FlatAppearance.BorderColor = Color.Red;
            btnApagarEstante.FlatStyle = FlatStyle.Flat;
            btnApagarEstante.Location = new Point(293, 296);
            btnApagarEstante.Name = "btnApagarEstante";
            btnApagarEstante.Size = new Size(237, 36);
            btnApagarEstante.TabIndex = 60;
            btnApagarEstante.Text = "Apagar Estante";
            btnApagarEstante.UseVisualStyleBackColor = true;
            btnApagarEstante.Click += btnApagarEstante_Click;
            // 
            // comboBoxEstantes
            // 
            comboBoxEstantes.FlatStyle = FlatStyle.Flat;
            comboBoxEstantes.FormattingEnabled = true;
            comboBoxEstantes.Location = new Point(293, 196);
            comboBoxEstantes.Name = "comboBoxEstantes";
            comboBoxEstantes.Size = new Size(237, 23);
            comboBoxEstantes.TabIndex = 59;
            comboBoxEstantes.Text = "Selecione a Estante a Apagar";
            // 
            // FormApagarEstante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblApagarLivro);
            Controls.Add(btnApagarEstante);
            Controls.Add(comboBoxEstantes);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormApagarEstante";
            Text = "FormApagarEstante";
            Load += FormApagarEstante_Load;
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
        private Label lblApagarLivro;
        private Button btnApagarEstante;
        private ComboBox comboBoxEstantes;
    }
}