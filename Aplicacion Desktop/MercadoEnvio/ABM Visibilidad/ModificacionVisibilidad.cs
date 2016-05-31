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
        List<Button> txt = new List<Button>();
        List<TextBox> txtTipo = new List<TextBox>();
        int A = 7;

        public ModificacionVisibilidad()
        {
            leerArchivoConfig();
            abm_visibilidad = new ABM_Visibilidad_DAO();
            InitializeComponent();
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            id_visibilidad.Clear();
            Limpiar_TxtYBut();

            A = 7;

            String desc_tipo = textTipo.Text;
            String desc_precio = textPrecio.Text;
            String desc_porcentaje = textPorcentaje.Text;
            String desc_porcentaje_envio = textEnvio.Text;

            id_visibilidad = abm_visibilidad.getIdVisibilidad(desc_tipo, desc_precio, desc_porcentaje, desc_porcentaje_envio);
            
            for (int i = 0; i < id_visibilidad.Count; i++)
            {
                txt.Add(addNewTextBox(id_visibilidad[i]));
            }
        }

        private Button addNewTextBox(string id)
        {
            Button but = new Button();
            but.Click += new EventHandler(SeleccionarID);

            this.Controls.Add(but);
            but.Top = A * 38;
            but.Left = 26;
            but.Text = id;


            TextBox text;

            text = crearTextBox(126);
            text.Text = abm_visibilidad.get_descVisibilidadSegun(id);
            txtTipo.Add(text);

            text = crearTextBox(226);
            text.Text = abm_visibilidad.get_desc_precioVisibilidadSegun(id).ToString();
            txtTipo.Add(text);

            text = crearTextBox(326);
            text.Text = abm_visibilidad.get_desc_porcentajeVisibilidadSegun(id).ToString();
            txtTipo.Add(text);

            text = crearTextBox(426);
            text.Text = abm_visibilidad.get_desc_porcentaje_envioVisibilidadSegun(id).ToString();
            txtTipo.Add(text);

            A++;
            return but;
        }

        private void SeleccionarID(object sender, EventArgs e)
        {
            Button button = sender as Button;

            ListadoVisibilidad formListado = new ListadoVisibilidad(int.Parse(button.Text));
            formListado.Show();
        }

        private TextBox crearTextBox(int left)
        {
            TextBox text = new TextBox();
            text.ReadOnly = true;
            this.Controls.Add(text);
            text.Top = A * 38;
            text.Left = left;

            return text;
        }

        private void Limpiar_TxtYBut()
        {
            foreach (Button t in txt)
            {
                this.Controls.Remove(t);
                t.Dispose();
            }

            foreach (TextBox t in txtTipo)
            {
                this.Controls.Remove(t);
                t.Dispose();
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            textTipo.Text = "";
            textPrecio.Text = "";
            textPorcentaje.Text = "";
            textEnvio.Text = "";
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
