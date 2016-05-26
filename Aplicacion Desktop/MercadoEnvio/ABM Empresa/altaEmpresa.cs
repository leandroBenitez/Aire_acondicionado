using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.ABM_Empresa
{
    public partial class altaEmpresa : Form
    {
        public altaEmpresa(String username, String password, String rol)
        {
            InitializeComponent();
            cargarDatos(username, password, rol);
        }

        public void cargarDatos(String username, String password, String rol)
        {
            textUsername.Text = username;
            textPassword.Text = password;
            textRol.Text = rol;
        }

    }
}
