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

        public Publicaciones()
        {
            InitializeComponent();
            publicacion = new publicacionDAO();
            cargar_datos();
            cargar_grid("");
        }

        public void cargar_datos()
        {
            foreach (string aux in publicacion.get_Rubros())
            { combo_rubros.Items.Add(aux); }
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
            cargar_grid("desc_publicacion like '%" + text_libre.Text + "%'");
        }

        public void cargar_grid(string condiciones)
        {
            dataGridViewPub.Rows.Clear();

            SqlDataReader lectura = publicacion.get_publicaciones(condiciones);
            
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
            //if (string combo_rubros.Text)
        }
    }
}
