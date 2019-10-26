using BecodingDesktop.Models.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecodingDesktop.Models
{
    public class UserModel:GenericCatalogModel
    {
        public string Password { get; set; }
        public RoleModel Role { get; set; }
        public string RoleText { get; set; }
        public string Email { get; set; }
        public string StateText { get; set; }

    }
}
