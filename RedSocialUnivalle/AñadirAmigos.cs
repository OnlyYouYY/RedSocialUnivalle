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
    public partial class AñadirAmigos : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True");
        public AñadirAmigos()
        {
            InitializeComponent();
            TBNombreUsuario.Text = Form1.nombre_inicio;
            TBIdUsuario.Text = Form1.IdUsuario;
            
        }

        private void AñadirAmigos_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("SELECT UsuarioSistema FROM TUsuario WHERE NOT UsuarioSistema = '"+TBNombreUsuario.Text+"'", cn);
            //abrimos la coneccion
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                //if datos son leido agregamos al control
                while (dr.Read())
                {
                    //agregamos el origen de datos al control
                    this.listBuscarAmigo.Items.Add(dr.GetString(0));
                }
            }
            //cerrams la coneccion
            cn.Close();
        }

        private void BTNBuscarUsuario_Click(object sender, EventArgs e)
        {/*
            int a = 0;

            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPBusquedaAmigo", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@Busqueda", SqlDbType.VarChar, 50);
            da.SelectCommand.Parameters.Add("@Bandera", SqlDbType.Int);

            da.SelectCommand.Parameters["@Busqueda"].Value = TBBuscarUsuario.Text;

            if (CBTipoBusqueda.Text == "Nombre")
                a = 1;
            if (CBTipoBusqueda.Text == "Usuario")
                a = 2;

            da.SelectCommand.Parameters["@Bandera"].Value = a;

            da.Fill(bt);

            listBuscarAmigo.Items.Add(bt);

            
            */
        }

        private void BTNAñadirAmigo_Click(object sender, EventArgs e)
        {
            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPAñadirAmigo", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdUsuarioSolicitud", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@NombreSolicitud", SqlDbType.VarChar, 50);
            da.SelectCommand.Parameters.Add("@UsuarioSistema", SqlDbType.VarChar, 50);

            da.SelectCommand.Parameters["@IdUsuario"].Value = TBIdUsuarioAñadir.Text;
            da.SelectCommand.Parameters["@IdUsuarioSolicitud"].Value = TBIdUsuario.Text;
            da.SelectCommand.Parameters["@NombreSolicitud"].Value = TBNombreUsuario.Text;
            da.SelectCommand.Parameters["@UsuarioSistema"].Value = TBNombreUsuario.Text;

            MessageBox.Show("Solicitud Enviada");

            da.Fill(bt);

            this.Close();

        }

        private void DGBusquedaUsuario_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void DGBusquedaUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DGBusquedaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DGBusquedaUsuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            /*
            
            SqlCommand cm = new SqlCommand("SELECT * FROM TUsuario WHERE Nombres='" + DGBusquedaUsuario.Text+ "'", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                TBIdUsuarioAñadir.Text = dr["IdUsuario"].ToString();
            }
            cn.Close();*/
        }

        private void DGBusquedaUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listBuscarAmigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("SELECT * FROM TUsuario where UsuarioSistema='" + listBuscarAmigo.Text + "'", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                TBIdUsuarioAñadir.Text = dr["IdUsuario"].ToString();
                lbNombreUsuario.Text = dr["UsuarioSistema"].ToString();
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
