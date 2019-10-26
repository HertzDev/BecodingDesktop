using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Views.Base;
using System.Drawing;

namespace BecodingDesktop.Views.General.Products
{
    public partial class FrmDetailProduct : FrmBaseActionContainer
    {
        private readonly IProduct _product;
        public FrmDetailProduct(IProduct product)
        {
            _product = product;

            this.Size = new Size(500, 500);
            var controls = _product.CreateView(null);
            this.flyContainer.Controls.AddRange(controls.ToArray());

        }


        public FrmDetailProduct()
        {
            InitializeComponent();
        }
    }
}
