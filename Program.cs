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
            prueba.UpdateStateItem(new Models.Roles.RoleModel()
            {
                Name="Administrador",
                Id=1,
                State=1
            });
            Application.Run(new FrmDetailUser(new DetailUser()));
        }
    }
}
