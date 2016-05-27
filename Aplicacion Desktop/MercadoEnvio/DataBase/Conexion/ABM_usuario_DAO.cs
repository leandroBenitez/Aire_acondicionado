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
                usuarioExistente.Close();
                return 0;
            }
            else
            {
                usuarioExistente.Close();
                return 1;
            }
        }

        /* VALIDO SI EL DNI INGRESADO EXISTE EN LA BASE DE DATOS - DEVUELVE 1 SI NO EXISTE */
        public int validarDNIExistente(String DNI)
        {
            SqlDataReader dniExistente = this.GD1C2016.ejecutarSentenciaConRetorno("select 1 from GESTORES_DEL_AIRE_ACONDICIONADO.lk_cliente where desc_Dni = Convert(numeric(18,0),'" + DNI + "');");
            if (dniExistente.HasRows)
            {
                dniExistente.Close();
                return 0;
            }
            else
            {
                dniExistente.Close();
                return 1;
            }
        }

        /* VALIDO SI LA RAZON SOCIAL INGRESADA EXISTE EN LA BASE DE DATOS - DEVUELVE 1 SI NO EXISTE */
        public int validarRazSocExistente(String razSoc)
        {
            SqlDataReader razSocExistente = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT 'EXISTE' from GESTORES_DEL_AIRE_ACONDICIONADO.lk_empresa where desc_Razon_Social = 'Razon Social Nº:" +razSoc+ "'");
            if (razSocExistente.HasRows)
            {
                razSocExistente.Close();
                return 0;
            }
            else
            {
                razSocExistente.Close();
                return 1;
            }
        }

        public int validarCuitExistente(String cuit)
        {
            SqlDataReader cuitExistente = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT 'EXISTE' from GESTORES_DEL_AIRE_ACONDICIONADO.lk_empresa where desc_Cuit = '" + cuit + "';");
            if (cuitExistente.HasRows)
            {
                cuitExistente.Close();
                return 0;
            }
            else
            {
                cuitExistente.Close();
                return 1;
            }
        }

        /* INSERTO EL CLIENTE */
        public void setearCliente(String username, String password, String rol, String desc_Apellido, String desc_Nombre, String desc_Dni, String desc_Mail, String desc_Dom_Calle, String desc_Nro_Calle, String desc_Piso, String desc_Depto, String desc_Localidad, String desc_Cod_Postal, String desc_Telefono, String desc_fecha_nac)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("EXECUTE GESTORES_DEL_AIRE_ACONDICIONADO.crear_usuario_cliente    @username = '" + username
                                                                                                                  + "', @password = '" + password
                                                                                                                  + "', @rol = '" + rol
                                                                                                                  + "', @desc_Apellido = '" + desc_Apellido 
                                                                                                                  + "', @desc_Nombre = '" + desc_Nombre
                                                                                                                  + "', @desc_Dni = '" + desc_Dni
                                                                                                                  + "', @desc_Mail = '" + desc_Mail
                                                                                                                  + "', @desc_Dom_Calle = '" + desc_Dom_Calle
                                                                                                                  + "', @desc_Nro_Calle = '" + desc_Nro_Calle
                                                                                                                  + "', @desc_Piso = '" + desc_Piso
                                                                                                                  + "', @desc_Depto = '" + desc_Depto
                                                                                                                  + "', @desc_Localidad = '" + desc_Localidad
                                                                                                                  + "', @desc_Cod_Postal = '" + desc_Cod_Postal
                                                                                                                  + "', @desc_Telefono = '" + desc_Telefono
                                                                                                                  + "', @desc_Fecha_Nac = '" + desc_fecha_nac 
                                                                                                                  + "'");
        }

        /* INSERTO LA EMPRESA */
        public void setearEmpresa(String username, String password, String rol, String razon_social, String mail, String telefono, String fecha_creacion, String dom_calle, String nro_calle, String piso, String depto, String localidad, String cp, String ciudad, String cuit)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("EXECUTE GESTORES_DEL_AIRE_ACONDICIONADO.crear_usuario_empresa    @username = '" + username
                                                                                                                  + "', @password = '" + password
                                                                                                                  + "', @rol = '" + rol
                                                                                                                  + "', @desc_razon_social = '" + razon_social
                                                                                                                  + "', @desc_Mail = '" + mail
                                                                                                                  + "', @desc_Telefono = '" + telefono
                                                                                                                  + "', @desc_Fecha_Creacion = '" + fecha_creacion
                                                                                                                  + "', @desc_Dom_Calle = '" + dom_calle
                                                                                                                  + "', @desc_Nro_Calle = '" + nro_calle
                                                                                                                  + "', @desc_Piso = '" + piso
                                                                                                                  + "', @desc_Depto = '" + depto
                                                                                                                  + "', @desc_Localidad = '" + localidad
                                                                                                                  + "', @desc_Cod_Postal = '" + cp
                                                                                                                  + "', @desc_ciudad = '" + ciudad
                                                                                                                  + "', @desc_cuit = '" + cuit
                                                                                                                  + "'");
        }


    }
}
