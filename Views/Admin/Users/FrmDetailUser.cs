﻿using BecodingDesktop.Interfaces.Admin;
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
    public partial class FrmDetailUser : FrmBaseActionContainer
    {
        private readonly IUser _user;
        public FrmDetailUser(IUser user)
        {
            _user = user;
            this.Size = new Size(450, 400);
            var controls = _user.CreateView();
            this.flyContainer.Controls.AddRange(controls.ToArray());
        }
        public FrmDetailUser()
        {
            InitializeComponent();
        }
    }
}