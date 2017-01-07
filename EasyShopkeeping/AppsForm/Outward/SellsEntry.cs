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

        String goodsDetailQueryString = "Select goodsentry.TRDR_FNAME_TMARK,goodsentry.RECV_DATE,goodsentry.ITEM_NAME,goodsentry.WT_BOX_TYPE, "
       +"goodsentry.WT_TXT,lotstatus.LOT_SERIAL,lotstatus.TOT_BOX,IF(FIND_IN_SET(lotstatus.LOT_ID,stockdetails.SHORT_LOT_IND) > 0, "
       +"goodsentry.SHORT_BOX, null) as SHORT_BOX,lotstatus.TOT_BAL,lotstatus.G_ENTRY_ID,lotstatus.TOT_SOLD,lotstatus.TOT_SOLD_IND, "
       + "goodsentry.TRDR_ID,stockdetails.SHORT_LOT_IND,stockdetails.STOCK_ID,lotstatus.LOT_ID from lot_status lotstatus left outer join stock_details "
       +"stockdetails on lotstatus.G_ENTRY_ID=stockdetails.G_ENTRY_ID inner join goods_entry goodsentry on goodsentry.G_ENTRY_ID=stockdetails.G_ENTRY_ID "
       +"where lotstatus.TOT_SOLD_IND='N'";
        String[] columnNameToDisplay = new String[] { "Trader Party", "Recv.Date", "Item", "BOX Type", "Wt(Kg)", "Lot Serial","Tot Box Recieved", "Total Box Short", "Total Balance", "Total Sold"};

        int[] columnIndexToHide = new int[] { 9, 11, 12, 13, 14,15 };
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
           String goodsDetailQueryString1 =goodsDetailQueryString+" and goodsentry.ITEM_NAME='"+itemSelected+"'";
           fillData.fillDataGridView(this.sellsEntryDataGridView, goodsDetailQueryString1, this.columnNameToDisplay, this.columnIndexToHide);
        }

        private void sellsEntryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    
                    String TRDR_FNAME_TMARK = this.sellsEntryDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    String RECV_DATE = this.sellsEntryDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    String ITEM_NAME = this.sellsEntryDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    String WT_BOX_TYPE = this.sellsEntryDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    String WT_TXT = this.sellsEntryDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    String TOT_BAL = this.sellsEntryDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                    String G_ENTRY_ID = this.sellsEntryDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                    String TOT_SOLD = this.sellsEntryDataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
                    String TRDR_ID = this.sellsEntryDataGridView.Rows[e.RowIndex].Cells[12].Value.ToString();
                    String STOCK_ID = this.sellsEntryDataGridView.Rows[e.RowIndex].Cells[14].Value.ToString();
                    String LOT_ID = this.sellsEntryDataGridView.Rows[e.RowIndex].Cells[15].Value.ToString();
                    Console.Write("TRDR_FNAME_TMARK:" + TRDR_FNAME_TMARK + "\nRECV_DATE:" + RECV_DATE + "\nITEM_NAME:" + ITEM_NAME + "\nWT_BOX_TYPE:" + WT_BOX_TYPE + "\nWT_TXT:" + WT_TXT + "\nTOT_BAL:" + TOT_BAL + "\nG_ENTRY_ID:" + G_ENTRY_ID + "\nTOT_SOLD:" + TOT_SOLD + "\nTRDR_ID:" + TRDR_ID + "\nSTOCK_ID:" + STOCK_ID + "\nLOT_ID:" + LOT_ID + "\nCUST_ID" + CUST_ID + "\ncustomerSelected:" + customerSelected);
                    AddSellsDetailFrm addSellsDetailFrm = new AddSellsDetailFrm(customerSelected, ITEM_NAME);
                    addSellsDetailFrm.Show();
                    String str = addSellsDetailFrm.amount;
                    Console.Write(str);
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }


    }
}
