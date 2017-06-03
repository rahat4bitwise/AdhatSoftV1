using EasyShopkeeping.Utility;
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

        public String rate;
        public String quantity;
        public String totalAmount;
        private DateTime sellDate;
        Validation validate = new Validation();
        public AddSellsDetailFrm()
        {
        //    Console.WriteLine("Constructer is called");
           
        }

        public AddSellsDetailFrm(String customer,String item,String Trader,String TotalBal)
        {
            InitializeComponent();
            this.customerLbl.Text= customer;
            this.itemLbl.Text = item;
            this.traderLbl.Text = Trader;
            this.lotBalLbl.Text = TotalBal;
            //Console.WriteLine("Argument constructer is called");
        }

        public String rate1
        {
            get { return rate; }
            set { rate = value; }
        }

        public String quantity1
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public String totalAmount1
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        public DateTime sellDate1
        {
            get { return sellDate; }
            set { sellDate = value; }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.rate1 = rateTxt.Text.ToString();
            this.quantity1 = qtyTxt.Text.ToString();
            this.totalAmount1 = totAmntTxt.Text.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddSellsDetailFrm_Load(object sender, EventArgs e)
        {
            this.sellDate1 = dateTimePicker1.Value;
        }

        private void rateTxt_TextChanged(object sender, EventArgs e)
        {
            double rate = 0;
            int quantity = 0;


            errorProvider1.Clear();

            if (!(validate.IsNumeric(qtyTxt.Text.Trim())))
            {
            errorProvider1.SetError(qtyTxt, "Value Should Be Numeric Or Must Not Empty"); 
            }


            if (!(String.IsNullOrEmpty(rateTxt.Text.Trim())) && validate.IsDouble(rateTxt.Text.Trim()))
            {
                rate = double.Parse(rateTxt.Text.Trim());
                if (!(String.IsNullOrEmpty(rateTxt.Text.Trim())))
                {
                    quantity = int.Parse(qtyTxt.Text.Trim());
                }
                    

            }
            else
            {
                errorProvider1.SetError(rateTxt, "Please Fill Rate Here");
            }
            totAmntTxt.Text = (rate * quantity).ToString();
            
        }

        private void qtyTxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            double rate=0 ;
            int quantity=0;
            
            if (validate.IsNumeric(qtyTxt.Text.Trim()) && !(String.IsNullOrEmpty(qtyTxt.Text)))
            {
                if (validate.IsDouble(rateTxt.Text.Trim())  )
                {
                    rate = Convert.ToDouble(rateTxt.Text.Trim());
                    quantity = int.Parse(qtyTxt.Text.Trim());
                    
                }
            }
            else
            {
                errorProvider1.SetError(qtyTxt, "Value Should Be Numeric Or Must Not Empty"); 

            }
            totAmntTxt.Text = (rate * quantity).ToString();

        }

    }
}
