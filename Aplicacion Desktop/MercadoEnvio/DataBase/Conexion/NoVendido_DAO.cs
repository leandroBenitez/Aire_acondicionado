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
    class NoVendido_DAO : GDAA_DAO
    {
        public NoVendido_DAO()
        {
            this.iniciar();
        }

        public List<string> get_idVisibilidad()
        {
            MessageBox.Show("SELECT id_visibilidad FROM " + ConstantesBD.tabla_visibilidad);
            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT id_visibilidad FROM " + ConstantesBD.tabla_visibilidad );

            List<string> resultado = new List<string>();
            while (lector.Read())
            {
                resultado.Add(lector["id_visibilidad"].ToString());
            }
            lector.Close();
            return resultado;
        }


    }

}