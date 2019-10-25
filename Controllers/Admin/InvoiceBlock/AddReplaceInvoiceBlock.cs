using BecodingDesktop.Interfaces.General;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecodingDesktop.Controllers.General.BloqueFactura
{
    public class AddReplaceInvoiceBlock : IInvoiceBlock
    {
        public List<Control> CreateView()
        {
            List<Control> controls = new List<Control>();
            var font = new Font(SystemFonts.DefaultFont, FontStyle.Bold);
            var margin = new Padding(10, 20, 10, 0);
            var size = new Size(400, 30);
            MaterialSingleLineTextField txtResolucion = new MaterialSingleLineTextField()
            {
                Name = "txtResolucion",
                Hint = "Ingrese la Resolucion",
                Margin = margin,
                Size = size,
                Dock = DockStyle.Fill
            };
            controls.Add(txtResolucion);

            MaterialSingleLineTextField txtCorreIni = new MaterialSingleLineTextField()
            {
                Name = "txtCorrelativoInicial",
                Hint = "Ingrese el correlativo Inicial",
                Size = size,
                Margin = margin,
                Dock = DockStyle.Fill
            };

            controls.Add(txtCorreIni);

            MaterialSingleLineTextField txtCorreFin = new MaterialSingleLineTextField()
            {
                Name = "txtCorrelativoFinal",
                Hint = "Ingrese el correlativo Final",
                Size = size,
                Margin = margin,
                Dock = DockStyle.Fill
            };
            controls.Add(txtCorreFin);

            MaterialSingleLineTextField txtCorrelativoAct = new MaterialSingleLineTextField()
            {
                Name = "txtCorrelativoActual",
                Hint = "Ingrese el correlativo Actual",
                Size = size,
                Margin = margin,

            };
            controls.Add(txtCorrelativoAct);
            return controls;
        }
    }
}
