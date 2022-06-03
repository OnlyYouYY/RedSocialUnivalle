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

using System.Runtime.InteropServices;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace RedSocialUnivalle
{
    public partial class Form1 : Form
    {

        #region Dlls para poder hacer el movimiento del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Rectangle sizeGripRectangle;
        bool inSizeDrag = false;
        const int GRIP_SIZE = 15;

        int w = 0;
        int h = 0;
        #endregion

        public static string nombre_inicio;
        public static string nombre_usuario;
        public static string apellido_usuario;
        public static string IdUsuario;

        static private NetworkStream stream;
        static private StreamWriter streamw;
        static private StreamReader streamr;
        static private TcpClient client = new TcpClient();
        static private string nick = "unknown";

        private delegate void DaddItem(string s);
        private void AddItem(string s)
        {
            
        }

        public Form1()
        {
            InitializeComponent();
            
        }
        
        void Conectar()
        {
            try
            {
                client.Connect("127.0.0.1", 8000);
                if(client.Connected)
                {
                    ChatMasServidor ct = new ChatMasServidor();
                    Thread t = new Thread(ct.Listen);

                    stream = client.GetStream();
                    streamr = new StreamReader(stream);
                    streamw = new StreamWriter(stream);

                    streamw.WriteLine(nick);
                    streamw.Flush();

                    t.Start();

                }
                else
                {
                    MessageBox.Show("Servidor no disponible");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Servidor no disponible");
            }
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
            nick = TBNombreUsuario.Texts;
            Conectar();
            DataTable bt = new DataTable();
            string tconexion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConexion = new SqlConnection(tconexion);
            SqlDataAdapter da = new SqlDataAdapter("SPLogin", dataConexion);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;



            da.SelectCommand.Parameters.Add("@Usuario", SqlDbType.VarChar, 50);
            da.SelectCommand.Parameters.Add("@Contraseña", SqlDbType.VarChar, 50);



            da.SelectCommand.Parameters["@Usuario"].Value = TBNombreUsuario.Texts;
            da.SelectCommand.Parameters["@Contraseña"].Value = TBContraseñaUsuario.Texts;

            da.Fill(bt);
            

            if (bt.Rows.Count >= 1)
            {
                nombre_inicio = TBNombreUsuario.Texts;
                nombre_usuario = bt.Rows[0][1].ToString();
                apellido_usuario = bt.Rows[0][2].ToString();
                IdUsuario = bt.Rows[0][0].ToString();
                InterfazGeneral aaa = new InterfazGeneral();
                aaa.Show();
            }
            else
            {
                MessageBox.Show("Usuario y Contraseña incorreto");
            }
            this.Hide();
            
        }

        private void BTNRegistro_Click(object sender, EventArgs e)
        {
            REGISTRO bbb = new REGISTRO();
            
            bbb.Show();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
