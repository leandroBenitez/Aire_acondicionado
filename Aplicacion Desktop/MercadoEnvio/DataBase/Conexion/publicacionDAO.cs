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
    class publicacionDAO : GDAA_DAO
    {
        public publicacionDAO()
        {
            this.iniciar();
        }

        public List<String> get_Rubros()
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("select desc_rubro from " + ConstantesBD.tabla_rubro);
            List<string> rubros = new List<string>();
            while (resultado.Read())
            {
                rubros.Add(resultado["desc_rubro"].ToString());
            }
            resultado.Close();
            return rubros;
        }

        public List<String> get_Tipo_Publicacion()
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("select desc_estado from " + ConstantesBD.tabla_estado_publicacion);
            List<string> tipos = new List<string>();
            while (resultado.Read())
            {
                tipos.Add(resultado["desc_estado"].ToString());
            }
            resultado.Close();
            return tipos;
        }

        public List<String> get_visualizaciones()
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("select desc_tipo from " + ConstantesBD.tabla_visibilidad);
            List<string> visibilidad = new List<string>();
            while (resultado.Read())
            {
                visibilidad.Add(resultado["desc_tipo"].ToString());
            }
            resultado.Close();
            return visibilidad;
        }

        public int ultimo_id()
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("select MAX(id_publicacion) as max from " + ConstantesBD.tabla_publicaciones);
            resultado.Read();
            int ultimo_id = Int32.Parse(resultado["max"].ToString());
            resultado.Close();
            return ultimo_id;
        }

        public string publicacion_pendiente(int id_user, string tipo_publicacion)
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select 'existe' as resultado from " + ConstantesBD.vista_publicaciones 
                                                                                        + " where id_usuario = '" + id_user.ToString()
                                                                                        + "' and desc_tipo_public = '" + tipo_publicacion 
                                                                                        + "' and desc_estado = 'Borrador'");
            if (!resultado.HasRows)
            {
                resultado.Close();
                return "ok";
            }
            else
            {
                resultado.Close();
                return "pendiente";
            }
        }

        public SqlDataReader get_publicaciones(string condiciones, int pagina, int tamanioPagina)
        {
            if (pagina == 1)
            {
                MessageBox.Show("Select TOP " + tamanioPagina.ToString() + " * from "
                                                                    + ConstantesBD.vista_publicaciones
                                                                    + " where " + condiciones);
                return this.GD1C2016.ejecutarSentenciaConRetorno("Select TOP " + tamanioPagina.ToString() + " * from " 
                                                                    + ConstantesBD.vista_publicaciones
                                                                    + " where " + condiciones);
            }
            else
            {
                int publicacionesAnteriores = (pagina - 1) * tamanioPagina;
                MessageBox.Show("Select TOP " + tamanioPagina.ToString() + " * from "
                                                                    + ConstantesBD.vista_publicaciones
                                                                    + " where " + condiciones
                                                                    + " and id_publicacion not in (Select TOP "
                                                                    + publicacionesAnteriores.ToString()
                                                                    + " id_publicacion from "
                                                                    + ConstantesBD.vista_publicaciones
                                                                    + " where " + condiciones
                                                                    + ")");

                return this.GD1C2016.ejecutarSentenciaConRetorno("Select TOP " + tamanioPagina.ToString() + " * from "
                                                                    + ConstantesBD.vista_publicaciones
                                                                    + " where " + condiciones
                                                                    + " and id_publicacion not in (Select TOP "
                                                                    + publicacionesAnteriores.ToString()
                                                                    + " id_publicacion from "
                                                                    + ConstantesBD.vista_publicaciones
                                                                    + " where " + condiciones
                                                                    + ")");
            }
        }

        public SqlDataReader get_datos_ultima_publicacion(int id_user, string tipo_publicacion)
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select * from " + ConstantesBD.vista_publicaciones
                                                                                + " where id_usuario = '" + id_user.ToString()
                                                                                + "' and desc_tipo_public = '" + tipo_publicacion 
                                                                                + "' and desc_estado = 'Borrador'");
            return resultado;
        }

        public bool guardar_publicacion(string id_publicacion, string descripcion,
                                        string stock, string fecha_pub,
                                        string fecha_venc, string precio,
                                        string precio_envio, string estado,
                                        string visualizacion, string tipo_publi,
                                        string rubro, int usuario   )
        {
            try
            {
                this.GD1C2016.ejecutarSentenciaSinRetorno("Execute GESTORES_DEL_AIRE_ACONDICIONADO.guardar_publicacion @id_publicacion = '" + id_publicacion
                                                                                                             + "', @descripcion = '" + descripcion
                                                                                                             + "', @stock = '" + stock
                                                                                                             + "', @fecha_pub = '" + fecha_pub
                                                                                                             + "', @fecha_venc = '" + fecha_venc
                                                                                                             + "', @precio = '" + precio
                                                                                                             + "', @precio_envio = '" + precio_envio
                                                                                                             + "', @estado = '" + estado
                                                                                                             + "', @visualizacion = '" + visualizacion
                                                                                                             + "', @tipo_publicacion = '" + tipo_publi
                                                                                                             + "', @rubro = '" + rubro
                                                                                                             + "', @usuario = '" + usuario.ToString() + "'");
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        protected void lanzarExcepcion(String mensajeError, SqlDataReader lector)
        {
            lector.Close();
            throw new ValidacionErroneaUsuarioException(mensajeError);
        }

        public int obtenerTotalRegistros(string condiciones)
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select Count(1) as CONTADOR from " + ConstantesBD.vista_publicaciones
                                                                                    + " where " + condiciones);
            resultado.Read();
            int cantidad;
            int.TryParse(resultado["CONTADOR"].ToString(), out cantidad);
            resultado.Close();
            return cantidad;
        }

    }
}