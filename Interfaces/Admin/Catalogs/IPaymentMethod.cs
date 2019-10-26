

using BecodingDesktop.Models;
using BecodingDesktop.Models.Catalogs;
using System;
using System.Collections.Generic;
using System.Data;

namespace BecodingDesktop.Interfaces.Admin.Catalogs
{
    public interface IPaymentMethod
    {
        List<PaymentMethodModel> GetPaymentMethods();
        MessageModel SetItem(PaymentMethodModel method);
        MessageModel UpdateItem(PaymentMethodModel method);

        MessageModel UpdateStateItem(PaymentMethodModel method);

        Func<DataRow, PaymentMethodModel> GetMapper();
        List<string> GetHeaders();


    }
}
