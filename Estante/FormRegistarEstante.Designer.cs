namespace BibliotecaSkilliana_M2.Estante
{
    partial class FormRegistarEstante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistarEstante));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            dataGridViewProcura = new DataGridView();
            label6 = new Label();
            lblEditarLivro = new Label();
            txtEmprestimoID = new TextBox();
            lblCodEstante = new Label();
            txtDescricao = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            btnLimparForm = new Button();
            btnRegistarEstante = new Button();
            btnLimparFormProcura = new Button();
            btnProcuraEstante = new Button();
            txtProcuraDescricao = new TextBox();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcura).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 64);
            panel2.TabIndex = 56;
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 432);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 41);
            panel1.TabIndex = 57;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(459, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(329, 205);
            dataGridView1.TabIndex = 58;
            // 
            // dataGridViewProcura
            // 
            dataGridViewProcura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProcura.Location = new Point(459, 344);
            dataGridViewProcura.Name = "dataGridViewProcura";
            dataGridViewProcura.Size = new Size(329, 71);
            dataGridViewProcura.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(69, 304);
            label6.Name = "label6";
            label6.Size = new Size(260, 21);
            label6.TabIndex = 60;
            label6.Text = "Menu Estantes - Procurar Estante";
            // 
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(69, 88);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(263, 21);
            lblEditarLivro.TabIndex = 61;
            lblEditarLivro.Text = "Menu Estantes - Registrar Estante";
            // 
            // txtEmprestimoID
            // 
            txtEmprestimoID.Enabled = false;
            txtEmprestimoID.Location = new Point(121, 150);
            txtEmprestimoID.Name = "txtEmprestimoID";
            txtEmprestimoID.Size = new Size(68, 23);
            txtEmprestimoID.TabIndex = 63;
            // 
            // lblCodEstante
            // 
            lblCodEstante.AutoSize = true;
            lblCodEstante.Location = new Point(42, 153);
            lblCodEstante.Name = "lblCodEstante";
            lblCodEstante.Size = new Size(73, 15);
            lblCodEstante.TabIndex = 62;
            lblCodEstante.Text = "Cód. Estante";
            // 
            // txtDescricao
            // 
            txtDescricao.Enabled = false;
            txtDescricao.Location = new Point(259, 150);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(153, 23);
            txtDescricao.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 153);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 64;
            label1.Text = "Descrição";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(164, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 203);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 66;
            label2.Text = "Secção";
            // 
            // btnLimparForm
            // 
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(76, 247);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(154, 37);
            btnLimparForm.TabIndex = 69;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            // 
            // btnRegistarEstante
            // 
            btnRegistarEstante.FlatAppearance.BorderColor = Color.LimeGreen;
            btnRegistarEstante.FlatStyle = FlatStyle.Flat;
            btnRegistarEstante.Location = new Point(241, 247);
            btnRegistarEstante.Name = "btnRegistarEstante";
            btnRegistarEstante.Size = new Size(154, 37);
            btnRegistarEstante.TabIndex = 68;
            btnRegistarEstante.Text = "Registar Estante";
            btnRegistarEstante.UseVisualStyleBackColor = true;
            // 
            // btnLimparFormProcura
            // 
            btnLimparFormProcura.FlatStyle = FlatStyle.Flat;
            btnLimparFormProcura.Location = new Point(76, 378);
            btnLimparFormProcura.Name = "btnLimparFormProcura";
            btnLimparFormProcura.Size = new Size(154, 37);
            btnLimparFormProcura.TabIndex = 71;
            btnLimparFormProcura.Text = "Limpar Form";
            btnLimparFormProcura.UseVisualStyleBackColor = true;
            // 
            // btnProcuraEstante
            // 
            btnProcuraEstante.FlatAppearance.BorderColor = Color.DarkViolet;
            btnProcuraEstante.FlatStyle = FlatStyle.Flat;
            btnProcuraEstante.Location = new Point(241, 378);
            btnProcuraEstante.Name = "btnProcuraEstante";
            btnProcuraEstante.Size = new Size(154, 37);
            btnProcuraEstante.TabIndex = 70;
            btnProcuraEstante.Text = "Procurar Estante";
            btnProcuraEstante.UseVisualStyleBackColor = true;
            // 
            // txtProcuraDescricao
            // 
            txtProcuraDescricao.Enabled = false;
            txtProcuraDescricao.Location = new Point(195, 344);
            txtProcuraDescricao.Name = "txtProcuraDescricao";
            txtProcuraDescricao.Size = new Size(153, 23);
            txtProcuraDescricao.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 347);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 72;
            label3.Text = "Descrição";
            // 
            // FormRegistarEstante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(txtProcuraDescricao);
            Controls.Add(label3);
            Controls.Add(btnLimparFormProcura);
            Controls.Add(btnProcuraEstante);
            Controls.Add(btnLimparForm);
            Controls.Add(btnRegistarEstante);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtDescricao);
            Controls.Add(label1);
            Controls.Add(txtEmprestimoID);
            Controls.Add(lblCodEstante);
            Controls.Add(lblEditarLivro);
            Controls.Add(label6);
            Controls.Add(dataGridViewProcura);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormRegistarEstante";
            Text = "FormRegistarEstante";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label9;
        private Panel panel1;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridView dataGridViewProcura;
        private Label label6;
        private Label lblEditarLivro;
        private TextBox txtEmprestimoID;
        private Label lblCodEstante;
        private TextBox txtDescricao;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button btnLimparForm;
        private Button btnRegistarEstante;
        private Button btnLimparFormProcura;
        private Button btnProcuraEstante;
        private TextBox txtProcuraDescricao;
        private Label label3;
    }
}