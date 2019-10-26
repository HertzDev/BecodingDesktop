using BecodingDesktop.Interfaces.Admin;
using BecodingDesktop.Interfaces.Admin.Catalogs;
using BecodingDesktop.Models;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BecodingDesktop.Controllers.Admin.Users
{
    class AddReplaceUser : IUser
    {
        private readonly IRole _role;

        public AddReplaceUser(IRole role)
        {
            _role = role;
        }
        public List<Control> CreateView(UserModel user)
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
                Dock = DockStyle.Fill,
                Text = string.IsNullOrEmpty(user?.Name)?string.Empty:user?.Name
            };
            controls.Add(txtUserName);

            MaterialSingleLineTextField txtEmail = new MaterialSingleLineTextField()
            {
                Name = "txtEmail",
                Hint = "Ingresa el correo electronico del Usuario",
                Margin = margin,
                Size = size,
                Dock = DockStyle.Fill,
                Text=string.IsNullOrEmpty(user?.Email) ? string.Empty : user?.Email
            };
            controls.Add(txtEmail);

            MaterialSingleLineTextField txtPassword = new MaterialSingleLineTextField()
            {
                Name = "txtPassword",
                Hint = "Ingresa la contraseña del Usuario",
                Margin = margin,
                Size = size,
                Dock = DockStyle.Fill,
                UseSystemPasswordChar=true,
                Text = string.IsNullOrEmpty(user?.Password) ? string.Empty : user?.Password
            };
            controls.Add(txtPassword);

            MaterialSingleLineTextField txtPasswordConfirm = new MaterialSingleLineTextField()
            {
                Name = "txtPassword",
                Hint = "Ingresa nuevamente la contraseña del Usuario",
                Margin = margin,
                Size = size,
                Dock = DockStyle.Fill,
                UseSystemPasswordChar = true,
                Text = string.Empty
            };
            controls.Add(txtPasswordConfirm);

            ComboBox cmbRoles = new ComboBox()
            {
                Name = "cmbRoles",
                Size = size,
                Margin = margin,
                Text = string.IsNullOrEmpty(user?.Role.Name) ? string.Empty:user?.Role.Name
            };
            var roles = _role.GetRoles();
            List<string> list = new List<string>();
            roles.ForEach(r=> {
                list.Add(r.Name);
            });

            cmbRoles.Items.AddRange(list.ToArray());
            var index = roles.FindIndex(r => r.Name.Equals((string.IsNullOrEmpty(user?.RoleText))?string.Empty:user?.RoleText));
            cmbRoles.SelectedIndex = index;
            controls.Add(cmbRoles);
            return controls;
        }
    }
}
