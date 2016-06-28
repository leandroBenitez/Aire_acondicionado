using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Excepciones;
using MercadoEnvio.Conexion;
using System.Data.SqlClient;
using System.Windows.Forms;
using MercadoEnvio.DataBase.Conexion;

namespace MercadoEnvio.DataBase.Conexion
{
    class Calificar_DAO : GDAA_DAO
    {
        public Calificar_DAO()
        {
            this.iniciar();
        }

        public List<string> getCalificaciones(string id_user)
        {
            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT desc_tipo from " + ConstantesBD.tabla_visibilidad);
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["desc_tipo"].ToString());
            }

            lector.Close();
            return resultado;
        }
    }
}
