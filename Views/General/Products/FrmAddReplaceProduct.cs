using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecodingDesktop.Views.General.Products
{
    public partial class FrmAddReplaceProduct : FrmBaseActionContainer
    {
        private readonly IProduct _product;
        public FrmAddReplaceProduct(IProduct product)
        {
            _product = product;
            this.Size = new Size(500, 500);
            var controls = _product.CreateView(); 
            this.flyContainer.Controls.AddRange(controls.ToArray());
            this.lblTitle.AutoSize = true;
            this.lblTitle.Size = new Size(500, 80);
        }
        public FrmAddReplaceProduct()
        {
            InitializeComponent();
        }
    }
}
