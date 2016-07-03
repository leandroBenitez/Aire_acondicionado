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

        /* CARGO TODOS LOS DATOS DEL USUARIO SEGUN LA TABLA LK_CLIENTE*/
        public void cargarDatos(Cliente clienteMod)
        {
            textUsername.Text = clienteMod.getUsername();
            textNombre.Text = clienteMod.getNombre();
            textApellido.Text = clienteMod.getApellido();
            comboTipoDoc.Text = clienteMod.getTipoDoc();
            textDni.Text = clienteMod.getDni();

            /* DESCOMPONGO EL MAIL*/
            String emailEntero = clienteMod.getMail();
            int posicionArroba = emailEntero.IndexOf("@");
            String mail = emailEntero.Substring(0,posicionArroba); //ok
            String dominio = emailEntero.Substring(posicionArroba + 1, emailEntero.Length - mail.Length - 1); //ok
            textMail.Text = mail;

            /* CARGO EL COMBO DE TIPOS DE DOCUMENTOS */
            comboTipoDoc.Items.Add("DNI");

            /* CARGO EL COMBO DE DOMINIOS DE MAIL */
            comboDominio.Items.Add("hotmail.com");
            comboDominio.Items.Add("gmail.com");
            comboDominio.Items.Add("live.com");
            comboDominio.Text = dominio;

            textDireccion.Text = clienteMod.getDireccion();
            textPiso.Text = clienteMod.getPiso();
            textAltura.Text = clienteMod.getNroCalle();
            textDepto.Text = clienteMod.getDepto();
            textLocalidad.Text = clienteMod.getLocalidad();
            textTelefono.Text = clienteMod.getTelefono();
            textCalendar.Text = clienteMod.getFecha_nacimiento();
            textCP.Text = clienteMod.getCodigo_postal();
            textFecCreacion.Text = clienteMod.getFechaCreacion();
            if (abm_usuario.getEstadoUsuario(clienteMod.getUsername()) == "1")
            {
                textEstado.Text = "Habilitado";
            }
            else
            {
                textEstado.Text = "Desabilitado";
            }
        }

        /*MODIFICO AL USUARIO - OK */
        private void buttonMod_Click(object sender, EventArgs e)
        {   
            String mail = textMail.Text + "@" + comboDominio.SelectedItem.ToString();
            abm_usuario.actualizarCliente(textUsername.Text, textNombre.Text, textApellido.Text, textDni.Text, comboTipoDoc.Text, mail, textTelefono.Text, textDireccion.Text, textAltura.Text, textPiso.Text, textDepto.Text, textLocalidad.Text, textCP.Text, "10/10/10", "10/10/10");
            this.Close();
        }

        /* OK */
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* HABILITA O DESHABILITA AL USUARIO DEPENDIENDO EN QEU ESTADO ESTÉ - OK*/
        private void buttonDeshabilitar_Click(object sender, EventArgs e)
        {
            if (abm_usuario.getEstadoUsuario(textUsername.Text) == "1")
            {
                abm_usuario.deshabilitarUsuario(textUsername.Text);
                MessageBox.Show("El Uusario ha sido deshabilitado exitosamente");
            }else
            {
                abm_usuario.habilitarUsuario(textUsername.Text);
                MessageBox.Show("El Uusario ha sido habilitado exitosamente");
            }
            this.Close();
        }

        private void modificacionCliente_Load(object sender, EventArgs e)
        {

        } 

    }
}
