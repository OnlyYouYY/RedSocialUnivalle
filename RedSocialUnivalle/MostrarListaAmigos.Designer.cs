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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNActualizarLista = new System.Windows.Forms.Button();
            this.lbIdMiUsuario1 = new System.Windows.Forms.TextBox();
            this.lbListaAmigos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNombres = new System.Windows.Forms.Label();
            this.lbApellidoUsuario = new System.Windows.Forms.Label();
            this.tbNombreUsuario = new System.Windows.Forms.Label();
            this.pbPerfilSelect = new RedSocialUnivalle.ClasePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfilSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "AMIGOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista de amigos";
            // 
            // BTNActualizarLista
            // 
            this.BTNActualizarLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(27)))));
            this.BTNActualizarLista.ForeColor = System.Drawing.Color.White;
            this.BTNActualizarLista.Location = new System.Drawing.Point(68, 438);
            this.BTNActualizarLista.Name = "BTNActualizarLista";
            this.BTNActualizarLista.Size = new System.Drawing.Size(300, 50);
            this.BTNActualizarLista.TabIndex = 3;
            this.BTNActualizarLista.Text = "ACTUALIZAR";
            this.BTNActualizarLista.UseVisualStyleBackColor = false;
            this.BTNActualizarLista.Click += new System.EventHandler(this.BTNActualizarLista_Click);
            // 
            // lbIdMiUsuario1
            // 
            this.lbIdMiUsuario1.Enabled = false;
            this.lbIdMiUsuario1.Location = new System.Drawing.Point(640, 12);
            this.lbIdMiUsuario1.Name = "lbIdMiUsuario1";
            this.lbIdMiUsuario1.Size = new System.Drawing.Size(20, 20);
            this.lbIdMiUsuario1.TabIndex = 4;
            this.lbIdMiUsuario1.Visible = false;
            // 
            // lbListaAmigos
            // 
            this.lbListaAmigos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.lbListaAmigos.ForeColor = System.Drawing.Color.White;
            this.lbListaAmigos.FormattingEnabled = true;
            this.lbListaAmigos.Location = new System.Drawing.Point(68, 138);
            this.lbListaAmigos.Name = "lbListaAmigos";
            this.lbListaAmigos.Size = new System.Drawing.Size(300, 290);
            this.lbListaAmigos.TabIndex = 5;
            this.lbListaAmigos.SelectedIndexChanged += new System.EventHandler(this.lbListaAmigos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(492, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Foto de Perfil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(460, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(460, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(460, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Usuario:";
            // 
            // lbNombres
            // 
            this.lbNombres.AutoSize = true;
            this.lbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres.ForeColor = System.Drawing.Color.White;
            this.lbNombres.Location = new System.Drawing.Point(545, 425);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(51, 20);
            this.lbNombres.TabIndex = 17;
            this.lbNombres.Text = "label2";
            // 
            // lbApellidoUsuario
            // 
            this.lbApellidoUsuario.AutoSize = true;
            this.lbApellidoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidoUsuario.ForeColor = System.Drawing.Color.White;
            this.lbApellidoUsuario.Location = new System.Drawing.Point(545, 468);
            this.lbApellidoUsuario.Name = "lbApellidoUsuario";
            this.lbApellidoUsuario.Size = new System.Drawing.Size(51, 20);
            this.lbApellidoUsuario.TabIndex = 16;
            this.lbApellidoUsuario.Text = "label2";
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.AutoSize = true;
            this.tbNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.tbNombreUsuario.Location = new System.Drawing.Point(545, 382);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(51, 20);
            this.tbNombreUsuario.TabIndex = 15;
            this.tbNombreUsuario.Text = "label1";
            // 
            // pbPerfilSelect
            // 
            this.pbPerfilSelect.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbPerfilSelect.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbPerfilSelect.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbPerfilSelect.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbPerfilSelect.BorderSize = 2;
            this.pbPerfilSelect.GradientAngle = 50F;
            this.pbPerfilSelect.Location = new System.Drawing.Point(439, 124);
            this.pbPerfilSelect.Name = "pbPerfilSelect";
            this.pbPerfilSelect.Size = new System.Drawing.Size(221, 221);
            this.pbPerfilSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfilSelect.TabIndex = 14;
            this.pbPerfilSelect.TabStop = false;
            // 
            // MostrarListaAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(738, 598);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbNombres);
            this.Controls.Add(this.lbApellidoUsuario);
            this.Controls.Add(this.tbNombreUsuario);
            this.Controls.Add(this.pbPerfilSelect);
            this.Controls.Add(this.lbListaAmigos);
            this.Controls.Add(this.lbIdMiUsuario1);
            this.Controls.Add(this.BTNActualizarLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarListaAmigos";
            this.Text = "MostrarListaAmigos";
            this.Load += new System.EventHandler(this.MostrarListaAmigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfilSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNActualizarLista;
        private System.Windows.Forms.TextBox lbIdMiUsuario1;
        private System.Windows.Forms.ListBox lbListaAmigos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNombres;
        private System.Windows.Forms.Label lbApellidoUsuario;
        private System.Windows.Forms.Label tbNombreUsuario;
        private ClasePictureBox pbPerfilSelect;
    }
}