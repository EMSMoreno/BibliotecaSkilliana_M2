namespace BibliotecaSkilliana_M2.Livro
{
    partial class FormRegistarLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistarLivro));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            btnLimparForm = new Button();
            btnRegistarLivro = new Button();
            lblQuantidade = new Label();
            textBox10 = new TextBox();
            lblCodEstante = new Label();
            textBox9 = new TextBox();
            lblEstado = new Label();
            lblNPaginas = new Label();
            textBox7 = new TextBox();
            lblIdioma = new Label();
            lblEditora = new Label();
            lblEdicao = new Label();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lblSinopse = new Label();
            textBox4 = new TextBox();
            lblDataLanc = new Label();
            lblTitulo = new Label();
            textBox2 = new TextBox();
            lblISBN = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            lblEditarLivro = new Label();
            dataGridViewProcura = new DataGridView();
            label3 = new Label();
            btnProcurarLivro = new Button();
            btnLimparProcura = new Button();
            lblTituloProcura = new Label();
            txtTituloProcura = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcura).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 64);
            panel2.TabIndex = 7;
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
            panel1.Location = new Point(0, 722);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 41);
            panel1.TabIndex = 8;
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
            // btnLimparForm
            // 
            btnLimparForm.FlatAppearance.BorderColor = Color.Black;
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(31, 514);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(171, 30);
            btnLimparForm.TabIndex = 66;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            // 
            // btnRegistarLivro
            // 
            btnRegistarLivro.FlatAppearance.BorderColor = Color.Lime;
            btnRegistarLivro.FlatStyle = FlatStyle.Flat;
            btnRegistarLivro.Location = new Point(208, 514);
            btnRegistarLivro.Name = "btnRegistarLivro";
            btnRegistarLivro.Size = new Size(171, 30);
            btnRegistarLivro.TabIndex = 65;
            btnRegistarLivro.Text = "Registar Livro";
            btnRegistarLivro.UseVisualStyleBackColor = true;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(31, 449);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 64;
            lblQuantidade.Text = "Quantidade";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(31, 467);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(159, 23);
            textBox10.TabIndex = 63;
            // 
            // lblCodEstante
            // 
            lblCodEstante.AutoSize = true;
            lblCodEstante.Location = new Point(200, 449);
            lblCodEstante.Name = "lblCodEstante";
            lblCodEstante.Size = new Size(73, 15);
            lblCodEstante.TabIndex = 62;
            lblCodEstante.Text = "Cód. Estante";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(200, 467);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(158, 23);
            textBox9.TabIndex = 61;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(31, 346);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 60;
            lblEstado.Text = "Estado";
            // 
            // lblNPaginas
            // 
            lblNPaginas.AutoSize = true;
            lblNPaginas.Location = new Point(200, 399);
            lblNPaginas.Name = "lblNPaginas";
            lblNPaginas.Size = new Size(65, 15);
            lblNPaginas.TabIndex = 58;
            lblNPaginas.Text = "Nº Páginas";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(200, 417);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(158, 23);
            textBox7.TabIndex = 57;
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.Location = new Point(31, 399);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(44, 15);
            lblIdioma.TabIndex = 56;
            lblIdioma.Text = "Idioma";
            // 
            // lblEditora
            // 
            lblEditora.AutoSize = true;
            lblEditora.Location = new Point(200, 346);
            lblEditora.Name = "lblEditora";
            lblEditora.Size = new Size(44, 15);
            lblEditora.TabIndex = 54;
            lblEditora.Text = "Editora";
            // 
            // lblEdicao
            // 
            lblEdicao.AutoSize = true;
            lblEdicao.Location = new Point(200, 291);
            lblEdicao.Name = "lblEdicao";
            lblEdicao.Size = new Size(42, 15);
            lblEdicao.TabIndex = 52;
            lblEdicao.Text = "Edição";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(200, 309);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 23);
            textBox3.TabIndex = 51;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(31, 309);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(159, 23);
            dateTimePicker1.TabIndex = 50;
            // 
            // lblSinopse
            // 
            lblSinopse.AutoSize = true;
            lblSinopse.Location = new Point(31, 187);
            lblSinopse.Name = "lblSinopse";
            lblSinopse.Size = new Size(48, 15);
            lblSinopse.TabIndex = 49;
            lblSinopse.Text = "Sinopse";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(31, 205);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(327, 67);
            textBox4.TabIndex = 48;
            // 
            // lblDataLanc
            // 
            lblDataLanc.AutoSize = true;
            lblDataLanc.Location = new Point(31, 291);
            lblDataLanc.Name = "lblDataLanc";
            lblDataLanc.Size = new Size(100, 15);
            lblDataLanc.TabIndex = 47;
            lblDataLanc.Text = "Data Lançamento";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(197, 129);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 46;
            lblTitulo.Text = "Titulo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 23);
            textBox2.TabIndex = 45;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(31, 129);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(32, 15);
            lblISBN.TabIndex = 44;
            lblISBN.Text = "ISBN";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 43;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(399, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(389, 461);
            dataGridView1.TabIndex = 42;
            // 
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(69, 81);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(221, 21);
            lblEditarLivro.TabIndex = 41;
            lblEditarLivro.Text = "Menu Livros - Registar Livro";
            // 
            // dataGridViewProcura
            // 
            dataGridViewProcura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProcura.Location = new Point(399, 595);
            dataGridViewProcura.Name = "dataGridViewProcura";
            dataGridViewProcura.Size = new Size(389, 109);
            dataGridViewProcura.TabIndex = 67;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(69, 574);
            label3.Name = "label3";
            label3.Size = new Size(224, 21);
            label3.TabIndex = 68;
            label3.Text = "Menu Livros - Procurar Livro";
            // 
            // btnProcurarLivro
            // 
            btnProcurarLivro.FlatAppearance.BorderColor = Color.BlueViolet;
            btnProcurarLivro.FlatStyle = FlatStyle.Flat;
            btnProcurarLivro.Location = new Point(208, 674);
            btnProcurarLivro.Name = "btnProcurarLivro";
            btnProcurarLivro.Size = new Size(171, 30);
            btnProcurarLivro.TabIndex = 69;
            btnProcurarLivro.Text = "Procurar Livro";
            btnProcurarLivro.UseVisualStyleBackColor = true;
            // 
            // btnLimparProcura
            // 
            btnLimparProcura.FlatAppearance.BorderColor = Color.Black;
            btnLimparProcura.FlatStyle = FlatStyle.Flat;
            btnLimparProcura.Location = new Point(31, 674);
            btnLimparProcura.Name = "btnLimparProcura";
            btnLimparProcura.Size = new Size(171, 30);
            btnLimparProcura.TabIndex = 70;
            btnLimparProcura.Text = "Limpar Form";
            btnLimparProcura.UseVisualStyleBackColor = true;
            // 
            // lblTituloProcura
            // 
            lblTituloProcura.AutoSize = true;
            lblTituloProcura.Location = new Point(99, 613);
            lblTituloProcura.Name = "lblTituloProcura";
            lblTituloProcura.Size = new Size(37, 15);
            lblTituloProcura.TabIndex = 72;
            lblTituloProcura.Text = "Titulo";
            // 
            // txtTituloProcura
            // 
            txtTituloProcura.Location = new Point(102, 631);
            txtTituloProcura.Name = "txtTituloProcura";
            txtTituloProcura.Size = new Size(171, 23);
            txtTituloProcura.TabIndex = 71;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(31, 417);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 23);
            comboBox1.TabIndex = 73;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(199, 364);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(159, 23);
            comboBox2.TabIndex = 74;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(31, 364);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(159, 23);
            comboBox3.TabIndex = 75;
            // 
            // FormRegistarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 763);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(lblTituloProcura);
            Controls.Add(txtTituloProcura);
            Controls.Add(btnLimparProcura);
            Controls.Add(btnProcurarLivro);
            Controls.Add(label3);
            Controls.Add(dataGridViewProcura);
            Controls.Add(btnLimparForm);
            Controls.Add(btnRegistarLivro);
            Controls.Add(lblQuantidade);
            Controls.Add(textBox10);
            Controls.Add(lblCodEstante);
            Controls.Add(textBox9);
            Controls.Add(lblEstado);
            Controls.Add(lblNPaginas);
            Controls.Add(textBox7);
            Controls.Add(lblIdioma);
            Controls.Add(lblEditora);
            Controls.Add(lblEdicao);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblSinopse);
            Controls.Add(textBox4);
            Controls.Add(lblDataLanc);
            Controls.Add(lblTitulo);
            Controls.Add(textBox2);
            Controls.Add(lblISBN);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(lblEditarLivro);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormRegistarLivro";
            Text = "FormRegistarLivro";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button btnLimparForm;
        private Button btnRegistarLivro;
        private Label lblQuantidade;
        private TextBox textBox10;
        private Label lblCodEstante;
        private TextBox textBox9;
        private Label lblEstado;
        private Label lblNPaginas;
        private TextBox textBox7;
        private Label lblIdioma;
        private Label lblEditora;
        private Label lblEdicao;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Label lblSinopse;
        private TextBox textBox4;
        private Label lblDataLanc;
        private Label lblTitulo;
        private TextBox textBox2;
        private Label lblISBN;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label lblEditarLivro;
        private DataGridView dataGridViewProcura;
        private Label label3;
        private Button btnProcurarLivro;
        private Button btnLimparProcura;
        private Label lblTituloProcura;
        private TextBox txtTituloProcura;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}