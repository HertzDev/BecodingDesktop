using BecodingDesktop.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BecodingDesktop.Interfaces.Admin
{
    public interface IMenuAdmin
    {
        List<MenuOptionModel> MenuOptionInit();
        void MenuClickEvent(object sender, EventArgs e);
        List<ToolStripItem> UnSelectedAll();
        ToolStripItem UnSelectedSubItems(MenuOptionModel option);
    }
}
