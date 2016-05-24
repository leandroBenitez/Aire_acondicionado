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
            cargarDatos();

        }

        public void cargarDatos()
        {
            /* CARGO EN COMBO DE DOMINIOS DE MAIL */
            comboDominio.Items.Add("hotmail.com");
            comboDominio.Items.Add("gmail.com");
            comboDominio.Items.Add("live.com");
        }

        /* VALIDAR TODOS LOS CAMPOS CONTRA LA BASE */
        private void buttonAlta_Click(object sender, EventArgs e)
        {



            /*
            // USERNAME EXISTENTE - SI ES = 1 ES PORQUE ES VALIDO EL NOMBRE
            if (abm_usuario.validarUsuarioExistente(textUsername.Text) == 1)
            {
                // COMPROBAR SI EL DNI EXISTE 
                if ( true ) //abm_usuario.validarDNIExistente(int.Parse(textDni.Text)) == 1  
                {
                    String username = textUsername.Text;
                    MessageBox.Show(username);
                    String password = textPassword.Text;
                    MessageBox.Show(password);
                    String rol = textRol.Text;
                    MessageBox.Show(rol);
                    String desc_Apellido = textApellido.Text;
                    MessageBox.Show(desc_Apellido);
                    String desc_Nombre = textNombre.Text;
                    MessageBox.Show(desc_Nombre);
                    int desc_Dni = int.Parse(textDni.Text);
                    Console.WriteLine(desc_Dni);
                    String desc_Mail = textMail.Text + "@" + comboDominio.SelectedItem.ToString();
                    MessageBox.Show(desc_Mail);
                    String desc_Dom_Calle = textCalle.Text;
                    MessageBox.Show(desc_Dom_Calle);
                    int desc_Nro_Calle = int.Parse(textAltura.Text);
                    Console.WriteLine(desc_Nro_Calle);
                    int desc_Piso = int.Parse(textPiso.Text);
                    Console.WriteLine(desc_Piso);
                    String desc_Depto = textDepto.Text;
                    MessageBox.Show(desc_Depto);
                    String desc_Localidad = textLocalidad.Text;
                    MessageBox.Show(desc_Localidad);
                    String desc_Cod_Postal = textCP.Text;
                    MessageBox.Show(desc_Cod_Postal);
                    int desc_Telefono = int.Parse(textTelefono.Text);
                    Console.WriteLine(desc_Telefono);
                    //DateTime desc_Fecha_Nac = DateTime(10,10,10);
               
                    // MANDO A SETEAR TABLAS USUARIO, ROLES_USUARIO Y CLIENTE - ME ESTA TIRANDO ERROR ESTO NO SE POR QUE 
                    //abm_usuario.setearCliente(username, password, rol, desc_Apellido, desc_Nombre, desc_Dni, desc_Mail, desc_Dom_Calle, desc_Nro_Calle, desc_Piso, desc_Depto, desc_Localidad, desc_Cod_Postal, desc_Telefono);

                }
                else
                {
                   MessageBox.Show("EL DNI YA ESTA REGISTRADO EN EL SISTEMA");
                }
            }
            else
            {
                MessageBox.Show("EL NOMBRE DE USUARIO YA EXISTE, POR FAVOR INGRESE OTRO");
            }
            */
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

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.Visible = false;
            // FALTARIA CARGA LA FECHA EN EL TEXT QUE NO ME LO ESTA CARGANDO EN EL FORMATO QUE QUIERO
            //textCalendar.Text = monthCalendar1.ToString();

        }

        private void textPiso_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
