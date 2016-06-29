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
using MercadoEnvio.Calificaciones;

namespace MercadoEnvio.ListadoCalificaciones
{
    public partial class ListadoSinCalificar : Form
    {
        private Calificar_DAO calificarDAO;
        List<string> listadoCalificaciones = new List<string>();


        public ListadoSinCalificar(int id_user)
        {
            leerArchivoConfig();
            calificarDAO = new Calificar_DAO();
            InitializeComponent();
            cargarGridView(id_user);
        }

        private void cargarGridView(int id_user)
        {
            listadoCalificaciones = calificarDAO.getCompras(id_user.ToString());

            for (int i = 0; i < listadoCalificaciones.Count; i++)
            {
                calificacionListado.Rows.Add(listadoCalificaciones[i].ToString()
                                            ,calificarDAO.getVendedor(int.Parse(listadoCalificaciones[i].ToString()))
                                            ,calificarDAO.getCalificacion(id_user, listadoCalificaciones[i].ToString()));
            }
        }

        private void button_seleccionar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = calificacionListado.SelectedRows[0];
            int publicacion = int.Parse(fila.Cells["Publicacion"].Value.ToString());
            int vendedor = int.Parse(fila.Cells["Vendedor"].Value.ToString());

            Calificar formCalificar = new Calificar(publicacion, vendedor);
            formCalificar.Show();

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
