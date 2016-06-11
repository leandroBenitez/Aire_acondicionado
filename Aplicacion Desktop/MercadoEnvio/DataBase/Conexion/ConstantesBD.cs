using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.DataBase.Conexion
{
    abstract class ConstantesBD
    {
        public static String fechaSistema;
        public static String Param_Conexion_urlServidor;
        public static String Param_Conexion_usuario;
        public static String Param_Conexion_contraseña;
        public static String Param_Conexion_nombreBD;
        //A partir de aqui se deben setear el nombre de las tabla y procedimientos
        public static String proc_insertar_cliente = "";
        //Todas las tablas
        public static String tabla_estado_publicacion = "GESTORES_DEL_AIRE_ACONDICIONADO.dm_estado_publicacion";
        public static String tabla_estado_usuario = "GESTORES_DEL_AIRE_ACONDICIONADO.dm_estado_usuario";
        public static String tabla_forma_pago = "GESTORES_DEL_AIRE_ACONDICIONADO.dm_forma_pago";
        public static String tabla_funciones = "GESTORES_DEL_AIRE_ACONDICIONADO.dm_funcion";
        public static String tabla_roles = "GESTORES_DEL_AIRE_ACONDICIONADO.dm_rol";
        public static String tabla_rubro = "GESTORES_DEL_AIRE_ACONDICIONADO.dm_rubro";
        public static String tabla_tipo_costo = "GESTORES_DEL_AIRE_ACONDICIONADO.dm_tipo_costo";
        public static String tabla_tipo_publicacion = "GESTORES_DEL_AIRE_ACONDICIONADO.dm_tipo_publicacion";
        public static String tabla_visibilidad = "GESTORES_DEL_AIRE_ACONDICIONADO.dm_visibilidad";
        public static String tabla_calificacion = "GESTORES_DEL_AIRE_ACONDICIONADO.ft_calificacion";
        public static String tabla_compras = "GESTORES_DEL_AIRE_ACONDICIONADO.ft_compra";
        public static String tabla_facturas = "GESTORES_DEL_AIRE_ACONDICIONADO.ft_factura";
        public static String tabla_items = "GESTORES_DEL_AIRE_ACONDICIONADO.ft_item";
        public static String tabla_publicaciones = "GESTORES_DEL_AIRE_ACONDICIONADO.ft_publicacion";
        public static String tabla_subastas = "GESTORES_DEL_AIRE_ACONDICIONADO.ft_subasta";
        public static String tabla_usuarios = "GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario";
        public static String tabla_clientes = "GESTORES_DEL_AIRE_ACONDICIONADO.lk_cliente";
        public static String tabla_empresas = "GESTORES_DEL_AIRE_ACONDICIONADO.lk_empresa";
        public static String tabla_ingresos = "GESTORES_DEL_AIRE_ACONDICIONADO.log_ingresos";
        public static String tabla_funciones_roles = "GESTORES_DEL_AIRE_ACONDICIONADO.rl_funciones_roles";
        public static String tabla_roles_usuarios = "GESTORES_DEL_AIRE_ACONDICIONADO.rl_roles_usuarios";
        public static String vista_publicaciones = "GESTORES_DEL_AIRE_ACONDICIONADO.publicaciones";


        // Recibe una fecha en formato DD/MM/AAAA y lo convierte a formato de BD: AAAAMMDD 00:00:00.00
        public static String cambiarFormatoFecha(String fecha)
        {
            String fechaConFormato = "";
            char[] delimitadores = { '/' };

            string[] palabras = fecha.Split(delimitadores);

            foreach (string s in palabras)
            {
                fechaConFormato = s + fechaConFormato;
            }
            return fechaConFormato + " 00:00:00.00";
        }
    }
}
