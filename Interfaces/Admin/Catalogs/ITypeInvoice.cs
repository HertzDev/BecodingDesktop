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
    public interface ITypeInvoice
    {
        List<string> GetHeaders();

        List<TypeInvoiceModel> GetTypesInvoices();
        MessageModel SetItem(TypeInvoiceModel invoice);
        MessageModel UpdateItem(TypeInvoiceModel invoice);

        MessageModel UpdateStateItem(TypeInvoiceModel invoice);

        Func<DataRow, TypeInvoiceModel> GetMapper();
    }
}
