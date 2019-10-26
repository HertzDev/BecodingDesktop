using BecodingDesktop.Interfaces.Admin.Catalogs;
using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Models;
using BecodingDesktop.Models.Catalogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecodingDesktop.Controllers.Admin.Catalogs
{
    public class Category : ICategory
    {
        private readonly ICatalogBase _catalog;

        public Category(ICatalogBase catalog)
        {
            _catalog = catalog;
        }
        public List<CategoryModel> GetCategories()
        {
            return _catalog.GetResults<CategoryModel>(GetMapper(), null, "pa_categorias");

        }

        public List<string> GetHeaders()
        {
            return new List<string>() { "Nombre de Categoría", "Fecha de Creación", "Estado", "", "Código" };
        }

        public Func<DataRow, CategoryModel> GetMapper()
        {
            Func<DataRow, CategoryModel> mapper = row =>
            {
                var data = new CategoryModel()
                {

                    Id = Convert.ToInt32(row["Id"].ToString()),
                    Name = row["Nombre_Categoria"].ToString(),
                    State = Convert.ToInt32(row["Eliminado"].ToString()),
                    CreationDate = DateTime.Parse(row["Creado"].ToString()).ToString("dd-MM-yyyy"),
                    UpdateDate = DateTime.Parse(row["Actualizado"].ToString()).ToString("dd-MM-yyyy")
                };

                data.StateText = data.State == 0 ? "Activo" : "Inactivo";
                return data;
            };
            return mapper;
        }

        public MessageModel SetItem(CategoryModel category)
        {
            string[,] parameters = { { "@nombre", "2", category.Name } };
            return _catalog.SetItem(parameters, "pa_crear_categorias");
        }

        public MessageModel UpdateItem(CategoryModel category)
        {
            string[,] parameters = { { "@nombre", "2", category.Name },{"@id","1",category.Id.ToString()} };
            return _catalog.SetItem(parameters, "pa_actualizar_categorias");
        }

        public MessageModel UpdateStateItem(CategoryModel category)
        {
            string[,] parameters = { { "@id", "1", category.Id.ToString() },{"@eliminado","1",category.State.ToString() } };
            return _catalog.SetItem(parameters, "pa_eliminar_categorias");
        }
    }
}
