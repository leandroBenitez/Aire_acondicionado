using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.Historial_Cliente
{
    public partial class HistorialMiCuenta : Form
    {
        private int id_usuario;

        public HistorialMiCuenta(int id)
        {
            InitializeComponent();
            id_usuario = id;
        }

        private void MostrarFacturacion_Click(object sender, EventArgs e)
        {
            HistorialFacturas formHistorialFacturas = new HistorialFacturas(this.id_usuario);
            formHistorialFacturas.Show();
        }

        private void MostrarEstrellasOtorgadas_Click(object sender, EventArgs e)
        {

        }

        private void MostrarEstrellasPorOtorgar_Click(object sender, EventArgs e)
        {

        }
      
        private void MostrarCompras_Click(object sender, EventArgs e)
        {
            HistorialCompras formHistorialCompras = new HistorialCompras();
            formHistorialCompras.Show();
        }

        private void MostrarSubastas_Click(object sender, EventArgs e)
        {
            HistorialSubastas formHistorialSubastas = new HistorialSubastas();
            formHistorialSubastas.Show();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
