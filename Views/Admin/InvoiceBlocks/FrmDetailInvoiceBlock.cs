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
    public partial class FrmDetailBloqueFactura : FrmBaseActionContainer
    {
        private readonly IInvoiceBlock _detallebloque;
        public FrmDetailBloqueFactura(IInvoiceBlock detalleBloque)
        {
            _detallebloque = detalleBloque;
            this.Size = new Size(400, 300);
            var controls = _detallebloque.CreateView();
            this.flyContainer.Controls.AddRange(controls.ToArray());
            this.lblTitle.AutoSize = true;
            this.lblTitle.Size = new Size(500, 80);
        }

        public FrmDetailBloqueFactura()
        {
            InitializeComponent();
        }
    }
}
