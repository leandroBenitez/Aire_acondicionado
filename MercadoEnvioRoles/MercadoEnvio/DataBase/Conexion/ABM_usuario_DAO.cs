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
    class ABM_usuario_DAO : GDAA_DAO
    {
        public ABM_usuario_DAO()
        {
            this.iniciar();
        }

        /* VALIDO SI EL NOMBRE DE USUARIO INGRESADO EXISTE EN LA BASE DE DATOS - DEVUELVE 1 SI NO EXISTE */
        public int validarUsuarioExistente(String desc_usuario)
        {
            SqlDataReader usuarioExistente = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT 1 FROM GESTORES_DEL_AIRE_ACONDICIONADO.lk_cliente c INNER JOIN GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario u ON c.id_usuario = u.id_usuario WHERE u.desc_username = '" + desc_usuario + "';");

            if (usuarioExistente.HasRows)
            {
                MessageBox.Show("EL NOMBRE DE USUARIO YA EXISTE, ELIJA OTRO POR FAVOR");
                return 0;
            }else
            return 1;
        }

        /* INSERTO EL CLIENTE */
        public void setearCliente(String id_usuario ,String desc_Apellido ,String desc_Nombre ,int desc_Dni ,String desc_Mail ,String desc_Dom_Calle , int desc_Nro_Calle ,int desc_Piso ,String desc_Depto ,String desc_Localidad ,String desc_Cod_Postal ,int desc_Telefono , DateTime desc_Fecha_Nac)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("	EXECUTE GESTORES_DEL_AIRE_ACONDICIONADO.crear_cliente '" + id_usuario + "' , '" + desc_Apellido + "' ,'" + desc_Nombre + "' , " + desc_Dni + " , '" + desc_Mail + "' , '" + desc_Dom_Calle + "', " + desc_Nro_Calle + ", " + desc_Piso + ",'" + desc_Depto + "' , '" + desc_Localidad + "',  '" + desc_Cod_Postal + "' ," + desc_Telefono + ", " + desc_Fecha_Nac + ";");
        }
    }


}
