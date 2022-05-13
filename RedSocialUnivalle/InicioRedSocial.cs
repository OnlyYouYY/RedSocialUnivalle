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
    public partial class InicioRedSocial : Form
    {
        public InicioRedSocial()
        {
            InitializeComponent();
            LBNombre.Text = Form1.nombre_usuario;
            LBApellido.Text = Form1.apellido_usuario;
            LBSesion.Text = Form1.nombre_inicio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AñadirPublicacion fff = new AñadirPublicacion();
            fff.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ModificarUsuario aaa = new ModificarUsuario();
            this.Close();
            aaa.Show();
        }

        private void BTNEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario ddd = new EliminarUsuario();
            this.Close();
            ddd.Show();

        }

        private void BTNMostrarUsuarios_Click(object sender, EventArgs e)
        {
            MostrarUsuarios fff = new MostrarUsuarios();
            this.Close();
            fff.Show();
        }

        private void BTNComentarPublicacion_Click(object sender, EventArgs e)
        {
            MostrarPublicaciones ggg = new MostrarPublicaciones();
            this.Close();
            ggg.Show();
        }

        private void BTNAñadirAmigos_Click(object sender, EventArgs e)
        {
            AñadirAmigos hhh = new AñadirAmigos();
            this.Close();
            hhh.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MostrarSolicitudes iii = new MostrarSolicitudes();
            this.Close();
            iii.Show();
        }

        private void BTNVerAmigos_Click(object sender, EventArgs e)
        {
            MostrarListaAmigos yyy = new MostrarListaAmigos();
            this.Close();
            yyy.Show();
        }
    }
}
