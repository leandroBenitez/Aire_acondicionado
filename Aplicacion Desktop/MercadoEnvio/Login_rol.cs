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

namespace MercadoEnvio
{
    public partial class Login_rol : Form
    {
        private LoginDAO loginDao;
        private string usuario;
        private int id_usuario;

        public Login_rol(string user, int id_user)
        {
            InitializeComponent();
            loginDao = new LoginDAO();
            usuario = user;
            id_usuario = id_user;
            cargar_roles(id_user);
        }

        void cargar_roles(int id_usuario)
        {
            foreach (string aux in loginDao.get_roles(id_usuario))
            {
                combo_rol.Items.Add(aux);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(combo_rol.Text))
            {
                MessageBox.Show("Seleccione al menos un rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Menu menu = new Menu(usuario, id_usuario, combo_rol.Text);
                menu.Show();
                this.Hide();
            }
        }
    }
}
