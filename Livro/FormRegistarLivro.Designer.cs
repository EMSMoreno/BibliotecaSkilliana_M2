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
            txtQuantidade = new TextBox();
            lblCodEstante = new Label();
            txtCodigoEstante = new TextBox();
            lblEstado = new Label();
            lblNPaginas = new Label();
            txtNumeroPaginas = new TextBox();
            lblIdioma = new Label();
            lblEditora = new Label();
            lblEdicao = new Label();
            txtEdicao = new TextBox();
            dtpDataLancamento = new DateTimePicker();
            lblSinopse = new Label();
            txtSinopse = new TextBox();
            lblDataLanc = new Label();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblISBN = new Label();
            txtISBN = new TextBox();
            lblEditarLivro = new Label();
            dataGridViewProcura = new DataGridView();
            label3 = new Label();
            btnProcurarLivro = new Button();
            btnLimparProcura = new Button();
            lblTituloProcura = new Label();
            txtTituloProcura = new TextBox();
            txtEditora = new TextBox();
            txtIdioma = new TextBox();
            txtEstado = new TextBox();
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
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 64);
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
            panel1.Location = new Point(0, 663);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 41);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(235, 15);
            label1.Name = "label1";
            label1.Size = new Size(446, 17);
            label1.TabIndex = 1;
            label1.Text = "@2024 WorldSkills Portugal Regional Exam - Portugal, September 2024";
            // 
            // btnLimparForm
            // 
            btnLimparForm.FlatAppearance.BorderColor = Color.Black;
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(32, 433);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(159, 30);
            btnLimparForm.TabIndex = 66;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            btnLimparForm.Click += btnLimparForm_Click;
            // 
            // btnRegistarLivro
            // 
            btnRegistarLivro.FlatAppearance.BorderColor = Color.Lime;
            btnRegistarLivro.FlatStyle = FlatStyle.Flat;
            btnRegistarLivro.Location = new Point(200, 433);
            btnRegistarLivro.Name = "btnRegistarLivro";
            btnRegistarLivro.Size = new Size(159, 30);
            btnRegistarLivro.TabIndex = 65;
            btnRegistarLivro.Text = "Registar Livro";
            btnRegistarLivro.UseVisualStyleBackColor = true;
            btnRegistarLivro.Click += btnRegistarLivro_Click;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(409, 349);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 64;
            lblQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(409, 367);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(159, 23);
            txtQuantidade.TabIndex = 63;
            // 
            // lblCodEstante
            // 
            lblCodEstante.AutoSize = true;
            lblCodEstante.Location = new Point(578, 349);
            lblCodEstante.Name = "lblCodEstante";
            lblCodEstante.Size = new Size(73, 15);
            lblCodEstante.TabIndex = 62;
            lblCodEstante.Text = "Cód. Estante";
            // 
            // txtCodigoEstante
            // 
            txtCodigoEstante.Location = new Point(578, 367);
            txtCodigoEstante.Name = "txtCodigoEstante";
            txtCodigoEstante.Size = new Size(158, 23);
            txtCodigoEstante.TabIndex = 61;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(31, 278);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 60;
            lblEstado.Text = "Estado";
            // 
            // lblNPaginas
            // 
            lblNPaginas.AutoSize = true;
            lblNPaginas.Location = new Point(200, 349);
            lblNPaginas.Name = "lblNPaginas";
            lblNPaginas.Size = new Size(65, 15);
            lblNPaginas.TabIndex = 58;
            lblNPaginas.Text = "Nº Páginas";
            // 
            // txtNumeroPaginas
            // 
            txtNumeroPaginas.Location = new Point(200, 367);
            txtNumeroPaginas.Name = "txtNumeroPaginas";
            txtNumeroPaginas.Size = new Size(158, 23);
            txtNumeroPaginas.TabIndex = 57;
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.Location = new Point(31, 349);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(44, 15);
            lblIdioma.TabIndex = 56;
            lblIdioma.Text = "Idioma";
            // 
            // lblEditora
            // 
            lblEditora.AutoSize = true;
            lblEditora.Location = new Point(200, 278);
            lblEditora.Name = "lblEditora";
            lblEditora.Size = new Size(44, 15);
            lblEditora.TabIndex = 54;
            lblEditora.Text = "Editora";
            // 
            // lblEdicao
            // 
            lblEdicao.AutoSize = true;
            lblEdicao.Location = new Point(200, 198);
            lblEdicao.Name = "lblEdicao";
            lblEdicao.Size = new Size(42, 15);
            lblEdicao.TabIndex = 52;
            lblEdicao.Text = "Edição";
            // 
            // txtEdicao
            // 
            txtEdicao.Location = new Point(200, 216);
            txtEdicao.Name = "txtEdicao";
            txtEdicao.Size = new Size(158, 23);
            txtEdicao.TabIndex = 51;
            // 
            // dtpDataLancamento
            // 
            dtpDataLancamento.Location = new Point(31, 216);
            dtpDataLancamento.Name = "dtpDataLancamento";
            dtpDataLancamento.Size = new Size(159, 23);
            dtpDataLancamento.TabIndex = 50;
            // 
            // lblSinopse
            // 
            lblSinopse.AutoSize = true;
            lblSinopse.Location = new Point(409, 129);
            lblSinopse.Name = "lblSinopse";
            lblSinopse.Size = new Size(48, 15);
            lblSinopse.TabIndex = 49;
            lblSinopse.Text = "Sinopse";
            // 
            // txtSinopse
            // 
            txtSinopse.Location = new Point(409, 147);
            txtSinopse.Multiline = true;
            txtSinopse.Name = "txtSinopse";
            txtSinopse.Size = new Size(391, 172);
            txtSinopse.TabIndex = 48;
            // 
            // lblDataLanc
            // 
            lblDataLanc.AutoSize = true;
            lblDataLanc.Location = new Point(31, 198);
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
            // txtTitulo
            // 
            txtTitulo.Location = new Point(200, 147);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(158, 23);
            txtTitulo.TabIndex = 45;
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
            // txtISBN
            // 
            txtISBN.Location = new Point(31, 147);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(159, 23);
            txtISBN.TabIndex = 43;
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
            dataGridViewProcura.Location = new Point(389, 499);
            dataGridViewProcura.Name = "dataGridViewProcura";
            dataGridViewProcura.Size = new Size(411, 130);
            dataGridViewProcura.TabIndex = 67;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(59, 499);
            label3.Name = "label3";
            label3.Size = new Size(224, 21);
            label3.TabIndex = 68;
            label3.Text = "Menu Livros - Procurar Livro";
            // 
            // btnProcurarLivro
            // 
            btnProcurarLivro.FlatAppearance.BorderColor = Color.BlueViolet;
            btnProcurarLivro.FlatStyle = FlatStyle.Flat;
            btnProcurarLivro.Location = new Point(198, 599);
            btnProcurarLivro.Name = "btnProcurarLivro";
            btnProcurarLivro.Size = new Size(171, 30);
            btnProcurarLivro.TabIndex = 69;
            btnProcurarLivro.Text = "Procurar Livro";
            btnProcurarLivro.UseVisualStyleBackColor = true;
            btnProcurarLivro.Click += btnProcurarLivro_Click;
            // 
            // btnLimparProcura
            // 
            btnLimparProcura.FlatAppearance.BorderColor = Color.Black;
            btnLimparProcura.FlatStyle = FlatStyle.Flat;
            btnLimparProcura.Location = new Point(21, 599);
            btnLimparProcura.Name = "btnLimparProcura";
            btnLimparProcura.Size = new Size(171, 30);
            btnLimparProcura.TabIndex = 70;
            btnLimparProcura.Text = "Limpar Form";
            btnLimparProcura.UseVisualStyleBackColor = true;
            btnLimparProcura.Click += btnLimparProcura_Click;
            // 
            // lblTituloProcura
            // 
            lblTituloProcura.AutoSize = true;
            lblTituloProcura.Location = new Point(89, 538);
            lblTituloProcura.Name = "lblTituloProcura";
            lblTituloProcura.Size = new Size(37, 15);
            lblTituloProcura.TabIndex = 72;
            lblTituloProcura.Text = "Titulo";
            // 
            // txtTituloProcura
            // 
            txtTituloProcura.Location = new Point(92, 556);
            txtTituloProcura.Name = "txtTituloProcura";
            txtTituloProcura.Size = new Size(171, 23);
            txtTituloProcura.TabIndex = 71;
            // 
            // txtEditora
            // 
            txtEditora.Location = new Point(200, 296);
            txtEditora.Name = "txtEditora";
            txtEditora.Size = new Size(158, 23);
            txtEditora.TabIndex = 73;
            // 
            // txtIdioma
            // 
            txtIdioma.Location = new Point(31, 367);
            txtIdioma.Name = "txtIdioma";
            txtIdioma.Size = new Size(158, 23);
            txtIdioma.TabIndex = 74;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(31, 296);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(158, 23);
            txtEstado.TabIndex = 75;
            // 
            // FormRegistarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 704);
            Controls.Add(txtEstado);
            Controls.Add(txtIdioma);
            Controls.Add(txtEditora);
            Controls.Add(lblTituloProcura);
            Controls.Add(txtTituloProcura);
            Controls.Add(btnLimparProcura);
            Controls.Add(btnProcurarLivro);
            Controls.Add(label3);
            Controls.Add(dataGridViewProcura);
            Controls.Add(btnLimparForm);
            Controls.Add(btnRegistarLivro);
            Controls.Add(lblQuantidade);
            Controls.Add(txtQuantidade);
            Controls.Add(lblCodEstante);
            Controls.Add(txtCodigoEstante);
            Controls.Add(lblEstado);
            Controls.Add(lblNPaginas);
            Controls.Add(txtNumeroPaginas);
            Controls.Add(lblIdioma);
            Controls.Add(lblEditora);
            Controls.Add(lblEdicao);
            Controls.Add(txtEdicao);
            Controls.Add(dtpDataLancamento);
            Controls.Add(lblSinopse);
            Controls.Add(txtSinopse);
            Controls.Add(lblDataLanc);
            Controls.Add(lblTitulo);
            Controls.Add(txtTitulo);
            Controls.Add(lblISBN);
            Controls.Add(txtISBN);
            Controls.Add(lblEditarLivro);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormRegistarLivro";
            Text = "FormRegistarLivro";
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
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button btnLimparForm;
        private Button btnRegistarLivro;
        private Label lblQuantidade;
        private TextBox txtQuantidade;
        private Label lblCodEstante;
        private TextBox txtCodigoEstante;
        private Label lblEstado;
        private Label lblNPaginas;
        private TextBox txtNumeroPaginas;
        private Label lblIdioma;
        private Label lblEditora;
        private Label lblEdicao;
        private TextBox txtEdicao;
        private DateTimePicker dtpDataLancamento;
        private Label lblSinopse;
        private TextBox txtSinopse;
        private Label lblDataLanc;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblISBN;
        private TextBox txtISBN;
        private Label lblEditarLivro;
        private DataGridView dataGridViewProcura;
        private Label label3;
        private Button btnProcurarLivro;
        private Button btnLimparProcura;
        private Label lblTituloProcura;
        private TextBox txtTituloProcura;
        private TextBox txtEditora;
        private TextBox txtIdioma;
        private TextBox txtEstado;
    }
}