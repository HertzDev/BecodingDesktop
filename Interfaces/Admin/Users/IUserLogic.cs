using BecodingDesktop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecodingDesktop.Interfaces.Admin.Users
{
    public interface IUserLogic
    {
        List<UserModel> GetUsers();
        MessageModel SetItem(UserModel user);
        MessageModel UpdateItem(UserModel user);

        MessageModel UpdateStateItem(UserModel user);

        Func<DataRow, UserModel> GetMapper();

        List<string> GetHeaders();

    }
}
