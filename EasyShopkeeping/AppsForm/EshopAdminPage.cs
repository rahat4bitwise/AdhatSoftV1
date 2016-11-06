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
using EasyShopkeeping.AppsForm.Inward;
using EasyShopkeeping.AppsForm.Outward;
using EasyShopkeeping.AppsForm.Trader;
using EasyShopkeeping.AppsForm.MasterEntry.Category;
using EasyShopkeeping.AppsForm.General;

namespace EasyShopkeeping
{
    public partial class AdminWindow : Form
    {
        String user;
        public AdminWindow(String userName)
        {
            InitializeComponent();
            this.user = userName;
            this.userNameLbl.Text = "Welcome Mr. " + userName;
            this.WindowState = FormWindowState.Maximized;
        }

        private void AdminWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            
 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure to Exit", "Exit Appliation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addNewUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void addNewCustomerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddCustomerFrm addCustomer = new AddCustomerFrm();
            addCustomer.Show();
        }

        private void masterEntryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
        }

        private void goodsEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodsEntry goodsEntryFrm = new GoodsEntry();
            goodsEntryFrm.Show();
        }

        private void sellsEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellsDetails sellsDetails = new SellsDetails();
            sellsDetails.Show();
        }

        private void addNewTraderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTraderFrm addTraderFrm = new AddTraderFrm();
            addTraderFrm.Show();
        }

        
            private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Minimized;
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void AdminWindow_Load(object sender, EventArgs e)
            {

            }

            private void AdminWindow_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.Shift && e.KeyCode == Keys.T)
                {
                    AddTraderFrm addTraderFrm = new AddTraderFrm();
                    addTraderFrm.Show();
                }
                if (e.Shift && e.KeyCode == Keys.C)
                {
                    AddCustomerFrm addCustomer = new AddCustomerFrm();
                    addCustomer.Show();
                }

                if (e.Shift && e.KeyCode == Keys.G)
                {
                    GoodsEntry goodsEntry = new GoodsEntry();
                    goodsEntry.Show();
                }
                if (e.Shift && e.KeyCode == Keys.S)
                {
                    SellsDetails sellsDetails = new SellsDetails();
                    sellsDetails.Show();
                }
            }

            private void customerToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void logoPanel_Paint(object sender, PaintEventArgs e)
            {

            }

            private void allCustomerToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AllCustomerFrm allCustomer = new AllCustomerFrm();
                allCustomer.Show();
            }

            private void addNewItemToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                AddItem addItem = new AddItem();
                addItem.Show();
            }

            private void addAreaToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                AddAreaFrm addAreaFrm = new AddAreaFrm();
                addAreaFrm.Show();  
            }

            private void addDistrictToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                AddDistrictFrm addDistrictFrm = new AddDistrictFrm();
                addDistrictFrm.Show();
            }

            private void addStateToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AddStateFrm addStateFrm = new AddStateFrm();
                addStateFrm.Show();
                
            }

            private void allGoodsEntryToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AllGoodsEntryDetails allGoodsEntryDetails = new AllGoodsEntryDetails();
                allGoodsEntryDetails.Show();
            }
        


    }
}
