namespace BibliotecaSkilliana_M2.Livro
{
    partial class FormVerLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerLivro));
            dataGridView1 = new DataGridView();
            btnAdicionarLivro = new Button();
            btnEditarLivro = new Button();
            lblEditarLivro = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 314);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnAdicionarLivro
            // 
            btnAdicionarLivro.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnAdicionarLivro.FlatStyle = FlatStyle.Flat;
            btnAdicionarLivro.Location = new Point(165, 457);
            btnAdicionarLivro.Name = "btnAdicionarLivro";
            btnAdicionarLivro.Size = new Size(219, 48);
            btnAdicionarLivro.TabIndex = 1;
            btnAdicionarLivro.Text = "Adicionar Livro";
            btnAdicionarLivro.UseVisualStyleBackColor = true;
            btnAdicionarLivro.Click += btnAdicionarLivro_Click;
            // 
            // btnEditarLivro
            // 
            btnEditarLivro.FlatAppearance.BorderColor = Color.Yellow;
            btnEditarLivro.FlatStyle = FlatStyle.Flat;
            btnEditarLivro.Location = new Point(392, 457);
            btnEditarLivro.Name = "btnEditarLivro";
            btnEditarLivro.Size = new Size(219, 48);
            btnEditarLivro.TabIndex = 2;
            btnEditarLivro.Text = "Editar Livro";
            btnEditarLivro.UseVisualStyleBackColor = true;
            btnEditarLivro.Click += btnEditarLivro_Click;
            // 
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(12, 91);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(191, 21);
            lblEditarLivro.TabIndex = 42;
            lblEditarLivro.Text = "Menu Livros - Ver Livros";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 64);
            panel2.TabIndex = 43;
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
            panel1.Location = new Point(0, 587);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 41);
            panel1.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(165, 14);
            label1.Name = "label1";
            label1.Size = new Size(446, 17);
            label1.TabIndex = 1;
            label1.Text = "@2024 WorldSkills Portugal Regional Exam - Portugal, September 2024";
            // 
            // FormVerLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 627);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(lblEditarLivro);
            Controls.Add(btnEditarLivro);
            Controls.Add(btnAdicionarLivro);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormVerLivro";
            Text = "FormVerLivro";
            Load += FormVerLivro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdicionarLivro;
        private Button btnEditarLivro;
        private Label lblEditarLivro;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel1;
        private Label label1;
    }
}