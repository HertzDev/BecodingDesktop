using System;

namespace BecodingDesktop.Interfaces
{
    public interface IMenuOption
    {
        void SetUnCheckedOption(object sender, EventArgs e);
        void UnSetBackColorChangeEvent();
        void SetBackColorChangeEvent();
    }
}
