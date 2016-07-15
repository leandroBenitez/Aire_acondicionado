using MercadoEnvio.ListadoCalificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.Calificaciones
{
    public partial class SubMenuCalificar : Form
    {
        Menu unMenu;
        int id_usuario;

        public SubMenuCalificar(Menu menu, int usuario)
        {
            unMenu = menu;
            id_usuario = usuario;

            InitializeComponent();
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void button_calificar_Click(object sender, EventArgs e)
        {
            ListadoSinCalificar listado = new ListadoSinCalificar(unMenu, id_usuario, this);
            listado.Show();
            this.Hide();
        }

        private void button_informe_Click(object sender, EventArgs e)
        {
            InformeCalificar informe = new InformeCalificar(id_usuario, this);
            informe.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InformeCalificarSubasta informe = new InformeCalificarSubasta(id_usuario, this);
            informe.Show();
            this.Hide();
        }
    }
}
