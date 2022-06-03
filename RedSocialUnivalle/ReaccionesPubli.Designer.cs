namespace RedSocialUnivalle
{
    partial class ReaccionesPubli
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
            this.btnMeGustaR = new System.Windows.Forms.Button();
            this.btnMeEncantaR = new System.Windows.Forms.Button();
            this.btnNoMeGustaR = new System.Windows.Forms.Button();
            this.panelReacciones = new System.Windows.Forms.Panel();
            this.lbSuma = new System.Windows.Forms.Label();
            this.tbIdPublicacionReaccion = new System.Windows.Forms.TextBox();
            this.lbReacciones = new System.Windows.Forms.ListBox();
            this.panelReacciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMeGustaR
            // 
            this.btnMeGustaR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.btnMeGustaR.FlatAppearance.BorderSize = 0;
            this.btnMeGustaR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeGustaR.ForeColor = System.Drawing.Color.Black;
            this.btnMeGustaR.Image = global::RedSocialUnivalle.Properties.Resources.MeGusta;
            this.btnMeGustaR.Location = new System.Drawing.Point(61, 25);
            this.btnMeGustaR.Name = "btnMeGustaR";
            this.btnMeGustaR.Size = new System.Drawing.Size(46, 36);
            this.btnMeGustaR.TabIndex = 0;
            this.btnMeGustaR.UseVisualStyleBackColor = false;
            this.btnMeGustaR.Click += new System.EventHandler(this.btnMeGustaR_Click);
            // 
            // btnMeEncantaR
            // 
            this.btnMeEncantaR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.btnMeEncantaR.FlatAppearance.BorderSize = 0;
            this.btnMeEncantaR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeEncantaR.ForeColor = System.Drawing.Color.Black;
            this.btnMeEncantaR.Image = global::RedSocialUnivalle.Properties.Resources.MeEncanta;
            this.btnMeEncantaR.Location = new System.Drawing.Point(175, 25);
            this.btnMeEncantaR.Name = "btnMeEncantaR";
            this.btnMeEncantaR.Size = new System.Drawing.Size(46, 36);
            this.btnMeEncantaR.TabIndex = 1;
            this.btnMeEncantaR.UseVisualStyleBackColor = false;
            this.btnMeEncantaR.Click += new System.EventHandler(this.btnMeEncantaR_Click);
            // 
            // btnNoMeGustaR
            // 
            this.btnNoMeGustaR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.btnNoMeGustaR.FlatAppearance.BorderSize = 0;
            this.btnNoMeGustaR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoMeGustaR.ForeColor = System.Drawing.Color.Black;
            this.btnNoMeGustaR.Image = global::RedSocialUnivalle.Properties.Resources.NoMeGusta;
            this.btnNoMeGustaR.Location = new System.Drawing.Point(289, 25);
            this.btnNoMeGustaR.Name = "btnNoMeGustaR";
            this.btnNoMeGustaR.Size = new System.Drawing.Size(46, 36);
            this.btnNoMeGustaR.TabIndex = 2;
            this.btnNoMeGustaR.UseVisualStyleBackColor = false;
            this.btnNoMeGustaR.Click += new System.EventHandler(this.btnNoMeGustaR_Click);
            // 
            // panelReacciones
            // 
            this.panelReacciones.Controls.Add(this.lbReacciones);
            this.panelReacciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReacciones.Location = new System.Drawing.Point(0, 104);
            this.panelReacciones.Name = "panelReacciones";
            this.panelReacciones.Size = new System.Drawing.Size(399, 301);
            this.panelReacciones.TabIndex = 3;
            // 
            // lbSuma
            // 
            this.lbSuma.AutoSize = true;
            this.lbSuma.ForeColor = System.Drawing.Color.White;
            this.lbSuma.Location = new System.Drawing.Point(25, 74);
            this.lbSuma.Name = "lbSuma";
            this.lbSuma.Size = new System.Drawing.Size(0, 13);
            this.lbSuma.TabIndex = 4;
            // 
            // tbIdPublicacionReaccion
            // 
            this.tbIdPublicacionReaccion.Location = new System.Drawing.Point(12, 13);
            this.tbIdPublicacionReaccion.Name = "tbIdPublicacionReaccion";
            this.tbIdPublicacionReaccion.Size = new System.Drawing.Size(17, 20);
            this.tbIdPublicacionReaccion.TabIndex = 5;
            this.tbIdPublicacionReaccion.Visible = false;
            // 
            // lbReacciones
            // 
            this.lbReacciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.lbReacciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbReacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReacciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbReacciones.FormattingEnabled = true;
            this.lbReacciones.ItemHeight = 16;
            this.lbReacciones.Location = new System.Drawing.Point(61, 16);
            this.lbReacciones.Name = "lbReacciones";
            this.lbReacciones.Size = new System.Drawing.Size(274, 256);
            this.lbReacciones.TabIndex = 0;
            // 
            // ReaccionesPubli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(399, 405);
            this.Controls.Add(this.tbIdPublicacionReaccion);
            this.Controls.Add(this.lbSuma);
            this.Controls.Add(this.panelReacciones);
            this.Controls.Add(this.btnNoMeGustaR);
            this.Controls.Add(this.btnMeEncantaR);
            this.Controls.Add(this.btnMeGustaR);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ReaccionesPubli";
            this.Text = "ReaccionesPubli";
            this.Load += new System.EventHandler(this.ReaccionesPubli_Load);
            this.panelReacciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMeGustaR;
        private System.Windows.Forms.Button btnMeEncantaR;
        private System.Windows.Forms.Button btnNoMeGustaR;
        private System.Windows.Forms.Panel panelReacciones;
        private System.Windows.Forms.Label lbSuma;
        public System.Windows.Forms.TextBox tbIdPublicacionReaccion;
        private System.Windows.Forms.ListBox lbReacciones;
    }
}