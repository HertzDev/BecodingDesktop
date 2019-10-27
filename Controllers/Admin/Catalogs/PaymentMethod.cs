using BecodingDesktop.Interfaces.Admin.Catalogs;
using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Models;
using BecodingDesktop.Models.Catalogs;
using System;
using System.Collections.Generic;
using System.Data;

namespace BecodingDesktop.Controllers.Admin.Catalogs
{
    class PaymentMethod : IPaymentMethod
    {
        private readonly ICatalogBase _catalog;

        public PaymentMethod(ICatalogBase catalog)
        {
            _catalog = catalog;
        }

        public List<string> GetHeaders()
        {
            return new List<string>() { "Forma de pago", "Fecha de Creación", "Estado", "", "Código" };

        }

        public Func<DataRow, PaymentMethodModel> GetMapper()
        {
            Func<DataRow, PaymentMethodModel> mapper = row =>
            {
                var method= new PaymentMethodModel()
                {
                    Id = Convert.ToInt32(row["Id"].ToString()),
                    Name = row["Nombre_Pago"].ToString(),
                    State = Convert.ToInt32(row["Eliminado"].ToString()),
                    CreationDate = row["Creado"].ToString(),
                    UpdateDate = row["Actualizado"].ToString()
                };
                method.StateText = (method.State == 0) ? "Activo" : "Inactivo";
                return method;
            };
            return mapper;
        }

        public List<PaymentMethodModel> GetPaymentMethods()
        {
            return _catalog.GetResults<PaymentMethodModel>(GetMapper(), null, "pa_forma_pago");
        }

        public MessageModel SetItem(PaymentMethodModel method)
        {
            string[,] parameters = { { "@nombre", "2", method.Name } };
            return _catalog.SetItem(parameters, "pa_crear_forma_pago");
        }

        public MessageModel UpdateItem(PaymentMethodModel method)
        {
            string[,] parameters = { { "@Id", "1", method.Id.ToString() }, { "@nombre", "2", method.Name } };
            return _catalog.SetItem(parameters, "pa_actualizar_forma_pago");
        }

        public MessageModel UpdateStateItem(PaymentMethodModel method)
        {
            string[,] parameters = { { "@Id", "1", method.Id.ToString() }, { "@eliminado", "1", method.State.ToString() } };
            return _catalog.SetItem(parameters, "pa_eliminar_forma_pago");
        }
    }
}
