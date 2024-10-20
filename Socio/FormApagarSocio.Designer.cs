namespace BibliotecaSkilliana_M2.Socio
{
    partial class FormApagarSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApagarSocio));
            cmbSocios = new ComboBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            lblEditarLivro = new Label();
            panel1 = new Panel();
            label1 = new Label();
            btnApagarSocio = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbSocios
            // 
            cmbSocios.FormattingEnabled = true;
            cmbSocios.Location = new Point(202, 206);
            cmbSocios.Name = "cmbSocios";
            cmbSocios.Size = new Size(237, 23);
            cmbSocios.TabIndex = 0;
            cmbSocios.Text = "Selecione o Sócio a Apagar";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(680, 64);
            panel2.TabIndex = 11;
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
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(69, 113);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(222, 21);
            lblEditarLivro.TabIndex = 52;
            lblEditarLivro.Text = "Menu Sócios - Apagar Sócio";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 41);
            panel1.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(104, 14);
            label1.Name = "label1";
            label1.Size = new Size(446, 17);
            label1.TabIndex = 1;
            label1.Text = "@2024 WorldSkills Portugal Regional Exam - Portugal, September 2024";
            // 
            // btnApagarSocio
            // 
            btnApagarSocio.FlatAppearance.BorderColor = Color.Red;
            btnApagarSocio.FlatStyle = FlatStyle.Flat;
            btnApagarSocio.Location = new Point(202, 272);
            btnApagarSocio.Name = "btnApagarSocio";
            btnApagarSocio.Size = new Size(237, 30);
            btnApagarSocio.TabIndex = 77;
            btnApagarSocio.Text = "Apagar Sócio";
            btnApagarSocio.UseVisualStyleBackColor = true;
            // 
            // FormApagarSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 450);
            Controls.Add(btnApagarSocio);
            Controls.Add(panel1);
            Controls.Add(lblEditarLivro);
            Controls.Add(panel2);
            Controls.Add(cmbSocios);
            Name = "FormApagarSocio";
            Text = "FormApagarSocio";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSocios;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label lblEditarLivro;
        private Panel panel1;
        private Label label1;
        private Button btnApagarSocio;
    }
}