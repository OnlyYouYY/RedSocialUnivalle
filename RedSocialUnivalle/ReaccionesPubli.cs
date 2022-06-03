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
    public partial class ReaccionesPubli : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True");
        public ReaccionesPubli()
        {
            InitializeComponent();
            /*panelReacciones.Visible = false;
            lbReacciones.Visible = false;*/
        }

        private void btnMeGustaR_Click(object sender, EventArgs e)
        {

            /*panelReacciones.Show();
            lbReacciones.Visible = true;*/

            lbReacciones.Items.Clear();
            lbSuma.Text = "";


            SqlCommand cm = new SqlCommand("SELECT r.IdUsuario, u.Nombres FROM TReaccionPublic as r,TUsuario as u Where IdPublicacion = '" + tbIdPublicacionReaccion.Text + "' and IdReaccion = '1' and r.IdUsuario = u.IdUsuario", cn);
            //abrimos la coneccion
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                //if datos son leido agregamos al control
                while (dr.Read())
                {
                    //agregamos el origen de datos al control
                    this.lbReacciones.Items.Add(dr.GetString(1));
                }
            }
            //cerrams la coneccion
            cn.Close();

            SqlCommand cm1 = new SqlCommand("SELECT COUNT(IdReaccion) as suma, IdPublicacion FROM TReaccionPublic WHERE IdReaccion = 1 and IdPublicacion = '"+tbIdPublicacionReaccion.Text+"' and Estado = 'True' GROUP BY IdPublicacion", cn);
            //abrimos la coneccion
            cn.Open();
            SqlDataReader dr1 = cm1.ExecuteReader();
            if (dr1.HasRows)
            {
                //if datos son leido agregamos al control
                while (dr1.Read())
                {
                    //agregamos el origen de datos al control
                    this.lbSuma.Text = dr1.GetInt32(0) + " personas han reaccionado y dan dado Me Gusta a tu publicacion";
                }
            }
            //cerrams la coneccion
            cn.Close();


        }

        private void btnMeEncantaR_Click(object sender, EventArgs e)
        {
            /*panelReacciones.Show();
            lbReacciones.Visible = true;*/

            lbReacciones.Items.Clear();
            lbSuma.Text = "";

            SqlCommand cm = new SqlCommand("SELECT r.IdUsuario, u.Nombres FROM TReaccionPublic as r,TUsuario as u Where IdPublicacion = '" + tbIdPublicacionReaccion.Text + "' and IdReaccion = '2' and r.IdUsuario = u.IdUsuario", cn);
            //abrimos la coneccion
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                //if datos son leido agregamos al control
                while (dr.Read())
                {
                    //agregamos el origen de datos al control
                    this.lbReacciones.Items.Add(dr.GetString(1));
                }
            }
            //cerrams la coneccion
            cn.Close();

            SqlCommand cm1 = new SqlCommand("SELECT COUNT(IdReaccion) as suma, IdPublicacion FROM TReaccionPublic WHERE IdReaccion = 2 and IdPublicacion = '" + tbIdPublicacionReaccion.Text + "' and Estado = 'True' GROUP BY IdPublicacion", cn);
            //abrimos la coneccion
            cn.Open();
            SqlDataReader dr1 = cm1.ExecuteReader();
            if (dr1.HasRows)
            {
                //if datos son leido agregamos al control
                while (dr1.Read())
                {
                    //agregamos el origen de datos al control
                    this.lbSuma.Text = dr1.GetInt32(0) + " personas han reaccionado y dan dado Me Encanta a tu publicacion";
                }
            }
            //cerrams la coneccion
            cn.Close();
        }

        private void btnNoMeGustaR_Click(object sender, EventArgs e)
        {
            /*panelReacciones.Show();
            lbReacciones.Visible = true;*/

            lbReacciones.Items.Clear();
            lbSuma.Text = "";

            SqlCommand cm = new SqlCommand("SELECT r.IdUsuario, u.Nombres FROM TReaccionPublic as r,TUsuario as u Where IdPublicacion = '" + tbIdPublicacionReaccion.Text + "' and IdReaccion = '3' and r.IdUsuario = u.IdUsuario", cn);
            //abrimos la coneccion
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                //if datos son leido agregamos al control
                while (dr.Read())
                {
                    //agregamos el origen de datos al control
                    this.lbReacciones.Items.Add(dr.GetString(1));
                }
            }
            //cerrams la coneccion
            cn.Close();
            SqlCommand cm1 = new SqlCommand("SELECT COUNT(IdReaccion) as suma, IdPublicacion FROM TReaccionPublic WHERE IdReaccion = 3 and IdPublicacion = '" + tbIdPublicacionReaccion.Text + "' and Estado = 'True' GROUP BY IdPublicacion", cn);
            //abrimos la coneccion
            cn.Open();
            SqlDataReader dr1 = cm1.ExecuteReader();
            if (dr1.HasRows)
            {
                //if datos son leido agregamos al control
                while (dr1.Read())
                {
                    //agregamos el origen de datos al control
                    this.lbSuma.Text = dr1.GetInt32(0) + " personas han reaccionado y dan dado No Me Gusta a tu publicacion";
                }
            }
            //cerrams la coneccion
            cn.Close();
        }

        private void ReaccionesPubli_Load(object sender, EventArgs e)
        {
            
        }
    }
}
