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


namespace MercadoEnvio.Listado_Estadistico
{
    public partial class Top5 : Form
    {
        ListadoEstadistico_DAO ListEstDAO = new ListadoEstadistico_DAO();
        public Menu menu;

        public Top5(Menu un_menu)
        {
            InitializeComponent();
            menu = un_menu;

            comboBoxTop5.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxTop5.Items.Add("Clientes - Cantidad de productos comprados");
            comboBoxTop5.Items.Add("Vendedores - Cantidad de productos no vendidos");
            comboBoxTop5.Items.Add("Vendedores - Cantidad de facturas");
            comboBoxTop5.Items.Add("Vendedores - Mayor monto facturado");

            comboBoxTrimestre.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxTrimestre.Items.Add("Primer trimestre");
            comboBoxTrimestre.Items.Add("Segundo trimestre");
            comboBoxTrimestre.Items.Add("Tercer trimestre");
            comboBoxTrimestre.Items.Add("Cuarto trimestre");
                         
        }

        private void comboBoxTop5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTop5.Text == "Vendedores - Cantidad de productos no vendidos")
            {
                NoVendidos formNoVendidos = new NoVendidos();
                formNoVendidos.Show();
                
            }
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            SqlDataReader lectorTop5;
               

            if ((!(string.IsNullOrWhiteSpace(comboBoxTrimestre.Text))) && (!(string.IsNullOrWhiteSpace(comboBoxTop5.Text))))
            {
                string condicionTrimAño = " ";
                switch (comboBoxTrimestre.Text)
                {
                    case "Primer trimestre":
                        condicionTrimAño = condicionTrimAño + " MONTH(desc_fecha) BETWEEN '1' AND '3' " ;
                        break;
                    case "Segundo trimestre":
                        condicionTrimAño = condicionTrimAño + " MONTH(desc_fecha) BETWEEN '4' AND '6' " ;
                        break;
                    case "Tercer trimestre":
                        condicionTrimAño = condicionTrimAño + " MONTH(desc_fecha) BETWEEN '7' AND '9' ";
                        break;
                    case "Cuarto trimestre":
                        condicionTrimAño = condicionTrimAño + " MONTH(desc_fecha) BETWEEN '10' AND '12' ";
                        break;

                }
                
                if(!(string.IsNullOrWhiteSpace(textBoxAñoTop.Text)))
                {
                    condicionTrimAño = condicionTrimAño + " and YEAR(desc_fecha) = '" + textBoxAñoTop.Text + "'";
                }

                switch (comboBoxTop5.Text)
                {
                    case "Clientes - Cantidad de productos comprados":
                        lectorTop5 = ListEstDAO.getListClientesMayorCantProdComp(condicionTrimAño);
                        cargar_grid_cliMayorCantProdComp(lectorTop5);
                        break;
                    case "Vendedores - Cantidad de facturas":
                        lectorTop5 = ListEstDAO.getListVendMayorCantFacturas(condicionTrimAño);
                        cargar_grid_vendFacturasOMonto(lectorTop5);
                        break;
                    case "Vendedores - Mayor monto facturado":
                        lectorTop5 = ListEstDAO.getListVendMayorMontoFactutado(condicionTrimAño);
                        cargar_grid_vendFacturasOMonto(lectorTop5);
                        break;

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un trimestre, un año y un listado", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_grid_cliMayorCantProdComp(SqlDataReader lector)
        {
            SqlDataReader lectorT5;
            int i = 0;

            lectorT5 = lector;

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[5];

            this.dataGridViewTop5.Columns["Col_rubro"].Visible = true;
            

            while(lectorT5.Read())
            {
                i++;
                columnas[0] = i.ToString();
                columnas[1] = lectorT5["id_usuario"].ToString();
                columnas[2] = lectorT5["desc_fecha"].ToString();
                columnas[3] = lectorT5["Cantidad"].ToString();
                columnas[4] = lectorT5["desc_rubro"].ToString(); 

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewTop5, columnas);
            }

            lectorT5.Close();
            dataGridViewTop5.Rows.AddRange(filas.ToArray());
        }

        private void cargar_grid_vendFacturasOMonto(SqlDataReader lector)
        {
            SqlDataReader lectorT5;
            int i = 0;

            lectorT5 = lector;

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[4];

            //this.dataGridViewTop5.Columns.Remove(Col_rubro);
            this.dataGridViewTop5.Columns["Col_rubro"].Visible = false;

            while (lectorT5.Read())
            {
                i++;
                columnas[0] = i.ToString();
                columnas[1] = lectorT5["id_usuario"].ToString();
                columnas[2] = lectorT5["desc_fecha"].ToString();
                columnas[3] = lectorT5["Cantidad"].ToString();               
             
                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewTop5, columnas);
            }

            lectorT5.Close();
            dataGridViewTop5.Rows.AddRange(filas.ToArray());
        }




        private void buttonVolver_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxAñoTop.Text = "";
            comboBoxTop5.SelectedIndex = -1;
            comboBoxTop5.Items.Clear();
            comboBoxTrimestre.SelectedIndex = -1;
            comboBoxTrimestre.Items.Clear();
            
        }

        private void comboBoxTrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
                     
        }



       
       

        
    }
}
