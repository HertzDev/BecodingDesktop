using BecodingDesktop.Helpers;
using BecodingDesktop.Views.Base;

namespace BecodingDesktop.Views.General.Products
{
    public partial class FrmProduct : FrmBaseBussinessContainer
    {
        public FrmProduct()
        {
            InitializeComponent();
            lblTitle.ForeColor = ColorManager.Primary;
            lblTitle.Text = "PRODUCTOS";
        }
    }
}
