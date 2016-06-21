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
    public partial class Subastar : Form
    {
        private publicacionDAO publicacion;
        public float costo_envio;
        public float valor;
        public int id_publicacion;
        public int id_usuario;
        public string fecha_vencimiento;

        public Subastar(string fecha_vencimiento, string desc, float valor, float costo_envio, int stock, int id_publica, int id_user)
        {
            InitializeComponent();
            publicacion = new publicacionDAO();
            this.costo_envio = costo_envio;
            this.valor = valor;
            this.id_publicacion = id_publica;
            this.id_usuario = id_user;
            this.fecha_vencimiento = fecha_vencimiento;
            setearValores(desc, stock);
        }

        public void setearValores(string descripcion, int stock)
        {
            articulo.Text = descripcion;
            fecha_venc.Text = this.fecha_vencimiento;

            SqlDataReader respuesta = publicacion.get_ultima_oferta(this.id_publicacion);

            if (respuesta.HasRows)
            {
                respuesta.Read();
                ult_monto.Text = respuesta["desc_monto"].ToString();
                ult_fecha.Text = respuesta["desc_fecha"].ToString();
            }
            else
            {
                ult_monto.Text = "0";
                ult_fecha.Text = "-";
            }
            respuesta.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.Parse(nuevo_monto.Text) > 0)
            {
                publicacion.realizar_compra_subasta(float.Parse(nuevo_monto.Text), this.id_publicacion, this.id_usuario, "Subasta", 0);
                MessageBox.Show("Su oferta se ha realizado con exito!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Revise el valor ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
