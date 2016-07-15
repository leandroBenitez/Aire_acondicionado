using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MercadoEnvio.DataBase.Conexion;
using System.Data.SqlClient;

namespace MercadoEnvio.ABM_Visibilidad
{
    public partial class ListadoVisibilidad : Form
    {
        ABM_Visibilidad_DAO abm_visibilidad;
        int id_vis;
        SubMenuVisibilidad unMenu;

        public ListadoVisibilidad(int id_visibilidad, SubMenuVisibilidad menu)
        {
            id_vis = id_visibilidad;
            unMenu = menu;
            abm_visibilidad = new ABM_Visibilidad_DAO();
            InitializeComponent();

            cargarTextBoxes(id_vis);
        }

        private void cargarTextBoxes(int id_vis)
        {
            textBoxTipo.Text = abm_visibilidad.get_descVisibilidadSegun(id_vis.ToString());
            textBoxPrecio.Text = abm_visibilidad.get_desc_precioVisibilidadSegun(id_vis.ToString()).ToString();
            textBoxPorcentaje.Text = abm_visibilidad.get_desc_porcentajeVisibilidadSegun(id_vis.ToString()).ToString();
            textBoxEnvio.Text = abm_visibilidad.get_desc_porcentaje_envioVisibilidadSegun(id_vis.ToString()).ToString();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            String desc_tipo = textBoxTipo.Text;
            String desc_precio = textBoxPrecio.Text;
            String desc_porcentaje = textBoxPorcentaje.Text;
            String desc_porcentaje_envio = textBoxEnvio.Text;

            try
            {
                if (abm_visibilidad.validar(desc_tipo, desc_precio, desc_porcentaje, desc_porcentaje_envio))
                {
                    abm_visibilidad.updateVisibilidad(id_vis, desc_tipo, float.Parse(desc_precio), float.Parse(desc_porcentaje), float.Parse(desc_porcentaje_envio));

                    MessageBox.Show("Visibilidad creada");

                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Modifique todos los campos o vuelva a ingresar los datos en cada campo");
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            textBoxTipo.Text = "";
            textBoxPrecio.Text = "";
            textBoxPorcentaje.Text = "";
            textBoxEnvio.Text = "";
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
            unMenu.Show();
        }

        private void textBoxTipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
