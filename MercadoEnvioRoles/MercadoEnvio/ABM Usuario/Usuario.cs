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
            comboBoxRoles.Items.Add("Cliente");
            comboBoxRoles.Items.Add("Empresa");
        }
    }
}
