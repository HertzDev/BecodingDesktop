using BecodingDesktop.Controllers.Admin.Catalogs;
using BecodingDesktop.Controllers.Admin.Users;
using BecodingDesktop.Helpers.Enums;
using BecodingDesktop.Views.Admin;
using BecodingDesktop.Views.Admin.Users;
using BecodingDesktop.Views.General.Products;
using BecodingDesktop.Views.General.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecodingDesktop.Helpers
{
    class FormManager
    {
        public static Form GetFormSelected(MenuOptionName option)
        {
            Form formSelected = null;

            var catalog = new CatalogBase();
            switch (option)
            {
                case MenuOptionName.SALES:
                    {
                        formSelected = new FrmSale();
                        break;
                    }
                case MenuOptionName.BRANDS:
                    {
                        formSelected = new FrmBrands(new Brand(catalog));
                        break;
                    }

                case MenuOptionName.CATEGORIES:
                    {
                        formSelected = new FrmCategories(new Category(catalog));
                        break;
                    }

                case MenuOptionName.INVOICEBLOCK:
                    {
                        formSelected = new FrmInvoiceBlock();
                        break;
                    }

                case MenuOptionName.MODELS:
                    {
                        formSelected = new FrmModels(new Model(catalog));
                        break;
                    }

                case MenuOptionName.PAYMENTMETHODS:
                    {
                        formSelected = new FrmPaymentMethods(new PaymentMethod(catalog));
                        break;
                    }

                case MenuOptionName.PRODUCTS:
                    {
                        formSelected = new FrmProduct();
                        break;
                    }

                case MenuOptionName.TYPEINVOICES:
                    {
                        formSelected = new FrmTypeInvoice(new TypeInvoice(catalog));
                        break;
                    }

                case MenuOptionName.USERS:
                    {
                        formSelected = new FrmUsers();
                        break;
                    }
                case MenuOptionName.USERSADD:
                    {
                        formSelected = new FrmAddReplaceUser(new AddReplaceUser(new Role()),null);
                        break;
                    }

                case MenuOptionName.USERSDETAIL:
                    {
                        formSelected = new FrmDetailUser(new DetailUser(), null);
                        break;
                    }
            }
            return formSelected;
        }
    }
}
