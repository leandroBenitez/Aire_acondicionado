using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.Generar_Publicación
{
    public partial class TipoDePubli : Form
    {
        private int id_usuario;
        public Menu menu;

        public TipoDePubli(int id_user, Menu un_menu)
        {
            InitializeComponent();
            id_usuario = id_user;
            menu = un_menu;
        }

        private void boton_compra_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra(id_usuario, menu);
            compra.Show();
            this.Hide();
        }

        private void boton_subasta_Click(object sender, EventArgs e)
        {
            Subasta subasta = new Subasta(id_usuario, menu);
            subasta.Show();
            this.Hide();
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}
