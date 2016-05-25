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
                return 0;
            else
                return 1;
        }

        public int validarDNIExistente(int DNI)
        {
            MessageBox.Show("SQL DNI ENTRA");
            SqlDataReader dniExistente = this.GD1C2016.ejecutarSentenciaConRetorno("select 1 from GESTORES_DEL_AIRE_ACONDICIONADO.lk_cliente where desc_Dni = " + DNI + ";");
            MessageBox.Show("SQL DNI SALE");
            if (dniExistente.HasRows)
                return 0;
            else
                return 1;
        }


        /* INSERTO EL CLIENTE */
        public void setearCliente(String username,String password, String rol, String desc_Apellido ,String desc_Nombre ,int desc_Dni ,String desc_Mail ,String desc_Dom_Calle , int desc_Nro_Calle ,int desc_Piso ,String desc_Depto ,String desc_Localidad ,String desc_Cod_Postal ,int desc_Telefono)
        {
            MessageBox.Show("Entro al setear de la dao");
            this.GD1C2016.ejecutarSentenciaSinRetorno("EXECUTE GESTORES_DEL_AIRE_ACONDICIONADO.crear_usuario_cliente '"+ username + "', '" + password + "', '" + rol + "', '" + desc_Nombre + "' ,'" + desc_Apellido + "' , " + desc_Dni + " , '" + desc_Mail + "' , '" + desc_Dom_Calle + "', " + desc_Nro_Calle + ", " + desc_Piso + ",'" + desc_Depto + "' , '" + desc_Localidad + "',  '" + desc_Cod_Postal + "' ," + desc_Telefono);
                                                     //EXECUTE GESTORES_DEL_AIRE_ACONDICIONADO.crear_usuario_cliente    'USERKOLO'    ,     'USERKOLO'    ,  'Cliente'   ,        'Ernesto'      ,       'Paredes'        ,    1111111111    ,   'ernestoparedes'  ,          'dorrego'      ,           12          ,         1        ,      'lindo'        ,        'Chacarita'      ,           '9999'           ,          12345      ,          ''
        }



    }


}
