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
            this.DGVerPublicaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.redSocialUnivalleDataSet1 = new RedSocialUnivalle.RedSocialUnivalleDataSet1();
            this.sPMostrarUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPMostrarUsuariosTableAdapter = new RedSocialUnivalle.RedSocialUnivalleDataSet1TableAdapters.SPMostrarUsuariosTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNVerPublicacion = new System.Windows.Forms.Button();
            this.TBIdPublicacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVerPublicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSocialUnivalleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVerPublicaciones
            // 
            this.DGVerPublicaciones.AllowUserToAddRows = false;
            this.DGVerPublicaciones.AllowUserToDeleteRows = false;
            this.DGVerPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVerPublicaciones.Location = new System.Drawing.Point(64, 102);
            this.DGVerPublicaciones.Name = "DGVerPublicaciones";
            this.DGVerPublicaciones.ReadOnly = true;
            this.DGVerPublicaciones.Size = new System.Drawing.Size(645, 374);
            this.DGVerPublicaciones.TabIndex = 0;
            this.DGVerPublicaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVerPublicaciones_CellClick);
            this.DGVerPublicaciones.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGVerPublicaciones_CellPainting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PUBLICACIONES";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Publicacion";
            // 
            // BTNVerPublicacion
            // 
            this.BTNVerPublicacion.Location = new System.Drawing.Point(745, 154);
            this.BTNVerPublicacion.Name = "BTNVerPublicacion";
            this.BTNVerPublicacion.Size = new System.Drawing.Size(191, 39);
            this.BTNVerPublicacion.TabIndex = 3;
            this.BTNVerPublicacion.Text = "Ver Publicacion";
            this.BTNVerPublicacion.UseVisualStyleBackColor = true;
            this.BTNVerPublicacion.Click += new System.EventHandler(this.BTNVerPublicacion_Click);
            // 
            // TBIdPublicacion
            // 
            this.TBIdPublicacion.Location = new System.Drawing.Point(745, 128);
            this.TBIdPublicacion.Name = "TBIdPublicacion";
            this.TBIdPublicacion.Size = new System.Drawing.Size(191, 20);
            this.TBIdPublicacion.TabIndex = 4;
            // 
            // MostrarPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 567);
            this.Controls.Add(this.TBIdPublicacion);
            this.Controls.Add(this.BTNVerPublicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVerPublicaciones);
            this.Name = "MostrarPublicaciones";
            this.Text = "MostrarPublicaciones";
            this.Load += new System.EventHandler(this.MostrarPublicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVerPublicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSocialUnivalleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMostrarUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVerPublicaciones;
        private System.Windows.Forms.Label label1;
        private RedSocialUnivalleDataSet1 redSocialUnivalleDataSet1;
        private System.Windows.Forms.BindingSource sPMostrarUsuariosBindingSource;
        private RedSocialUnivalleDataSet1TableAdapters.SPMostrarUsuariosTableAdapter sPMostrarUsuariosTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNVerPublicacion;
        private System.Windows.Forms.TextBox TBIdPublicacion;
    }
}