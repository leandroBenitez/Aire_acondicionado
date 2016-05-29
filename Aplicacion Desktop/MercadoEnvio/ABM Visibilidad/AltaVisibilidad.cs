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
    public partial class AltaVisibilidad : Form
    {
        private ABM_Visibilidad_DAO abm_visibilidad;

        public AltaVisibilidad()
        {
            abm_visibilidad = new ABM_Visibilidad_DAO();
            InitializeComponent();
        }


        private void Guardar_Click(object sender, EventArgs e)
        {
            String desc_tipo = textNombre.Text;
            String desc_precio = textPrecio.Text;
            String desc_porcentaje = textPorcentaje.Text;
            String desc_porcentaje_envio = textEnvio.Text;
            
            abm_visibilidad.setearVisibilidad(desc_tipo, desc_precio, desc_porcentaje, desc_porcentaje_envio);
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            textNombre.Text = "";
            textPrecio.Text = "";
            textPorcentaje.Text = "";
            textEnvio.Text = "";
        }
    }
}
