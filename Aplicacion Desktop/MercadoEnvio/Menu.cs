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
using MercadoEnvio.Generar_Publicación;
using MercadoEnvio.Historial_Cliente;
using MercadoEnvio.ComprarOfertar;
using MercadoEnvio.ABM_Usuario;
using MercadoEnvio.Consulta_Facturas;
using MercadoEnvio.Listado_Estadistico;
using MercadoEnvio.ListadoCalificaciones;
using MercadoEnvio.ABM_Rol;
using MercadoEnvio.ABM_Visibilidad;

namespace MercadoEnvio
{
    public partial class Menu : Form
    {
        private LoginDAO loginDAO;
        public int id_usuario;

        public Menu(string user, int id_user, string rol)
        {
            InitializeComponent();
            loginDAO = new LoginDAO();
            adaptar_menu(user, id_user, rol);
            id_usuario = id_user;
        }

        void adaptar_menu(string user, int id_user, string rol)
        {
            text_user.Text = user;
            text_fecha.Text = ConstantesBD.fechaSistema.ToString();

            List<string> funciones = this.loginDAO.get_funcionalidades(rol);

            if (!(funciones.Contains("ABM de Rol")))
                {   boton_abm_roles.Hide(); }

            if (!(funciones.Contains("ABM de Usuarios")))
                {   boton_abm_user.Hide(); }
            
            if (!(funciones.Contains("ABM de Rubro")))
                {   boton_abm_rubro.Hide(); }

            if (!(funciones.Contains("ABM visibilidad de publicación")))
                {   boton_abm_visib.Hide(); }

            if (!(funciones.Contains("Generar Publicación")))
            { 
                boton_generar_pu.Hide();
                my_publi.Hide();
            }

            if (!(funciones.Contains("Comprar/Ofertar")))
                {   boton_comprar.Hide();
                    boton_ofertar.Hide();   }

            if (!(funciones.Contains("Historial del cliente")))
                {   boton_historial.Hide(); }

            //if (!(funciones.Contains("Calificar al Vendedor")))
            //    {   boton_abm_user.Hide(); }

            if (!(funciones.Contains("Consulta de facturas realizadas al vendedor")))
                {   boton_con_fact.Hide(); }

            if (!(funciones.Contains("Listado Estadístico")))
                {   boton_estadistica.Hide(); }
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boton_generar_pu_Click(object sender, EventArgs e)
        {
            if (this.loginDAO.cant_publicaciones(this.id_usuario) == 0)
            {
                MessageBox.Show("Gracias por elegirnos. Su primer publicacion sera gratis.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            TipoDePubli un_tipo = new TipoDePubli(id_usuario, this);
            un_tipo.Show();
            this.Hide();
        }

        private void boton_con_fact_Click(object sender, EventArgs e)
        {
            cons_fac consultaFacturas = new cons_fac(this);
            consultaFacturas.Show();
            this.Hide();
        }

        private void boton_historial_Click(object sender, EventArgs e)
        {
            HistorialMiCuenta hist = new HistorialMiCuenta(this.id_usuario, this);//this para lograr menu show
            hist.Show();
            this.Hide();
        }

        private void boton_estadistica_Click(object sender, EventArgs e)
        {
            Top5 top5 = new Top5(this);//recibe menu
            top5.Show();
            this.Hide();
        }

        private void boton_comprar_Click(object sender, EventArgs e)
        {
            if (this.loginDAO.calificaciones_pendientes(this.id_usuario) < 4)
            {
                Publicaciones_compra publi = new Publicaciones_compra(this);
                publi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Antes de comprar complete sus calificaciones pendientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void boton_ofertar_Click(object sender, EventArgs e)
        {
            if (this.loginDAO.calificaciones_pendientes(this.id_usuario) < 4)
            {
                Publicaciones_subasta publi = new Publicaciones_subasta(this);
                publi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Antes de subastar complete sus calificaciones pendientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void boton_calificar_Click(object sender, EventArgs e)
        {
            ListadoSinCalificar listado = new ListadoSinCalificar(this, this.id_usuario);
            listado.Show();
            this.Hide();
        }

        private void boton_abm_user_Click(object sender, EventArgs e)
        {
            subMenuUsuario nuevoSubMenu = new subMenuUsuario();
            nuevoSubMenu.Show();
        }

        private void boton_abm_visib_Click(object sender, EventArgs e)
        {
            SubMenuVisibilidad visibilidad = new SubMenuVisibilidad(this);
            visibilidad.Show();
        }

        private void boton_abm_rubro_Click(object sender, EventArgs e)
        {

        }

        private void boton_abm_roles_Click(object sender, EventArgs e)
        {
            subMenuRol subMenu = new subMenuRol();
            subMenu.Show();
        }

        private void my_publi_Click(object sender, EventArgs e)
        {
            Mis_publicaciones mis = new Mis_publicaciones(this);
            mis.Show(); 
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Change_Password change = new Change_Password(this);
            change.Show();
        }
    }
}
