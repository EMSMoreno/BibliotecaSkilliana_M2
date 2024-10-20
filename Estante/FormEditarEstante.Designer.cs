namespace BibliotecaSkilliana_M2.Estante
{
    partial class FormEditarEstante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarEstante));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            btnLimparForm = new Button();
            btnEditarEstante = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            txtDescricao = new TextBox();
            label1 = new Label();
            txtEmprestimoID = new TextBox();
            lblCodEstante = new Label();
            lblEditarLivro = new Label();
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
            panel2.Controls.Add(label9);
            panel2.Location = new Point(1, 0);
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
            panel1.Location = new Point(1, 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 41);
            panel1.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(187, 15);
            label8.Name = "label8";
            label8.Size = new Size(446, 17);
            label8.TabIndex = 1;
            label8.Text = "@2024 WorldSkills Portugal Regional Exam - Portugal, September 2024";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(127, 236);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(569, 150);
            dataGridView1.TabIndex = 58;
            // 
            // btnLimparForm
            // 
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(542, 150);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(154, 37);
            btnLimparForm.TabIndex = 60;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            // 
            // btnEditarEstante
            // 
            btnEditarEstante.FlatAppearance.BorderColor = Color.Yellow;
            btnEditarEstante.FlatStyle = FlatStyle.Flat;
            btnEditarEstante.Location = new Point(542, 193);
            btnEditarEstante.Name = "btnEditarEstante";
            btnEditarEstante.Size = new Size(154, 37);
            btnEditarEstante.TabIndex = 59;
            btnEditarEstante.Text = "Editar Estante";
            btnEditarEstante.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(271, 201);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 73;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 204);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 72;
            label2.Text = "Secção";
            // 
            // txtDescricao
            // 
            txtDescricao.Enabled = false;
            txtDescricao.Location = new Point(346, 164);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(153, 23);
            txtDescricao.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 167);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 70;
            label1.Text = "Descrição";
            // 
            // txtEmprestimoID
            // 
            txtEmprestimoID.Enabled = false;
            txtEmprestimoID.Location = new Point(196, 164);
            txtEmprestimoID.Name = "txtEmprestimoID";
            txtEmprestimoID.Size = new Size(68, 23);
            txtEmprestimoID.TabIndex = 69;
            // 
            // lblCodEstante
            // 
            lblCodEstante.AutoSize = true;
            lblCodEstante.Location = new Point(117, 167);
            lblCodEstante.Name = "lblCodEstante";
            lblCodEstante.Size = new Size(73, 15);
            lblCodEstante.TabIndex = 68;
            lblCodEstante.Text = "Cód. Estante";
            // 
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(70, 98);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(240, 21);
            lblEditarLivro.TabIndex = 74;
            lblEditarLivro.Text = "Menu Estantes - Editar Estante";
            // 
            // FormEditarEstante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEditarLivro);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtDescricao);
            Controls.Add(label1);
            Controls.Add(txtEmprestimoID);
            Controls.Add(lblCodEstante);
            Controls.Add(btnLimparForm);
            Controls.Add(btnEditarEstante);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormEditarEstante";
            Text = "FormEditarEstante";
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
        private Label label9;
        private Panel panel1;
        private Label label8;
        private DataGridView dataGridView1;
        private Button btnLimparForm;
        private Button btnEditarEstante;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtDescricao;
        private Label label1;
        private TextBox txtEmprestimoID;
        private Label lblCodEstante;
        private Label lblEditarLivro;
    }
}