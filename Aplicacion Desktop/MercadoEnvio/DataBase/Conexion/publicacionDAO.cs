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

        public List<String> get_Estados()
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("select desc_estado from " + ConstantesBD.tabla_estado_publicacion);
            List<string> estados = new List<string>();
            while (resultado.Read())
            {
                estados.Add(resultado["desc_estado"].ToString());
            }
            resultado.Close();
            return estados;
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

        /*OBTENGO USERNAME DE USUARIO - Probar*/
        public String getUsername(int id_publicacion)
        {
            SqlDataReader username = this.GD1C2016.ejecutarSentenciaConRetorno("Select desc_publicacion from " + ConstantesBD.tabla_publicaciones + " where id_publicacion = " + id_publicacion);

            if (username.HasRows)
            {
                username.Read();
                String user = username["desc_publicacion"].ToString();
                username.Close();
                return user;
            }
            else
            {
                return "eh";
            }

        }

        public int ultimo_id()
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("select MAX(id_publicacion) as max from " + ConstantesBD.tabla_publicaciones);
            resultado.Read();
            int ultimo_id = Int32.Parse(resultado["max"].ToString());
            resultado.Close();
            return ultimo_id;
        }

        public SqlDataReader get_publicaciones_propias(int id_usuario)
        {
            return this.GD1C2016.ejecutarSentenciaConRetorno("Select * from " + ConstantesBD.vista_publicaciones.ToString()
                                                                        + " where id_usuario = '" + id_usuario.ToString()
                                                                        + "' and desc_estado <> 'Borrador'");
        }

        public void cambiar_Estado(int publicacion, string nuevo_estado)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("Execute GESTORES_DEL_AIRE_ACONDICIONADO.facturar_publicacion   @id_publicacion = '" + publicacion.ToString()
                                                                                                                + "', @nuevo_estado = '" + nuevo_estado
                                                                                                                + "', @fechasys = '" + ConstantesBD.fechaSistema + "'"  );
        }

        public string publicacion_pendiente(int id_user, string tipo_publicacion)
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select 'existe' as resultado from " + tipo_publicacion 
                                                                                        + " where id_usuario = '" + id_user.ToString()
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

        public SqlDataReader get_publicaciones_CO(string condiciones, int pagina, int tamanioPagina)
        {
            if (pagina == 1)
            {
                return this.GD1C2016.ejecutarSentenciaConRetorno("Select TOP " + tamanioPagina.ToString() + " * from " 
                                                                    + ConstantesBD.vista_publi_compra
                                                                    + " where " + condiciones
                                                                    + " order by precio_visualizacion desc");
            }
            else
            {
                int publicacionesAnteriores = (pagina - 1) * tamanioPagina;
                return this.GD1C2016.ejecutarSentenciaConRetorno("Select TOP " + tamanioPagina.ToString() + " * from "
                                                                    + ConstantesBD.vista_publi_compra
                                                                    + " where " + condiciones
                                                                    + " and id_publicacion not in (Select TOP "
                                                                    + publicacionesAnteriores.ToString()
                                                                    + " id_publicacion from "
                                                                    + ConstantesBD.vista_publi_compra
                                                                    + " where " + condiciones
                                                                    + ")"
                                                                    + " order by precio_visualizacion desc");
            }
        }

        public SqlDataReader get_publicaciones_SU(string condiciones, int pagina, int tamanioPagina)
        {
            if (pagina == 1)
            {
                return this.GD1C2016.ejecutarSentenciaConRetorno("Select TOP " + tamanioPagina.ToString() + " * from "
                                                                    + ConstantesBD.vista_publi_subasta
                                                                    + " where " + condiciones
                                                                    + " order by precio_visualizacion desc");
            }
            else
            {
                int publicacionesAnteriores = (pagina - 1) * tamanioPagina;
                return this.GD1C2016.ejecutarSentenciaConRetorno("Select TOP " + tamanioPagina.ToString() + " * from "
                                                                    + ConstantesBD.vista_publi_subasta
                                                                    + " where " + condiciones
                                                                    + " and id_publicacion not in (Select TOP "
                                                                    + publicacionesAnteriores.ToString()
                                                                    + " id_publicacion from "
                                                                    + ConstantesBD.vista_publi_subasta
                                                                    + " where " + condiciones
                                                                    + ")"
                                                                    + " order by precio_visualizacion desc");
            }
        }

        public SqlDataReader get_datos_ultima_publicacion(int id_user, string tipo_publicacion)
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select * from " + tipo_publicacion
                                                                                + " where id_usuario = '" + id_user.ToString()
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

        public int obtenerTotalRegistros_CO(string condiciones)
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select Count(1) as CONTADOR from " + ConstantesBD.vista_publi_compra
                                                                                    + " where " + condiciones);
            resultado.Read();
            int cantidad;
            int.TryParse(resultado["CONTADOR"].ToString(), out cantidad);
            resultado.Close();
            return cantidad;
        }

        public int obtenerTotalRegistros_SU(string condiciones)
        {
            SqlDataReader resultado = this.GD1C2016.ejecutarSentenciaConRetorno("Select Count(1) as CONTADOR from " + ConstantesBD.vista_publi_subasta
                                                                                    + " where " + condiciones);
            resultado.Read();
            int cantidad;
            int.TryParse(resultado["CONTADOR"].ToString(), out cantidad);
            resultado.Close();
            return cantidad;
        }

        public void comprar (   int cantidad, int publicacion, int usuario, string envio    )
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("Execute GESTORES_DEL_AIRE_ACONDICIONADO.comprar @desc_fecha = '" + ConstantesBD.fechaSistema
                                                                                                 + "', @cantidad = '" + cantidad.ToString()
                                                                                                 + "', @publicacion = '" + publicacion.ToString()
                                                                                                 + "', @usuario = '" + usuario.ToString()
                                                                                                 + "', @envio = '" + envio.ToString() + "'");    
        }

        public void subastar (   float monto, int publicacion, int usuario, string envio    )
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("Execute GESTORES_DEL_AIRE_ACONDICIONADO.subastar @desc_fecha = '" + ConstantesBD.fechaSistema
                                                                                                  + "', @monto = '" + monto.ToString()
                                                                                                  + "', @publicacion = '" + publicacion.ToString()
                                                                                                  + "', @usuario = '" + usuario.ToString()
                                                                                                  + "', @envio = '" + envio.ToString() + "'");
        }

        public SqlDataReader get_ultima_oferta(int id_publicacion)
        {
            return this.GD1C2016.ejecutarSentenciaConRetorno("Select TOP 1 * from " + ConstantesBD.tabla_subastas 
                                                                + " where id_publicacion = '" + id_publicacion.ToString()
                                                                + "' order by desc_monto desc");
        }

    }
}