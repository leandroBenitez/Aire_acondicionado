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

namespace MercadoEnvio.ComprarOfertar
{
    public partial class Publicaciones : Form
    {
        private publicacionDAO publicacion;

        private int tamanioPagina = 10;
        private int paginaActual = 1;
        private int totalPaginas = 0;
        string condiciones = "desc_tipo_public = 'Compra Inmediata'";

        public Publicaciones()
        {
            InitializeComponent();
            publicacion = new publicacionDAO();
            cargar_datos();
            cargar_grid();
        }

        public void cargar_datos()
        {
            foreach (string aux in publicacion.get_Rubros())
            { combo_rubros.Items.Add(aux); }
            fecha_desde.Format = DateTimePickerFormat.Custom;
            fecha_hasta.Format = DateTimePickerFormat.Custom;

            fecha_desde.CustomFormat = "yyyy-MM-dd";
            fecha_hasta.CustomFormat = "yyyy-MM-dd";

            fecha_desde.Text = "2015-01-01";
            fecha_hasta.Text = "2017-01-01";

            combo_rubros.Items.Add("Todos");
            combo_rubros.Text = "Todos";
        }

        private void radio_compra_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_compra.Checked == true)
            {
                radio_subasta.Checked = false;
            }
            else
            {
                radio_subasta.Checked = true;
            }
        }

        private void radio_subasta_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_subasta.Checked == true)
            {
                radio_compra.Checked = false;
            }
            else
            {
                radio_compra.Checked = true;
            }
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            this.condiciones = "desc_publicacion like '%" + text_libre.Text + "%' and desc_tipo_public = 'Compra Inmediata'";
            this.paginaActual = 1;
            int totalRegistros = publicacion.obtenerTotalRegistros(this.condiciones);
            this.totalPaginas = calcularTotalDePaginas(totalRegistros);
            cargar_grid();
            limpiar_filtros();
        }

        public void cargar_grid()
        {
            dataGridViewPub.Rows.Clear();

            int totalRegistros = publicacion.obtenerTotalRegistros(this.condiciones);
            this.totalPaginas = calcularTotalDePaginas(totalRegistros);

            SqlDataReader lectura = publicacion.get_publicaciones(this.condiciones, this.paginaActual ,this.tamanioPagina);
            
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[5];

            while (lectura.Read())
            {
                columnas[0] = lectura["desc_publicacion"].ToString();
                columnas[1] = lectura["desc_stock"].ToString();
                columnas[2] = lectura["desc_precio"].ToString();
                columnas[3] = lectura["desc_costo_envio"].ToString();
                columnas[4] = lectura["fecha_vencimiento"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewPub, columnas);
            }
            lectura.Close();
            dataGridViewPub.Rows.AddRange(filas.ToArray());
        }

        private void boton_aplicar_Click(object sender, EventArgs e)
        {
            string condiciones = "desc_publicacion like '%" + text_libre.Text + "%'";
            //agrego el filtro por rubros
            if (combo_rubros.Text != "Todos")
            {
                condiciones = condiciones + " and desc_rubro like '%" + combo_rubros.Text + "%'";
            }
            //agrego el filtro por compra/subasta
            if (radio_compra.Checked == true)
            {
                condiciones = condiciones + " and desc_tipo_public = 'Compra Inmediata'";
            }
            else
            {
                condiciones = condiciones + " and desc_tipo_public = 'Subasta'";
            }
            //agrego el filtro de precio "desde"
            if (!string.IsNullOrWhiteSpace(precio_desde.Text))
            { condiciones = condiciones + " and desc_precio >= '" + precio_desde.Text + "'"; }
            //agrego el filtro de precio "hasta"
            if (!string.IsNullOrWhiteSpace(precio_hasta.Text))
            { condiciones = condiciones + " and desc_precio <= '" + precio_hasta.Text + "'"; }
            //agrego los filtros de fecha
            condiciones = condiciones + " and fecha_vencimiento between '" + fecha_desde.Text 
                                        + "' and '" + fecha_hasta.Text + "'";
            this.condiciones = condiciones;
            this.paginaActual = 1;
            int totalRegistros = publicacion.obtenerTotalRegistros(this.condiciones);
            this.totalPaginas = calcularTotalDePaginas(totalRegistros);
            cargar_grid();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(this.paginaActual == this.totalPaginas))
            {
                this.paginaActual += 1;
                cargar_grid();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(this.paginaActual == 1))
            {
                this.paginaActual -= 1;
                cargar_grid();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.paginaActual = this.totalPaginas;
            cargar_grid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.paginaActual = 1;
            cargar_grid();
        }

        private void boton_limpiar_Click(object sender, EventArgs e)
        {
            limpiar_filtros();
        }

        public void limpiar_filtros()
        {
            combo_rubros.Text = "Todos";
            precio_desde.Text = "";
            precio_hasta.Text = "";
            radio_subasta.Checked = false;
            radio_compra.Checked = true;
            fecha_desde.Text = "2015-01-01";
            fecha_hasta.Text = "2017-01-01";
        }
    }
}
