using BecodingDesktop.Models;
using BecodingDesktop.Models.Catalogs;
using BecodingDesktop.Models.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecodingDesktop.Interfaces.General
{
    public interface IProduct
    {
        List<Control> CreateView(ProductModel user);
        List<ProductModel> GetProducts();
        MessageModel SetItem(ProductModel data);
        MessageModel UpdateItem(ProductModel data);

        MessageModel UpdateStateItem(ProductModel data);

        Func<DataRow, ProductModel> GetMapper();
        List<string> GetHeaders();
    }
}
