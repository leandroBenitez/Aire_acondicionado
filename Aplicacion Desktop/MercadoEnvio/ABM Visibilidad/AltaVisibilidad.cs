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

namespace MercadoEnvio.ABM_Visibilidad
{
    public partial class AltaVisibilidad : Form
    {
        private ABM_Visibilidad_DAO abm_visibilidad;
        SubMenuVisibilidad unMenu;

        public AltaVisibilidad(SubMenuVisibilidad menu)
        {
            leerArchivoConfig();
            abm_visibilidad = new ABM_Visibilidad_DAO();
            InitializeComponent();
            unMenu = menu;
        }


        private void Guardar_Click(object sender, EventArgs e)
        {
            String desc_tipo = textNombre.Text;
            String desc_precio = textPrecio.Text;
            String desc_porcentaje = textPorcentaje.Text;
            String desc_porcentaje_envio = textEnvio.Text;

            if (abm_visibilidad.validar(desc_tipo, desc_precio, desc_porcentaje, desc_porcentaje_envio))
            {
                abm_visibilidad.setearVisibilidad(desc_tipo, desc_precio, desc_porcentaje, desc_porcentaje_envio);

                MessageBox.Show("Visibilidad creada");
                this.Close();
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            textNombre.Text = "";
            textPrecio.Text = "";
            textPorcentaje.Text = "";
            textEnvio.Text = "";
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
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
