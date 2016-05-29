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

        public ListadoVisibilidad(int id_visibilidad)
        {
            id_vis = id_visibilidad;
            abm_visibilidad = new ABM_Visibilidad_DAO();
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            String desc_tipo = textBoxTipo.Text;
            String desc_precio = textBoxPrecio.Text;
            String desc_porcentaje = textBoxPorcentaje.Text;
            String desc_porcentaje_envio = textBoxEnvio.Text;

            abm_visibilidad.updateVisibilidad(id_vis, desc_tipo, desc_precio, desc_porcentaje, desc_porcentaje_envio);
        }

        private void textBoxTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            textBoxTipo.Text = "";
            textBoxPrecio.Text = "";
            textBoxPorcentaje.Text = "";
            textBoxEnvio.Text = "";
        }
    }
}
