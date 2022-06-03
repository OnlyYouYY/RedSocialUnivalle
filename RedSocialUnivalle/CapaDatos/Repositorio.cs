using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialUnivalle.CapaDatos
{
    public abstract class Repositorio
    {
        private readonly string CadenaConexion;
        public Repositorio()
        {
            CadenaConexion = "Data Source=-VITANOVA-;Initial Catalog=RedSocialUnivalle;Integrated Security=True";
        }
        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
