namespace BibliotecaSkilliana_M2.Socio
{
    partial class FormEditarSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarSocio));
            cmbEstado = new ComboBox();
            label12 = new Label();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtMorada = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtNumeroCartaoCidadao = new TextBox();
            txtNome = new TextBox();
            btnLimparForm = new Button();
            btnEditarSocio = new Button();
            dataGridViewSocios = new DataGridView();
            dtpDataNascimento = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            lblEditarLivro = new Label();
            label5 = new Label();
            cmbFuncionario = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(429, 240);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(172, 23);
            cmbEstado.TabIndex = 74;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(378, 246);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 73;
            label12.Text = "Estado";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(429, 202);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(172, 23);
            txtTelefone.TabIndex = 71;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(429, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(172, 23);
            txtEmail.TabIndex = 70;
            // 
            // txtMorada
            // 
            txtMorada.Location = new Point(118, 243);
            txtMorada.Name = "txtMorada";
            txtMorada.Size = new Size(240, 23);
            txtMorada.TabIndex = 69;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(369, 205);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 68;
            label11.Text = "Telefone";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(379, 165);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 67;
            label10.Text = "E-mail";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(61, 246);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 66;
            label9.Text = "Morada";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(55, 287);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 65;
            label8.Text = "Data Nascimento:";
            // 
            // txtNumeroCartaoCidadao
            // 
            txtNumeroCartaoCidadao.Location = new Point(173, 202);
            txtNumeroCartaoCidadao.Name = "txtNumeroCartaoCidadao";
            txtNumeroCartaoCidadao.Size = new Size(185, 23);
            txtNumeroCartaoCidadao.TabIndex = 64;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(110, 162);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(248, 23);
            txtNome.TabIndex = 63;
            // 
            // btnLimparForm
            // 
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(647, 222);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(154, 37);
            btnLimparForm.TabIndex = 62;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            btnLimparForm.Click += btnLimparForm_Click;
            // 
            // btnEditarSocio
            // 
            btnEditarSocio.FlatAppearance.BorderColor = Color.Yellow;
            btnEditarSocio.FlatStyle = FlatStyle.Flat;
            btnEditarSocio.Location = new Point(647, 265);
            btnEditarSocio.Name = "btnEditarSocio";
            btnEditarSocio.Size = new Size(154, 37);
            btnEditarSocio.TabIndex = 61;
            btnEditarSocio.Text = "Editar Sócio";
            btnEditarSocio.UseVisualStyleBackColor = true;
            btnEditarSocio.Click += btnEditar_Click;
            // 
            // dataGridViewSocios
            // 
            dataGridViewSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSocios.Location = new Point(30, 319);
            dataGridViewSocios.Name = "dataGridViewSocios";
            dataGridViewSocios.Size = new Size(771, 221);
            dataGridViewSocios.TabIndex = 59;
            dataGridViewSocios.CellClick += dataGridViewSocios_CellClick;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(158, 281);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(178, 23);
            dtpDataNascimento.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 205);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 53;
            label3.Text = "Nº Cartão Cidadão";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 165);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 52;
            label2.Text = "Nome:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 566);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 41);
            panel1.TabIndex = 75;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(196, 13);
            label6.Name = "label6";
            label6.Size = new Size(446, 17);
            label6.TabIndex = 1;
            label6.Text = "@2024 WorldSkills Portugal Regional Exam - Portugal, September 2024";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(841, 64);
            panel2.TabIndex = 76;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(69, 12);
            label7.Name = "label7";
            label7.Size = new Size(313, 30);
            label7.TabIndex = 0;
            label7.Text = "Bem-vindos à Livraria Skilliana";
            // 
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(69, 107);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(212, 21);
            lblEditarLivro.TabIndex = 77;
            lblEditarLivro.Text = "Menu Sócios - Editar Sócio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 287);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 55;
            label5.Text = "Funcionário ID";
            // 
            // cmbFuncionario
            // 
            cmbFuncionario.FormattingEnabled = true;
            cmbFuncionario.Location = new Point(448, 279);
            cmbFuncionario.Name = "cmbFuncionario";
            cmbFuncionario.Size = new Size(153, 23);
            cmbFuncionario.TabIndex = 78;
            // 
            // FormEditarSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 606);
            Controls.Add(cmbFuncionario);
            Controls.Add(lblEditarLivro);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cmbEstado);
            Controls.Add(label12);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtMorada);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtNumeroCartaoCidadao);
            Controls.Add(txtNome);
            Controls.Add(btnLimparForm);
            Controls.Add(btnEditarSocio);
            Controls.Add(dataGridViewSocios);
            Controls.Add(dtpDataNascimento);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormEditarSocio";
            Text = "FormEditarSocio";
            Load += FormEditarSocio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEstado;
        private Label label12;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtMorada;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtNumeroCartaoCidadao;
        private TextBox txtNome;
        private Button btnLimparForm;
        private Button btnEditarSocio;
        private DataGridView dataGridViewSocios;
        private DateTimePicker dtpDataNascimento;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label6;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label7;
        private Label lblEditarLivro;
        private Label label5;
        private ComboBox cmbFuncionario;
    }
}