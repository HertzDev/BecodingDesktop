using BecodingDesktop.Interfaces.Admin.Catalogs;
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

namespace BecodingDesktop.Controllers.Admin.Product
{
    public class Product : IProduct
    {
        private readonly ICatalogBase _catalog;
        public Product(ICatalogBase catalog)
        {
            _catalog = catalog;
        }

        public List<Control> CreateView()
        {
            throw new NotImplementedException();
        }

        public Func<DataRow, ProductModel> GetMapper()
        {
            Func<DataRow, ProductModel> mapper = row =>
            {
                return new ProductModel()
                {
                    Id = Convert.ToInt32(row["id"].ToString()),
                    Name = row["nombre_producto"].ToString(),
                    State = row["eliminado"].ToString(),
                    Description = row["descripcion"].ToString(),
                    Price = Convert.ToDecimal(row["price"].ToString()),
                    ProductCode = row["cod_producto"].ToString(),
                    Existence = row["existencia"].ToString(),
                    CreationDate = row["creado"].ToString(),
                    UpdateDate = row["actualizado"].ToString()
                };
            };
            return mapper;
        }

        public List<ProductModel> GetProducts()
        {
            return _catalog.GetResults<ProductModel>(GetMapper(), null, "pa_crear_productos");
        }

        public MessageModel SetItem(ProductModel data)
        {
            string[,] parameters = { 
                { "@nombre_producto", "2", data.Name }, 
                { "@descripcion", "2", data.Description },
                { "@precio", "6", data.Price.ToString() },
                { "@cod_producto", "2", data.ProductCode },
                { "@existencia", "1", data.Existence }
            };
            return _catalog.SetItem(parameters, "pa_crear_marcas");
        }

        public MessageModel UpdateItem(ProductModel data)
        {
            string[,] parameters = { 
                { "@id", "1", data.Id.ToString() },
                { "@nombre", "2", data.Name } ,
                { "@descripcion", "2", data.Description },
                { "@precio", "6", data.Price.ToString() },
                { "@cod_producto", "2", data.ProductCode },
                { "@existencia", "1", data.Existence }
            };
            return _catalog.SetItem(parameters, "pa_actualizar_productos");
        }

        public MessageModel UpdateStateItem(ProductModel data)
        {
            string[,] parameters = {
                { "@id", "1", data.Id.ToString() }, 
                { "@eliminado", "1", data.State.ToString() }
            };
            return _catalog.SetItem(parameters, "pa_eliminar_productos");
        }
    }
}
