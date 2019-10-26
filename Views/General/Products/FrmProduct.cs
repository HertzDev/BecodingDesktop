using BecodingDesktop.Controllers.Admin.Catalogs;
using BecodingDesktop.Controllers.Admin.Users;
using BecodingDesktop.Helpers;
using BecodingDesktop.Helpers.Enums;
using BecodingDesktop.Interfaces.Admin.Users;
using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Models;
using BecodingDesktop.Models.Catalogs;
using BecodingDesktop.Models.General;
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

namespace BecodingDesktop.Views.General.Products
{
    public partial class FrmProduct : FrmBaseBussinessContainer
    {

        private readonly IProduct _idata;
        private readonly ICatalogBase _catalog = new CatalogBase();
        private List<ProductModel> products = new List<ProductModel>();
        public FrmProduct(IProduct idata)
        {
            _idata = idata;
            products = _idata.GetProducts();
            this.lblTitle.Text = "PRODUCTOS";
            this.SetDatagridViewElements(products);
            this.btnAdd.Click += OpenAddForm;
            //this.dtBussiness.CellClick += CellClicked;
            this.txtSearch.TextChanged += SearchTextChanged;


        }
        public FrmProduct()
        {
            InitializeComponent();
        }




        private void SetDatagridViewElements(List<ProductModel> data)
        {

            this.dtBussiness.DataSource = data;
            if (this.dtBussiness.Rows.Count > 0)
            {
                var headers = _idata.GetHeaders();
                this.dtBussiness.Columns["Id"].HeaderText = headers[0];
                this.dtBussiness.Columns["Id"].DisplayIndex = 0;
                this.dtBussiness.Columns["UpdateDate"].Visible = false;
                this.dtBussiness.Columns["Description"].Visible = false;
                this.dtBussiness.Columns["ProductCode"].Visible = false;
                this.dtBussiness.Columns["Name"].HeaderText = headers[1];
                this.dtBussiness.Columns["Name"].DisplayIndex = 1;

                this.dtBussiness.Columns["Price"].HeaderText = headers[2];
                this.dtBussiness.Columns["Price"].DisplayIndex = 2;

                this.dtBussiness.Columns["Existence"].HeaderText = headers[3];
                this.dtBussiness.Columns["Existence"].DisplayIndex = 3;

                this.dtBussiness.Columns["CreationDate"].HeaderText = headers[4];
                this.dtBussiness.Columns["CreationDate"].DisplayIndex = 4;

                this.dtBussiness.Columns["State"].Visible = false;
                this.dtBussiness.Columns["StateText"].HeaderText = headers[5];
                this.dtBussiness.Columns["StateText"].DisplayIndex =5;

                this.dtBussiness.Columns.Add(new DataGridViewImageColumn() { Name = "Edit", Image = Properties.Resources.I_edit_gray });
                this.dtBussiness.Columns.Add(new DataGridViewImageColumn() { Name = "Detail", Image = Properties.Resources.I_bill_black });
                this.dtBussiness.Columns["Edit"].HeaderText = headers[6];
                this.dtBussiness.Columns["Edit"].DisplayIndex = 6;
                this.dtBussiness.Columns["Detail"].HeaderText = headers[7];
                this.dtBussiness.Columns["Detail"].DisplayIndex = 7;
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
            var form = FormManager.GetFormSelected(MenuOptionName.PRODUCTSADO);
            form.Show(this);
        }

        public void RefreshTable(List<ProductModel> data)
        {
            this.products = data;
            this.dtBussiness.DataSource = data;
        }





        private void SearchTextChanged(object sender, EventArgs e)
        {
            var filter = this.cmbFilters.Items.IndexOf(this.cmbFilters.Text);
            var text = this.txtSearch.Text.ToLower();
            if (string.IsNullOrEmpty(text))
            {
                this.dtBussiness.DataSource = this.products;
            }
            else
            {
                switch (filter)
                {
                    case 0:
                        {

                            this.dtBussiness.DataSource = this.products.FindAll(r => r.Id.ToString().Contains(text) || r.Name.ToLower().Contains(text) || r.StateText.ToLower().Contains(text)
                            || r.CreationDate.Contains(text) || r.Price.ToString().Contains(text) || r.Existence.ToString().Contains(text));
                            break;
                        }
                    case 1:
                        {
                            this.dtBussiness.DataSource = this.products.FindAll(r => r.Id.ToString().Contains(text));
                            break;

                        }
                    case 2:
                        {
                            this.dtBussiness.DataSource = this.products.FindAll(r => r.Name.ToLower().Contains(text));
                            break;

                        }


                    case 3:
                        {
                            this.dtBussiness.DataSource = this.products.FindAll(r => r.Price.ToString().Contains(text));
                            break;

                        }

                    case 4:
                        {
                            this.dtBussiness.DataSource = this.products.FindAll(r => r.Existence.ToString().Contains(text));
                            break;

                        }

                    case 5:
                        {
                            this.dtBussiness.DataSource = this.products.FindAll(r => r.CreationDate.Contains(text));
                            break;

                        }

                    case 6:
                        {
                            this.dtBussiness.DataSource = this.products.FindAll(r => r.StateText.ToLower().Contains(text));
                            break;

                        }

                }
            }

        }

    }
}
