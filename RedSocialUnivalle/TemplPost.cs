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
    public partial class TemplPost : UserControl
    {
        
        public TemplPost()
        {
            InitializeComponent();
            tbIdUsuario.Text = Form1.IdUsuario;
            tbNombreInicio.Text = Form1.nombre_inicio;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnReacciones_Click(object sender, EventArgs e)
        {
            ReaccionesInicio iii = new ReaccionesInicio();

            iii.tbIdPublicacion2.Text = tbIdPublicacion.Text;
            iii.tbIdUsuario2.Text = tbIdUsuario.Text;
            iii.tbNombreInicio2.Text = tbNombreInicio.Text;

            iii.Show();
        }

        private void btnComentarios_Click(object sender, EventArgs e)
        {
            ComentariosInicio ppp = new ComentariosInicio();
            ppp.tbIdPublicacion3.Text = tbIdPublicacion.Text;
            ppp.Show();
            
        }

        private void TemplPost_Load(object sender, EventArgs e)
        {

        }
    }
}
