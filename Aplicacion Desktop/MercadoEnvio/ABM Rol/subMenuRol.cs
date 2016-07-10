using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.ABMRol;
using MercadoEnvios.ABM_Rol;
using MercadoEnvio.ABM_Rol;

namespace MercadoEnvio.ABM_Rol
{
    public partial class subMenuRol : Form
    {
        public subMenuRol()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            altaRol altaRol = new altaRol();
            altaRol.Show();
        }

        private void subMenuRol_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bajaRol bajaRol = new bajaRol();
            bajaRol.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificacionRol modRol = new ModificacionRol();
            modRol.Show();
        }
    }
}
