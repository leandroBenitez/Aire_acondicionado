using System;
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
    public partial class HistorialSubastas : Form
    {
        HistorialSubastas_DAO HistSubDAO = new HistorialSubastas_DAO();
        private int id_usuario;

        //Páginas-------------------------------------------------------------
        private int tamanioPagina = 10;
        private int paginaActual = 1;
        private int totalPaginas = 0;
        //Páginas------------------------------------------------------------

        public HistorialSubastas(int idUser)
        {
            InitializeComponent();
            id_usuario = idUser;
        }

        private void cargar_grid_histSubastas()
        {
            dataGridViewSubastas.Rows.Clear();

            //total de registros--------------------------------------------------
            int totalRegistros = HistSubDAO.obtenerTotalRegistros(this.id_usuario);
            //total de páginas----------------------------------------------------
            this.totalPaginas = calcularTotalDePaginas(totalRegistros);
            //--------------------------------------------------------------------

            SqlDataReader lectura;

            lectura = HistSubDAO.get_subastas(this.id_usuario);

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[5];

            while (lectura.Read())
            {
                columnas[0] = lectura["id_subasta"].ToString();
                columnas[1] = lectura["desc_fecha"].ToString();
                columnas[2] = lectura["desc_monto"].ToString();
                columnas[3] = lectura["id_publicación"].ToString();
                columnas[4] = lectura["Id_usuario"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewSubastas, columnas);

            }

            lectura.Close();
            dataGridViewSubastas.Rows.AddRange(filas.ToArray()); 
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
       
        private void buttonVolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrimerPag_Click(object sender, EventArgs e)
        {
            this.paginaActual = this.totalPaginas;
            cargar_grid_histSubastas();
        }

        private void buttonPaginaAnt_Click(object sender, EventArgs e)
        {
            if (!(this.paginaActual == 1))
            {
                this.paginaActual -= 1;
                cargar_grid_histSubastas();
            }
        }

        private void buttonPaginaSgte_Click(object sender, EventArgs e)
        {
            if (!(this.paginaActual == this.totalPaginas))
            {
                this.paginaActual += 1;
                cargar_grid_histSubastas();
            }
        }

        private void buttonUltimaPag_Click(object sender, EventArgs e)
        {
            this.paginaActual = this.totalPaginas;
            cargar_grid_histSubastas();
        }

       
    }
}
