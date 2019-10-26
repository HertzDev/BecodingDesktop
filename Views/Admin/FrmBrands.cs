using BecodingDesktop.Helpers;
using BecodingDesktop.Helpers.Enums;
using BecodingDesktop.Interfaces.Admin.Catalogs;
using BecodingDesktop.Models;
using BecodingDesktop.Models.Catalogs;
using BecodingDesktop.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BecodingDesktop.Views.Admin
{
    public partial class FrmBrands : FrmBasicCatalogContainer
    {
        private readonly IBrand _brand;
        private int idSelected = 0;

        private void SetDatagridViewElements(List<BrandModel> brands)
        {

            this.dgvCatalog.DataSource = brands;
            if (this.dgvCatalog.Rows.Count > 0)
            {
                var headers = _brand.GetHeaders();
                this.dgvCatalog.Columns["Id"].HeaderText = headers[4];
                this.dgvCatalog.Columns["Id"].DisplayIndex = 0;
                this.dgvCatalog.Columns["UpdateDate"].Visible = false;
                this.dgvCatalog.Columns["Name"].HeaderText = headers[0];
                this.dgvCatalog.Columns["Name"].DisplayIndex = 1;
                this.dgvCatalog.Columns["CreationDate"].HeaderText = headers[1];
                this.dgvCatalog.Columns["CreationDate"].DisplayIndex = 3;
                this.dgvCatalog.Columns["State"].Visible = false;
                this.dgvCatalog.Columns["StateText"].HeaderText = headers[2];
                this.dgvCatalog.Columns["StateText"].DisplayIndex = 2;
                this.dgvCatalog.Columns.Add(new DataGridViewImageColumn() { Name = "Edit", Image = Properties.Resources.I_edit_gray });
                this.dgvCatalog.Columns["Edit"].HeaderText = headers[3];
                this.dgvCatalog.Columns["Edit"].DisplayIndex = 4;
                headers.Insert(0, "Todo");
                this.cmbFilters.Text = "Todo";
                headers.Remove("");
                this.cmbFilters.Items.AddRange(headers.ToArray());


                foreach (var item in this.dgvCatalog.Rows)
                {
                    ((DataGridViewRow)item).Cells["Edit"].Value = Properties.Resources.I_edit_gray;


                }

            }
            this.dgvCatalog.CellClick += CellClicked;
            this.btnGuardar.Click += AddReplaceEvent;
            this.txtSearch.TextChanged += SearchTextChanged;

        }

        private void SearchTextChanged(object sender, EventArgs e)
        {
            var filter = this.cmbFilters.Items.IndexOf(this.cmbFilters.Text);
            var text = this.txtSearch.Text.ToLower();
            if (string.IsNullOrEmpty(text))
            {
                this.dgvCatalog.DataSource = this.brands;
            }
            else
            {
                switch (filter)
                {
                    case 0:
                        {

                            this.dgvCatalog.DataSource = this.brands.FindAll(r => r.Id.ToString().Contains(text) || r.Name.ToLower().Contains(text) || r.StateText.ToLower().Contains(text) || r.CreationDate.Contains(text));
                            break;
                        }
                    case 1:
                        {
                            this.dgvCatalog.DataSource = this.brands.FindAll(r => r.Name.ToLower().Contains(text));
                            break;

                        }
                    case 2:
                        {
                            this.dgvCatalog.DataSource = this.brands.FindAll(r => r.CreationDate.Contains(text));
                            break;

                        }

                    case 3:
                        {
                            this.dgvCatalog.DataSource = this.brands.FindAll(r => r.StateText.ToLower().Contains(text));
                            break;

                        }
                    case 4:
                        {
                            this.dgvCatalog.DataSource = this.brands.FindAll(r => r.Id.ToString().Contains(text));
                            break;

                        }
                }
            }
           
        }
        List<BrandModel> brands;
        public FrmBrands(IBrand brand)
        {
            _brand = brand;
            brands = _brand.GetBrands();
            SetDatagridViewElements(brands);
            this.ClearProperties();
        }

        private void CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) 
            {
                this.txtName.Text = this.dgvCatalog.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                this.btnGuardar.Text = "ACTUALIZAR";
                var state= this.dgvCatalog.Rows[e.RowIndex].Cells["State"].Value.ToString().Equals("0");
                this.rdoActive.Checked = state;
                this.rdoInactive.Checked = !state;
                this.rdoActive.Visible = true;
                this.rdoInactive.Visible = true;
                this.idSelected = int.Parse(this.dgvCatalog.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            }
        }

        private void AddReplaceEvent(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            if (ValidatorManager.IsValid(TypeValidation.WORD, name)) {
                
                DialogResult result=MessageBox.Show("¿Estás seguro que deseas " + btnGuardar.Text + " la marca "+name+"?","",MessageBoxButtons.OKCancel);
                if (result.Equals(DialogResult.OK)) 
                {
                    MessageModel message = null;
                    if (btnGuardar.Text.Equals("guardar"))
                    {
                        message = _brand.SetItem(new BrandModel() { Name = name });
                    }
                    else
                    {
                        message=_brand.UpdateItem(new BrandModel() { Name = name, Id = idSelected });

                        message = _brand.UpdateStateItem(new BrandModel() { State = (this.rdoActive.Checked)?0:1, Id = idSelected });

                    }
                    if (message.Code == 200)
                    {
                        this.dgvCatalog.DataSource = _brand.GetBrands();
                        this.ClearProperties();
                    }
                    else
                    {
                        MessageBox.Show(message.Message);

                    }
                }
            }
            else
            {
                MessageBox.Show("Debes completar todos los parametros antes de realizar el proceso");
            }
            
        }

        private void ClearProperties() 
        {
            this.btnGuardar.Text = "GUARDAR";
            this.txtName.Text = string.Empty;
            this.lblTotalCount.Text = this.dgvCatalog.Rows.Count.ToString();
            this.rdoActive.Visible = false;
            this.rdoInactive.Visible = false;
        }
        public FrmBrands()
        {
            InitializeComponent();
        }
    }
}
