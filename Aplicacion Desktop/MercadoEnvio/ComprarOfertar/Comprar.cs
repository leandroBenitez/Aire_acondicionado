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

        public Comprar(string desc, float valor, float costo_envio, int stock, int id_publica, int id_user)
        {
            InitializeComponent();
            this.costo_envio = costo_envio;
            this.valor = valor;
            this.id_publicacion = id_publica;
            this.id_usuario = id_user;
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

            label_valor.Text = "0";
            cost_envio.Text = this.costo_envio.ToString();
            total_real.Text = this.costo_envio.ToString();
        }

        private void combo_cantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_valor.Text = (Int32.Parse(combo_cantidad.Text) * this.valor).ToString();
            total_real.Text = ((Int32.Parse(combo_cantidad.Text) * this.valor) + this.costo_envio).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(combo_cantidad.Text == "0"))
            {
                publicacionDAO publicacion = new publicacionDAO();
                publicacion.realizar_compra_subasta(0, this.id_publicacion, this.id_usuario, "Compra Inmediata", Int16.Parse(combo_cantidad.Text));
                MessageBox.Show("Su compra se ha realizado con exito!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Elija al menos un item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
