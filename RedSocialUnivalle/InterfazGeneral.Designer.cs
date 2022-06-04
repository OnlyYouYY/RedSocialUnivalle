namespace RedSocialUnivalle
{
    partial class InterfazGeneral
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
            this.panelButtonActions = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new RJCodeAdvance.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbIdUsuarioSistema = new System.Windows.Forms.TextBox();
            this.lbApellidoUsuario = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsuarioSistema = new System.Windows.Forms.Label();
            this.panelRecargable = new System.Windows.Forms.Panel();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.iconMiUsuario = new FontAwesome.Sharp.IconButton();
            this.iconChat = new FontAwesome.Sharp.IconButton();
            this.iconAmigos = new FontAwesome.Sharp.IconButton();
            this.iconPublicaciones = new FontAwesome.Sharp.IconButton();
            this.pbPerfilInicio = new RedSocialUnivalle.ClasePictureBox();
            this.iconCerrar = new FontAwesome.Sharp.IconButton();
            this.iconMinimizar = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panelButtonActions.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelRecargable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfilInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtonActions
            // 
            this.panelButtonActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.panelButtonActions.Controls.Add(this.iconCerrar);
            this.panelButtonActions.Controls.Add(this.iconMinimizar);
            this.panelButtonActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonActions.Location = new System.Drawing.Point(0, 0);
            this.panelButtonActions.Name = "panelButtonActions";
            this.panelButtonActions.Size = new System.Drawing.Size(1186, 33);
            this.panelButtonActions.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.iconMiUsuario);
            this.panelMenu.Controls.Add(this.iconChat);
            this.panelMenu.Controls.Add(this.iconAmigos);
            this.panelMenu.Controls.Add(this.iconPublicaciones);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 33);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(216, 637);
            this.panelMenu.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrarSesion.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnCerrarSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCerrarSesion.BorderRadius = 13;
            this.btnCerrarSesion.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(36, 548);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(139, 59);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "CERRAR SESION";
            this.btnCerrarSesion.TextColor = System.Drawing.Color.White;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbIdUsuarioSistema);
            this.panel1.Controls.Add(this.lbApellidoUsuario);
            this.panel1.Controls.Add(this.lbNombreUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbUsuarioSistema);
            this.panel1.Controls.Add(this.pbPerfilInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 241);
            this.panel1.TabIndex = 0;
            // 
            // tbIdUsuarioSistema
            // 
            this.tbIdUsuarioSistema.Location = new System.Drawing.Point(193, 119);
            this.tbIdUsuarioSistema.Name = "tbIdUsuarioSistema";
            this.tbIdUsuarioSistema.Size = new System.Drawing.Size(17, 20);
            this.tbIdUsuarioSistema.TabIndex = 7;
            this.tbIdUsuarioSistema.Visible = false;
            // 
            // lbApellidoUsuario
            // 
            this.lbApellidoUsuario.AutoSize = true;
            this.lbApellidoUsuario.ForeColor = System.Drawing.Color.White;
            this.lbApellidoUsuario.Location = new System.Drawing.Point(104, 206);
            this.lbApellidoUsuario.Name = "lbApellidoUsuario";
            this.lbApellidoUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbApellidoUsuario.TabIndex = 6;
            this.lbApellidoUsuario.Text = "label1";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lbNombreUsuario.Location = new System.Drawing.Point(104, 176);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbNombreUsuario.TabIndex = 5;
            this.lbNombreUsuario.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // lbUsuarioSistema
            // 
            this.lbUsuarioSistema.AutoSize = true;
            this.lbUsuarioSistema.ForeColor = System.Drawing.Color.White;
            this.lbUsuarioSistema.Location = new System.Drawing.Point(103, 146);
            this.lbUsuarioSistema.Name = "lbUsuarioSistema";
            this.lbUsuarioSistema.Size = new System.Drawing.Size(35, 13);
            this.lbUsuarioSistema.TabIndex = 1;
            this.lbUsuarioSistema.Text = "label1";
            // 
            // panelRecargable
            // 
            this.panelRecargable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.panelRecargable.Controls.Add(this.pbPortada);
            this.panelRecargable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRecargable.Location = new System.Drawing.Point(216, 33);
            this.panelRecargable.Name = "panelRecargable";
            this.panelRecargable.Size = new System.Drawing.Size(970, 637);
            this.panelRecargable.TabIndex = 2;
            this.panelRecargable.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRecargable_Paint);
            // 
            // pbPortada
            // 
            this.pbPortada.Location = new System.Drawing.Point(0, 0);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(970, 637);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            // 
            // iconMiUsuario
            // 
            this.iconMiUsuario.FlatAppearance.BorderSize = 0;
            this.iconMiUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMiUsuario.ForeColor = System.Drawing.Color.White;
            this.iconMiUsuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconMiUsuario.IconColor = System.Drawing.Color.White;
            this.iconMiUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMiUsuario.Location = new System.Drawing.Point(58, 463);
            this.iconMiUsuario.Name = "iconMiUsuario";
            this.iconMiUsuario.Size = new System.Drawing.Size(96, 64);
            this.iconMiUsuario.TabIndex = 3;
            this.iconMiUsuario.Text = "Mi Usuario";
            this.iconMiUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconMiUsuario.UseVisualStyleBackColor = true;
            this.iconMiUsuario.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconChat
            // 
            this.iconChat.FlatAppearance.BorderSize = 0;
            this.iconChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconChat.ForeColor = System.Drawing.Color.White;
            this.iconChat.IconChar = FontAwesome.Sharp.IconChar.Microblog;
            this.iconChat.IconColor = System.Drawing.Color.White;
            this.iconChat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChat.Location = new System.Drawing.Point(58, 393);
            this.iconChat.Name = "iconChat";
            this.iconChat.Size = new System.Drawing.Size(96, 64);
            this.iconChat.TabIndex = 4;
            this.iconChat.Text = "Chat";
            this.iconChat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconChat.UseVisualStyleBackColor = true;
            this.iconChat.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconAmigos
            // 
            this.iconAmigos.FlatAppearance.BorderSize = 0;
            this.iconAmigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAmigos.ForeColor = System.Drawing.Color.White;
            this.iconAmigos.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconAmigos.IconColor = System.Drawing.Color.White;
            this.iconAmigos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAmigos.Location = new System.Drawing.Point(58, 323);
            this.iconAmigos.Name = "iconAmigos";
            this.iconAmigos.Size = new System.Drawing.Size(96, 64);
            this.iconAmigos.TabIndex = 2;
            this.iconAmigos.Text = "Amigos";
            this.iconAmigos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconAmigos.UseVisualStyleBackColor = true;
            this.iconAmigos.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconPublicaciones
            // 
            this.iconPublicaciones.FlatAppearance.BorderSize = 0;
            this.iconPublicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPublicaciones.ForeColor = System.Drawing.Color.White;
            this.iconPublicaciones.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.iconPublicaciones.IconColor = System.Drawing.Color.White;
            this.iconPublicaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPublicaciones.Location = new System.Drawing.Point(58, 253);
            this.iconPublicaciones.Name = "iconPublicaciones";
            this.iconPublicaciones.Size = new System.Drawing.Size(96, 64);
            this.iconPublicaciones.TabIndex = 1;
            this.iconPublicaciones.Text = "Publicaciones";
            this.iconPublicaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconPublicaciones.UseVisualStyleBackColor = true;
            this.iconPublicaciones.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pbPerfilInicio
            // 
            this.pbPerfilInicio.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbPerfilInicio.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbPerfilInicio.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbPerfilInicio.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbPerfilInicio.BorderSize = 2;
            this.pbPerfilInicio.GradientAngle = 50F;
            this.pbPerfilInicio.Location = new System.Drawing.Point(43, 13);
            this.pbPerfilInicio.Name = "pbPerfilInicio";
            this.pbPerfilInicio.Size = new System.Drawing.Size(121, 121);
            this.pbPerfilInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfilInicio.TabIndex = 0;
            this.pbPerfilInicio.TabStop = false;
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
            this.iconCerrar.Location = new System.Drawing.Point(1143, 7);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(28, 23);
            this.iconCerrar.TabIndex = 7;
            this.iconCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconCerrar.UseVisualStyleBackColor = true;
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
            this.iconMinimizar.Location = new System.Drawing.Point(1115, 7);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(28, 23);
            this.iconMinimizar.TabIndex = 6;
            this.iconMinimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconMinimizar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "pruebas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InterfazGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 670);
            this.Controls.Add(this.panelRecargable);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelButtonActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazGeneral";
            this.Text = "InterfazGeneral";
            this.Load += new System.EventHandler(this.InterfazGeneral_Load);
            this.panelButtonActions.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRecargable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfilInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtonActions;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelRecargable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbApellidoUsuario;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsuarioSistema;
        private ClasePictureBox pbPerfilInicio;
        private FontAwesome.Sharp.IconButton iconAmigos;
        private FontAwesome.Sharp.IconButton iconPublicaciones;
        private FontAwesome.Sharp.IconButton iconMiUsuario;
        private FontAwesome.Sharp.IconButton iconChat;
        private System.Windows.Forms.TextBox tbIdUsuarioSistema;
        private System.Windows.Forms.PictureBox pbPortada;
        private RJCodeAdvance.RJControls.RJButton btnCerrarSesion;
        private FontAwesome.Sharp.IconButton iconCerrar;
        private FontAwesome.Sharp.IconButton iconMinimizar;
        private System.Windows.Forms.Button button1;
    }
}