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
using System.Data.SqlClient;
using System.IO;

namespace MercadoEnvio.Calificaciones
{
    public partial class Calificar : Form
    {
        private Calificar_DAO calificarDAO;

        public Calificar(int publicacion, int usuario)
        {
            leerArchivoConfig();
            calificarDAO = new Calificar_DAO();
            InitializeComponent();
            
            labelUsuario.Text = usuario.ToString();

            cargarCalificacionComboBox();
        }

        public void cargarCalificacionComboBox()
        {
            for (int i = 1; i <= 5; i++)
            {
                Calificacion_ComboBox.Items.Add(i);
            }
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            int j = (int)Calificacion_ComboBox.SelectedItem;

            PruebaTextBox.Text = j.ToString();
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
