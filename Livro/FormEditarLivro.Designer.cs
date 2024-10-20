namespace BibliotecaSkilliana_M2.Livro
{
    partial class FormEditarLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarLivro));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            lblEditarLivro = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            lblISBN = new Label();
            lblTitulo = new Label();
            textBox2 = new TextBox();
            lblDataLanc = new Label();
            lblSinopse = new Label();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lblEdicao = new Label();
            textBox3 = new TextBox();
            lblEditora = new Label();
            lblIdioma = new Label();
            lblNPaginas = new Label();
            textBox7 = new TextBox();
            lblEstado = new Label();
            lblCodEstante = new Label();
            textBox9 = new TextBox();
            lblQuantidade = new Label();
            textBox10 = new TextBox();
            btnEditarLivro = new Button();
            btnLimparForm = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 467);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 41);
            panel1.TabIndex = 5;
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
            panel2.Size = new Size(916, 64);
            panel2.TabIndex = 6;
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
            lblEditarLivro.Location = new Point(69, 88);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(204, 21);
            lblEditarLivro.TabIndex = 14;
            lblEditarLivro.Text = "Menu Livros - Editar Livro";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 309);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(865, 152);
            dataGridView1.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 16;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(55, 156);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(32, 15);
            lblISBN.TabIndex = 17;
            lblISBN.Text = "ISBN";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(155, 156);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Titulo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 18;
            // 
            // lblDataLanc
            // 
            lblDataLanc.AutoSize = true;
            lblDataLanc.Location = new Point(315, 156);
            lblDataLanc.Name = "lblDataLanc";
            lblDataLanc.Size = new Size(100, 15);
            lblDataLanc.TabIndex = 21;
            lblDataLanc.Text = "Data Lançamento";
            // 
            // lblSinopse
            // 
            lblSinopse.AutoSize = true;
            lblSinopse.Location = new Point(55, 211);
            lblSinopse.Name = "lblSinopse";
            lblSinopse.Size = new Size(48, 15);
            lblSinopse.TabIndex = 23;
            lblSinopse.Text = "Sinopse";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(55, 229);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(257, 67);
            textBox4.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(315, 174);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(156, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // lblEdicao
            // 
            lblEdicao.AutoSize = true;
            lblEdicao.Location = new Point(315, 211);
            lblEdicao.Name = "lblEdicao";
            lblEdicao.Size = new Size(42, 15);
            lblEdicao.TabIndex = 26;
            lblEdicao.Text = "Edição";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(315, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 23);
            textBox3.TabIndex = 25;
            // 
            // lblEditora
            // 
            lblEditora.AutoSize = true;
            lblEditora.Location = new Point(315, 255);
            lblEditora.Name = "lblEditora";
            lblEditora.Size = new Size(44, 15);
            lblEditora.TabIndex = 28;
            lblEditora.Text = "Editora";
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.Location = new Point(479, 211);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(44, 15);
            lblIdioma.TabIndex = 30;
            lblIdioma.Text = "Idioma";
            // 
            // lblNPaginas
            // 
            lblNPaginas.AutoSize = true;
            lblNPaginas.Location = new Point(479, 255);
            lblNPaginas.Name = "lblNPaginas";
            lblNPaginas.Size = new Size(65, 15);
            lblNPaginas.TabIndex = 32;
            lblNPaginas.Text = "Nº Páginas";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(479, 273);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 23);
            textBox7.TabIndex = 31;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(479, 156);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 34;
            lblEstado.Text = "Estado";
            // 
            // lblCodEstante
            // 
            lblCodEstante.AutoSize = true;
            lblCodEstante.Location = new Point(610, 156);
            lblCodEstante.Name = "lblCodEstante";
            lblCodEstante.Size = new Size(73, 15);
            lblCodEstante.TabIndex = 36;
            lblCodEstante.Text = "Cód. Estante";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(610, 174);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 35;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(610, 211);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 38;
            lblQuantidade.Text = "Quantidade";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(610, 229);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 37;
            // 
            // btnEditarLivro
            // 
            btnEditarLivro.FlatAppearance.BorderColor = Color.Yellow;
            btnEditarLivro.FlatStyle = FlatStyle.Flat;
            btnEditarLivro.Location = new Point(732, 275);
            btnEditarLivro.Name = "btnEditarLivro";
            btnEditarLivro.Size = new Size(171, 30);
            btnEditarLivro.TabIndex = 39;
            btnEditarLivro.Text = "Editar Livro";
            btnEditarLivro.UseVisualStyleBackColor = true;
            // 
            // btnLimparForm
            // 
            btnLimparForm.FlatAppearance.BorderColor = Color.Black;
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(732, 239);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(171, 30);
            btnLimparForm.TabIndex = 40;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(477, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(127, 23);
            comboBox1.TabIndex = 74;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(318, 273);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(155, 23);
            comboBox2.TabIndex = 75;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(479, 229);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(125, 23);
            comboBox3.TabIndex = 76;
            // 
            // FormEditarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 507);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(btnLimparForm);
            Controls.Add(btnEditarLivro);
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
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormEditarLivro";
            Text = "FormEditarLivro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label lblEditarLivro;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label lblISBN;
        private Label lblTitulo;
        private TextBox textBox2;
        private Label lblDataLanc;
        private Label lblSinopse;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Label lblEdicao;
        private TextBox textBox3;
        private Label lblEditora;
        private Label lblIdioma;
        private Label lblNPaginas;
        private TextBox textBox7;
        private Label lblEstado;
        private Label lblCodEstante;
        private TextBox textBox9;
        private Label lblQuantidade;
        private TextBox textBox10;
        private Button btnEditarLivro;
        private Button btnLimparForm;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}