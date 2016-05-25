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
using MercadoEnvio.ABM_Empresa;

namespace MercadoEnvio.ABM_Usuario 
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
            this.cargar_items_comboboxroles();
        }

        private void cargar_items_comboboxroles()
        {
            comboBoxRol.Items.Add("Cliente");
            comboBoxRol.Items.Add("Empresa");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String rol = comboBoxRol.SelectedItem.ToString();

            if (comboBoxRol.SelectedItem.ToString().Equals("Cliente"))
            {
                altaUsuarioCliente formAltaCliente = new altaUsuarioCliente();
                formAltaCliente.Show();

            } if (comboBoxRol.SelectedItem.ToString().Equals("Empresa"))
            {
                altaEmpresa formAltaEmpresa = new altaEmpresa();
                formAltaEmpresa.Show();

            }


        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
