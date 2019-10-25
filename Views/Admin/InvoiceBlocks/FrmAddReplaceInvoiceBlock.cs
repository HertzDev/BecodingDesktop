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

namespace BecodingDesktop.Views.General.BloqueFactura
{
    public partial class FrmAddReplaceBloqueFactura : FrmBaseActionContainer
    {
        private readonly IInvoiceBlock _bloquefactura;
        public FrmAddReplaceBloqueFactura(IInvoiceBlock bloqueFactura)
        {
            _bloquefactura = bloqueFactura;
            this.Size = new Size(500, 300);
            var controls = _bloquefactura.CreateView();
            this.flyContainer.Controls.AddRange(controls.ToArray());
            this.lblTitle.AutoSize = true;
            this.lblTitle.Size = new Size(500, 80);

        }

        public FrmAddReplaceBloqueFactura()
        {
            InitializeComponent();
        }
    }
}
