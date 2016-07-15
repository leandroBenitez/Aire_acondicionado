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
using MercadoEnvio.ListadoCalificaciones;

namespace MercadoEnvio.Calificaciones
{
    public partial class Calificar : Form
    {
        private Calificar_DAO calificarDAO;
        private ABM_usuario_DAO usuarioDAO;

        int pubCalif, vendedorCalif, compradorCalif; 
        private Menu unMenu;
        private ListadoSinCalificar unListado;

        public Calificar(int id_calif, int vendedor, int comprador, Menu menu, ListadoSinCalificar listado)
        {
            leerArchivoConfig();
            calificarDAO = new Calificar_DAO();
            usuarioDAO = new ABM_usuario_DAO();
            InitializeComponent();

            labelUsuario.Text = usuarioDAO.getUsername(vendedor.ToString());
            pubCalif = id_calif;
            vendedorCalif = vendedor;
            compradorCalif = comprador;
            unMenu = menu;
            unListado = listado;

            cargarCalificacionComboBox();
        }

        public void cargarCalificacionComboBox()
        {
            for (int i = 1; i <= 5; i++)
            {
                combo_calificacion.Items.Add(i);
            }
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            string descripcion = label_descripcion.Text;

            try
            {
                int estrellas = (int)combo_calificacion.SelectedItem;
                calificarDAO.calificarA(pubCalif, estrellas, descripcion, compradorCalif);
                MessageBox.Show("Calificación realizada");
                this.Close();
                this.unMenu.Show();
            }
            catch
            {
                MessageBox.Show("Seleccione una cantidad de estrellas de la lista");
            }

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

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.unListado.Show();
            this.Close();
        }
    }
}
