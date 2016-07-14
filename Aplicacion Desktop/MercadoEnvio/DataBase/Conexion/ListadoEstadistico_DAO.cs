using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Excepciones;
using MercadoEnvio.Conexion;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MercadoEnvio.DataBase.Conexion
{
    class ListadoEstadistico_DAO : GDAA_DAO
    {
        public ListadoEstadistico_DAO()
        {
            this.iniciar();
        }

        public List<string> get_idVisibilidad()
        {
            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT id_visibilidad FROM " + ConstantesBD.tabla_visibilidad );

            List<string> resultado = new List<string>();
            while (lector.Read())
            {
                resultado.Add(lector["id_visibilidad"].ToString());
            }
            lector.Close();
            return resultado;
        }

        public SqlDataReader getListVendMayorCantProdNoVend(string condicion)/*5 vendedores con mayor cantidad de productos no vendidos (1) */
        {
           SqlDataReader resultado;
           resultado = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT TOP 5 id_usuario, fecha_publicacion, COUNT(id_publicacion) Cantidad FROM GESTORES_DEL_AIRE_ACONDICIONADO.publicaciones WHERE desc_estado != 'Activo' "
                                                                    + condicion + " GROUP BY id_usuario, fecha_publicacion ORDER BY fecha_publicacion ");

           return resultado;
        }

        public SqlDataReader getListClientesMayorCantProdComp(string condicion)
        {
            SqlDataReader resultado;
            resultado = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT TOP 5 C.id_usuario, C.desc_fecha, C.desc_cantidad as Cantidad, R.desc_rubro as desc_rubro FROM GESTORES_DEL_AIRE_ACONDICIONADO.ft_compra C INNER JOIN GESTORES_DEL_AIRE_ACONDICIONADO.ft_publicacion P ON C.id_publicacion = P.id_publicacion INNER JOIN GESTORES_DEL_AIRE_ACONDICIONADO.dm_rubro R ON P.id_rubro = R.id_rubro WHERE " 
                                                                   + condicion + " ORDER BY MONTH(C.desc_fecha),YEAR(C.desc_fecha) ");
            return resultado;
        }



        public SqlDataReader getListVendMayorCantFacturas(string condicion)
        {
            SqlDataReader resultado;

            resultado = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT TOP 5 id_usuario, desc_fecha, COUNT(desc_total) Cantidad FROM GESTORES_DEL_AIRE_ACONDICIONADO.ft_factura WHERE " 
                                                                    + condicion + " GROUP BY id_usuario, desc_fecha ORDER BY MONTH(desc_fecha), YEAR(desc_fecha) ");

            return resultado;
        }

       
        public SqlDataReader getListVendMayorMontoFactutado(string condicion)
        {
            SqlDataReader resultado;

            resultado = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT TOP 5 id_usuario, desc_fecha, SUM(desc_total) Cantidad FROM GESTORES_DEL_AIRE_ACONDICIONADO.ft_factura WHERE "
                                                                    + condicion + " GROUP BY id_usuario, desc_fecha ORDER BY MONTH(desc_fecha), YEAR(desc_fecha) ");

            return resultado;
        }




    }

}