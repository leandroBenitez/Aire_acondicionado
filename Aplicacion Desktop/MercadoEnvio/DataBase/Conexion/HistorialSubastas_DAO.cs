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
    class HistorialSubastas_DAO : GDAA_DAO
    {

        public HistorialSubastas_DAO()
        {
            this.iniciar();        
        }

        public SqlDataReader get_subastas(int id_usuario)
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select * from " + ConstantesBD.tabla_subastas
                                                                                    + " where id_usuario = '" + id_usuario.ToString() + "'");

            return resultado;
        }


        public int obtenerTotalRegistros(int id_usuario)
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select Count(1) as CONTADOR from " + ConstantesBD.tabla_facturas
                                                                                    + " where id_usuario = '" + id_usuario.ToString() + "'");
            resultado.Read();
            int cantidad;
            int.TryParse(resultado["CONTADOR"].ToString(), out cantidad);
            resultado.Close();
            return cantidad;
        }

    }
}
