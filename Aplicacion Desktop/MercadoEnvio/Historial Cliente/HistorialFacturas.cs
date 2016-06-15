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

namespace MercadoEnvio.Historial_Cliente
{
    public partial class HistorialFacturas : Form
    {
        HistorialFacturas_DAO HistFacDAO = new HistorialFacturas_DAO();
        private int id_usuario;


        public HistorialFacturas(int idUser)
        {
            InitializeComponent();
            id_usuario = idUser;
        }

        private void HistorialFacturas_Load(object sender, EventArgs e)
        {
            dataGridViewFacturas.Rows.Clear();
            SqlDataReader lectura;

            lectura = HistFacDAO.get_facturas(this.id_usuario);

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[5];

            while (lectura.Read())
            {
                columnas[0] = lectura["id_factura"].ToString();
                columnas[1] = lectura["desc_fecha"].ToString();
                columnas[2] = lectura["desc_total"].ToString();
                columnas[3] = lectura["id_forma_pago"].ToString();
                columnas[4] = lectura["Id_usuario"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewFacturas, columnas);

            }

            lectura.Close();
            dataGridViewFacturas.Rows.AddRange(filas.ToArray());
        }

        private void buttonVolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

