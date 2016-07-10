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
using System.IO;

namespace MercadoEnvio.ABMRol
{
    public partial class bajaRol : Form
    {
        private ABM_Rol_DAO abm_rol;

        public bajaRol()
        {
            leerArchivoConfig();
            abm_rol = new ABM_Rol_DAO();
            InitializeComponent();
            cargarComboDeNombres();
        }

        /*CARGO EL COMBOBOX CON TODOS LOS ROLES EXISTENTES PEGANDOLE A DM.ROL*/
        public void cargarComboDeNombres()
        {
            foreach (string nombre in abm_rol.get_roles())
            {
                comboNombresRoles.Items.Add(nombre);
            }
        }

        /* */
        private void botonBaja_Click(object sender, EventArgs e)
        {
            int id_rol = abm_rol.getIdRol(comboNombresRoles.SelectedItem.ToString());
            abm_rol.updateEstadoRol("D", id_rol);

            // INHABILITAR A LOS USUARIOS QUE TENGAN ASIGNADO EL ROL (¿QUE ONDA ESTO?)
            MessageBox.Show("El rol ha sido dado de baja exitosamente");
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
