using BecodingDesktop.Interfaces.Admin.Users;
using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Models;
using BecodingDesktop.Models.Catalogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecodingDesktop.Controllers.Admin.Users
{
    public class User : IUserLogic
    {
        private readonly ICatalogBase _catalog;
        public User(ICatalogBase catalog)
        {
            _catalog = catalog;
        }
        public List<UserModel> GetUsers()
        {
            return _catalog.GetResults<UserModel>(GetMapper(), null, "pa_usuarios");
        }

        public List<string> GetHeaders()
        {
            return new List<string>() { "Código", "Nombre de Usuario", "Correo Electrónico","Rol", "Fecha de Creación", "Estado", "",""};
        }

        public Func<DataRow, UserModel> GetMapper()
        {
            Func<DataRow, UserModel> mapper = row =>
            {
                var user = new UserModel()
                {
                    Id = Convert.ToInt32(row["Id"].ToString()),
                    Name = row["Nombre_Usuario"].ToString(),
                    Email = row["Email"].ToString(),
                    Role = new RoleModel() {
                        Id = int.Parse(row["Roles_Id"].ToString()),
                        Name = row["Nombre_Rol"].ToString()
                    },
                    Password=row["Password"].ToString(),
                    State = Convert.ToInt32(row["Eliminado"].ToString()),
                    CreationDate = DateTime.Parse(row["Creado"].ToString()).ToString("dd-MM-yyyy"),
                    UpdateDate = DateTime.Parse(row["Actualizado"].ToString()).ToString("dd-MM-yyyy")
                };
                user.StateText = user.State == 0 ? "Activo" : "Inactivo";
                user.RoleText = user.Role.Name.ToString();
                return user;
            };
            return mapper;

        }

        public MessageModel SetItem(UserModel user)
        {
            string[,] parameters = { { "@nombre_usuario", "2", user.Name }, { "@email", "2", user.Email }, { "@password", "2", user.Password }, { "@role", "1", user.Role.Id.ToString()} };
            return _catalog.SetItem(parameters, "pa_crear_usuarios");
        }

        public MessageModel UpdateItem(UserModel user)
        {
            string[,] parameters = { { "@id", "1", user.Id.ToString() }, { "@nombre_usuario", "2", user.Name }, { "@email", "2", user.Email }, { "@password", "2", user.Password } };
            return _catalog.SetItem(parameters, "pa_actualizar_usuarios");

        }

        public MessageModel UpdateStateItem(UserModel user)
        {
            string[,] parameters = { { "@Id", "1", user.Id.ToString() }, { "@eliminado", "1", user.State.ToString() } };
            return _catalog.SetItem(parameters, "pa_eliminar_usuarios");
        }
    }
}
