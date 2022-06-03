namespace RedSocialUnivalle
{
    partial class MisPublicaciones
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
            this.listMisPublicaciones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFechaPublicacion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIdMiUsuario = new System.Windows.Forms.TextBox();
            this.tbNombreInicio = new System.Windows.Forms.TextBox();
            this.tbIdPublicacion = new System.Windows.Forms.TextBox();
            this.lbComentarios = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.btnVerReacciones = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pbImagenPublic = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPublic)).BeginInit();
            this.SuspendLayout();
            // 
            // listMisPublicaciones
            // 
            this.listMisPublicaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.listMisPublicaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMisPublicaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listMisPublicaciones.FormattingEnabled = true;
            this.listMisPublicaciones.Location = new System.Drawing.Point(65, 80);
            this.listMisPublicaciones.Name = "listMisPublicaciones";
            this.listMisPublicaciones.Size = new System.Drawing.Size(484, 104);
            this.listMisPublicaciones.TabIndex = 0;
            this.listMisPublicaciones.SelectedIndexChanged += new System.EventHandler(this.listMisPublicaciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(271, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titulo:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(315, 237);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(35, 13);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(271, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Publicacion:";
            // 
            // lbFechaPublicacion
            // 
            this.lbFechaPublicacion.AutoSize = true;
            this.lbFechaPublicacion.ForeColor = System.Drawing.Color.White;
            this.lbFechaPublicacion.Location = new System.Drawing.Point(407, 331);
            this.lbFechaPublicacion.Name = "lbFechaPublicacion";
            this.lbFechaPublicacion.Size = new System.Drawing.Size(35, 13);
            this.lbFechaPublicacion.TabIndex = 5;
            this.lbFechaPublicacion.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(271, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Comentarios";
            // 
            // tbIdMiUsuario
            // 
            this.tbIdMiUsuario.Location = new System.Drawing.Point(498, 28);
            this.tbIdMiUsuario.Name = "tbIdMiUsuario";
            this.tbIdMiUsuario.Size = new System.Drawing.Size(20, 20);
            this.tbIdMiUsuario.TabIndex = 12;
            this.tbIdMiUsuario.Visible = false;
            // 
            // tbNombreInicio
            // 
            this.tbNombreInicio.Location = new System.Drawing.Point(529, 28);
            this.tbNombreInicio.Name = "tbNombreInicio";
            this.tbNombreInicio.Size = new System.Drawing.Size(20, 20);
            this.tbNombreInicio.TabIndex = 13;
            this.tbNombreInicio.Visible = false;
            // 
            // tbIdPublicacion
            // 
            this.tbIdPublicacion.Location = new System.Drawing.Point(294, 38);
            this.tbIdPublicacion.Name = "tbIdPublicacion";
            this.tbIdPublicacion.Size = new System.Drawing.Size(20, 20);
            this.tbIdPublicacion.TabIndex = 14;
            this.tbIdPublicacion.Visible = false;
            // 
            // lbComentarios
            // 
            this.lbComentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.lbComentarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbComentarios.ForeColor = System.Drawing.Color.White;
            this.lbComentarios.FormattingEnabled = true;
            this.lbComentarios.Location = new System.Drawing.Point(65, 446);
            this.lbComentarios.Name = "lbComentarios";
            this.lbComentarios.Size = new System.Drawing.Size(484, 130);
            this.lbComentarios.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descripcion:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescripcion.Enabled = false;
            this.tbDescripcion.ForeColor = System.Drawing.Color.White;
            this.tbDescripcion.Location = new System.Drawing.Point(356, 263);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(193, 52);
            this.tbDescripcion.TabIndex = 17;
            // 
            // btnVerReacciones
            // 
            this.btnVerReacciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(27)))));
            this.btnVerReacciones.FlatAppearance.BorderSize = 0;
            this.btnVerReacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerReacciones.ForeColor = System.Drawing.Color.White;
            this.btnVerReacciones.Location = new System.Drawing.Point(275, 367);
            this.btnVerReacciones.Name = "btnVerReacciones";
            this.btnVerReacciones.Size = new System.Drawing.Size(274, 35);
            this.btnVerReacciones.TabIndex = 18;
            this.btnVerReacciones.Text = "Ver Reacciones";
            this.btnVerReacciones.UseVisualStyleBackColor = false;
            this.btnVerReacciones.Click += new System.EventHandler(this.btnVerReacciones_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tus Publicaciones";
            // 
            // pbImagenPublic
            // 
            this.pbImagenPublic.Location = new System.Drawing.Point(65, 201);
            this.pbImagenPublic.Name = "pbImagenPublic";
            this.pbImagenPublic.Size = new System.Drawing.Size(200, 201);
            this.pbImagenPublic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenPublic.TabIndex = 1;
            this.pbImagenPublic.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(272, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Informacion de la Publicacion";
            // 
            // MisPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(627, 637);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerReacciones);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbComentarios);
            this.Controls.Add(this.tbIdPublicacion);
            this.Controls.Add(this.tbNombreInicio);
            this.Controls.Add(this.tbIdMiUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbFechaPublicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImagenPublic);
            this.Controls.Add(this.listMisPublicaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MisPublicaciones";
            this.Text = "MisPublicaciones";
            this.Load += new System.EventHandler(this.MisPublicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPublic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMisPublicaciones;
        private System.Windows.Forms.PictureBox pbImagenPublic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbFechaPublicacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIdMiUsuario;
        private System.Windows.Forms.TextBox tbNombreInicio;
        private System.Windows.Forms.TextBox tbIdPublicacion;
        private System.Windows.Forms.ListBox lbComentarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Button btnVerReacciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}