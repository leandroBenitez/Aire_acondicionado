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
    public partial class Login : Form
    {
        private LoginDAO loginDAO;

        public Login()
        {
            leerArchivoConfig();
            loginDAO = new LoginDAO();
            InitializeComponent();
            loginDAO.iniciar_aplicacion();
        }

        private void leerArchivoConfig()
        {
            try
            {
                using (StreamReader sr = new StreamReader("ArchivoConfiguracion.txt"))
                {
                    string line, textoArchivo = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        textoArchivo = textoArchivo + line + "\n";
                    }

                    char[] delimitadores = { ' ', ',', '.', '\t', '\n' };

                    string[] palabras = textoArchivo.Split(delimitadores);

                    ConstantesBD.fechaSistema = palabras[2];
                    ConstantesBD.Param_Conexion_urlServidor = palabras[9];
                    ConstantesBD.Param_Conexion_usuario = palabras[14];
                    ConstantesBD.Param_Conexion_contraseña = palabras[17];
                    ConstantesBD.Param_Conexion_nombreBD = palabras[24];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al leer el archivo de configuracion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(textBox_user.Text)) || (string.IsNullOrWhiteSpace(textBox_pass.Text)))
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string mensaje = this.loginDAO.validar_login(textBox_user.Text, textBox_pass.Text);
                switch (mensaje)
                { 
                    case "invalido":
                        MessageBox.Show("El usuario no existe en el sistema.", "Usuario Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "inhabilitado":
                        MessageBox.Show("El usuario se encuentra bloqueado.", "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "incorrecto":
                        MessageBox.Show("La contraseña ingresa es incorrecta.", "Contraseña Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "correcto":
                        int id_usuario = loginDAO.get_id_usuario(textBox_user.Text);
                        int cant_roles = loginDAO.get_number_roles(id_usuario);

                        if (cant_roles == 0)
                        {
                            MessageBox.Show("El usuario no posee roles habilitados.", "Roles Inhabilitados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string rol = loginDAO.get_unique_rol(id_usuario);

                            if (cant_roles == 1)
                            {
                                Menu menu = new Menu(textBox_user.Text, id_usuario, rol);
                                menu.Show();
                                this.Hide();
                            }
                            else
                            {
                                Login_rol logins = new Login_rol(textBox_user.Text, id_usuario);
                                logins.Show();
                                this.Hide();
                            }
                        }
                    break;
                }
            }
        }
    }
}
