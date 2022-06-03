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
        SqlConnection cn = new SqlConnection("Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True");
        public static string IdPublicacion;
        public MostrarPublicaciones()
        {
            InitializeComponent();
        }
        

        private void MostrarPublicaciones_Load(object sender, EventArgs e)
        {

            SqlCommand cm = new SqlCommand("SELECT IdPublicacion, TituloContent FROM TPublicacion", cn);
            
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                
                while (dr.Read())
                {
                    
                    this.listPublicaciones.Items.Add(dr.GetString(1));
                }
            }
            //cerrams la coneccion
            cn.Close();
        }

        private void DGVerPublicaciones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }

        private void DGVerPublicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        /*private void BTNVerPublicacion_Click(object sender, EventArgs e)
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

        }*/

        private void iconPublicaciones_Click(object sender, EventArgs e)
        {
            AñadirPublicacion iii = new AñadirPublicacion();
            iii.TopLevel = false;
            panelPublicRefresh.Controls.Add(iii);
            iii.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            
            
                Publicacion iii = new Publicacion();
                iii.TBIdPublicacion2.Text = tbIdPublicacion.Text;
                iii.TopLevel = false;
                panelPublicRefresh.Controls.Add(iii);
                iii.Show();
            
            
            
            
        }

        private void iconModificarPublic_Click(object sender, EventArgs e)
        {
            MisPublicaciones ppp = new MisPublicaciones();
            
            ppp.TopLevel = false;
            panelPublicRefresh.Controls.Add(ppp);
            ppp.Show();
        }

        private void iconEliminarPublic_Click(object sender, EventArgs e)
        {

        }

        private void listPublicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("SELECT * FROM TPublicacion where TituloContent='" + listPublicaciones.Text + "'", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                tbIdPublicacion.Text = dr["IdPublicacion"].ToString();

            }
            cn.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
