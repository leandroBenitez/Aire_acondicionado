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
            /* CARGO EL COMBO CON LOS DOMINIO DE EMAIL*/
            comboDominio.Items.Add("hotmail.com");
            comboDominio.Items.Add("gmail.com");
            comboDominio.Items.Add("live.com");
            /* --------------------------------------*/

            //textUsername.Text = empresaMod.get
            //textRol.Text = empresaMod.getR
            textRazonSoc.Text = empresaMod.getRazSoc();
            textMail.Text = empresaMod.getMail();
            // selecciono dominio del combo
            textTelefono.Text = empresaMod.getTelefono();
            textDireccion.Text = empresaMod.getDomCalle();
            textAltura.Text = empresaMod.getNroCalle();
            textPiso.Text = empresaMod.getPiso();
            textDepto.Text = empresaMod.getDepto();
            textCP.Text = empresaMod.getCodPos();
            textLocalidad.Text = empresaMod.getLocalidad();
            textCuit1.Text = empresaMod.getCuit();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            //abm_usuario.actualizarEmpresa(razonSoc, descMail, descTelefono, descCalle, nroCalle, depto, localidad, codPos, ciudad, cuit, nombreContacto, idRubro, idEmpresa)
        }

    }
}
