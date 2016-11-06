using EasyShopkeeping.Utility;
using EasyShopkeeping.Utility.Common;
using EasyShopkeeping.Utility.Excepetions;
using MySql.Data.MySqlClient;
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
    public partial class GoodsEntry : Form
    {
        public GoodsEntry()
        {
            InitializeComponent();
        }
        String TRDR_ID;
        String TRDR_FNAME_TMARK;
        String itemSelected;
        String wtSelected;
        String lotNoShortSelected;
        String isTransportSetails;
  
        int lot1 = 0;
        int lot2 = 0;
        int lot3 = 0;
        int lot4 = 0;
        int lot5 = 0;
        int shortBox = 0;
       
        private int GetTotalLotCount()
        {
            return lot1 + lot2 + lot3 + lot4 + lot5 - shortBox;
        }
        private int getTotalFare(int totalBoxes,int fareEachBox)
        {
            return totalBoxes * fareEachBox;
        }
        Helper helper = new Helper();
        private void SetToolTip()
        {
            toolTip1.SetToolTip(goodsEntryTradercomboBox, "Select Trader");
            toolTip1.SetToolTip(goodsEntryItemcomboBox, "Select Item");
            toolTip1.SetToolTip(goodsEntryWtcomboBox, "Select Box Type");
            toolTip1.SetToolTip(wtTxt, "Enter Wt Here");
            toolTip1.SetToolTip(lot1_txt, "Enter Lot");

        }

        private void GoodsEntry_Load(object sender, EventArgs e)
        {
            SetToolTip();
            goodsEntryTradercomboBox.Items.Clear();
            goodsEntryItemcomboBox.Items.Clear();

            try
            {

                FillFormWithData comboboxDataReader = new FillFormWithData();
                MySqlDataReader reader1 = comboboxDataReader.getDataInComboBox("trader_info", "TRDR_ID,TRDR_FNAME,TRDR_TMARK");
                MySqlDataReader reader2 = comboboxDataReader.getDataInComboBox("item_details", "ITEM_NAME");
                if(!(reader1.HasRows))
                {
                    goodsEntryTradercomboBox.Items.Add("Not Present In Database");
                }
                if(!(reader2.HasRows))
                {
                    goodsEntryItemcomboBox.Items.Add("Not Present In Database");
                }
                while (reader1.Read())
                {
                    goodsEntryTradercomboBox.Items.Add(new ComboBoxItem(reader1.GetString("TRDR_FNAME") + helper.nullToEmpty(reader1.GetString("TRDR_TMARK")), reader1.GetString("TRDR_ID")));
                }
                while (reader2.Read())
                {
                    goodsEntryItemcomboBox.Items.Add(reader2.GetString("ITEM_NAME"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GoodsEntry_KeyDown(object sender, KeyEventArgs e)
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

        private void goodsEntryTradercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            this.TRDR_ID = ((ComboBoxItem)goodsEntryTradercomboBox.SelectedItem).HiddenValue;
            this.TRDR_FNAME_TMARK = ((ComboBoxItem)goodsEntryTradercomboBox.SelectedItem).ToString();

            
        }

        private void goodsEntryItemcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            itemSelected = goodsEntryItemcomboBox.SelectedItem.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            wtSelected = goodsEntryWtcomboBox.SelectedItem.ToString();
        }

        private void goodsEntryradioButton_Click(object sender, EventArgs e)
        {
            if(goodsEntryradioButton.Checked==true)
            {
                goodsTransportGrpBox.Visible = true;
                isTransportSetails = "YES";
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (goodsEntryradioNOBtn.Checked == true)
            {
                goodsTransportGrpBox.Visible = false;
                isTransportSetails = "NO";
            }
        }

        //Saving the goods entry details into database;
       // TRDR_ID;itemSelected;wtSelected;isTransportSetails; will be selected at run time
        
        private void goodsEntrySaveBtn_Click(object sender, EventArgs e)
        {
            String WT_TXT = wtTxt.Text.ToString();
            String WT_BOX_TYPE = wtSelected;
            String ITEM_NAME=itemSelected;
            String LOT_1 = lot1_txt.Text.ToString();
            String LOT_2 = lot2_txt.Text.ToString();
            String LOT_3 = lot3_txt.Text.ToString();
            String LOT_4 = lot4_txt.Text.ToString();
            String LOT_5 = lot5_txt.Text.ToString();
            String SHORT_BOX = shortBoxTxt.Text.ToString();
            String QTY_RCVD=totallotCount_txt.Text.ToString();
            String ORIGIN = goodEntryOriginTxt.Text.ToString();
            String FARE_RATE = fareRateTxt.Text.ToString();
            String VEHICLE_NO = vehicleNoTxt.Text.ToString();
            String LOGISTIC_DETAILS = isTransportSetails;
            String TOTAL_FARE = totalFareTxt.Text.ToString();
            DateTime date =  dateTimePicker.Value;
            String RECV_DATE = DateHelper.getSqlString(date);
            String LOT_NO_SHORT = lotNoShortSelected;
            


            if(String.IsNullOrEmpty(TRDR_ID)||String.IsNullOrEmpty(TRDR_FNAME_TMARK))
            {
                errorProvider1.SetError(goodsEntryTradercomboBox, "Please Select Trader");
                return;
            }
            if (String.IsNullOrEmpty(itemSelected))
            {
                errorProvider1.SetError(goodsEntryItemcomboBox, "Please Select Item");
                return;
            }
            if (String.IsNullOrEmpty(wtSelected))
            {
                errorProvider1.SetError(goodsEntryWtcomboBox, "Please Select Box");
                return;
            }
            if (String.IsNullOrEmpty(WT_TXT))
            {
                errorProvider1.SetError(wtTxt, "Please Enter Wt");
                return;
            }
            if (String.IsNullOrEmpty(LOT_1))
            {
                errorProvider1.SetError(lot1_txt, "Please Enter lot");
                return;
            }

            if (String.IsNullOrEmpty(shortBoxTxt.Text.ToString()) && !(String.IsNullOrEmpty(lotNoShortSelected)) )
            {
                errorProvider1.SetError(shortBoxTxt, "Enter No of Short Box");
                return;
            }
            if (!(String.IsNullOrEmpty(shortBoxTxt.Text.ToString())) && (String.IsNullOrEmpty(lotNoShortSelected)))
            {
                errorProvider1.SetError(lotNoShortComboBox, "Enter Lot No Shorted.");
                return;
            }
            if (!(String.IsNullOrEmpty(lotNoShortSelected)) && !(String.IsNullOrEmpty(shortBoxTxt.Text.ToString())))
            {
                int val=int.Parse(lotNoShortSelected);
               
                if (int.Parse(lotNoShortSelected) == 1)
                {

                    if (String.IsNullOrEmpty(lot1_txt.Text.ToString()))
                    {
                        errorProvider1.SetError(lot1_txt, "Enter Lot No");
                        return;
                    }

                }
                if (int.Parse(lotNoShortSelected) == 2)
                {

                    if (String.IsNullOrEmpty(lot2_txt.Text.ToString()))
                    {
                        errorProvider1.SetError(lot2_txt, "Enter Lot No");
                        return;
                    }
                    
                }
                if (int.Parse(lotNoShortSelected) == 3)
                {
                    if (String.IsNullOrEmpty(lot3_txt.Text.ToString()))
                    {
                        errorProvider1.SetError(lot3_txt, "Enter Lot No");
                        return;
                    }
                }
                if (int.Parse(lotNoShortSelected) == 4)
                {
                    if (String.IsNullOrEmpty(lot4_txt.Text.ToString()))
                    {
                        errorProvider1.SetError(lot4_txt, "Enter Lot No");
                        return;
                    }
                }
                if (int.Parse(lotNoShortSelected) == 5)
                {
                    if (String.IsNullOrEmpty(lot5_txt.Text.ToString()))
                    {
                        errorProvider1.SetError(lot5_txt, "Enter Lot No");
                        return;
                    }
                }
           }




            if(String.Equals(isTransportSetails,"YES"))
            {
                
                if (String.IsNullOrEmpty(ORIGIN))
                {
                    errorProvider1.SetError(goodEntryOriginTxt, "Please Enter Origin");
                    return;
                }
                if (String.IsNullOrEmpty(VEHICLE_NO))
                {
                    errorProvider1.SetError(vehicleNoTxt, "Please Enter Truck No");
                    return;
                }
                if (String.IsNullOrEmpty(FARE_RATE))
                {
                    errorProvider1.SetError(fareRateTxt, "Please Enter Fare Rate");
                    return;
                }
            }
            GoodsEntryDataLoad goodsEntryDataLoad = new GoodsEntryDataLoad();
            if (goodsEntryDataLoad.saveGoodsEntryData(TRDR_ID,ITEM_NAME,WT_BOX_TYPE,WT_TXT,LOT_1,LOT_2,LOT_3,LOT_4,LOT_5,LOGISTIC_DETAILS,SHORT_BOX,
                QTY_RCVD, ORIGIN, VEHICLE_NO, FARE_RATE, TOTAL_FARE, RECV_DATE, TRDR_FNAME_TMARK, LOT_NO_SHORT))
            {
                MessageBox.Show("Goods Entry Saved Successfully");
                GoodsEntry goodsEntry = new GoodsEntry();
                goodsEntry.Show();
                this.Close();
                
            }
            else
                MessageBox.Show("Goods Entry Not Saved");
           
            

        }

    

        private void goodsEntryResetBtn_Click(object sender, EventArgs e)
        {
            GoodsEntry goodsEntry = new GoodsEntry();
            goodsEntry.Show();
            this.Close();
        }

        private void lot1_txt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!(String.IsNullOrEmpty(lot1_txt.Text.Trim())))
                lot1 = int.Parse(lot1_txt.Text.Trim());
            else
                lot1 = 0;
            totallotCount_txt.Text =GetTotalLotCount().ToString();
             
        }

        private void lot2_txt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!(String.IsNullOrEmpty(lot2_txt.Text.Trim())))
                lot2 = int.Parse(lot2_txt.Text.Trim());
            else
                lot2 = 0;
            totallotCount_txt.Text = GetTotalLotCount().ToString();
        }

        private void wtTxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void lot3_txt_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(lot3_txt.Text.Trim())))
                lot3 = int.Parse(lot3_txt.Text.Trim());
            else
                lot3 = 0;
            totallotCount_txt.Text = GetTotalLotCount().ToString();
        }

        private void lot4_txt_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(lot4_txt.Text.Trim())))
                lot4 = int.Parse(lot4_txt.Text.Trim());
            else
                lot4 = 0;
            totallotCount_txt.Text = GetTotalLotCount().ToString();
        }

        private void lot5_txt_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(lot5_txt.Text.Trim())))
                lot5 = int.Parse(lot5_txt.Text.Trim());
            else
                lot5 = 0;
            totallotCount_txt.Text = GetTotalLotCount().ToString();
        }

        private void goodEntryOriginTxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void vehicleNoTxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void fareRateTxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            String totLotCnt=totallotCount_txt.Text.ToString();

            if (String.IsNullOrEmpty(totLotCnt))
            {
                MessageBox.Show("Enter Lot Details First");
                lot1_txt.Focus();
                fareRateTxt.Clear();
            }
            else
            {
                int fareRate=0;
                if(!String.IsNullOrEmpty(fareRateTxt.Text.ToString()))
                  fareRate  =int.Parse(fareRateTxt.Text.ToString());
                totalFareTxt.Text=getTotalFare(int.Parse(totLotCnt),fareRate).ToString();
            }
        }

        private void shortBoxTxt_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(shortBoxTxt.Text.Trim())))
                shortBox = int.Parse(shortBoxTxt.Text.Trim());
            else
                shortBox = 0;
            totallotCount_txt.Text = GetTotalLotCount().ToString();
        }

        private void lotNoShortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lotNoShortSelected = lotNoShortComboBox.SelectedItem.ToString();
           
        }

        private void totallotCount_txt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

       

        
    }
}
