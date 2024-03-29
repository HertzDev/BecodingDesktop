﻿using BecodingDesktop.Interfaces.Admin;
using BecodingDesktop.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecodingDesktop.Controllers.Admin.Users
{
    class DetailUser : IUser
    {
        public List<Control> CreateView(UserModel user)
        {
            List<Control> controls = new List<Control>();
            var font = new Font(SystemFonts.DefaultFont, FontStyle.Bold);
            var margin = new Padding(10, 20, 10, 0);
            TableLayoutPanel tblBody = new TableLayoutPanel()
            {
                Name = "tblBody",
                ColumnCount = 2,
                AutoSize = false,
                Size = new Size(430, 400),
                RowStyles =
                {
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,30f),
                    new RowStyle(SizeType.Absolute,60f)

                },
                ColumnStyles =
                {
                    new ColumnStyle(SizeType.Absolute,100f),
                    new ColumnStyle(SizeType.Percent,35f)
                },
            };

            Label lblTitleUserCode = new Label()
            {
                Name = "lblTitleUserCode",
                Text = "Código:",
                Font = font
            };
            tblBody.Controls.Add(lblTitleUserCode, 0, 0);


            Label lblUserCode = new Label()
            {
                Name = "lblUserCode",
                Text = string.IsNullOrEmpty(user?.Id.ToString()) ? string.Empty : user?.Id.ToString(),
                Font = font,
                Dock = DockStyle.Left
            };
            tblBody.Controls.Add(lblUserCode, 1, 0);

            Label lblTitleUserName = new Label()
            {
                Name = "lblTitleUserName",
                Text = "Nombre:",
                Font = font
            };
            tblBody.Controls.Add(lblTitleUserName, 0, 1);


            Label lblUserName = new Label()
            {
                Name = "lblUserName",
                Text = string.IsNullOrEmpty(user?.Name) ? string.Empty : user?.Name,
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lblUserName, 1, 1);

            Label lblTitleEmail = new Label()
            {
                Name = "lblTitleEmail",
                Text = "Correo electrónico:",
                Font = font
            };
            tblBody.Controls.Add(lblTitleEmail, 0, 2);


            Label lblEmail = new Label()
            {
                Name = "lblEmail",
                Text = string.IsNullOrEmpty(user?.Email) ? string.Empty : user?.Email,
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lblEmail, 1, 2);

            Label lblTitleRole = new Label()
            {
                Name = "lblTitleRole",
                Text = "Rol:",
                Font = font
            };
            tblBody.Controls.Add(lblTitleRole, 0, 3);


            Label lblRole = new Label()
            {
                Name = "lblRole",
                Text = string.IsNullOrEmpty(user?.Role.Name) ? string.Empty : user?.Role.Name,
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lblRole, 1, 3);

            Label lblTitleState = new Label()
            {
                Name = "lblTitleState",
                Text = "Estado:",
                Font = font
            };
            tblBody.Controls.Add(lblTitleState, 0, 4);


            Label lblState = new Label()
            {
                Name = "lblState",
                Text = string.IsNullOrEmpty(user?.StateText) ? string.Empty : user?.StateText,
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lblState, 1, 4);


            Label lblTitleCreationDate = new Label()
            {
                Name = "lblTitleCreationDate",
                Text = "Fecha de \n\rCreación:",
                Font = font,
                AutoSize = true,
                Height = 60
            };
            tblBody.Controls.Add(lblTitleCreationDate, 0, 5);


            Label lblCreationDate = new Label()
            {
                Name = "lblCreationDate",
                Text = string.IsNullOrEmpty(user?.CreationDate) ? string.Empty : user?.CreationDate,
                Font = font,
                Dock = DockStyle.Fill
            };
            tblBody.Controls.Add(lblCreationDate, 1, 5);
            controls.Add(tblBody);
            return controls;

        }
    }
}
