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
    public interface ICategory
    {
        List<CategoryModel> GetCategories();
        MessageModel SetItem(CategoryModel category);
        MessageModel UpdateItem(CategoryModel category);

        MessageModel UpdateStateItem(CategoryModel category);

        Func<DataRow, CategoryModel> GetMapper();

    }
}
