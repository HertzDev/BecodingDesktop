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
    interface IModel
    {
        List<Model> GetModels();
        MessageModel SetItem(Model model);
        MessageModel UpdateItem(Model model);

        MessageModel UpdateStateItem(Model model);

        Func<DataRow, Model> GetMapper();

    }
}
