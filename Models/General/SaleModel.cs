using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecodingDesktop.Models.General
{
    public class SaleModel
    {

        public int Id { get; set; }
        public string ClientName { get; set; }
        public string NFactura { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public int Canceled { get; set; }
        public string DateCanceled { get; set; }
        public int PaymentMethod { get; set; }
        public int UserCanceled { get; set; }
        public int UserInvoice { get; set; }
        public string Nit { get; set; }
        public string Building { get; set; }
        public int InvoiceType { get; set; }
        public string CreationDate { get; set; }
        public string UpdateDate { get; set; }

    }
}
