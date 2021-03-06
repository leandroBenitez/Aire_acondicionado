﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.DataBase.Conexion;
using System.Data.SqlClient;

namespace MercadoEnvio.Historial_Cliente
{
    public partial class HistorialComprasSinCalificar : Form
    {
        HistorialEstrellas_DAO HistEstDAO = new HistorialEstrellas_DAO();
        private int id_usuario;

        //Páginas-------------------------------------------------------------
        private int tamanioPagina = 10;
        private int paginaActual = 1;
        private int totalPaginas = 0;
        //Páginas------------------------------------------------------------

        public HistorialComprasSinCalificar(int idUser)
        {
            InitializeComponent();
            id_usuario = idUser;
        }

        private void cargar_grid_histComprasSinCalificar()
        {
            dataGridViewComprasSinCalificar.Rows.Clear();

            //total de registros--------------------------------------------------
            int totalRegistros = HistEstDAO.obtenerTotalRegistros(this.id_usuario);
            //total de páginas----------------------------------------------------
            this.totalPaginas = calcularTotalDePaginas(totalRegistros);
            //--------------------------------------------------------------------

            SqlDataReader lectura;

            lectura = HistEstDAO.get_comprasSinCalificar(this.id_usuario);

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[6];

            while (lectura.Read())
            {
                columnas[0] = lectura["id_calificacion"].ToString();
                columnas[1] = lectura["desc_codigo"].ToString();
                columnas[2] = lectura["desc_cantidad_estrellas"].ToString();
                columnas[3] = lectura["descripcion"].ToString();
                columnas[4] = lectura["id_usuario_comprador"].ToString();
                columnas[5] = lectura["id_compra"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewComprasSinCalificar, columnas);
                
            }

            lectura.Close();
            dataGridViewComprasSinCalificar.Rows.AddRange(filas.ToArray());
        }

        private int calcularTotalDePaginas(int cantRegistros)
        {
            int aux;
            aux = cantRegistros / this.tamanioPagina;

            if (cantRegistros % this.tamanioPagina > 0)
            {
                aux += 1;
            }
            return aux;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrimerPag_Click(object sender, EventArgs e)
        {
            this.paginaActual = this.totalPaginas;
            cargar_grid_histComprasSinCalificar();
        }

        private void buttonPaginaAnt_Click(object sender, EventArgs e)
        {
            if (!(this.paginaActual == 1))
            {
                this.paginaActual -= 1;
                cargar_grid_histComprasSinCalificar();
            }
        }

        private void buttonPaginaSgte_Click(object sender, EventArgs e)
        {
            if (!(this.paginaActual == this.totalPaginas))
            {
                this.paginaActual += 1;
                cargar_grid_histComprasSinCalificar();
            }
        }

        private void buttonUltimaPag_Click(object sender, EventArgs e)
        {
            this.paginaActual = this.totalPaginas;
            cargar_grid_histComprasSinCalificar();
        }

        private void HistorialComprasSinCalificar_Load(object sender, EventArgs e)
        {
            cargar_grid_histComprasSinCalificar();
        }
    }
}
