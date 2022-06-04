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
using System.IO;

namespace RedSocialUnivalle
{
    public partial class InterfazGeneral : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True");
        public InterfazGeneral()
        {
            InitializeComponent();
            tbIdUsuarioSistema.Text = Form1.IdUsuario;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MostrarPublicaciones uuu = new MostrarPublicaciones();
            uuu.TopLevel = false;
            panelRecargable.Controls.Add(uuu);
            uuu.Show();

            pbPortada.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            FormularioAmigos jjj = new FormularioAmigos();
            jjj.TopLevel = false;
            panelRecargable.Controls.Add(jjj);
            jjj.Show();
            pbPortada.Hide();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            MiPerfilDeUsuario qqq = new MiPerfilDeUsuario();
            qqq.TopLevel = false;
            panelRecargable.Controls.Add(qqq);
            qqq.Show();
            pbPortada.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ListaChat ppp = new ListaChat();
            ppp.TopLevel = false;
            panelRecargable.Controls.Add(ppp);
            ppp.Show();
            pbPortada.Hide();
        }

        private void panelRecargable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InterfazGeneral_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("SELECT * FROM TUsuario where IdUsuario='" + tbIdUsuarioSistema.Text + "'", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                
                lbUsuarioSistema.Text = dr["UsuarioSistema"].ToString();
                lbNombreUsuario.Text = dr["Nombres"].ToString();
                lbApellidoUsuario.Text = dr["Apellido_Paterno"].ToString();

                Byte[] mybyte = new byte[0];
                mybyte = (Byte[])(dr["ImagenPerfil"]);
                MemoryStream ms = new MemoryStream(mybyte);
                pbPerfilInicio.Image = Image.FromStream(ms);

                Byte[] mybyte1 = new byte[0];
                mybyte1 = (Byte[])(dr["ImagenPortada"]);
                MemoryStream ms1 = new MemoryStream(mybyte1);
                pbPortada.Image = Image.FromStream(ms1);
            }
            cn.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 inicio = new Form1();
            inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pruebas iii = new pruebas();
            iii.Show();
        }
    }
}
