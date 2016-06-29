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

        public List<string> getCompras(string id_user)
        {
            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT id_publicacion from " + ConstantesBD.tabla_compras +
                                                                             " WHERE id_usuario = " + id_user);
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["id_publicacion"].ToString());
            }

            lector.Close();
            return resultado;
        }
        public int getCalificacion(int id_user, string id_pub)
        {
            try
            {
                int id = 0;
                SqlDataReader num_rol = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT desc_cantidad_estrellas FROM " + ConstantesBD.tabla_calificacion +
                                                                                   " WHERE id_publicacion = " + id_pub +
                                                                                   " AND id_usuario = " + id_user);

                if (num_rol.Read())
                    id = (int)num_rol[0];
                num_rol.Close();

                return id;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int getVendedor(int id_pub)
        {
            int id = 0;
            SqlDataReader num_rol = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT id_usuario FROM " + ConstantesBD.tabla_publicaciones +
                                                                               " WHERE id_publicacion = " + id_pub);

            if (num_rol.Read())
                id = (int)num_rol[0];
            num_rol.Close();

            return id;
        }
    }
}
