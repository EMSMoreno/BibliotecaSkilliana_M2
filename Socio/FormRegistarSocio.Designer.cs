namespace BibliotecaSkilliana_M2.Socio
{
    partial class FormRegistarSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistarSocio));
            btnProcurarSocio = new Button();
            dataGridViewPesquisaSocios = new DataGridView();
            btnLimparForm = new Button();
            btnRegistarSocio = new Button();
            dataGridViewSocios = new DataGridView();
            dtpDataNascimento = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtNumeroCartaoCidadao = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtMorada = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            label12 = new Label();
            cmbEstado = new ComboBox();
            panel1 = new Panel();
            label6 = new Label();
            textBox1 = new TextBox();
            label13 = new Label();
            button1 = new Button();
            label7 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label14 = new Label();
            cmbFuncionario = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisaSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnProcurarSocio
            // 
            btnProcurarSocio.FlatAppearance.BorderColor = Color.DarkOrchid;
            btnProcurarSocio.FlatStyle = FlatStyle.Flat;
            btnProcurarSocio.Location = new Point(181, 629);
            btnProcurarSocio.Name = "btnProcurarSocio";
            btnProcurarSocio.Size = new Size(154, 37);
            btnProcurarSocio.TabIndex = 37;
            btnProcurarSocio.Text = "Procurar Sócio";
            btnProcurarSocio.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPesquisaSocios
            // 
            dataGridViewPesquisaSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisaSocios.Location = new Point(359, 549);
            dataGridViewPesquisaSocios.Name = "dataGridViewPesquisaSocios";
            dataGridViewPesquisaSocios.Size = new Size(439, 117);
            dataGridViewPesquisaSocios.TabIndex = 35;
            // 
            // btnLimparForm
            // 
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(22, 457);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(154, 37);
            btnLimparForm.TabIndex = 33;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            // 
            // btnRegistarSocio
            // 
            btnRegistarSocio.FlatAppearance.BorderColor = Color.LimeGreen;
            btnRegistarSocio.FlatStyle = FlatStyle.Flat;
            btnRegistarSocio.Location = new Point(186, 457);
            btnRegistarSocio.Name = "btnRegistarSocio";
            btnRegistarSocio.Size = new Size(154, 37);
            btnRegistarSocio.TabIndex = 32;
            btnRegistarSocio.Text = "Registar Sócio";
            btnRegistarSocio.UseVisualStyleBackColor = true;
            btnRegistarSocio.Click += btnRegistarSocio_Click;
            // 
            // dataGridViewSocios
            // 
            dataGridViewSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSocios.Location = new Point(359, 101);
            dataGridViewSocios.Name = "dataGridViewSocios";
            dataGridViewSocios.Size = new Size(439, 393);
            dataGridViewSocios.TabIndex = 30;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(140, 307);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(200, 23);
            dtpDataNascimento.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 395);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 24;
            label5.Text = "Funcionário ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 144);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 22;
            label3.Text = "Nº Cartão Cidadão";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 104);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 21;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(83, 101);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(257, 23);
            txtNome.TabIndex = 38;
            // 
            // txtNumeroCartaoCidadao
            // 
            txtNumeroCartaoCidadao.Location = new Point(152, 141);
            txtNumeroCartaoCidadao.Name = "txtNumeroCartaoCidadao";
            txtNumeroCartaoCidadao.Size = new Size(146, 23);
            txtNumeroCartaoCidadao.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 313);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 40;
            label8.Text = "Data Nascimento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 185);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 41;
            label9.Text = "Morada";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 230);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 42;
            label10.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 271);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 43;
            label11.Text = "Telefone";
            // 
            // txtMorada
            // 
            txtMorada.Location = new Point(92, 182);
            txtMorada.Name = "txtMorada";
            txtMorada.Size = new Size(248, 23);
            txtMorada.TabIndex = 44;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(92, 227);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 45;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(94, 268);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(145, 23);
            txtTelefone.TabIndex = 46;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 353);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 48;
            label12.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(140, 350);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(200, 23);
            cmbEstado.TabIndex = 49;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 683);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 41);
            panel1.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(172, 15);
            label6.Name = "label6";
            label6.Size = new Size(446, 17);
            label6.TabIndex = 1;
            label6.Text = "@2024 WorldSkills Portugal Regional Exam - Portugal, September 2024";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 589);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 52;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(86, 571);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 51;
            label13.Text = "Nome:";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(21, 629);
            button1.Name = "button1";
            button1.Size = new Size(154, 37);
            button1.TabIndex = 53;
            button1.Text = "Limpar Form";
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(66, 526);
            label7.Name = "label7";
            label7.Size = new Size(232, 21);
            label7.TabIndex = 69;
            label7.Text = "Menu Sócios - Procurar Sócio";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label14);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(810, 64);
            panel2.TabIndex = 70;
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
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(69, 12);
            label14.Name = "label14";
            label14.Size = new Size(313, 30);
            label14.TabIndex = 0;
            label14.Text = "Bem-vindos à Livraria Skilliana";
            // 
            // cmbFuncionario
            // 
            cmbFuncionario.FormattingEnabled = true;
            cmbFuncionario.Location = new Point(140, 392);
            cmbFuncionario.Name = "cmbFuncionario";
            cmbFuncionario.Size = new Size(200, 23);
            cmbFuncionario.TabIndex = 71;
            // 
            // FormRegistarSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 724);
            Controls.Add(cmbFuncionario);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label13);
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
            Controls.Add(btnProcurarSocio);
            Controls.Add(dataGridViewPesquisaSocios);
            Controls.Add(btnLimparForm);
            Controls.Add(btnRegistarSocio);
            Controls.Add(dataGridViewSocios);
            Controls.Add(dtpDataNascimento);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormRegistarSocio";
            Text = "FormRegistarSocio";
            Load += FormRegistarSocio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisaSocios).EndInit();
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

        private Button btnProcurarSocio;
        private DataGridView dataGridViewPesquisaSocios;
        private Button btnLimparForm;
        private Button btnRegistarSocio;
        private DataGridView dataGridViewSocios;
        private DateTimePicker dtpDataNascimento;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtNumeroCartaoCidadao;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtMorada;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Label label12;
        private ComboBox cmbEstado;
        private Panel panel1;
        private Label label6;
        private TextBox textBox1;
        private Label label13;
        private Button button1;
        private Label label7;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label14;
        private ComboBox cmbFuncionario;
    }
}