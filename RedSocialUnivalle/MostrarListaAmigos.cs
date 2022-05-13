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
    public partial class MostrarListaAmigos : Form
    {
        public MostrarListaAmigos()
        {
            InitializeComponent();
            TBIdUsuario.Text = Form1.IdUsuario;
        }

        private void MostrarListaAmigos_Load(object sender, EventArgs e)
        {
            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrarListaAmigos", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.VarChar, 50);

            da.SelectCommand.Parameters["@IdUsuario"].Value = TBIdUsuario.Text;

            da.Fill(bt);
            DGListaAmigos.DataSource = bt;

            DataTable bt1 = new DataTable();
            string tconeccion1 = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection1 = new SqlConnection(tconeccion1);
            SqlDataAdapter da1 = new SqlDataAdapter("SPMostrarListaAmigos2", dataConection1);
            da1.SelectCommand.CommandType = CommandType.StoredProcedure;

            da1.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.VarChar, 50);

            da1.SelectCommand.Parameters["@IdUsuario"].Value = TBIdUsuario.Text;

            da1.Fill(bt1);
            DGListaAmigos2.DataSource = bt1;
        }
    }
}
