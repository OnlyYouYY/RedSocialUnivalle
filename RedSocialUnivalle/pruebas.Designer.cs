namespace RedSocialUnivalle
{
    partial class pruebas
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
            this.FLPPublicaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FLPPublicaciones
            // 
            this.FLPPublicaciones.AutoScroll = true;
            this.FLPPublicaciones.Location = new System.Drawing.Point(12, 12);
            this.FLPPublicaciones.Name = "FLPPublicaciones";
            this.FLPPublicaciones.Size = new System.Drawing.Size(720, 406);
            this.FLPPublicaciones.TabIndex = 1;
            // 
            // pruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FLPPublicaciones);
            this.Name = "pruebas";
            this.Text = "pruebas";
            this.Load += new System.EventHandler(this.pruebas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPPublicaciones;
    }
}