using BecodingDesktop.Helpers;
using BecodingDesktop.Helpers.Enums;
using BecodingDesktop.Interfaces.Admin.Users;
using BecodingDesktop.Models;
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
        private readonly IUserLogic _userLogic;
        public FrmUsers(IUserLogic userLogic)
        {
            _userLogic = userLogic;
            this.SetDatagridViewElements(_userLogic.GetUsers());
            this.btnAdd.Click += OpenAddForm;
        }
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void SetDatagridViewElements(List<UserModel> users)
        {

            this.dtBussiness.DataSource = users;
            if (this.dtBussiness.Rows.Count > 0)
            {
                var headers = _userLogic.GetHeaders();
                this.dtBussiness.Columns["Id"].HeaderText = headers[0];
                this.dtBussiness.Columns["Id"].DisplayIndex = 0;
                this.dtBussiness.Columns["UpdateDate"].Visible = false;
                this.dtBussiness.Columns["Name"].HeaderText = headers[1];
                this.dtBussiness.Columns["Name"].DisplayIndex = 1;
                this.dtBussiness.Columns["Email"].HeaderText = headers[2];
                this.dtBussiness.Columns["Email"].DisplayIndex = 2;
                this.dtBussiness.Columns["CreationDate"].HeaderText = headers[3];
                this.dtBussiness.Columns["CreationDate"].DisplayIndex = 3;
                this.dtBussiness.Columns["State"].Visible = false;
                this.dtBussiness.Columns["StateText"].HeaderText = headers[4];
                this.dtBussiness.Columns["StateText"].DisplayIndex = 4;
                this.dtBussiness.Columns.Add(new DataGridViewImageColumn() { Name = "Edit", Image = Properties.Resources.I_edit_gray });
                this.dtBussiness.Columns["Edit"].HeaderText = headers[5];
                this.dtBussiness.Columns["Edit"].DisplayIndex = 5;
                headers.Insert(0, "Todo");
                this.cmbFilters.Text = "Todo";
                headers.Remove("");
                this.cmbFilters.Items.AddRange(headers.ToArray());


                foreach (var item in this.dtBussiness.Rows)
                {
                    ((DataGridViewRow)item).Cells["Edit"].Value = Properties.Resources.I_edit_gray;


                }

            }
           
        }

        private void OpenAddForm(object sender, EventArgs e)
        {
            var form = FormManager.GetFormSelected(MenuOptionName.USERSADD);
            form.Show(this);
        }

        public void RefreshTable(List<UserModel> users)
        {
            this.dtBussiness.DataSource = users;
        }
    }
}
