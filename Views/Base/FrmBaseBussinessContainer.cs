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
    public partial class FrmBaseBussinessContainer : MaterialForm
    {
        public FrmBaseBussinessContainer()
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
            this.dtBussiness.ColumnHeadersDefaultCellStyle.BackColor = ColorManager.PrimaryLight;
            this.dtBussiness.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dtBussiness.ColumnHeadersDefaultCellStyle.ForeColor = ColorManager.White;
            this.dtBussiness.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtBussiness.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtBussiness.ColumnHeadersHeight = 40;
            this.dtBussiness.RowTemplate.Height = 40;
            this.dtBussiness.AllowUserToAddRows = false;
            this.dtBussiness.AllowUserToDeleteRows = false;
            this.dtBussiness.ReadOnly = true;
            this.dtBussiness.RowsDefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular, GraphicsUnit.Point);
            this.dtBussiness.ColumnHeadersDefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold, GraphicsUnit.Point);
            this.dtBussiness.EnableHeadersVisualStyles = false;
        }
    }
}
