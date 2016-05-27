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
using MercadoEnvio.ABM_Empresa;

namespace MercadoEnvio.ABM_Usuario 
{
    public partial class Usuario : Form
    {
        private ABM_usuario_DAO abm_usuario;
        public Usuario()
        {
            leerArchivoConfig();
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            this.cargar_items_comboboxroles();
        }

        private void cargar_items_comboboxroles()
        {
            comboBoxRol.Items.Add("Cliente");
            comboBoxRol.Items.Add("Empresa");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxRol.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de rol existente. Ayuda: utilice las opciones proporcionadas");
            }
            else
            {
                String rol = comboBoxRol.SelectedItem.ToString();
                if (comboBoxRol.SelectedItem.ToString().Equals("Cliente"))
                {
                    altaCliente formAltaCliente = new altaCliente(textUsername.Text, textPassword.Text, comboBoxRol.SelectedItem.ToString());
                    int existe = abm_usuario.validarUsuarioExistente(textUsername.Text);
                    /* SI NO EXISTE, MUESTRO EL FORM PARA CARGAR TODOS LOS DATOS */
                    if (existe == 1)
                    {
                        formAltaCliente.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El nombre de usuario infresado ya existe, por favor intente nuevamente");
                    }


                }
                else if (comboBoxRol.SelectedItem.ToString().Equals("Empresa"))
                {
                    altaEmpresa formAltaEmpresa = new altaEmpresa(textUsername.Text, textPassword.Text, comboBoxRol.SelectedItem.ToString());
                    //VERIFICAR DATOS (USERNAME)
                    formAltaEmpresa.Show();
                    this.Hide();
                }
            }
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

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
    }
}
