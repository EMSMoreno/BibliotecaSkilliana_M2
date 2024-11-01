namespace BibliotecaSkilliana_M2.Estante
{
    partial class FormVerEstante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerEstante));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lblEditarLivro = new Label();
            btnApagarEstante = new Button();
            btnEditarEstante = new Button();
            btnAdicionarEstante = new Button();
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
            panel1.Location = new Point(0, 589);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 41);
            panel1.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(186, 12);
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
            lblEditarLivro.Size = new Size(227, 21);
            lblEditarLivro.TabIndex = 50;
            lblEditarLivro.Text = "Menu Estantes - Ver Estantes";
            // 
            // btnApagarEstante
            // 
            btnApagarEstante.FlatAppearance.BorderColor = Color.Red;
            btnApagarEstante.FlatStyle = FlatStyle.Flat;
            btnApagarEstante.Location = new Point(600, 484);
            btnApagarEstante.Name = "btnApagarEstante";
            btnApagarEstante.Size = new Size(135, 48);
            btnApagarEstante.TabIndex = 49;
            btnApagarEstante.Text = "Apagar Estante";
            btnApagarEstante.UseVisualStyleBackColor = true;
            btnApagarEstante.Click += btnApagarEstante_Click;
            // 
            // btnEditarEstante
            // 
            btnEditarEstante.FlatAppearance.BorderColor = Color.Yellow;
            btnEditarEstante.FlatStyle = FlatStyle.Flat;
            btnEditarEstante.Location = new Point(324, 484);
            btnEditarEstante.Name = "btnEditarEstante";
            btnEditarEstante.Size = new Size(135, 48);
            btnEditarEstante.TabIndex = 48;
            btnEditarEstante.Text = "Editar Estante";
            btnEditarEstante.UseVisualStyleBackColor = true;
            btnEditarEstante.Click += btnEditarEstante_Click;
            // 
            // btnAdicionarEstante
            // 
            btnAdicionarEstante.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnAdicionarEstante.FlatStyle = FlatStyle.Flat;
            btnAdicionarEstante.Location = new Point(71, 484);
            btnAdicionarEstante.Name = "btnAdicionarEstante";
            btnAdicionarEstante.Size = new Size(135, 48);
            btnAdicionarEstante.TabIndex = 47;
            btnAdicionarEstante.Text = "Adicionar Estante";
            btnAdicionarEstante.UseVisualStyleBackColor = true;
            btnAdicionarEstante.Click += btnAdicionarEstante_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(210, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(388, 314);
            dataGridView1.TabIndex = 46;
            // 
            // FormVerEstante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 627);
            Controls.Add(lblEditarLivro);
            Controls.Add(btnApagarEstante);
            Controls.Add(btnEditarEstante);
            Controls.Add(btnAdicionarEstante);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormVerEstante";
            Text = "FormVerEstante";
            Load += FormRegistarEstante_Load;
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
        private Button btnApagarEstante;
        private Button btnEditarEstante;
        private Button btnAdicionarEstante;
        private DataGridView dataGridView1;
    }
}