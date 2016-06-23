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
            comboBoxTop5.Items.Clear();
           
            if (comboBoxTrimestre.Text != "" && textBoxAnio.Text != "" && comboBoxTop5.Text != "")
            {
               
                switch (comboBoxTrimestre.Text)
                {
                    case "Primer trimestre":
                        
                        break;
                    case "Segundo trimestre":
                        
                        break;
                    case "Tercer trimestre":
                        
                        break;

                    case "Cuarto trimestre":

                        break;

                }
                switch (comboBoxTop5.Text)
                {
                    case "Clientes - Cantidad de productos comprados":
                        
                        break;
                    case "Vendedores - Cantidad de factura":
                        ;
                        break;
                    case "Vendedores - Mayor monto facturado":
                        
                        break;

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un trimestre, un año y un listado", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxAnio.Text = "";
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
