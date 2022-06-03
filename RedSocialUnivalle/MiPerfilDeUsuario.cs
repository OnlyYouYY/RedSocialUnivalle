using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace RedSocialUnivalle
{
    public partial class MiPerfilDeUsuario : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True");
        public MiPerfilDeUsuario()
        {
            InitializeComponent();
            tbIdUsuarioSistema.Text = Form1.IdUsuario;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            ModificarUsuario ppp = new ModificarUsuario();
            ppp.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MiPerfilDeUsuario_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("SELECT * FROM TUsuario where IdUsuario='" + tbIdUsuarioSistema.Text + "'", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {

                lbUsuarioSistema.Text = dr["UsuarioSistema"].ToString();
                lbNombreUsuario.Text = dr["Nombres"].ToString();
                lbApellidoPaterno.Text = dr["Apellido_Paterno"].ToString();
                lbApellidoMaterno.Text = dr["Apellido_Materno"].ToString();
                lbCorreo.Text = dr["CorreoElectronico"].ToString();
                lbNacionalidad.Text = dr["Nacionalidad"].ToString();
                lbContacto.Text = dr["NroContacto"].ToString();
                lbSexo.Text = dr["Sexo"].ToString();
                lbFechaNacimiento.Text = dr["Fecha_Nacimiento"].ToString();
                lbEstado.Text = dr["Estado"].ToString();
                if (lbEstado.Text == "True")
                {
                    lbEstado.Text = "ACTIVA";
                }

                Byte[] mybyte = new byte[0];
                mybyte = (Byte[])(dr["ImagenPerfil"]);
                MemoryStream ms = new MemoryStream(mybyte);
                pbFotoPerfil.Image = Image.FromStream(ms);

                Byte[] mybyte1 = new byte[0];
                mybyte1 = (Byte[])(dr["ImagenPortada"]);
                MemoryStream ms1 = new MemoryStream(mybyte1);
                pbPortada.Image = Image.FromStream(ms1);


            }
            cn.Close();
        }
    }
}
