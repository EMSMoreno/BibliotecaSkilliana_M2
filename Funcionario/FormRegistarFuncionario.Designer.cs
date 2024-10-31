namespace BibliotecaSkilliana_M2.Funcionario
{
    partial class FormRegistarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistarFuncionario));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            cmbEstadoFunc = new ComboBox();
            btnLimparForm = new Button();
            btnRegistarFuncionario = new Button();
            lblNFuncionario = new Label();
            txtNumeroFunc = new TextBox();
            lblTipo = new Label();
            lblEstado = new Label();
            lblEmail = new Label();
            txtEmailFunc = new TextBox();
            lblTelefone = new Label();
            txtTelefoneFunc = new TextBox();
            dtpDataNasc = new DateTimePicker();
            lblMorada = new Label();
            txtMoradaFunc = new TextBox();
            lblDataNasc = new Label();
            lblNome = new Label();
            txtNomeFunc = new TextBox();
            lblIDFuncionario = new Label();
            txtIDFunc = new TextBox();
            lblEditarLivro = new Label();
            cmbTipoFunc = new ComboBox();
            dataGridViewProcura = new DataGridView();
            btnLimparFormProcura = new Button();
            btnProcuraFuncionario = new Button();
            label3 = new Label();
            txtFuncionarioProcura = new TextBox();
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
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(828, 64);
            panel2.TabIndex = 8;
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
            panel1.Location = new Point(1, 589);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 41);
            panel1.TabIndex = 9;
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
            // cmbEstadoFunc
            // 
            cmbEstadoFunc.FormattingEnabled = true;
            cmbEstadoFunc.Location = new Point(412, 307);
            cmbEstadoFunc.Name = "cmbEstadoFunc";
            cmbEstadoFunc.Size = new Size(159, 23);
            cmbEstadoFunc.TabIndex = 100;
            // 
            // btnLimparForm
            // 
            btnLimparForm.FlatAppearance.BorderColor = Color.Black;
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(248, 365);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(158, 30);
            btnLimparForm.TabIndex = 97;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            btnLimparForm.Click += btnLimparForm_Click;
            // 
            // btnRegistarFuncionario
            // 
            btnRegistarFuncionario.FlatAppearance.BorderColor = Color.Lime;
            btnRegistarFuncionario.FlatStyle = FlatStyle.Flat;
            btnRegistarFuncionario.Location = new Point(412, 365);
            btnRegistarFuncionario.Name = "btnRegistarFuncionario";
            btnRegistarFuncionario.Size = new Size(171, 30);
            btnRegistarFuncionario.TabIndex = 96;
            btnRegistarFuncionario.Text = "Registar Funcionário";
            btnRegistarFuncionario.UseVisualStyleBackColor = true;
            btnRegistarFuncionario.Click += btnRegistarFuncionario_Click;
            // 
            // lblNFuncionario
            // 
            lblNFuncionario.AutoSize = true;
            lblNFuncionario.Location = new Point(577, 219);
            lblNFuncionario.Name = "lblNFuncionario";
            lblNFuncionario.Size = new Size(87, 15);
            lblNFuncionario.TabIndex = 95;
            lblNFuncionario.Text = "Nº Funcionário";
            // 
            // txtNumeroFunc
            // 
            txtNumeroFunc.Location = new Point(577, 237);
            txtNumeroFunc.Name = "txtNumeroFunc";
            txtNumeroFunc.Size = new Size(162, 23);
            txtNumeroFunc.TabIndex = 94;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(149, 289);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(96, 15);
            lblTipo.TabIndex = 93;
            lblTipo.Text = "Tipo Funcionário";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(412, 289);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 91;
            lblEstado.Text = "Estado";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(149, 219);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 90;
            lblEmail.Text = "Email";
            // 
            // txtEmailFunc
            // 
            txtEmailFunc.Location = new Point(149, 237);
            txtEmailFunc.Name = "txtEmailFunc";
            txtEmailFunc.Size = new Size(210, 23);
            txtEmailFunc.TabIndex = 89;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(32, 219);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 86;
            lblTelefone.Text = "Telefone";
            // 
            // txtTelefoneFunc
            // 
            txtTelefoneFunc.Location = new Point(32, 237);
            txtTelefoneFunc.Name = "txtTelefoneFunc";
            txtTelefoneFunc.Size = new Size(111, 23);
            txtTelefoneFunc.TabIndex = 85;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Location = new Point(412, 237);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(159, 23);
            dtpDataNasc.TabIndex = 84;
            // 
            // lblMorada
            // 
            lblMorada.AutoSize = true;
            lblMorada.Location = new Point(412, 144);
            lblMorada.Name = "lblMorada";
            lblMorada.Size = new Size(48, 15);
            lblMorada.TabIndex = 83;
            lblMorada.Text = "Morada";
            // 
            // txtMoradaFunc
            // 
            txtMoradaFunc.Location = new Point(412, 162);
            txtMoradaFunc.Name = "txtMoradaFunc";
            txtMoradaFunc.Size = new Size(327, 23);
            txtMoradaFunc.TabIndex = 82;
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(412, 219);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(98, 15);
            lblDataNasc.TabIndex = 81;
            lblDataNasc.Text = "Data Nascimento";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(130, 144);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(106, 15);
            lblNome.TabIndex = 80;
            lblNome.Text = "Nome Funcionário";
            // 
            // txtNomeFunc
            // 
            txtNomeFunc.Location = new Point(133, 162);
            txtNomeFunc.Name = "txtNomeFunc";
            txtNomeFunc.Size = new Size(226, 23);
            txtNomeFunc.TabIndex = 79;
            // 
            // lblIDFuncionario
            // 
            lblIDFuncionario.AutoSize = true;
            lblIDFuncionario.Location = new Point(32, 144);
            lblIDFuncionario.Name = "lblIDFuncionario";
            lblIDFuncionario.Size = new Size(84, 15);
            lblIDFuncionario.TabIndex = 78;
            lblIDFuncionario.Text = "ID Funcionário";
            // 
            // txtIDFunc
            // 
            txtIDFunc.Enabled = false;
            txtIDFunc.Location = new Point(32, 162);
            txtIDFunc.Name = "txtIDFunc";
            txtIDFunc.Size = new Size(84, 23);
            txtIDFunc.TabIndex = 77;
            // 
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(45, 96);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(327, 21);
            lblEditarLivro.TabIndex = 76;
            lblEditarLivro.Text = "Menu Funcionários - Registar Funcionário";
            // 
            // cmbTipoFunc
            // 
            cmbTipoFunc.FormattingEnabled = true;
            cmbTipoFunc.Location = new Point(149, 307);
            cmbTipoFunc.Name = "cmbTipoFunc";
            cmbTipoFunc.Size = new Size(210, 23);
            cmbTipoFunc.TabIndex = 101;
            // 
            // dataGridViewProcura
            // 
            dataGridViewProcura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProcura.Location = new Point(395, 443);
            dataGridViewProcura.Name = "dataGridViewProcura";
            dataGridViewProcura.Size = new Size(421, 127);
            dataGridViewProcura.TabIndex = 103;
            // 
            // btnLimparFormProcura
            // 
            btnLimparFormProcura.FlatAppearance.BorderColor = Color.Black;
            btnLimparFormProcura.FlatStyle = FlatStyle.Flat;
            btnLimparFormProcura.Location = new Point(20, 540);
            btnLimparFormProcura.Name = "btnLimparFormProcura";
            btnLimparFormProcura.Size = new Size(171, 30);
            btnLimparFormProcura.TabIndex = 105;
            btnLimparFormProcura.Text = "Limpar Form";
            btnLimparFormProcura.UseVisualStyleBackColor = true;
            btnLimparFormProcura.Click += btnLimparFormProcura_Click;
            // 
            // btnProcuraFuncionario
            // 
            btnProcuraFuncionario.FlatAppearance.BorderColor = Color.Lime;
            btnProcuraFuncionario.FlatStyle = FlatStyle.Flat;
            btnProcuraFuncionario.Location = new Point(197, 540);
            btnProcuraFuncionario.Name = "btnProcuraFuncionario";
            btnProcuraFuncionario.Size = new Size(171, 30);
            btnProcuraFuncionario.TabIndex = 104;
            btnProcuraFuncionario.Text = "Procurar Funcionário";
            btnProcuraFuncionario.UseVisualStyleBackColor = true;
            btnProcuraFuncionario.Click += btnProcuraFuncionario_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 476);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 107;
            label3.Text = "Nome Funcionário";
            // 
            // txtFuncionarioProcura
            // 
            txtFuncionarioProcura.Location = new Point(91, 494);
            txtFuncionarioProcura.Name = "txtFuncionarioProcura";
            txtFuncionarioProcura.Size = new Size(226, 23);
            txtFuncionarioProcura.TabIndex = 106;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(45, 431);
            label4.Name = "label4";
            label4.Size = new Size(330, 21);
            label4.TabIndex = 108;
            label4.Text = "Menu Funcionários - Procurar Funcionário\r\n";
            // 
            // FormRegistarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 630);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtFuncionarioProcura);
            Controls.Add(btnLimparFormProcura);
            Controls.Add(btnProcuraFuncionario);
            Controls.Add(dataGridViewProcura);
            Controls.Add(cmbTipoFunc);
            Controls.Add(cmbEstadoFunc);
            Controls.Add(btnLimparForm);
            Controls.Add(btnRegistarFuncionario);
            Controls.Add(lblNFuncionario);
            Controls.Add(txtNumeroFunc);
            Controls.Add(lblTipo);
            Controls.Add(lblEstado);
            Controls.Add(lblEmail);
            Controls.Add(txtEmailFunc);
            Controls.Add(lblTelefone);
            Controls.Add(txtTelefoneFunc);
            Controls.Add(dtpDataNasc);
            Controls.Add(lblMorada);
            Controls.Add(txtMoradaFunc);
            Controls.Add(lblDataNasc);
            Controls.Add(lblNome);
            Controls.Add(txtNomeFunc);
            Controls.Add(lblIDFuncionario);
            Controls.Add(txtIDFunc);
            Controls.Add(lblEditarLivro);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormRegistarFuncionario";
            Text = "FormRegistarFuncionario";
            Load += FormRegistarFuncionario_Load;
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
        private ComboBox cmbEstadoFunc;
        private ComboBox comboBox2;
        private Button btnLimparForm;
        private Button btnRegistarFuncionario;
        private Label lblNFuncionario;
        private TextBox txtNumeroFunc;
        private Label lblTipo;
        private Label lblEstado;
        private Label lblEmail;
        private TextBox txtEmailFunc;
        private Label lblIdioma;
        private Label lblEditora;
        private Label lblTelefone;
        private TextBox txtTelefoneFunc;
        private DateTimePicker dtpDataNasc;
        private Label lblMorada;
        private TextBox txtMoradaFunc;
        private Label lblDataNasc;
        private Label lblNome;
        private TextBox txtNomeFunc;
        private Label lblIDFuncionario;
        private TextBox txtIDFunc;
        private Label lblEditarLivro;
        private ComboBox cmbTipoFunc;
        private DataGridView dataGridViewProcura;
        private Button btnLimparFormProcura;
        private Button btnProcuraFuncionario;
        private Label label3;
        private TextBox txtFuncionarioProcura;
        private Label label4;
    }
}