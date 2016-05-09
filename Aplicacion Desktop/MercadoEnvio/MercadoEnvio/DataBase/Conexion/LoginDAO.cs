using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Excepciones;
using MercadoEnvio.Conexion;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace MercadoEnvio.DataBase.Conexion
{
    class LoginDAO : GDAA_DAO
    {
        public LoginDAO()
        {
            this.iniciar();
        }

        public List<string> consulta_de_prueba()
        {
            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("select distinct top 10 Publ_Cli_Nombre from gd_esquema.Maestra where Publ_Cli_Nombre is not null");
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["Publ_Cli_Nombre"].ToString());
            }

            lector.Close();
            return resultado;
        }

        protected void lanzarExcepcion(String mensajeError, SqlDataReader lector)
        {
            lector.Close();
            throw new ValidacionErroneaUsuarioException(mensajeError);
        }
    }
}
