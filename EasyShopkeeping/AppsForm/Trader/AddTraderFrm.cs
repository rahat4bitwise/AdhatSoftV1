using EasyShopkeeping.Utility;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopkeeping.AppsForm.Trader
{
    public partial class AddTraderFrm : Form
    {
        String stateSelected;
        String distSelected;
        Validation validate = new Validation();
        public AddTraderFrm()
        {
            InitializeComponent();
        }

        private void AddTraderFrm_KeyDown(object sender, KeyEventArgs e)
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

        private void AddTraderFrm_Load(object sender, EventArgs e)
        {
            try
            {

                FillFormWithData comboboxDataReader = new FillFormWithData();
                MySqlDataReader reader = comboboxDataReader.getDataInComboBox("state", "STATE_NAME");
                if (!(reader.HasRows))
                {
                    traderStateComboBox.Items.Add("Not Found In Databases");
                }
                while (reader.Read())
                {
                    traderStateComboBox.Items.Add(reader.GetString("STATE_NAME"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void traderStateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            stateSelected = traderStateComboBox.SelectedItem.ToString();
            traderDistComboBox.Items.Clear();
            try
            {

                FillFormWithData comboboxDataReader = new FillFormWithData();
                MySqlDataReader reader = comboboxDataReader.getDataInComboBox("district", "DISTRICT_NAME", "STATE_NAME", stateSelected);
                if (!(reader.HasRows))
                {
                    traderDistComboBox.Items.Add("Not Found In Databases");
                }
                while (reader.Read())
                {
                    traderDistComboBox.Items.Add(reader.GetString("DISTRICT_NAME"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void traderDistComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            distSelected = traderDistComboBox.SelectedItem.ToString();
        }

        private void addCustomerSaveBtn_Click(object sender, EventArgs e)
        {
            String TRDR_FNAME = traderFirstNameTxt.Text.ToString();
            String TRDR_LNAME = traderLastNameTxt.Text.ToString();
            String TRDR_MOB = traderMobileTxt.Text.ToString();
            String TRDR_EMAIL = traderEmailTxt.Text.ToString();
            String TRDR_TMARK = traderTradeMartTxt.Text.ToString();
            String TRDR_STATE = stateSelected;
            String TRDR_DISTRICT = distSelected;
            String TRDR_PIN = traderPinTxt.Text.ToString();

            if (string.IsNullOrEmpty(TRDR_FNAME))
            {
                errorProvider1.SetError(traderFirstNameTxt, "FirstName required!");
                traderFirstNameTxt.Focus();
                return;

            }

            else if (!(validate.IsAlpha(TRDR_FNAME)))
            {
                errorProvider1.SetError(traderFirstNameTxt, "FirstName Should be albhabet!");
                traderFirstNameTxt.Clear();
                traderFirstNameTxt.Focus();
                return;
            }
            else if (!(String.IsNullOrEmpty(TRDR_LNAME)) && !(validate.IsAlpha(TRDR_LNAME)))
            {
                errorProvider1.SetError(traderLastNameTxt, "LastName Should be albhabet!");
                traderLastNameTxt.Clear();
                traderLastNameTxt.Focus();
                return;
            }
            else if (!(String.IsNullOrEmpty(TRDR_MOB)) && !(validate.IsNumeric(TRDR_MOB)))
            {

                errorProvider1.SetError(traderMobileTxt, "Mobile No Should be Numeric");
                traderMobileTxt.Clear();
                traderMobileTxt.Focus();
                return;
            }
            else if (!(String.IsNullOrEmpty(TRDR_MOB)) && !(TRDR_MOB.Length == 10))
            {
                errorProvider1.SetError(traderMobileTxt, "Mobile No Should contain 10 Digit");
                traderMobileTxt.Clear();
                traderMobileTxt.Focus();
                return;

            }
            else if (!(String.IsNullOrEmpty(TRDR_EMAIL)) && !(validate.IsValidEmail(TRDR_EMAIL)))
            {

                errorProvider1.SetError(traderEmailTxt, "Email Is not Valid");
                traderEmailTxt.Clear();
                traderEmailTxt.Focus();
                return;
            }

            else if (String.IsNullOrEmpty(TRDR_STATE))
            {
                errorProvider1.SetError(traderStateComboBox, "Select State!");
                return;
            }

            else if (String.IsNullOrEmpty(TRDR_DISTRICT))
            {
                errorProvider1.SetError(traderDistComboBox, "Select District!");
                return;
            }

            else if (String.IsNullOrEmpty(TRDR_PIN))
            {
                errorProvider1.SetError(traderPinTxt, "Enter Pin Code!");
                return;
            }
            else if (String.IsNullOrEmpty(TRDR_TMARK))
            {
                errorProvider1.SetError(traderTradeMartTxt, "Enter TradeMark!");
                return;
            }

            TraderDataLoad tarderDataLoad = new TraderDataLoad();
            if (tarderDataLoad.saveTraderData(TRDR_FNAME, TRDR_LNAME, TRDR_MOB, TRDR_EMAIL, TRDR_TMARK, TRDR_STATE, TRDR_DISTRICT, TRDR_PIN))
            {
                MessageBox.Show("Trader Data Saved Successfully");
            }
            else
                MessageBox.Show("Trader Data Not Saved");
           
 
            
        }

        private void traderPinTxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void traderTradeMartTxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

       
    }
}
