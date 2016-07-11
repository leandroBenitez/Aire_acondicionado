﻿using System;
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

        public List<string> getCompras(string comprador)
        {
            SqlDataReader lector = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT ca.id_calificacion from " + ConstantesBD.tabla_calificacion + " ca" +
                                                                             " WHERE ca.desc_cantidad_estrellas = 0 AND ca.id_usuario_comprador = " + comprador);
            List<string> resultado = new List<string>();

            while (lector.Read())
            {
                resultado.Add(lector["id_calificacion"].ToString());
            }

            lector.Close();
            return resultado;
        }

        public int getCalificacion(int id_user, string id_pub)
        {
            try
            {
                int id = 0;
                SqlDataReader num_rol = this.GD1C2016.ejecutarSentenciaConRetorno("SELECT desc_cantidad_estrellas FROM " + ConstantesBD.tabla_calificacion +
                                                                                   " WHERE id_publicacion = " + id_pub +
                                                                                   " AND id_usuario = " + id_user);

                if (num_rol.Read())
                    id = (int)num_rol[0];
                num_rol.Close();

                return id;
            }
            catch (Exception e)
            {
                return 0;
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
    }
}
