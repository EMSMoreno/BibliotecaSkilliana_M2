namespace BibliotecaSkilliana_M2.Autor
{
    partial class FormRegistarAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistarAutor));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            dataGridViewProcura = new DataGridView();
            lblEditarLivro = new Label();
            txtNomeAutor = new TextBox();
            label1 = new Label();
            lblDataNasc = new Label();
            dtpDataNasc = new DateTimePicker();
            txtBiografia = new TextBox();
            lblBio = new Label();
            txtFacebook = new TextBox();
            lblFacebook = new Label();
            txtInstagram = new TextBox();
            lblInstagram = new Label();
            txtTwitter = new TextBox();
            lblTwitter = new Label();
            label2 = new Label();
            cmbCodSecao = new ComboBox();
            btnLimparForm = new Button();
            btnRegistarAutor = new Button();
            btnLimparFormProcura = new Button();
            btnProcuraAutor = new Button();
            txtNomeAutorProcura = new TextBox();
            lblNomeAutorProcura = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcura).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(893, 64);
            panel2.TabIndex = 56;
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
            panel1.Location = new Point(0, 632);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 41);
            panel1.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(212, 15);
            label8.Name = "label8";
            label8.Size = new Size(446, 17);
            label8.TabIndex = 1;
            label8.Text = "@2024 WorldSkills Portugal Regional Exam - Portugal, September 2024";
            // 
            // dataGridViewProcura
            // 
            dataGridViewProcura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProcura.Location = new Point(396, 454);
            dataGridViewProcura.Name = "dataGridViewProcura";
            dataGridViewProcura.Size = new Size(472, 151);
            dataGridViewProcura.TabIndex = 59;
            // 
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(47, 100);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(240, 21);
            lblEditarLivro.TabIndex = 60;
            lblEditarLivro.Text = "Menu Autores - Registar Autor";
            // 
            // txtNomeAutor
            // 
            txtNomeAutor.Location = new Point(144, 146);
            txtNomeAutor.Name = "txtNomeAutor";
            txtNomeAutor.Size = new Size(200, 23);
            txtNomeAutor.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 149);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 63;
            label1.Text = "Nome Autor";
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(40, 190);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(98, 15);
            lblDataNasc.TabIndex = 65;
            lblDataNasc.Text = "Data Nascimento";
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Location = new Point(144, 184);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(200, 23);
            dtpDataNasc.TabIndex = 66;
            // 
            // txtBiografia
            // 
            txtBiografia.Location = new Point(458, 146);
            txtBiografia.Multiline = true;
            txtBiografia.Name = "txtBiografia";
            txtBiografia.Size = new Size(410, 74);
            txtBiografia.TabIndex = 68;
            // 
            // lblBio
            // 
            lblBio.AutoSize = true;
            lblBio.Location = new Point(395, 149);
            lblBio.Name = "lblBio";
            lblBio.Size = new Size(54, 15);
            lblBio.TabIndex = 67;
            lblBio.Text = "Biografia";
            // 
            // txtFacebook
            // 
            txtFacebook.Location = new Point(144, 249);
            txtFacebook.Name = "txtFacebook";
            txtFacebook.PlaceholderText = "facebook.com/nome_autor";
            txtFacebook.Size = new Size(200, 23);
            txtFacebook.TabIndex = 70;
            // 
            // lblFacebook
            // 
            lblFacebook.AutoSize = true;
            lblFacebook.Location = new Point(62, 252);
            lblFacebook.Name = "lblFacebook";
            lblFacebook.Size = new Size(58, 15);
            lblFacebook.TabIndex = 69;
            lblFacebook.Text = "Facebook";
            // 
            // txtInstagram
            // 
            txtInstagram.Location = new Point(144, 282);
            txtInstagram.Name = "txtInstagram";
            txtInstagram.PlaceholderText = "instagram.com/nome_autor";
            txtInstagram.Size = new Size(200, 23);
            txtInstagram.TabIndex = 72;
            // 
            // lblInstagram
            // 
            lblInstagram.AutoSize = true;
            lblInstagram.Location = new Point(62, 285);
            lblInstagram.Name = "lblInstagram";
            lblInstagram.Size = new Size(60, 15);
            lblInstagram.TabIndex = 71;
            lblInstagram.Text = "Instagram";
            // 
            // txtTwitter
            // 
            txtTwitter.Location = new Point(144, 314);
            txtTwitter.Name = "txtTwitter";
            txtTwitter.PlaceholderText = "twitter.com/nome_autor";
            txtTwitter.Size = new Size(200, 23);
            txtTwitter.TabIndex = 74;
            // 
            // lblTwitter
            // 
            lblTwitter.AutoSize = true;
            lblTwitter.Location = new Point(62, 317);
            lblTwitter.Name = "lblTwitter";
            lblTwitter.Size = new Size(54, 15);
            lblTwitter.TabIndex = 73;
            lblTwitter.Text = "X/Twitter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 252);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 75;
            label2.Text = "Código Secção";
            // 
            // cmbCodSecao
            // 
            cmbCodSecao.FormattingEnabled = true;
            cmbCodSecao.Location = new Point(475, 249);
            cmbCodSecao.Name = "cmbCodSecao";
            cmbCodSecao.Size = new Size(183, 23);
            cmbCodSecao.TabIndex = 76;
            // 
            // btnLimparForm
            // 
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(458, 306);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(154, 37);
            btnLimparForm.TabIndex = 78;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            btnLimparForm.Click += btnLimparForm_Click;
            // 
            // btnRegistarAutor
            // 
            btnRegistarAutor.FlatAppearance.BorderColor = Color.LimeGreen;
            btnRegistarAutor.FlatStyle = FlatStyle.Flat;
            btnRegistarAutor.Location = new Point(623, 306);
            btnRegistarAutor.Name = "btnRegistarAutor";
            btnRegistarAutor.Size = new Size(154, 37);
            btnRegistarAutor.TabIndex = 77;
            btnRegistarAutor.Text = "Registar Autor";
            btnRegistarAutor.UseVisualStyleBackColor = true;
            btnRegistarAutor.Click += btnRegistarAutor_Click;
            // 
            // btnLimparFormProcura
            // 
            btnLimparFormProcura.FlatStyle = FlatStyle.Flat;
            btnLimparFormProcura.Location = new Point(47, 568);
            btnLimparFormProcura.Name = "btnLimparFormProcura";
            btnLimparFormProcura.Size = new Size(154, 37);
            btnLimparFormProcura.TabIndex = 80;
            btnLimparFormProcura.Text = "Limpar Form";
            btnLimparFormProcura.UseVisualStyleBackColor = true;
            btnLimparFormProcura.Click += btnLimparFormProcura_Click;
            // 
            // btnProcuraAutor
            // 
            btnProcuraAutor.FlatAppearance.BorderColor = Color.DarkViolet;
            btnProcuraAutor.FlatStyle = FlatStyle.Flat;
            btnProcuraAutor.Location = new Point(212, 568);
            btnProcuraAutor.Name = "btnProcuraAutor";
            btnProcuraAutor.Size = new Size(154, 37);
            btnProcuraAutor.TabIndex = 79;
            btnProcuraAutor.Text = "Procurar Autor";
            btnProcuraAutor.UseVisualStyleBackColor = true;
            btnProcuraAutor.Click += btnProcuraAutor_Click;
            // 
            // txtNomeAutorProcura
            // 
            txtNomeAutorProcura.Location = new Point(144, 499);
            txtNomeAutorProcura.Name = "txtNomeAutorProcura";
            txtNomeAutorProcura.Size = new Size(200, 23);
            txtNomeAutorProcura.TabIndex = 82;
            // 
            // lblNomeAutorProcura
            // 
            lblNomeAutorProcura.AutoSize = true;
            lblNomeAutorProcura.Location = new Point(62, 502);
            lblNomeAutorProcura.Name = "lblNomeAutorProcura";
            lblNomeAutorProcura.Size = new Size(73, 15);
            lblNomeAutorProcura.TabIndex = 81;
            lblNomeAutorProcura.Text = "Nome Autor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(81, 443);
            label4.Name = "label4";
            label4.Size = new Size(243, 21);
            label4.TabIndex = 83;
            label4.Text = "Menu Autores - Procurar Autor";
            // 
            // FormRegistarAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 672);
            Controls.Add(label4);
            Controls.Add(txtNomeAutorProcura);
            Controls.Add(lblNomeAutorProcura);
            Controls.Add(btnLimparFormProcura);
            Controls.Add(btnProcuraAutor);
            Controls.Add(btnLimparForm);
            Controls.Add(btnRegistarAutor);
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
            Controls.Add(lblEditarLivro);
            Controls.Add(dataGridViewProcura);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormRegistarAutor";
            Text = "FormRegistarAutor";
            Load += FormRegistarAutor_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label9;
        private Panel panel1;
        private Label label8;
        private DataGridView dataGridViewProcura;
        private Label lblEditarLivro;
        private TextBox txtNomeAutor;
        private Label label1;
        private Label lblDataNasc;
        private DateTimePicker dtpDataNasc;
        private TextBox txtBiografia;
        private Label lblBio;
        private TextBox txtFacebook;
        private Label lblFacebook;
        private TextBox txtInstagram;
        private Label lblInstagram;
        private TextBox txtTwitter;
        private Label lblTwitter;
        private Label label2;
        private ComboBox cmbCodSecao;
        private Button btnLimparForm;
        private Button btnRegistarAutor;
        private Button btnLimparFormProcura;
        private Button btnProcuraAutor;
        private TextBox txtNomeAutorProcura;
        private Label lblNomeAutorProcura;
        private Label label4;
    }
}