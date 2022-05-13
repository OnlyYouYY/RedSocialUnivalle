namespace RedSocialUnivalle
{
    partial class EliminarUsuario
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
            this.TBBuscarUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellidoPaterno = new System.Windows.Forms.TextBox();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNBuscarUsuario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBApellidoMaterno = new System.Windows.Forms.TextBox();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELIMINAR USUARIO";
            // 
            // TBBuscarUsuario
            // 
            this.TBBuscarUsuario.Enabled = false;
            this.TBBuscarUsuario.Location = new System.Drawing.Point(754, 12);
            this.TBBuscarUsuario.Name = "TBBuscarUsuario";
            this.TBBuscarUsuario.Size = new System.Drawing.Size(43, 20);
            this.TBBuscarUsuario.TabIndex = 2;
            this.TBBuscarUsuario.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido Paterno";
            // 
            // TBNombre
            // 
            this.TBNombre.Enabled = false;
            this.TBNombre.Location = new System.Drawing.Point(204, 125);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(255, 20);
            this.TBNombre.TabIndex = 6;
            // 
            // TBApellidoPaterno
            // 
            this.TBApellidoPaterno.Enabled = false;
            this.TBApellidoPaterno.Location = new System.Drawing.Point(204, 185);
            this.TBApellidoPaterno.Name = "TBApellidoPaterno";
            this.TBApellidoPaterno.Size = new System.Drawing.Size(255, 20);
            this.TBApellidoPaterno.TabIndex = 7;
            this.TBApellidoPaterno.TextChanged += new System.EventHandler(this.TBApellidoPaterno_TextChanged);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.BackColor = System.Drawing.Color.LimeGreen;
            this.BTNEliminar.ForeColor = System.Drawing.Color.White;
            this.BTNEliminar.Location = new System.Drawing.Point(488, 176);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(200, 46);
            this.BTNEliminar.TabIndex = 9;
            this.BTNEliminar.Text = "ELIMINAR";
            this.BTNEliminar.UseVisualStyleBackColor = false;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // BTNBuscarUsuario
            // 
            this.BTNBuscarUsuario.BackColor = System.Drawing.Color.Red;
            this.BTNBuscarUsuario.ForeColor = System.Drawing.Color.White;
            this.BTNBuscarUsuario.Location = new System.Drawing.Point(488, 125);
            this.BTNBuscarUsuario.Name = "BTNBuscarUsuario";
            this.BTNBuscarUsuario.Size = new System.Drawing.Size(200, 45);
            this.BTNBuscarUsuario.TabIndex = 10;
            this.BTNBuscarUsuario.Text = "CARGAR DATOS";
            this.BTNBuscarUsuario.UseVisualStyleBackColor = false;
            this.BTNBuscarUsuario.Click += new System.EventHandler(this.BTNBuscarUsuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Correo Electronico";
            // 
            // TBApellidoMaterno
            // 
            this.TBApellidoMaterno.Enabled = false;
            this.TBApellidoMaterno.Location = new System.Drawing.Point(204, 245);
            this.TBApellidoMaterno.Name = "TBApellidoMaterno";
            this.TBApellidoMaterno.Size = new System.Drawing.Size(255, 20);
            this.TBApellidoMaterno.TabIndex = 13;
            // 
            // TBCorreo
            // 
            this.TBCorreo.Enabled = false;
            this.TBCorreo.Location = new System.Drawing.Point(204, 305);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(255, 20);
            this.TBCorreo.TabIndex = 14;
            // 
            // EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.TBCorreo);
            this.Controls.Add(this.TBApellidoMaterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNBuscarUsuario);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.TBApellidoPaterno);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBBuscarUsuario);
            this.Controls.Add(this.label1);
            this.Name = "EliminarUsuario";
            this.Text = "EliminarUsuario";
            this.Load += new System.EventHandler(this.EliminarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBBuscarUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellidoPaterno;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNBuscarUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBApellidoMaterno;
        private System.Windows.Forms.TextBox TBCorreo;
    }
}