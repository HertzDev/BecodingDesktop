using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecodingDesktop.Models
{
    public class GenericCatalogModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int State { get; set; }
        public string CreationDate { get; set; }
        public string UpdateDate { get; set; }
    }
}
