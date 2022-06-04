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
    public partial class ComentariosInicio : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True");

        public ComentariosInicio()
        {
            InitializeComponent();
            tbIdUsuarioSis.Text = Form1.IdUsuario;
            
        }
        private void CargarComentarios()
        {
            try
            {
                // Usamos la conexion con un try para evitar Errores en Ejecución
                SqlConnection DataBase = new SqlConnection("Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True");
                DataTable dataTable = new DataTable();
                {
                    DataBase.Open();
                    SqlDataAdapter SqlAdapter = new SqlDataAdapter
                    ("SELECT IdPublicacion, ImagenPerfil, TComentario.UsuarioSistema, Fecha_Comentario,ComentarioContent FROM TComentario INNER JOIN TUsuario ON TComentario.IdUsuario = TUsuario.IdUsuario WHERE TComentario.IdPublicacion = '"+tbIdPublicacion3.Text+"' ORDER BY TComentario.Fecha_Comentario DESC", DataBase);
                    dataTable = new DataTable();
                    SqlAdapter.Fill(dataTable);
                }
                // Añadimos las publicaciones a la estructura de las publicaciones, una por cada fila del DataTable resultado de la consulta
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    ComentariosFLP coment = new ComentariosFLP();
                    coment.lbPerfil.Text = dataTable.Rows[i]["UsuarioSistema"].ToString();
                    Byte[] bitMapUser = new Byte[0];
                    bitMapUser = (Byte[])(dataTable.Rows[i]["ImagenPerfil"]);
                    MemoryStream bitUser = new MemoryStream(bitMapUser);
                    coment.pbPerfil.Image = Image.FromStream(bitUser);
                    coment.lbComentario.Text = dataTable.Rows[i]["ComentarioContent"].ToString();


                    FLPComentarios.Controls.Add(coment);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "(!) - Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error); }



        }

        private void ComentariosInicio_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("SELECT * FROM TUsuario where IdUsuario='" + tbIdUsuarioSis.Text + "'", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                lbNombreUsuario.Text = dr["UsuarioSistema"].ToString();  

                Byte[] mybyte = new byte[0];
                mybyte = (Byte[])(dr["ImagenPerfil"]);
                MemoryStream ms = new MemoryStream(mybyte);
                pbImagenUsuario.Image = Image.FromStream(ms);

            }
            cn.Close();
            CargarComentarios();
        }
    }
}
