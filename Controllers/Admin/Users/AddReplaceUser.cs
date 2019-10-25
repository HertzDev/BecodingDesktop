using BecodingDesktop.Interfaces.Admin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BecodingDesktop.Controllers.Admin.Users
{
    class AddReplaceUser : IUser
    {
        public List<Control> CreateView()
        {
            List<Control> controls = new List<Control>();
            var font = new Font(SystemFonts.DefaultFont, FontStyle.Bold);
            var margin = new Padding(10, 20, 10, 0);
            var size = new Size(400, 30);
            MaterialSingleLineTextField txtUserName = new MaterialSingleLineTextField()
            {
                Name = "txtUserName",
                Hint = "Ingresa el nombre del Usuario",
                Margin = margin,
                Size = size,
                Dock = DockStyle.Fill
            };
            controls.Add(txtUserName);

            MaterialSingleLineTextField txtEmail = new MaterialSingleLineTextField()
            {
                Name = "txtEmail",
                Hint = "Ingresa el correo electronico del Usuario",
                Margin = margin,
                Size = size,
                Dock = DockStyle.Fill
            };
            controls.Add(txtEmail);

            MaterialSingleLineTextField txtPassword = new MaterialSingleLineTextField()
            {
                Name = "txtPassword",
                Hint = "Ingresa la contraseña del Usuario",
                Margin = margin,
                Size = size,
                Dock = DockStyle.Fill,
                UseSystemPasswordChar=true
            };
            controls.Add(txtPassword);

            MaterialSingleLineTextField txtPasswordConfirm = new MaterialSingleLineTextField()
            {
                Name = "txtPassword",
                Hint = "Ingresa nuevamente la contraseña del Usuario",
                Margin = margin,
                Size = size,
                Dock = DockStyle.Fill,
                UseSystemPasswordChar = true
            };
            controls.Add(txtPasswordConfirm);

            ComboBox cmbRoles = new ComboBox()
            {
                Name = "cmbRoles",
                Size = size,
                Margin = margin
            };

            controls.Add(cmbRoles);

            return controls;
        }
    }
}
