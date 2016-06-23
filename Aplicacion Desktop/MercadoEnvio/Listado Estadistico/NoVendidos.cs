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
using MercadoEnvio.Listado_Estadistico;

namespace MercadoEnvio.Listado_Estadistico
{   
    
    public partial class NoVendidos : Form
    {
        public NoVendidos()
        {
            InitializeComponent();
            comboBoxVisibilidad.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxVisibilidad.Items.Add("Por tipo de publicación");
            comboBoxVisibilidad.Items.Add("Por producto vendido");
            comboBoxVisibilidad.Items.Add("Por envío de producto");
            comboBoxVisibilidad.Items.Add("Gratuita para el vendedor");

            comboBoxMes.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxMes.Items.Add("Enero");
            comboBoxMes.Items.Add("Febrero");
            comboBoxMes.Items.Add("Marzo");
            comboBoxMes.Items.Add("Mayo");
            comboBoxMes.Items.Add("Junio");
            comboBoxMes.Items.Add("Julio");
            comboBoxMes.Items.Add("Agosto");
            comboBoxMes.Items.Add("Septiembre");
            comboBoxMes.Items.Add("Octubre");
            comboBoxMes.Items.Add("Noviembre");
            comboBoxMes.Items.Add("Diciembre");

        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxMes.SelectedIndex = -1;
            comboBoxMes.Items.Clear();
            comboBoxVisibilidad.SelectedIndex = -1;
            comboBoxVisibilidad.Items.Clear();

        }

        private void comboBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxVisibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
