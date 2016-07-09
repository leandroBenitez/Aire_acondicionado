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
        public Menu menu;
        
        public HistorialMiCuenta(int id_user, Menu un_menu)
        {
            InitializeComponent();
            id_usuario = id_user;
            menu = un_menu;
        }

        private void MostrarFacturacion_Click(object sender, EventArgs e)
        {
            HistorialFacturas formHistorialFacturas = new HistorialFacturas(this.id_usuario);
            formHistorialFacturas.Show();
        }

        private void MostrarCompras_Click(object sender, EventArgs e)
        {
            HistorialCompras formHistorialCompras = new HistorialCompras(this.id_usuario);
            formHistorialCompras.Show();
        }

        private void MostrarComprasCalificadas_Click(object sender, EventArgs e)
        {
            HistorialComprasCalificadas formHistorialEstrellasOtorgadas = new HistorialComprasCalificadas(this.id_usuario);
            formHistorialEstrellasOtorgadas.Show();
        }


        private void MostrarComprasSinCalificar_Click(object sender, EventArgs e)
        {
            HistorialComprasSinCalificar formHistorialEstrellasPorOtorgar = new HistorialComprasSinCalificar(this.id_usuario);
            formHistorialEstrellasPorOtorgar.Show();
        }

        private void MostrarCalificacionesRecibidas_Click(object sender, EventArgs e)
        {
            HistorialCalificacionesRecibidas formHistorailCalificacionesRecibidas = new HistorialCalificacionesRecibidas(this.id_usuario);
            formHistorailCalificacionesRecibidas.Show();
        }

    
       private void MostrarSubastas_Click(object sender, EventArgs e)
        {
            HistorialSubastas formHistorialSubastas = new HistorialSubastas(this.id_usuario);
            formHistorialSubastas.Show();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            menu.Show();//cambio para menu
            this.Close();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

             
    }
}
