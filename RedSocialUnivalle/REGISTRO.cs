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
    public partial class REGISTRO : Form
    {
        public REGISTRO()
        {
            InitializeComponent();
        }

        private void BTNInsertar_Click(object sender, EventArgs e)
        {
            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPInsertarUsuario", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@Nombres", SqlDbType.VarChar, 50);
            da.SelectCommand.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar, 50);
            da.SelectCommand.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar, 50);
            da.SelectCommand.Parameters.Add("@CorreoElectronico", SqlDbType.VarChar, 50);
            da.SelectCommand.Parameters.Add("@Nacionalidad", SqlDbType.VarChar, 50);
            da.SelectCommand.Parameters.Add("@NroContacto", SqlDbType.Int);
            da.SelectCommand.Parameters.Add("@Sexo", SqlDbType.VarChar, 50);
            da.SelectCommand.Parameters.Add("@FechaNacimiento", SqlDbType.Date);
            da.SelectCommand.Parameters.Add("@Contraseña", SqlDbType.VarChar, 50);
            da.SelectCommand.Parameters.Add("@ImgPerfil", SqlDbType.Image);
            da.SelectCommand.Parameters.Add("@ImgPortada", SqlDbType.Image);
            da.SelectCommand.Parameters.Add("@UsuarioSistema", SqlDbType.VarChar, 50);

            if (TBNombres.Text == "")
            {
                MessageBox.Show("Compruebe el Nombre");
            }
            else
            {
                if (TBApellidoPaterno.Text == "")
                {
                    MessageBox.Show("Compruebe el Apellido Paterno");
                }
                else
                {
                    if (TBApellidoMaterno.Text == "")
                    {
                        MessageBox.Show("Compruebe el Apellido Materno");
                    }
                    else
                    {
                        if (TBCorreo.Text == "")
                        {
                            MessageBox.Show("Compruebe el Correo Electronico");
                        }
                        else
                        {
                            if (CBNacionalidad.Text == "")
                            {
                                MessageBox.Show("Compruebe la Nacionalidad");
                            }
                            else
                            {
                                if (TBContacto.Text == "")
                                {
                                    MessageBox.Show("Compruebe el Numero de Contacto");
                                }
                                else
                                {
                                    if (CBSexo.Text == "")
                                    {
                                        MessageBox.Show("Compruebe el Sexo");
                                    }
                                    else
                                    {
                                        if (DTFechaNacimiento.Text == "")
                                        {
                                            MessageBox.Show("Compruebe la Fecha de Nacimiento");
                                        }
                                        else
                                        {
                                            if (TBContraseña.Text == "")
                                            {
                                                MessageBox.Show("Compruebe la Contraseña");
                                            }
                                            else
                                            {
                                                if (TBUsuario.Text == "")
                                                {
                                                    MessageBox.Show("Compruebe el Nombre de Usuario");
                                                }
                                                else
                                                {
                                                    da.SelectCommand.Parameters["@Nombres"].Value = TBNombres.Text;
                                                    da.SelectCommand.Parameters["@ApellidoPaterno"].Value = TBApellidoPaterno.Text;
                                                    da.SelectCommand.Parameters["@ApellidoMaterno"].Value = TBApellidoMaterno.Text;
                                                    da.SelectCommand.Parameters["@CorreoElectronico"].Value = TBCorreo.Text;
                                                    da.SelectCommand.Parameters["@Nacionalidad"].Value = CBNacionalidad.Text;
                                                    da.SelectCommand.Parameters["@NroContacto"].Value = TBContacto.Text;
                                                    da.SelectCommand.Parameters["@Sexo"].Value = CBSexo.Text;
                                                    da.SelectCommand.Parameters["@FechaNacimiento"].Value = DTFechaNacimiento.Text;
                                                    da.SelectCommand.Parameters["@Contraseña"].Value = TBContraseña.Text;
                                                    da.SelectCommand.Parameters["@UsuarioSistema"].Value = TBUsuario.Text;

                                                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                                                    PB1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                                    System.IO.MemoryStream ms1 = new System.IO.MemoryStream();
                                                    PB2.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);

                                                    da.SelectCommand.Parameters["@ImgPerfil"].Value = ms.GetBuffer();
                                                    da.SelectCommand.Parameters["@ImgPortada"].Value = ms1.GetBuffer();


                                                    da.Fill(bt);
                                                    if (bt.Rows.Count >= 1)
                                                    {
                                                        MessageBox.Show("Usuario Registrado");
                                                        this.Close();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Nombre de Usuario Existente, escoge otro porfavor");
                                                    }

                                                    

                                                    
                                                }


                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void REGISTRO_Load(object sender, EventArgs e)
        {
            

        }

        private void DGLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNAbrir1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image File(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PB1.Image = new Bitmap(open.FileName);
            }
        }

        private void BTNAbrir2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image File(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PB2.Image = new Bitmap(open.FileName);
            }
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
