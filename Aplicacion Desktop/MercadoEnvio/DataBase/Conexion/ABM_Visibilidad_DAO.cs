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
    class ABM_Visibilidad_DAO : GDAA_DAO
    {
        public ABM_Visibilidad_DAO()
        {
            this.iniciar();
        }

        public List<string> get_descVisibilidad()
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

        public void setearVisibilidad(String desc_tipo, String desc_precio, String desc_porcentaje, String desc_porcentaje_envio)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("INSERT INTO " + ConstantesBD.tabla_visibilidad + " (desc_codigo, desc_tipo, desc_precio, desc_porcentaje, desc_porcentaje_envio) VALUES (" + "1010 , '"
                                                                                                                                                                                                          + desc_tipo + "', " 
                                                                                                                                                                                                          + desc_precio + ", " 
                                                                                                                                                                                                          + desc_porcentaje + ", " 
                                                                                                                                                                                                          + desc_porcentaje_envio + ")");
        }

        public int getIdVisibilidad(String desc_tipo)
        {
            int id = 0;
            SqlDataReader num_visibilidad = this.GD1C2016.ejecutarSentenciaConRetorno("select id_visibilidad from " + ConstantesBD.tabla_visibilidad + " where desc_tipo = '" + desc_tipo + "'");

            if (num_visibilidad.Read())
                id = (int)num_visibilidad[0];
            num_visibilidad.Close();

            return id;
        }

        public void borrarVisibilidad(int id_visibilidad)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("DELETE FROM " + ConstantesBD.tabla_visibilidad + " WHERE id_visibilidad = " + id_visibilidad);
        }

        public void updateVisibilidad(int id_visibilidad, String desc_tipo, String desc_precio, String desc_porcentaje, String desc_porcentaje_envio)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("UPDATE " + ConstantesBD.tabla_visibilidad + " SET desc_tipo = '" + desc_tipo + "'" +
                                                                                                   ", desc_precio = " + desc_precio +
                                                                                                   ", desc_porcentaje = " + desc_porcentaje +
                                                                                                   ", desc_porcentaje_envio = " + desc_porcentaje_envio +
                                                                                                   " WHERE id_visibilidad = " + id_visibilidad);
        }
    }
}
