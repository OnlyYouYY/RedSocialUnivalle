namespace RedSocialUnivalle
{
    partial class MostrarUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGListaUsuarios = new System.Windows.Forms.DataGridView();
            this.BTNActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIOS ACTIVOS";
            // 
            // DGListaUsuarios
            // 
            this.DGListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListaUsuarios.Location = new System.Drawing.Point(84, 152);
            this.DGListaUsuarios.Name = "DGListaUsuarios";
            this.DGListaUsuarios.Size = new System.Drawing.Size(689, 309);
            this.DGListaUsuarios.TabIndex = 1;
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.BackColor = System.Drawing.Color.LimeGreen;
            this.BTNActualizar.ForeColor = System.Drawing.Color.White;
            this.BTNActualizar.Location = new System.Drawing.Point(664, 110);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(109, 36);
            this.BTNActualizar.TabIndex = 2;
            this.BTNActualizar.Text = "ACTUALIZAR";
            this.BTNActualizar.UseVisualStyleBackColor = false;
            this.BTNActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // MostrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 526);
            this.Controls.Add(this.BTNActualizar);
            this.Controls.Add(this.DGListaUsuarios);
            this.Controls.Add(this.label1);
            this.Name = "MostrarUsuarios";
            this.Text = "MostrarUsuarios";
            this.Load += new System.EventHandler(this.MostrarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGListaUsuarios;
        private System.Windows.Forms.Button BTNActualizar;
    }
}