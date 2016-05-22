using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Excepciones;
using MercadoEnvio.Conexion;
using System.Data.SqlClient;

namespace MercadoEnvio.DataBase.Conexion
{
    class LoginDAO : GDAA_DAO
    {
        public LoginDAO()
        {
            this.iniciar();
        }

        public List<string> get_roles()
        {
            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("Select desc_rol from " + ConstantesBD.tabla_roles);
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["desc_rol"].ToString());
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
