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
    public partial class MisPublicaciones : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True");
        public MisPublicaciones()
        {
            InitializeComponent();
            tbIdMiUsuario.Text = Form1.IdUsuario;
            tbNombreInicio.Text = Form1.nombre_inicio;
        }

        private void MisPublicaciones_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("SELECT * FROM TPublicacion WHERE IdUsuario = '"+ tbIdMiUsuario.Text +"' and Estado = 'True'", cn);
            //abrimos la coneccion
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                //if datos son leido agregamos al control
                while (dr.Read())
                {
                    //agregamos el origen de datos al control
                    this.listMisPublicaciones.Items.Add(dr.GetString(2));
                }
            }
            //cerrams la coneccion
            cn.Close();

            
        }
        private void CargarComentarios() {
            SqlCommand cm1 = new SqlCommand("SELECT * FROM TComentario WHERE IdPublicacion = '" + tbIdPublicacion.Text + "' and Estado = 'True'", cn);
            
            SqlDataReader dr1 = cm1.ExecuteReader();
            if (dr1.HasRows)
            {
                //if datos son leido agregamos al control
                while (dr1.Read())
                {
                    //agregamos el origen de datos al control
                    this.lbComentarios.Items.Add(dr1.GetString(3));
                }
            }

            //cerrams la coneccion
            
        }
        

        private void listMisPublicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbComentarios.Items.Clear();
            SqlCommand cm = new SqlCommand("SELECT * FROM TPublicacion WHERE TituloContent='" + listMisPublicaciones.Text + "'", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                tbIdPublicacion.Text = dr["IdPublicacion"].ToString();
                tbDescripcion.Text = dr["TextContent"].ToString();
                lbTitulo.Text = dr["TituloContent"].ToString();
                lbFechaPublicacion.Text = dr["Fecha_Publicacion"].ToString();

                Byte[] mybyte = new byte[0];
                mybyte = (Byte[])(dr["ImagenU"]);
                MemoryStream ms = new MemoryStream(mybyte);
                pbImagenPublic.Image = Image.FromStream(ms);

                dr.Close();
                CargarComentarios();
            }
            
            cn.Close();
        }

        private void btnVerReacciones_Click(object sender, EventArgs e)
        {
            ReaccionesPubli ppp = new ReaccionesPubli();
            ppp.tbIdPublicacionReaccion.Text = tbIdPublicacion.Text;
            ppp.Show();
        }
    }
}
