namespace BibliotecaSkilliana_M2.Autor
{
    partial class FormEditarAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarAutor));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            lblEditarLivro = new Label();
            dataGridViewAutores = new DataGridView();
            txtNomeAutor = new TextBox();
            label1 = new Label();
            txtBiografia = new TextBox();
            lblBio = new Label();
            dtpDataNasc = new DateTimePicker();
            lblDataNasc = new Label();
            txtTwitter = new TextBox();
            lblTwitter = new Label();
            txtInstagram = new TextBox();
            lblInstagram = new Label();
            txtFacebook = new TextBox();
            lblFacebook = new Label();
            cmbCodSecao = new ComboBox();
            label2 = new Label();
            btnLimparForm = new Button();
            btnEditarAutor = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAutores).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(819, 64);
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
            panel1.Location = new Point(0, 531);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 41);
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
            lblEditarLivro.Location = new Point(69, 98);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(223, 21);
            lblEditarLivro.TabIndex = 61;
            lblEditarLivro.Text = "Menu Autores - Editar Autor";
            // 
            // dataGridViewAutores
            // 
            dataGridViewAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAutores.Location = new Point(69, 329);
            dataGridViewAutores.Name = "dataGridViewAutores";
            dataGridViewAutores.Size = new Size(734, 181);
            dataGridViewAutores.TabIndex = 62;
            dataGridViewAutores.CellClick += dataGridViewAutores_CellClick;
            // 
            // txtNomeAutor
            // 
            txtNomeAutor.Location = new Point(146, 161);
            txtNomeAutor.Name = "txtNomeAutor";
            txtNomeAutor.Size = new Size(183, 23);
            txtNomeAutor.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 164);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 67;
            label1.Text = "Nome Autor";
            // 
            // txtBiografia
            // 
            txtBiografia.Location = new Point(129, 238);
            txtBiografia.Multiline = true;
            txtBiografia.Name = "txtBiografia";
            txtBiografia.Size = new Size(200, 85);
            txtBiografia.TabIndex = 72;
            // 
            // lblBio
            // 
            lblBio.AutoSize = true;
            lblBio.Location = new Point(66, 241);
            lblBio.Name = "lblBio";
            lblBio.Size = new Size(54, 15);
            lblBio.TabIndex = 71;
            lblBio.Text = "Biografia";
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Location = new Point(164, 200);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(165, 23);
            dtpDataNasc.TabIndex = 70;
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(60, 206);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(98, 15);
            lblDataNasc.TabIndex = 69;
            lblDataNasc.Text = "Data Nascimento";
            // 
            // txtTwitter
            // 
            txtTwitter.Location = new Point(426, 249);
            txtTwitter.Name = "txtTwitter";
            txtTwitter.PlaceholderText = "twitter.com/escreve_assim";
            txtTwitter.Size = new Size(200, 23);
            txtTwitter.TabIndex = 80;
            // 
            // lblTwitter
            // 
            lblTwitter.AutoSize = true;
            lblTwitter.Location = new Point(344, 252);
            lblTwitter.Name = "lblTwitter";
            lblTwitter.Size = new Size(54, 15);
            lblTwitter.TabIndex = 79;
            lblTwitter.Text = "X/Twitter";
            // 
            // txtInstagram
            // 
            txtInstagram.Location = new Point(426, 205);
            txtInstagram.Name = "txtInstagram";
            txtInstagram.PlaceholderText = "instagram.com/escreve_assim";
            txtInstagram.Size = new Size(200, 23);
            txtInstagram.TabIndex = 78;
            // 
            // lblInstagram
            // 
            lblInstagram.AutoSize = true;
            lblInstagram.Location = new Point(344, 208);
            lblInstagram.Name = "lblInstagram";
            lblInstagram.Size = new Size(60, 15);
            lblInstagram.TabIndex = 77;
            lblInstagram.Text = "Instagram";
            // 
            // txtFacebook
            // 
            txtFacebook.Location = new Point(426, 161);
            txtFacebook.Name = "txtFacebook";
            txtFacebook.PlaceholderText = "facebook.com/escreve_assim";
            txtFacebook.Size = new Size(200, 23);
            txtFacebook.TabIndex = 76;
            // 
            // lblFacebook
            // 
            lblFacebook.AutoSize = true;
            lblFacebook.Location = new Point(344, 164);
            lblFacebook.Name = "lblFacebook";
            lblFacebook.Size = new Size(58, 15);
            lblFacebook.TabIndex = 75;
            lblFacebook.Text = "Facebook";
            // 
            // cmbCodSecao
            // 
            cmbCodSecao.FormattingEnabled = true;
            cmbCodSecao.Location = new Point(427, 289);
            cmbCodSecao.Name = "cmbCodSecao";
            cmbCodSecao.Size = new Size(200, 23);
            cmbCodSecao.TabIndex = 82;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 295);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 81;
            label2.Text = "Código Secção";
            // 
            // btnLimparForm
            // 
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(649, 241);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(154, 37);
            btnLimparForm.TabIndex = 84;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            btnLimparForm.Click += btnLimparForm_Click;
            // 
            // btnEditarAutor
            // 
            btnEditarAutor.FlatAppearance.BorderColor = Color.Yellow;
            btnEditarAutor.FlatStyle = FlatStyle.Flat;
            btnEditarAutor.Location = new Point(649, 284);
            btnEditarAutor.Name = "btnEditarAutor";
            btnEditarAutor.Size = new Size(154, 37);
            btnEditarAutor.TabIndex = 83;
            btnEditarAutor.Text = "Editar Autor";
            btnEditarAutor.UseVisualStyleBackColor = true;
            btnEditarAutor.Click += btnEditarAutor_Click;
            // 
            // FormEditarAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 570);
            Controls.Add(btnLimparForm);
            Controls.Add(btnEditarAutor);
            Controls.Add(cmbCodSecao);
            Controls.Add(label2);
            Controls.Add(txtTwitter);
            Controls.Add(lblTwitter);
            Controls.Add(txtInstagram);
            Controls.Add(lblInstagram);
            Controls.Add(txtFacebook);
            Controls.Add(lblFacebook);
            Controls.Add(txtBiografia);
            Controls.Add(lblBio);
            Controls.Add(dtpDataNasc);
            Controls.Add(lblDataNasc);
            Controls.Add(txtNomeAutor);
            Controls.Add(label1);
            Controls.Add(dataGridViewAutores);
            Controls.Add(lblEditarLivro);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormEditarAutor";
            Text = "FormEditarAutor";
            Load += FormEditarAutor_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAutores).EndInit();
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
        private DataGridView dataGridViewAutores;
        private TextBox txtNomeAutor;
        private Label label1;
        private TextBox txtBiografia;
        private Label lblBio;
        private DateTimePicker dtpDataNasc;
        private Label lblDataNasc;
        private TextBox txtTwitter;
        private Label lblTwitter;
        private TextBox txtInstagram;
        private Label lblInstagram;
        private TextBox txtFacebook;
        private Label lblFacebook;
        private ComboBox cmbCodSecao;
        private Label label2;
        private Button btnLimparForm;
        private Button btnEditarAutor;
    }
}