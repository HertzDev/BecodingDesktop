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
    public interface IBrand
    {
        List<BrandModel> GetBrands();
        MessageModel SetItem(BrandModel brand);
        MessageModel UpdateItem(BrandModel brand);

        MessageModel UpdateStateItem(BrandModel brand);

        Func<DataRow, BrandModel> GetMapper();

        List<string> GetHeaders();
    }
}
