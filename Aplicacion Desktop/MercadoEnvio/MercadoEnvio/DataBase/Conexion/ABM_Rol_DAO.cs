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
    class ABM_Rol_DAO : GDAA_DAO
    {
        public ABM_Rol_DAO()
        {
            this.iniciar();
        }

        public List<string> get_funciones()
        {
            SqlDataReader funciones = this.GD1C2016.ejecutarSentenciaConRetorno("Select [desc_funcion] from [GESTORES_DEL_AIRE_ACONDICIONADO].[dm_funcion]");
            List<string> funciones_string = new List<string>();

            while (funciones.Read())
            {
                funciones_string.Add(funciones["desc_funcion"].ToString());
            }

            funciones.Close();
            return funciones_string;
        }

        protected void lanzarExcepcion(String mensajeError, SqlDataReader lector)
        {
            lector.Close();
            throw new ValidacionErroneaUsuarioException(mensajeError);
        }
    }
}
