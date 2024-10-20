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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            txtEmprestimoID = new TextBox();
            lblIDAutor = new Label();
            textBox2 = new TextBox();
            lblBio = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblDataNasc = new Label();
            txtTwitter = new TextBox();
            lblTwitter = new Label();
            txtInstagram = new TextBox();
            lblInstagram = new Label();
            txtFacebook = new TextBox();
            lblFacebook = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            btnLimparForm = new Button();
            btnEditarAutor = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 329);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(734, 181);
            dataGridView1.TabIndex = 62;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 164);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 67;
            label1.Text = "Nome Autor";
            // 
            // txtEmprestimoID
            // 
            txtEmprestimoID.Enabled = false;
            txtEmprestimoID.Location = new Point(129, 161);
            txtEmprestimoID.Name = "txtEmprestimoID";
            txtEmprestimoID.Size = new Size(68, 23);
            txtEmprestimoID.TabIndex = 66;
            // 
            // lblIDAutor
            // 
            lblIDAutor.AutoSize = true;
            lblIDAutor.Location = new Point(72, 164);
            lblIDAutor.Name = "lblIDAutor";
            lblIDAutor.Size = new Size(51, 15);
            lblIDAutor.TabIndex = 65;
            lblIDAutor.Text = "ID Autor";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 238);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 85);
            textBox2.TabIndex = 72;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(164, 200);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(165, 23);
            dateTimePicker1.TabIndex = 70;
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
            txtTwitter.Location = new Point(424, 263);
            txtTwitter.Name = "txtTwitter";
            txtTwitter.PlaceholderText = "twitter.com/escreve_assim";
            txtTwitter.Size = new Size(200, 23);
            txtTwitter.TabIndex = 80;
            // 
            // lblTwitter
            // 
            lblTwitter.AutoSize = true;
            lblTwitter.Location = new Point(342, 266);
            lblTwitter.Name = "lblTwitter";
            lblTwitter.Size = new Size(54, 15);
            lblTwitter.TabIndex = 79;
            lblTwitter.Text = "X/Twitter";
            // 
            // txtInstagram
            // 
            txtInstagram.Location = new Point(424, 231);
            txtInstagram.Name = "txtInstagram";
            txtInstagram.PlaceholderText = "instagram.com/escreve_assim";
            txtInstagram.Size = new Size(200, 23);
            txtInstagram.TabIndex = 78;
            // 
            // lblInstagram
            // 
            lblInstagram.AutoSize = true;
            lblInstagram.Location = new Point(342, 234);
            lblInstagram.Name = "lblInstagram";
            lblInstagram.Size = new Size(60, 15);
            lblInstagram.TabIndex = 77;
            lblInstagram.Text = "Instagram";
            // 
            // txtFacebook
            // 
            txtFacebook.Location = new Point(424, 198);
            txtFacebook.Name = "txtFacebook";
            txtFacebook.PlaceholderText = "facebook.com/escreve_assim";
            txtFacebook.Size = new Size(200, 23);
            txtFacebook.TabIndex = 76;
            // 
            // lblFacebook
            // 
            lblFacebook.AutoSize = true;
            lblFacebook.Location = new Point(342, 201);
            lblFacebook.Name = "lblFacebook";
            lblFacebook.Size = new Size(58, 15);
            lblFacebook.TabIndex = 75;
            lblFacebook.Text = "Facebook";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(424, 292);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(87, 23);
            comboBox1.TabIndex = 82;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 298);
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
            // 
            // FormEditarAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 570);
            Controls.Add(btnLimparForm);
            Controls.Add(btnEditarAutor);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(txtTwitter);
            Controls.Add(lblTwitter);
            Controls.Add(txtInstagram);
            Controls.Add(lblInstagram);
            Controls.Add(txtFacebook);
            Controls.Add(lblFacebook);
            Controls.Add(textBox2);
            Controls.Add(lblBio);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblDataNasc);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtEmprestimoID);
            Controls.Add(lblIDAutor);
            Controls.Add(dataGridView1);
            Controls.Add(lblEditarLivro);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormEditarAutor";
            Text = "FormEditarAutor";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtEmprestimoID;
        private Label lblIDAutor;
        private TextBox textBox2;
        private Label lblBio;
        private DateTimePicker dateTimePicker1;
        private Label lblDataNasc;
        private TextBox txtTwitter;
        private Label lblTwitter;
        private TextBox txtInstagram;
        private Label lblInstagram;
        private TextBox txtFacebook;
        private Label lblFacebook;
        private ComboBox comboBox1;
        private Label label2;
        private Button btnLimparForm;
        private Button btnEditarAutor;
    }
}