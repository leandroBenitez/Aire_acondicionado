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
        public void setearCliente(String username, String password, String rol, String desc_Apellido, String desc_Nombre, String desc_Dni, String tipo_doc, String desc_Mail, String desc_Dom_Calle, String desc_Nro_Calle, String desc_Piso, String desc_Depto, String desc_Localidad, String desc_Cod_Postal, String desc_Telefono, String desc_fecha_nac, String desc_fecha_creacion)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("EXECUTE GESTORES_DEL_AIRE_ACONDICIONADO.crear_usuario_cliente    @username = '" + username
                                                                                                                  + "', @password = '" + password
                                                                                                                  + "', @rol = '" + rol
                                                                                                                  + "', @desc_Apellido = '" + desc_Apellido 
                                                                                                                  + "', @desc_Nombre = '" + desc_Nombre
                                                                                                                  + "', @desc_tipo_doc = '" + tipo_doc
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
                                                                                                                  + "', @desc_fecha_creacion = '" + desc_fecha_creacion
                                                                                                                  + "'");
        }

        /* INSERTO LA EMPRESA */
        public void setearEmpresa(String username, String password, String rol, String razon_social, String mail, String telefono, String fecha_creacion, String dom_calle, String nro_calle, String piso, String depto, String localidad, String cp, String ciudad, String cuit, String rubro)
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
                                                                                                                  + "', @desc_rubro = '" + rubro
                                                                                                                  + "'");
        }

        /* BUSCO CLIENTE POR FILTROS INGRESADOS */
        public List<SqlDataReader> buscarCliente(List<String> filtros)
        {
            SqlDataReader clientes = this.GD1C2016.ejecutarSentenciaConRetorno("select * from GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario as u inner join GESTORES_DEL_AIRE_ACONDICIONADO.lk_cliente as c on u.id_usuario = c.id_usuario where " + filtros[0] +
                                                                                                                                                                                                                                         " and " + filtros[1] +
                                                                                                                                                                                                                                         " and " + filtros[2] +
                                                                                                                                                                                                                                         " and " + filtros[3] +
                                                                                                                                                                                                                                         " and " + filtros[4] + ";");
            List<SqlDataReader> listaReturn = new List<SqlDataReader>();
            listaReturn.Add(clientes);

            return listaReturn;
        }

        /* BUSCO EMPRESA POR FILTROS INGRESADOS */
        public List<SqlDataReader> buscarEmpresa(List<String> filtros)
        {
            SqlDataReader empresas = this.GD1C2016.ejecutarSentenciaConRetorno("select * from GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario as u inner join GESTORES_DEL_AIRE_ACONDICIONADO.lk_empresa as e on u.id_usuario = e.id_usuario where " + filtros[0] +
                                                                                                                                                                                                                                        " and " + filtros[1] +
                                                                                                                                                                                                                                        " and " + filtros[2] + ";");
            List<SqlDataReader> listaReturn = new List<SqlDataReader>();
            listaReturn.Add(empresas);

            return listaReturn;
        }
        
        /* OBTENGO LA DESCRIPCION DE UN ROL SEGUN ID*/
        public String getDescRol(String id_rol)
        {
            SqlDataReader descripcionRol = this.GD1C2016.ejecutarSentenciaConRetorno("Select [desc_rol] from [GESTORES_DEL_AIRE_ACONDICIONADO].[dm_rol] where id_rol = '" + id_rol + "';");
            String rol = descripcionRol["desc_rol"].ToString();

            descripcionRol.Close();
            return rol;
        }

        /*OBTENGO USERNAME DE CLIENTE - Probar*/
        public String getUsername(String id_username)
        {
            SqlDataReader username = this.GD1C2016.ejecutarSentenciaConRetorno("Select desc_username from GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario where id_usuario = '" + id_username + "';");


            if (username.HasRows)
            {
                //while (username.Read())
                //{
                    username.Read();
                    String user = username["desc_username"].ToString();
                    username.Close();
                    return user;
                //}
            }
            else
            {
                username.Close();
                return "szd";
            }
        }

        /* OBTENGO ID DE ROL SEGUN UN ID DE USUARIO - Porbar*/
        public String getIdRolPorIdUser(String id_usuario)
        {
            MessageBox.Show(id_usuario);
            SqlDataReader id_rol = this.GD1C2016.ejecutarSentenciaConRetorno("select id_rol from GESTORES_DEL_AIRE_ACONDICIONADO.rl_roles_usuarios where id_usuario = '" + id_usuario + "';");
            
            String user = id_rol["id_rol"].ToString();
            id_rol.Close();
            return user;
        }

        /* ACTUALIZO EMPRESA - OK*/
        public void actualizarEmpresa(String razonSoc, String descMail, String descTelefono, String descCalle, String nroCalle, String depto, String localidad, String codPos, String ciudad, String cuit, String nombreContacto, String descRubro, String idUsuario)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("update GESTORES_DEL_AIRE_ACONDICIONADO.lk_empresa set desc_Razon_Social = '" + razonSoc 
	                                                                                                           + "', desc_Mail = '" + descMail
	                                                                                 + "',desc_Telefono = Convert(numeric(10,0), '" + descTelefono + "')"                 
                                                                                                             +",desc_Dom_Calle = '" + descCalle 
	                                                                                 +"',desc_Nro_Calle = Convert(numeric(10,0), '" + nroCalle + "')"
	                                                                                                             +",desc_Depto = '" + depto
	                                                                                                        +"',desc_Localidad = '" + localidad
	                                                                                                       +"',desc_Cod_Postal = '" + codPos
	                                                                                                           +"',desc_Ciudad = '" + ciudad
	                                                                                                             +"',desc_Cuit = '" + cuit
	                                                                                                  +"',desc_nombre_contacto = '" + nombreContacto
	                                                                                                              +"',desc_rubro = '" + descRubro
	                                                                                                       +"'where id_usuario = '" + idUsuario + "';");
            MessageBox.Show("La empresa ha sido modificada Satisfactoriamente");
        }

        /* ACTUALIZO CLIENTE - OK*/
        public void actualizarCliente(String idCliente, String nombre, String apellido, String dni, String tipoDoc, String mail, String telefono, String direccion, String nro, String piso, String depto, String localidad, String codPos, String fechaNac, String fechaCreacion)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("update GESTORES_DEL_AIRE_ACONDICIONADO.lk_cliente set desc_nombre = '" + nombre              
                                                                                                       +"',desc_Apellido = '" + apellido 
	                                                                                 +"',desc_DNI = Convert(numeric(10,0), '" + dni + "')"
	                                                                                                    +",desc_tipo_doc = '" + tipoDoc
	                                                                                                       +"',desc_Mail = '" + mail
                                                                                +"',desc_Telefono = Convert(numeric(10,0), '" + telefono + "')"
	                                                                                                  +",desc_Dom_Calle =  '" + direccion
	                                                                           +"',desc_Nro_Calle=  Convert(numeric(10,0), '" + nro + "')"
                                                                                    +",desc_Piso =  Convert(numeric(10,0), '" + piso + "')"
	                                                                                                       +",desc_Depto = '" + depto
	                                                                                                  +"',desc_Localidad = '" + localidad
	                                                                                                +"',desc_Cod_Postal = '" + codPos
                                                                                    +"',desc_Fecha_Nac = Convert(datetime, '" + fechaNac + "')"
                                                                                +",desc_Fecha_Creacion = Convert(datetime, '" + fechaCreacion + "')"
                                                                                                     + "where id_usuario = '" + idCliente + "'");
            MessageBox.Show("El cliente ha sido modificado Satisfactoriamente");
        }

        /* DESHABILITAR USUARIO - OK*/
        public void deshabilitarUsuario(String id_usuario)
        {
           this.GD1C2016.ejecutarSentenciaSinRetorno("update GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario set id_estado = '2' where id_usuario = '" + id_usuario + "';");
        }

        /* HABILITAR USUARIO - OK */
        public void habilitarUsuario(String id_usuario)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("update GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario set id_estado = '1' where id_usuario = '" + id_usuario + "';");
        }

        /* OBTENGO ID_USUARIO SEGUN USERNAME - Probar */
        public String getId(String desc_usuario)
        {
            SqlDataReader id_usuario = this.GD1C2016.ejecutarSentenciaConRetorno("select id_usuario from GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario where desc_username = '" + desc_usuario + "'");
            if (id_usuario.HasRows)
            {
                id_usuario.Read();

                String user = id_usuario["id_usuario"].ToString();
                id_usuario.Close();
                return user;
            }
            else
            {
                return "ok";
            }

        }
                  
        /* OBTENER ESTADO USUARIO POR ID_USUARIO ( 1 - HABILITADO, 2 - DESHABILITADO ) - OK */                                                                                                                                                                               
        public String getEstadoUsuario(String id_usuario)
        {
            SqlDataReader estado = this.GD1C2016.ejecutarSentenciaConRetorno("select id_estado from GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario where id_usuario = '" + id_usuario + "';");
            
            estado.Read();
            String est = estado["id_estado"].ToString();
            estado.Close();
            return est;
        }
    }
}
