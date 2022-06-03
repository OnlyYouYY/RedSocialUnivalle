namespace RedSocialUnivalle
{
    partial class AñadirAmigos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.redSocialUnivalleDataSet = new RedSocialUnivalle.RedSocialUnivalleDataSet1();
            this.sPMostrarUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPMostrarUsuariosTableAdapter = new RedSocialUnivalle.RedSocialUnivalleDataSet1TableAdapters.SPMostrarUsuariosTableAdapter();
            this.BTNAñadirAmigo = new System.Windows.Forms.Button();
            this.TBNombreUsuario = new System.Windows.Forms.TextBox();
            this.TBIdUsuario = new System.Windows.Forms.TextBox();
            this.TBIdUsuarioAñadir = new System.Windows.Forms.Label();
            this.listBuscarAmigo = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNombres = new System.Windows.Forms.Label();
            this.lbApellidoUsuario = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.pbPerfilSelect = new RedSocialUnivalle.ClasePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.redSocialUnivalleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfilSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AÑADIR AMIGO";
            // 
            // redSocialUnivalleDataSet
            // 
            this.redSocialUnivalleDataSet.DataSetName = "RedSocialUnivalleDataSet1";
            this.redSocialUnivalleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPMostrarUsuariosBindingSource
            // 
            this.sPMostrarUsuariosBindingSource.DataMember = "SPMostrarUsuarios";
            this.sPMostrarUsuariosBindingSource.DataSource = this.redSocialUnivalleDataSet;
            // 
            // sPMostrarUsuariosTableAdapter
            // 
            this.sPMostrarUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // BTNAñadirAmigo
            // 
            this.BTNAñadirAmigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(27)))));
            this.BTNAñadirAmigo.ForeColor = System.Drawing.Color.White;
            this.BTNAñadirAmigo.Location = new System.Drawing.Point(85, 461);
            this.BTNAñadirAmigo.Name = "BTNAñadirAmigo";
            this.BTNAñadirAmigo.Size = new System.Drawing.Size(281, 50);
            this.BTNAñadirAmigo.TabIndex = 9;
            this.BTNAñadirAmigo.Text = "+AÑADIR AMIGO";
            this.BTNAñadirAmigo.UseVisualStyleBackColor = false;
            this.BTNAñadirAmigo.Click += new System.EventHandler(this.BTNAñadirAmigo_Click);
            // 
            // TBNombreUsuario
            // 
            this.TBNombreUsuario.Enabled = false;
            this.TBNombreUsuario.Location = new System.Drawing.Point(572, 12);
            this.TBNombreUsuario.Name = "TBNombreUsuario";
            this.TBNombreUsuario.Size = new System.Drawing.Size(23, 20);
            this.TBNombreUsuario.TabIndex = 10;
            this.TBNombreUsuario.Visible = false;
            // 
            // TBIdUsuario
            // 
            this.TBIdUsuario.Enabled = false;
            this.TBIdUsuario.Location = new System.Drawing.Point(572, 38);
            this.TBIdUsuario.Name = "TBIdUsuario";
            this.TBIdUsuario.Size = new System.Drawing.Size(23, 20);
            this.TBIdUsuario.TabIndex = 11;
            this.TBIdUsuario.Visible = false;
            // 
            // TBIdUsuarioAñadir
            // 
            this.TBIdUsuarioAñadir.AutoSize = true;
            this.TBIdUsuarioAñadir.ForeColor = System.Drawing.Color.White;
            this.TBIdUsuarioAñadir.Location = new System.Drawing.Point(560, 61);
            this.TBIdUsuarioAñadir.Name = "TBIdUsuarioAñadir";
            this.TBIdUsuarioAñadir.Size = new System.Drawing.Size(35, 13);
            this.TBIdUsuarioAñadir.TabIndex = 12;
            this.TBIdUsuarioAñadir.Text = "label4";
            // 
            // listBuscarAmigo
            // 
            this.listBuscarAmigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.listBuscarAmigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBuscarAmigo.ForeColor = System.Drawing.Color.White;
            this.listBuscarAmigo.FormattingEnabled = true;
            this.listBuscarAmigo.Location = new System.Drawing.Point(85, 87);
            this.listBuscarAmigo.Name = "listBuscarAmigo";
            this.listBuscarAmigo.Size = new System.Drawing.Size(281, 366);
            this.listBuscarAmigo.TabIndex = 13;
            this.listBuscarAmigo.SelectedIndexChanged += new System.EventHandler(this.listBuscarAmigo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(488, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Foto de Perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(457, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(457, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Apellidos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(457, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Usuario:";
            // 
            // lbNombres
            // 
            this.lbNombres.AutoSize = true;
            this.lbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres.ForeColor = System.Drawing.Color.White;
            this.lbNombres.Location = new System.Drawing.Point(542, 446);
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
            this.lbApellidoUsuario.Location = new System.Drawing.Point(542, 489);
            this.lbApellidoUsuario.Name = "lbApellidoUsuario";
            this.lbApellidoUsuario.Size = new System.Drawing.Size(51, 20);
            this.lbApellidoUsuario.TabIndex = 16;
            this.lbApellidoUsuario.Text = "label2";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lbNombreUsuario.Location = new System.Drawing.Point(542, 403);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(51, 20);
            this.lbNombreUsuario.TabIndex = 15;
            this.lbNombreUsuario.Text = "label1";
            // 
            // pbPerfilSelect
            // 
            this.pbPerfilSelect.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbPerfilSelect.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbPerfilSelect.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbPerfilSelect.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbPerfilSelect.BorderSize = 2;
            this.pbPerfilSelect.GradientAngle = 50F;
            this.pbPerfilSelect.Location = new System.Drawing.Point(436, 145);
            this.pbPerfilSelect.Name = "pbPerfilSelect";
            this.pbPerfilSelect.Size = new System.Drawing.Size(221, 221);
            this.pbPerfilSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfilSelect.TabIndex = 14;
            this.pbPerfilSelect.TabStop = false;
            // 
            // AñadirAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(722, 559);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbNombres);
            this.Controls.Add(this.lbApellidoUsuario);
            this.Controls.Add(this.lbNombreUsuario);
            this.Controls.Add(this.pbPerfilSelect);
            this.Controls.Add(this.listBuscarAmigo);
            this.Controls.Add(this.TBIdUsuarioAñadir);
            this.Controls.Add(this.TBIdUsuario);
            this.Controls.Add(this.TBNombreUsuario);
            this.Controls.Add(this.BTNAñadirAmigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AñadirAmigos";
            this.Text = "AñadirAmigos";
            this.Load += new System.EventHandler(this.AñadirAmigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.redSocialUnivalleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfilSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RedSocialUnivalleDataSet1 redSocialUnivalleDataSet;
        private System.Windows.Forms.BindingSource sPMostrarUsuariosBindingSource;
        private RedSocialUnivalleDataSet1TableAdapters.SPMostrarUsuariosTableAdapter sPMostrarUsuariosTableAdapter;
        private System.Windows.Forms.Button BTNAñadirAmigo;
        private System.Windows.Forms.TextBox TBNombreUsuario;
        private System.Windows.Forms.TextBox TBIdUsuario;
        private System.Windows.Forms.Label TBIdUsuarioAñadir;
        private System.Windows.Forms.ListBox listBuscarAmigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNombres;
        private System.Windows.Forms.Label lbApellidoUsuario;
        private System.Windows.Forms.Label lbNombreUsuario;
        private ClasePictureBox pbPerfilSelect;
    }
}