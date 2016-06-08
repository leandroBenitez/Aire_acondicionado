using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.DataBase.Entidades;
using MercadoEnvio.DataBase.Conexion;

namespace MercadoEnvio.ABM_Cliente
{
    public partial class modificacionCliente : Form
    {
        ABM_usuario_DAO abm_usuario;        
        public modificacionCliente(Cliente clienteMod)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            cargarDatos(clienteMod);
        }

        public void cargarDatos(Cliente clienteMod)
        {
            textUsername.Text = clienteMod.getUsername();
            textNombre.Text = clienteMod.getNombre();
            textApellido.Text = clienteMod.getApellido();
            textDni.Text = clienteMod.getDni();
            // tipo doc

            /* DESCOMPONGO EL MAIL*/
            String mail = clienteMod.getMail();
            int posicionArroba = mail.IndexOf("@");
            String dominio = mail.Substring(posicionArroba, mail.Count()-1);


            /* CARGO EN COMBO DE DOMINIOS DE MAIL */
            comboDominio.Items.Add("hotmail.com");
            comboDominio.Items.Add("gmail.com");
            comboDominio.Items.Add("live.com");
            /* SELECCIONAR OPCION DEL COMBO CORRESPONDIENTE - FALTA PROBAR*/
            comboDominio.SelectedValue = dominio;

            textDireccion.Text = clienteMod.getDireccion();
            textPiso.Text = clienteMod.getPiso();
            textAltura.Text = clienteMod.getNroCalle();
            textDepto.Text = clienteMod.getDepto();
            textLocalidad.Text = clienteMod.getLocalidad();
            textTelefono.Text = clienteMod.getTelefono();
            textCalendar.Text = clienteMod.getFecha_nacimiento();
            textCP.Text = clienteMod.getCodigo_postal();
            textFecCreacion.Text = clienteMod.getFechaCreacion();
            //textRol.Text = clienteMod.getRol();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {   
            String mail = textMail.Text + "@" + comboDominio.SelectedItem.ToString();
            String id_cliente = "1";

            abm_usuario.actualizarCliente(id_cliente, textNombre.Text, textApellido.Text, textDni.Text, comboTipoDoc.SelectedItem.ToString(), mail, textTelefono.Text, textDireccion.Text, textAltura.Text, textPiso.Text, textDepto.Text, textLocalidad.Text, textCP.Text, textCalendar.Text, textFecCreacion.Text);
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeshabilitar_Click(object sender, EventArgs e)
        {
            //abm_usuario.deshabilitarUsuario();
        } 

    }
}
