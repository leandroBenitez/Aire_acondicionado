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
    public partial class ModificacionVisibilidad : Form
    {
        ABM_Visibilidad_DAO abm_visibilidad;
        List<string> id_visibilidad = new List<string>();

        public ModificacionVisibilidad()
        {
            leerArchivoConfig();
            abm_visibilidad = new ABM_Visibilidad_DAO();
            InitializeComponent();
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            id_visibilidad.Clear();
            comboBox1.Items.Clear();

            String desc_tipo = textTipo.Text;
            String desc_precio = textPrecio.Text;
            String desc_porcentaje = textPorcentaje.Text;
            String desc_porcentaje_envio = textEnvio.Text;

            id_visibilidad = abm_visibilidad.getIdVisibilidad(desc_tipo, desc_precio, desc_porcentaje, desc_porcentaje_envio);
            
            for (int i = 0; i < id_visibilidad.Count; i++)
            {
                comboBox1.Items.Add(id_visibilidad[i]);
            }
        }

        private void Seleccionar2_Click(object sender, EventArgs e)
        {

            ListadoVisibilidad formListado = new ListadoVisibilidad(int.Parse(comboBox1.SelectedItem.ToString()));
            formListado.Show();
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

        private void textEnvio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
