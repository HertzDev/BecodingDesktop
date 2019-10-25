using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BecodingDesktop.Views.General.Sales
{
    public partial class FrmDetailSale : FrmBaseActionContainer
    {
        private readonly ISale _sale;
        public FrmDetailSale(ISale sale)
        {
            _sale = sale;
            this.flyContainer.Controls.AddRange(_sale.CreateView().ToArray());
        }
        public FrmDetailSale()
        {
            InitializeComponent();
        }
    }
}
