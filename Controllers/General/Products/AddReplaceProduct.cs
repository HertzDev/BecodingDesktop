using BecodingDesktop.Helpers;
using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Models;
using BecodingDesktop.Models.General;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecodingDesktop.Controllers.General.Products
{
    public class AddReplaceProduct : IProduct
    {
        public List<Control> CreateView()
        {
            List<Control> controls = new List<Control>();
            var font = new Font(SystemFonts.DefaultFont, FontStyle.Bold);
            var margin = new Padding(10, 20, 10, 0);
            var size = new Size(400,30);
            MaterialSingleLineTextField txtProductName = new MaterialSingleLineTextField()
            {
                Name = "txtProductName",
                Hint = "Ingresa el nombre del Producto",
                Margin = margin,
                Size=size,
                Dock=DockStyle.Fill
            };
            controls.Add(txtProductName);

            ComboBox cmbCategories = new ComboBox()
            {
                Name="cmbCategories",
                Size = size,
                Margin =margin,
                Dock = DockStyle.Fill
            };

            controls.Add(cmbCategories);


            ComboBox cmbBrands = new ComboBox()
            {
                Name = "cmbBrands",
                Size = size,
                Margin = margin,
                Dock = DockStyle.Fill
            };

            controls.Add(cmbBrands);


            ComboBox cmbModels = new ComboBox()
            {
                Name = "cmbModels",
                Size = size,
                Margin = margin,
                Dock = DockStyle.Fill
            };

            controls.Add(cmbModels);

            
            MaterialSingleLineTextField txtProductPrice = new MaterialSingleLineTextField()
            {
                Name = "txtProductPrice",
                Hint = "Ingresa el precio del Producto",
                Size = size,
                Margin=margin,
                Dock = DockStyle.Fill
            };

            controls.Add(txtProductPrice);

            MaterialSingleLineTextField txtProductQuantity = new MaterialSingleLineTextField()
            {
                Name = "txtProductQuantity",
                Hint = "Ingrese la cantidad de unidades en existencia",
                Size = size,
                Margin = margin,
                Dock = DockStyle.Fill
            };
            controls.Add(txtProductQuantity);

            MaterialSingleLineTextField txtProductDescription = new MaterialSingleLineTextField()
            {
                Name = "txtProductDescription",
                Hint = "Ingrese la descripción del Producto",
                Size = size,
                Margin = margin,

            };
            controls.Add(txtProductDescription);
            return controls;
        }

        public Func<DataRow, ProductModel> GetMapper()
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetProducts()
        {
            throw new NotImplementedException();
        }

        public MessageModel SetItem(ProductModel data)
        {
            throw new NotImplementedException();
        }

        public MessageModel UpdateItem(ProductModel data)
        {
            throw new NotImplementedException();
        }

        public MessageModel UpdateStateItem(ProductModel data)
        {
            throw new NotImplementedException();
        }
    }
}
