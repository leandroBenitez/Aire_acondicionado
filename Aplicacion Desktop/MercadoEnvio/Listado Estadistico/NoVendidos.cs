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
        NoVendido_DAO ProdNoVendidos = new NoVendido_DAO();
        ABM_Visibilidad_DAO VisibDAO = new ABM_Visibilidad_DAO();


        public NoVendidos()
        {
            InitializeComponent();
            comboBoxVisibilidad.DropDownStyle = ComboBoxStyle.DropDownList;

            List<string> idVisibilidades = ProdNoVendidos.get_idVisibilidad();

            for (int i = 0; i < idVisibilidades.Count; i++)
            {
                string descVisi = VisibDAO.get_descVisibilidadSegun(idVisibilidades[i]);
                comboBoxVisibilidad.Items.Add(descVisi);
            }
          

            comboBoxMes.DropDownStyle = ComboBoxStyle.DropDownList;

            for (int i = 1; i <= 12; i++ )
            {
                comboBoxMes.Items.Add(i);
            }

        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            string condicion = " where 1=1";
            if (!(string.IsNullOrWhiteSpace(comboBoxVisibilidad.Text)))
            {
                condicion = condicion + " and visibilidad = '" + comboBoxVisibilidad.Text + "'";
            }

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
