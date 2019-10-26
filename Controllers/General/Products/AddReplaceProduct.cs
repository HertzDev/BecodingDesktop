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
        public List<Control> CreateView(ProductModel product)
        {
            List<Control> controls = new List<Control>();
            var font = new Font(SystemFonts.DefaultFont, FontStyle.Bold);
            var margin = new Padding(10, 20, 10, 0);
            var size = new Size(400, 30);
            MaterialSingleLineTextField txtProductName = new MaterialSingleLineTextField()
            {
                Name = "txtProductName",
                Hint = "Ingresa el nombre",
                Margin = margin,
                Size = size,
                Dock = DockStyle.Fill,
                Text = string.IsNullOrEmpty(product?.Name) ? string.Empty : product?.Name
            };
            controls.Add(txtProductName);

            MaterialSingleLineTextField txtPrice = new MaterialSingleLineTextField()
            {
                Name = "txtPrice",
                Hint = "Ingresa precio",
                Margin = margin,
                Size = size,
                Dock = DockStyle.Fill,
                Text = string.IsNullOrEmpty(product?.Price.ToString()) ? string.Empty : product?.Price.ToString()
            };
            controls.Add(txtPrice);

            MaterialSingleLineTextField txtExistence = new MaterialSingleLineTextField()
            {
                Name = "txtExistence",
                Hint = "Ingresa las existencias",
                Margin = margin,
                Size = size,
                Dock = DockStyle.Fill,
                UseSystemPasswordChar = true,
                Text = string.IsNullOrEmpty(product?.Existence.ToString()) ? string.Empty : product?.Existence.ToString()
            };
            controls.Add(txtExistence);

            MaterialSingleLineTextField txtProductCode = new MaterialSingleLineTextField()
            {
                Name = "txtProductCode",
                Hint = "Ingresa el codigo de producto",
                Margin = margin,
                Size = size,
                Dock = DockStyle.Fill,
                UseSystemPasswordChar = true,
                Text = string.IsNullOrEmpty(product?.ProductCode) ? string.Empty : product?.ProductCode
            };
            controls.Add(txtProductCode);


            MaterialSingleLineTextField txtDesc = new MaterialSingleLineTextField()
            {
                Name = "txtDesc",
                Hint = "Ingresa la descripcion de producto",
                Margin = margin,
                Size = size,
                Dock = DockStyle.Fill,
                UseSystemPasswordChar = true,
                Text = string.IsNullOrEmpty(product?.Description) ? string.Empty : product?.Description
            };
            controls.Add(txtDesc);

            return controls;
        }


        public List<string> GetHeaders()
        {
            throw new NotImplementedException();
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
