namespace BibliotecaSkilliana_M2.Emprestimo
{
    partial class FormEditarEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarEmprestimo));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            lblEditarLivro = new Label();
            dateTimePickerDataRegisto = new DateTimePicker();
            txtEmprestimoID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerDataDevolucao = new DateTimePicker();
            txtNumeroSocio = new TextBox();
            label4 = new Label();
            label3 = new Label();
            comboBoxFuncionarioID = new ComboBox();
            label5 = new Label();
            btnLimparForm = new Button();
            btnEditarEmprestimo = new Button();
            dataGridView1 = new DataGridView();
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
            panel2.Controls.Add(label7);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 64);
            panel2.TabIndex = 77;
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 410);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 41);
            panel1.TabIndex = 78;
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
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(69, 99);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(312, 21);
            lblEditarLivro.TabIndex = 79;
            lblEditarLivro.Text = "Menu Empréstimos - Editar Empréstimo";
            // 
            // dateTimePickerDataRegisto
            // 
            dateTimePickerDataRegisto.Location = new Point(355, 179);
            dateTimePickerDataRegisto.Name = "dateTimePickerDataRegisto";
            dateTimePickerDataRegisto.Size = new Size(200, 23);
            dateTimePickerDataRegisto.TabIndex = 83;
            // 
            // txtEmprestimoID
            // 
            txtEmprestimoID.Location = new Point(190, 159);
            txtEmprestimoID.Name = "txtEmprestimoID";
            txtEmprestimoID.Size = new Size(68, 23);
            txtEmprestimoID.TabIndex = 82;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 185);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 81;
            label2.Text = "Data Registo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 162);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 80;
            label1.Text = "Empréstimo ID";
            // 
            // dateTimePickerDataDevolucao
            // 
            dateTimePickerDataDevolucao.Location = new Point(355, 221);
            dateTimePickerDataDevolucao.Name = "dateTimePickerDataDevolucao";
            dateTimePickerDataDevolucao.Size = new Size(200, 23);
            dateTimePickerDataDevolucao.TabIndex = 87;
            // 
            // txtNumeroSocio
            // 
            txtNumeroSocio.Location = new Point(112, 198);
            txtNumeroSocio.Name = "txtNumeroSocio";
            txtNumeroSocio.Size = new Size(146, 23);
            txtNumeroSocio.TabIndex = 86;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 203);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 85;
            label4.Text = "Nº Sócio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 214);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 84;
            label3.Text = "Data Prevista \r\nDevolução";
            // 
            // comboBoxFuncionarioID
            // 
            comboBoxFuncionarioID.FormattingEnabled = true;
            comboBoxFuncionarioID.Location = new Point(125, 242);
            comboBoxFuncionarioID.Name = "comboBoxFuncionarioID";
            comboBoxFuncionarioID.Size = new Size(133, 23);
            comboBoxFuncionarioID.TabIndex = 89;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 245);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 88;
            label5.Text = "Funcionário ID";
            // 
            // btnLimparForm
            // 
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(572, 234);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(154, 37);
            btnLimparForm.TabIndex = 91;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            // 
            // btnEditarEmprestimo
            // 
            btnEditarEmprestimo.FlatAppearance.BorderColor = Color.Yellow;
            btnEditarEmprestimo.FlatStyle = FlatStyle.Flat;
            btnEditarEmprestimo.Location = new Point(572, 192);
            btnEditarEmprestimo.Name = "btnEditarEmprestimo";
            btnEditarEmprestimo.Size = new Size(154, 37);
            btnEditarEmprestimo.TabIndex = 90;
            btnEditarEmprestimo.Text = "Editar Empréstimo";
            btnEditarEmprestimo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(692, 127);
            dataGridView1.TabIndex = 92;
            // 
            // FormEditarEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnLimparForm);
            Controls.Add(btnEditarEmprestimo);
            Controls.Add(comboBoxFuncionarioID);
            Controls.Add(label5);
            Controls.Add(dateTimePickerDataDevolucao);
            Controls.Add(txtNumeroSocio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePickerDataRegisto);
            Controls.Add(txtEmprestimoID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblEditarLivro);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormEditarEmprestimo";
            Text = "FormEditarEmprestimo";
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
        private Label label7;
        private Panel panel1;
        private Label label6;
        private Label lblEditarLivro;
        private DateTimePicker dateTimePickerDataRegisto;
        private TextBox txtEmprestimoID;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerDataDevolucao;
        private TextBox txtNumeroSocio;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxFuncionarioID;
        private Label label5;
        private Button btnLimparForm;
        private Button btnEditarEmprestimo;
        private DataGridView dataGridView1;
    }
}