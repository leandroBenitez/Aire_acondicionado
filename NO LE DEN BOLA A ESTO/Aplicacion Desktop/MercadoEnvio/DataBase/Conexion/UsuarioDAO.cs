using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Conexion;

namespace MercadoEnvio.DataBase.Conexion
{
    class UsuarioDAO : GDAA_DAO
    {
        public UsuarioDAO()
        {
            this.iniciar();
        }
        /*
        public String obtenerNombreRol(String id_rol)
        {
            String nombre_rol;

            SqlDataReader lector = this.GD1C2014.ejecutarSentenciaConRetorno("select DESCRIPCION from " + ConstantesBD.t_roles + " where ID_ROL = '" + id_rol + "'");
            lector.Read();
            nombre_rol = lector["DESCRIPCION"].ToString();
            lector.Close();
            return nombre_rol;
        }

        public int obtenerIdRol(String nombre_rol)
        {
            int id_rol;

            SqlDataReader lector = this.GD1C2014.ejecutarSentenciaConRetorno("select id_rol from " + ConstantesBD.t_roles + " where nombre_rol = '" + nombre_rol + "'");
            lector.Read();
            int.TryParse(lector["id_rol"].ToString(), out id_rol);
            lector.Close();
            return id_rol;
        }
        */
    }

}
