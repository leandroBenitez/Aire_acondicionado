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
            SqlDataReader facturas = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT * FROM GESTORES_DEL_AIRE_ACONDICIONADO.ft_factura WHERE " + filtros[0] +
                                                                                                                                         " and " + filtros[1] +
                                                                                                                                         " and " + filtros[2] +
                                                                                                                                         " and " + filtros[3] + ";");
            List<SqlDataReader> listaReturn = new List<SqlDataReader>();
            listaReturn.Add(facturas);
            

            return listaReturn;
        }

        /* OBTENGO TODOS LOS ID DE USUARIO TIRANDOLE UN LIKE A LA DESCRIPCIÓN EN LA TABLA USUARIO - PROBAR */
        public List<String> getUsuarioPorLikeDesc(String likeDescUser)
        {
            SqlDataReader usuarios = this.GD1C2016.ejecutarSentenciaConRetorno("select id_usuario from GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario where desc_username LIKE '%" +  likeDescUser + "%'");
            List<String> users = new List<String>();

            while (usuarios.Read())
            {
                users.Add(usuarios["id_usuario"].ToString());
            }

            usuarios.Close();

            return users;
        }

        /* OBTENGO LOS NUMERO DE FACTURA (ID_FACTURA) EN DONDE HAY ITEMS QUE CONTIENEN EL LIKEDESC*/
         public List<String> getFacturas(String likeDesc)
           {
            SqlDataReader facturas = this.GD1C2016.ejecutarSentenciaConRetorno("select id_factura from GESTORES_DEL_AIRE_ACONDICIONADO.ft_item where DESC_ITEM_DESC LIKE '%" + likeDesc + "%'");
            List<String> nros_fact = new List<String>();

            while (facturas.Read())
            {
                nros_fact.Add(facturas["id_factura"].ToString());
            }

            facturas.Close();
            return nros_fact;
        }
    }
}
