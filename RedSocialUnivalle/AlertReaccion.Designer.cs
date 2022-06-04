namespace RedSocialUnivalle
{
    partial class AlertReaccion
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
            this.LBAlerta = new System.Windows.Forms.Label();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.iconCerrar = new FontAwesome.Sharp.IconButton();
            this.iconMinimizar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.iconCerrar);
            this.panel1.Controls.Add(this.iconMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 33);
            this.panel1.TabIndex = 37;
            // 
            // LBAlerta
            // 
            this.LBAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAlerta.ForeColor = System.Drawing.Color.White;
            this.LBAlerta.Location = new System.Drawing.Point(63, 73);
            this.LBAlerta.Name = "LBAlerta";
            this.LBAlerta.Size = new System.Drawing.Size(253, 21);
            this.LBAlerta.TabIndex = 38;
            this.LBAlerta.Text = "Reaccion regitrada exitosamente.";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Crimson;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Crimson;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 13;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(114, 107);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 39;
            this.rjButton1.Text = "Aceptar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
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
            this.iconCerrar.Location = new System.Drawing.Point(349, 6);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(28, 23);
            this.iconCerrar.TabIndex = 9;
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
            this.iconMinimizar.Location = new System.Drawing.Point(321, 6);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(28, 23);
            this.iconMinimizar.TabIndex = 8;
            this.iconMinimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconMinimizar.UseVisualStyleBackColor = true;
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(385, 175);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.LBAlerta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert";
            this.Text = "Alert";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconCerrar;
        private FontAwesome.Sharp.IconButton iconMinimizar;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        public System.Windows.Forms.Label LBAlerta;
    }
}