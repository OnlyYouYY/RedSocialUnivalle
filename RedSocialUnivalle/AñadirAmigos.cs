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

namespace RedSocialUnivalle
{
    public partial class AñadirAmigos : Form
    {
        public AñadirAmigos()
        {
            InitializeComponent();
            TBNombreUsuario.Text = Form1.nombre_inicio;
            TBIdUsuario.Text = Form1.IdUsuario;
            
        }

        private void AñadirAmigos_Load(object sender, EventArgs e)
        {
            

        }

        private void BTNBuscarUsuario_Click(object sender, EventArgs e)
        {
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
            DGBusquedaUsuario.DataSource = bt;

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
    }
}
