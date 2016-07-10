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

        public List<string> getCompras(string comprador)
        {
            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT co.id_compra from " + ConstantesBD.tabla_compras + " AS co" +
                                                                             " LEFT JOIN " + ConstantesBD.tabla_calificacion + " AS ca" +
                                                                             " ON co.id_compra = ca.id_compra WHERE ca.id_compra IS NULL AND co.id_usuario = " +
                                                                             comprador);
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["id_compra"].ToString());
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

        public int getVendedor(int id_compra)
        {
            int id = 0;
            SqlDataReader num_rol = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT pu.id_usuario FROM " + ConstantesBD.tabla_publicaciones + " pu" +
                                                                               " JOIN " + ConstantesBD.tabla_compras + " co" +
                                                                               " ON co.id_compra = " + id_compra +
                                                                               " AND co.id_publicacion = pu.id_publicacion");

            if (num_rol.Read())
                id = (int)num_rol[0];
            num_rol.Close();

            return id;
        }

        public void calificarA(int pubCalif, int estrellas, int vendedorCalif, int compradorCalif, string descripcion)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("INSERT INTO " + ConstantesBD.tabla_calificacion + " (desc_codigo, desc_cantidad_estrellas, id_usuario_vendedor, id_usuario_comprador, id_compra, descripcion) " +
                                                      "Values ("
                                                      + pubCalif + ", "
                                                      + estrellas + ", "
                                                      + vendedorCalif + ", "
                                                      + compradorCalif + ", "
                                                      + pubCalif + ", "
                                                      + descripcion + ")");
        }
    }
}
