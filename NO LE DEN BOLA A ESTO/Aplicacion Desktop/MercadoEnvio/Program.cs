using MercadoEnvios.ABM_Rol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.ABMRol;
using MercadoEnvio.ABM_Usuario;
using MercadoEnvio.ABM_Empresa;

namespace MercadoEnvio
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new buscarEmpresa());
        }
    }
}

