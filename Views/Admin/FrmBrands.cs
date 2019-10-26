using BecodingDesktop.Interfaces.Admin.Catalogs;
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

        public FrmBrands(IBrand brand)
        {
            _brand = brand;
            this.dgvCatalog.DataSource = _brand.GetBrands();
            var headers = _brand.GetHeaders();
            this.dgvCatalog.Columns["Id"].Visible = false;
            this.dgvCatalog.Columns["UpdateDate"].Visible = false;
            this.dgvCatalog.Columns["Name"].HeaderText = headers[0];
            this.dgvCatalog.Columns["CreationDate"].HeaderText = headers[1];
            this.dgvCatalog.Columns["State"].HeaderText = headers[2];
            


            this.btnGuardar.Click +=AddReplaceEvent;
        }

        private void AddReplaceEvent(object sender, EventArgs e)
        {
           var message= _brand.SetItem(new BrandModel() {Name=this.txtName.Text});
            if (message.Code == 200) 
            {
                this.dgvCatalog.DataSource = _brand.GetBrands();
            }
        }

        public FrmBrands()
        {
            InitializeComponent();
        }
    }
}
