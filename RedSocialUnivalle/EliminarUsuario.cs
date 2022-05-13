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
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
            TBBuscarUsuario.Text = Form1.IdUsuario;
            
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlDataAdapter da = new SqlDataAdapter("SPEliminarUsuario", dataConection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int);
            da.SelectCommand.Parameters["@IdUsuario"].Value = TBBuscarUsuario.Text;

            da.Fill(bt);

            MessageBox.Show("Usuario Eliminado");
            this.Close();
            
            
            
            
        }

        private void BTNBuscarUsuario_Click(object sender, EventArgs e)
        {
            DataTable bt = new DataTable();
            string tconeccion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
            SqlConnection dataConection = new SqlConnection(tconeccion);
            SqlCommand comando = new SqlCommand("SELECT * FROM TUsuario WHERE IdUsuario = @IdUsuario", dataConection);
            comando.Parameters.AddWithValue("@IdUsuario", TBBuscarUsuario.Text);
            dataConection.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                
                TBNombre.Text = registro["Nombres"].ToString();
                TBApellidoPaterno.Text = registro["Apellido_Paterno"].ToString();
                TBApellidoMaterno.Text = registro["Apellido_Materno"].ToString();
                TBCorreo.Text = registro["CorreoElectronico"].ToString();

                dataConection.Close();
            }
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void TBApellidoMaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBApellidoPaterno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
