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

namespace BecodingDesktop.Controllers.General.Sales
{
    class AddReplaceSale : ISale
    {
        public List<Control> CreateView()
        {
            List<Control> controls = new List<Control>();
            var font = new Font(SystemFonts.DefaultFont, FontStyle.Bold);
            var margin = new Padding(10,20,10,0);
            TableLayoutPanel content = new TableLayoutPanel()
            {
                Name = "tblAddReplace",
                ColumnCount = 3,
                AutoSize=false,
                Size=new Size(430,60),
                RowStyles =
                {
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,50f),
                    new RowStyle(SizeType.Absolute,50f),
                },
                ColumnStyles=
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
            content.Controls.Add(noBill,0,0);
            Label generationDate = new Label()
            {
                Name = "lblGenerationDate",
                Text = DateTime.Now.Date.ToString("dd - MM - yyyy"),
                ForeColor = ColorManager.Primary,
                Font = font,
                Dock=DockStyle.Right
            };
            content.Controls.Add(generationDate, 1, 0);

            content.SetColumnSpan(generationDate, 2);
            MaterialRadioButton rdoBill = new MaterialRadioButton()
            {
                Name = "rdoBill",
                Text = "Factura",

            };
            MaterialRadioButton rdoCredit = new MaterialRadioButton()
            {
                Name = "rdoCredit",
                Text = "Credito Fiscal",
                AutoSize=true
            };
            content.Controls.Add(rdoBill,0,1);
            content.Controls.Add(rdoCredit, 1, 1);
            content.SetColumnSpan(rdoCredit, 2);

            controls.Add(content);
            MaterialSingleLineTextField txtNit = new MaterialSingleLineTextField()
            {
                Name = "txtNit",
                Hint = "Ingresa el número de NIT",
                Dock = DockStyle.Fill,
                Margin = margin

            };
            controls.Add(txtNit);
            
            MaterialSingleLineTextField txtClientName = new MaterialSingleLineTextField()
            {
                Name = "txtClientName",
                Hint = "Ingresa el nombre del Cliente",
                Dock = DockStyle.Fill,
                Margin = margin
            };

            controls.Add(txtClientName);
            TableLayoutPanel contentMiddle = new TableLayoutPanel()
            {
                Name = "tblAddReplaceMiddle",
                ColumnCount = 3,
                AutoSize = false,
                Size = new Size(430, 30),
                RowStyles =
                {
                    new RowStyle(SizeType.Absolute,30f)
                },
                ColumnStyles =
                {
                    new ColumnStyle(SizeType.Percent,50f),
                    new ColumnStyle(SizeType.Percent,25f),
                    new ColumnStyle(SizeType.Percent,25f)
                },
                Margin=margin
            };

            MaterialSingleLineTextField txtSearchProduct = new MaterialSingleLineTextField()
            {
                Name = "txtSearchProduct",
                Hint = "Ingresa el nombre del Producto",
                Dock = DockStyle.Fill,
            };

            contentMiddle.Controls.Add(txtSearchProduct, 0, 0);

            MaterialSingleLineTextField txtPriceProduct = new MaterialSingleLineTextField()
            {
                Name = "txtPriceProduct",
                Hint = "$0.00",
                Dock = DockStyle.Fill,
            };
            contentMiddle.Controls.Add(txtPriceProduct, 1, 0);

            MaterialSingleLineTextField txtUnitProduct = new MaterialSingleLineTextField()
            {
                Name = "txtUnitProduct",
                Hint = "0",
                Dock = DockStyle.Fill,
            };
            contentMiddle.Controls.Add(txtUnitProduct, 2, 0);
            controls.Add(contentMiddle);
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
