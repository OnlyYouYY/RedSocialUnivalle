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
    public partial class pruebas : Form
    {
        
        


        public pruebas()
        {
            InitializeComponent();
            CargarPosts();
        }
        private void CargarPosts()
        {
            try
            {
                // Usamos la conexion con un try para evitar Errores en Ejecución
                SqlConnection DataBase = new SqlConnection("Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True");
                DataTable dataTable = new DataTable();
                {
                    DataBase.Open();
                    SqlDataAdapter SqlAdapter = new SqlDataAdapter
                    ("SELECT IdPublicacion, ImagenPerfil, TUsuario.UsuarioSistema, TPublicacion.Fecha_Publicacion,TituloContent,TextContent, ImagenU FROM TPublicacion INNER JOIN TUsuario ON TPublicacion.IdUsuario = TUsuario.IdUsuario ORDER BY TPublicacion.Fecha_Publicacion DESC", DataBase);
                    dataTable = new DataTable();
                    SqlAdapter.Fill(dataTable);
                }
                // Añadimos las publicaciones a la estructura de las publicaciones, una por cada fila del DataTable resultado de la consulta
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    TemplPost post = new TemplPost();
                    post.PostUser.Text = dataTable.Rows[i]["UsuarioSistema"].ToString();
                    Byte[] bitMapUser = new Byte[0];
                    bitMapUser = (Byte[])(dataTable.Rows[i]["ImagenPerfil"]);
                    MemoryStream bitUser = new MemoryStream(bitMapUser);
                    post.PostProfile.Image = Image.FromStream(bitUser);
                    post.tbIdPublicacion.Text = dataTable.Rows[i]["IdPublicacion"].ToString();
                    post.PostDateTime.Text = dataTable.Rows[i]["Fecha_Publicacion"].ToString();
                    post.PostTitle.Text = dataTable.Rows[i]["TituloContent"].ToString();
                    post.PostContent.Text = dataTable.Rows[i]["TextContent"].ToString();
                    // Validamos si la publicacion contiene una Imagen
                    if ((dataTable.Rows[i]["ImagenU"].ToString()) != "")
                    {
                        Byte[] bitMapPost = new Byte[0];
                        bitMapPost = (Byte[])(dataTable.Rows[i]["ImagenU"]);
                        MemoryStream bitPost = new MemoryStream(bitMapPost);
                        post.PostImage.Image = Image.FromStream(bitPost);
                    }
                    else { post.PostImage = null; }
                    FLPPublicaciones.Controls.Add(post);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "(!) - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error); }



        }

        private void pruebas_Load(object sender, EventArgs e)
        {

        }
    }

}
