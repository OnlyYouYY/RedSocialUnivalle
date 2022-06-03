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
    public partial class Chat : Form
    {

        public int IdUsuario1;
        public int IdUsuario2;

        SqlConnection cn = new SqlConnection("Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True");
        public Chat()
        {
            InitializeComponent();
            tbIdUsuario1.Text = Form1.IdUsuario;

        }

        
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPInsertarMensaje", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdUsuarioEmisor", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdUsuarioReceptor", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@Mensaje", SqlDbType.VarChar, 100);

            da.SelectCommand.Parameters["@IdUsuarioEmisor"].Value = tbIdUsuario1.Text;
            da.SelectCommand.Parameters["@IdUsuarioReceptor"].Value = tbIdUsuario2.Text;
            da.SelectCommand.Parameters["@Mensaje"].Value = tbEnviarMsg.Texts;

            da.Fill(bt);



            lbChat.Items.Clear();
            tbEnviarMsg.Texts = "";

            SqlCommand cm1 = new SqlCommand("select DISTINCT m.mensaje, m.IdUsuarioEmisor,m.IdUsuarioReceptor,m.FechaMensaje from TMensaje as m, TUsuario as u where(IdUsuarioEmisor =" + tbIdUsuario1.Text + " and IdUsuarioReceptor = " + tbIdUsuario2.Text + ") or(IdUsuarioEmisor = " + tbIdUsuario2.Text + " and IdUsuarioReceptor = " + tbIdUsuario1.Text + ") ORDER BY m.FechaMensaje asc", cn);


            cn.Open();
            SqlDataReader dr1 = cm1.ExecuteReader();
            if (dr1.HasRows)
            {

                while (dr1.Read())
                {

                    this.lbChat.Items.Add(dr1.GetString(0));
                }
            }

            cn.Close();

        }

      

        private void timerMensajes_Tick_1(object sender, EventArgs e)
        {
            lbChat.Items.Clear();
            SqlCommand cm1 = new SqlCommand("select DISTINCT m.mensaje, m.IdUsuarioEmisor,m.IdUsuarioReceptor,m.FechaMensaje from TMensaje as m, TUsuario as u where(IdUsuarioEmisor =" + tbIdUsuario1.Text + " and IdUsuarioReceptor = " + tbIdUsuario2.Text + ") or(IdUsuarioEmisor = " + tbIdUsuario2.Text + " and IdUsuarioReceptor = " + tbIdUsuario1.Text + ") ORDER BY m.FechaMensaje asc", cn);
            //abrimos la coneccion
            cn.Open();
            SqlDataReader dr1 = cm1.ExecuteReader();
            if (dr1.HasRows)
            {
                //if datos son leido agregamos al control
                while (dr1.Read())
                {
                    //agregamos el origen de datos al control
                    this.lbChat.Items.Add(dr1.GetString(0));
                }
            }
            //cerrams la coneccion
            cn.Close();
        }

        private void pbImagenAmigo_Click(object sender, EventArgs e)
        {

        }

        private void Chat_Load_1(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("SELECT IdUsuario, ImagenPerfil FROM TUsuario WHERE IdUsuario = '" + tbIdAmigo2.Text + "'", cn);
            //abrimos la coneccion
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                //if datos son leido agregamos al control
                while (dr.Read())
                {
                    Byte[] mybyte = new byte[0];
                    mybyte = (Byte[])(dr["ImagenPerfil"]);
                    MemoryStream ms = new MemoryStream(mybyte);
                    pbImageAmigo.Image = Image.FromStream(ms);

                }
            }
            //cerrams la coneccion
            cn.Close();


            SqlCommand cm1 = new SqlCommand("select DISTINCT m.mensaje, m.IdUsuarioEmisor,m.IdUsuarioReceptor,m.FechaMensaje from TMensaje as m, TUsuario as u where(IdUsuarioEmisor =" + tbIdUsuario1.Text + " and IdUsuarioReceptor = " + tbIdUsuario2.Text + ") or(IdUsuarioEmisor = " + tbIdUsuario2.Text + " and IdUsuarioReceptor = " + tbIdUsuario1.Text + ") ORDER BY m.FechaMensaje asc", cn);
            //abrimos la coneccion
            cn.Open();
            SqlDataReader dr1 = cm1.ExecuteReader();
            if (dr1.HasRows)
            {
                //if datos son leido agregamos al control
                while (dr1.Read())
                {
                    //agregamos el origen de datos al control
                    this.lbChat.Items.Add(dr1.GetString(0));
                }
            }
            //cerrams la coneccion
            cn.Close();
        }
    }
}
