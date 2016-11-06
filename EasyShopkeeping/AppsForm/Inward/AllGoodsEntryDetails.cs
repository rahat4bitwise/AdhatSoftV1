using EasyShopkeeping.Utility;
using EasyShopkeeping.Utility.Common;
using EasyShopkeeping.Utility.ExportDocument;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopkeeping.AppsForm.Inward
{
    public partial class AllGoodsEntryDetails : Form
    {
        public AllGoodsEntryDetails()
        {
            InitializeComponent();
        }

        String dateRange;
        String G_ENTRY_ID;
        String TRDR_ID;
       

        Validation validate = new Validation();
        String tableName = "goods_entry";
        String[] columnsToPull = new String[] { "G_ENTRY_ID", "TRDR_ID","RECV_DATE", "TRDR_FNAME_TMARK", "ITEM_NAME", "WT_BOX_TYPE", "WT_TXT", "LOT_1", "LOT_2", "LOT_3", "LOT_4"
        , "LOT_5", "LOT_NO_SHORT","SHORT_BOX", "QTY_RCVD","LOGISTIC_DETAILS", "ORIGIN", "VEHICLE_NO", "FARE_RATE", "TOTAL_FARE"};
        String[] columnNameToDisplay = new String[] { "","","Receiving Date", "Party Detail", "Item", "BOX Type", "Wt(Kg)", "Lot 1", "Lot 2", "Lot 3", "Lot 4",
         "Lot 5","Lot No Short", "Short Box", "Total Recieved", "Transport Details", "ORIGIN", "Truck No", "Fare Rate","Total Fare"};
        String whereCondition = " RECV_DATE='" + DateHelper.getSqlString(DateTime.Now) + "'";
        
        int[] columnIndexToHide = new int[] { 0, 1 };
        FillDataGridView fillData = new FillDataGridView();
        ToExcel toExcel = new ToExcel();
        private void AllGoodsEntryDetails_Load(object sender, EventArgs e)
        {
            
            fillData.fillDataGridView(this.AllGoodsEntrydataGridView, this.tableName, this.columnsToPull, this.columnNameToDisplay, this.columnIndexToHide,whereCondition);
            if (this.AllGoodsEntrydataGridView.RowCount == 0)
                MessageBox.Show("No Good Recieving Entry Found For Today\nPlease Enter Goods Entry For Todays");
        }

        private void closeFormpictureBox_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void minimizeFormpicBox_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Minimized;
        }

        private void AllGoodsEntrydataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            makeEntryDetailPanelNonEditable();

            if (e.RowIndex >= 0)
            {
                G_ENTRY_ID=this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                TRDR_ID=this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                dateTimePicker1.Value= (DateTime)this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[2].Value;
                String TRDR_FNAME_TMARK=this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                traderNameTxt.Text = TRDR_FNAME_TMARK.Substring(0, TRDR_FNAME_TMARK.IndexOf('('));
                tradeMarkTxt.Text =TRDR_FNAME_TMARK.Split('(', ')')[1];
                itemTxt.Text = this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                wtTxt1.Text = this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                wtTxt2.Text = this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                lot1Txt.Text = this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                lot2Txt.Text = this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                lot3Txt.Text = this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                lot4Txt.Text = this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
                lot5Txt.Text = this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
                shortBoxTxt.Text = this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[12].Value.ToString();
                totalRcvdTxt.Text = this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[13].Value.ToString();
                orginTxt.Text = this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[15].Value.ToString();
                truckNoTxt.Text = this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[16].Value.ToString();
                farePerBoxTxt.Text = this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[17].Value.ToString();
                totalFareTxt.Text = this.AllGoodsEntrydataGridView.Rows[e.RowIndex].Cells[18].Value.ToString();
            }

        }

        private void customDateRadioBtn_Click(object sender, EventArgs e)
        {
            if (customDateRadioBtn.Checked == true)
            {
                dateRange = "customDate";
                fromDateLabel.Text = "Date";
                toDateLabel.Visible = false;
                toDateTimePicker.Visible = false;
                
            }
        }

        private void allRadioBtn_Click(object sender, EventArgs e)
        {
            if (allRadioBtn.Checked == true)
            {
                fromDateLabel.Text = "Date";
                toDateLabel.Visible = false;
                toDateTimePicker.Visible = false;
                dateRange = "All";
            }
        }

        private void dateRangeRadioBtn_Click(object sender, EventArgs e)
        {
            if (dateRangeRadioBtn.Checked == true)
            {
                fromDateLabel.Text = "From";
                toDateLabel.Visible = true;
                toDateTimePicker.Visible = true;
                dateRange = "dateRange";
            }

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (allRadioBtn.Checked == false && customDateRadioBtn.Checked == false && dateRangeRadioBtn.Checked == false)
            {
                MessageBox.Show("Please Check at least one Option(All/ Date Range/Custom date");
                return;
            }
            if(dateRange.Equals("All"))
            {
                fillData.fillDataGridView(this.AllGoodsEntrydataGridView, this.tableName, this.columnsToPull, this.columnNameToDisplay, this.columnIndexToHide);
                String whereCondition = " RECV_DATE='" + DateHelper.getSqlString(DateTime.Now) + "'";
            }
            else if(dateRange.Equals("customDate"))
            {
                String whereCondition = " RECV_DATE='" + DateHelper.getSqlString(fromDateTimePicker.Value) + "'";
                fillData.fillDataGridView(this.AllGoodsEntrydataGridView, this.tableName, this.columnsToPull, this.columnNameToDisplay, this.columnIndexToHide, whereCondition);
                
            }
            else if(dateRange.Equals("dateRange"))
            {
                String whereCondition = " RECV_DATE between '" + DateHelper.getSqlString(fromDateTimePicker.Value) + "' and '" + DateHelper.getSqlString(toDateTimePicker.Value)+"'";
                fillData.fillDataGridView(this.AllGoodsEntrydataGridView, this.tableName, this.columnsToPull, this.columnNameToDisplay, this.columnIndexToHide, whereCondition);
            }
            
        }

        private void toExcelBtn_Click(object sender, EventArgs e)
        {
            int[] columnsIndexPrinted = {2, 3, 4, 5, 6,7,8,9,10,11,12,13,14,15,16,17,18 };
            toExcel.exportToExcel(this.AllGoodsEntrydataGridView, "AllGoodEntry", columnsIndexPrinted);
        }

        public void makeEntryDetailPanelEditable()
        {
            dateTimePicker1.Enabled = true;
            itemTxt.ReadOnly = false;
            wtTxt1.ReadOnly = false;
            wtTxt2.ReadOnly = false;
            lot1Txt.ReadOnly = false;
            lot2Txt.ReadOnly = false;
            lot3Txt.ReadOnly = false;
            lot4Txt.ReadOnly = false;
            lot5Txt.ReadOnly = false;
            shortBoxTxt.ReadOnly = false;
            totalRcvdTxt.ReadOnly = false;
            orginTxt.ReadOnly = false;
            truckNoTxt.ReadOnly = false;
            farePerBoxTxt.ReadOnly = false;
            totalFareTxt.ReadOnly = false; 
        }
        public void makeEntryDetailPanelNonEditable()
        {
            dateTimePicker1.Enabled = false;
            itemTxt.ReadOnly = true;
            wtTxt1.ReadOnly = true;
            wtTxt2.ReadOnly = true;
            lot1Txt.ReadOnly = true;
            lot2Txt.ReadOnly = true;
            lot3Txt.ReadOnly = true;
            lot4Txt.ReadOnly = true;
            lot5Txt.ReadOnly = true;
            shortBoxTxt.ReadOnly = true;
            totalRcvdTxt.ReadOnly = true;
            orginTxt.ReadOnly = true;
            truckNoTxt.ReadOnly = true;
            farePerBoxTxt.ReadOnly = true;
            totalFareTxt.ReadOnly = true; 
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            makeEntryDetailPanelEditable();
        }

    }
}
