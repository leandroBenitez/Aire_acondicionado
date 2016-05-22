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
            cargar_roles_combobox();
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

        private void cargar_roles_combobox()
        {
            foreach (string aux in loginDAO.get_roles())
            {
                comboBox_roles.Items.Add(aux);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //If (string.IsNullOrWhiteSpace(un_texto))
            //{
            //    MessageBox.Show("Ingrese un usuario valido.", "Error", MessageBoxButtons.OK,    MessageBoxIcon.Warning);
            //}
            
           // If (textBox_user)  
           // textBox_pass
        }

        public void verificar_texto_vacio(string un_texto)
        { 
            if (string.IsNullOrWhiteSpace(un_texto))
            {
                
            }
            else
            {
                
            }
        }
    }
}
