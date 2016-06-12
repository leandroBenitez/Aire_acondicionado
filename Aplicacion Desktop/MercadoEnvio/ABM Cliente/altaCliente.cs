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
    public partial class altaCliente : Form
    {
        private ABM_usuario_DAO abm_usuario;

        public altaCliente(String username, String password, String rol)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            cargarDatos(username, password, rol);
        }

        public void cargarDatos(String username, String password, String rol)
        {
            /* CARGO EN COMBO DE DOMINIOS DE MAIL */
            comboDominio.Items.Add("hotmail.com");
            comboDominio.Items.Add("gmail.com");
            comboDominio.Items.Add("live.com");

            /* CARGO EL COMBO DE LOS TIPOS DE DOCUMENTO */
            comboTipoDoc.Items.Add("DNI");

            /* SETEO LOS CAMPOS CON LAS VARIABLES RECIBIDAS */
            textUsername.Text = username;
            textPassword.Text = password;
            textRol.Text = rol;
        }

        /* VALIDAR TODOS LOS CAMPOS CONTRA LA BASE */
        private void buttonAlta_Click(object sender, EventArgs e)
        {
                // DNI EXISTENTE - SI ES = 1 ES PORQUE ES VALIDO EL DNI (NO ESTÁ INGRESADO TODAVIA)
                if ( abm_usuario.validarDNIExistente(textDni.Text) == 1  )
                {
                    if (comboDominio.SelectedItem == null)
                    {
                        MessageBox.Show("Debe ingresar un dominio de email. Ayuda: seleccione una de las opciones dadas");
                    }
                    else if (comboTipoDoc.SelectedItem == null)
                    {
                        MessageBox.Show("Debe ingresar un tipo de documento. Ayuda: seleccione una de las opciones dadas");
                    }
                    else
                    {
                        String username = textUsername.Text;
                        String password = textPassword.Text;
                        String rol = textRol.Text;
                        String desc_Apellido = textApellido.Text;
                        String desc_Nombre = textNombre.Text;
                        String desc_Dni = textDni.Text;
                        String tipo_doc = comboTipoDoc.SelectedItem.ToString();
                        String desc_Mail = textMail.Text + "@" + comboDominio.SelectedItem.ToString();
                        String desc_Dom_Calle = textCalle.Text;
                        String desc_Nro_Calle = textAltura.Text;
                        String desc_Piso = textPiso.Text;
                        String desc_Depto = textDepto.Text;
                        String desc_Localidad = textLocalidad.Text;
                        String desc_Cod_Postal = textCP.Text;
                        String desc_Telefono = textTelefono.Text;
                        String desc_Fecha_Nac = textDia.Text + "/" + textMes.Text + "/" + textAnio.Text;
                        String desc_fecha_creacion = textFecCreacion.Text;


                        // MANDO A SETEAR TABLAS USUARIO, ROLES_USUARIO Y CLIENTE - ME ESTA TIRANDO ERROR ESTO NO SE POR QUE 
                        abm_usuario.setearCliente(username, password, rol, desc_Apellido, desc_Nombre, desc_Dni, tipo_doc, desc_Mail, desc_Dom_Calle, desc_Nro_Calle, desc_Piso, desc_Depto, desc_Localidad, desc_Cod_Postal, desc_Telefono, desc_Fecha_Nac, desc_fecha_creacion);
                                                                                                                                                                                                                                                                    
                        // VUELVO AL MENU PRINCIPAL DE LOS ADMINISTRADORES QUE TODAVIA NO ESTÁ CREADO

                    }
                }
                else
                {
                   MessageBox.Show("El DNI ingresado ya está registrado en el sistema");
                }
        }

        private void buttonSelectRol_Click(object sender, EventArgs e)
        {
            // ARIR FORM SELECCION DE ROLES Y OBTENER ROL ELEGIDO
            seleccionRoles formSeleccion = new seleccionRoles();
            formSeleccion.Show();
            //textRol.Text = formSeleccion.comboNombresRoles.SelectedItem.ToString(); NO ANDA, VER
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

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Usuario formUsuario = new Usuario();
            formUsuario.Show();
        }
    }
}
