using BecodingDesktop.Interfaces.Admin.Catalogs;
using BecodingDesktop.Models;
using BecodingDesktop.Models.Catalogs;
using System;
using System.Collections.Generic;
using System.Data;

namespace BecodingDesktop.Controllers.Admin.Catalogs
{
    public class Role : IRole
    {
        CatalogBase _catalog = new CatalogBase();
        public Func<DataRow, RoleModel> GetMapper()
        {
            Func<DataRow, RoleModel> mapper = row =>
            {
                return new RoleModel()
                {
                    Id = Convert.ToInt32(row["Id"].ToString()),
                    Name = row["Nombre_Rol"].ToString(),
                    State = Convert.ToInt32(row["Eliminado"].ToString()),
                    CreationDate = row["Creado"].ToString(),
                    UpdateDate = row["Actualizado"].ToString()
                };
            };
            return mapper;
        }

        public List<RoleModel> GetRoles()
        {
            return _catalog.GetResults<RoleModel>(GetMapper(), null, "pa_roles");
        }

        public MessageModel SetItem(RoleModel role)
        {
            string[,] parameters = { { "@nombre_rol", "2", role.Name}};
            return _catalog.SetItem(parameters, "pa_crear_rol");
        }

        public MessageModel UpdateItem(RoleModel role)
        {
            string[,] parameters = {{ "@Id", "1", role.Id.ToString() },{ "@nombre_rol", "2", role.Name }};
            return _catalog.SetItem(parameters, "pa_actualizar_rol");
        }

        public MessageModel UpdateStateItem(RoleModel role)
        {
            string[,] parameters = { { "@Id", "1", role.Id.ToString() }, { "@eliminado", "1", role.State.ToString()} };
            return _catalog.SetItem(parameters, "pa_eliminar_rol");
        }
    }
}
