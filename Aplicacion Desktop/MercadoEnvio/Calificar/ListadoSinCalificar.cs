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
        private ABM_usuario_DAO usuarioDAO;
        private publicacionDAO publicacionDAO;

        private Menu unMenu;
        private SubMenuCalificar unSubMenu;
        List<string> listadoCalificaciones = new List<string>();


        public ListadoSinCalificar(Menu menu, int id_comprador, SubMenuCalificar subMenu)
        {
            leerArchivoConfig();
            calificarDAO = new Calificar_DAO();
            usuarioDAO = new ABM_usuario_DAO();
            publicacionDAO = new publicacionDAO();

            this.unMenu = menu;
            unSubMenu = subMenu;
            InitializeComponent();
            cargarGridView(id_comprador);
        }

        private void cargarGridView(int id_comprador)
        {
            int id_compra = 0;
            int id_subasta = 0;
            int id_calificacion = 0;
            decimal id_publicacion = 0;

            listadoCalificaciones = calificarDAO.getIdCalificacion(id_comprador);

            for (int i = 0; i < listadoCalificaciones.Count; i++)
            {
                id_calificacion = int.Parse(listadoCalificaciones[i]);


                MessageBox.Show("Publicacion: " + id_calificacion.ToString());

                id_publicacion = calificarDAO.get_publicacion(id_calificacion);

                calificacionListado.Rows.Add(listadoCalificaciones[i]
                                            , publicacionDAO.get_desc_publicacion(id_publicacion)
                                            , usuarioDAO.getUsername(calificarDAO.getVendedor(int.Parse(listadoCalificaciones[i])).ToString()));
            }

            if (listadoCalificaciones.Count > 0)
            {
                foreach (DataGridViewRow row in calificacionListado.Rows)
                {

                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void button_seleccionar_Click(object sender, EventArgs e)
        {
            int id_user = int.Parse(this.unMenu.id_usuario.ToString());

            try
            {
                DataGridViewRow fila = calificacionListado.SelectedRows[0];
                int id_calif = int.Parse(fila.Cells["idCalificacion"].Value.ToString());
                int vendedor = calificarDAO.getVendedor(id_calif);

                Calificar formCalificar = new Calificar(id_calif, vendedor, id_user, this.unMenu, this);
                formCalificar.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Seleccione una fila");
            }

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.unSubMenu.Show();
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
