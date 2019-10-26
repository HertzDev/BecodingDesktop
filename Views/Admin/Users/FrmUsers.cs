﻿using BecodingDesktop.Helpers;
using BecodingDesktop.Helpers.Enums;
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
    public partial class FrmUsers : FrmBaseBussinessContainer
    {
        
        public FrmUsers()
        {
            InitializeComponent();
            this.btnAdd.Click += OpenAddForm;
        }

        private void OpenAddForm(object sender, EventArgs e)
        {
            var form = FormManager.GetFormSelected(MenuOptionName.USERSADD);
            form.Show();
        }
    }
}
