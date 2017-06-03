using EasyShopkeeping.Utility.ExportDocument;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopkeeping.AppsForm.Customer
{
    public partial class GetCollectionForCust : Form
    {
        public GetCollectionForCust()
        {
            InitializeComponent();
        }

        String customerSelected;
        String areaSelected;
        String custSellsDataTable = "cust_sells_data";
        String custPaymentRcptTable = "cust_payment_rcpt";
        String collectionDetailQueryString = "select custData.cust_id,custData.CUST_FNAME,custData.CUST_LNAME,custData.CUST_AREA,custSellData.ITEM_NAME,custSellData.WT_TXT Kg,"
            +"custSellData.WT_BOX_TYPE,custSellData.QTY,custSellData.RATE,custSellData.TOT_AMNT,custPymntRcpt.PYMNT_AMNT,custSellData.TOT_AMNT-custPymntRcpt.PYMNT_AMNT Balance"
            +" from cust_sells_data custSellData inner join customer_data custData on custData.cust_id=custSellData.cust_id left outer join cust_payment_rcpt custPymntRcpt"
            +" on custSellData.CUST_ID=custPymntRcpt.cust_id and custSellData.SELL_TXN_ID =custPymntRcpt.SELL_TXN_ID where custSellData.PYMNT_CLR ='N'";
	   
	   
        String[] columnNameToDisplay = new String[] { "Cust_id", "First Name", "Last Name", "Area", "Item Name", "Wt(Kg)", "Qty","Rate", "Total Amount", "Total Payment", "Total Balance"};

        int[] columnIndexToHide = new int[] {0};
        FillDataGridView fillData = new FillDataGridView();
        ToExcel toExcel = new ToExcel();

        private void GetCollectionForCust_Load(object sender, EventArgs e)
        {
            fillData.fillDataGridView(this.getCollectiondataGridView, collectionDetailQueryString, this.columnNameToDisplay, this.columnIndexToHide);
            customerComboBox.Items.Clear();
            areaComboBox.Items.Clear();
            customeSearchTxt.Text = "";
        }

    
    
    
    
    
    }
}
