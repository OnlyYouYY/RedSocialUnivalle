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
    public partial class AñadirPublicacion : Form
    {
        public static string IdArchivo;
        public AñadirPublicacion()
        {
            InitializeComponent();
            TBIdUsuario.Text = Form1.IdUsuario;
            TBNombreUsuario.Text = Form1.nombre_inicio;

        }

        private void AñadirPublicacion_Load(object sender, EventArgs e)
        {

        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPPublicar", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@TituloContent", SqlDbType.VarChar, 50);
            da.SelectCommand.Parameters.Add("@TextContent", SqlDbType.VarChar, 1000);
            da.SelectCommand.Parameters.Add("@ImagenU", SqlDbType.Image);
            da.SelectCommand.Parameters.Add("@UsuarioSistema", SqlDbType.VarChar, 50);

            da.SelectCommand.Parameters["@IdUsuario"].Value = TBIdUsuario.Text;
            da.SelectCommand.Parameters["@TituloContent"].Value = TBTituloPublicacion.Text;
            da.SelectCommand.Parameters["@TextContent"].Value = TBDescripcionPublicacion.Text;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            PBPublicacion.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            da.SelectCommand.Parameters["@ImagenU"].Value = ms.GetBuffer();
            da.SelectCommand.Parameters["@UsuarioSistema"].Value = TBNombreUsuario.Text;


            MessageBox.Show("Publicacion Registrada");
            da.Fill(bt);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void BTNAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image File(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PBPublicacion.Image = new Bitmap(open.FileName);
            }
        }
    }
}
