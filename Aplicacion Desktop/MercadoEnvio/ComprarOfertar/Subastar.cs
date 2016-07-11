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
        public Menu un_menu;

        public Subastar(string fecha_vencimiento, string desc, float valor, float costo_envio, int stock, int id_publica, Menu un_men)
        {
            InitializeComponent();
            publicacion = new publicacionDAO();
            this.costo_envio = costo_envio;
            this.valor = valor;
            this.id_publicacion = id_publica;
            this.id_usuario = un_men.id_usuario;
            this.fecha_vencimiento = fecha_vencimiento;
            this.un_menu = un_men;
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
                ult_monto.Text = "$"+respuesta["desc_monto"].ToString();
                ult_fecha.Text = respuesta["desc_fecha"].ToString();
            }
            else
            {
                ult_monto.Text = "$"+this.valor;
                ult_fecha.Text = "-";
            }
            respuesta.Close();

            total_real.Text = "$0";

            if (!(float.Parse(costo_envio.ToString()) > 0))
            {
                check_envio.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.Parse(nuevo_monto.Text) > 0)
            {
                if (float.Parse(nuevo_monto.Text) > float.Parse(ult_monto.Text.Substring(1)))
                {
                    string envio;
                    if (check_envio.Checked == true)
                    {
                        envio = "Si";
                    }
                    else
                    {
                        envio = "No";
                    }
                    publicacion.subastar(float.Parse(nuevo_monto.Text), this.id_publicacion, this.id_usuario, envio);
                    MessageBox.Show("Su oferta se ha realizado con exito!");
                    this.Close();
                    this.un_menu.Show();
                }
                else
                {
                    MessageBox.Show("La oferta debe ser mayor a la anterior.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Revise el valor ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void check_envio_CheckedChanged(object sender, EventArgs e)
        {
            if (check_envio.Checked == true)
            {
                total_real.Text = "$" + this.costo_envio.ToString();
            }
            else
            {
                total_real.Text = "$0";
            }
        }
    }
}
