using BecodingDesktop.Controllers.Admin.Catalogs;
using BecodingDesktop.Helpers;
using BecodingDesktop.Helpers.Enums;
using BecodingDesktop.Interfaces.Employee;
using BecodingDesktop.Models;
using BecodingDesktop.Views.General.Products;
using BecodingDesktop.Views.General.Sales;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BecodingDesktop.Controllers.Employee
{
    class MenuEmployee : IMenuEmployee, IDisposable
    {
        readonly List<MenuOptionModel> Options = new List<MenuOptionModel>();

        Size Size = new Size(260, 40);
        readonly Font Font = new Font(SystemFonts.DefaultFont, FontStyle.Bold);

        public void MenuClickEvent(object sender, EventArgs e)
        {
            var item = (ToolStripItem)sender;
            var tag = int.Parse(item.Tag.ToString());
            var option = Options.Find(op => op.Id == tag);
            option.SelectedState = !option.SelectedState;
            Options.ForEach(op =>
            {
                if (op.Id != option.Id)
                {
                    op.SelectedState = false;
                }
            });
            item.ForeColor = (option.SelectedState) ? (option.Id <= 3) ? ColorManager.White : ColorManager.Black : ColorManager.Black;
            item.Image = (option.SelectedState) ? option.Selected : option.UnSelected;
            item.BackColor = (option.SelectedState) ? option.SelectedColor : ColorManager.White;
        }

        public List<MenuOptionModel> MenuOptionInit()
        {
            Options.Add(
              new MenuOptionModel()
              {
                  Id = 1,
                  Name = "VENTAS",
                  Selected = Properties.Resources.I_sale_white,
                  SelectedColor = ColorManager.PrimaryLight,
                  UnSelected = Properties.Resources.I_sale_black,
                  UnSelectedColor = ColorManager.Black,
                  ClickEvent = MenuClickEvent,
                  SelectedState = false,
                  Banner = Properties.Resources.img_banner_sale,
                  FormAssigned = MenuOptionName.SALES
              });
            Options.Add(
                new MenuOptionModel()
                {
                    Id = 2,
                    Name = "USUARIOS",
                    Selected = Properties.Resources.I_user_white,
                    SelectedColor = ColorManager.PrimaryLight,
                    UnSelected = Properties.Resources.I_user_black,
                    UnSelectedColor = ColorManager.Black,
                    SelectedState = false,
                    ClickEvent = MenuClickEvent,
                    Banner = Properties.Resources.img_banner_sale,
                    FormAssigned =MenuOptionName.USERS

                });

            return Options;
        }

        public List<ToolStripItem> UnSelectedAll()
        {
            var options = Options;
            List<ToolStripItem> toolStrips = new List<ToolStripItem>();
            foreach (var option in options)
            {
                    var toolStripItem = new ToolStripButton()
                    {
                        Tag = option.Id,
                        Text = option.Name,
                        ForeColor = option.UnSelectedColor,
                        Image = option.UnSelected,
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Alignment = ToolStripItemAlignment.Left,
                        Padding = Padding.Empty,
                        Size = Size,
                        Font = Font
                    };
                    toolStripItem.Click += option.ClickEvent;
                    toolStrips.Add(toolStripItem);
            }
            Size.Height = 240;
            var toolStripItemImage = new ToolStripButton()
            {
                BackgroundImage = Properties.Resources.img_banner_sale,
                BackgroundImageLayout = ImageLayout.Stretch,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Alignment = ToolStripItemAlignment.Left,
                Padding = Padding.Empty,
                Size = Size,
                Enabled = false,
                Margin = new Padding(0, 180, 0, 0)
            };

            toolStrips.Add(toolStripItemImage);
            return toolStrips;
        }

        public ToolStripItem UnSelectedSubItems(MenuOptionModel option)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

       
    }
}
