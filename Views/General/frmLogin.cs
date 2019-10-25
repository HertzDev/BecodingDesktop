using BecodingDesktop.Controllers.Admin;
using BecodingDesktop.Helpers;
using BecodingDesktop.Views.Admin;
using BecodingDesktop.Views.Base;
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

namespace BecodingDesktop.Views.General
{
    public partial class FrmLogin : MaterialForm
    {
        public FrmLogin()
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
        }

        protected override void OnLoad(EventArgs e)
        {
            this.lblTitleSignIn.ForeColor = ColorManager.Primary;
            base.OnLoad(e);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuAdminContainer a = new FrmMenuAdminContainer(new MenuAdmin());
            a.Show();
        }
    }
}
