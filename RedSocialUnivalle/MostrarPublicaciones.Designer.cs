namespace RedSocialUnivalle
{
    partial class MostrarPublicaciones
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
            this.redSocialUnivalleDataSet = new RedSocialUnivalle.RedSocialUnivalleDataSet1();
            this.sPMostrarUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPMostrarUsuariosTableAdapter = new RedSocialUnivalle.RedSocialUnivalleDataSet1TableAdapters.SPMostrarUsuariosTableAdapter();
            this.panelPubliControllers = new System.Windows.Forms.Panel();
            this.btnCerrar = new RJCodeAdvance.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdPublicacion = new System.Windows.Forms.TextBox();
            this.iconVerPublic = new FontAwesome.Sharp.IconButton();
            this.iconEliminarPublic = new FontAwesome.Sharp.IconButton();
            this.iconModificarPublic = new FontAwesome.Sharp.IconButton();
            this.iconAñadirPublic = new FontAwesome.Sharp.IconButton();
            this.listPublicaciones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPublicRefresh = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.redSocialUnivalleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarUsuariosBindingSource)).BeginInit();
            this.panelPubliControllers.SuspendLayout();
            this.SuspendLayout();
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
            // panelPubliControllers
            // 
            this.panelPubliControllers.Controls.Add(this.btnCerrar);
            this.panelPubliControllers.Controls.Add(this.label2);
            this.panelPubliControllers.Controls.Add(this.tbIdPublicacion);
            this.panelPubliControllers.Controls.Add(this.iconVerPublic);
            this.panelPubliControllers.Controls.Add(this.iconEliminarPublic);
            this.panelPubliControllers.Controls.Add(this.iconModificarPublic);
            this.panelPubliControllers.Controls.Add(this.iconAñadirPublic);
            this.panelPubliControllers.Controls.Add(this.listPublicaciones);
            this.panelPubliControllers.Controls.Add(this.label1);
            this.panelPubliControllers.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPubliControllers.Location = new System.Drawing.Point(0, 0);
            this.panelPubliControllers.Name = "panelPubliControllers";
            this.panelPubliControllers.Size = new System.Drawing.Size(343, 637);
            this.panelPubliControllers.TabIndex = 10;
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
            this.btnCerrar.Location = new System.Drawing.Point(49, 562);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 40);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextColor = System.Drawing.Color.White;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lista de Publicaciones:";
            // 
            // tbIdPublicacion
            // 
            this.tbIdPublicacion.Location = new System.Drawing.Point(277, 573);
            this.tbIdPublicacion.Name = "tbIdPublicacion";
            this.tbIdPublicacion.Size = new System.Drawing.Size(18, 20);
            this.tbIdPublicacion.TabIndex = 16;
            this.tbIdPublicacion.Visible = false;
            // 
            // iconVerPublic
            // 
            this.iconVerPublic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(27)))));
            this.iconVerPublic.FlatAppearance.BorderSize = 0;
            this.iconVerPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconVerPublic.ForeColor = System.Drawing.Color.White;
            this.iconVerPublic.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.iconVerPublic.IconColor = System.Drawing.Color.White;
            this.iconVerPublic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVerPublic.Location = new System.Drawing.Point(175, 161);
            this.iconVerPublic.Name = "iconVerPublic";
            this.iconVerPublic.Size = new System.Drawing.Size(120, 65);
            this.iconVerPublic.TabIndex = 15;
            this.iconVerPublic.Text = "Ver Publicacion";
            this.iconVerPublic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconVerPublic.UseVisualStyleBackColor = false;
            this.iconVerPublic.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconEliminarPublic
            // 
            this.iconEliminarPublic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(27)))));
            this.iconEliminarPublic.FlatAppearance.BorderSize = 0;
            this.iconEliminarPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEliminarPublic.ForeColor = System.Drawing.Color.White;
            this.iconEliminarPublic.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.iconEliminarPublic.IconColor = System.Drawing.Color.White;
            this.iconEliminarPublic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEliminarPublic.Location = new System.Drawing.Point(49, 161);
            this.iconEliminarPublic.Name = "iconEliminarPublic";
            this.iconEliminarPublic.Size = new System.Drawing.Size(120, 65);
            this.iconEliminarPublic.TabIndex = 14;
            this.iconEliminarPublic.Text = "Eliminar Publicacion";
            this.iconEliminarPublic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconEliminarPublic.UseVisualStyleBackColor = false;
            this.iconEliminarPublic.Click += new System.EventHandler(this.iconEliminarPublic_Click);
            // 
            // iconModificarPublic
            // 
            this.iconModificarPublic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(27)))));
            this.iconModificarPublic.FlatAppearance.BorderSize = 0;
            this.iconModificarPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconModificarPublic.ForeColor = System.Drawing.Color.White;
            this.iconModificarPublic.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.iconModificarPublic.IconColor = System.Drawing.Color.White;
            this.iconModificarPublic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconModificarPublic.Location = new System.Drawing.Point(175, 90);
            this.iconModificarPublic.Name = "iconModificarPublic";
            this.iconModificarPublic.Size = new System.Drawing.Size(120, 65);
            this.iconModificarPublic.TabIndex = 13;
            this.iconModificarPublic.Text = "Mis Publicaciones";
            this.iconModificarPublic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconModificarPublic.UseVisualStyleBackColor = false;
            this.iconModificarPublic.Click += new System.EventHandler(this.iconModificarPublic_Click);
            // 
            // iconAñadirPublic
            // 
            this.iconAñadirPublic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(145)))), ((int)(((byte)(27)))));
            this.iconAñadirPublic.FlatAppearance.BorderSize = 0;
            this.iconAñadirPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAñadirPublic.ForeColor = System.Drawing.Color.White;
            this.iconAñadirPublic.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.iconAñadirPublic.IconColor = System.Drawing.Color.White;
            this.iconAñadirPublic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAñadirPublic.Location = new System.Drawing.Point(49, 90);
            this.iconAñadirPublic.Name = "iconAñadirPublic";
            this.iconAñadirPublic.Size = new System.Drawing.Size(120, 65);
            this.iconAñadirPublic.TabIndex = 12;
            this.iconAñadirPublic.Text = "Añadir Publicacion";
            this.iconAñadirPublic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconAñadirPublic.UseVisualStyleBackColor = false;
            this.iconAñadirPublic.Click += new System.EventHandler(this.iconPublicaciones_Click);
            // 
            // listPublicaciones
            // 
            this.listPublicaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.listPublicaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPublicaciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.listPublicaciones.ForeColor = System.Drawing.Color.White;
            this.listPublicaciones.FormattingEnabled = true;
            this.listPublicaciones.Location = new System.Drawing.Point(49, 268);
            this.listPublicaciones.Name = "listPublicaciones";
            this.listPublicaciones.Size = new System.Drawing.Size(246, 288);
            this.listPublicaciones.TabIndex = 11;
            this.listPublicaciones.SelectedIndexChanged += new System.EventHandler(this.listPublicaciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "PUBLICACIONES";
            // 
            // panelPublicRefresh
            // 
            this.panelPublicRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPublicRefresh.Location = new System.Drawing.Point(343, 0);
            this.panelPublicRefresh.Name = "panelPublicRefresh";
            this.panelPublicRefresh.Size = new System.Drawing.Size(627, 637);
            this.panelPublicRefresh.TabIndex = 11;
            // 
            // MostrarPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(970, 637);
            this.Controls.Add(this.panelPublicRefresh);
            this.Controls.Add(this.panelPubliControllers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarPublicaciones";
            this.Text = "MostrarPublicaciones";
            this.Load += new System.EventHandler(this.MostrarPublicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.redSocialUnivalleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarUsuariosBindingSource)).EndInit();
            this.panelPubliControllers.ResumeLayout(false);
            this.panelPubliControllers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RedSocialUnivalleDataSet1 redSocialUnivalleDataSet;
        private System.Windows.Forms.BindingSource sPMostrarUsuariosBindingSource;
        private RedSocialUnivalleDataSet1TableAdapters.SPMostrarUsuariosTableAdapter sPMostrarUsuariosTableAdapter;
        private System.Windows.Forms.Panel panelPubliControllers;
        private FontAwesome.Sharp.IconButton iconVerPublic;
        private FontAwesome.Sharp.IconButton iconEliminarPublic;
        private FontAwesome.Sharp.IconButton iconModificarPublic;
        private FontAwesome.Sharp.IconButton iconAñadirPublic;
        private System.Windows.Forms.ListBox listPublicaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPublicRefresh;
        private System.Windows.Forms.TextBox tbIdPublicacion;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJButton btnCerrar;
    }
}