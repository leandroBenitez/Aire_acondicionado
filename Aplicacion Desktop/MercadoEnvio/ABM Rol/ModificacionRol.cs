using MercadoEnvio.DataBase.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.ABMRol
{
    public partial class ModificacionRol : Form
    {
        private ABM_Rol_DAO abm_rol;

        public ModificacionRol()
        {
            leerArchivoConfig();
            abm_rol = new ABM_Rol_DAO();
            InitializeComponent();
            cargarDatosFormulario();
        }

        /* CARGO EL COMBO DE NOMBRES DE ROLES PEGANDOLE A DM.ROL - OK*/
        public void cargarDatosFormulario()
        {
            foreach (string nombre in abm_rol.get_roles())
            {
                comboNombresRoles.Items.Add(nombre);
            }
        }

        /* CUANDO SELECCIONO UN ROL DEL COMBO, CARGO LAS FUNCIONES QUE TIENE Y EL ESTADO EN EL QUE ESTA - OK*/
        private void comboNombresRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboNombresRoles.DropDownStyle;
            // BORRA SI YA SE HABIA SELECCIONADO ALGO POR ERROR
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();

            String rol = comboNombresRoles.SelectedItem.ToString(); // ITEM SELECCIONADO EN EL COMBO
           // MessageBox.Show(abm_rol.getEstadoRol(rol).First().ToString());

            /* SE CARGA EL CHECKEDLIST1 DE FUNCIONES EXISTENTES EN EL ROL (HARDCODE)*/
            foreach (string funcion in abm_rol.getFuncionesAsignadasRol(rol))
            {
                checkedListBox1.Items.Add(funcion);
            }

            /* SE CARGA EL CHECKEDLIST2 DE FUNCIONES PARA AGREGAR AL ROL*/
            foreach (string funcion in abm_rol.getFuncionesFaltantesRol(rol))
            {
                checkedListBox2.Items.Add(funcion);
            }

            // SETEO CHECK DE ESTADO DE ROL 
            if (abm_rol.getEstadoRol(rol).First().ToString().Equals("H"))
                radioButtonH.Select();
            else
                radioButtonD.Select();
        }

        /* PASO LOS ROLES SELECCIONADOS AL OTRO CHECKED DE FUNCIONES SIN ASIGNAR - OK*/
        private void eliminarRol_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                int cantidadItems = checkedListBox1.Items.Count - 1;
                for (int x = 0; x <= cantidadItems; x++)
                {
                    if (checkedListBox1.GetItemChecked(x) == true)
                    {
                        checkedListBox2.Items.Add(checkedListBox1.CheckedItems[0].ToString());
                        checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[0]);
                        x--;
                        cantidadItems--;
                    }
                }
            }
            else
            {
                MessageBox.Show("No se han seleccionado funciones para eliminar");
            }
        }

        /* PASO LOS ROLES SELECCIONADOS AL OTRO CHECKED DE FUNCIONES ASIGNADAS - OK*/
        private void agregarRol_Click(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedItems.Count != 0)
            {
                int cantidadItems = checkedListBox2.Items.Count - 1;
                for (int x = 0; x <= cantidadItems; x++)
                {
                    if (checkedListBox2.GetItemChecked(x) == true)
                    {
                        checkedListBox1.Items.Add(checkedListBox2.CheckedItems[0].ToString());
                        checkedListBox2.Items.Remove(checkedListBox2.CheckedItems[0]);
                        cantidadItems--;
                        x--;
                    }
                }
            }
            else
            {
                MessageBox.Show("No se han seleccionado funciones para agregar");
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_rol = abm_rol.getIdRol(comboNombresRoles.SelectedItem.ToString());

                //ELIMINO TODAS LAS FUNCIONES QUE TIENE ASIGNADAS EL ROL - OK
                abm_rol.deleteFuncionesDeRol(id_rol);

                //AGREGO LAS CORRESPONDIENTES POR LA MODIFICACION
                string funcionalidad;
                int id_func;
                for (int x = 0; x <= checkedListBox1.Items.Count - 1; x++)
                {
                    funcionalidad = checkedListBox1.Items[x].ToString();
                    id_func = abm_rol.getIdFunc(funcionalidad);
                    abm_rol.setearFuncionalidades(funcionalidad, id_func, id_rol);
                }

                string estado = "";
                if (radioButtonH.Checked)
                    estado = "H";
                else
                    estado = "D";

                String nombre = "";

                if (textNewName.Text != "")
                {
                    nombre = textNewName.Text;
                    abm_rol.updateNombreRol(id_rol, nombre);
                }
                // UPDATEO EL ESTADO EN CASO DE QUE SEA NECESARIO
                abm_rol.updateEstadoRol(estado, id_rol);

                //DESHABILITO USUARIO EN CASO DE QUE EL ESTADO DEL ROL SEA D (¿QUE ONDA CON ESTO?)
                MessageBox.Show("El Rol ha sido modificado satisfactoriamente");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Asegúrese de haber completado los datos correspondientes");
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
