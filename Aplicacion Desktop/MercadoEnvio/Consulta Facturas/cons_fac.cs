﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.DataBase.Conexion;

namespace MercadoEnvio.Consulta_Facturas
{
    public partial class cons_fac : Form
    {
        ABM_Factura_DAO abm_factura;
        public Menu menu;

        public cons_fac(Menu unMenu)
        {
            abm_factura = new ABM_Factura_DAO();
            InitializeComponent();
            menu = unMenu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textAnio1.Text = "";
            textAnio2.Text = "";
            textMes1.Text = "";
            textMes2.Text = "";
            textDia1.Text = "";
            textDia2.Text = "";
            textDescripcion.Text = "";
            textDestinatario.Text = "";
            textImporte1.Text = "";
            textImporte2.Text = "";
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            
            List<String> filtros = new List<String>();
            listado.Rows.Clear();
            String fechaInicio;
            String fechaFin;

            /* Armo las fechas para la Query */
            if (textDia1.Text != "" && textMes1.Text != "" && textAnio1.Text != "")
            {
                fechaInicio = textDia1.Text + "/" + textMes1.Text + "/" + textAnio1.Text;
                if (textDia2.Text != "" && textMes2.Text != "" && textAnio2.Text != "")
                {
                    fechaFin = textDia2.Text + "/" + textMes2.Text + "/" + textAnio2.Text;
                    // VER PORQUE NO ESTÁ ANDANDO NI EN LA QUERY DEL MANAGEMENT
                    filtros.Add("DESC_FECHA BETWEEN CONVERT(DATETIME,'" + fechaInicio + "') AND CONVERT(DATETIME,'" + fechaFin + "')");
                }
                else
                {
                    // Mensaje de advertencia
                }
            }
            else
            {
                filtros.Add("1=1");
            }

            if (textDestinatario.Text != "")
                filtros.Add("id_usuario = " + textDestinatario.Text);
            else
                filtros.Add("1=1");

            if (textDescripcion.Text != "")
                filtros.Add("1 = 1");
            else
            filtros.Add("1=1");

            if (textImporte1.Text != "" && textImporte2.Text != "")
                filtros.Add("desc_total BETWEEN " + textImporte1.Text + " AND " + textImporte2.Text);
            else
                filtros.Add("1 = 1");

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[10];

            List<SqlDataReader> facturas = abm_factura.buscarFactura(filtros);
            
            List<String> id_usuarios = new List<String>();

            while (facturas[0].Read())
            {
                columnas[0] = facturas[0]["id_factura"].ToString();
                //columnas[2] = facturas[0]["desc_factura_nro"].ToString();
                columnas[2] = facturas[0]["desc_fecha"];
                columnas[3] = facturas[0]["desc_total"].ToString();
                columnas[4] = facturas[0]["id_usuario"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(listado, columnas);
            }
            facturas[0].Close();
            listado.Rows.AddRange(filas.ToArray());
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}
