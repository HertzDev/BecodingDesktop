using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Views.Base;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BecodingDesktop.Views.General.Sales
{
    public partial class FrmAddReplaceSale : FrmBaseActionContainer
    {
        private readonly ISale _sale;
        public FrmAddReplaceSale(ISale sale)
        {
            _sale = sale;
            var controls = _sale.CreateView();
            controls.ForEach(c => 
            {
                if(c.Name.Equals("tblAddReplace"))
                {
                     ((MaterialRadioButton)c.Controls.Find("rdoCredit", true)?[0]).CheckedChanged += RdtIsChecked;
                }
               
            
            });
            this.flyContainer.Controls.AddRange(controls.ToArray());
            ((MaterialSingleLineTextField)this.flyContainer.Controls.Find("txtNit", true)[0]).Visible = false;

        }
        public FrmAddReplaceSale()
        {
            InitializeComponent();
        }

        protected void RdtIsChecked(object sender, EventArgs e)
        {
            var rdo = (MaterialRadioButton)sender;
            ((MaterialSingleLineTextField)this.flyContainer.Controls.Find("txtNit", true)[0]).Visible = rdo.Checked;
            
        }
    }
}
