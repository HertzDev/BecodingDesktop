using BecodingDesktop.Helpers;
using BecodingDesktop.Helpers.Enums;
using BecodingDesktop.Interfaces.Admin;
using BecodingDesktop.Interfaces.Admin.Users;
using BecodingDesktop.Models;
using BecodingDesktop.Models.Catalogs;
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

namespace BecodingDesktop.Views.Admin.Users
{
    public partial class FrmAddReplaceUser : FrmBaseActionContainer
    {
        private readonly IUser _user;
        private readonly IUserLogic _userLogic;
        private readonly UserModel userSend;
        public FrmAddReplaceUser(IUser user, UserModel userModel, IUserLogic userLogic)
        {
            _user = user;
            _userLogic = userLogic;
            this.Size = new Size(450, 400);
            userSend = userModel;
            var controls = user.CreateView(userModel);
            this.flyContainer.Controls.AddRange(controls.ToArray());
            this.btnMainAction.Text = userModel != null ? "ACTUALIZAR" : "GUARDAR";
            this.btnMainAction.Click += ClickEvent;
            this.btnCancel.Click += CloseEvent;
        }

        private void CloseEvent(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            var user = new UserModel()
            {
                Id = (userSend!=null)?userSend.Id:0,
                Name = this.flyContainer.Controls[0].Text,
                Email = this.flyContainer.Controls[1].Text,
                Password = this.flyContainer.Controls[2].Text,
                Role = new RoleModel()
                {
                    Id = ((ComboBox)this.flyContainer.Controls[4]).SelectedIndex+1,
                    Name = ((ComboBox)this.flyContainer.Controls[4]).SelectedItem?.ToString()
                }
            };
            if (IsAllCompleteValues(user))
            {
                
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas "+this.btnMainAction.Text+" el usuario?","asas",MessageBoxButtons.OKCancel);
                if(result.Equals(DialogResult.OK))
                {
                    MessageModel message = null;
                    if (this.btnMainAction.Text.ToLower().Equals("guardar"))
                    {
                        message = _userLogic.SetItem(user);
                    }
                    else
                    {
                        message = _userLogic.UpdateItem(user);
                        //message = _userLogic.UpdateStateItem(user);
                    }
                    if(message!=null && message.Code == 200)
                    {
                        var users = this.Owner.ActiveMdiChild;
                        ((FrmUsers)users).RefreshTable(_userLogic.GetUsers());
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

        private bool IsAllCompleteValues(UserModel user)
        {
            return (ValidatorManager.IsValid(TypeValidation.WORD, user.Name) && ValidatorManager.IsValid(TypeValidation.WORD, user.Email)
                && ValidatorManager.IsValid(TypeValidation.WORD, user.Password) && ValidatorManager.IsValid(TypeValidation.WORD, user.Role.Name));
        }

        private void ClearProperties()
        {
            this.flyContainer.Controls.Clear();
            var controls = _user.CreateView(null);
            this.flyContainer.Controls.AddRange(controls.ToArray());
        }



        public FrmAddReplaceUser()
        {
            InitializeComponent();
        }
    }
}
