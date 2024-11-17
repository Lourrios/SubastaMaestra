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
            panel1 = new Panel();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(10, 86);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
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
            textBoxContraseña.Location = new Point(112, 84);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(254, 23);
            textBoxContraseña.TabIndex = 3;
            textBoxContraseña.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(75, 163);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(81, 23);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Aceptar";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(176, 163);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(81, 23);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonRegistrarse
            // 
            buttonRegistrarse.Location = new Point(294, 163);
            buttonRegistrarse.Name = "buttonRegistrarse";
            buttonRegistrarse.Size = new Size(81, 23);
            buttonRegistrarse.TabIndex = 6;
            buttonRegistrarse.Text = "Registrarse";
            buttonRegistrarse.UseVisualStyleBackColor = true;
            buttonRegistrarse.Click += buttonRegistrarse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Candara", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(322, 54);
            label3.Name = "label3";
            label3.Size = new Size(93, 41);
            label3.TabIndex = 7;
            label3.Text = "Login";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(214, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(73, 71);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(buttonRegistrarse);
            panel2.Controls.Add(buttonCancelar);
            panel2.Controls.Add(buttonLogin);
            panel2.Controls.Add(textBoxContraseña);
            panel2.Controls.Add(textBoxUsuario);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(99, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 213);
            panel2.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(638, 378);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "Login";
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
        private Panel panel1;
        private Panel panel2;
    }
}