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

namespace MercadoEnvio.Generar_Publicación
{
    public partial class Mis_publicaciones : Form
    {
        private publicacionDAO publicacion;
        private Menu un_menu;

        public Mis_publicaciones(Menu menu)
        {
            publicacion = new publicacionDAO();
            InitializeComponent();
            this.un_menu = menu;
            cargar_combo_estados();
            cargar_grid(this.un_menu.id_usuario);
        }

        public void cargar_combo_estados()
        {
            foreach (string aux in publicacion.get_Estados())
            { combo_estados.Items.Add(aux); }
        }

        public void cargar_grid(int id_usuario)
        {
            dataGridViewPub.Rows.Clear();

            SqlDataReader lectura = publicacion.get_publicaciones_propias(id_usuario);

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[11];

            while (lectura.Read())
            {
                columnas[0] = lectura["id_publicacion"].ToString();
                columnas[1] = lectura["desc_publicacion"].ToString();
                columnas[2] = lectura["desc_tipo_public"].ToString();
                columnas[3] = lectura["desc_stock"].ToString();
                columnas[4] = lectura["desc_precio"].ToString();
                columnas[5] = lectura["desc_costo_envio"].ToString();
                columnas[6] = lectura["fecha_publicacion"].ToString();
                columnas[7] = lectura["fecha_vencimiento"].ToString();
                columnas[8] = lectura["desc_rubro"].ToString();
                columnas[9] = lectura["desc_tipo"].ToString();
                columnas[10] = lectura["desc_estado"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewPub, columnas);
            }
            lectura.Close();
            dataGridViewPub.Rows.AddRange(filas.ToArray());
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.un_menu.Show();
            this.Close();
        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow fila = dataGridViewPub.SelectedRows[0];
                int publicacion_actual = Int16.Parse(fila.Cells["Column1"].Value.ToString());
                string estado_actual = fila.Cells["Column11"].Value.ToString();

                if (estado_actual == "Finalizada")
                {
                    MessageBox.Show("La publicacion ya esta finalizada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    publicacion.cambiar_Estado(publicacion_actual, combo_estados.Text);
                }
            }
            catch
            {
                MessageBox.Show("Elija solo una fila");
            }
        }
    }
}
