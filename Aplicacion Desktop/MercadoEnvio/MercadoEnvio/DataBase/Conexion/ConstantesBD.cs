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
        public static String tabla_roles = "GESTORES_DEL_AIRE_ACONDICIONADO.dm_rol";
        public static String tabla_clientes = "";
        public static String proc_insertar_cliente = "";

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
