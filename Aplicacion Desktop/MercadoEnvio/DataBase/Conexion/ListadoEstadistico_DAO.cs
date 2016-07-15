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
            resultado = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT TOP 5 us.desc_username, pu.fecha_publicacion, pu.desc_tipo, SUM(pu.desc_stock) as Cantidad FROM " 
                                                                    + ConstantesBD.vista_publicaciones + " pu left join "
                                                                    + ConstantesBD.tabla_usuarios + " us on pu.id_usuario = us.id_usuario "
                                                                    + "WHERE desc_estado = 'Activo' " + condicion 
                                                                    + " GROUP BY us.desc_username, pu.fecha_publicacion, pu.desc_tipo " 
                                                                    + "ORDER BY pu.fecha_publicacion, pu.desc_tipo");

           return resultado;
        }

        public SqlDataReader getListClientesMayorCantProdComp(string condicion)
        {
            SqlDataReader resultado;
            resultado = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT TOP 5 us.desc_username, co.desc_fecha, sum(co.desc_cantidad) as Cantidad, ru.desc_rubro as desc_rubro from "
                                                                   + ConstantesBD.tabla_compras + " co inner join "
                                                                   + ConstantesBD.tabla_publicaciones + " pu on co.id_publicacion = pu.id_publicacion inner join " 
                                                                   + ConstantesBD.tabla_rubro + " ru on pu.id_rubro = ru.id_rubro inner join "
                                                                   + ConstantesBD.tabla_usuarios + " us on co.id_usuario = us.id_usuario where " 
                                                                   + condicion
                                                                   + " group by us.desc_username, co.desc_fecha, ru.desc_rubro"
                                                                   + " ORDER BY sum(co.desc_cantidad) desc");
            return resultado;
        }

        public List<string> get_anios()
        {
            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT distinct YEAR(desc_fecha) as ANIOS FROM " + ConstantesBD.tabla_compras);
            List<string> resultado = new List<string>();
            
            while (lector.Read())
            {
                resultado.Add(lector["ANIOS"].ToString());
            }
            lector.Close();
            return resultado;
        }

        public SqlDataReader getListVendMayorCantFacturas(string condicion)
        {
            SqlDataReader resultado;
            resultado = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT TOP 5 us.desc_username, fa.desc_fecha, count(fa.id_factura) Cantidad FROM "
                                                                    + ConstantesBD.tabla_facturas + " fa"
                                                                    + " inner join " + ConstantesBD.tabla_usuarios + " us"
                                                                    + " on fa.id_usuario = us.id_usuario"
                                                                    + " WHERE " + condicion
                                                                    + " GROUP BY us.desc_username, fa.desc_fecha"
                                                                    + " ORDER BY count(fa.id_factura) desc");

            return resultado;
        }

       
        public SqlDataReader getListVendMayorMontoFactutado(string condicion)
        {
            SqlDataReader resultado;
            resultado = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT TOP 5 us.desc_username, fa.desc_fecha, SUM(fa.desc_total) Cantidad FROM "
                                                                    + ConstantesBD.tabla_facturas + " fa"
                                                                    + " inner join " + ConstantesBD.tabla_usuarios + " us"
                                                                    + " on fa.id_usuario = us.id_usuario"
                                                                    + " WHERE " + condicion
                                                                    + " GROUP BY us.desc_username, fa.desc_fecha"
                                                                    + " ORDER BY SUM(fa.desc_total) desc");

            return resultado;
        }




    }

}