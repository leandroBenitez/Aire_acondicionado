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
        ListadoEstadistico_DAO ProdNoVendidosDAO = new ListadoEstadistico_DAO();
        ABM_Visibilidad_DAO VisibDAO = new ABM_Visibilidad_DAO();


        public NoVendidos()
        {
            InitializeComponent();
            comboBoxVisibilidad.DropDownStyle = ComboBoxStyle.DropDownList;

            List<string> idVisibilidades = ProdNoVendidosDAO.get_idVisibilidad();

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
            SqlDataReader lectorNoVendido;
            //string condicion = " where 1=1";
            string condicion = " ";
            if (!(string.IsNullOrWhiteSpace(comboBoxVisibilidad.Text)))
            {
                condicion = condicion + " and desc_tipo = '" + comboBoxVisibilidad.Text + "'";
            }

            if (!(string.IsNullOrWhiteSpace(comboBoxMes.Text)))
            {
                condicion = condicion + " and MONTH(fecha_publicacion) = '" + comboBoxMes.Text + "'";
            }

            if (!(string.IsNullOrWhiteSpace(textBoxAñoNV.Text))) 
            {
                condicion = condicion + " and YEAR(fecha_publicacion) = '" + textBoxAñoNV.Text + "'";
            }

            lectorNoVendido = ProdNoVendidosDAO.getListVendMayorCantProdNoVend(condicion);
            cargar_grid_prodNoVendidos(lectorNoVendido);
        }

        private void cargar_grid_prodNoVendidos(SqlDataReader lector)
        {
            SqlDataReader lectorNV;
            int i = 0;

            lectorNV = lector;

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[4];

            while(lectorNV.Read())
            {
                i++;
                columnas[0] = i.ToString();
                columnas[1] = lectorNV["id_usuario"].ToString();
                columnas[2] = lectorNV["fecha_publicacion"].ToString();
                columnas[3] = lectorNV["Cantidad"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewNoVendidos, columnas);
               

            }

            lectorNV.Close();
            dataGridViewNoVendidos.Rows.AddRange(filas.ToArray());
            
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxMes.SelectedIndex = -1;
            comboBoxVisibilidad.SelectedIndex = -1;
            textBoxAñoNV.Text = "";
            dataGridViewNoVendidos.Rows.Clear();
        }

        private void comboBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxVisibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
