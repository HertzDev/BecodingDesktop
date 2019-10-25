using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Models;
using BecodingDesktop.Models.Catalogs;
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
        MessageModel SetItem(RoleModel role);
        MessageModel UpdateItem(RoleModel role);

        MessageModel UpdateStateItem(RoleModel role);

        Func<DataRow, RoleModel> GetMapper();
    }
}
