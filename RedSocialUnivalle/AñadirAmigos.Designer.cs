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
            this.redSocialUnivalleDataSet1 = new RedSocialUnivalle.RedSocialUnivalleDataSet1();
            this.sPMostrarUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPMostrarUsuariosTableAdapter = new RedSocialUnivalle.RedSocialUnivalleDataSet1TableAdapters.SPMostrarUsuariosTableAdapter();
            this.DGBusquedaUsuario = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TBBuscarUsuario = new System.Windows.Forms.TextBox();
            this.BTNBuscarUsuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CBTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBIdUsuarioAñadir = new System.Windows.Forms.TextBox();
            this.BTNAñadirAmigo = new System.Windows.Forms.Button();
            this.TBNombreUsuario = new System.Windows.Forms.TextBox();
            this.TBIdUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.redSocialUnivalleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGBusquedaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AÑADIR AMIGO";
            // 
            // redSocialUnivalleDataSet1
            // 
            this.redSocialUnivalleDataSet1.DataSetName = "RedSocialUnivalleDataSet1";
            this.redSocialUnivalleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPMostrarUsuariosBindingSource
            // 
            this.sPMostrarUsuariosBindingSource.DataMember = "SPMostrarUsuarios";
            this.sPMostrarUsuariosBindingSource.DataSource = this.redSocialUnivalleDataSet1;
            // 
            // sPMostrarUsuariosTableAdapter
            // 
            this.sPMostrarUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // DGBusquedaUsuario
            // 
            this.DGBusquedaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBusquedaUsuario.Location = new System.Drawing.Point(85, 164);
            this.DGBusquedaUsuario.Name = "DGBusquedaUsuario";
            this.DGBusquedaUsuario.Size = new System.Drawing.Size(614, 153);
            this.DGBusquedaUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar Usuario:";
            // 
            // TBBuscarUsuario
            // 
            this.TBBuscarUsuario.Location = new System.Drawing.Point(185, 127);
            this.TBBuscarUsuario.Name = "TBBuscarUsuario";
            this.TBBuscarUsuario.Size = new System.Drawing.Size(371, 20);
            this.TBBuscarUsuario.TabIndex = 3;
            // 
            // BTNBuscarUsuario
            // 
            this.BTNBuscarUsuario.Location = new System.Drawing.Point(570, 97);
            this.BTNBuscarUsuario.Name = "BTNBuscarUsuario";
            this.BTNBuscarUsuario.Size = new System.Drawing.Size(129, 50);
            this.BTNBuscarUsuario.TabIndex = 4;
            this.BTNBuscarUsuario.Text = "BUSCAR";
            this.BTNBuscarUsuario.UseVisualStyleBackColor = true;
            this.BTNBuscarUsuario.Click += new System.EventHandler(this.BTNBuscarUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Busqueda:";
            // 
            // CBTipoBusqueda
            // 
            this.CBTipoBusqueda.FormattingEnabled = true;
            this.CBTipoBusqueda.Items.AddRange(new object[] {
            "Nombre",
            "Usuario"});
            this.CBTipoBusqueda.Location = new System.Drawing.Point(185, 97);
            this.CBTipoBusqueda.Name = "CBTipoBusqueda";
            this.CBTipoBusqueda.Size = new System.Drawing.Size(371, 21);
            this.CBTipoBusqueda.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Añadir Amigo (ID Usuario)";
            // 
            // TBIdUsuarioAñadir
            // 
            this.TBIdUsuarioAñadir.Location = new System.Drawing.Point(216, 354);
            this.TBIdUsuarioAñadir.Name = "TBIdUsuarioAñadir";
            this.TBIdUsuarioAñadir.Size = new System.Drawing.Size(340, 20);
            this.TBIdUsuarioAñadir.TabIndex = 8;
            // 
            // BTNAñadirAmigo
            // 
            this.BTNAñadirAmigo.BackColor = System.Drawing.Color.LimeGreen;
            this.BTNAñadirAmigo.ForeColor = System.Drawing.Color.White;
            this.BTNAñadirAmigo.Location = new System.Drawing.Point(570, 338);
            this.BTNAñadirAmigo.Name = "BTNAñadirAmigo";
            this.BTNAñadirAmigo.Size = new System.Drawing.Size(129, 50);
            this.BTNAñadirAmigo.TabIndex = 9;
            this.BTNAñadirAmigo.Text = "+AÑADIR AMIGO";
            this.BTNAñadirAmigo.UseVisualStyleBackColor = false;
            this.BTNAñadirAmigo.Click += new System.EventHandler(this.BTNAñadirAmigo_Click);
            // 
            // TBNombreUsuario
            // 
            this.TBNombreUsuario.Enabled = false;
            this.TBNombreUsuario.Location = new System.Drawing.Point(753, 12);
            this.TBNombreUsuario.Name = "TBNombreUsuario";
            this.TBNombreUsuario.Size = new System.Drawing.Size(23, 20);
            this.TBNombreUsuario.TabIndex = 10;
            this.TBNombreUsuario.Visible = false;
            // 
            // TBIdUsuario
            // 
            this.TBIdUsuario.Enabled = false;
            this.TBIdUsuario.Location = new System.Drawing.Point(753, 38);
            this.TBIdUsuario.Name = "TBIdUsuario";
            this.TBIdUsuario.Size = new System.Drawing.Size(23, 20);
            this.TBIdUsuario.TabIndex = 11;
            this.TBIdUsuario.Visible = false;
            // 
            // AñadirAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 465);
            this.Controls.Add(this.TBIdUsuario);
            this.Controls.Add(this.TBNombreUsuario);
            this.Controls.Add(this.BTNAñadirAmigo);
            this.Controls.Add(this.TBIdUsuarioAñadir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBTipoBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNBuscarUsuario);
            this.Controls.Add(this.TBBuscarUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGBusquedaUsuario);
            this.Controls.Add(this.label1);
            this.Name = "AñadirAmigos";
            this.Text = "AñadirAmigos";
            this.Load += new System.EventHandler(this.AñadirAmigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.redSocialUnivalleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGBusquedaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RedSocialUnivalleDataSet1 redSocialUnivalleDataSet1;
        private System.Windows.Forms.BindingSource sPMostrarUsuariosBindingSource;
        private RedSocialUnivalleDataSet1TableAdapters.SPMostrarUsuariosTableAdapter sPMostrarUsuariosTableAdapter;
        private System.Windows.Forms.DataGridView DGBusquedaUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBBuscarUsuario;
        private System.Windows.Forms.Button BTNBuscarUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBTipoBusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBIdUsuarioAñadir;
        private System.Windows.Forms.Button BTNAñadirAmigo;
        private System.Windows.Forms.TextBox TBNombreUsuario;
        private System.Windows.Forms.TextBox TBIdUsuario;
    }
}