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
    class ABM_Rol_DAO : GDAA_DAO
    {
        public ABM_Rol_DAO()
        {
            this.iniciar();
        }
        
        /* OBTENGO TODAS LAS FUNCIONES QUE EXISEN EN LA TABLA FUNCIONES */
        public List<string> get_funciones()
        {
            SqlDataReader funciones = this.GD1C2016.ejecutarSentenciaConRetorno("Select [desc_funcion] from [GESTORES_DEL_AIRE_ACONDICIONADO].[dm_funcion]");
            List<string> funciones_string = new List<string>();

            while (funciones.Read())
            {
                funciones_string.Add(funciones["desc_funcion"].ToString());
            }

            funciones.Close();
            return funciones_string;
        }

        /* OBTENGO TODAS LA FUNCIONES ASIGNADAS A UN ROL EN PARTICULAR */
        public List<String> getFuncionesAsignadasRol(String descRol)
        {
            SqlDataReader funciones = this.GD1C2016.ejecutarSentenciaConRetorno("select desc_funcion from GESTORES_DEL_AIRE_ACONDICIONADO.rl_funciones_roles funcrol join GESTORES_DEL_AIRE_ACONDICIONADO.dm_funcion func on func.id_funcion = funcrol.id_funcion join GESTORES_DEL_AIRE_ACONDICIONADO.dm_rol rol on rol.desc_rol = '" + descRol + "' and rol.id_rol = funcrol.id_rol");
            List<string> funciones_string = new List<string>();

            while (funciones.Read())
            {
                funciones_string.Add(funciones["desc_funcion"].ToString());
            }

            funciones.Close();
            return funciones_string;
        }

        /* OBTENGO LAS FUNCIONES QUE NO TIENE UN ROL EN PARTICULAR */
        public List<String> getFuncionesFaltantesRol(String descRol)
        {
            SqlDataReader funciones = this.GD1C2016.ejecutarSentenciaConRetorno("select desc_funcion from GESTORES_DEL_AIRE_ACONDICIONADO.dm_funcion func where not(func.desc_funcion IN ( select desc_funcion from GESTORES_DEL_AIRE_ACONDICIONADO.rl_funciones_roles funcrol join GESTORES_DEL_AIRE_ACONDICIONADO.dm_funcion func on func.id_funcion = funcrol.id_funcion join GESTORES_DEL_AIRE_ACONDICIONADO.dm_rol rol on rol.desc_rol = '" + descRol + "' and rol.id_rol = funcrol.id_rol))");
            List<string> funciones_string = new List<string>();

            while (funciones.Read())
            {
                funciones_string.Add(funciones["desc_funcion"].ToString());
            }

            funciones.Close();
            return funciones_string;
        }


        /* SETEO LAS FUNCIONALIDADES AL NUEVO ROL */
        public void setearFuncionalidades(String funcionalidad, int id_func, int id_rubro)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("INSERT GESTORES_DEL_AIRE_ACONDICIONADO.rl_funciones_roles(id_rol, id_funcion) VALUES (" + id_rubro + "," + id_func +")");
        }

        /* SETEO EL NUEVO ROL Y OBTENGO EL NUMERO DE ID QUE SE LE ASIGNO (NO ANDA TODAVIA)*/
        public int setearRol(String nuevoRol)
        {
            Int32 numNuevoRubro = 1000;
            MessageBox.Show(nuevoRol);
            this.GD1C2016.ejecutarSentenciaSinRetorno("INSERT GESTORES_DEL_AIRE_ACONDICIONADO.dm_rol(desc_rol, estado_rol) VALUES ('" + nuevoRol + "' , 'A')");


            SqlDataReader numRubro = this.GD1C2016.ejecutarSentenciaConRetorno("select MAX([id_rol])from [GESTORES_DEL_AIRE_ACONDICIONADO].[dm_rol]");

            // Castear como int o algo por el estilo
            numRubro.Close();

            return numNuevoRubro;
        }

        /* OBTENGO TODOS LOS NOMBRES DE ROLES QUE EXISTEN*/
        public List<string> get_roles()
        {
            SqlDataReader roles = this.GD1C2016.ejecutarSentenciaConRetorno("Select [desc_rol] from [GESTORES_DEL_AIRE_ACONDICIONADO].[dm_rol]");
            List<string> nombresRoles = new List<string>();
            while (roles.Read())
            {
                nombresRoles.Add(roles["desc_rol"].ToString());
            }
            roles.Close();

            return nombresRoles;
        }
        
        protected void lanzarExcepcion(String mensajeError, SqlDataReader lector)
        {
            lector.Close();
            throw new ValidacionErroneaUsuarioException(mensajeError);
        }


        /* OBTENGO EL ID DEL ROL SEGUN SU DESCRIPCION (FALTA VER COMO CHORA GUARDO AL QUERY EN UN PUTOINT)*/
        public int getIdRol(String desc_rol)
        {
            int id = 0;
            SqlDataReader id_rol = this.GD1C2016.ejecutarSentenciaConRetorno("Select [id_rol] from [GESTORES_DEL_AIRE_ACONDICIONADO].[dm_rol] where desc_rol = '"+ desc_rol +"' )");

            id_rol.Close();
            return id;
        }

        /* ELIMINO LAS FUNCIONES QUE TIENE ASIGNADAS UN ROLD DE TABLA FUNCIONES_ROLES*/
        public void deleteFuncionesDeRol(int id_rol)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("DELETE FROM GESTORES_DEL_AIRE_ACONDICIONADO.rl_funciones_roles WHERE id_rol = " + id_rol + ";");
        }

        public List<String> getEstadoRol(String desc_rol)
        {
            SqlDataReader estado = this.GD1C2016.ejecutarSentenciaConRetorno("Select [estado_rol] from [GESTORES_DEL_AIRE_ACONDICIONADO].[dm_rol] where desc_rol = '" + desc_rol + "';");
            List<string> nombresRoles = new List<string>();
            while (estado.Read())
            {
                nombresRoles.Add(estado["estado_rol"].ToString());
            }
            
            estado.Close();
            return nombresRoles;
        }

        public void updateEstadoRol(String estado, int id_rol)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("INSERT GESTORES_DEL_AIRE_ACONDICIONADO.rl_funciones_roles(estado_rol) VALUES ('" + estado +"') where id_rol = " + id_rol + ";");

        }

    }
}
