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
    public partial class Form1 : Form
    {
        public static string nombre_inicio;
        public static string nombre_usuario;
        public static string apellido_usuario;
        public static string IdUsuario;
        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            DataTable bt = new DataTable();
            string tconexion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConexion = new SqlConnection(tconexion);
            SqlDataAdapter da = new SqlDataAdapter("SPLogin", dataConexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;



            da.SelectCommand.Parameters.Add("@Usuario", SqlDbType.VarChar, 50);
            da.SelectCommand.Parameters.Add("@Contraseña", SqlDbType.VarChar, 50);



            da.SelectCommand.Parameters["@Usuario"].Value = TBNombreUsuario.Text;
            da.SelectCommand.Parameters["@Contraseña"].Value = TBContraseñaUsuario.Text;

            da.Fill(bt);
            

            if (bt.Rows.Count >= 1)
            {
                nombre_inicio = TBNombreUsuario.Text;
                nombre_usuario = bt.Rows[0][1].ToString();
                apellido_usuario = bt.Rows[0][2].ToString();
                IdUsuario = bt.Rows[0][0].ToString();
                InicioRedSocial aaa = new InicioRedSocial();
                aaa.Show();
            }
            else
            {
                MessageBox.Show("Usuario y Contraseña incorreto");
            }
            
            
        }

        private void BTNRegistro_Click(object sender, EventArgs e)
        {
            REGISTRO bbb = new REGISTRO();
            
            bbb.Show();
        }
    }
}
