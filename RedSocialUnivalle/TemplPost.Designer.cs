namespace RedSocialUnivalle
{
    partial class TemplPost
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PostUser = new System.Windows.Forms.Label();
            this.PostDateTime = new System.Windows.Forms.Label();
            this.PostTitle = new System.Windows.Forms.Label();
            this.PostContent = new System.Windows.Forms.Label();
            this.tbIdPublicacion = new System.Windows.Forms.TextBox();
            this.tbIdUsuario = new System.Windows.Forms.TextBox();
            this.tbNombreInicio = new System.Windows.Forms.TextBox();
            this.btnComentarios = new FontAwesome.Sharp.IconButton();
            this.PostImage = new System.Windows.Forms.PictureBox();
            this.PostProfile = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.btnReacciones = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.PostImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // PostUser
            // 
            this.PostUser.AutoSize = true;
            this.PostUser.BackColor = System.Drawing.Color.Transparent;
            this.PostUser.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostUser.ForeColor = System.Drawing.Color.White;
            this.PostUser.Location = new System.Drawing.Point(356, 34);
            this.PostUser.Name = "PostUser";
            this.PostUser.Size = new System.Drawing.Size(49, 23);
            this.PostUser.TabIndex = 0;
            this.PostUser.Text = "label1";
            // 
            // PostDateTime
            // 
            this.PostDateTime.AutoSize = true;
            this.PostDateTime.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostDateTime.ForeColor = System.Drawing.Color.White;
            this.PostDateTime.Location = new System.Drawing.Point(285, 100);
            this.PostDateTime.Name = "PostDateTime";
            this.PostDateTime.Size = new System.Drawing.Size(40, 19);
            this.PostDateTime.TabIndex = 2;
            this.PostDateTime.Text = "label1";
            // 
            // PostTitle
            // 
            this.PostTitle.AutoSize = true;
            this.PostTitle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostTitle.ForeColor = System.Drawing.Color.White;
            this.PostTitle.Location = new System.Drawing.Point(285, 80);
            this.PostTitle.Name = "PostTitle";
            this.PostTitle.Size = new System.Drawing.Size(40, 19);
            this.PostTitle.TabIndex = 5;
            this.PostTitle.Text = "label1";
            // 
            // PostContent
            // 
            this.PostContent.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostContent.ForeColor = System.Drawing.Color.White;
            this.PostContent.Location = new System.Drawing.Point(285, 119);
            this.PostContent.Name = "PostContent";
            this.PostContent.Size = new System.Drawing.Size(401, 49);
            this.PostContent.TabIndex = 7;
            this.PostContent.Text = "label2";
            // 
            // tbIdPublicacion
            // 
            this.tbIdPublicacion.Location = new System.Drawing.Point(655, 34);
            this.tbIdPublicacion.Name = "tbIdPublicacion";
            this.tbIdPublicacion.Size = new System.Drawing.Size(31, 20);
            this.tbIdPublicacion.TabIndex = 10;
            // 
            // tbIdUsuario
            // 
            this.tbIdUsuario.Location = new System.Drawing.Point(655, 61);
            this.tbIdUsuario.Name = "tbIdUsuario";
            this.tbIdUsuario.Size = new System.Drawing.Size(31, 20);
            this.tbIdUsuario.TabIndex = 13;
            // 
            // tbNombreInicio
            // 
            this.tbNombreInicio.Location = new System.Drawing.Point(655, 88);
            this.tbNombreInicio.Name = "tbNombreInicio";
            this.tbNombreInicio.Size = new System.Drawing.Size(31, 20);
            this.tbNombreInicio.TabIndex = 14;
            // 
            // btnComentarios
            // 
            this.btnComentarios.FlatAppearance.BorderSize = 0;
            this.btnComentarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComentarios.ForeColor = System.Drawing.Color.White;
            this.btnComentarios.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.btnComentarios.IconColor = System.Drawing.Color.White;
            this.btnComentarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComentarios.IconSize = 35;
            this.btnComentarios.Location = new System.Drawing.Point(612, 454);
            this.btnComentarios.Name = "btnComentarios";
            this.btnComentarios.Size = new System.Drawing.Size(74, 49);
            this.btnComentarios.TabIndex = 9;
            this.btnComentarios.Text = "Comentarios";
            this.btnComentarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComentarios.UseVisualStyleBackColor = true;
            this.btnComentarios.Click += new System.EventHandler(this.btnComentarios_Click);
            // 
            // PostImage
            // 
            this.PostImage.Location = new System.Drawing.Point(288, 175);
            this.PostImage.Name = "PostImage";
            this.PostImage.Size = new System.Drawing.Size(398, 273);
            this.PostImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PostImage.TabIndex = 4;
            this.PostImage.TabStop = false;
            // 
            // PostProfile
            // 
            this.PostProfile.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PostProfile.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PostProfile.BorderColor2 = System.Drawing.Color.HotPink;
            this.PostProfile.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PostProfile.BorderSize = 2;
            this.PostProfile.GradientAngle = 50F;
            this.PostProfile.Location = new System.Drawing.Point(288, 15);
            this.PostProfile.Name = "PostProfile";
            this.PostProfile.Size = new System.Drawing.Size(57, 57);
            this.PostProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PostProfile.TabIndex = 1;
            this.PostProfile.TabStop = false;
            // 
            // btnReacciones
            // 
            this.btnReacciones.FlatAppearance.BorderSize = 0;
            this.btnReacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReacciones.ForeColor = System.Drawing.Color.White;
            this.btnReacciones.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnReacciones.IconColor = System.Drawing.Color.White;
            this.btnReacciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReacciones.IconSize = 35;
            this.btnReacciones.Location = new System.Drawing.Point(288, 454);
            this.btnReacciones.Name = "btnReacciones";
            this.btnReacciones.Size = new System.Drawing.Size(74, 49);
            this.btnReacciones.TabIndex = 15;
            this.btnReacciones.Text = "Reacciona";
            this.btnReacciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReacciones.UseVisualStyleBackColor = true;
            this.btnReacciones.Click += new System.EventHandler(this.btnReacciones_Click);
            // 
            // TemplPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.Controls.Add(this.btnReacciones);
            this.Controls.Add(this.tbNombreInicio);
            this.Controls.Add(this.tbIdUsuario);
            this.Controls.Add(this.tbIdPublicacion);
            this.Controls.Add(this.btnComentarios);
            this.Controls.Add(this.PostContent);
            this.Controls.Add(this.PostTitle);
            this.Controls.Add(this.PostImage);
            this.Controls.Add(this.PostDateTime);
            this.Controls.Add(this.PostProfile);
            this.Controls.Add(this.PostUser);
            this.Name = "TemplPost";
            this.Size = new System.Drawing.Size(970, 522);
            this.Load += new System.EventHandler(this.TemplPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PostImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label PostUser;
        public RJCodeAdvance.RJControls.RJCircularPictureBox PostProfile;
        public System.Windows.Forms.Label PostDateTime;
        public System.Windows.Forms.PictureBox PostImage;
        public System.Windows.Forms.Label PostTitle;
        public System.Windows.Forms.Label PostContent;
        private FontAwesome.Sharp.IconButton btnComentarios;
        public System.Windows.Forms.TextBox tbIdPublicacion;
        private System.Windows.Forms.TextBox tbIdUsuario;
        private System.Windows.Forms.TextBox tbNombreInicio;
        private FontAwesome.Sharp.IconButton btnReacciones;
    }
}
