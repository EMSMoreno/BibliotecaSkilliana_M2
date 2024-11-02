namespace BibliotecaSkilliana_M2.Autor
{
    partial class FormVerAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerAutor));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lblEditarLivro = new Label();
            btnEditarAutor = new Button();
            btnAdicionarAutor = new Button();
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
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 64);
            panel2.TabIndex = 44;
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
            panel1.Location = new Point(0, 585);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 41);
            panel1.TabIndex = 45;
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
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(12, 94);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(219, 21);
            lblEditarLivro.TabIndex = 50;
            lblEditarLivro.Text = "Menu Autores - Ver Autores";
            // 
            // btnEditarAutor
            // 
            btnEditarAutor.FlatAppearance.BorderColor = Color.Yellow;
            btnEditarAutor.FlatStyle = FlatStyle.Flat;
            btnEditarAutor.Location = new Point(419, 460);
            btnEditarAutor.Name = "btnEditarAutor";
            btnEditarAutor.Size = new Size(192, 48);
            btnEditarAutor.TabIndex = 48;
            btnEditarAutor.Text = "Editar Autor";
            btnEditarAutor.UseVisualStyleBackColor = true;
            btnEditarAutor.Click += btnEditarAutor_Click;
            // 
            // btnAdicionarAutor
            // 
            btnAdicionarAutor.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnAdicionarAutor.FlatStyle = FlatStyle.Flat;
            btnAdicionarAutor.Location = new Point(165, 460);
            btnAdicionarAutor.Name = "btnAdicionarAutor";
            btnAdicionarAutor.Size = new Size(192, 48);
            btnAdicionarAutor.TabIndex = 47;
            btnAdicionarAutor.Text = "Adicionar Autor";
            btnAdicionarAutor.UseVisualStyleBackColor = true;
            btnAdicionarAutor.Click += btnAdicionarAutor_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 314);
            dataGridView1.TabIndex = 46;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FormVerAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 627);
            Controls.Add(lblEditarLivro);
            Controls.Add(btnEditarAutor);
            Controls.Add(btnAdicionarAutor);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormVerAutor";
            Text = "FormVerAutor";
            Load += FormRegistarAutor_Load;
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
        private Button btnEditarAutor;
        private Button btnAdicionarAutor;
        private DataGridView dataGridView1;
    }
}