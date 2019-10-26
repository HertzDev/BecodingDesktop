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
    public interface ILogicSale
    {

        List<Control> CreateView();
        List<SaleModel> GetProducts();
        MessageModel SetItem(SaleModel data);

        MessageModel UpdateStateItem(SaleModel data);

        Func<DataRow, SaleModel> GetMapper();


    }
}
