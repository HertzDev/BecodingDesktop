using BecodingDesktop.Controllers.Admin;
using BecodingDesktop.Controllers.Employee;
using BecodingDesktop.Helpers;
using BecodingDesktop.Views.Admin;
using BecodingDesktop.Views.Base;
using BecodingDesktop.Views.Employee;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecodingDesktop.Views.General
{
    public partial class FrmLogin : MaterialForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink900, Primary.Pink900,
                Primary.Pink900, Accent.LightBlue200,
                TextShade.WHITE
            );
            materialSkinManager.FORM_PADDING = 20;
        }

        protected override void OnLoad(EventArgs e)
        {
            this.lblTitleSignIn.ForeColor = ColorManager.Primary;
            base.OnLoad(e);
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HU62KJ8; Initial Catalog=modulo_ventas;Integrated Security=True");
        public void Login(string email, string contraseña)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("LOGEO", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("password", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][1].ToString() == "Administrador")
                    {
                        if (dt.Rows[0][3].ToString() == "0")
                        {

                            FrmMenuAdminContainer a = new FrmMenuAdminContainer(new MenuAdmin());
                            a.Show();


                        }
                        else if (dt.Rows[0][3].ToString() == "1")
                        {
                            MessageBox.Show("Administador Inactivo");
                            this.txtEmail.Clear();
                            this.txtPassword.Clear();
                        }

                    }
                    else if (dt.Rows[0][1].ToString() == "Empleado")
                    {
                        if (dt.Rows[0][3].ToString() == "0")
                        {
                            FrmMenuEmployeeContainer b = new FrmMenuEmployeeContainer(new MenuEmployee());
                            b.Show();
                        }
                        else if (dt.Rows[0][3].ToString() == "1")
                        {
                            MessageBox.Show("Usuario Inactivo");
                            this.txtEmail.Clear();
                            this.txtPassword.Clear();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                    this.txtEmail.Clear();
                    this.txtPassword.Clear();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Login(this.txtEmail.Text, this.txtPassword.Text);
        }
    }
}
