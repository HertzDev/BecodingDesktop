using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Models;
using BecodingDesktop.Models.Roles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecodingDesktop.Interfaces.Admin.Catalogs
{
    public interface IRole
    {
        List<RoleModel> GetRoles();
        MessageModel SetItem();
        MessageModel UpdateItem();

        Func<DataRow, RoleModel> GetMapper();
    }
}
