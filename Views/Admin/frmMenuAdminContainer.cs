using BecodingDesktop.Helpers;
using BecodingDesktop.Interfaces;
using BecodingDesktop.Interfaces.Admin;
using BecodingDesktop.Interfaces.Admin.Catalogs;
using BecodingDesktop.Models;
using BecodingDesktop.Views.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BecodingDesktop.Views.Admin
{
    public partial class FrmMenuAdminContainer : FrmBaseMenuContainer,IMenuOption
    {

        private readonly IMenuAdmin _menuOption;
        private readonly IBrand _brand;
        private readonly List<MenuOptionModel> _options = new List<MenuOptionModel>();

        public FrmMenuAdminContainer(IMenuAdmin menuOption)
        {
            _menuOption = menuOption;
            _options=_menuOption?.MenuOptionInit();
            var menu = (_menuOption?.UnSelectedAll());
            menu.ForEach(m=> {
                if(!m.Text.Equals("CATALOGOS") && !m.Text.Equals("REPORTES"))
                {
                    m.BackColorChanged += SetUnCheckedOption;
                }
                else
                {
                    foreach (ToolStripItem item in ((ToolStripDropDownButton)m).DropDownItems)
                    {
                        item.BackColorChanged += SetUnCheckedSubOption;
                    }
                    
                }
            });
            mainMenu.Items.AddRange(menu.ToArray());
            mainMenu.Items[1].Margin = new Padding(0,150,0,0);

        }
        public FrmMenuAdminContainer()
        {
            InitializeComponent();
        }

        public void SetUnCheckedOption(object sender,EventArgs e)
        {
            var item = (ToolStripItem)sender;
            var tag = int.Parse(item.Tag.ToString());
            var formtype = _options.First(op => op.Id==tag).FormAssigned;
            var form = FormManager.GetFormSelected(formtype);
            var formActive = this.ActiveMdiChild;
            if (formActive != null)
            {
                formActive.Close();
            }
            if(form!=null)
            {
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form?.Show();

            }


            UnSetBackColorChangeEvent();
            for (int i=1;i<5;i++)
            {
                if(i!=tag)
                {
                        mainMenu.Items[i].ForeColor = ColorManager.Black;
                        mainMenu.Items[i].BackColor = ColorManager.White;
                        mainMenu.Items[i].Image = _options.First(op=>op.Id==i).UnSelected;
                        
                }
            }
            mainMenu.Items[5].Image = _options.First(op => op.Id == tag).Banner;
            SetBackColorChangeEvent();
        }

        public void UnSetBackColorChangeEvent()
        {
            for(int i=1;i<6;i++)
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

        public void SetUnCheckedSubOption(object sender, EventArgs e)
        {
            var item = (ToolStripItem)sender;
            var tag = int.Parse(item.Tag.ToString());
            Form form = null;
            _options[3].SubItems.ForEach(r =>
            {
                if (tag == r.Id)
                {
                    form = FormManager.GetFormSelected(r.FormAssigned);
                }
            });
            //_options[4].SubItems.ForEach(r =>
            //{
            //    if (tag == r.Id)
            //    {
            //        form = FormManager.GetFormSelected(r.FormAssigned);
            //    }
            //});
            var formActive = this.ActiveMdiChild;
            if (formActive != null)
            {
                formActive.Hide();
            }
            if (form != null)
            {
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form?.Show();
            }
            Bitmap image = null;
            _options[3].SubItems.ForEach(r =>
            {
                if (tag == r.Id)
                {
                    image = r.Banner;
                }
            });
            //_options[4].SubItems.ForEach(r =>
            //{
            //    if (tag == r.Id)
            //    {
            //        image = r.Banner;
            //    }
            //});
            mainMenu.Items[5].Image = image;

        }
    }
}
