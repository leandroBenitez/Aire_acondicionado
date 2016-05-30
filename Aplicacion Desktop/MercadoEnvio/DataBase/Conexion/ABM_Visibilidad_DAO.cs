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

        public List<string> getIdVisibilidad(String desc_tipo, String desc_precio, String desc_porcentaje, String desc_porcentaje_envio)
        {
            if (desc_tipo != "" || desc_tipo != " ")
            {
                desc_tipo = "desc_tipo LIKE '%" + desc_tipo + "%' AND ";
            }
            if (desc_precio != "" || desc_precio != " ")
            {
                desc_precio = "desc_precio LIKE '%" + desc_precio + "%' AND ";
            }
            if (desc_porcentaje != "" || desc_porcentaje != " ")
            {
                desc_porcentaje = " desc_porcentaje LIKE '%" + desc_porcentaje + "%' AND ";
            }
            if (desc_porcentaje_envio != "" || desc_porcentaje_envio != " ")
            {
                desc_porcentaje_envio = " desc_porcentaje_envio LIKE '%" + desc_porcentaje_envio + "%'";

            }

            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT id_visibilidad FROM " + ConstantesBD.tabla_visibilidad + 
                                                                             " WHERE " + desc_tipo + desc_precio + desc_porcentaje + desc_porcentaje_envio);
                                        
            List<string> resultado = new List<string>();


            while (lector.Read())
            {
                resultado.Add(lector["id_visibilidad"].ToString());
            }

            lector.Close();
            return resultado;
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

        public Boolean validar(String desc_tipo, String desc_precio, String desc_porcentaje, String desc_porcentaje_envio)
        {
            if (errorTipo(desc_tipo))
            {
                MessageBox.Show("El nuevo Rol debe tener un nombre");

                return false;
            }
            if (errorPrecio(desc_precio))
            {
                MessageBox.Show("Precio no valido");

                return false;
            }
            if (errorPrecio(desc_porcentaje))
            {
                MessageBox.Show("Porcentaje no valido");

                return false;
            }
            if (errorPrecio(desc_porcentaje_envio))
            {
                MessageBox.Show("Envio no valido");

                return false;
            }

            return true;
        }

        private Boolean errorTipo(String desc_tipo)
        {
            return (desc_tipo == "") || (desc_tipo == " ");
        }

        private Boolean errorPrecio(String desc_precio)
        {
            
            if (((desc_precio == "") || (desc_precio == " ")))
            {
                return true;
            }

            return precioMayor(desc_precio);
        }

        private Boolean precioMayor(String desc_precio)
        {
            float precio;
            Boolean esPrecio = float.TryParse(desc_precio, out precio);

            if (esPrecio)
            {
                return (precio < 0);
            }

            return true;
        }
    }
}
