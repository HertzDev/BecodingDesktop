using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Models;
using BecodingDesktop.Models.General;


namespace BecodingDesktop.Controllers.General.Sales
{
    public class Sale : ILogicSale
    {

        private readonly ICatalogBase _catalog;
        public Sale(ICatalogBase catalog)
        {
            _catalog = catalog;
        }

        public List<Control> CreateView()
        {
            throw new NotImplementedException();
        }

        public Func<DataRow, SaleModel> GetMapper()
        {
            Func<DataRow, SaleModel> mapper = row =>
            {
                return new SaleModel()
                {
                    Id = Convert.ToInt32(row["id"].ToString()),
                    ClientName = row["nombre_cliente"].ToString(),
                    NFactura = row["n_factura"].ToString(),
                    Total = Convert.ToDecimal(row["total"].ToString()),
                    SubTotal = Convert.ToDecimal(row["sub_total"].ToString()),
                    CreationDate = row["creado"].ToString(),
                    UpdateDate = row["actualizado"].ToString(),
                    Canceled = Convert.ToInt32(row["canceled"].ToString()),
                    DateCanceled = row["fecha_anulacion"].ToString(),
                    PaymentMethod = Convert.ToInt32(row["forma_pago"].ToString()),
                    UserCanceled = Convert.ToInt32(row["usuario_anulo"].ToString()),
                    UserInvoice = Convert.ToInt32(row["usuario_factura"].ToString()),
                    Nit = row["actualizado"].ToString(),
                    Building = row["empresa"].ToString(),
                    InvoiceType = Convert.ToInt32(row["tipo_factura"].ToString()),
                };
            };
            return mapper;
        }

        public List<SaleModel> GetProducts()
        {

            return _catalog.GetResults<SaleModel>(GetMapper(), null, "pa_factura");
        }

        public MessageModel SetItem(SaleModel data)
        {
            string[,] parameters = {
                { "@nombre_cliente", "2", data.ClientName },
                { "@n_factura", "1", data.NFactura },
                { "@total", "6", data.Total.ToString() },
                { "@sub_total", "6", data.SubTotal.ToString() },
                { "@creado", "2", data.CreationDate },
                { "@anulado", "1", data.Canceled.ToString() },
                { "@fecha_anulacion", "2", data.DateCanceled },
                { "@forma_pago_id", "1", data.PaymentMethod.ToString() },
                { "@usuario_anulo_id", "1", data.UserCanceled.ToString() },
                { "@usuario_factura_id", "1", data.UserInvoice.ToString() },
                { "@nit", "2", data.Nit },
                { "@empresa", "2", data.Building },
                { "@tipo_factura", "2", data.InvoiceType.ToString() },
                { "@actualizado", "2", data.UpdateDate }
            };
            return _catalog.SetItem(parameters, "pa_crear_factura");
        }

        

        public MessageModel UpdateStateItem(SaleModel data)
        {
            string[,] parameters = {
                { "@id", "1", data.Id.ToString() },
                { "@usuario_anulo_id", "1", data.UserCanceled.ToString() }
            };
            return _catalog.SetItem(parameters, "pa_eliminar_facturas");
        }
    }
}
