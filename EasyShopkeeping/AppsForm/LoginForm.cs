using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EasyShopkeeping
{
    public partial class MemberLogin : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public MemberLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.username.Focus();
            //this.WindowState = FormWindowState.Maximized;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            EasyShopkeeping easyShopkeeping = new EasyShopkeeping();
            easyShopkeeping.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (this.username.Text == "" || this.password.Text == "")
                MessageBox.Show("Username or Password Field Should Not Be Blank");
            else
            {
                UserInfoDAO userInfoDAO = new UserInfoDAO();
                UserForm userForm = new UserForm();
                if (userInfoDAO.validateUser(this.username.Text, this.password.Text))
                {
                    if (userInfoDAO.getUserype() == "admin")
                    {
                        AdminWindow adminWindow = new AdminWindow(username.Text.ToUpper());
                        adminWindow.Show();
                        log.Info("User " + this.username.Text.ToUpper() + " Successfully Logged In");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Normal User");

                }
                else
                {
                    log.Info("UserName: " + this.username + " Tried To Logged In");
                    string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                    log.Info("Window UserName " + userName + " Tried To Logged In");
                    MessageBox.Show("Wrong Username Or Password");
                }


                //String result="UserName"+user.getUsername+"\n" + "Password" + user.setPassword + "\n" + "UserType" + user.setUserCategory;
                //MessageBox.Show(result);

                // userForm.Show();
            }
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
