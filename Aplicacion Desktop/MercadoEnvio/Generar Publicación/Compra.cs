using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MercadoEnvio.DataBase.Conexion;

namespace MercadoEnvio.Generar_Publicación
{
    public partial class Compra : Form
    {
        private LoginDAO login;
        private publicacionDAO publicacion;
        private int id_usuario;
        public Menu menu;

        public Compra(int id_user, Menu un_menu)
        {
            InitializeComponent();
            id_usuario = id_user;
            menu = un_menu;
            login = new LoginDAO();
            publicacion = new publicacionDAO();
            cargar_datos();
        }

        void cargar_datos()
        {
            foreach (string aux in publicacion.get_Rubros())
            {   combo_rubros.Items.Add(aux);    }

            foreach (string aux in publicacion.get_visualizaciones())
            {   combo_vis.Items.Add(aux); }

            foreach (string aux in publicacion.get_Tipo_Publicacion())
            {   combo_estado_pu.Items.Add(aux); }

            label_user.Text = login.get_username(this.id_usuario);
            
            fecha_vencimiento.Format = DateTimePickerFormat.Custom;
            fecha_vencimiento.CustomFormat = "dd'/'MM'/'yyyy";

            if (publicacion.publicacion_pendiente(this.id_usuario, ConstantesBD.vista_publi_compra) == "ok")
            {
                label_id_publicacion.Text = (publicacion.ultimo_id() + 1).ToString();
                fecha_sys.Text = ConstantesBD.fechaSistema;
                //fecha_vencimiento.Text = "01-01-2017";
            }
            else
            {
                MessageBox.Show("El usuario posee una publicacion pendiente", "Publicacion Pendiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                SqlDataReader resultado = publicacion.get_datos_ultima_publicacion(this.id_usuario, ConstantesBD.vista_publi_compra);

                resultado.Read();
                label_id_publicacion.Text = resultado["id_publicacion"].ToString();
                fecha_sys.Text = resultado["fecha_publicacion"].ToString().Substring(0, 10);
                desc.Text = resultado["desc_publicacion"].ToString();
                text_stock.Text = resultado["desc_stock"].ToString();
                text_precio.Text = resultado["desc_precio"].ToString();
                if (float.Parse(resultado["desc_costo_envio"].ToString()) > 0)
                {
                    check_envio.CheckState = CheckState.Checked;
                    textbox_envio.Text = resultado["desc_costo_envio"].ToString();
                }
                else
                {
                    check_envio.CheckState = CheckState.Unchecked;
                }
                combo_rubros.Text = resultado["desc_rubro"].ToString();
                combo_estado_pu.Text = resultado["desc_estado"].ToString();
                combo_vis.Text = resultado["desc_tipo"].ToString();

                string fecha_venc = resultado["fecha_vencimiento"].ToString();

                resultado.Close();

                fecha_vencimiento.Text = fecha_venc;
                combo_rubros.Items.Add("Todos");
                combo_rubros.Text = "Todos";
            }
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void boton_finalizar_Click(object sender, EventArgs e)
        {
            if (combo_estado_pu.Text == "Borrador")
            {
                if (validar_valores_numericos() == "correcto")
                {
                    guardar_publicacion();
                }
                else
                {
                    MessageBox.Show("Revise los valores numericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (validar_valores_numericos() == "correcto" &&
                    validar_valores_nulos() == "completo")
                {
                    guardar_publicacion();
                }
                else
                {
                    MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void guardar_publicacion()
        {
            string aux;
            string fecha;

            if (check_envio.Checked)
            {   aux =  textbox_envio.Text;  }
            else
            {   aux = "0";  }

            if (string.IsNullOrWhiteSpace(fecha_vencimiento.Text))
            { 
                fecha = "01/01/1900";
            }
            else
            {
                fecha = fecha_vencimiento.Text;
            }

            bool resultado = this.publicacion.guardar_publicacion(label_id_publicacion.Text,
                                                 desc.Text,
                                                 text_stock.Text,
                                                 ConstantesBD.fechaSistema,
                                                 fecha,
                                                 text_precio.Text.Replace(",","."),
                                                 textbox_envio.Text.Replace(",", "."),
                                                 combo_estado_pu.Text,
                                                 combo_vis.Text,
                                                 "Compra Inmediata",
                                                 combo_rubros.Text,
                                                 this.id_usuario    );

                       
            if (resultado)
            {
                MessageBox.Show("Publicacion guardada.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                menu.Show();
                this.Close();
            } 
            else
            {
                MessageBox.Show("Revise los valores ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string validar_valores_numericos()
        { 
            int temp;
            float temp2;

            if ((!string.IsNullOrWhiteSpace(text_stock.Text) &&
                 !int.TryParse(text_stock.Text, out temp)) ||
                (!string.IsNullOrWhiteSpace(text_precio.Text) &&
                 !float.TryParse(text_precio.Text, out temp2)) ||
                (!string.IsNullOrWhiteSpace(textbox_envio.Text) &&
                 !float.TryParse(textbox_envio.Text, out temp2) &&
                 check_envio.Checked))
            {
                return "error";
            }
            else
            {
                return "correcto";
            }    
        }

        public string validar_valores_nulos()
        {
            if (string.IsNullOrWhiteSpace(desc.Text) ||
                string.IsNullOrWhiteSpace(text_stock.Text) ||
                string.IsNullOrWhiteSpace(text_precio.Text) ||
                (check_envio.Checked && string.IsNullOrWhiteSpace(text_stock.Text)) ||
                string.IsNullOrWhiteSpace(combo_rubros.Text) ||
                string.IsNullOrWhiteSpace(combo_estado_pu.Text) ||
                string.IsNullOrWhiteSpace(combo_vis.Text) ||
                string.IsNullOrWhiteSpace(fecha_vencimiento.Text))
            {
                return "incompleto";
            }
            else
            {
                return "completo";
            }
        }

        private void check_envio_CheckedChanged(object sender, EventArgs e)
        {
            textbox_envio.Enabled = (check_envio.CheckState == CheckState.Checked);
        }

        private void combo_vis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_vis.Text == "Gratis")
            {
                textbox_envio.Text = "";
                check_envio.Enabled = false;
                textbox_envio.Enabled = false;
            }
            else
            {
                check_envio.Enabled = true;
                textbox_envio.Enabled = true;
            }
        }
    }
}
