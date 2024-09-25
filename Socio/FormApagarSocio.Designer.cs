namespace BibliotecaSkilliana_M2.Socio
{
    partial class FormApagarSocio
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
            cmbSocios = new ComboBox();
            btnApagar = new Button();
            SuspendLayout();
            // 
            // cmbSocios
            // 
            cmbSocios.FormattingEnabled = true;
            cmbSocios.Location = new Point(147, 153);
            cmbSocios.Name = "cmbSocios";
            cmbSocios.Size = new Size(237, 23);
            cmbSocios.TabIndex = 0;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(219, 218);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 23);
            btnApagar.TabIndex = 1;
            btnApagar.Text = "button1";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // FormApagarSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnApagar);
            Controls.Add(cmbSocios);
            Name = "FormApagarSocio";
            Text = "FormApagarSocio";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbSocios;
        private Button btnApagar;
    }
}