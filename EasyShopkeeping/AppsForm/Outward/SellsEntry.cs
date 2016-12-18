using EasyShopkeeping.Utility;
using EasyShopkeeping.Utility.Common;
using EasyShopkeeping.Utility.ExportDocument;
using MySql.Data.MySqlClient;
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
    public partial class SellsEntry : Form
    {

        Helper helper = new Helper();

        public SellsEntry()
        {
            InitializeComponent();
        }

        String CUST_ID;
        String customerSelected;
        String itemSelected;
        String goodEntryTable = "goods_entry";
        String lotStatusTable="lot_status";
        String goodsEntryTable="goods_entry";

        String goodsDetailQueryString = "Select goodsentry.TRDR_FNAME_TMARK,lotstatus.LOT_ID,goodsentry.ITEM_NAME,goodsentry.WT_BOX_TYPE, "
       +"goodsentry.WT_TXT,lotstatus.LOT_SERIAL,lotstatus.TOT_BOX,IF(FIND_IN_SET(lotstatus.LOT_ID,stockdetails.SHORT_LOT_IND) > 0, "
       +"goodsentry.SHORT_BOX, null) as SHORT_BOX,lotstatus.TOT_BAL,lotstatus.G_ENTRY_ID,lotstatus.TOT_SOLD,lotstatus.TOT_SOLD_IND, "
       +"goodsentry.TRDR_ID,stockdetails.SHORT_LOT_IND,stockdetails.STOCK_ID from lot_status lotstatus left outer join stock_details "
       +"stockdetails on lotstatus.G_ENTRY_ID=stockdetails.G_ENTRY_ID inner join goods_entry goodsentry on goodsentry.G_ENTRY_ID=stockdetails.G_ENTRY_ID "
       +"where lotstatus.TOT_SOLD_IND='N'";
        String[] columnNameToDisplay = new String[] { "Trader Party", "LotId", "Item", "BOX Type", "Wt(Kg)", "Lot Serial","Tot Box Recieved", "Total Box Short", "Total Balance", "Total Sold"};

        int[] columnIndexToHide = new int[] { 9, 11, 12, 13, 14 };
        FillDataGridView fillData = new FillDataGridView();
        ToExcel toExcel = new ToExcel();
        private void SellsEntry_Load(object sender, EventArgs e)
        {
            fillData.fillDataGridView(this.sellsEntryDataGridView, goodsDetailQueryString, this.columnNameToDisplay, this.columnIndexToHide);
            sellsEntryCutomerComboBox.Items.Clear();
            sellsEntryItemComboBox.Items.Clear();
           try
            {
            FillFormWithData comboboxDataReader = new FillFormWithData();
            MySqlDataReader reader1 = comboboxDataReader.getDataInComboBox("customer_data", "CUST_ID,CUST_FNAME,CUST_LNAME,CUST_AREA");
            MySqlDataReader reader2 = comboboxDataReader.getDataInComboBox("item_details", "ITEM_NAME");
            if (!(reader1.HasRows))
            {
                sellsEntryCutomerComboBox.Items.Add("Not Present In Database");
            }
            if (!(reader2.HasRows))
            {
                sellsEntryItemComboBox.Items.Add("Not Present In Database");
            }
            while (reader1.Read())
            {
                sellsEntryCutomerComboBox.Items.Add(new ComboBoxItem(reader1.GetString("CUST_FNAME") + " "+reader1.GetString("CUST_LNAME")+" "+helper.nullToEmpty(reader1.GetString("CUST_AREA")), reader1.GetString("CUST_ID")));
            }
            while (reader2.Read())
            {
                sellsEntryItemComboBox.Items.Add(reader2.GetString("ITEM_NAME"));
            }
            }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
        }
        private void sellsEntrySaveBtn_Click(object sender, EventArgs e)
        {

        }
        private void SellsDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sellsEntryCutomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            this.CUST_ID = ((ComboBoxItem)sellsEntryCutomerComboBox.SelectedItem).HiddenValue;
            this.customerSelected = ((ComboBoxItem)sellsEntryCutomerComboBox.SelectedItem).ToString();
        }

        private void sellsEntryItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            this.itemSelected = sellsEntryItemComboBox.SelectedItem.ToString();
        }

       

     

    }
}
