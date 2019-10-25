using BecodingDesktop.Controllers.Admin.Catalogs;
using BecodingDesktop.Controllers.Admin.Users;
using BecodingDesktop.Views.Admin.Users;
using System;
using System.Windows.Forms;

namespace BecodingDesktop
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
            var prueba = new Role();
            prueba.SetItem();
            Application.Run(new FrmDetailUser(new DetailUser()));
        }
    }
}
