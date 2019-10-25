using BecodingDesktop.Helpers;
using BecodingDesktop.Interfaces;
using BecodingDesktop.Interfaces.Employee;
using BecodingDesktop.Models;
using BecodingDesktop.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BecodingDesktop.Views.Employee
{
    public partial class FrmMenuEmployeeContainer : FrmBaseMenuContainer,IMenuOption
    {
        private readonly IMenuEmployee _menuOption;
        List<MenuOptionModel> _options = new List<MenuOptionModel>();
        public FrmMenuEmployeeContainer(IMenuEmployee menuEmployee)
        {
            _menuOption = menuEmployee;
            _options = _menuOption?.MenuOptionInit();
            var menu = (_menuOption?.UnSelectedAll());
            menu.ForEach(m => {
                m.BackColorChanged += SetUnCheckedOption;
            });
            mainMenu.Items.AddRange(menu.ToArray());
            mainMenu.Items[1].Margin = new Padding(0, 150, 0, 0);

        }

        public FrmMenuEmployeeContainer()
        {
            InitializeComponent();
        }

        public void SetUnCheckedOption(object sender, EventArgs e)
        {
            var item = (ToolStripItem)sender;
            var tag = int.Parse(item.Tag.ToString());
            var form = _options.First(op => op.Id == tag).FormAssigned;
            var formActive = this.ActiveMdiChild;
            if (formActive != null)
            {
                formActive.Close();
            }
            form.MdiParent = this;
            form?.Show();


            UnSetBackColorChangeEvent();
            for (int i = 1; i < 6; i++)
            {
                if (i != tag)
                {
                    mainMenu.Items[i].ForeColor = ColorManager.Black;
                    mainMenu.Items[i].BackColor = ColorManager.White;
                    mainMenu.Items[i].Image = _options.First(op => op.Id == i).UnSelected;

                }

            }
            mainMenu.Items[6].Image = _options.First(op => op.Id == tag).Banner;
            SetBackColorChangeEvent();
        }

        public void UnSetBackColorChangeEvent()
        {
            for (int i = 1; i < 6; i++)
            {
                mainMenu.Items[i].BackColorChanged -= SetUnCheckedOption;
            }
        }

        public void SetBackColorChangeEvent()
        {
            for (int i = 1; i < 6; i++)
            {
                mainMenu.Items[i].BackColorChanged += SetUnCheckedOption;
            }
        }
    }
}
