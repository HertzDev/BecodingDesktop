using BecodingDesktop.Helpers;
using MaterialSkin;
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

namespace BecodingDesktop.Views.Base
{
    public partial class FrmBasicCatalogContainer : MaterialForm
    {
        public FrmBasicCatalogContainer()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink900, Primary.Pink900,
                Primary.Pink900, Accent.LightBlue200,
                TextShade.WHITE
            );
            materialSkinManager.FORM_PADDING = 20;

            this.dgvCatalog.ColumnHeadersDefaultCellStyle.BackColor = ColorManager.PrimaryLight;
            this.dgvCatalog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvCatalog.ColumnHeadersDefaultCellStyle.ForeColor = ColorManager.White;
            this.dgvCatalog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCatalog.ColumnHeadersHeight = 40;
            this.dgvCatalog.RowTemplate.Height = 40;
            this.dgvCatalog.AllowUserToAddRows = false;
            this.dgvCatalog.AllowUserToDeleteRows = false;
            this.dgvCatalog.ReadOnly = true;
            this.dgvCatalog.RowsDefaultCellStyle.Font= new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular, GraphicsUnit.Point);
            this.dgvCatalog.ColumnHeadersDefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold, GraphicsUnit.Point);
            this.dgvCatalog.EnableHeadersVisualStyles = false;

        }
    }
}
