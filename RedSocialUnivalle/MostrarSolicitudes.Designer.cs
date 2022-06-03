namespace RedSocialUnivalle
{
    partial class MostrarSolicitudes
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
            this.TBIdUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNBorrarSolicitud = new System.Windows.Forms.Button();
            this.BTNAceptarSolicitud = new System.Windows.Forms.Button();
            this.lbSolicitudes = new System.Windows.Forms.ListBox();
            this.tbIdSolicitudes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBIdUsuario
            // 
            this.TBIdUsuario.Enabled = false;
            this.TBIdUsuario.Location = new System.Drawing.Point(567, 69);
            this.TBIdUsuario.Name = "TBIdUsuario";
            this.TBIdUsuario.Size = new System.Drawing.Size(63, 20);
            this.TBIdUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SOLICITUDES DE AMISTAD";
            // 
            // BTNBorrarSolicitud
            // 
            this.BTNBorrarSolicitud.BackColor = System.Drawing.Color.Red;
            this.BTNBorrarSolicitud.ForeColor = System.Drawing.Color.White;
            this.BTNBorrarSolicitud.Location = new System.Drawing.Point(85, 388);
            this.BTNBorrarSolicitud.Name = "BTNBorrarSolicitud";
            this.BTNBorrarSolicitud.Size = new System.Drawing.Size(128, 84);
            this.BTNBorrarSolicitud.TabIndex = 5;
            this.BTNBorrarSolicitud.Text = "-  BORRAR SOLICITUD";
            this.BTNBorrarSolicitud.UseVisualStyleBackColor = false;
            this.BTNBorrarSolicitud.Click += new System.EventHandler(this.BTNBorrarSolicitud_Click);
            // 
            // BTNAceptarSolicitud
            // 
            this.BTNAceptarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(27)))));
            this.BTNAceptarSolicitud.ForeColor = System.Drawing.Color.White;
            this.BTNAceptarSolicitud.Location = new System.Drawing.Point(502, 388);
            this.BTNAceptarSolicitud.Name = "BTNAceptarSolicitud";
            this.BTNAceptarSolicitud.Size = new System.Drawing.Size(128, 84);
            this.BTNAceptarSolicitud.TabIndex = 6;
            this.BTNAceptarSolicitud.Text = "+  ACEPTAR SOLICITUD";
            this.BTNAceptarSolicitud.UseVisualStyleBackColor = false;
            this.BTNAceptarSolicitud.Click += new System.EventHandler(this.BTNAceptarSolicitud_Click);
            // 
            // lbSolicitudes
            // 
            this.lbSolicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.lbSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSolicitudes.ForeColor = System.Drawing.Color.White;
            this.lbSolicitudes.FormattingEnabled = true;
            this.lbSolicitudes.Location = new System.Drawing.Point(85, 107);
            this.lbSolicitudes.Name = "lbSolicitudes";
            this.lbSolicitudes.Size = new System.Drawing.Size(545, 275);
            this.lbSolicitudes.TabIndex = 7;
            this.lbSolicitudes.SelectedIndexChanged += new System.EventHandler(this.lbSolicitudes_SelectedIndexChanged);
            // 
            // tbIdSolicitudes
            // 
            this.tbIdSolicitudes.Enabled = false;
            this.tbIdSolicitudes.Location = new System.Drawing.Point(567, 43);
            this.tbIdSolicitudes.Name = "tbIdSolicitudes";
            this.tbIdSolicitudes.Size = new System.Drawing.Size(63, 20);
            this.tbIdSolicitudes.TabIndex = 8;
            // 
            // MostrarSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(722, 559);
            this.Controls.Add(this.tbIdSolicitudes);
            this.Controls.Add(this.lbSolicitudes);
            this.Controls.Add(this.BTNAceptarSolicitud);
            this.Controls.Add(this.BTNBorrarSolicitud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBIdUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarSolicitudes";
            this.Text = "MostrarSolicitudes";
            this.Load += new System.EventHandler(this.MostrarSolicitudes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TBIdUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNBorrarSolicitud;
        private System.Windows.Forms.Button BTNAceptarSolicitud;
        private System.Windows.Forms.ListBox lbSolicitudes;
        private System.Windows.Forms.TextBox tbIdSolicitudes;
    }
}