namespace BibliotecaSkilliana_M2.Emprestimo
{
    partial class FormRegistarEmprestimo
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
            lblRegistoEmprestimos = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmprestimoID = new TextBox();
            txtNumeroSocio = new TextBox();
            comboBoxFuncionarioID = new ComboBox();
            dateTimePickerDataRegisto = new DateTimePicker();
            dateTimePickerDataDevolucao = new DateTimePicker();
            dataGridViewEmprestimos = new DataGridView();
            label6 = new Label();
            btnRegistarEmprestimo = new Button();
            btnLimparForm = new Button();
            label7 = new Label();
            dataGridViewPesquisaEmprestimos = new DataGridView();
            txtProcurarEmprestimos = new TextBox();
            btnProcurarEmprestimos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmprestimos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisaEmprestimos).BeginInit();
            SuspendLayout();
            // 
            // lblRegistoEmprestimos
            // 
            lblRegistoEmprestimos.AutoSize = true;
            lblRegistoEmprestimos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblRegistoEmprestimos.Location = new Point(12, 43);
            lblRegistoEmprestimos.Name = "lblRegistoEmprestimos";
            lblRegistoEmprestimos.Size = new Size(275, 25);
            lblRegistoEmprestimos.TabIndex = 0;
            lblRegistoEmprestimos.Text = "Fazer Registo de Empréstimos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 101);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Empréstimo ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 144);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Data Registo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 184);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 3;
            label3.Text = "Data Prevista \r\nDevolução:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 236);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 4;
            label4.Text = "Número Sócio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 284);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 5;
            label5.Text = "Funcionário ID:";
            // 
            // txtEmprestimoID
            // 
            txtEmprestimoID.Location = new Point(143, 98);
            txtEmprestimoID.Name = "txtEmprestimoID";
            txtEmprestimoID.Size = new Size(68, 23);
            txtEmprestimoID.TabIndex = 6;
            // 
            // txtNumeroSocio
            // 
            txtNumeroSocio.Location = new Point(143, 236);
            txtNumeroSocio.Name = "txtNumeroSocio";
            txtNumeroSocio.Size = new Size(200, 23);
            txtNumeroSocio.TabIndex = 7;
            // 
            // comboBoxFuncionarioID
            // 
            comboBoxFuncionarioID.FormattingEnabled = true;
            comboBoxFuncionarioID.Location = new Point(143, 281);
            comboBoxFuncionarioID.Name = "comboBoxFuncionarioID";
            comboBoxFuncionarioID.Size = new Size(133, 23);
            comboBoxFuncionarioID.TabIndex = 8;
            // 
            // dateTimePickerDataRegisto
            // 
            dateTimePickerDataRegisto.Location = new Point(143, 138);
            dateTimePickerDataRegisto.Name = "dateTimePickerDataRegisto";
            dateTimePickerDataRegisto.Size = new Size(200, 23);
            dateTimePickerDataRegisto.TabIndex = 9;
            // 
            // dateTimePickerDataDevolucao
            // 
            dateTimePickerDataDevolucao.Location = new Point(143, 191);
            dateTimePickerDataDevolucao.Name = "dateTimePickerDataDevolucao";
            dateTimePickerDataDevolucao.Size = new Size(200, 23);
            dateTimePickerDataDevolucao.TabIndex = 10;
            // 
            // dataGridViewEmprestimos
            // 
            dataGridViewEmprestimos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmprestimos.Location = new Point(378, 101);
            dataGridViewEmprestimos.Name = "dataGridViewEmprestimos";
            dataGridViewEmprestimos.Size = new Size(551, 350);
            dataGridViewEmprestimos.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(378, 43);
            label6.Name = "label6";
            label6.Size = new Size(267, 25);
            label6.TabIndex = 12;
            label6.Text = "Ver Registos de Empréstimos";
            // 
            // btnRegistarEmprestimo
            // 
            btnRegistarEmprestimo.FlatAppearance.BorderColor = Color.LimeGreen;
            btnRegistarEmprestimo.FlatStyle = FlatStyle.Flat;
            btnRegistarEmprestimo.Location = new Point(12, 354);
            btnRegistarEmprestimo.Name = "btnRegistarEmprestimo";
            btnRegistarEmprestimo.Size = new Size(154, 37);
            btnRegistarEmprestimo.TabIndex = 13;
            btnRegistarEmprestimo.Text = "Registar Empréstimo";
            btnRegistarEmprestimo.UseVisualStyleBackColor = true;
            btnRegistarEmprestimo.Click += btnRegistarEmprestimo_Click;
            // 
            // btnLimparForm
            // 
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(189, 354);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(154, 37);
            btnLimparForm.TabIndex = 14;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            btnLimparForm.Click += btnLimparForm_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.Location = new Point(12, 426);
            label7.Name = "label7";
            label7.Size = new Size(285, 25);
            label7.TabIndex = 15;
            label7.Text = "Fazer Pesquisa de Empréstimos";
            // 
            // dataGridViewPesquisaEmprestimos
            // 
            dataGridViewPesquisaEmprestimos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisaEmprestimos.Location = new Point(378, 463);
            dataGridViewPesquisaEmprestimos.Name = "dataGridViewPesquisaEmprestimos";
            dataGridViewPesquisaEmprestimos.Size = new Size(551, 79);
            dataGridViewPesquisaEmprestimos.TabIndex = 16;
            // 
            // txtProcurarEmprestimos
            // 
            txtProcurarEmprestimos.Location = new Point(45, 472);
            txtProcurarEmprestimos.Name = "txtProcurarEmprestimos";
            txtProcurarEmprestimos.PlaceholderText = "Procura aqui o empréstimo que desejas";
            txtProcurarEmprestimos.Size = new Size(242, 23);
            txtProcurarEmprestimos.TabIndex = 17;
            txtProcurarEmprestimos.TextAlign = HorizontalAlignment.Center;
            // 
            // btnProcurarEmprestimos
            // 
            btnProcurarEmprestimos.FlatAppearance.BorderColor = Color.DarkOrchid;
            btnProcurarEmprestimos.FlatStyle = FlatStyle.Flat;
            btnProcurarEmprestimos.Location = new Point(83, 501);
            btnProcurarEmprestimos.Name = "btnProcurarEmprestimos";
            btnProcurarEmprestimos.Size = new Size(154, 37);
            btnProcurarEmprestimos.TabIndex = 18;
            btnProcurarEmprestimos.Text = "Procurar Empréstimo";
            btnProcurarEmprestimos.UseVisualStyleBackColor = true;
            btnProcurarEmprestimos.Click += btnProcurarEmprestimos_Click;
            // 
            // FormRegistarEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 554);
            Controls.Add(btnProcurarEmprestimos);
            Controls.Add(txtProcurarEmprestimos);
            Controls.Add(dataGridViewPesquisaEmprestimos);
            Controls.Add(label7);
            Controls.Add(btnLimparForm);
            Controls.Add(btnRegistarEmprestimo);
            Controls.Add(label6);
            Controls.Add(dataGridViewEmprestimos);
            Controls.Add(dateTimePickerDataDevolucao);
            Controls.Add(dateTimePickerDataRegisto);
            Controls.Add(comboBoxFuncionarioID);
            Controls.Add(txtNumeroSocio);
            Controls.Add(txtEmprestimoID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblRegistoEmprestimos);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormRegistarEmprestimo";
            Text = "FormRegistarEmprestimo";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmprestimos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisaEmprestimos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistoEmprestimos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEmprestimoID;
        private TextBox txtNumeroSocio;
        private ComboBox comboBoxFuncionarioID;
        private DateTimePicker dateTimePickerDataRegisto;
        private DateTimePicker dateTimePickerDataDevolucao;
        private DataGridView dataGridViewEmprestimos;
        private Label label6;
        private Button btnRegistarEmprestimo;
        private Button btnLimparForm;
        private Label label7;
        private DataGridView dataGridViewPesquisaEmprestimos;
        private TextBox txtProcurarEmprestimos;
        private Button btnProcurarEmprestimos;
    }
}