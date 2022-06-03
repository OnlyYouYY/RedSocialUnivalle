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
    public partial class ListaChat : Form
    {
        public static string nombreAmigo;

        

        SqlConnection cn = new SqlConnection("Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True");
        public ListaChat()
        {
            InitializeComponent();
            lbIdMiUsuario.Text = Form1.IdUsuario;
        }

        private void ListaChat_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("SELECT DISTINCT a.IdAmigo, a.IdUsuario, a.IdUsuarioSolicitud, a.EstadoAmigo, u.UsuarioSistema FROM TAmigo as a, TUsuario as u WHERE (a.IdUsuario = '"+lbIdMiUsuario.Text+"' and a.IdUsuarioSolicitud = u.IdUsuario) or (a.IdUsuario = u.IdUsuario and a.IdUsuarioSolicitud = '"+lbIdMiUsuario.Text+"') and a.EstadoAmigo = 1", cn);
            //abrimos la coneccion
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                //if datos son leido agregamos al control
                while (dr.Read())
                {
                    //agregamos el origen de datos al control
                    this.listChatAmigos.Items.Add(dr.GetString(4));
                }
            }
            //cerrams la coneccion
            cn.Close();
        }

        private void listChatAmigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("SELECT * FROM TUsuario where UsuarioSistema='" + listChatAmigos.Text + "'", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                tbIdAmigo.Text = dr["IdUsuario"].ToString();
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

        private void btnChatear_Click(object sender, EventArgs e)
        {

            nombreAmigo = tbNombreUsuario.Text;

            Chat uuu = new Chat();
            uuu.tbIdAmigo2.Text = tbIdAmigo.Text;
            uuu.nombreUsuarioChat.Text = tbNombreUsuario.Text;
            uuu.tbIdUsuario2.Text = tbIdAmigo.Text;

            uuu.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
