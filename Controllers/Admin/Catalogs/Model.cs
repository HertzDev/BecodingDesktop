using BecodingDesktop.Interfaces.Admin.Catalogs;
using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace BecodingDesktop.Controllers.Admin.Catalogs
{
    public class Model : IModel
    {
        private readonly ICatalogBase _catalog;
        public Model(ICatalogBase catalog)
        {
            _catalog = catalog;
        }

        public List<string> GetHeaders()
        {
            return new List<string>() { "Nombre de Modelo", "Fecha de Creación", "Estado", "", "Código" };
        }

        public Func<DataRow, Models.Catalogs.Model> GetMapper()
        {

            Func<DataRow, Models.Catalogs.Model> mapper = row =>
            {
                var model = new Models.Catalogs.Model()
                {
                    Id = Convert.ToInt32(row["Id"].ToString()),
                    Name = row["Nombre_Modelo"].ToString(),
                    State = Convert.ToInt32(row["Eliminado"].ToString()),
                    CreationDate = DateTime.Parse(row["Creado"].ToString()).ToString("dd-MM-yyyy"),
                    UpdateDate = DateTime.Parse(row["Actualizado"].ToString()).ToString("dd-MM-yyyy")
                };
                model.StateText = model.State == 0 ? "Activo" : "Inactivo";
                return model;
            };
            return mapper;
        }

        public List<Models.Catalogs.Model> GetModels()
        {
            return _catalog.GetResults<Models.Catalogs.Model>(GetMapper(), null, "pa_modelos");
        }

        public MessageModel SetItem(Models.Catalogs.Model model)
        {

            string[,] parameters = { { "@nombre", "2", model.Name } };
            return _catalog.SetItem(parameters, "pa_crear_modelos");
        }

        public MessageModel UpdateItem(Models.Catalogs.Model model)
        {
            string[,] parameters = { { "@Id", "1", model.Id.ToString() }, { "@nombre", "2", model.Name } };
            return _catalog.SetItem(parameters, "pa_actualizar_modelos");
        }

        public MessageModel UpdateStateItem(Models.Catalogs.Model model)
        {
            string[,] parameters = { { "@Id", "1", model.Id.ToString() }, { "@eliminado", "1", model.State.ToString() } };
            return _catalog.SetItem(parameters, "pa_eliminar_modelos");
        }
    }
}
