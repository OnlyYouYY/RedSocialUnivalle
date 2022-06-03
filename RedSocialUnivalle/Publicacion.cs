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
    public partial class Publicacion : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True");
        string reaccion = "";
        public Publicacion()
        {
            InitializeComponent();
            TBIdUsuario.Text = Form1.IdUsuario;
            TBUsuario.Text = Form1.nombre_inicio;
            
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (RB1.Checked)
            {
                reaccion = "1";
            }
            if (RB2.Checked)
            {
                reaccion = "2";
            }
            if (RB3.Checked)
            {
                reaccion = "3";
            }

            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPReaccion_Publicacion_Comentario", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdPublicacion", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdReaccion", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@ComentarioContent", SqlDbType.VarChar, 50);
            da.SelectCommand.Parameters.Add("@UsuarioSistema", SqlDbType.VarChar, 50);

            da.SelectCommand.Parameters["@IdPublicacion"].Value = TBIdPublicacion2.Text;
            da.SelectCommand.Parameters["@IdUsuario"].Value = TBIdUsuario.Text;
            da.SelectCommand.Parameters["@IdReaccion"].Value = reaccion;
            da.SelectCommand.Parameters["@ComentarioContent"].Value = TBComentario.Text;
            da.SelectCommand.Parameters["@UsuarioSistema"].Value = TBUsuario.Text;

            MessageBox.Show("Reaccion y/o Comentario Registrado");
            da.Fill(bt);

            this.Close();



        }

        private void Publicacion_Load(object sender, EventArgs e)
        {
            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlCommand comando = new SqlCommand("SELECT tp.TituloContent, tp.TextContent, tp.ImagenU, tp.Fecha_Publicacion, tu.UsuarioSistema FROM TPublicacion tp INNER JOIN TUsuario tu ON tp.IdUsuario = tu.IdUsuario WHERE IdPublicacion = @IdPublicacion", dataConection);
            comando.Parameters.AddWithValue("@IdPublicacion", TBIdPublicacion2.Text);
            dataConection.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                LBTituloPublicacion.Text = registro["TituloContent"].ToString();
                TBDescripcionPublicacion.Text = registro["TextContent"].ToString();
                LBFechaPublicacion.Text = registro["Fecha_Publicacion"].ToString();
                LBUsuarioPublicacion.Text = registro["UsuarioSistema"].ToString();



                dataConection.Close();
            }

            SqlCommand cm = new SqlCommand("SELECT IdUsuario, ImagenPerfil FROM TUsuario WHERE IdUsuario = '" + TBIdPublicacion2.Text + "'", cn);
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
                    PBImagenPublicacion.Image = Image.FromStream(ms);
                }
            }
            //cerrams la coneccion
            cn.Close();
        }

        private void BTNCargarImagen_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sConexion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConnection = new SqlConnection(sConexion);
            SqlDataAdapter da = new SqlDataAdapter("SPCargarImagen", dataConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdPublicacion", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdPublicacion"].Value = TBIdPublicacion2.Text;

            da.Fill(dt);

            Byte[] mybyte = new byte[0];
            mybyte = (Byte[])(dt.Rows[0][0]);
            MemoryStream ms = new MemoryStream(mybyte);
            PBImagenPublicacion.Image = Image.FromStream(ms);
        }
    }
}
