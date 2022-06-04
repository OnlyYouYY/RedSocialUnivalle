namespace RedSocialUnivalle
{
    partial class ComentariosFLP
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
            this.pbPerfil = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.lbComentario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPerfil
            // 
            this.pbPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbPerfil.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbPerfil.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbPerfil.BorderSize = 2;
            this.pbPerfil.GradientAngle = 50F;
            this.pbPerfil.Location = new System.Drawing.Point(104, 13);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(56, 56);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 0;
            this.pbPerfil.TabStop = false;
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfil.ForeColor = System.Drawing.Color.White;
            this.lbPerfil.Location = new System.Drawing.Point(175, 14);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(49, 23);
            this.lbPerfil.TabIndex = 1;
            this.lbPerfil.Text = "label1";
            // 
            // lbComentario
            // 
            this.lbComentario.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComentario.ForeColor = System.Drawing.Color.White;
            this.lbComentario.Location = new System.Drawing.Point(175, 32);
            this.lbComentario.Name = "lbComentario";
            this.lbComentario.Size = new System.Drawing.Size(403, 37);
            this.lbComentario.TabIndex = 2;
            this.lbComentario.Text = "label2";
            // 
            // ComentariosFLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.Controls.Add(this.lbComentario);
            this.Controls.Add(this.lbPerfil);
            this.Controls.Add(this.pbPerfil);
            this.Name = "ComentariosFLP";
            this.Size = new System.Drawing.Size(695, 84);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public RJCodeAdvance.RJControls.RJCircularPictureBox pbPerfil;
        public System.Windows.Forms.Label lbPerfil;
        public System.Windows.Forms.Label lbComentario;
    }
}
