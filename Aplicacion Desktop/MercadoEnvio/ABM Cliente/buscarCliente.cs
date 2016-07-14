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
using MercadoEnvio.DataBase.Entidades;
using System.Data.SqlClient;
using System.IO;
using MercadoEnvio.ABM_Cliente;

namespace MercadoEnvio.ABM_Usuario
{
    public partial class buscarCliente : Form
    {
        ABM_usuario_DAO abm_usuario;

        private int tamanioPagina = 11;
        private int paginaActual = 1;
        private int totalPaginas = 0;
        public List<String> filtros = new List<String>();

        public buscarCliente()
        {
            abm_usuario = new ABM_usuario_DAO();
            InitializeComponent();
            cargarDatos();
            cargarGrid(filtros);
        }

        public void cargarDatos()
        {
            ComboBoxTipoDoc.Items.Add("DNI");

            filtros.Add(" 1 = 1 ");
            filtros.Add(" 1 = 1 ");
            filtros.Add(" 1 = 1 ");
            filtros.Add(" 1 = 1 ");
            filtros.Add(" 1 = 1 ");
        }

        private void B_Buscar_Click(object sender, EventArgs e)
        {
            filtros = new List<String>();
            listado.Rows.Clear();

            this.paginaActual = 1;

            if (textApellido.Text != "")
                filtros.Add("c.desc_apellido like '%" + textApellido.Text + "%'");
            else
                filtros.Add("1 = 1");
            if (textNombre.Text != "")
                filtros.Add("c.desc_Nombre like '%" + textNombre.Text + "%'");
            else
                filtros.Add("1 = 1");
            if (ComboBoxTipoDoc.Text != "")
                filtros.Add("c.desc_tipo_doc like '%" + ComboBoxTipoDoc.Text + "%'");
            else 
                filtros.Add("1 = 1");
            if (textDni.Text != "")
                filtros.Add("c.desc_Dni like '%" + textDni.Text + "%'");
            else 
                filtros.Add("1 = 1");
            if (textEmail.Text != "")
                filtros.Add("c.desc_Mail like '%" + textEmail.Text + "%'");
            else
                filtros.Add("1 = 1");

            cargarGrid(filtros);
        }

        public void cargarGrid(List<String> filtros)
        {
            listado.Rows.Clear();

            int totalRegistros = abm_usuario.obtenerTotalRegistrosCliente(filtros);
            this.totalPaginas = calcularTotalDePaginas(totalRegistros);

            List<SqlDataReader> clientes = abm_usuario.buscarCliente(filtros, paginaActual, tamanioPagina);

            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[17];

              while (clientes[0].Read())
             {
                //id_usuario = clientes[0]["id_usuario"].ToString();
                //id_usuarios.Add(id_usuario);
                columnas[1] = clientes[0]["id_usuario"].ToString();  //id_usuario;
                columnas[2] = clientes[0]["desc_Apellido"];
                columnas[3] = clientes[0]["desc_Nombre"];
                columnas[4] = clientes[0]["desc_tipo_doc"];
                columnas[5] = clientes[0]["desc_Dni"];
                columnas[6] = clientes[0]["desc_Mail"];
                columnas[7] = clientes[0]["desc_Dom_Calle"];
                columnas[8] = clientes[0]["desc_Nro_Calle"];
                columnas[9] = clientes[0]["desc_Piso"];
                columnas[10] = clientes[0]["desc_Depto"];
                columnas[11] = clientes[0]["desc_Localidad"];
                columnas[12] = clientes[0]["desc_Cod_Postal"];
                columnas[13] = clientes[0]["desc_Telefono"];
                columnas[14] = clientes[0]["desc_Fecha_Nac"];
                columnas[15] = clientes[0]["desc_Fecha_Creacion"];

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(listado, columnas);
             }
              clientes[0].Close();
              listado.Rows.AddRange(filas.ToArray());
        }

        private void B_Limpiar_Click(object sender, EventArgs e)
        {
            textApellido.Text = "";
            textNombre.Text = "";
            textDni.Text = "";
            textEmail.Text = "";
            textDni.Text = "";
            ComboBoxTipoDoc.Text = "";
        }
  
        private void buttonMod_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente clienteMod = new Cliente();

                DataGridViewRow fila = listado.SelectedRows[0];

                clienteMod.setApellido(fila.Cells["APELLIDO"].Value.ToString());
                clienteMod.setNombre(fila.Cells["NOMBRE"].Value.ToString());
                clienteMod.setFecha_nacimiento(fila.Cells["FEC_NAC"].Value.ToString());
                clienteMod.setDni(fila.Cells["DNI"].Value.ToString());
                clienteMod.setMail(fila.Cells["EMAIL"].Value.ToString());
                clienteMod.setDireccion(fila.Cells["DOMICILIO"].Value.ToString());
                clienteMod.setNroCalle(fila.Cells["NRO_CALLE"].Value.ToString());
                clienteMod.setPiso(fila.Cells["PISO"].Value.ToString());
                clienteMod.setDepto(fila.Cells["DPTO"].Value.ToString());
                clienteMod.setCodigo_postal(fila.Cells["COD_POSTAL"].Value.ToString());
                clienteMod.setLocalidad(fila.Cells["LOCALIDAD"].Value.ToString());
                clienteMod.setTelefono(fila.Cells["TELEFONO"].Value.ToString());
                clienteMod.setTipoDoc(fila.Cells["TIPO_DOC"].Value.ToString());
                clienteMod.setUsername(fila.Cells["USUARIO"].Value.ToString());
                clienteMod.setFechaCreacion(fila.Cells["FECHA_CREACION"].Value.ToString());

                String username = abm_usuario.getUsername(fila.Cells["USUARIO"].Value.ToString());

                //clienteMod.setRol(fila.Cells["ROL"].Value.ToString());
                //String id_rol = ;
                //clienteMod.setRol(abm_usuario.getDescRol(id_rol));


                modificacionCliente modificarCliente = new modificacionCliente(clienteMod);

                modificarCliente.Show();
            }
            catch
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }
   
        private void B_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /* VER COMO OBTENER UNA COLUMNA (ID_USUARIO) PARA DAR DE BAJA CON EL METODO QUE YA CREE */
        private void buttonBaja_Click(object sender, EventArgs e)
        {
           /*
            String id_user;

            // Get the currently selected row using the SelectedRow property.
            DataGrid row = listado.SelectedRows();

            // Display the first name from the selected row.
            // In this example, the third column (index 2) contains
            // the first name.
            MessageLabel.Text = "You selected " + row.Cells[2].Text + ".";

            if (abm_usuario.getEstadoUsuario(textUsername.Text) == "1")
            {
                //abm_usuario.deshabilitarUsuario(textUsername.Text);
                MessageBox.Show("El Uusario ha sido deshabilitado exitosamente");
            }else
            {
                //abm_usuario.habilitarUsuario(textUsername.Text);
                MessageBox.Show("El Uusario ha sido habilitado exitosamente");
            }
            this.Close();
            * */
        }

        private int calcularTotalDePaginas(int cantRegistros)
        {
            int aux;
            aux = cantRegistros / this.tamanioPagina;
            if (cantRegistros % this.tamanioPagina > 0)
            {
                aux += 1;
            }
            return aux;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(this.paginaActual == this.totalPaginas))
            {
                this.paginaActual += 1;
                cargarGrid(this.filtros);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(this.paginaActual == 1))
            {
                this.paginaActual -= 1;
                cargarGrid(this.filtros);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.paginaActual = this.totalPaginas;
            cargarGrid(this.filtros);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.paginaActual = 1;
            cargarGrid(this.filtros);
        }

    }
}
