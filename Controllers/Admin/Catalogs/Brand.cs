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
    public class Brand : IBrand
    {
        private readonly ICatalogBase _catalog;
        public Brand(ICatalogBase catalog)
        {
            _catalog = catalog;
        }
        public List<BrandModel> GetBrands()
        {

            return _catalog.GetResults<BrandModel>(GetMapper(), null, "pa_marcas");
        }

        public Func<DataRow, BrandModel> GetMapper()
        {
            Func<DataRow, BrandModel> mapper = row =>
            {
                return new BrandModel()
                {
                    Id = Convert.ToInt32(row["Id"].ToString()),
                    Name = row["Nombre_Marca"].ToString(),
                    State = Convert.ToInt32(row["Eliminado"].ToString()),
                    CreationDate = row["Creado"].ToString(),
                    UpdateDate = row["Actualizado"].ToString()
                };
            };
            return mapper;

        }

        public MessageModel SetItem(BrandModel brand)
        {

            string[,] parameters = { { "@nombre", "2", brand.Name } };
            return _catalog.SetItem(parameters, "pa_crear_marcas");
        }

        public MessageModel UpdateItem(BrandModel brand)
        {
            string[,] parameters = { { "@Id", "1", brand.Id.ToString() }, { "@nombre", "2", brand.Name } };
            return _catalog.SetItem(parameters, "pa_actualizar_marcas");
        }

        public MessageModel UpdateStateItem(BrandModel brand)
        {
            string[,] parameters = { { "@Id", "1", brand.Id.ToString() }, { "@eliminado", "1", brand.State.ToString() } };
            return _catalog.SetItem(parameters, "pa_eliminar_marcas");
        }
    }
}
