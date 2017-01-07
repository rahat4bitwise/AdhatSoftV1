using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopkeeping.AppsForm.Outward
{
    public partial class AddSellsDetailFrm : Form
    {

        public String amount;
        public String quantity;
        public String totalAmount;
        public AddSellsDetailFrm()
        {
            InitializeComponent();
        }

        public AddSellsDetailFrm(String customer,String item)
        {
            this.customerLbl.Text= customer;
            this.itemLbl.Text = item;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.amount = textBox2.Text.ToString();
            this.quantity = textBox1.Text.ToString();
        }


        

    }
}
