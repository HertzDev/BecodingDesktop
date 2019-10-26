using BecodingDesktop.Controllers.Admin.Catalogs;
using BecodingDesktop.Controllers.Admin.Users;
using BecodingDesktop.Helpers;
using BecodingDesktop.Interfaces.Admin;
using BecodingDesktop.Models;
using BecodingDesktop.Views.Base;
using MaterialSkin.Controls;
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
    public partial class FrmDetailUser : FrmBaseActionContainer
    {
        private readonly IUser _user;
        private readonly UserModel user;


        public FrmDetailUser(IUser user,UserModel userModel)
        {
            _user = user;
            this.user = userModel;
            this.Size = new Size(450, 400);
            var controls = _user.CreateView(userModel);
            this.flyContainer.Controls.AddRange(controls.ToArray());
            this.btnMainAction.Click += UpdateClick;
            this.btnCancel.Click += CancelEvent;
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            var form = new FrmAddReplaceUser(new AddReplaceUser(new Role()),user,new User(new CatalogBase()));
            form.Show(this.Owner);
            this.Close();
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            this.Close();
        }

        public FrmDetailUser()
        {
            InitializeComponent();
        }
    }
}
