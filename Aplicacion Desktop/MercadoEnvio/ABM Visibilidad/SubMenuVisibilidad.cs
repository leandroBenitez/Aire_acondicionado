using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.ABM_Visibilidad;

namespace MercadoEnvio.ABM_Visibilidad
{
    public partial class SubMenuVisibilidad : Form
    {
        Menu unMenu;

        public SubMenuVisibilidad(Menu menu)
        {
            InitializeComponent();
            unMenu = menu;
        }

        private void button_alta_Click(object sender, EventArgs e)
        {
            AltaVisibilidad alta = new AltaVisibilidad(this);
            alta.Show();
            this.Hide();
        }

        private void button_modificacion_Click(object sender, EventArgs e)
        {
            ModificacionVisibilidad modificacion = new ModificacionVisibilidad(this);
            modificacion.Show();
            this.Hide();
        }

        private void button_baja_Click(object sender, EventArgs e)
        {
            BajaVisibilidad baja = new BajaVisibilidad(this);
            baja.Show();
            this.Hide();
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
