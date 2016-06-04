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
    class HistorialCompras_DAO : GDAA_DAO
    { 
        public HistorialCompras_DAO()
        {
            this.iniciar();
        }

        public SqlDataReader get_compras()
        {
            /*  public List<string> get_compras()
            * {
            * SqlDataReader compras= this.GD1C2016.ejecutarSentenciaConRetorno("Select id_compra from GESTORES_DEL_AIRE_ACONDICIONADO.ft_compra");
            * List<string> compras_string = new List<string>();
            *
            *while (compras.Read())
            * {
                 compras_string.Add(compras["id_compra"].ToString());
            * }

             *compras.Close();
             return compras_string;
             * */
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select * from" + ConstantesBD.tabla_compras);

            return resultado;

        }





   }

}