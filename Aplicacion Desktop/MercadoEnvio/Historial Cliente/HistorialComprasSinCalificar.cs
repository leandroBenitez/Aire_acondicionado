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
    public partial class HistorialComprasSinCalificar : Form
    {
        HistorialEstrellas_DAO HistEstDAO = new HistorialEstrellas_DAO();
        private int id_usuario;

        public HistorialComprasSinCalificar(int idUser)
        {
            InitializeComponent();
            id_usuario = idUser;
        }

        private void HistorialEstrellasPorOtorgar_Load(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewComprasSinCalificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
