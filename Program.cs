using BecodingDesktop.Controllers.Admin.Catalogs;
using BecodingDesktop.Controllers.Admin.Users;
using BecodingDesktop.Models.Catalogs;
using BecodingDesktop.Views.Admin.Users;
using BecodingDesktop.Views.General;
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
            Application.Run(new FrmLogin());
        }
    }
}
