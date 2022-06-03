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
    public partial class MostrarSolicitudes : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True");
        public MostrarSolicitudes()
        {
            InitializeComponent();
            TBIdUsuario.Text = Form1.IdUsuario;
        }

        private void MostrarSolicitudes_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("SELECT IdAmigo,NombreSolicitud,FechaEnvio_Solicitud FROM TAmigo WHERE  IdUsuario = "+TBIdUsuario.Text+" and EstadoAmigo = 'False' and Estado = 'True'", cn);
            //abrimos la coneccion
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                //if datos son leido agregamos al control
                while (dr.Read())
                {
                    //agregamos el origen de datos al control
                    this.lbSolicitudes.Items.Add(dr.GetString(1));
                }
            }
            //cerrams la coneccion
            cn.Close();
        }

        private void BTNAceptarSolicitud_Click(object sender, EventArgs e)
        {
            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPAceptarSolicitud", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@IdAmigo", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdUsuario"].Value = TBIdUsuario.Text;
            da.SelectCommand.Parameters["@IdAmigo"].Value = tbIdSolicitudes.Text;

            da.Fill(bt);
            MessageBox.Show("Solicitud Aceptada");
        }

        private void BTNBorrarSolicitud_Click(object sender, EventArgs e)
        {
            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPEliminarSolicitud", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdAmigo", SqlDbType.Int);
            da.SelectCommand.Parameters["@IdAmigo"].Value = tbIdSolicitudes.Text;
            da.Fill(bt);
            MessageBox.Show("Solicitud Eliminada");
        }

        private void lbSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("SELECT * FROM TAmigo where NombreSolicitud='" + lbSolicitudes.Text + "'and EstadoAmigo = 'False' and Estado = 'True'", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                tbIdSolicitudes.Text = dr["IdAmigo"].ToString();
                
            }
            cn.Close();
        }
    }
}
