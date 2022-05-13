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
    public partial class MostrarUsuarios : Form
    {
        public MostrarUsuarios()
        {
            InitializeComponent();
        }

        private void MostrarUsuarios_Load(object sender, EventArgs e)
        {
            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrarUsuarios", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.Fill(bt);
            DGListaUsuarios.DataSource = bt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable br = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrarUsuarios", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.Fill(br);
            DGListaUsuarios.DataSource = br;
        }
    }
}
