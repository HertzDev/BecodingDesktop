using BecodingDesktop.Interfaces.Admin.Users;
using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Models;
using BecodingDesktop.Models.Catalogs;
using BecodingDesktop.Models.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecodingDesktop.Controllers.General.Products
{
    class Product : IProduct
    {

        private readonly ICatalogBase _catalog;
        public Product(ICatalogBase catalog)
        {
            _catalog = catalog;
        }


        public List<Control> CreateView(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Func<DataRow, ProductModel> GetMapper()
        {
            Func<DataRow, ProductModel> mapper = row =>
            {
                var data = new ProductModel()
                {
                    Id = Convert.ToInt32(row["Id"].ToString()),
                    Name = row["nombre_producto"].ToString(),
                    Description = row["descripcion"].ToString(),
                    Price = Convert.ToDecimal(row["precio"].ToString()),
                    Existence = Convert.ToInt32(row["existencia"].ToString()),
                    ProductCode = row["cod_producto"].ToString(),
                    CreationDate = DateTime.Parse(row["Creado"].ToString()).ToString("dd-MM-yyyy"),
                    UpdateDate = DateTime.Parse(row["Actualizado"].ToString()).ToString("dd-MM-yyyy")
                };
                data.StateText = data.State == 0 ? "Activo" : "Inactivo";
                return data;
            };
            return mapper;
        }

        public List<ProductModel> GetProducts()
        {
            return _catalog.GetResults<ProductModel>(GetMapper(), null, "pa_productos");
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

        public List<string> GetHeaders()
        {
            return new List<string>() { "Código", "Producto", "Precio", "Existencias", "Fecha de Creación", "Estado", "", "" };
        }

        public List<Control> CreateView(ProductModel user)
        {
            throw new NotImplementedException();
        }
    }
}
