using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.ABM_Usuario;
using MercadoEnvio.ABM_Cliente;
using MercadoEnvio.ABM_Empresa;

namespace MercadoEnvio.ABM_Usuario
{
    public partial class subMenuUsuario : Form
    {
        public subMenuUsuario()
        {
            InitializeComponent();
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.Show();
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {

        }

        private void buttonModCliente_Click(object sender, EventArgs e)
        {
            buscarCliente nuevaBusqueda = new buscarCliente();
            nuevaBusqueda.Show();
        }

        private void buttonModEmpresa_Click(object sender, EventArgs e)
        {
            buscarEmpresa nuevaBusqueda = new buscarEmpresa();
            nuevaBusqueda.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
