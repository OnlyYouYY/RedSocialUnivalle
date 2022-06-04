namespace RedSocialUnivalle
{
    partial class ListaChat
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
            this.listChatAmigos = new System.Windows.Forms.ListBox();
            this.btnChatear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new RJCodeAdvance.RJControls.RJButton();
            this.tbNombreUsuario = new System.Windows.Forms.Label();
            this.tbIdAmigo = new System.Windows.Forms.Label();
            this.lbApellidoUsuario = new System.Windows.Forms.Label();
            this.lbNombres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPerfilSelect = new RedSocialUnivalle.ClasePictureBox();
            this.lbIdMiUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfilSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // listChatAmigos
            // 
            this.listChatAmigos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.listChatAmigos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listChatAmigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listChatAmigos.ForeColor = System.Drawing.Color.White;
            this.listChatAmigos.FormattingEnabled = true;
            this.listChatAmigos.ItemHeight = 25;
            this.listChatAmigos.Location = new System.Drawing.Point(51, 96);
            this.listChatAmigos.Name = "listChatAmigos";
            this.listChatAmigos.Size = new System.Drawing.Size(464, 402);
            this.listChatAmigos.TabIndex = 0;
            this.listChatAmigos.SelectedIndexChanged += new System.EventHandler(this.listChatAmigos_SelectedIndexChanged);
            // 
            // btnChatear
            // 
            this.btnChatear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(27)))));
            this.btnChatear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChatear.ForeColor = System.Drawing.Color.White;
            this.btnChatear.Location = new System.Drawing.Point(51, 504);
            this.btnChatear.Name = "btnChatear";
            this.btnChatear.Size = new System.Drawing.Size(464, 55);
            this.btnChatear.TabIndex = 2;
            this.btnChatear.Text = "ABRIR CHAT";
            this.btnChatear.UseVisualStyleBackColor = false;
            this.btnChatear.Click += new System.EventHandler(this.btnChatear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.listChatAmigos);
            this.panel1.Controls.Add(this.btnChatear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 598);
            this.panel1.TabIndex = 5;
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
            this.btnCerrar.Location = new System.Drawing.Point(51, 34);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 40);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextColor = System.Drawing.Color.White;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.AutoSize = true;
            this.tbNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.tbNombreUsuario.Location = new System.Drawing.Point(772, 354);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(51, 20);
            this.tbNombreUsuario.TabIndex = 6;
            this.tbNombreUsuario.Text = "label1";
            // 
            // tbIdAmigo
            // 
            this.tbIdAmigo.AutoSize = true;
            this.tbIdAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdAmigo.ForeColor = System.Drawing.Color.White;
            this.tbIdAmigo.Location = new System.Drawing.Point(900, 569);
            this.tbIdAmigo.Name = "tbIdAmigo";
            this.tbIdAmigo.Size = new System.Drawing.Size(51, 20);
            this.tbIdAmigo.TabIndex = 7;
            this.tbIdAmigo.Text = "label2";
            this.tbIdAmigo.Visible = false;
            // 
            // lbApellidoUsuario
            // 
            this.lbApellidoUsuario.AutoSize = true;
            this.lbApellidoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidoUsuario.ForeColor = System.Drawing.Color.White;
            this.lbApellidoUsuario.Location = new System.Drawing.Point(772, 440);
            this.lbApellidoUsuario.Name = "lbApellidoUsuario";
            this.lbApellidoUsuario.Size = new System.Drawing.Size(51, 20);
            this.lbApellidoUsuario.TabIndex = 8;
            this.lbApellidoUsuario.Text = "label2";
            // 
            // lbNombres
            // 
            this.lbNombres.AutoSize = true;
            this.lbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres.ForeColor = System.Drawing.Color.White;
            this.lbNombres.Location = new System.Drawing.Point(772, 397);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(51, 20);
            this.lbNombres.TabIndex = 9;
            this.lbNombres.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(687, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(687, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(687, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(719, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Foto de Perfil";
            // 
            // pbPerfilSelect
            // 
            this.pbPerfilSelect.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbPerfilSelect.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbPerfilSelect.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbPerfilSelect.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbPerfilSelect.BorderSize = 2;
            this.pbPerfilSelect.GradientAngle = 50F;
            this.pbPerfilSelect.Location = new System.Drawing.Point(666, 96);
            this.pbPerfilSelect.Name = "pbPerfilSelect";
            this.pbPerfilSelect.Size = new System.Drawing.Size(221, 221);
            this.pbPerfilSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfilSelect.TabIndex = 4;
            this.pbPerfilSelect.TabStop = false;
            // 
            // lbIdMiUsuario
            // 
            this.lbIdMiUsuario.AutoSize = true;
            this.lbIdMiUsuario.Location = new System.Drawing.Point(823, 574);
            this.lbIdMiUsuario.Name = "lbIdMiUsuario";
            this.lbIdMiUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbIdMiUsuario.TabIndex = 14;
            this.lbIdMiUsuario.Text = "label5";
            this.lbIdMiUsuario.Visible = false;
            // 
            // ListaChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(954, 598);
            this.Controls.Add(this.lbIdMiUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNombres);
            this.Controls.Add(this.lbApellidoUsuario);
            this.Controls.Add(this.tbIdAmigo);
            this.Controls.Add(this.tbNombreUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbPerfilSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaChat";
            this.Text = "ListaChat";
            this.Load += new System.EventHandler(this.ListaChat_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfilSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listChatAmigos;
        private System.Windows.Forms.Button btnChatear;
        private ClasePictureBox pbPerfilSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tbNombreUsuario;
        private System.Windows.Forms.Label tbIdAmigo;
        private System.Windows.Forms.Label lbApellidoUsuario;
        private System.Windows.Forms.Label lbNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbIdMiUsuario;
        private RJCodeAdvance.RJControls.RJButton btnCerrar;
    }
}