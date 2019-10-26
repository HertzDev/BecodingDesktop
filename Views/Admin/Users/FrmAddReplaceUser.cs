using BecodingDesktop.Interfaces.Admin;
using BecodingDesktop.Models;
using BecodingDesktop.Models.Catalogs;
using BecodingDesktop.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecodingDesktop.Views.Admin.Users
{
    public partial class FrmAddReplaceUser : FrmBaseActionContainer
    {
        private readonly IUser _user;
        private readonly UserModel userSend;
        public FrmAddReplaceUser(IUser user, UserModel userModel)
        {
            _user = user;
            this.Size = new Size(450, 400);
            userSend = userModel;
            var controls = user.CreateView(userModel);
            this.flyContainer.Controls.AddRange(controls.ToArray());
            this.btnMainAction.Text = userModel != null ? "ACTUALIZAR" : "GUARDAR";
            this.btnMainAction.Click += ClickEvent;
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            /*var user = new UserModel()
            {
                Id = userSend.Id,
                Name = this.flyContainer.Controls[0].Text,
                Email = this.flyContainer.Controls[1].Text,
                Password = this.flyContainer.Controls[2].Text,
                Role = new RoleModel()
                {
                    Id = ((ComboBox)this.flyContainer.Controls[4]).SelectedIndex,
                    Name = ((ComboBox)this.flyContainer.Controls[4]).SelectedItem.ToString()
                }

            };
            */
        }

        public FrmAddReplaceUser()
        {
            InitializeComponent();
        }
    }
}
