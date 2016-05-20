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

        public void cargarDatosFormulario()
        {
            /* SE CARGA EL COMBO DE NOMBRES DE ROLES */
            foreach (string nombre in abm_rol.get_roles())
            {
                comboNombresRoles.Items.Add(nombre);
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

        private void comboNombresRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // FALTIA BORRAR SI YA SE HABIA SELECCIONADO ALGO POR ERROR (PROBAR)
            //comboNombresRoles.Items.Clear();

            String rubro = comboNombresRoles.SelectedItem.ToString();
            /* SE CARGA EL CHECKEDLIST DE FUNCIONES EXISTENTES EN EL ROL (HARDCODE)*/
            foreach (string funcion in abm_rol.getFuncionesAsignadasRol(rubro))
            {
                checkedListBox1.Items.Add(funcion);
            }

            
            /* SE CARGA EL CHECKEDLIST DE FUNCIONES PARA AGREGAR AL ROL*/
        }

    }
}
