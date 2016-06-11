using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.DataBase.Conexion;
using MercadoEnvio.DataBase.Entidades;

namespace MercadoEnvio.ABM_Empresa
{
    public partial class modificacionEmpresa : Form
    {
        ABM_usuario_DAO abm_usuario;
        public modificacionEmpresa(Empresa empresaMod)
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            cargarDatos(empresaMod);
        }

        public void cargarDatos(Empresa empresaMod)
        {
            /* DESCOMPONGO EL MAIL*/
            String emailEntero = empresaMod.getMail();
            int posicionArroba = emailEntero.IndexOf("@");
            String mail = emailEntero.Substring(0, posicionArroba); //ok
            String dominio = emailEntero.Substring(posicionArroba + 1, emailEntero.Length - mail.Length - 1); //ok
            textMail.Text = mail;

            /* CARGO EL COMBO DE DOMINIOS DE MAIL */
            comboDominio.Items.Add("hotmail.com");
            comboDominio.Items.Add("gmail.com");
            comboDominio.Items.Add("live.com");
            comboDominio.Text = dominio;
            /* --------------------------------------*/

            textRazonSoc.Text = empresaMod.getRazSoc();
            textUsername.Text = empresaMod.getIdUsername();
            textTelefono.Text = empresaMod.getTelefono();
            textDireccion.Text = empresaMod.getDomCalle();
            textAltura.Text = empresaMod.getNroCalle();
            textPiso.Text = empresaMod.getPiso();
            textDepto.Text = empresaMod.getDepto();
            textCP.Text = empresaMod.getCodPos();
            textLocalidad.Text = empresaMod.getLocalidad();
            textCuit1.Text = empresaMod.getCuit();
            textFechaCreacion.Text = empresaMod.getFechaCreacion();
            textRubro.Text = empresaMod.getRubro();
            textNombreContacto.Text = empresaMod.getNombreContacto();
            if (abm_usuario.getEstadoUsuario(empresaMod.getIdUsername()) == "1")
            {
                textEstado.Text = "Habilitado";
            }
            else
            {
                textEstado.Text = "Deshabilitado";
            }
        }

        /* ACTUALIZO LOS DATOS DE LA EMPRESA */
        private void buttonMod_Click(object sender, EventArgs e)
        {
            String mail = textMail.Text + "@" + comboDominio.SelectedItem.ToString();
            abm_usuario.actualizarEmpresa(textRazonSoc.Text, mail, textTelefono.Text, textDireccion.Text, textAltura.Text, textDepto.Text, textLocalidad.Text, textCP.Text, textCiudad.Text, textCuit1.Text, textNombreContacto.Text, textRubro.Text, "idEmp");
        }


        /* HABILITA O DESHABILITA AL USUARIO DEPENDIENDO EN QEU ESTADO ESTÉ - OK*/
        private void buttonDeshabilitar_Click(object sender, EventArgs e)
        {
            if (abm_usuario.getEstadoUsuario(textUsername.Text) == "1")
            {
                abm_usuario.deshabilitarUsuario(textUsername.Text);
                MessageBox.Show("El Uusario ha sido deshabilitado exitosamente");
            }
            else
            {
                abm_usuario.habilitarUsuario(textUsername.Text);
                MessageBox.Show("El Uusario ha sido habilitado exitosamente");
            }
            this.Close();
        } 

    }
}
