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

namespace MercadoEnvio.ABM_Usuario
{
    public partial class seleccionRoles : Form
    {
        private ABM_Rol_DAO abm_rol;
        public seleccionRoles()
        {
            abm_rol = new ABM_Rol_DAO();
            InitializeComponent();
            cargarComboDeNombres();
        }

        public void cargarComboDeNombres()
        {
            foreach (string nombre in abm_rol.get_roles())
            {
                comboNombresRoles.Items.Add(nombre);
            }
        }

        public void comboNombresRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
