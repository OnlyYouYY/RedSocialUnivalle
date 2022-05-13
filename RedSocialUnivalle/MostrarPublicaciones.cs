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
    public partial class MostrarPublicaciones : Form
    {
        public static string IdPublicacion;
        public MostrarPublicaciones()
        {
            InitializeComponent();
        }
        

        private void MostrarPublicaciones_Load(object sender, EventArgs e)
        {
            
            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPMostrarPublicacionesDG", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.Fill(bt);
            DGVerPublicaciones.DataSource = bt;
        }

        private void DGVerPublicaciones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }

        private void DGVerPublicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BTNVerPublicacion_Click(object sender, EventArgs e)
        {

            
            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPBuscarPublicacion", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdPublicacion", SqlDbType.Int);

            da.SelectCommand.Parameters["@IdPublicacion"].Value = TBIdPublicacion.Text;


            da.Fill(bt);

            if (bt.Rows.Count >= 1)
            {
                IdPublicacion = TBIdPublicacion.Text;
                
                Publicacion fff = new Publicacion();
                fff.Show();
            }
            else
            {
                MessageBox.Show("Publicacion no encontrada");
            }

        }
    }
}
