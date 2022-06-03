namespace RedSocialUnivalle
{
    partial class ChatMasServidor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbIdUsuario2 = new System.Windows.Forms.TextBox();
            this.tbIdAmigo2 = new System.Windows.Forms.TextBox();
            this.tbIdUsuario1 = new System.Windows.Forms.TextBox();
            this.nombreUsuarioChat = new System.Windows.Forms.Label();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.tbEnviarMsg = new RedSocialUnivalle.claseTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbImagenAmigo = new RedSocialUnivalle.ClasePictureBox();
            this.btnInfoUsuario = new FontAwesome.Sharp.IconButton();
            this.btnEnviar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenAmigo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.pbImagenAmigo);
            this.panel1.Controls.Add(this.tbIdUsuario2);
            this.panel1.Controls.Add(this.tbIdAmigo2);
            this.panel1.Controls.Add(this.tbIdUsuario1);
            this.panel1.Controls.Add(this.btnInfoUsuario);
            this.panel1.Controls.Add(this.nombreUsuarioChat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 75);
            this.panel1.TabIndex = 9;
            // 
            // tbIdUsuario2
            // 
            this.tbIdUsuario2.Location = new System.Drawing.Point(503, 28);
            this.tbIdUsuario2.Name = "tbIdUsuario2";
            this.tbIdUsuario2.Size = new System.Drawing.Size(100, 20);
            this.tbIdUsuario2.TabIndex = 7;
            this.tbIdUsuario2.Visible = false;
            // 
            // tbIdAmigo2
            // 
            this.tbIdAmigo2.Location = new System.Drawing.Point(167, 32);
            this.tbIdAmigo2.Name = "tbIdAmigo2";
            this.tbIdAmigo2.Size = new System.Drawing.Size(23, 20);
            this.tbIdAmigo2.TabIndex = 4;
            this.tbIdAmigo2.Visible = false;
            // 
            // tbIdUsuario1
            // 
            this.tbIdUsuario1.Location = new System.Drawing.Point(397, 28);
            this.tbIdUsuario1.Name = "tbIdUsuario1";
            this.tbIdUsuario1.Size = new System.Drawing.Size(100, 20);
            this.tbIdUsuario1.TabIndex = 6;
            this.tbIdUsuario1.Visible = false;
            // 
            // nombreUsuarioChat
            // 
            this.nombreUsuarioChat.AutoSize = true;
            this.nombreUsuarioChat.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuarioChat.ForeColor = System.Drawing.Color.White;
            this.nombreUsuarioChat.Location = new System.Drawing.Point(75, 31);
            this.nombreUsuarioChat.Name = "nombreUsuarioChat";
            this.nombreUsuarioChat.Size = new System.Drawing.Size(86, 18);
            this.nombreUsuarioChat.TabIndex = 2;
            this.nombreUsuarioChat.Text = "Usuario 1";
            // 
            // lbChat
            // 
            this.lbChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.lbChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbChat.ForeColor = System.Drawing.Color.White;
            this.lbChat.FormattingEnabled = true;
            this.lbChat.Location = new System.Drawing.Point(0, 75);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(799, 312);
            this.lbChat.TabIndex = 11;
            // 
            // tbEnviarMsg
            // 
            this.tbEnviarMsg.BackColor = System.Drawing.SystemColors.Window;
            this.tbEnviarMsg.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbEnviarMsg.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbEnviarMsg.BorderRadius = 13;
            this.tbEnviarMsg.BorderSize = 2;
            this.tbEnviarMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnviarMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEnviarMsg.Location = new System.Drawing.Point(30, 13);
            this.tbEnviarMsg.Margin = new System.Windows.Forms.Padding(4);
            this.tbEnviarMsg.Multiline = false;
            this.tbEnviarMsg.Name = "tbEnviarMsg";
            this.tbEnviarMsg.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbEnviarMsg.PasswordChar = false;
            this.tbEnviarMsg.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEnviarMsg.PlaceholderText = "Mensaje...";
            this.tbEnviarMsg.Size = new System.Drawing.Size(696, 31);
            this.tbEnviarMsg.TabIndex = 1;
            this.tbEnviarMsg.Texts = "";
            this.tbEnviarMsg.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.panel3.Controls.Add(this.btnEnviar);
            this.panel3.Controls.Add(this.tbEnviarMsg);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 392);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 58);
            this.panel3.TabIndex = 10;
            // 
            // pbImagenAmigo
            // 
            this.pbImagenAmigo.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbImagenAmigo.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbImagenAmigo.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbImagenAmigo.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbImagenAmigo.BorderSize = 2;
            this.pbImagenAmigo.GradientAngle = 50F;
            this.pbImagenAmigo.Location = new System.Drawing.Point(12, 12);
            this.pbImagenAmigo.Name = "pbImagenAmigo";
            this.pbImagenAmigo.Size = new System.Drawing.Size(54, 54);
            this.pbImagenAmigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenAmigo.TabIndex = 5;
            this.pbImagenAmigo.TabStop = false;
            // 
            // btnInfoUsuario
            // 
            this.btnInfoUsuario.FlatAppearance.BorderSize = 0;
            this.btnInfoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoUsuario.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
            this.btnInfoUsuario.IconColor = System.Drawing.Color.White;
            this.btnInfoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfoUsuario.IconSize = 25;
            this.btnInfoUsuario.Location = new System.Drawing.Point(751, 28);
            this.btnInfoUsuario.Name = "btnInfoUsuario";
            this.btnInfoUsuario.Size = new System.Drawing.Size(21, 23);
            this.btnInfoUsuario.TabIndex = 3;
            this.btnInfoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnEnviar.IconColor = System.Drawing.Color.White;
            this.btnEnviar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnviar.IconSize = 25;
            this.btnEnviar.Location = new System.Drawing.Point(751, 21);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(21, 23);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // ChatMasServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbChat);
            this.Controls.Add(this.panel3);
            this.Name = "ChatMasServidor";
            this.Text = "ChatMasServidor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenAmigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ClasePictureBox pbImagenAmigo;
        public System.Windows.Forms.TextBox tbIdUsuario2;
        public System.Windows.Forms.TextBox tbIdAmigo2;
        public System.Windows.Forms.TextBox tbIdUsuario1;
        private FontAwesome.Sharp.IconButton btnInfoUsuario;
        public System.Windows.Forms.Label nombreUsuarioChat;
        private claseTextBox tbEnviarMsg;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnEnviar;
        private System.Windows.Forms.ListBox lbChat;
    }
}