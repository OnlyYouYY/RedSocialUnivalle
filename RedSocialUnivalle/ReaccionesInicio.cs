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
    public partial class ReaccionesInicio : Form
    {
        string reaccion = "";
        string mensaje = "";
        public ReaccionesInicio()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
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
                da.SelectCommand.Parameters.Add("@UsuarioSistema", SqlDbType.VarChar, 50);

                da.SelectCommand.Parameters["@IdPublicacion"].Value = tbIdPublicacion2.Text;
                da.SelectCommand.Parameters["@IdUsuario"].Value = tbIdUsuario2.Text;
                da.SelectCommand.Parameters["@IdReaccion"].Value = reaccion;
                da.SelectCommand.Parameters["@UsuarioSistema"].Value = tbNombreInicio2.Text;

                da.Fill(bt);

                this.Close();

                AlertReaccion ooo = new AlertReaccion();
                ooo.Show();
            }
            catch
            {
                MessageBox.Show("Datos no registrados/error database");
            }
        }
    }
}
