namespace BibliotecaSkilliana_M2
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtUsernameNew = new TextBox();
            txtPasswordNew = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btnCreateUser = new Button();
            btnLoginUser = new Button();
            btnLimparFormCreate = new Button();
            btnLimparFormLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 370);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 41);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(172, 15);
            label1.Name = "label1";
            label1.Size = new Size(446, 17);
            label1.TabIndex = 1;
            label1.Text = "@2024 WorldSkills Portugal Regional Exam - Portugal, September 2024";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(505, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 64);
            panel2.TabIndex = 2;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 132);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(252, 132);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 189);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 189);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 6;
            label6.Text = "Password";
            // 
            // txtUsernameNew
            // 
            txtUsernameNew.Location = new Point(26, 150);
            txtUsernameNew.Name = "txtUsernameNew";
            txtUsernameNew.Size = new Size(184, 23);
            txtUsernameNew.TabIndex = 7;
            // 
            // txtPasswordNew
            // 
            txtPasswordNew.Location = new Point(26, 207);
            txtPasswordNew.Name = "txtPasswordNew";
            txtPasswordNew.PasswordChar = '*';
            txtPasswordNew.Size = new Size(184, 23);
            txtPasswordNew.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(252, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(184, 23);
            txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(252, 207);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(184, 23);
            txtPassword.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(70, 89);
            label7.Name = "label7";
            label7.Size = new Size(97, 21);
            label7.TabIndex = 11;
            label7.Text = "Create User";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(307, 89);
            label8.Name = "label8";
            label8.Size = new Size(91, 21);
            label8.TabIndex = 12;
            label8.Text = "Login User";
            // 
            // btnCreateUser
            // 
            btnCreateUser.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            btnCreateUser.FlatStyle = FlatStyle.Flat;
            btnCreateUser.Location = new Point(26, 254);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(184, 35);
            btnCreateUser.TabIndex = 13;
            btnCreateUser.Text = "Create User";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // btnLoginUser
            // 
            btnLoginUser.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnLoginUser.FlatStyle = FlatStyle.Flat;
            btnLoginUser.Location = new Point(252, 254);
            btnLoginUser.Name = "btnLoginUser";
            btnLoginUser.Size = new Size(184, 35);
            btnLoginUser.TabIndex = 14;
            btnLoginUser.Text = "Login User";
            btnLoginUser.UseVisualStyleBackColor = true;
            btnLoginUser.Click += btnLogin_Click;
            // 
            // btnLimparFormCreate
            // 
            btnLimparFormCreate.FlatStyle = FlatStyle.Flat;
            btnLimparFormCreate.Location = new Point(26, 295);
            btnLimparFormCreate.Name = "btnLimparFormCreate";
            btnLimparFormCreate.Size = new Size(184, 34);
            btnLimparFormCreate.TabIndex = 15;
            btnLimparFormCreate.Text = "Limpar Form";
            btnLimparFormCreate.UseVisualStyleBackColor = true;
            btnLimparFormCreate.Click += btnClear_Click;
            // 
            // btnLimparFormLogin
            // 
            btnLimparFormLogin.FlatStyle = FlatStyle.Flat;
            btnLimparFormLogin.Location = new Point(252, 295);
            btnLimparFormLogin.Name = "btnLimparFormLogin";
            btnLimparFormLogin.Size = new Size(184, 34);
            btnLimparFormLogin.TabIndex = 16;
            btnLimparFormLogin.Text = "Limpar Form";
            btnLimparFormLogin.UseVisualStyleBackColor = true;
            btnLimparFormLogin.Click += btnClear_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(btnLimparFormLogin);
            Controls.Add(btnLimparFormCreate);
            Controls.Add(btnLoginUser);
            Controls.Add(btnCreateUser);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPasswordNew);
            Controls.Add(txtUsernameNew);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormLogin";
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtUsernameNew;
        private TextBox txtPasswordNew;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label7;
        private Label label8;
        private Button btnCreateUser;
        private Button btnLoginUser;
        private Button btnLimparFormCreate;
        private Button btnLimparFormLogin;
    }
}