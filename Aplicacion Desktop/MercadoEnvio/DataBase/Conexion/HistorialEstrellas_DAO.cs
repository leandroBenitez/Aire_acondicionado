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

        public SqlDataReader get_comprasCalificadas(int id_usuario)//FALTA FILTRAR
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select * from " + ConstantesBD.tabla_subastas
                                                                                    + " where id_usuario = '" + id_usuario.ToString() + "'");

            return resultado;

        }


        public SqlDataReader get_comprasSinCalificar(int id_usuario) //FALTA FILTRAR
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select * from " + ConstantesBD.tabla_subastas
                                                                                    + " where id_usuario = '" + id_usuario.ToString() + "'");

            return resultado;
        }


    }
}
