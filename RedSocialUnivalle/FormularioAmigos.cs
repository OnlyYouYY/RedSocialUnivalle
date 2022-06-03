using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedSocialUnivalle
{
    public partial class FormularioAmigos : Form
    {
        public FormularioAmigos()
        {
            InitializeComponent();
        }

        private void FormularioAmigos_Load(object sender, EventArgs e)
        {

        }

        private void iconAñadirAmigo_Click(object sender, EventArgs e)
        {
            AñadirAmigos kkk = new AñadirAmigos();
            kkk.TopLevel = false;
            panelRefreshAmigos.Controls.Add(kkk);
            kkk.Show();
        }

        private void iconSolicitudes_Click(object sender, EventArgs e)
        {
            MostrarSolicitudes ooo = new MostrarSolicitudes();
            ooo.TopLevel = false;
            panelRefreshAmigos.Controls.Add(ooo);
            ooo.Show();
        }

        private void iconListaAmigos_Click(object sender, EventArgs e)
        {
            MostrarListaAmigos rrr = new MostrarListaAmigos();
            rrr.TopLevel = false;
            panelRefreshAmigos.Controls.Add(rrr);
            rrr.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
