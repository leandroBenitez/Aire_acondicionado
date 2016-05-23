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
using System.Data.SqlClient;

namespace MercadoEnvio.ABM_Usuario
{
    public partial class altaUsuarioCliente : Form
    {
        private ABM_usuario_DAO abm_usuario;

        public altaUsuarioCliente()
        {
            leerArchivoConfig();
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
        }

        /* VALIDAR TODOS LOS CAMPOS CONTRA LA BASE */
        private void buttonAlta_Click(object sender, EventArgs e)
        {
            String id_usuario = "0";
            // USERNAME EXISTENTE
            if (abm_usuario.validarUsuarioExistente(textUsername.Text) == 1)
            {
                
            }

            String desc_Apellido = "";
            String desc_Nombre = "";
	        int desc_Dni = 0;
            String desc_Mail = "";
            String desc_Dom_Calle = "";
	        int desc_Nro_Calle = 0;
	        int desc_Piso = 0;
            String desc_Depto = "";
            String desc_Localidad = "";
            String desc_Cod_Postal = "";
            int desc_Telefono = 0;
            DateTime desc_Fecha_Nac = DateTime(10,10,10);

            if (true)
            {
                abm_usuario.setearCliente(id_usuario, desc_Apellido, desc_Nombre, desc_Dni, desc_Mail, desc_Dom_Calle, desc_Nro_Calle, desc_Piso, desc_Depto, desc_Localidad, desc_Cod_Postal, desc_Telefono, desc_Fecha_Nac);
            }
            else 
            {

                // DNI EXISTENTE
            }
        }

        private DateTime DateTime(int p1, int p2, int p3)
        {
            throw new NotImplementedException();
        }

        private void buttonSelectRol_Click(object sender, EventArgs e)
        {
            // ARIR FORM SELECCION DE ROLES Y OBTENER ROL ELEGIDO
            seleccionRoles formSeleccion = new seleccionRoles();
            formSeleccion.Show();
            //textRol.Text = formSeleccion.comboNombresRoles.SelectedItem.ToString(); NO ANDA, VER

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
