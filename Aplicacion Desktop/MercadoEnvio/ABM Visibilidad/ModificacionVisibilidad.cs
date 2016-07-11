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
using MercadoEnvio.DataBase.Conexion;
using System.Data.SqlClient;

namespace MercadoEnvio.ABM_Visibilidad
{
    public partial class ModificacionVisibilidad : Form
    {
        ABM_Visibilidad_DAO abm_visibilidad;
        List<string> id_visibilidad = new List<string>();
        SubMenuVisibilidad unMenu;

        public ModificacionVisibilidad(SubMenuVisibilidad menu)
        {
            leerArchivoConfig();
            abm_visibilidad = new ABM_Visibilidad_DAO();
            InitializeComponent();
            unMenu = menu;
        }
        
        private void Buscar_Click(object sender, EventArgs e)
        {
            tablaVisibilidad.Rows.Clear();
            tablaVisibilidad.Refresh();

            String desc_tipo = textTipo.Text;
            String desc_precio = textPrecio.Text;
            String desc_porcentaje = textPorcentaje.Text;
            String desc_porcentaje_envio = textEnvio.Text;

            id_visibilidad = abm_visibilidad.getIdVisibilidad(desc_tipo, desc_precio, desc_porcentaje, desc_porcentaje_envio);

            string id;

            for (int i = 0; i < id_visibilidad.Count; i++)
            {
                id = id_visibilidad[i];

                tablaVisibilidad.Rows.Add(id,
                                          abm_visibilidad.get_descVisibilidadSegun(id).ToString(), 
                                          abm_visibilidad.get_desc_precioVisibilidadSegun(id).ToString(),
                                          abm_visibilidad.get_desc_porcentajeVisibilidadSegun(id).ToString(),
                                          abm_visibilidad.get_desc_porcentaje_envioVisibilidadSegun(id).ToString());
            }

        }

        private void Click_En_Seleccionar(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaVisibilidad.CurrentCell.ColumnIndex == 5)
            {
                var row = tablaVisibilidad.CurrentRow;

                ListadoVisibilidad formListado = new ListadoVisibilidad(int.Parse(row.Cells[0].Value.ToString()), unMenu);
                formListado.Show();
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            textTipo.Text = "";
            textPrecio.Text = "";
            textPorcentaje.Text = "";
            textEnvio.Text = "";
        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow fila = tablaVisibilidad.SelectedRows[0];
                int visibilidad = int.Parse(fila.Cells["Id"].Value.ToString());

                ListadoVisibilidad formCalificar = new ListadoVisibilidad(visibilidad, unMenu);
                formCalificar.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            unMenu.Show();
            this.Close();
        }

        private void leerArchivoConfig()
        {
            try
            {
                using (StreamReader sr = new StreamReader("ArchivoConfiguracion.txt"))
                {
                    string line, textoArchivo = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        textoArchivo = textoArchivo + line + "\n";
                    }

                    char[] delimitadores = { ' ', ',', '.', '\t', '\n' };

                    string[] palabras = textoArchivo.Split(delimitadores);

                    ConstantesBD.fechaSistema = palabras[2];
                    ConstantesBD.Param_Conexion_urlServidor = palabras[9];
                    ConstantesBD.Param_Conexion_usuario = palabras[14];
                    ConstantesBD.Param_Conexion_contraseña = palabras[17];
                    ConstantesBD.Param_Conexion_nombreBD = palabras[24];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al leer el archivo de configuracion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textEnvio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
