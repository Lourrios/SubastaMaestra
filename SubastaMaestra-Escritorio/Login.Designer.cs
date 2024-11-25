namespace SubastaMaestra_Escritorio
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            textBoxContraseña = new TextBox();
            buttonLogin = new Button();
            buttonCancelar = new Button();
            buttonRegistrarse = new Button();
            label3 = new Label();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 86);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(112, 26);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(254, 23);
            textBoxUsuario.TabIndex = 2;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(112, 86);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(254, 23);
            textBoxContraseña.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(123, 9, 146);
            buttonLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            buttonLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.Transparent;
            buttonLogin.Location = new Point(61, 163);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(95, 32);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Aceptar";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(123, 9, 146);
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(172, 163);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(81, 32);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonRegistrarse
            // 
            buttonRegistrarse.BackColor = Color.FromArgb(123, 9, 146);
            buttonRegistrarse.FlatAppearance.BorderColor = Color.White;
            buttonRegistrarse.FlatAppearance.BorderSize = 0;
            buttonRegistrarse.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 255);
            buttonRegistrarse.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            buttonRegistrarse.FlatStyle = FlatStyle.Flat;
            buttonRegistrarse.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegistrarse.ForeColor = Color.White;
            buttonRegistrarse.Location = new Point(268, 163);
            buttonRegistrarse.Name = "buttonRegistrarse";
            buttonRegistrarse.Size = new Size(81, 32);
            buttonRegistrarse.TabIndex = 6;
            buttonRegistrarse.Text = "Registrarse";
            buttonRegistrarse.UseVisualStyleBackColor = false;
            buttonRegistrarse.Click += buttonRegistrarse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Century Gothic", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(136, 37);
            label3.Name = "label3";
            label3.Size = new Size(102, 39);
            label3.TabIndex = 7;
            label3.Text = "Login";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(buttonRegistrarse);
            panel2.Controls.Add(buttonCancelar);
            panel2.Controls.Add(buttonLogin);
            panel2.Controls.Add(textBoxContraseña);
            panel2.Controls.Add(textBoxUsuario);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(87, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 213);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(638, 332);
            Controls.Add(label3);
            Controls.Add(panel2);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Opacity = 0.88D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login ";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsuario;
        private TextBox textBoxContraseña;
        private Button buttonLogin;
        private Button buttonCancelar;
        private Button buttonRegistrarse;
        private Label label3;
        private Panel panel2;
    }
}