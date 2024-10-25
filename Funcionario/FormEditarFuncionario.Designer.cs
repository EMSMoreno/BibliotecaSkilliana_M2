namespace BibliotecaSkilliana_M2.Funcionario
{
    partial class FormEditarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarFuncionario));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lblEditarLivro = new Label();
            dataGridView1 = new DataGridView();
            btnLimparForm = new Button();
            btnEditarFuncionario = new Button();
            lblNome = new Label();
            txtNomeFunc = new TextBox();
            lblIDFuncionario = new Label();
            txtIDFunc = new TextBox();
            lblMorada = new Label();
            txtMoradaFunc = new TextBox();
            lblNFuncionario = new Label();
            txtNumeroFunc = new TextBox();
            lblEmail = new Label();
            txtEmailFunc = new TextBox();
            lblTelefone = new Label();
            txtTelefoneFunc = new TextBox();
            dtpDataNasc = new DateTimePicker();
            lblDataNasc = new Label();
            cmbTipoFunc = new ComboBox();
            cmbEstadoFunc = new ComboBox();
            lblTipo = new Label();
            lblEstado = new Label();
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
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 64);
            panel2.TabIndex = 9;
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
            panel1.Location = new Point(0, 494);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 41);
            panel1.TabIndex = 10;
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
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(69, 95);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(317, 21);
            lblEditarLivro.TabIndex = 15;
            lblEditarLivro.Text = "Menu Funcionários - Editar Funcionários";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(68, 328);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(666, 150);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnLimparForm
            // 
            btnLimparForm.FlatAppearance.BorderColor = Color.Black;
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(579, 256);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(155, 30);
            btnLimparForm.TabIndex = 78;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            btnLimparForm.Click += btnLimparForm_Click;
            // 
            // btnEditarFuncionario
            // 
            btnEditarFuncionario.FlatAppearance.BorderColor = Color.Yellow;
            btnEditarFuncionario.FlatStyle = FlatStyle.Flat;
            btnEditarFuncionario.Location = new Point(579, 292);
            btnEditarFuncionario.Name = "btnEditarFuncionario";
            btnEditarFuncionario.Size = new Size(155, 30);
            btnEditarFuncionario.TabIndex = 77;
            btnEditarFuncionario.Text = "Editar Funcionário";
            btnEditarFuncionario.UseVisualStyleBackColor = true;
            btnEditarFuncionario.Click += btnEditarFuncionario_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(167, 175);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(106, 15);
            lblNome.TabIndex = 84;
            lblNome.Text = "Nome Funcionário";
            // 
            // txtNomeFunc
            // 
            txtNomeFunc.Location = new Point(170, 193);
            txtNomeFunc.Name = "txtNomeFunc";
            txtNomeFunc.Size = new Size(226, 23);
            txtNomeFunc.TabIndex = 83;
            // 
            // lblIDFuncionario
            // 
            lblIDFuncionario.AutoSize = true;
            lblIDFuncionario.Location = new Point(69, 175);
            lblIDFuncionario.Name = "lblIDFuncionario";
            lblIDFuncionario.Size = new Size(84, 15);
            lblIDFuncionario.TabIndex = 82;
            lblIDFuncionario.Text = "ID Funcionário";
            // 
            // txtIDFunc
            // 
            txtIDFunc.Enabled = false;
            txtIDFunc.Location = new Point(69, 193);
            txtIDFunc.Name = "txtIDFunc";
            txtIDFunc.Size = new Size(84, 23);
            txtIDFunc.TabIndex = 81;
            // 
            // lblMorada
            // 
            lblMorada.AutoSize = true;
            lblMorada.Location = new Point(69, 226);
            lblMorada.Name = "lblMorada";
            lblMorada.Size = new Size(48, 15);
            lblMorada.TabIndex = 86;
            lblMorada.Text = "Morada";
            // 
            // txtMoradaFunc
            // 
            txtMoradaFunc.Location = new Point(69, 244);
            txtMoradaFunc.Name = "txtMoradaFunc";
            txtMoradaFunc.Size = new Size(327, 23);
            txtMoradaFunc.TabIndex = 85;
            // 
            // lblNFuncionario
            // 
            lblNFuncionario.AutoSize = true;
            lblNFuncionario.Location = new Point(407, 281);
            lblNFuncionario.Name = "lblNFuncionario";
            lblNFuncionario.Size = new Size(87, 15);
            lblNFuncionario.TabIndex = 103;
            lblNFuncionario.Text = "Nº Funcionário";
            // 
            // txtNumeroFunc
            // 
            txtNumeroFunc.Location = new Point(407, 299);
            txtNumeroFunc.Name = "txtNumeroFunc";
            txtNumeroFunc.Size = new Size(159, 23);
            txtNumeroFunc.TabIndex = 102;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(524, 175);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 101;
            lblEmail.Text = "Email";
            // 
            // txtEmailFunc
            // 
            txtEmailFunc.Location = new Point(524, 193);
            txtEmailFunc.Name = "txtEmailFunc";
            txtEmailFunc.Size = new Size(210, 23);
            txtEmailFunc.TabIndex = 100;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(407, 175);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 99;
            lblTelefone.Text = "Telefone";
            // 
            // txtTelefoneFunc
            // 
            txtTelefoneFunc.Location = new Point(407, 193);
            txtTelefoneFunc.Name = "txtTelefoneFunc";
            txtTelefoneFunc.Size = new Size(111, 23);
            txtTelefoneFunc.TabIndex = 98;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Location = new Point(407, 244);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(159, 23);
            dtpDataNasc.TabIndex = 97;
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(407, 226);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(98, 15);
            lblDataNasc.TabIndex = 96;
            lblDataNasc.Text = "Data Nascimento";
            // 
            // cmbTipoFunc
            // 
            cmbTipoFunc.FormattingEnabled = true;
            cmbTipoFunc.Location = new Point(68, 299);
            cmbTipoFunc.Name = "cmbTipoFunc";
            cmbTipoFunc.Size = new Size(162, 23);
            cmbTipoFunc.TabIndex = 107;
            // 
            // cmbEstadoFunc
            // 
            cmbEstadoFunc.FormattingEnabled = true;
            cmbEstadoFunc.Location = new Point(245, 299);
            cmbEstadoFunc.Name = "cmbEstadoFunc";
            cmbEstadoFunc.Size = new Size(151, 23);
            cmbEstadoFunc.TabIndex = 106;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(69, 281);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(96, 15);
            lblTipo.TabIndex = 105;
            lblTipo.Text = "Tipo Funcionário";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(245, 281);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 104;
            lblEstado.Text = "Estado";
            // 
            // FormEditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 534);
            Controls.Add(cmbTipoFunc);
            Controls.Add(cmbEstadoFunc);
            Controls.Add(lblTipo);
            Controls.Add(lblEstado);
            Controls.Add(lblNFuncionario);
            Controls.Add(txtNumeroFunc);
            Controls.Add(lblEmail);
            Controls.Add(txtEmailFunc);
            Controls.Add(lblTelefone);
            Controls.Add(txtTelefoneFunc);
            Controls.Add(dtpDataNasc);
            Controls.Add(lblDataNasc);
            Controls.Add(lblMorada);
            Controls.Add(txtMoradaFunc);
            Controls.Add(lblNome);
            Controls.Add(txtNomeFunc);
            Controls.Add(lblIDFuncionario);
            Controls.Add(txtIDFunc);
            Controls.Add(btnLimparForm);
            Controls.Add(btnEditarFuncionario);
            Controls.Add(dataGridView1);
            Controls.Add(lblEditarLivro);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormEditarFuncionario";
            Text = "FormEditarFuncionario";
            Load += FormRegistarSecao_Load;
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
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label lblEditarLivro;
        private DataGridView dataGridView1;
        private Button btnLimparForm;
        private Button btnEditarFuncionario;
        private Label lblNome;
        private TextBox txtNomeFunc;
        private Label lblIDFuncionario;
        private TextBox txtIDFunc;
        private Label lblMorada;
        private TextBox txtMoradaFunc;
        private Label lblNFuncionario;
        private TextBox txtNumeroFunc;
        private Label lblEmail;
        private TextBox txtEmailFunc;
        private Label lblTelefone;
        private TextBox txtTelefoneFunc;
        private DateTimePicker dtpDataNasc;
        private Label lblDataNasc;
        private ComboBox cmbTipoFunc;
        private ComboBox cmbEstadoFunc;
        private Label lblTipo;
        private Label lblEstado;
    }
}