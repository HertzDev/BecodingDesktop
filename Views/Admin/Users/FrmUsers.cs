using BecodingDesktop.Controllers.Admin.Catalogs;
using BecodingDesktop.Controllers.Admin.Users;
using BecodingDesktop.Helpers;
using BecodingDesktop.Helpers.Enums;
using BecodingDesktop.Interfaces.Admin.Users;
using BecodingDesktop.Interfaces.General;
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
    public partial class FrmUsers : FrmBaseBussinessContainer
    {
        private readonly IUserLogic _userLogic;
        private readonly ICatalogBase _catalog = new CatalogBase();
        private List<UserModel> users = new List<UserModel>();
        public FrmUsers(IUserLogic userLogic)
        {
            _userLogic = userLogic;
            users = _userLogic.GetUsers();
            this.SetDatagridViewElements(users);
            this.btnAdd.Click += OpenAddForm;
            this.dtBussiness.CellClick += CellClicked;
            this.txtSearch.TextChanged += SearchTextChanged;
            this.lblTitle.Text = "USUARIOS";
            

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
                this.dtBussiness.Columns["Password"].Visible = false;
                this.dtBussiness.Columns["Role"].Visible = false;
                this.dtBussiness.Columns["RoleText"].HeaderText=headers[3];
                this.dtBussiness.Columns["Name"].HeaderText = headers[1];
                this.dtBussiness.Columns["Name"].DisplayIndex = 1;
                this.dtBussiness.Columns["Email"].HeaderText = headers[2];
                this.dtBussiness.Columns["Email"].DisplayIndex = 2;
                this.dtBussiness.Columns["CreationDate"].HeaderText = headers[4];
                this.dtBussiness.Columns["CreationDate"].DisplayIndex = 3;
                this.dtBussiness.Columns["State"].Visible = false;
                this.dtBussiness.Columns["StateText"].HeaderText = headers[5];
                this.dtBussiness.Columns["StateText"].DisplayIndex = 4;
                this.dtBussiness.Columns.Add(new DataGridViewImageColumn() { Name = "Edit", Image = Properties.Resources.I_edit_gray });
                this.dtBussiness.Columns.Add(new DataGridViewImageColumn() { Name = "Detail", Image = Properties.Resources.I_bill_black });
                this.dtBussiness.Columns["Edit"].HeaderText = headers[6];
                this.dtBussiness.Columns["Edit"].DisplayIndex = 5;
                this.dtBussiness.Columns["Detail"].HeaderText = headers[7];
                this.dtBussiness.Columns["Detail"].DisplayIndex = 6;
                headers.Insert(0, "Todo");
                this.cmbFilters.Text = "Todo";
                headers.Remove("");
                this.cmbFilters.Items.AddRange(headers.ToArray());


                foreach (var item in this.dtBussiness.Rows)
                {
                    ((DataGridViewRow)item).Cells["Edit"].Value = Properties.Resources.I_edit_gray;

                    ((DataGridViewRow)item).Cells["Detail"].Value = Properties.Resources.I_bill_black;
                }

            }
            this.lblTotalCount.Text = this.dtBussiness.Rows.Count.ToString();
           
        }

        private void OpenAddForm(object sender, EventArgs e)
        {
            var form = FormManager.GetFormSelected(MenuOptionName.USERSADD);
            form.Show(this);
        }

        public void RefreshTable(List<UserModel> users)
        {
            this.users = users;
            this.dtBussiness.DataSource = users;
        }

        private void CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 0 || e.ColumnIndex==1) && e.RowIndex >= 0)
            {
                var user = new UserModel()
                {
                    Id = int.Parse(this.dtBussiness.Rows[e.RowIndex].Cells["Id"].Value.ToString()),
                    Email = this.dtBussiness.Rows[e.RowIndex].Cells["Email"].Value.ToString(),
                    Name = this.dtBussiness.Rows[e.RowIndex].Cells["Name"].Value.ToString(),
                    Password = this.dtBussiness.Rows[e.RowIndex].Cells["Password"].Value.ToString(),
                    Role = new RoleModel()
                    {
                        Id = int.Parse(((RoleModel)this.dtBussiness.Rows[e.RowIndex].Cells["Role"].Value).Id.ToString()),
                        Name = this.dtBussiness.Rows[e.RowIndex].Cells["RoleText"].Value.ToString()
                    },
                    RoleText= this.dtBussiness.Rows[e.RowIndex].Cells["RoleText"].Value.ToString(),
                    State = int.Parse(this.dtBussiness.Rows[e.RowIndex].Cells["State"].Value.ToString()),
                    StateText = this.dtBussiness.Rows[e.RowIndex].Cells["StateText"].Value.ToString(),
                    CreationDate = this.dtBussiness.Rows[e.RowIndex].Cells["CreationDate"].Value.ToString()
                };
                if (e.ColumnIndex == 0)
                {
                    var form = new FrmAddReplaceUser(new AddReplaceUser(new Role()),user,new User(_catalog));
                    form.Show(this);
                }
                else
                {
                    var form = new FrmDetailUser(new DetailUser(), user);
                    form.Show(this);
                }
            }
        }
        private void SearchTextChanged(object sender, EventArgs e)
        {
            var filter = this.cmbFilters.Items.IndexOf(this.cmbFilters.Text);
            var text = this.txtSearch.Text.ToLower();
            if (string.IsNullOrEmpty(text))
            {
                this.dtBussiness.DataSource = this.users;
            }
            else
            {
                switch (filter)
                {
                    case 0:
                        {

                            this.dtBussiness.DataSource = this.users.FindAll(r => r.Id.ToString().Contains(text) || r.Name.ToLower().Contains(text) || r.StateText.ToLower().Contains(text) 
                            || r.CreationDate.Contains(text) || r.Email.Contains(text) || r.RoleText.Contains(text));
                            break;
                        }
                    case 1:
                        {
                            this.dtBussiness.DataSource = this.users.FindAll(r => r.Id.ToString().Contains(text));
                            break;

                        }
                    case 2:
                        {
                            this.dtBussiness.DataSource = this.users.FindAll(r => r.Name.ToLower().Contains(text));
                            break;

                        }

                    case 3:
                        {
                            this.dtBussiness.DataSource = this.users.FindAll(r => r.Email.ToLower().Contains(text));
                            break;

                        }
                    case 4:
                        {
                            this.dtBussiness.DataSource = this.users.FindAll(r => r.RoleText.ToLower().Contains(text));
                            break;

                        }
                    case 5:
                        {
                            this.dtBussiness.DataSource = this.users.FindAll(r => r.CreationDate.Contains(text));
                            break;

                        }

                    case 6:
                        {
                            this.dtBussiness.DataSource = this.users.FindAll(r => r.StateText.ToLower().Contains(text));
                            break;

                        }
                    
                }
            }

        }

    }
}
