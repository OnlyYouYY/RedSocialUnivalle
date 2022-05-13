namespace RedSocialUnivalle
{
    partial class MostrarListaAmigos
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
            this.DGListaAmigos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNActualizarLista = new System.Windows.Forms.Button();
            this.TBIdUsuario = new System.Windows.Forms.TextBox();
            this.DGListaAmigos2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaAmigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaAmigos2)).BeginInit();
            this.SuspendLayout();
            // 
            // DGListaAmigos
            // 
            this.DGListaAmigos.AllowUserToAddRows = false;
            this.DGListaAmigos.AllowUserToDeleteRows = false;
            this.DGListaAmigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListaAmigos.Location = new System.Drawing.Point(67, 117);
            this.DGListaAmigos.Name = "DGListaAmigos";
            this.DGListaAmigos.ReadOnly = true;
            this.DGListaAmigos.Size = new System.Drawing.Size(316, 244);
            this.DGListaAmigos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AMIGOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista de amigos";
            // 
            // BTNActualizarLista
            // 
            this.BTNActualizarLista.BackColor = System.Drawing.Color.LimeGreen;
            this.BTNActualizarLista.ForeColor = System.Drawing.Color.White;
            this.BTNActualizarLista.Location = new System.Drawing.Point(67, 367);
            this.BTNActualizarLista.Name = "BTNActualizarLista";
            this.BTNActualizarLista.Size = new System.Drawing.Size(642, 36);
            this.BTNActualizarLista.TabIndex = 3;
            this.BTNActualizarLista.Text = "ACTUALIZAR";
            this.BTNActualizarLista.UseVisualStyleBackColor = false;
            // 
            // TBIdUsuario
            // 
            this.TBIdUsuario.Enabled = false;
            this.TBIdUsuario.Location = new System.Drawing.Point(768, 13);
            this.TBIdUsuario.Name = "TBIdUsuario";
            this.TBIdUsuario.Size = new System.Drawing.Size(20, 20);
            this.TBIdUsuario.TabIndex = 4;
            this.TBIdUsuario.Visible = false;
            // 
            // DGListaAmigos2
            // 
            this.DGListaAmigos2.AllowUserToAddRows = false;
            this.DGListaAmigos2.AllowUserToDeleteRows = false;
            this.DGListaAmigos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListaAmigos2.Location = new System.Drawing.Point(393, 117);
            this.DGListaAmigos2.Name = "DGListaAmigos2";
            this.DGListaAmigos2.ReadOnly = true;
            this.DGListaAmigos2.Size = new System.Drawing.Size(316, 244);
            this.DGListaAmigos2.TabIndex = 5;
            // 
            // MostrarListaAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGListaAmigos2);
            this.Controls.Add(this.TBIdUsuario);
            this.Controls.Add(this.BTNActualizarLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGListaAmigos);
            this.Name = "MostrarListaAmigos";
            this.Text = "MostrarListaAmigos";
            this.Load += new System.EventHandler(this.MostrarListaAmigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGListaAmigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaAmigos2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGListaAmigos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNActualizarLista;
        private System.Windows.Forms.TextBox TBIdUsuario;
        private System.Windows.Forms.DataGridView DGListaAmigos2;
    }
}