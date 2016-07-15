using MercadoEnvio.DataBase.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.Calificaciones
{
    public partial class InformeCalificarSubasta : Form
    {
        private Calificar_DAO calificarDAO;
        private ABM_usuario_DAO usuarioDAO;
        private publicacionDAO publicacionDAO;
        private int id_usuario;
        private SubMenuCalificar unSubMenu;
        List<string> listadoCalificaciones = new List<string>();

        public InformeCalificarSubasta(int usuario, SubMenuCalificar subMenu)
        {
            id_usuario = usuario;
            unSubMenu = subMenu;
            calificarDAO = new Calificar_DAO();
            usuarioDAO = new ABM_usuario_DAO();
            publicacionDAO = new publicacionDAO();

            InitializeComponent();

            label_total.Text = "0";
            cargarCombo();
            cargarHistorial();
        }

        private void cargarCombo()
        {
            for (int i = 1; i <= 5; i++)
            {
                combo_calificacion.Items.Add(i);
            }
        }

        private void cargarHistorial()
        {
            int id_subasta = 0;
            decimal id_publicacion = 0;
            listadoCalificaciones = calificarDAO.get_ultimas_calificaciones_subastas(id_usuario);

            label_total.Text = listadoCalificaciones.Count().ToString();
            for (int i = 0; i < listadoCalificaciones.Count; i++)
            {
                id_subasta = calificarDAO.getSubasta(int.Parse(listadoCalificaciones[i]));
                id_publicacion = calificarDAO.getPublicacionSubasta(id_subasta);
                

                dataGridView_historial.Rows.Add(listadoCalificaciones[i]
                                            , publicacionDAO.get_desc_publicacion(id_publicacion)
                                            , usuarioDAO.getUsername(calificarDAO.getVendedor(int.Parse(listadoCalificaciones[i])).ToString()));
            }
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            unSubMenu.Show();
            this.Close();
        }

        private void button_seleccionar_Click(object sender, EventArgs e)
        {
            dataGridView_calificaciones.Rows.Clear();
            try
            {
                cargarGridView(combo_calificacion.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Elija una calificacion");
            }
        }

        private void cargarGridView(string calificacion)
        {
            int id_subasta = 0;
            decimal id_publicacion = 0;
            listadoCalificaciones = calificarDAO.getCalificacionesSubastas(id_usuario, int.Parse(calificacion));

            label_total.Text = listadoCalificaciones.Count().ToString();
            for (int i = 0; i < listadoCalificaciones.Count; i++)
            {
               
                id_subasta = calificarDAO.getSubasta(int.Parse(listadoCalificaciones[i]));
                id_publicacion = calificarDAO.getPublicacionSubasta(id_subasta);
               
                dataGridView_calificaciones.Rows.Add(listadoCalificaciones[i]
                                            , publicacionDAO.get_desc_publicacion(id_publicacion)
                                            , usuarioDAO.getUsername(calificarDAO.getVendedor(int.Parse(listadoCalificaciones[i])).ToString())
                                            , calificarDAO.getCalificacion(int.Parse(listadoCalificaciones[i])));
            }
        }
    }
}
