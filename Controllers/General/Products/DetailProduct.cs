using BecodingDesktop.Interfaces.General;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BecodingDesktop.Controllers.General.Products
{
    public class DetailProduct : IProduct
    {
        public List<Control> CreateView()
        {
            List<Control> controls = new List<Control>();
            var font = new Font(SystemFonts.DefaultFont, FontStyle.Bold);
            var margin = new Padding(10, 20, 10, 0);
            TableLayoutPanel tblBody = new TableLayoutPanel()
            {
                Name = "tblBody",
                ColumnCount = 2,
                AutoSize = false,
                Size = new Size(430, 400),
                RowStyles =
                {
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,90f)

                },
                ColumnStyles =
                {
                    new ColumnStyle(SizeType.Absolute,100f),
                    new ColumnStyle(SizeType.Percent,35f)
                },
            };

            Label lblTitleProductCode = new Label()
            {
                Name = "lblTitleProductCode",
                Text = "Código:",
                Font = font
            };
            tblBody.Controls.Add(lblTitleProductCode, 0, 0);


            Label lblProductCode = new Label()
            {
                Name = "lblProductCode",
                Text = "HE343SAD",
                Font = font,
                Dock = DockStyle.Left
            };
            tblBody.Controls.Add(lblProductCode, 1, 0);

            Label lblTitleProductName = new Label()
            {
                Name = "lblTitleProductName",
                Text = "Nombre:",
                Font = font
            };
            tblBody.Controls.Add(lblTitleProductName, 0, 1);


            Label lblProductName = new Label()
            {
                Name = "lblProductName",
                Text = "Gorila Glass X",
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lblProductName, 1, 1);

            Label lblTitleCategory = new Label()
            {
                Name = "lblTitleCategory",
                Text = "Categoría:",
                Font = font
            };
            tblBody.Controls.Add(lblTitleCategory, 0, 2);


            Label lblCategory = new Label()
            {
                Name = "lblCategory",
                Text = "Vidrío Templado",
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lblCategory, 1, 2);

            Label lblTitleBrand = new Label()
            {
                Name = "lblTitleBrand",
                Text = "Marca:",
                Font = font
            };
            tblBody.Controls.Add(lblTitleBrand, 0, 3);


            Label lblBrand = new Label()
            {
                Name = "lblBrand",
                Text = "Gorilla X",
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lblBrand, 1, 3);

            Label lblTitleModel = new Label()
            {
                Name = "lblTitleModel",
                Text = "Modelo:",
                Font = font
            };
            tblBody.Controls.Add(lblTitleModel, 0, 4);


            Label lblModel = new Label()
            {
                Name = "lblModel",
                Text = "Fire Forte",
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lblModel, 1, 4);


            Label lblTitlePrice = new Label()
            {
                Name = "lblTitlePrice",
                Text = "Precio:",
                Font = font
            };
            tblBody.Controls.Add(lblTitlePrice, 0, 5);


            Label lblPrice = new Label()
            {
                Name = "lblPrice",
                Text = "$11.00",
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lblPrice, 1, 5);


            
            Label lblTitleQuantity = new Label()
            {
                Name = "lblTitleQuantity",
                Text = "Existencias:",
                Font = font
            };
            tblBody.Controls.Add(lblTitleQuantity, 0, 6);


            Label lblQuantity = new Label()
            {
                Name = "lblQuantity",
                Text = "100",
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lblQuantity, 1, 6);


            Label lblTitleCreationDate = new Label()
            {
                Name = "lblTitleCreationDate",
                Text = "Fecha de \n\rCreación:",
                Font = font, 
                AutoSize = true,Height=60
            };
            tblBody.Controls.Add(lblTitleCreationDate, 0, 7);


            Label lblCreationDate = new Label()
            {
                Name = "lblCreationDate",
                Text = "2019-10-05",
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lblCreationDate, 1, 7);
            controls.Add(tblBody);
            Label lblTitleDescription = new Label()
            {
                Name = "lblTitleDescription",
                Text = "Descripción:",
                Font = font,

            };
            tblBody.Controls.Add(lblTitleDescription, 0, 8);


            Label lblDescription = new Label()
            {
                Name = "lblDescription",
                Text = "Vidrio templado, para dispositivos\n\r marca Samsung",
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lblDescription, 1, 8);

            return controls;
        }
    }
}
