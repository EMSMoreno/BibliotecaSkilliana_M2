﻿namespace BibliotecaSkilliana_M2.Funcionario
{
    partial class FormVerFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerFuncionario));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            btnApagarSocio = new Button();
            lblEditarLivro = new Label();
            btnEditarSocio = new Button();
            btnAdicionarSocio = new Button();
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
            panel2.TabIndex = 46;
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
            panel1.Location = new Point(0, 586);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 41);
            panel1.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(165, 15);
            label1.Name = "label1";
            label1.Size = new Size(446, 17);
            label1.TabIndex = 1;
            label1.Text = "@2024 WorldSkills Portugal Regional Exam - Portugal, September 2024";
            // 
            // btnApagarSocio
            // 
            btnApagarSocio.FlatAppearance.BorderColor = Color.Red;
            btnApagarSocio.FlatStyle = FlatStyle.Flat;
            btnApagarSocio.Location = new Point(613, 483);
            btnApagarSocio.Name = "btnApagarSocio";
            btnApagarSocio.Size = new Size(135, 48);
            btnApagarSocio.TabIndex = 60;
            btnApagarSocio.Text = "Apagar Colaborador";
            btnApagarSocio.UseVisualStyleBackColor = true;
            btnApagarSocio.Click += btnApagarSocio_Click;
            // 
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEditarLivro.Location = new Point(12, 95);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(283, 21);
            lblEditarLivro.TabIndex = 59;
            lblEditarLivro.Text = "Menu Funcionário - Ver Funcionário";
            // 
            // btnEditarSocio
            // 
            btnEditarSocio.FlatAppearance.BorderColor = Color.Yellow;
            btnEditarSocio.FlatStyle = FlatStyle.Flat;
            btnEditarSocio.Location = new Point(326, 483);
            btnEditarSocio.Name = "btnEditarSocio";
            btnEditarSocio.Size = new Size(135, 48);
            btnEditarSocio.TabIndex = 58;
            btnEditarSocio.Text = "Editar Colaborador";
            btnEditarSocio.UseVisualStyleBackColor = true;
            btnEditarSocio.Click += btnEditarSocio_Click;
            // 
            // btnAdicionarSocio
            // 
            btnAdicionarSocio.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnAdicionarSocio.FlatStyle = FlatStyle.Flat;
            btnAdicionarSocio.Location = new Point(53, 483);
            btnAdicionarSocio.Name = "btnAdicionarSocio";
            btnAdicionarSocio.Size = new Size(135, 48);
            btnAdicionarSocio.TabIndex = 57;
            btnAdicionarSocio.Text = "Adicionar Colaborador";
            btnAdicionarSocio.UseVisualStyleBackColor = true;
            btnAdicionarSocio.Click += btnAdicionarSocio_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 314);
            dataGridView1.TabIndex = 56;
            // 
            // FormVerFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 627);
            Controls.Add(btnApagarSocio);
            Controls.Add(lblEditarLivro);
            Controls.Add(btnEditarSocio);
            Controls.Add(btnAdicionarSocio);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormVerFuncionario";
            Text = "FormVerFuncionario";
            Load += FormRegistarFuncionario_Load;
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
        private Button btnApagarSocio;
        private Label lblEditarLivro;
        private Button btnEditarSocio;
        private Button btnAdicionarSocio;
        private DataGridView dataGridView1;
    }
}