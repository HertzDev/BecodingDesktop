using BecodingDesktop.Helpers;
using BecodingDesktop.Helpers.Enums;
using BecodingDesktop.Interfaces.Admin;
using BecodingDesktop.Interfaces.General;
using BecodingDesktop.Models;
using BecodingDesktop.Models.General;
using BecodingDesktop.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BecodingDesktop.Views.General.Products
{
    public partial class FrmAddReplaceProduct : FrmBaseActionContainer
    {
        private readonly IProduct _product;
        private readonly ProductModel dataSend;
        public FrmAddReplaceProduct(IProduct iproduct, ProductModel product)
        {
            _product = iproduct;
            this.Size = new Size(500, 500);
            var controls = _product.CreateView(product); 
            this.flyContainer.Controls.AddRange(controls.ToArray());
            this.lblTitle.AutoSize = true;
            this.lblTitle.Size = new Size(500, 80);
        }
        public FrmAddReplaceProduct()
        {
            InitializeComponent();
        }

        private void CloseEvent(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsAllCompleteValues(ProductModel product)
        {
            return (ValidatorManager.IsValid(TypeValidation.WORD, product.Name) && ValidatorManager.IsValid(TypeValidation.WORD, product.Price)
                && ValidatorManager.IsValid(TypeValidation.WORD, product.Existence) && ValidatorManager.IsValid(TypeValidation.WORD, product.ProductCode) && ValidatorManager.IsValid(TypeValidation.WORD, product.Description));
        }

        private void ClearProperties()
        {
            this.flyContainer.Controls.Clear();
            var controls = _product.CreateView(null);
            this.flyContainer.Controls.AddRange(controls.ToArray());
        }





        private void ClickEvent(object sender, EventArgs e)
        {
            var dataStore = new ProductModel()
            {
                Id = (dataSend != null) ? dataSend.Id : 0,
                Name = this.flyContainer.Controls[0].Text,
                Price = Convert.ToDecimal(this.flyContainer.Controls[1].Text),
                Existence = Convert.ToInt32(this.flyContainer.Controls[2].Text),
                ProductCode = this.flyContainer.Controls[3].Text,
                Description = this.flyContainer.Controls[4].Text
            };
            if (IsAllCompleteValues(dataStore))
            {

                DialogResult result = MessageBox.Show("¿Estás seguro que deseas " + this.btnMainAction.Text + " el dato?", "asas", MessageBoxButtons.OKCancel);
                if (result.Equals(DialogResult.OK))
                {
                    MessageModel message = null;
                    if (this.btnMainAction.Text.ToLower().Equals("guardar"))
                    {
                        message = _product.SetItem(dataStore);
                    }
                    else
                    {
                        message = _product.UpdateItem(dataStore);
                        //message = _userLogic.UpdateStateItem(user);
                    }
                    if (message != null && message.Code == 200)
                    {
                        var users = this.Owner.ActiveMdiChild;
                        ((FrmProduct)users).RefreshTable(_product.GetProducts());
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(message.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar todos los campos para poder continuar");
            }
        }
    }
}
