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
            { boton_generar_pu.Hide(); }

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
            HistorialMiCuenta hist = new HistorialMiCuenta(this.id_usuario);//this para lograr menu show
            hist.Show();
            this.Hide();
        }

        private void boton_estadistica_Click(object sender, EventArgs e)
        {

        }

        private void boton_comprar_Click(object sender, EventArgs e)
        {
            Publicaciones publi = new Publicaciones(this, "Compra");
            publi.Show();
            this.Hide();
        }

        private void boton_ofertar_Click(object sender, EventArgs e)
        {
            Publicaciones publi = new Publicaciones(this, "Subasta");
            publi.Show();
            this.Hide();
        }

        private void boton_abm_user_Click(object sender, EventArgs e)
        {
            subMenuUsuario nuevoSubMenu = new subMenuUsuario();
            nuevoSubMenu.Show();
        }

        private void boton_abm_visib_Click(object sender, EventArgs e)
        {

        }

        private void boton_abm_rubro_Click(object sender, EventArgs e)
        {

        }

        private void boton_abm_roles_Click(object sender, EventArgs e)
        {

        }
    }
}
