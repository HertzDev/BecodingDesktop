using BecodingDesktop.Controllers.Admin.Catalogs;
using BecodingDesktop.Interfaces.Admin.Catalogs;
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
    public partial class FrmModels : FrmBasicCatalogContainer
    {
        private readonly IModel _model;
        private int idSelected = 0;
        public FrmModels(IModel model)
        {
            _model = model;
        }
        private void SetDatagridViewElements(List<Model> models)
        {

            this.dgvCatalog.DataSource = models;
            if (this.dgvCatalog.Rows.Count > 0)
            {
                var headers = _model.GetHeaders();
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


            }

            foreach (var item in this.dgvCatalog.Rows)
            {
                ((DataGridViewRow)item).Cells["Edit"].Value = Properties.Resources.I_edit_gray;


            }
            this.dgvCatalog.CellClick += CellClicked;
            this.btnGuardar.Click += AddReplaceEvent;
            this.txtSearch.TextChanged += SearchTextChanged;

        }

        private void SearchTextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddReplaceEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        public FrmModels()
        {
            InitializeComponent();
        }
    }
}
