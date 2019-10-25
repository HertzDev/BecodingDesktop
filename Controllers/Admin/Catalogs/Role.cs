using BecodingDesktop.Helpers;
using BecodingDesktop.Interfaces.Admin.Catalogs;
using BecodingDesktop.Models;
using BecodingDesktop.Models.Roles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public MessageModel SetItem()
        {
            string[,] parameters = { { "@nombre_rol", "2", "Empleado" }};
            var a=_catalog.SetItem(parameters,"pa_crear_rol");
            return a;
        }

        public MessageModel UpdateItem()
        {
            throw new NotImplementedException();
        }
    }
}
