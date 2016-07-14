using System;
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
        ABM_usuario_DAO abm_usuario;
        public Menu menu;

        private int tamanioPagina = 11;
        private int paginaActual = 1;
        private int totalPaginas = 0;
        List<String> filtros = new List<String>();

        public cons_fac(Menu unMenu)
        {
            abm_factura = new ABM_Factura_DAO();
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            menu = unMenu;
            cargarDatos();
            cargarGrid(filtros);
        }

        public void cargarDatos()
        {
            filtros.Add(" 1 = 1 ");
            filtros.Add(" 1 = 1 ");
            filtros.Add(" 1 = 1 ");
            filtros.Add(" 1 = 1 ");
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
            try
            {
                filtros = new List<String>();
                listado.Rows.Clear();
                String fechaInicio;
                String fechaFin;

                this.paginaActual = 1;

                /* Armo las fechas para la Query */
                if (textDia1.Text != "" && textMes1.Text != "" && textAnio1.Text != "" && textDia2.Text != "" && textMes2.Text != "" && textAnio2.Text != "")
                {
                    fechaInicio = textDia1.Text + "/" + textMes1.Text + "/" + textAnio1.Text;
                    fechaFin = textDia2.Text + "/" + textMes2.Text + "/" + textAnio2.Text;
                    filtros.Add("DESC_FECHA BETWEEN CONVERT(DATETIME,'" + fechaInicio + "') AND CONVERT(DATETIME,'" + fechaFin + "')");
                }
                else if (textDia1.Text != "" && textMes1.Text != "" && textAnio1.Text != "")
                {
                    fechaInicio = textDia1.Text + "/" + textMes1.Text + "/" + textAnio1.Text;
                    filtros.Add("DESC_FECHA > CONVERT(DATETIME,'" + fechaInicio + "')");
                }
                else if (textDia2.Text != "" && textMes2.Text != "" && textAnio2.Text != "")
                {
                    fechaFin = textDia2.Text + "/" + textMes2.Text + "/" + textAnio2.Text;
                    filtros.Add("DESC_FECHA < CONVERT(DATETIME,'" + fechaFin + "')");
                }
                else
                {
                    filtros.Add("1=1");
                }

                if (textDestinatario.Text != "")
                {
                    List<String> lista_id_usuarios = abm_factura.getUsuarioPorLikeDesc(textDestinatario.Text);
                    String id_usuarios_filtro = "'99999'";
                    int pos = 0;
                    while (lista_id_usuarios.Count() > pos)
                    {
                        id_usuarios_filtro = id_usuarios_filtro + ",'" + lista_id_usuarios.ElementAt(pos) + "'";
                        pos++;
                    }
                    filtros.Add("id_usuario IN (" + id_usuarios_filtro + ")");
                }
                else
                    filtros.Add("1=1");

                if (textDescripcion.Text != "")
                {
                    List<String> lista_id_facturas = abm_factura.getFacturas(textDescripcion.Text);
                    String id_facturas_filtro = "'0000000000000000000009999'";
                    int pos = 0;
                    while (lista_id_facturas.Count() > pos)
                    {
                        id_facturas_filtro = id_facturas_filtro + ",'" + lista_id_facturas.ElementAt(pos) + "'";
                        pos++;
                    }
                    filtros.Add("id_factura IN (" + id_facturas_filtro + ")");
                }
                else
                    filtros.Add("1=1");

                if (textImporte1.Text != "" && textImporte2.Text != "")
                    filtros.Add("desc_total BETWEEN " + textImporte1.Text + " AND " + textImporte2.Text);
                else if (textImporte1.Text != "")
                    filtros.Add("desc_total > " + textImporte1.Text);
                else if (textImporte2.Text != "")
                    filtros.Add("desc_total < " + textImporte2.Text);
                else
                    filtros.Add("1 = 1");

                cargarGrid(filtros);
            }
            catch
            {
                MessageBox.Show("Verifique que los filtros ingresados son correctos. Ayuda: En importe tienen que ir números. En fechas, tienen que ser fechas válidas. Además no se permiten símbolos en general para cualquier filtro");
            }
        }

        public void cargarGrid(List<String> filtros)
        {
            listado.Rows.Clear();

            int totalRegistros = abm_usuario.obtenerTotalRegistrosFacturas(filtros);
            this.totalPaginas = calcularTotalDePaginas(totalRegistros);

            List<SqlDataReader> facturas = abm_factura.buscarFactura(filtros, paginaActual, tamanioPagina);

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[10];

            while (facturas[0].Read())
            {
                columnas[0] = facturas[0]["id_factura"].ToString();
                columnas[1] = facturas[0]["desc_fecha"];
                columnas[2] = facturas[0]["desc_total"].ToString();
                String id_usuario = facturas[0]["id_usuario"].ToString();
                columnas[3] = abm_usuario.getUsername(id_usuario);

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.paginaActual = 1;
            cargarGrid(this.filtros);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(this.paginaActual == 1))
            {
                this.paginaActual -= 1;
                cargarGrid(this.filtros);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!(this.paginaActual == this.totalPaginas))
            {
                this.paginaActual += 1;
                cargarGrid(this.filtros);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.paginaActual = this.totalPaginas;
            cargarGrid(this.filtros);
        }

    }
}
