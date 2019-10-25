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
    public partial class FrmBaseActionContainer : MaterialForm
    {
        public FrmBaseActionContainer()
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
            this.btnCancel.BackColor = Color.Aquamarine;
            tblContainer.RowStyles[0].SizeType = SizeType.Absolute;
            tblContainer.RowStyles[0].Height = 50;
        }

        
    }
}
