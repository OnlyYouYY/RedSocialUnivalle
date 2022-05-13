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
        public MostrarSolicitudes()
        {
            InitializeComponent();
            TBIdUsuario.Text = Form1.IdUsuario;
        }

        private void MostrarSolicitudes_Load(object sender, EventArgs e)
        {
            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrarSolicitudes", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdUsuario"].Value = TBIdUsuario.Text;

            da.Fill(bt);
            DGMostrarSolicitudes.DataSource = bt;
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
            da.SelectCommand.Parameters["@IdAmigo"].Value = TBIdSolicitud.Text;

            da.Fill(bt);
        }

        private void BTNBorrarSolicitud_Click(object sender, EventArgs e)
        {
            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPEliminarSolicitud", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdAmigo", SqlDbType.Int);
            da.SelectCommand.Parameters["@IdAmigo"].Value = TBIdSolicitud.Text;
            da.Fill(bt);
        }
    }
}
