using RedSocialUnivalle.CapaDatos;
using RedSocialUnivalle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RedSocialUnivalle
{
    public class DataMensajes : RepositorioMaestro
    {
        private string nombre_inicio;
        private string nombre_usuario;
        private string apellido_usuario;
        private string idUsuario;
        private byte[] perfil;
        private string idUsuarioEmisor;
        private string idUsuarioReceptor;
        private string mensaje;
        private DateTime fechaMensaje;


        public string NombreUsuario { get { return nombre_usuario; } set { nombre_usuario = value; } }

        public string NombreInicio { get { return nombre_inicio; } set { nombre_inicio = value; } }

        public string ApellidoUsuario { get { return apellido_usuario; } set { apellido_usuario = value; } }

        public string IdUsuario { get { return idUsuario; } set { idUsuario= value; } }

        public byte[] Perfil { get { return perfil; } set { perfil = value; } }

        public string IdUsuarioEmisor { get { return idUsuarioEmisor; } set { idUsuarioEmisor = value; } }

        public string IdUsuarioReceptor { get { return idUsuarioReceptor; } set { idUsuarioReceptor = value; } }

        public string Mensaje { get { return mensaje; } set { mensaje = value; } }

        public DateTime FechaMensaje { get { return fechaMensaje; } set { fechaMensaje = value; } }


        public List<DataMensajes> UsrMje()
        {
            string comando = @"With cte as (
            select u.UsuarioSistema, u.ImagenPerfil, m.mensaje, m.IdUsuarioEmisor,m.FechaMensaje, row_Number() over(partition by u.UsuarioSistema order by m.FechaMensaje desc) as row
            from TMensaje as m, TUsuario as u where(IdUsuarioEmisor = @LoginUser and IdUsuarioReceptor = u.IdUsuario)
            or(IdUsuarioEmisor = u.IdUsuario and IdUsuarioReceptor = @LoginUser))
            select c.UsuarioSistema as [Usuario], c.ImagenPerfil as [Perfil],
            c.mensaje as [Mensaje], c.IdUsuarioEmisor as [Emisor]
            from cte c where row = 1 order by c.FechaMensaje desc; ";
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@LoginUser", Form1.IdUsuario));
            var tabla = ExecuteReader(comando);
            var ListaUsrMje = new List<DataMensajes>();
            foreach(DataRow item in tabla.Rows)
            {
                ListaUsrMje.Add(new DataMensajes
                {
                    NombreUsuario = item[0].ToString(),
                    Perfil = (byte[])item[1],
                    Mensaje = item[2].ToString(),
                    IdUsuarioEmisor = item[3].ToString()
                });
            }
            return ListaUsrMje;
        }
        public List<DataMensajes> MsgConUsr(string Usr) 
        {
            string comando = @"select*from TMensaje where (IdUsuarioEmisor=@LoginUser and IdUsuarioReceptor=(select IdUsuario from TUsuario where UsuarioSistema=@Usuario)) 
            or (IdUsuarioReceptor=@LoginUser and IdUsuarioEmisor= (select IdUsuario from TUsuario where UsuarioSistema=@Usuario))";

            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@LoginUser", Form1.IdUsuario));
            parametros.Add(new SqlParameter("@Usuario", Usr));
            var tabla = ExecuteReader(comando);
            var MensajesConUsr = new List<DataMensajes>();
            foreach(DataRow item in tabla.Rows)
            {
                MensajesConUsr.Add(new DataMensajes
                {
                    IdUsuarioEmisor = item[0].ToString(),
                    Mensaje = item[2].ToString()
                });
            }
            return MensajesConUsr;
        }

    }   
}
