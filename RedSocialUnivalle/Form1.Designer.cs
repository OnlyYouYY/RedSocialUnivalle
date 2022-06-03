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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.BTNRegistro = new System.Windows.Forms.Button();
            this.LNLBOlvideContraseña = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBContraseñaUsuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.TBNombreUsuario = new RJCodeAdvance.RJControls.RJTextBox();
            this.iconCerrar = new FontAwesome.Sharp.IconButton();
            this.iconMinimizar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.BTNLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
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
            this.BTNRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
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
            // TBContraseñaUsuario
            // 
            this.TBContraseñaUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.TBContraseñaUsuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TBContraseñaUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TBContraseñaUsuario.BorderRadius = 0;
            this.TBContraseñaUsuario.BorderSize = 2;
            this.TBContraseñaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContraseñaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBContraseñaUsuario.Location = new System.Drawing.Point(520, 206);
            this.TBContraseñaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TBContraseñaUsuario.Multiline = false;
            this.TBContraseñaUsuario.Name = "TBContraseñaUsuario";
            this.TBContraseñaUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBContraseñaUsuario.PasswordChar = true;
            this.TBContraseñaUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBContraseñaUsuario.PlaceholderText = "Contraseña...";
            this.TBContraseñaUsuario.Size = new System.Drawing.Size(266, 31);
            this.TBContraseñaUsuario.TabIndex = 9;
            this.TBContraseñaUsuario.Texts = "";
            this.TBContraseñaUsuario.UnderlinedStyle = false;
            // 
            // TBNombreUsuario
            // 
            this.TBNombreUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.TBNombreUsuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TBNombreUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TBNombreUsuario.BorderRadius = 0;
            this.TBNombreUsuario.BorderSize = 2;
            this.TBNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBNombreUsuario.Location = new System.Drawing.Point(520, 133);
            this.TBNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TBNombreUsuario.Multiline = false;
            this.TBNombreUsuario.Name = "TBNombreUsuario";
            this.TBNombreUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBNombreUsuario.PasswordChar = false;
            this.TBNombreUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBNombreUsuario.PlaceholderText = "Usuario...";
            this.TBNombreUsuario.Size = new System.Drawing.Size(266, 31);
            this.TBNombreUsuario.TabIndex = 10;
            this.TBNombreUsuario.Texts = "";
            this.TBNombreUsuario.UnderlinedStyle = false;
            // 
            // iconCerrar
            // 
            this.iconCerrar.FlatAppearance.BorderSize = 0;
            this.iconCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCerrar.ForeColor = System.Drawing.Color.White;
            this.iconCerrar.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleDown;
            this.iconCerrar.IconColor = System.Drawing.Color.Crimson;
            this.iconCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCerrar.IconSize = 28;
            this.iconCerrar.Location = new System.Drawing.Point(820, 6);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(28, 23);
            this.iconCerrar.TabIndex = 9;
            this.iconCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconCerrar.UseVisualStyleBackColor = true;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.FlatAppearance.BorderSize = 0;
            this.iconMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMinimizar.ForeColor = System.Drawing.Color.White;
            this.iconMinimizar.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.iconMinimizar.IconColor = System.Drawing.Color.White;
            this.iconMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimizar.IconSize = 25;
            this.iconMinimizar.Location = new System.Drawing.Point(792, 6);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(28, 23);
            this.iconMinimizar.TabIndex = 8;
            this.iconMinimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconMinimizar.UseVisualStyleBackColor = true;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.iconCerrar);
            this.panel1.Controls.Add(this.iconMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 33);
            this.panel1.TabIndex = 35;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(862, 417);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TBNombreUsuario);
            this.Controls.Add(this.TBContraseñaUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LNLBOlvideContraseña);
            this.Controls.Add(this.BTNRegistro);
            this.Controls.Add(this.BTNLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNLogin;
        private System.Windows.Forms.Button BTNRegistro;
        private System.Windows.Forms.LinkLabel LNLBOlvideContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJTextBox TBContraseñaUsuario;
        private RJCodeAdvance.RJControls.RJTextBox TBNombreUsuario;
        private FontAwesome.Sharp.IconButton iconCerrar;
        private FontAwesome.Sharp.IconButton iconMinimizar;
        private System.Windows.Forms.Panel panel1;
    }
}

