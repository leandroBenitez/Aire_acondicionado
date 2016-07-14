using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MercadoEnvio.Conexion
{
    abstract class GDAA_DAO
    {
        protected SQLServerBD GD1C2016;

        protected void iniciar()
        {
            this.GD1C2016 = new SQLServerBD(MercadoEnvio.DataBase.Conexion.ConstantesBD.Param_Conexion_urlServidor,
                MercadoEnvio.DataBase.Conexion.ConstantesBD.Param_Conexion_usuario,
                MercadoEnvio.DataBase.Conexion.ConstantesBD.Param_Conexion_contraseña,
                MercadoEnvio.DataBase.Conexion.ConstantesBD.Param_Conexion_nombreBD, "true", "1000");
            this.GD1C2016.abrir();
        }

        public void finalizar()
        {
            this.GD1C2016.cerrar();
        }
    }
}