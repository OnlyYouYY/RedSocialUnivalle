namespace RedSocialUnivalle
{
    partial class FormularioAmigos
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
            this.panelMenuAmigos = new System.Windows.Forms.Panel();
            this.iconListaAmigos = new FontAwesome.Sharp.IconButton();
            this.iconSolicitudes = new FontAwesome.Sharp.IconButton();
            this.iconAñadirAmigo = new FontAwesome.Sharp.IconButton();
            this.panelRefreshAmigos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCerrar = new RJCodeAdvance.RJControls.RJButton();
            this.panelMenuAmigos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuAmigos
            // 
            this.panelMenuAmigos.Controls.Add(this.btnCerrar);
            this.panelMenuAmigos.Controls.Add(this.iconListaAmigos);
            this.panelMenuAmigos.Controls.Add(this.iconSolicitudes);
            this.panelMenuAmigos.Controls.Add(this.iconAñadirAmigo);
            this.panelMenuAmigos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuAmigos.Location = new System.Drawing.Point(0, 0);
            this.panelMenuAmigos.Name = "panelMenuAmigos";
            this.panelMenuAmigos.Size = new System.Drawing.Size(216, 598);
            this.panelMenuAmigos.TabIndex = 0;
            // 
            // iconListaAmigos
            // 
            this.iconListaAmigos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(27)))));
            this.iconListaAmigos.FlatAppearance.BorderSize = 0;
            this.iconListaAmigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconListaAmigos.ForeColor = System.Drawing.Color.White;
            this.iconListaAmigos.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconListaAmigos.IconColor = System.Drawing.Color.White;
            this.iconListaAmigos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconListaAmigos.Location = new System.Drawing.Point(50, 358);
            this.iconListaAmigos.Name = "iconListaAmigos";
            this.iconListaAmigos.Size = new System.Drawing.Size(120, 65);
            this.iconListaAmigos.TabIndex = 16;
            this.iconListaAmigos.Text = "Lista de Amigos";
            this.iconListaAmigos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconListaAmigos.UseVisualStyleBackColor = false;
            this.iconListaAmigos.Click += new System.EventHandler(this.iconListaAmigos_Click);
            // 
            // iconSolicitudes
            // 
            this.iconSolicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(27)))));
            this.iconSolicitudes.FlatAppearance.BorderSize = 0;
            this.iconSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSolicitudes.ForeColor = System.Drawing.Color.White;
            this.iconSolicitudes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconSolicitudes.IconColor = System.Drawing.Color.White;
            this.iconSolicitudes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSolicitudes.Location = new System.Drawing.Point(50, 249);
            this.iconSolicitudes.Name = "iconSolicitudes";
            this.iconSolicitudes.Size = new System.Drawing.Size(120, 65);
            this.iconSolicitudes.TabIndex = 15;
            this.iconSolicitudes.Text = "Solicitudes";
            this.iconSolicitudes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconSolicitudes.UseVisualStyleBackColor = false;
            this.iconSolicitudes.Click += new System.EventHandler(this.iconSolicitudes_Click);
            // 
            // iconAñadirAmigo
            // 
            this.iconAñadirAmigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(27)))));
            this.iconAñadirAmigo.FlatAppearance.BorderSize = 0;
            this.iconAñadirAmigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAñadirAmigo.ForeColor = System.Drawing.Color.White;
            this.iconAñadirAmigo.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconAñadirAmigo.IconColor = System.Drawing.Color.White;
            this.iconAñadirAmigo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAñadirAmigo.Location = new System.Drawing.Point(50, 140);
            this.iconAñadirAmigo.Name = "iconAñadirAmigo";
            this.iconAñadirAmigo.Size = new System.Drawing.Size(120, 65);
            this.iconAñadirAmigo.TabIndex = 14;
            this.iconAñadirAmigo.Text = "Añadir Amigo";
            this.iconAñadirAmigo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconAñadirAmigo.UseVisualStyleBackColor = false;
            this.iconAñadirAmigo.Click += new System.EventHandler(this.iconAñadirAmigo_Click);
            // 
            // panelRefreshAmigos
            // 
            this.panelRefreshAmigos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRefreshAmigos.Location = new System.Drawing.Point(216, 0);
            this.panelRefreshAmigos.Name = "panelRefreshAmigos";
            this.panelRefreshAmigos.Size = new System.Drawing.Size(738, 598);
            this.panelRefreshAmigos.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.BackgroundColor = System.Drawing.Color.Red;
            this.btnCerrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCerrar.BorderRadius = 13;
            this.btnCerrar.BorderSize = 0;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(50, 482);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 40);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextColor = System.Drawing.Color.White;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormularioAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(954, 598);
            this.Controls.Add(this.panelRefreshAmigos);
            this.Controls.Add(this.panelMenuAmigos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioAmigos";
            this.Text = "FormularioAmigos";
            this.Load += new System.EventHandler(this.FormularioAmigos_Load);
            this.panelMenuAmigos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuAmigos;
        private System.Windows.Forms.FlowLayoutPanel panelRefreshAmigos;
        private FontAwesome.Sharp.IconButton iconSolicitudes;
        private FontAwesome.Sharp.IconButton iconAñadirAmigo;
        private FontAwesome.Sharp.IconButton iconListaAmigos;
        private RJCodeAdvance.RJControls.RJButton btnCerrar;
    }
}