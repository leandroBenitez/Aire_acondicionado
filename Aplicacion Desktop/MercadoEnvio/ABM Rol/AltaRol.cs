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

namespace MercadoEnvios.ABM_Rol
{
    public partial class altaRol : Form
    {
        private ABM_Rol_DAO abm_rol;

        public altaRol()
        {
            leerArchivoConfig();
            abm_rol = new ABM_Rol_DAO();
            InitializeComponent();
            cargar_funciones();
        }

        /* CARGO EL CHEKEDLSITBOX CON TODAS LAS FUNCIONALIDADES QUE PUEDE TENER EL ROL*/
        public void cargar_funciones() 
        {
            foreach (string funcion in abm_rol.get_funciones())
            {
                checkedListBox1.Items.Add(funcion);
            }
        }

        /* LIMPIO LAS FUNCIONALIDADES CON CHECK EN CASO DE CONFUSIÓN OK*/
        private void limpiar_Click(object sender, EventArgs e)
        {
            foreach (string aux in abm_rol.get_funciones())
            {
                checkedListBox1.Items.Remove(aux);
            }
            cargar_funciones();
        }

        /* CARGO LAS TABLAS CUANDO ACEPTO*/
        private void aceptar_Click(object sender, EventArgs e)
        {
            /* VERIFICO QUE TODOS LOS CAMPOS ESTÉN CARGADOS CORRECTAMENTE */
            if (textNombre.Text != "")
            {
                if (abm_rol.rolExistente(textNombre.Text) == 0)
                {
                    abm_rol = new ABM_Rol_DAO();

                    /* SETEO TABLA ROL Y OBTENGO EL NÚMERO DE RUBRO*/
                    int id_nuevo_rol = abm_rol.setearRol(textNombre.Text);
                    // Determine if there are any items checked.
                    if (checkedListBox1.CheckedItems.Count != 0)
                    {
                        int i = 0;
                        // If so, loop through all checked items and add to table
                        for (int x = 0; x <= checkedListBox1.Items.Count - 1; x++)
                        {
                            if (checkedListBox1.GetItemChecked(x) == true)
                            {
                                abm_rol.setearFuncionalidades(checkedListBox1.CheckedItems[i].ToString(), x + 1, id_nuevo_rol);
                                i++;
                            }
                        }
                    }
                    MessageBox.Show("El rol ha sido dado de alta satisfactoriamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El nombre de rol ingresado ya existe");
                }
            }
            else
            {
                MessageBox.Show("El nuevo Rol debe tener un nombre");
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
