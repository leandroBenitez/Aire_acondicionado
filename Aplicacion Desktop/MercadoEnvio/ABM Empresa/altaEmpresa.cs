using MercadoEnvio.ABM_Usuario;
using MercadoEnvio.DataBase.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.ABM_Empresa
{
    public partial class altaEmpresa : Form
    {
        private ABM_usuario_DAO abm_usuario;

        public altaEmpresa(String username, String password, String rol)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            cargarDatos(username, password, rol);
        }

        public void cargarDatos(String username, String password, String rol)
        {
            comboDominio.Items.Add("hotmail.com");
            comboDominio.Items.Add("gmail.com");
            comboDominio.Items.Add("live.com");

            textUsername.Text = username;
            textPassword.Text = password;
            textRol.Text = rol;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Usuario formUsuario = new Usuario();
            formUsuario.Show();
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            if (abm_usuario.validarRazSocExistente(textRazonSoc.Text) == 1)
            {
                if (textCuit1.Text == "" || textCuit2.Text == "" || textCuit3.Text == "")
                {
                    MessageBox.Show("Debe ingresar un numero de cuit valido");
                }
                else
                {
                    String cuit = textCuit1.Text + "-" + textCuit2.Text + "-" + textCuit3.Text;
                    if (abm_usuario.validarCuitExistente(cuit) == 1)
                    {

                        if (comboDominio.SelectedItem == null)
                        {
                            MessageBox.Show("Debe ingresar un dominio de email. Ayuda: seleccione una de las opciones dadas");
                        }
                        else
                        {
                            String username = textUsername.Text;
                            String password = textPassword.Text;
                            String rol = textRol.Text;
                            String razSoc = textRazonSoc.Text;
                            String desc_Mail = textMail.Text + "@" + comboDominio.SelectedItem.ToString();
                            String telefono = textTelefono.Text;
                            String fecha_creacion =  textDia.Text + "/" + textMes.Text + "/" + textAnio.Text;
                            String direccion = textDireccion.Text;
                            String altura = textAltura.Text;
                            String piso = textPiso.Text;
                            String depto = textDepto.Text;
                            String localidad = "";
                            String codPos = textCP.Text;
                            String ciudad = "";
        
                            // MANDO A SETEAR TABLAS USUARIO, ROLES_USUARIO Y CLIENTE - ME ESTA TIRANDO ERROR ESTO NO SE POR QUE 
                            abm_usuario.setearEmpresa(username, password, rol, razSoc, desc_Mail, telefono, fecha_creacion, direccion, altura, piso, depto, localidad,  codPos, ciudad, cuit);

                            // VUELVO AL MENU PRINCIPAL DE LOS ADMINISTRADORES QUE TODAVIA NO ESTÁ CREADO

                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("El numero de CUIT ya existe");
                    }
                }
            }
            else
            {
                MessageBox.Show("El numero de razon social ya existe, por favor ingrese otro");
            }

        }

    }
}
