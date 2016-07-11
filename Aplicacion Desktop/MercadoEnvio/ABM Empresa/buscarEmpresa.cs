using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.DataBase.Conexion;
using MercadoEnvio.DataBase.Entidades;
using System.IO;

namespace MercadoEnvio.ABM_Empresa
{
    public partial class buscarEmpresa : Form
    {
        ABM_usuario_DAO abm_usuario;
        public buscarEmpresa()
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
        }

        private void B_Limpiar_Click(object sender, EventArgs e)
        {
            textRazSoc.Text = "";
            textEmail.Text = "";
            textCuit.Text = "";
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa empresaMod = new Empresa();

                DataGridViewRow fila = listado.SelectedRows[0];

                empresaMod.setIdUsername(fila.Cells["USUARIO"].Value.ToString());
                empresaMod.setRazSoc(fila.Cells["RAZON_SOCIAL"].Value.ToString());
                empresaMod.setMail(fila.Cells["EMAIL"].Value.ToString());
                //empresaMod.setTelefono(fila.Cells["TELEFONO"].Value.ToString());
                empresaMod.setFechaCreacion(fila.Cells["FEC_CREACION"].Value.ToString());
                empresaMod.setMail(fila.Cells["EMAIL"].Value.ToString());
                empresaMod.setDomCalle(fila.Cells["DOMICILIO"].Value.ToString());
                empresaMod.setNroCalle(fila.Cells["NRO_CALLE"].Value.ToString());
                empresaMod.setPiso(fila.Cells["PISO"].Value.ToString());
                empresaMod.setDepto(fila.Cells["DPTO"].Value.ToString());
                //empresaMod.setLocalidad(fila.Cells["LOCALIDAD"].Value.ToString());
                empresaMod.setCodPos(fila.Cells["COD_POSTAL"].Value.ToString());
                empresaMod.setTelefono(fila.Cells["TELEFONO"].Value.ToString());
                empresaMod.setRubro(fila.Cells["RUBRO"].Value.ToString());
                empresaMod.setCiudad(fila.Cells["CIUDAD"].Value.ToString());
                empresaMod.setLocalidad(fila.Cells["LOCALIDAD"].Value.ToString());
                empresaMod.setNombreContacto(fila.Cells["NOMBRE_CONTACTO"].Value.ToString());
                empresaMod.setCuit(fila.Cells["CUIT"].Value.ToString());
                empresaMod.setFechaCreacion(fila.Cells["FEC_CREACION"].Value.ToString());

                //String username = abm_usuario.getUsername(fila.Cells["USUARIO"].Value.ToString());
                modificacionEmpresa modificarEmpresa = new modificacionEmpresa(empresaMod);

                modificarEmpresa.Show();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void B_Buscar_Click(object sender, EventArgs e)
        {
            List<String> filtros = new List<String>();
            listado.Rows.Clear();

            if (textRazSoc.Text != "")
                filtros.Add("e.desc_razon_social like '%" + textRazSoc.Text + "%'");
            else
                filtros.Add("1 = 1");
            if (textEmail.Text != "")
                filtros.Add("e.desc_Mail like '%" + textEmail.Text + "%'");
            else
                filtros.Add("1 = 1");
            if (textCuit.Text != "")
                filtros.Add("e.desc_Cuit like '%" + textCuit.Text + "%'");
            else
                filtros.Add("1 = 1");
            
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[18];

            List<SqlDataReader> empresa = abm_usuario.buscarEmpresa(filtros);

            List<String> id_usuarios = new List<String>();
            String id_usuario = "";

            while (empresa[0].Read())
            {
                id_usuario = empresa[0]["id_usuario"].ToString();
                columnas[1] = id_usuario;
                columnas[2] = empresa[0]["desc_razon_social"];
                columnas[3] = empresa[0]["desc_Cuit"];
                columnas[4] = empresa[0]["desc_Fecha_Creacion"];
                columnas[5] = empresa[0]["desc_Mail"];
                columnas[6] = empresa[0]["desc_rubro"];
                columnas[7] = empresa[0]["desc_nombre_contacto"];
                columnas[8] = empresa[0]["desc_Ciudad"];
                columnas[9] = empresa[0]["desc_Dom_Calle"];
                columnas[10] = empresa[0]["desc_Nro_calle"];
                columnas[11] = empresa[0]["desc_Piso"];
                columnas[12] = empresa[0]["desc_Depto"];
                columnas[13] = empresa[0]["desc_Cod_Postal"];
                columnas[14] = empresa[0]["desc_Localidad"];
                columnas[15] = empresa[0]["desc_Telefono"];
                
                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(listado, columnas);
            }
            empresa[0].Close();
            listado.Rows.AddRange(filas.ToArray());
        }

        private void B_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
