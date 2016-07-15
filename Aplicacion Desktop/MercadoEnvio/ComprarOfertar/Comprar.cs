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

namespace MercadoEnvio.ComprarOfertar
{
    public partial class Comprar : Form
    {
        public float costo_envio;
        public float valor;
        public int id_publicacion;
        public int id_usuario;
        private Menu un_menu;

        public Comprar(string desc, float valor, float costo_envio, int stock, int id_publica, int id_user, Menu un_me)
        {
            InitializeComponent();
            this.costo_envio = costo_envio;
            this.valor = valor;
            this.id_publicacion = id_publica;
            this.id_usuario = id_user;
            this.un_menu = un_me;
            setearValores(desc, stock);
        }

        public void setearValores(string descripcion, int stock)
        {
            articulo.Text = descripcion;
            while (stock > 0)
            {
                combo_cantidad.Items.Add(stock);
                stock--;
            }
            combo_cantidad.Items.Add("0");
            combo_cantidad.Text = "0";

            label_valor.Text = "$0";
            if (!(float.Parse(this.costo_envio.ToString()) > 0))
            {
                check_envio.Enabled = false;
                total_real.Text = "$0";
            }

            total_real.Text = "$0";
            cost_envio.Text = "$0";
        }

        private void combo_cantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            recalcular_valores();
        }

        public void recalcular_valores()
        {
            label_valor.Text = "$" + (Int32.Parse(combo_cantidad.Text) * this.valor).ToString();

            if (check_envio.Checked == false)
            {
                total_real.Text = "$" + (Int32.Parse(combo_cantidad.Text) * this.valor).ToString();
            }
            else
            {
                total_real.Text = "$" + ((Int32.Parse(combo_cantidad.Text) * this.valor) + this.costo_envio).ToString();            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.un_menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(combo_cantidad.Text == "0"))
            {
                string envio;
                publicacionDAO publicacion = new publicacionDAO();
                if (check_envio.Checked == true)
                {
                    envio = "Si";
                }
                else
                {
                    envio = "No";
                }
                publicacion.comprar(Int16.Parse(combo_cantidad.Text), this.id_publicacion, this.id_usuario, envio);
                MessageBox.Show("Su compra se ha realizado con exito!");
                this.Close();
                this.un_menu.Show();
            }
            else
            {
                MessageBox.Show("Elija al menos un item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void check_envio_CheckedChanged(object sender, EventArgs e)
        {
            if (check_envio.Checked == true)
            {
                cost_envio.Text = "$" + this.costo_envio.ToString();
            }
            else
            {
                cost_envio.Text = "$0";
            }
            recalcular_valores();
        }
    }
}
