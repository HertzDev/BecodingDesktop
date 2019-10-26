using BecodingDesktop.Helpers.Enums;
using BecodingDesktop.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BecodingDesktop.Interfaces.Admin
{
    public interface IMenuAdmin
    {
        List<MenuOptionModel> MenuOptionInit();
        Form GetFormSelected(MenuOptionName option);
        void MenuClickEvent(object sender, EventArgs e);
        void SubMenuClickEvent(object sender, EventArgs e);
        List<ToolStripItem> UnSelectedAll();
        ToolStripItem UnSelectedSubItems(MenuOptionModel option);
    }
}
