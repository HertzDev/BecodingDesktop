using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecodingDesktop.Models.Catalogs
{
    public class BrandModel:GenericCatalogModel
    {
        public string StateText { get; set; }
        

        public BrandModel()
        {
            StateText = State == 0 ? "Activo" : "Inactivo";
        }
    }
}
