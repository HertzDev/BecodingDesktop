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
        public FrmBrands(IBrand brand)
        {
            _brand = brand;
            this.dgvCatalog.DataSource = _brand.GetBrands();
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
            foreach (var item in this.dgvCatalog.Rows)
            {
                ((DataGridViewRow)item).Cells["Edit"].Value = Properties.Resources.I_edit_gray;


            }
            this.dgvCatalog.CellClick += CellClicked;
            this.btnGuardar.Click +=AddReplaceEvent;
        }

        private void CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) 
            {
                this.txtName.Text = this.dgvCatalog.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                this.btnGuardar.Text = "ACTUALIZAR";
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
                    message = btnGuardar.Text.ToLower().Equals("guardar") ? 
                    _brand.SetItem(new BrandModel() { Name = name }):_brand.UpdateItem(new BrandModel() { Name = name,Id=idSelected });
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
        
        }
        public FrmBrands()
        {
            InitializeComponent();
        }
    }
}
