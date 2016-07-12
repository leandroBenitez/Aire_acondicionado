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
    public partial class Publicaciones_subasta : Form
    {
        private publicacionDAO publicacion;
        private Menu unMenu;

        private int tamanioPagina = 11;
        private int paginaActual = 1;
        private int totalPaginas = 0;
        string condicion_necesaria;
        string condiciones = "";

        public Publicaciones_subasta(Menu menu)
        {
            InitializeComponent();
            publicacion = new publicacionDAO();
            this.unMenu = menu;
            cargar_datos();
            this.condicion_necesaria = "desc_tipo_public = 'Subasta' and id_usuario <> '" + unMenu.id_usuario + "'";
            cargar_grid();
        }

        public void cargar_datos()
        {
            foreach (string aux in publicacion.get_Rubros())
            { 
              check_list.Items.Add(aux, true);
            }
        }

        public void cargar_grid()
        {
            dataGridViewPub.Rows.Clear();

            int totalRegistros = publicacion.obtenerTotalRegistros_SU(this.condiciones + " " + this.condicion_necesaria);
            this.totalPaginas = calcularTotalDePaginas(totalRegistros);

            SqlDataReader lectura = publicacion.get_publicaciones_SU(this.condiciones + " " + this.condicion_necesaria, this.paginaActual, this.tamanioPagina);
            
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[7];

            while (lectura.Read())
            {
                columnas[0] = lectura["id_publicacion"].ToString();
                columnas[1] = lectura["desc_publicacion"].ToString();
                columnas[2] = lectura["desc_stock"].ToString();
                columnas[3] = lectura["desc_precio"].ToString();
                columnas[4] = lectura["desc_costo_envio"].ToString();
                columnas[5] = lectura["fecha_vencimiento"].ToString();
                columnas[6] = lectura["precio_visualizacion"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewPub, columnas);
            }
            lectura.Close();
            dataGridViewPub.Rows.AddRange(filas.ToArray());
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            this.condiciones = "desc_publicacion like '%" + text_libre.Text + "%' and";
            this.paginaActual = 1;
            int totalRegistros = publicacion.obtenerTotalRegistros_SU(this.condiciones + " " + this.condicion_necesaria);
            this.totalPaginas = calcularTotalDePaginas(totalRegistros);
            cargar_grid();
            for (int i = 0; i < check_list.Items.Count; i++)
                check_list.SetItemChecked(i, true);
        }

        private void boton_aplicar_Click(object sender, EventArgs e)
        {
            string condiciones = "desc_publicacion like '%" + text_libre.Text + "%'";
            string rubros = "(";
            //agrego el filtro por rubros
            for (int i = 0; i < check_list.Items.Count; i++)
                if (check_list.GetItemCheckState(i) == CheckState.Checked)
                {
                    rubros = rubros + "'" + check_list.Items[i] + "',";
                }

            if (rubros == "(")
            {
                rubros = rubros + "'')";
            }
            else
            {
                rubros = rubros.Remove(rubros.Length - 1) + ")";
            }
            
            this.condiciones = condiciones + " and desc_rubro in " + rubros + " and";
            this.paginaActual = 1;
            int totalRegistros = publicacion.obtenerTotalRegistros_SU(this.condiciones + " " + this.condicion_necesaria);
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

        private void button1_Click(object sender, EventArgs e)//pág sig
        {
            if (!(this.paginaActual == this.totalPaginas))
            {
                this.paginaActual += 1;
                cargar_grid();
            }
        }

        private void button2_Click(object sender, EventArgs e)//pág ant
        {
            if (!(this.paginaActual == 1))
            {
                this.paginaActual -= 1;
                cargar_grid();
            }
        }

        private void button4_Click(object sender, EventArgs e)//últ pág
        {
            this.paginaActual = this.totalPaginas;
            cargar_grid();
        }

        private void button3_Click(object sender, EventArgs e)//primer pág
        {
            this.paginaActual = 1;
            cargar_grid();
        }

        private void boton_limpiar_Click(object sender, EventArgs e)
        {
            text_libre.Text = ""; 
            for (int i = 1; i < check_list.Items.Count; i++)
                check_list.SetItemChecked(i, true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow fila = dataGridViewPub.SelectedRows[0];
                string publicacion = fila.Cells["descrip"].Value.ToString();
                float valor = float.Parse(fila.Cells["desc_precio"].Value.ToString());
                float costo_envio = float.Parse(fila.Cells["desc_costo_envio"].Value.ToString());
                int stock = Int32.Parse(fila.Cells["desc_stock"].Value.ToString());
                int id_publicacion = Int32.Parse(fila.Cells["id_publi"].Value.ToString());
                string fecha_venc = fila.Cells["desc_fecha_venc"].Value.ToString();

                Subastar unaSubasta = new Subastar(fecha_venc, publicacion, valor, costo_envio, stock, id_publicacion, this.unMenu);
                unaSubasta.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Elija solo una fila");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.unMenu.Show();
            this.Close();
        }
    }
}
