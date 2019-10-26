using BecodingDesktop.Interfaces.Admin.Catalogs;
using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Models;
using BecodingDesktop.Models.Catalogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecodingDesktop.Controllers.Admin.Catalogs
{
    public class TypeInvoice : ITypeInvoice
    {
        private readonly ICatalogBase _catalog;
        public TypeInvoice(ICatalogBase catalog)
        {
            _catalog = catalog;
        }
        public List<TypeInvoiceModel> GetTypesInvoices()
        {
            return _catalog.GetResults<TypeInvoiceModel>(GetMapper(), null, "pa_tipo_factura");
        }

        public Func<DataRow, TypeInvoiceModel> GetMapper()
        {

            Func<DataRow, TypeInvoiceModel> mapper = row =>
            {
                var invoice = new TypeInvoiceModel()
                {
                    Id = Convert.ToInt32(row["Id"].ToString()),
                    Name = row["Tipo_Factura"].ToString(),
                    State = Convert.ToInt32(row["Eliminado"].ToString()),
                    CreationDate = row["Creado"].ToString(),
                    UpdateDate = row["Actualizado"].ToString()
                };
                invoice.StateText = invoice.State == 0 ? "Activo" : "Inactivo";
                return invoice;
            };
            return mapper;
        }

        public MessageModel SetItem(TypeInvoiceModel invoice)
        {
            string[,] parameters = { { "@nombre", "2", invoice.Name } };
            return _catalog.SetItem(parameters, "pa_crear_tipo_factura");
        }

        public MessageModel UpdateItem(TypeInvoiceModel invoice)
        {
            string[,] parameters = { { "@nombre", "2", invoice.Name },{"@id","1",invoice.Id.ToString() } };
            return _catalog.SetItem(parameters, "pa_actualizar_tipo_factura");
        }

        public MessageModel UpdateStateItem(TypeInvoiceModel invoice)
        {
            string[,] parameters = { { "@id", "1", invoice.Id.ToString() },{"@eliminado","1",invoice.State.ToString()} };
            return _catalog.SetItem(parameters, "pa_elminiar_tipo_factura");
        }

        public List<string> GetHeaders()
        {
            return new List<string>() { "Nombre de Marca", "Fecha de Creación", "Estado", "", "Código" };
        }
    }
}
