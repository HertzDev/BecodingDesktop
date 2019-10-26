using BecodingDesktop.Controllers.Admin.Catalogs;
using BecodingDesktop.Helpers;
using BecodingDesktop.Helpers.Enums;
using BecodingDesktop.Interfaces.Admin;
using BecodingDesktop.Models;
using BecodingDesktop.Views.Admin;
using BecodingDesktop.Views.Admin.Users;
using BecodingDesktop.Views.General.Products;
using BecodingDesktop.Views.General.Sales;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BecodingDesktop.Controllers.Admin
{
    class MenuAdmin : IMenuAdmin, IDisposable
    {
        List<MenuOptionModel> Options = new List<MenuOptionModel>();

        Size Size = new Size(260, 40);
        readonly Font Font = new Font(SystemFonts.DefaultFont, FontStyle.Bold);

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
                    FormAssigned = MenuOptionName.USERS

                });
            Options.Add(
                new MenuOptionModel()
                {
                    Id = 3,
                    Name = "PRODUCTOS",
                    Selected = Properties.Resources.I_product_white,
                    SelectedColor = ColorManager.PrimaryLight,
                    UnSelected = Properties.Resources.I_product_black,
                    UnSelectedColor = ColorManager.Black,
                    SelectedState = false,
                    ClickEvent = MenuClickEvent,
                    Banner = Properties.Resources.img_banner_sale,
                    FormAssigned = MenuOptionName.PRODUCTS
                });
            List<MenuOptionModel> catalogs = new List<MenuOptionModel>
            {
                new MenuOptionModel()
                {
                    Id = 6,
                    Name = "FORMAS DE PAGO",
                    Selected = Properties.Resources.I_payment_white,
                    SelectedColor = ColorManager.PrimaryLight,
                    UnSelected = Properties.Resources.I_payment_black,
                    UnSelectedColor = ColorManager.Black,
                    SelectedState = false,
                    ClickEvent = SubMenuClickEvent,
                    Banner = Properties.Resources.img_banner_sale,
                    FormAssigned = MenuOptionName.PAYMENTMETHODS
                },
                //new MenuOptionModel()
                //{
                //    Id = 7,
                //    Name = "ROLES",
                //    Selected = Properties.Resources.I_role_white,
                //    SelectedColor = ColorManager.PrimaryLight,
                //    UnSelected = Properties.Resources.I_role_black,
                //    UnSelectedColor = ColorManager.Black,
                //    ClickEvent = SubMenuClickEvent,
                //    Banner = Properties.Resources.img_banner_sale,
                //    FormAssigned = MenuOptionName.ROLES
                //},
                new MenuOptionModel()
                {
                    Id = 8,
                    Name = "TIPO DE FACTURAS",
                    Selected = Properties.Resources.I_bill_white,
                    SelectedColor = ColorManager.PrimaryLight,
                    UnSelected = Properties.Resources.I_bill_black,
                    UnSelectedColor = ColorManager.Black,
                    ClickEvent = SubMenuClickEvent,
                    Banner = Properties.Resources.img_banner_sale,
                    FormAssigned = MenuOptionName.TYPEINVOICES
                },
                new MenuOptionModel()
                {
                    Id = 9,
                    Name = "CATEGORIAS",
                    Selected = Properties.Resources.I_category_white,
                    SelectedColor = ColorManager.PrimaryLight,
                    UnSelected = Properties.Resources.I_category_black,
                    UnSelectedColor = ColorManager.Black,
                    ClickEvent = SubMenuClickEvent,
                    Banner = Properties.Resources.img_banner_sale,
                    FormAssigned = MenuOptionName.CATEGORIES
                },
                new MenuOptionModel()
                {
                    Id = 10,
                    Name = "MARCAS",
                    Selected = Properties.Resources.I_brand_white,
                    SelectedColor = ColorManager.PrimaryLight,
                    UnSelected = Properties.Resources.I_brand_black,
                    UnSelectedColor = ColorManager.Black,
                    ClickEvent = SubMenuClickEvent,
                    Banner = Properties.Resources.img_banner_sale,
                    FormAssigned =MenuOptionName.BRANDS
                },
                new MenuOptionModel()
                {
                    Id = 11,
                    Name = "MODELOS",
                    Selected = Properties.Resources.I_model_white,
                    SelectedColor = ColorManager.PrimaryLight,
                    UnSelected = Properties.Resources.I_model_black,
                    UnSelectedColor = ColorManager.Black,
                    ClickEvent =SubMenuClickEvent,
                    Banner = Properties.Resources.img_banner_sale,
                    FormAssigned = MenuOptionName.MODELS
                }
            };
            Options.Add(new MenuOptionModel()
            {
                Id = 4,
                Name = "CATALOGOS",
                Selected = Properties.Resources.I_model_white,
                SelectedColor = ColorManager.PrimaryLight,
                UnSelected = Properties.Resources.I_model_black,
                UnSelectedColor = ColorManager.Black,
                SubItems = catalogs,
                //ClickEvent = MenuClickEvent,
                Banner = Properties.Resources.img_banner_sale,
            });
            //List<MenuOptionModel> reports = new List<MenuOptionModel>
            //{
            //    new MenuOptionModel()
            //    {
            //        Id = 12,
            //        Name = "REPORTE DE VENTAS",
            //        Selected = Properties.Resources.I_report_white,
            //        SelectedColor = ColorManager.PrimaryLight,
            //        UnSelected = Properties.Resources.I_report_black,
            //        UnSelectedColor = ColorManager.Black,
            //        ClickEvent = MenuClickEvent,
            //        Banner = Properties.Resources.img_banner_sale,
            //        FormAssigned = MenuOptionName.SALES

            //    }
            //};
            //Options.Add(new MenuOptionModel()
            //{
            //    Id = 5,
            //    Name = "REPORTES",
            //    Selected = Properties.Resources.I_model_white,
            //    SelectedColor = ColorManager.PrimaryLight,
            //    UnSelected = Properties.Resources.I_model_black,
            //    UnSelectedColor = ColorManager.Black,
            //    SubItems = reports,
            //    ClickEvent = MenuClickEvent,
            //    Banner = Properties.Resources.img_banner_sale,
            //    FormAssigned = MenuOptionName.SALES
            //});
            return Options;
        }

        public void MenuClickEvent(object sender, EventArgs e)
        {
            var item = (ToolStripItem)sender;
            var tag = (int.Parse(item.Tag.ToString()));
        
            var option =Options.Find(op=>op.Id==tag);
            option.SelectedState = !option.SelectedState;
            Options.ForEach(op =>
            {
                if(op.Id != option.Id)
                {
                    op.SelectedState = false;
                }
            });
            item.ForeColor = (option.SelectedState)? (option.Id<=3)? ColorManager.White : ColorManager.Black : ColorManager.Black;
            item.Image = (option.SelectedState) ? option.Selected : option.UnSelected;
            item.BackColor = (option.SelectedState) ? option.SelectedColor : ColorManager.White;
        }
       
        public List<ToolStripItem> UnSelectedAll()
        {
            var options = Options;
            List<ToolStripItem> toolStrips = new List<ToolStripItem>();
            foreach (var option in options)
            {

                if (option.SubItems != null && option.SubItems.Count > 0)
                {
                    var subItem = UnSelectedSubItems(option);
                    toolStrips.Add(subItem);
                }
                else
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
                Margin = new Padding(0, 120, 0, 0)
            };

            toolStrips.Add(toolStripItemImage);
            return toolStrips;
        }

        public ToolStripItem UnSelectedSubItems(MenuOptionModel option)
        {
            var size = Size;
            size.Width = 240;
            var toolStripItem = new ToolStripDropDownButton()
            {
                Tag=option.Id,
                Text = option.Name,
                ForeColor = option.UnSelectedColor,
                Image = option.UnSelected,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Alignment = ToolStripItemAlignment.Left,
                Padding = Padding.Empty,
                Size = size,
                DropDownDirection = ToolStripDropDownDirection.BelowRight,
                Font = Font
            };
            toolStripItem.Click += option.ClickEvent;
            var toolStripDropDownItem = new ToolStripDropDown()
            {
                Text = option.Name,
                ForeColor = option.UnSelectedColor,
                AutoSize = true,
                Size = Size,
                LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
            };
            var toolStripButtonArray = new List<ToolStripItem>();
            foreach (var suboption in option.SubItems)
            {
                var toolStripSubItem = new ToolStripButton()
                {
                    Tag=suboption.Id,
                    Text = suboption.Name,
                    ForeColor = suboption.UnSelectedColor,
                    Image = suboption.UnSelected,
                    AutoSize = false,
                    Alignment = ToolStripItemAlignment.Left,
                    Padding = Padding.Empty,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Size = Size
                };
                toolStripSubItem.Click += suboption.ClickEvent;
                toolStripButtonArray.Add(toolStripSubItem);
            }
            toolStripDropDownItem.Items.AddRange(toolStripButtonArray.ToArray());
            toolStripItem.DropDown = toolStripDropDownItem;
            return toolStripItem;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SubMenuClickEvent(object sender, EventArgs e)
        {
            var item = (ToolStripItem)sender;
            var tag = (int.Parse(item.Tag.ToString()));

            MenuOptionModel option = null;
            //Options[4].SubItems.ForEach(s => { 
            //        if (tag == s.Id)
            //        {
            //            option = s;
            //        }
            //    });
            Options[3].SubItems.ForEach(s => {
                if (tag == s.Id)
                {
                    option = s;
                }
            });
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

        public void SetUnCheckedSubOption(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
