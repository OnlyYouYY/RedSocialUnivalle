namespace RedSocialUnivalle
{
    partial class AñadirPublicacion
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
            this.TBTituloPublicacion = new System.Windows.Forms.TextBox();
            this.TBDescripcionPublicacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNAbrir = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.TBIdUsuario = new System.Windows.Forms.TextBox();
            this.TBNombreUsuario = new System.Windows.Forms.TextBox();
            this.PBPublicacion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBPublicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // TBTituloPublicacion
            // 
            this.TBTituloPublicacion.Location = new System.Drawing.Point(195, 95);
            this.TBTituloPublicacion.Name = "TBTituloPublicacion";
            this.TBTituloPublicacion.Size = new System.Drawing.Size(323, 20);
            this.TBTituloPublicacion.TabIndex = 0;
            // 
            // TBDescripcionPublicacion
            // 
            this.TBDescripcionPublicacion.Location = new System.Drawing.Point(95, 144);
            this.TBDescripcionPublicacion.Multiline = true;
            this.TBDescripcionPublicacion.Name = "TBDescripcionPublicacion";
            this.TBDescripcionPublicacion.Size = new System.Drawing.Size(423, 60);
            this.TBDescripcionPublicacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titulo Publicacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion Publicacion:";
            // 
            // BTNAbrir
            // 
            this.BTNAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNAbrir.Location = new System.Drawing.Point(95, 436);
            this.BTNAbrir.Name = "BTNAbrir";
            this.BTNAbrir.Size = new System.Drawing.Size(126, 53);
            this.BTNAbrir.TabIndex = 5;
            this.BTNAbrir.Text = "ABRIR IMAGEN";
            this.BTNAbrir.UseVisualStyleBackColor = true;
            this.BTNAbrir.Click += new System.EventHandler(this.BTNAbrir_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(27)))));
            this.BTNGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNGuardar.ForeColor = System.Drawing.Color.White;
            this.BTNGuardar.Location = new System.Drawing.Point(389, 436);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(129, 53);
            this.BTNGuardar.TabIndex = 6;
            this.BTNGuardar.Text = "+ AÑADIR PUBLICACION";
            this.BTNGuardar.UseVisualStyleBackColor = false;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // TBIdUsuario
            // 
            this.TBIdUsuario.Enabled = false;
            this.TBIdUsuario.Location = new System.Drawing.Point(544, 12);
            this.TBIdUsuario.Name = "TBIdUsuario";
            this.TBIdUsuario.Size = new System.Drawing.Size(33, 20);
            this.TBIdUsuario.TabIndex = 9;
            this.TBIdUsuario.Visible = false;
            // 
            // TBNombreUsuario
            // 
            this.TBNombreUsuario.Enabled = false;
            this.TBNombreUsuario.Location = new System.Drawing.Point(544, 38);
            this.TBNombreUsuario.Name = "TBNombreUsuario";
            this.TBNombreUsuario.Size = new System.Drawing.Size(33, 20);
            this.TBNombreUsuario.TabIndex = 10;
            this.TBNombreUsuario.Visible = false;
            // 
            // PBPublicacion
            // 
            this.PBPublicacion.Location = new System.Drawing.Point(95, 210);
            this.PBPublicacion.Name = "PBPublicacion";
            this.PBPublicacion.Size = new System.Drawing.Size(423, 220);
            this.PBPublicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPublicacion.TabIndex = 4;
            this.PBPublicacion.TabStop = false;
            // 
            // AñadirPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(611, 598);
            this.Controls.Add(this.TBNombreUsuario);
            this.Controls.Add(this.TBIdUsuario);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.BTNAbrir);
            this.Controls.Add(this.PBPublicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBDescripcionPublicacion);
            this.Controls.Add(this.TBTituloPublicacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AñadirPublicacion";
            this.Text = "AñadirPublicacion";
            this.Load += new System.EventHandler(this.AñadirPublicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBPublicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBTituloPublicacion;
        private System.Windows.Forms.TextBox TBDescripcionPublicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PBPublicacion;
        private System.Windows.Forms.Button BTNAbrir;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.TextBox TBIdUsuario;
        private System.Windows.Forms.TextBox TBNombreUsuario;
    }
}