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
    class HistorialEstrellas_DAO : GDAA_DAO
    {
        public HistorialEstrellas_DAO()
        {
            this.iniciar();
        }

        public SqlDataReader get_comprasCalificadas(int id_usuario)//Compras calificadas por el comprador
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT * FROM " + ConstantesBD.tabla_calificacion
                                                                                    + " WHERE desc_cantidad_estrellas > '0' and id_usuario_comprador = '" + id_usuario.ToString() + "'");

            return resultado;

        }

        
        public SqlDataReader get_comprasSinCalificar(int id_usuario) // Compras sin calificar por el comprador
        {
            
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT * FROM " + ConstantesBD.tabla_calificacion
                                                                                    + " WHERE desc_cantidad_estrellas = '0' and id_usuario_comprador = '" + id_usuario.ToString() + "'");

            return resultado;
        }

        public SqlDataReader get_calificacionesRecibidas(int id_usuario)//Las calificaciones las que recibe el vendedor
        { 
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT id_calificacion, desc_codigo, desc_cantidad_estrellas, id_usuario_vendedor, id_compra, id_subasta " + ConstantesBD.tabla_calificacion
                                                                                    + " WHERE desc_cantidad_estrellasn  > '0' and id_usuario_vendedor = '" + id_usuario.ToString() + "'");

            return resultado;
        }


        public int obtenerTotalRegistros(int id_usuario)
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select Count(1) as CONTADOR from " + ConstantesBD.tabla_calificacion
                                                                                    + " where id_usuario_comprador = '" + id_usuario.ToString() + "'");
            resultado.Read();
            int cantidad;
            int.TryParse(resultado["CONTADOR"].ToString(), out cantidad);
            resultado.Close();
            return cantidad;
        }

        public int obtenerTotalRegistrosVendedor(int id_usuario)
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select Count(1) as CONTADOR from " + ConstantesBD.tabla_calificacion
                                                                                    + " where id_usuario_vendedor = '" + id_usuario.ToString() + "'");
            resultado.Read();
            int cantidad;
            int.TryParse(resultado["CONTADOR"].ToString(), out cantidad);
            resultado.Close();
            return cantidad;
        }

    }
}
