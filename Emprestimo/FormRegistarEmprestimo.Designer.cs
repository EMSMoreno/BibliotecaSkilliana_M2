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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistarEmprestimo));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNumeroSocio = new TextBox();
            comboBoxFuncionarioID = new ComboBox();
            dateTimePickerDataRegisto = new DateTimePicker();
            dateTimePickerDataDevolucao = new DateTimePicker();
            btnRegistarEmprestimo = new Button();
            btnLimparForm = new Button();
            dataGridViewProcura = new DataGridView();
            btnProcuraEmprestimo = new Button();
            panel1 = new Panel();
            label8 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            lblEditarLivro = new Label();
            label6 = new Label();
            btnLimparProcuraEmprestimo = new Button();
            txtEmprestimoIDProcura = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcura).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 143);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Data Registo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(400, 183);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 3;
            label3.Text = "Data Prevista \r\nDevolução";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 148);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 4;
            label4.Text = "Nº Sócio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 193);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 5;
            label5.Text = "Funcionário ID";
            // 
            // txtNumeroSocio
            // 
            txtNumeroSocio.Location = new Point(167, 145);
            txtNumeroSocio.Name = "txtNumeroSocio";
            txtNumeroSocio.Size = new Size(43, 23);
            txtNumeroSocio.TabIndex = 7;
            // 
            // comboBoxFuncionarioID
            // 
            comboBoxFuncionarioID.FormattingEnabled = true;
            comboBoxFuncionarioID.Location = new Point(167, 190);
            comboBoxFuncionarioID.Name = "comboBoxFuncionarioID";
            comboBoxFuncionarioID.Size = new Size(176, 23);
            comboBoxFuncionarioID.TabIndex = 8;
            // 
            // dateTimePickerDataRegisto
            // 
            dateTimePickerDataRegisto.Location = new Point(490, 137);
            dateTimePickerDataRegisto.Name = "dateTimePickerDataRegisto";
            dateTimePickerDataRegisto.Size = new Size(176, 23);
            dateTimePickerDataRegisto.TabIndex = 9;
            // 
            // dateTimePickerDataDevolucao
            // 
            dateTimePickerDataDevolucao.Location = new Point(490, 190);
            dateTimePickerDataDevolucao.Name = "dateTimePickerDataDevolucao";
            dateTimePickerDataDevolucao.Size = new Size(176, 23);
            dateTimePickerDataDevolucao.TabIndex = 10;
            // 
            // btnRegistarEmprestimo
            // 
            btnRegistarEmprestimo.FlatAppearance.BorderColor = Color.LimeGreen;
            btnRegistarEmprestimo.FlatStyle = FlatStyle.Flat;
            btnRegistarEmprestimo.Location = new Point(378, 265);
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
            btnLimparForm.Location = new Point(213, 265);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(154, 37);
            btnLimparForm.TabIndex = 14;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            btnLimparForm.Click += btnLimparForm_Click;
            // 
            // dataGridViewProcura
            // 
            dataGridViewProcura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProcura.Location = new Point(378, 393);
            dataGridViewProcura.Name = "dataGridViewProcura";
            dataGridViewProcura.Size = new Size(404, 90);
            dataGridViewProcura.TabIndex = 16;
            // 
            // btnProcuraEmprestimo
            // 
            btnProcuraEmprestimo.FlatAppearance.BorderColor = Color.DarkOrchid;
            btnProcuraEmprestimo.FlatStyle = FlatStyle.Flat;
            btnProcuraEmprestimo.Location = new Point(189, 446);
            btnProcuraEmprestimo.Name = "btnProcuraEmprestimo";
            btnProcuraEmprestimo.Size = new Size(154, 37);
            btnProcuraEmprestimo.TabIndex = 18;
            btnProcuraEmprestimo.Text = "Procurar Empréstimo";
            btnProcuraEmprestimo.UseVisualStyleBackColor = true;
            btnProcuraEmprestimo.Click += btnProcurarEmprestimos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 510);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 41);
            panel1.TabIndex = 54;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(220, 14);
            label8.Name = "label8";
            label8.Size = new Size(446, 17);
            label8.TabIndex = 1;
            label8.Text = "@2024 WorldSkills Portugal Regional Exam - Portugal, September 2024";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 64);
            panel2.TabIndex = 55;
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
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(24, 85);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(335, 21);
            lblEditarLivro.TabIndex = 53;
            lblEditarLivro.Text = "Menu Empréstimos - Registrar Empréstimo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(45, 359);
            label6.Name = "label6";
            label6.Size = new Size(332, 21);
            label6.TabIndex = 56;
            label6.Text = "Menu Empréstimos - Procurar Empréstimo";
            // 
            // btnLimparProcuraEmprestimo
            // 
            btnLimparProcuraEmprestimo.FlatStyle = FlatStyle.Flat;
            btnLimparProcuraEmprestimo.Location = new Point(29, 446);
            btnLimparProcuraEmprestimo.Name = "btnLimparProcuraEmprestimo";
            btnLimparProcuraEmprestimo.Size = new Size(154, 37);
            btnLimparProcuraEmprestimo.TabIndex = 57;
            btnLimparProcuraEmprestimo.Text = "Limpar Form";
            btnLimparProcuraEmprestimo.UseVisualStyleBackColor = true;
            // 
            // txtEmprestimoIDProcura
            // 
            txtEmprestimoIDProcura.Location = new Point(196, 402);
            txtEmprestimoIDProcura.Name = "txtEmprestimoIDProcura";
            txtEmprestimoIDProcura.Size = new Size(68, 23);
            txtEmprestimoIDProcura.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 405);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 58;
            label7.Text = "Empréstimo ID";
            // 
            // FormRegistarEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 551);
            Controls.Add(txtEmprestimoIDProcura);
            Controls.Add(label7);
            Controls.Add(btnLimparProcuraEmprestimo);
            Controls.Add(label6);
            Controls.Add(lblEditarLivro);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnProcuraEmprestimo);
            Controls.Add(dataGridViewProcura);
            Controls.Add(btnLimparForm);
            Controls.Add(btnRegistarEmprestimo);
            Controls.Add(dateTimePickerDataDevolucao);
            Controls.Add(dateTimePickerDataRegisto);
            Controls.Add(comboBoxFuncionarioID);
            Controls.Add(txtNumeroSocio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormRegistarEmprestimo";
            Text = "FormRegistarEmprestimo";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcura).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNumeroSocio;
        private ComboBox comboBoxFuncionarioID;
        private DateTimePicker dateTimePickerDataRegisto;
        private DateTimePicker dateTimePickerDataDevolucao;
        private Button btnRegistarEmprestimo;
        private Button btnLimparForm;
        private DataGridView dataGridViewProcura;
        private Button btnProcuraEmprestimo;
        private Panel panel1;
        private Label label8;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label9;
        private Label lblEditarLivro;
        private Label label6;
        private Button btnLimparProcuraEmprestimo;
        private TextBox txtEmprestimoIDProcura;
        private Label label7;
    }
}