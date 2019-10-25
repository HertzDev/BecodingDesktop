using BecodingDesktop.Helpers;
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
    public class DetailInvoiceBlock : IInvoiceBlock
    {
        public List<Control> CreateView()
        {
            List<Control> controls = new List<Control>();
            var font = new Font(SystemFonts.DefaultFont, FontStyle.Bold);
            var margin = new Padding(10, 20, 10, 0);
            var size = new Size(400, 30);
            TableLayoutPanel tblBody = new TableLayoutPanel()
            {
                Name = "tblBody",
                ColumnCount = 2,
                AutoSize = false,
                Size = new Size(430, 150),
                RowStyles =
                {
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,30f),
                },
                ColumnStyles =
                {
                    new ColumnStyle(SizeType.Absolute,120f),
                    new ColumnStyle(SizeType.Percent,35f)
                },
            };

            Label lblresolucion = new Label()
            {
                Name = "lblresolucion",
                Text = "Resolucion:",
                Font = font
            };
            tblBody.Controls.Add(lblresolucion, 0, 0);


            Label lbldetalleresol = new Label()
            {
                Name = "lbldetalleresol",
                Text = "Fact-0000000",
                Font = font,
                Dock = DockStyle.Left
            };
            tblBody.Controls.Add(lbldetalleresol, 1, 0);

            Label lblcorreini = new Label()
            {
                Name = "lblcorreini",
                Text = "Correlativo Inicial:",
                Size = size,
                Font = font
            };
            tblBody.Controls.Add(lblcorreini, 0, 1);


            Label lbldetallecorreini = new Label()
            {
                Name = "lbldetallecorreini",
                Text = "0000001",
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lbldetallecorreini, 1, 1);

            Label lblcorrefin = new Label()
            {
                Name = "lblcorrefin",
                Text = "Correlativo Final:",
                Size = size,
                Font = font
            };
            tblBody.Controls.Add(lblcorrefin, 0, 2);


            Label lbldetallecorrefin = new Label()
            {
                Name = "lbldetallecorrefin",
                Text = "9999999",
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lbldetallecorrefin, 1, 2);

            Label lblcorreact = new Label()
            {
                Name = "lblcorreact",
                Text = "Correlativo Actual:",
                Size = size,
                Font = font
            };
            tblBody.Controls.Add(lblcorreact, 0, 3);

            Label lbldetallecorreact = new Label()
            {
                Name = "lbldetallecorrefin",
                Text = "0000100",
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lbldetallecorreact, 1, 3);

            controls.Add(tblBody);
           
            return controls;
        }
    }
}
