namespace RedSocialUnivalle
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBNombreUsuario = new System.Windows.Forms.TextBox();
            this.TBContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.BTNRegistro = new System.Windows.Forms.Button();
            this.LNLBOlvideContraseña = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBNombreUsuario
            // 
            this.TBNombreUsuario.Location = new System.Drawing.Point(520, 143);
            this.TBNombreUsuario.Name = "TBNombreUsuario";
            this.TBNombreUsuario.Size = new System.Drawing.Size(266, 20);
            this.TBNombreUsuario.TabIndex = 0;
            // 
            // TBContraseñaUsuario
            // 
            this.TBContraseñaUsuario.Location = new System.Drawing.Point(520, 216);
            this.TBContraseñaUsuario.Name = "TBContraseñaUsuario";
            this.TBContraseñaUsuario.PasswordChar = '*';
            this.TBContraseñaUsuario.Size = new System.Drawing.Size(266, 20);
            this.TBContraseñaUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(517, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(517, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // BTNLogin
            // 
            this.BTNLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.BTNLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BTNLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLogin.ForeColor = System.Drawing.Color.White;
            this.BTNLogin.Location = new System.Drawing.Point(520, 252);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(129, 66);
            this.BTNLogin.TabIndex = 4;
            this.BTNLogin.Text = "LOGIN";
            this.BTNLogin.UseVisualStyleBackColor = false;
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // BTNRegistro
            // 
            this.BTNRegistro.BackColor = System.Drawing.Color.DarkCyan;
            this.BTNRegistro.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BTNRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRegistro.ForeColor = System.Drawing.Color.White;
            this.BTNRegistro.Location = new System.Drawing.Point(655, 252);
            this.BTNRegistro.Name = "BTNRegistro";
            this.BTNRegistro.Size = new System.Drawing.Size(131, 66);
            this.BTNRegistro.TabIndex = 5;
            this.BTNRegistro.Text = "REGISTRARSE";
            this.BTNRegistro.UseVisualStyleBackColor = false;
            this.BTNRegistro.Click += new System.EventHandler(this.BTNRegistro_Click);
            // 
            // LNLBOlvideContraseña
            // 
            this.LNLBOlvideContraseña.AutoSize = true;
            this.LNLBOlvideContraseña.ForeColor = System.Drawing.Color.Silver;
            this.LNLBOlvideContraseña.LinkColor = System.Drawing.Color.Silver;
            this.LNLBOlvideContraseña.Location = new System.Drawing.Point(593, 344);
            this.LNLBOlvideContraseña.Name = "LNLBOlvideContraseña";
            this.LNLBOlvideContraseña.Size = new System.Drawing.Size(131, 13);
            this.LNLBOlvideContraseña.TabIndex = 6;
            this.LNLBOlvideContraseña.TabStop = true;
            this.LNLBOlvideContraseña.Text = "¿Olvidaste tu contraseña?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(618, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "BIENVENIDO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RedSocialUnivalle.Properties.Resources.login1;
            this.pictureBox1.Location = new System.Drawing.Point(-32, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(880, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LNLBOlvideContraseña);
            this.Controls.Add(this.BTNRegistro);
            this.Controls.Add(this.BTNLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBContraseñaUsuario);
            this.Controls.Add(this.TBNombreUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBNombreUsuario;
        private System.Windows.Forms.TextBox TBContraseñaUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNLogin;
        private System.Windows.Forms.Button BTNRegistro;
        private System.Windows.Forms.LinkLabel LNLBOlvideContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

