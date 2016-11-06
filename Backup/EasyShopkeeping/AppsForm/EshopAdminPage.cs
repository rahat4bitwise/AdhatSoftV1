using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EasyShopkeeping.AppsForm.User;
using EasyShopkeeping.AppsForm.Customer;

namespace EasyShopkeeping
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void masterEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerFrm addCustomer = new AddCustomerFrm();
            addCustomer.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
          AddUser addUser = new AddUser();
          addUser.Show();
        }
    }
}
