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
            btnProcurarSocio = new Button();
            txtProcurarSocios = new TextBox();
            dataGridViewPesquisaSocios = new DataGridView();
            label7 = new Label();
            btnLimparForm = new Button();
            btnRegistarSocio = new Button();
            label6 = new Label();
            dataGridViewSocios = new DataGridView();
            dtpDataNascimento = new DateTimePicker();
            txtNumeroSocio = new TextBox();
            txtNSocio = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblRegistoEmprestimos = new Label();
            txtNome = new TextBox();
            txtNumeroCartaoCidadao = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtMorada = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtIDFuncionario = new TextBox();
            label12 = new Label();
            cmbEstado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisaSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).BeginInit();
            SuspendLayout();
            // 
            // btnProcurarSocio
            // 
            btnProcurarSocio.FlatAppearance.BorderColor = Color.DarkOrchid;
            btnProcurarSocio.FlatStyle = FlatStyle.Flat;
            btnProcurarSocio.Location = new Point(87, 645);
            btnProcurarSocio.Name = "btnProcurarSocio";
            btnProcurarSocio.Size = new Size(154, 37);
            btnProcurarSocio.TabIndex = 37;
            btnProcurarSocio.Text = "Procurar Sócio";
            btnProcurarSocio.UseVisualStyleBackColor = true;
            // 
            // txtProcurarSocios
            // 
            txtProcurarSocios.Location = new Point(49, 616);
            txtProcurarSocios.Name = "txtProcurarSocios";
            txtProcurarSocios.PlaceholderText = "Procura aqui o sócio que desejas";
            txtProcurarSocios.Size = new Size(242, 23);
            txtProcurarSocios.TabIndex = 36;
            txtProcurarSocios.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewPesquisaSocios
            // 
            dataGridViewPesquisaSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisaSocios.Location = new Point(375, 570);
            dataGridViewPesquisaSocios.Name = "dataGridViewPesquisaSocios";
            dataGridViewPesquisaSocios.Size = new Size(551, 79);
            dataGridViewPesquisaSocios.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.Location = new Point(16, 570);
            label7.Name = "label7";
            label7.Size = new Size(228, 25);
            label7.TabIndex = 34;
            label7.Text = "Fazer Pesquisa de Sócios";
            // 
            // btnLimparForm
            // 
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(190, 479);
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
            btnRegistarSocio.Location = new Point(13, 479);
            btnRegistarSocio.Name = "btnRegistarSocio";
            btnRegistarSocio.Size = new Size(154, 37);
            btnRegistarSocio.TabIndex = 32;
            btnRegistarSocio.Text = "Registar Sócio";
            btnRegistarSocio.UseVisualStyleBackColor = true;
            btnRegistarSocio.Click += btnRegistarSocio_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(375, 13);
            label6.Name = "label6";
            label6.Size = new Size(210, 25);
            label6.TabIndex = 31;
            label6.Text = "Ver Registos de Sócios";
            // 
            // dataGridViewSocios
            // 
            dataGridViewSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSocios.Location = new Point(376, 71);
            dataGridViewSocios.Name = "dataGridViewSocios";
            dataGridViewSocios.Size = new Size(551, 445);
            dataGridViewSocios.TabIndex = 30;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(140, 312);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(200, 23);
            dtpDataNascimento.TabIndex = 29;
            // 
            // txtNumeroSocio
            // 
            txtNumeroSocio.Location = new Point(140, 356);
            txtNumeroSocio.Name = "txtNumeroSocio";
            txtNumeroSocio.Size = new Size(200, 23);
            txtNumeroSocio.TabIndex = 26;
            // 
            // txtNSocio
            // 
            txtNSocio.Location = new Point(129, 68);
            txtNSocio.Name = "txtNSocio";
            txtNSocio.Size = new Size(68, 23);
            txtNSocio.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 430);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 24;
            label5.Text = "Funcionário ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 359);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 23;
            label4.Text = "Número Sócio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 154);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 22;
            label3.Text = "Numero Cartão Cidadão:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 114);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 21;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 71);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 20;
            label1.Text = "Número Sócio:";
            // 
            // lblRegistoEmprestimos
            // 
            lblRegistoEmprestimos.AutoSize = true;
            lblRegistoEmprestimos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblRegistoEmprestimos.Location = new Point(9, 13);
            lblRegistoEmprestimos.Name = "lblRegistoEmprestimos";
            lblRegistoEmprestimos.Size = new Size(218, 25);
            lblRegistoEmprestimos.TabIndex = 19;
            lblRegistoEmprestimos.Text = "Fazer Registo de Sócios";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(86, 111);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(254, 23);
            txtNome.TabIndex = 38;
            // 
            // txtNumeroCartaoCidadao
            // 
            txtNumeroCartaoCidadao.Location = new Point(182, 151);
            txtNumeroCartaoCidadao.Name = "txtNumeroCartaoCidadao";
            txtNumeroCartaoCidadao.Size = new Size(158, 23);
            txtNumeroCartaoCidadao.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 318);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 40;
            label8.Text = "Data Nascimento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 195);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 41;
            label9.Text = "Morada:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 234);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 42;
            label10.Text = "E-mail:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(36, 278);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 43;
            label11.Text = "Telefone:";
            // 
            // txtMorada
            // 
            txtMorada.Location = new Point(92, 192);
            txtMorada.Name = "txtMorada";
            txtMorada.Size = new Size(248, 23);
            txtMorada.TabIndex = 44;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(92, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 45;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(96, 275);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(145, 23);
            txtTelefone.TabIndex = 46;
            // 
            // txtIDFuncionario
            // 
            txtIDFuncionario.Location = new Point(140, 430);
            txtIDFuncionario.Name = "txtIDFuncionario";
            txtIDFuncionario.Size = new Size(200, 23);
            txtIDFuncionario.TabIndex = 47;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 395);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 48;
            label12.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(140, 392);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(200, 23);
            cmbEstado.TabIndex = 49;
            // 
            // FormRegistarSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 700);
            Controls.Add(cmbEstado);
            Controls.Add(label12);
            Controls.Add(txtIDFuncionario);
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
            Controls.Add(txtProcurarSocios);
            Controls.Add(dataGridViewPesquisaSocios);
            Controls.Add(label7);
            Controls.Add(btnLimparForm);
            Controls.Add(btnRegistarSocio);
            Controls.Add(label6);
            Controls.Add(dataGridViewSocios);
            Controls.Add(dtpDataNascimento);
            Controls.Add(txtNumeroSocio);
            Controls.Add(txtNSocio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblRegistoEmprestimos);
            Name = "FormRegistarSocio";
            Text = "FormRegistarSocio";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisaSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProcurarSocio;
        private TextBox txtProcurarSocios;
        private DataGridView dataGridViewPesquisaSocios;
        private Label label7;
        private Button btnLimparForm;
        private Button btnRegistarSocio;
        private Label label6;
        private DataGridView dataGridViewSocios;
        private DateTimePicker dtpDataNascimento;
        private TextBox txtNumeroSocio;
        private TextBox txtNSocio;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblRegistoEmprestimos;
        private TextBox txtNome;
        private TextBox txtNumeroCartaoCidadao;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtMorada;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtIDFuncionario;
        private Label label12;
        private ComboBox cmbEstado;
    }
}