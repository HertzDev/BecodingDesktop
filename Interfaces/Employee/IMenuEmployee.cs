using BecodingDesktop.Helpers.Enums;
using BecodingDesktop.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BecodingDesktop.Interfaces.Employee
{
    public interface IMenuEmployee
    {
        List<MenuOptionModel> MenuOptionInit();
        void MenuClickEvent(object sender, EventArgs e);
        List<ToolStripItem> UnSelectedAll();
    }
}
