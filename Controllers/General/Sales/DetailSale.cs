using BecodingDesktop.Helpers;
using BecodingDesktop.Interfaces.General;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecodingDesktop.Controllers.General.Sales
{
    class DetailSale : ISale
    {
        public List<Control> CreateView()
        {
            List<Control> controls = new List<Control>();
            var font = new Font(SystemFonts.DefaultFont, FontStyle.Bold);
            var margin = new Padding(10, 20, 10, 0);
            TableLayoutPanel content = new TableLayoutPanel()
            {
                Name = "tblHead",
                ColumnCount = 3,
                AutoSize = false,
                Size = new Size(430, 30),
                RowStyles =
                {
                    new RowStyle(SizeType.Absolute,30f),
                },
                ColumnStyles =
                {
                    new ColumnStyle(SizeType.Percent,30f),
                    new ColumnStyle(SizeType.Percent,35f),
                    new ColumnStyle(SizeType.Percent,35f)
                },
            };
            Label noBill = new Label()
            {
                Name = "lblNoBill",
                Text = "No.000000001",
                ForeColor = ColorManager.Primary,
                Font = font,

            };
            content.Controls.Add(noBill, 0, 0);
            Label generationDate = new Label()
            {
                Name = "lblGenerationDate",
                Text = DateTime.Now.Date.ToString("dd - MM - yyyy"),
                ForeColor = ColorManager.Primary,
                Font = font,
                Dock = DockStyle.Right
            };
            content.Controls.Add(generationDate, 1, 0);
            content.SetColumnSpan(generationDate, 2);
            controls.Add(content);
            TableLayoutPanel tblBody = new TableLayoutPanel()
            {
                Name = "tblBody",
                ColumnCount = 2,
                AutoSize = false,
                Size = new Size(430, 100),
                RowStyles =
                {
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

            Label lblTitleTypeBill = new Label()
            {
                Name = "lblTitleTypeBill",
                Text = "Tipo de factura:",
                Font = font
            };
            tblBody.Controls.Add(lblTitleTypeBill, 0, 0);


            Label lblTypeBill = new Label()
            {
                Name = "lblTypeBill",
                Text = "Factura",
                Font = font,
                Dock=DockStyle.Left
            };
            tblBody.Controls.Add(lblTypeBill, 1, 0);

            Label lblTitleNIT = new Label()
            {
                Name = "lblTitleNIT",
                Text = "NIT:",
                Font = font
            };
            tblBody.Controls.Add(lblTitleNIT, 0, 1);


            Label lblNIT = new Label()
            {
                Name = "lblNIT",
                Text = "0614-170595-133-6",
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lblNIT, 1, 1);
           
            Label lblTitleClientName = new Label()
            {
                Name = "lblTitleClientName",
                Text = "Cliente:",
                Font = font
            };
            tblBody.Controls.Add(lblTitleClientName, 0, 2);


            Label lblClientName = new Label()
            {
                Name = "lblClientName",
                Text = "Humberto Antonio Galdamez Chavez",
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lblClientName, 1, 2);

            controls.Add(tblBody);
            DataGridView dgvProductSale = new DataGridView()
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                Size = new Size(400, 300)
            };
            controls.Add(dgvProductSale);



            Label lblTotal = new Label()
            {
                Name = "lblTotal",
                Text = "Total: $0.00",
                AutoSize = true,
                ForeColor = ColorManager.Primary,
                Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                Margin = new Padding(250, 10, 0, 0)
            };
            controls.Add(lblTotal);
            return controls;
        }
    }
}
