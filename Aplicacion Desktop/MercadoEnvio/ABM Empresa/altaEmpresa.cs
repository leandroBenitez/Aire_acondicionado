﻿using MercadoEnvio.ABM_Usuario;
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

            /* SETEO LA FECHA DE CREACION LEVANTANDOLA DESDE EL ARCHIVO DE CONFIGURACION */
            textFechaSist.Text = ConstantesBD.fechaSistema;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Usuario formUsuario = new Usuario();
            formUsuario.Show();
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (textRazonSoc.Text == "")
                    MessageBox.Show("Ingresar un número de razón social, es obligatorio");
                else
                {
                    if (abm_usuario.validarRazSocExistente(textRazonSoc.Text) == 1)
                    {
                        if (textCuit1.Text.LongCount() != 2 || textCuit2.Text.LongCount() != 8 || textCuit3.Text.LongCount() != 2)
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
                                    String fecha_creacion = textFechaSist.Text;
                                    String direccion = textDireccion.Text;
                                    String altura = textAltura.Text;
                                    String piso = textPiso.Text;
                                    String depto = textDepto.Text;
                                    String localidad = textLocalidad.Text;
                                    String codPos = textCP.Text;
                                    String ciudad = textCiudad.Text;
                                    String rubro = textRubro.Text;
                                    String nombreContacto = textNameContact.Text;

                                    // MANDO A SETEAR TABLAS USUARIO, ROLES_USUARIO Y CLIENTE - ME ESTA TIRANDO ERROR ESTO NO SE POR QUE 
                                    abm_usuario.setearEmpresa(username, password, rol, razSoc, desc_Mail, telefono, fecha_creacion, direccion, altura, piso, depto, localidad, codPos, ciudad, cuit, rubro, nombreContacto);

                                    // VUELVO
                                    MessageBox.Show("La empresa ha sido creada exitosamente!");
                                    this.Close();
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
            catch
            {
                MessageBox.Show("Verifique los datos ingresados");
            }
        }

        private void altaEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

    }
}
