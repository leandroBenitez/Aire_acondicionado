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

namespace MercadoEnvio
{
    public partial class Change_Password : Form
    {
        private LoginDAO loginDAO;
        private Menu menu;


        public Change_Password(Menu un_menu)
        {
            InitializeComponent();
            this.menu = un_menu;
            this.menu.Enabled = false;
            loginDAO = new LoginDAO();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.menu.Enabled = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pass.Text) ||
                string.IsNullOrWhiteSpace(new_pass.Text) ||
                string.IsNullOrWhiteSpace(new_pass2.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (new_pass.Text != new_pass2.Text)
                {
                    MessageBox.Show("Las nuevas contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (loginDAO.verificar_pass(pass.Text, this.menu.id_usuario) == "OK")
                    {
                        loginDAO.cambiar_pass(new_pass.Text, this.menu.id_usuario);
                        MessageBox.Show("La contraseña ha sido modificada.", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.menu.Enabled = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña actual ingresada no coincide.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }
    }
}
