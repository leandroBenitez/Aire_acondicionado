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
    class LoginDAO : GDAA_DAO
    {
        public LoginDAO()
        {
            this.iniciar();
        }

        public List<string> get_roles(int id_usuario)
        {
            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("Select desc_rol from GESTORES_DEL_AIRE_ACONDICIONADO.rol_usuario where id_usuario = '" + 
                                                                                id_usuario.ToString() + "'");
            List<string> resultado = new List<string>();
            while (lector.Read())
            {
                resultado.Add(lector["desc_rol"].ToString());
            }
            lector.Close();
            return resultado;
        }

        public int calificaciones_pendientes(int id_usuario)
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select Count(1) as CANTIDAD from " + ConstantesBD.tabla_calificacion +
                                                                                    " where id_usuario_comprador = '" + id_usuario.ToString() +
                                                                                    "' and desc_cantidad_estrellas = 0");
            if (resultado.HasRows)
            {
                resultado.Read();
                int aux = Int32.Parse(resultado["CANTIDAD"].ToString());
                resultado.Close();
                return aux;
            }
            else
            {
                resultado.Close();
                return 0;
            }
        }

        public List<string> get_funcionalidades(string rol)
        {
            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("Select desc_funcion from GESTORES_DEL_AIRE_ACONDICIONADO.rol_funcionalidades where desc_rol = '" +
                                                                                rol + "'");
            List<string> resultado = new List<string>();
            while (lector.Read())
            {
                resultado.Add(lector["desc_funcion"].ToString());
            }
            lector.Close();
            return resultado;
        }

        public string validar_login(string username, string password)
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Execute GESTORES_DEL_AIRE_ACONDICIONADO.logearse @user = '" + username + 
                                                                                                                              "', @pass = '" + password + "'");
            resultado.Read();
            string aux = resultado["mensaje"].ToString();
            resultado.Close();
            return aux;
        }

        public void iniciar_aplicacion()
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("Execute GESTORES_DEL_AIRE_ACONDICIONADO.inicializar_modelo @fechasys = '" + ConstantesBD.fechaSistema + "';");
        }

        public int get_id_usuario(string username)
        {
            SqlDataReader usuario = this.GD1C2016.ejecutarSentenciaConRetorno("Select id_usuario from GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario where desc_username = '" +
                                                                                                                username + "'");
            usuario.Read();
            int id = Int32.Parse(usuario["id_usuario"].ToString());
            usuario.Close();
            return id;
        }

        public int get_number_roles(int id_usuario)
        {
            SqlDataReader usuario = this.GD1C2016.ejecutarSentenciaConRetorno("Select Count(1) as 'Cant' from GESTORES_DEL_AIRE_ACONDICIONADO.rol_usuario where id_usuario = '" +
                                                                                                    id_usuario.ToString() + "' and estado_rol = 'H'");
            usuario.Read();
            int cant = Int32.Parse(usuario["Cant"].ToString());
            usuario.Close();
            return cant;
        }

        public string get_unique_rol(int id_usuario)
        {
            SqlDataReader rol = this.GD1C2016.ejecutarSentenciaConRetorno("Select desc_rol from GESTORES_DEL_AIRE_ACONDICIONADO.rol_usuario where id_usuario = '" +
                                                                                                    id_usuario.ToString() + "' and estado_rol = 'H'");
            rol.Read();
            string desc_rol = rol["desc_rol"].ToString();
            rol.Close();
            return desc_rol;
        }

        public string get_username(int id_usuario)
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select desc_username from " + ConstantesBD.tabla_usuarios 
                                                                                    + " where id_usuario = '" + id_usuario.ToString() + "'");
            resultado.Read();
            string username = resultado["desc_username"].ToString();
            resultado.Close();
            return username;
        }

        protected void lanzarExcepcion(String mensajeError, SqlDataReader lector)
        {
            lector.Close();
            throw new ValidacionErroneaUsuarioException(mensajeError);
        }
    }
}
