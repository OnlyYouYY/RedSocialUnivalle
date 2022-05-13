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
            this.DGMostrarSolicitudes = new System.Windows.Forms.DataGridView();
            this.TBIdUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBIdSolicitud = new System.Windows.Forms.TextBox();
            this.BTNBorrarSolicitud = new System.Windows.Forms.Button();
            this.BTNAceptarSolicitud = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGMostrarSolicitudes
            // 
            this.DGMostrarSolicitudes.AllowUserToAddRows = false;
            this.DGMostrarSolicitudes.AllowUserToDeleteRows = false;
            this.DGMostrarSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMostrarSolicitudes.Location = new System.Drawing.Point(65, 85);
            this.DGMostrarSolicitudes.Name = "DGMostrarSolicitudes";
            this.DGMostrarSolicitudes.ReadOnly = true;
            this.DGMostrarSolicitudes.Size = new System.Drawing.Size(362, 274);
            this.DGMostrarSolicitudes.TabIndex = 0;
            // 
            // TBIdUsuario
            // 
            this.TBIdUsuario.Enabled = false;
            this.TBIdUsuario.Location = new System.Drawing.Point(773, 12);
            this.TBIdUsuario.Name = "TBIdUsuario";
            this.TBIdUsuario.Size = new System.Drawing.Size(15, 20);
            this.TBIdUsuario.TabIndex = 1;
            this.TBIdUsuario.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SOLICITUDES DE AMISTAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Solicitud";
            // 
            // TBIdSolicitud
            // 
            this.TBIdSolicitud.Location = new System.Drawing.Point(457, 115);
            this.TBIdSolicitud.Name = "TBIdSolicitud";
            this.TBIdSolicitud.Size = new System.Drawing.Size(271, 20);
            this.TBIdSolicitud.TabIndex = 4;
            // 
            // BTNBorrarSolicitud
            // 
            this.BTNBorrarSolicitud.BackColor = System.Drawing.Color.Red;
            this.BTNBorrarSolicitud.ForeColor = System.Drawing.Color.White;
            this.BTNBorrarSolicitud.Location = new System.Drawing.Point(457, 159);
            this.BTNBorrarSolicitud.Name = "BTNBorrarSolicitud";
            this.BTNBorrarSolicitud.Size = new System.Drawing.Size(128, 84);
            this.BTNBorrarSolicitud.TabIndex = 5;
            this.BTNBorrarSolicitud.Text = "-  BORRAR SOLICITUD";
            this.BTNBorrarSolicitud.UseVisualStyleBackColor = false;
            this.BTNBorrarSolicitud.Click += new System.EventHandler(this.BTNBorrarSolicitud_Click);
            // 
            // BTNAceptarSolicitud
            // 
            this.BTNAceptarSolicitud.BackColor = System.Drawing.Color.LimeGreen;
            this.BTNAceptarSolicitud.ForeColor = System.Drawing.Color.White;
            this.BTNAceptarSolicitud.Location = new System.Drawing.Point(600, 159);
            this.BTNAceptarSolicitud.Name = "BTNAceptarSolicitud";
            this.BTNAceptarSolicitud.Size = new System.Drawing.Size(128, 84);
            this.BTNAceptarSolicitud.TabIndex = 6;
            this.BTNAceptarSolicitud.Text = "+  ACEPTAR SOLICITUD";
            this.BTNAceptarSolicitud.UseVisualStyleBackColor = false;
            this.BTNAceptarSolicitud.Click += new System.EventHandler(this.BTNAceptarSolicitud_Click);
            // 
            // MostrarSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.BTNAceptarSolicitud);
            this.Controls.Add(this.BTNBorrarSolicitud);
            this.Controls.Add(this.TBIdSolicitud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBIdUsuario);
            this.Controls.Add(this.DGMostrarSolicitudes);
            this.Name = "MostrarSolicitudes";
            this.Text = "MostrarSolicitudes";
            this.Load += new System.EventHandler(this.MostrarSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGMostrarSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGMostrarSolicitudes;
        private System.Windows.Forms.TextBox TBIdUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBIdSolicitud;
        private System.Windows.Forms.Button BTNBorrarSolicitud;
        private System.Windows.Forms.Button BTNAceptarSolicitud;
    }
}