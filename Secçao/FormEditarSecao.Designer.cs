namespace BibliotecaSkilliana_M2.Secçao
{
    partial class FormEditarSecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarSecao));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lblDescricaoSecao = new Label();
            txtDescricaoSecao = new TextBox();
            lblCodSecao = new Label();
            txtCodSecao = new TextBox();
            lblEditarLivro = new Label();
            dataGridView1 = new DataGridView();
            btnLimparForm = new Button();
            btnEditarSecao = new Button();
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
            panel2.Size = new Size(680, 64);
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
            panel1.Location = new Point(0, 410);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 41);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(104, 14);
            label1.Name = "label1";
            label1.Size = new Size(446, 17);
            label1.TabIndex = 1;
            label1.Text = "@2024 WorldSkills Portugal Regional Exam - Portugal, September 2024";
            // 
            // lblDescricaoSecao
            // 
            lblDescricaoSecao.AutoSize = true;
            lblDescricaoSecao.Location = new Point(104, 208);
            lblDescricaoSecao.Name = "lblDescricaoSecao";
            lblDescricaoSecao.Size = new Size(98, 15);
            lblDescricaoSecao.TabIndex = 54;
            lblDescricaoSecao.Text = "Descrição Secção";
            // 
            // txtDescricaoSecao
            // 
            txtDescricaoSecao.Location = new Point(104, 226);
            txtDescricaoSecao.Name = "txtDescricaoSecao";
            txtDescricaoSecao.Size = new Size(159, 23);
            txtDescricaoSecao.TabIndex = 53;
            // 
            // lblCodSecao
            // 
            lblCodSecao.AutoSize = true;
            lblCodSecao.Location = new Point(104, 164);
            lblCodSecao.Name = "lblCodSecao";
            lblCodSecao.Size = new Size(86, 15);
            lblCodSecao.TabIndex = 52;
            lblCodSecao.Text = "Código Secção";
            // 
            // txtCodSecao
            // 
            txtCodSecao.Location = new Point(104, 182);
            txtCodSecao.Name = "txtCodSecao";
            txtCodSecao.Size = new Size(86, 23);
            txtCodSecao.TabIndex = 51;
            // 
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(69, 95);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(227, 21);
            lblEditarLivro.TabIndex = 50;
            lblEditarLivro.Text = "Menu Secção - Editar Secção";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(104, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(466, 138);
            dataGridView1.TabIndex = 55;
            // 
            // btnLimparForm
            // 
            btnLimparForm.FlatAppearance.BorderColor = Color.Black;
            btnLimparForm.FlatStyle = FlatStyle.Flat;
            btnLimparForm.Location = new Point(399, 182);
            btnLimparForm.Name = "btnLimparForm";
            btnLimparForm.Size = new Size(171, 30);
            btnLimparForm.TabIndex = 76;
            btnLimparForm.Text = "Limpar Form";
            btnLimparForm.UseVisualStyleBackColor = true;
            // 
            // btnEditarSecao
            // 
            btnEditarSecao.FlatAppearance.BorderColor = Color.Yellow;
            btnEditarSecao.FlatStyle = FlatStyle.Flat;
            btnEditarSecao.Location = new Point(399, 218);
            btnEditarSecao.Name = "btnEditarSecao";
            btnEditarSecao.Size = new Size(171, 30);
            btnEditarSecao.TabIndex = 75;
            btnEditarSecao.Text = "Editar Secção";
            btnEditarSecao.UseVisualStyleBackColor = true;
            // 
            // FormEditarSecao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 450);
            Controls.Add(btnLimparForm);
            Controls.Add(btnEditarSecao);
            Controls.Add(dataGridView1);
            Controls.Add(lblDescricaoSecao);
            Controls.Add(txtDescricaoSecao);
            Controls.Add(lblCodSecao);
            Controls.Add(txtCodSecao);
            Controls.Add(lblEditarLivro);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormEditarSecao";
            Text = "FormEditarSecao";
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
        private Label lblDescricaoSecao;
        private TextBox txtDescricaoSecao;
        private Label lblCodSecao;
        private TextBox txtCodSecao;
        private Label lblEditarLivro;
        private DataGridView dataGridView1;
        private Button btnLimparForm;
        private Button btnEditarSecao;
    }
}