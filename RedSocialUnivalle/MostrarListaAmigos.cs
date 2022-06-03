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
    public partial class MostrarListaAmigos : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True");
        public MostrarListaAmigos()
        {
            InitializeComponent();
            lbIdMiUsuario1.Text = Form1.IdUsuario;
            
        }

        private void MostrarListaAmigos_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("SELECT DISTINCT a.IdAmigo, a.IdUsuario, a.IdUsuarioSolicitud, a.EstadoAmigo, u.UsuarioSistema FROM TAmigo as a, TUsuario as u WHERE (a.IdUsuario = '" + lbIdMiUsuario1.Text + "' and a.IdUsuarioSolicitud = a.IdUsuario) or (a.IdUsuario = a.IdUsuario and a.IdUsuarioSolicitud = '" + lbIdMiUsuario1.Text + "') and a.EstadoAmigo = 'True' and u.IdUsuario = a.IdUsuario", cn);
            //abrimos la coneccion
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                //if datos son leido agregamos al control
                while (dr.Read())
                {
                    //agregamos el origen de datos al control
                    this.lbListaAmigos.Items.Add(dr.GetString(4));
                }
            }
            //cerrams la coneccion
            cn.Close();
        }

        private void BTNActualizarLista_Click(object sender, EventArgs e)
        {

        }

        private void lbListaAmigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("SELECT * FROM TUsuario where UsuarioSistema='" + lbListaAmigos.Text + "'", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
               
                tbNombreUsuario.Text = dr["UsuarioSistema"].ToString();
                lbNombres.Text = dr["Nombres"].ToString();
                lbApellidoUsuario.Text = dr["Apellido_Paterno"].ToString();

                Byte[] mybyte = new byte[0];
                mybyte = (Byte[])(dr["ImagenPerfil"]);
                MemoryStream ms = new MemoryStream(mybyte);
                pbPerfilSelect.Image = Image.FromStream(ms);
            }
            cn.Close();
        }
    }
}
