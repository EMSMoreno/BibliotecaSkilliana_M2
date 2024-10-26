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
            dataGridViewEstantes = new DataGridView();
            btnLimparForm = new Button();
            btnEditarEstante = new Button();
            label2 = new Label();
            txtDescricao = new TextBox();
            label1 = new Label();
            lblEditarLivro = new Label();
            comboBoxSecao = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstantes).BeginInit();
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
            // dataGridViewEstantes
            // 
            dataGridViewEstantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstantes.Location = new Point(168, 225);
            dataGridViewEstantes.Name = "dataGridViewEstantes";
            dataGridViewEstantes.Size = new Size(336, 150);
            dataGridViewEstantes.TabIndex = 58;
            dataGridViewEstantes.CellClick += dataGridViewEstantes_CellClick;
            // 
            // btnLimparForm
            // 
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(510, 225);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(154, 37);
            btnLimparForm.TabIndex = 60;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            btnLimparForm.Click += btnLimparForm_Click;
            // 
            // btnEditarEstante
            // 
            btnEditarEstante.FlatAppearance.BorderColor = Color.Yellow;
            btnEditarEstante.FlatStyle = FlatStyle.Flat;
            btnEditarEstante.Location = new Point(510, 268);
            btnEditarEstante.Name = "btnEditarEstante";
            btnEditarEstante.Size = new Size(154, 37);
            btnEditarEstante.TabIndex = 59;
            btnEditarEstante.Text = "Editar Estante";
            btnEditarEstante.UseVisualStyleBackColor = true;
            btnEditarEstante.Click += btnEditarEstante_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 199);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 72;
            label2.Text = "Secção";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(218, 161);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(182, 23);
            txtDescricao.TabIndex = 71;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 164);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 70;
            label1.Text = "Descrição";
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
            // comboBoxSecao
            // 
            comboBoxSecao.FormattingEnabled = true;
            comboBoxSecao.Location = new Point(218, 196);
            comboBoxSecao.Name = "comboBoxSecao";
            comboBoxSecao.Size = new Size(182, 23);
            comboBoxSecao.TabIndex = 75;
            // 
            // FormEditarEstante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxSecao);
            Controls.Add(lblEditarLivro);
            Controls.Add(label2);
            Controls.Add(txtDescricao);
            Controls.Add(label1);
            Controls.Add(btnLimparForm);
            Controls.Add(btnEditarEstante);
            Controls.Add(dataGridViewEstantes);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormEditarEstante";
            Text = "FormEditarEstante";
            Load += FormEditarEstante_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label9;
        private Panel panel1;
        private Label label8;
        private DataGridView dataGridViewEstantes;
        private Button btnLimparForm;
        private Button btnEditarEstante;
        private Label label2;
        private TextBox txtDescricao;
        private Label label1;
        private Label lblEditarLivro;
        private ComboBox comboBoxSecao;
    }
}