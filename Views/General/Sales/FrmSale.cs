using BecodingDesktop.Helpers;
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

namespace BecodingDesktop.Views.General.Sales
{
    public partial class FrmSale : FrmBaseBussinessContainer
    {
        public FrmSale()
        {
            InitializeComponent();
            lblTitle.ForeColor = ColorManager.Primary;
            lblTitle.Text = "VENTAS";
            btnAdd.BackColor = ColorManager.Primary;
            btnAdd.ForeColor = ColorManager.White;
        }
    }
}
