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
    class ABM_Factura_DAO : GDAA_DAO
    {
        public ABM_Factura_DAO()
        {
            this.iniciar();
        }

        /* BUSCO FACTURAS POR FILTROS INGRESADOS */
        public List<SqlDataReader> buscarFactura(List<String> filtros)
        {
            MessageBox.Show("SELECT * FROM GESTORES_DEL_AIRE_ACONDICIONADO.ft_factura WHERE " + filtros[0] +
                                                                                                                                         " and " + filtros[1] +
                                                                                                                                         " and " + filtros[2] +
                                                                                                                                         " and " + filtros[3] + ";");
            SqlDataReader facturas = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT * FROM GESTORES_DEL_AIRE_ACONDICIONADO.ft_factura WHERE " + filtros[0] +
                                                                                                                                         " and " + filtros[1] +
                                                                                                                                         " and " + filtros[2] +
                                                                                                                                         " and " + filtros[3] + ";");
            List<SqlDataReader> listaReturn = new List<SqlDataReader>();
            listaReturn.Add(facturas);

            return listaReturn;
        }
    }
}
