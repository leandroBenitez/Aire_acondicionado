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
    public partial class HistorialCompras : Form
    {
        HistorialCompras_DAO HistCompDAO = new HistorialCompras_DAO();
        private int id_usuario;
        
        
        public HistorialCompras(int idUser)
        {
            InitializeComponent();
            id_usuario = idUser;
        }

        private void HistorialCompras_Load(object sender, EventArgs e)
        {
            dataGridViewCompras.Rows.Clear();
            SqlDataReader lectura;

            lectura = HistCompDAO.get_compras(this.id_usuario);

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[5];

            while (lectura.Read())
            {
                columnas[0] = lectura["id_compra"].ToString();
                columnas[1] = lectura["desc_fecha"].ToString();
                columnas[2] = lectura["desc_cantidad"].ToString();
                columnas[3] = lectura["id_publicación"].ToString();
                columnas[4] = lectura["Id_usuario"].ToString();

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridViewCompras, columnas);

            }

            lectura.Close();
            dataGridViewCompras.Rows.AddRange(filas.ToArray()); 
        }


        private void buttonVolverAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       


    }
}
