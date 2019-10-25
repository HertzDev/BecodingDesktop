using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecodingDesktop.Interfaces.Admin
{
    public interface IUser
    {
        List<Control> CreateView();
    }
}
