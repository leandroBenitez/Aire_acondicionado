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
    class Calificar_DAO : GDAA_DAO
    {
        public Calificar_DAO()
        {
            this.iniciar();
        }

        public List<string> getIdCalificacion(int comprador)
        {
            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT ca.id_calificacion from " + ConstantesBD.tabla_calificacion + " ca" +
                                                                             " WHERE ca.id_usuario_comprador = " + comprador + " AND ca.desc_cantidad_estrellas = 0");
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["id_calificacion"].ToString());
            }

            lector.Close();
            return resultado;
        }

        public List<string> getCalificaciones(int comprador, int calificacion)
        {
            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT ca.id_calificacion from " + ConstantesBD.tabla_calificacion + " ca" +
                                                                             " WHERE ca.id_usuario_comprador = " + comprador +
                                                                             " AND ca.desc_cantidad_estrellas = " + calificacion + " AND ca.id_subasta is null");
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["id_calificacion"].ToString());
            }

            lector.Close();
            return resultado;
        }

        public List<string> getCalificacionesSubastas(int comprador, int calificacion)
        {
            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT ca.id_calificacion from " + ConstantesBD.tabla_calificacion + " ca" +
                                                                             " WHERE ca.id_usuario_comprador = " + comprador +
                                                                             " AND ca.desc_cantidad_estrellas = " + calificacion + " AND ca.id_compra is null");
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["id_calificacion"].ToString());
            }

            lector.Close();
            return resultado;
        }

        public decimal getCalificacion(int id_pub)
        {
                decimal id = 0;
                SqlDataReader num_rol = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT desc_cantidad_estrellas FROM " + ConstantesBD.tabla_calificacion +
                                                                                   " WHERE id_calificacion = " + id_pub);

                if (num_rol.Read())
                    id = (decimal)num_rol[0];
                num_rol.Close();

                return id;
        }
        /*
        public int getCompra(decimal id_cal)
        {
            try
            {
                int id = 0;
                SqlDataReader num_rol = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT id_compra FROM " + ConstantesBD.tabla_calificacion +
                                                                                   " WHERE id_calificacion = " + id_cal);

                if (num_rol.Read())
                    id = (int)num_rol[0];
                num_rol.Close();

                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se encontro la compra Publicacion: " + id_cal.ToString());
                return -1;
            }
        }
        */

        public int getCompra(decimal id_cal)
        {
                int id = 0;
                SqlDataReader num_rol = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT id_compra FROM " + ConstantesBD.tabla_calificacion +
                                                                                   " WHERE id_calificacion = " + id_cal);

                if (num_rol.Read())
                    id = (int)num_rol[0];
                num_rol.Close();

                return id;
        }
        public decimal getPublicacionCompra(int id_com)
        {
            try
            {
                decimal id = 0;
                SqlDataReader num_rol = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT id_publicacion FROM " + ConstantesBD.tabla_compras +
                                                                                   " WHERE id_compra = " + id_com);

                if (num_rol.Read())
                    id = (decimal)num_rol[0];
                num_rol.Close();

                return id;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        /*
        public int getSubasta(decimal id_cal)
        {
            try
            {
                int id = 0;
                SqlDataReader num_rol = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT id_subasta FROM " + ConstantesBD.tabla_calificacion +
                                                                                   " WHERE id_calificacion = " + id_cal);

                if (num_rol.Read())
                    id = (int)num_rol[0];
                num_rol.Close();

                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se encontro la subasta Publicacion: " + id_cal.ToString());
                return -1;
            }
        }
        */

        public int getSubasta(decimal id_cal)
        {
                int id = 0;
                SqlDataReader num_rol = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT id_subasta FROM " + ConstantesBD.tabla_calificacion +
                                                                                   " WHERE id_calificacion = " + id_cal);

                if (num_rol.Read())
                    id = (int)num_rol[0];
                num_rol.Close();

                return id;
         
        }
        public decimal getPublicacionSubasta(int id_sub)
        {
            try
            {
                decimal id = 0;
                SqlDataReader num_rol = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT id_publicacion FROM " + ConstantesBD.tabla_subastas +
                                                                                   " WHERE id_subasta = " + id_sub);

                if (num_rol.Read())
                    id = (decimal)num_rol[0];
                num_rol.Close();

                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se encuentra el id " + id_sub);
                return -1;
            }
        }
        
        public int getVendedor(int id_compra)
        {
            int id = 0;
            SqlDataReader num_rol = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT ca.id_usuario_vendedor FROM " + ConstantesBD.tabla_calificacion + " ca" +
                                                                               " WHERE ca.id_calificacion = " + id_compra);

            if (num_rol.Read())
                id = (int)num_rol[0];
            num_rol.Close();

            return id;
        }

        public void calificarA(int pubCalif, int estrellas, string descripcion, int compradorCalif)
        {
            this.GD1C2016.ejecutarSentenciaSinRetorno("UPDATE " + ConstantesBD.tabla_calificacion + " SET " +
                                                      "desc_cantidad_estrellas = " 
                                                      + estrellas + ", descripcion = '"
                                                      + descripcion + "' "
                                                      + "WHERE id_calificacion = " 
                                                      + pubCalif + " AND id_usuario_comprador = "
                                                      + compradorCalif);
        }

        public List<string> get_ultimas_calificaciones(int id_usuario)
        {
            try
            {
                SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT TOP 5 ca.id_calificacion from " + ConstantesBD.tabla_calificacion + " ca" +
                                                                                 " WHERE ca.id_usuario_comprador = " + id_usuario + " AND ca.id_subasta is null" +
                                                                                 " ORDER BY ca.id_calificacion DESC");
                List<string> resultado = new List<string>();

                while (lector.Read())
                {
                    resultado.Add(lector["id_calificacion"].ToString());
                }

                lector.Close();
                return resultado;
            }
            catch (Exception)
            {
                MessageBox.Show("No hay nada");
                 List<string> resultado = new List<string>();
                 return resultado;
            }
        }

        public List<string> get_ultimas_calificaciones_subastas(int id_usuario)
        {

            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT TOP 5 ca.id_calificacion from " + ConstantesBD.tabla_calificacion + " ca" +
                                                                             " WHERE ca.id_usuario_comprador = " + id_usuario + " AND ca.id_compra is null" +
                                                                             " ORDER BY ca.id_calificacion DESC");
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["id_calificacion"].ToString());
            }

            lector.Close();
            return resultado;
        }
    }
}
