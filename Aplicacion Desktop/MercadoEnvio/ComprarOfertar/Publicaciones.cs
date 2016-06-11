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
using System.Data.SqlClient;

namespace MercadoEnvio.ComprarOfertar
{
    public partial class Publicaciones : Form
    {
        private publicacionDAO publicacion;

        public Publicaciones()
        {
            InitializeComponent();
            publicacion = new publicacionDAO();
            cargar_datos();
        }

        public void cargar_datos()
        {
            foreach (string aux in publicacion.get_Rubros())
            { combo_rubros.Items.Add(aux); }
        }

        private void radio_compra_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_compra.Checked == true)
            {
                radio_subasta.Checked = false;
            }
            else
            {
                radio_subasta.Checked = true;
            }
        }

        private void radio_subasta_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_subasta.Checked == true)
            {
                radio_compra.Checked = false;
            }
            else
            {
                radio_compra.Checked = true;
            }
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            SqlDataReader resultado = publicacion.get_publicaciones("s");
            resultado.Close();
        }
    }
}
