using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EasyShopkeeping.FormData.FormInterface;
using EasyShopkeeping.FormData.Customer;
using EasyShopkeeping.AppsForm.General;
using MySql.Data.MySqlClient;
using EasyShopkeeping.Utility;
namespace EasyShopkeeping.AppsForm.Customer
{
    public partial class AddCustomerFrm : Form,GetFormInput
    {

        String stateSelected;
        String distSelected;
        String areaSelected;
        String custImgLoc;
        Validation validate = new Validation();
        public AddCustomerFrm()
        {
            InitializeComponent();
            
        }


        private void AddCustomer_Load(object sender, EventArgs e)
        {
           
           //String stringName=AppConstant.IMG_TRAGET_PATH+"\\geet20160905.jpeg";
           //profilepictureBox.Image = new Bitmap(stringName);
            custFirstName.Focus();
           
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.OpenFile();  
        }

        private void addProfileImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                profilepictureBox.Image = new Bitmap(open.FileName);
                // image file path
                custImgLoc = open.FileName;

            } 
        }


        private void addCustomerSaveBtn_Click(object sender, EventArgs e)
        {
            String CUST_FNAME = custFirstName.Text.ToString();
            String CUST_LNAME = custLastName.Text.ToString();
            String CUST_MOB = custMobile.Text.ToString();
            String CUST_EMAIL = custEmail.Text.ToString();
            String CUST_STATE = stateSelected;
            String CUST_DISTRICT = distSelected;
            String CUST_AREA = areaSelected;
            String CUST_IMG_LOC = custImgLoc; ;
            if (string.IsNullOrEmpty(CUST_FNAME))
            {
                errorProvider1.SetError(custFirstName, "FirstName required!");
                custFirstName.Focus();
                custFirstName.Clear();
                return;

            }
            else if (Validation.IsContainSPace((CUST_FNAME)))
            {
                errorProvider1.SetError(custFirstName, "Enter First Name Without Space");
                custFirstName.Clear();
                custFirstName.Focus();
                return;
            }
            else if (!(validate.IsAlpha(CUST_FNAME)))
            {
                errorProvider1.SetError(custFirstName, "FirstName Should be albhabet!");
                custFirstName.Clear();
                custFirstName.Focus();
                return;
            }
            else if (!(String.IsNullOrEmpty(CUST_LNAME)) && !(validate.IsAlpha(CUST_LNAME)))
            {
                errorProvider1.SetError(custLastName, "LastName Should be albhabet!");
                custLastName.Clear();
                custLastName.Focus();
                return;
            }
            else if (!(String.IsNullOrEmpty(CUST_MOB)) && !(validate.IsNumeric(CUST_MOB)))
            {

                errorProvider1.SetError(custMobile, "Mobile No Should be Numeric");
                custMobile.Clear();
                custMobile.Focus();
                return;
            }
            else if (!(String.IsNullOrEmpty(CUST_MOB)) && !(CUST_MOB.Length == 10))
            {
                errorProvider1.SetError(custMobile, "Mobile No Should contain 10 Digit");
                custMobile.Clear();
                custMobile.Focus();
                return;

            }
            else if (!(String.IsNullOrEmpty(CUST_EMAIL)) && !(validate.IsValidEmail(CUST_EMAIL)))
            {

                errorProvider1.SetError(custEmail, "Email Is not Valid");
                custEmail.Clear();
                custEmail.Focus();
                return;
            }

            else if (String.IsNullOrEmpty(CUST_STATE))
            {
                errorProvider1.SetError(custStateComboBox, "Select State!");
                return;
            }

            else if (String.IsNullOrEmpty(CUST_DISTRICT))
            {
                errorProvider1.SetError(custDistrictComboBox, "Select District!");
                return;
            }
            else if (String.IsNullOrEmpty(CUST_AREA))
            {
                errorProvider1.SetError(custAreaComboBox, "Select Area!");
                return;
            }


            CustomerDataLoad customerDataLoad = new CustomerDataLoad();
            if (customerDataLoad.saveCustomerData(CUST_FNAME, CUST_LNAME, CUST_MOB, CUST_EMAIL, CUST_STATE, CUST_DISTRICT, CUST_AREA, CUST_IMG_LOC))
            {
                MessageBox.Show("Customer Data Saved Successfully");
            }
            else
                MessageBox.Show("Customer Data Not Saved");
           
 
            
            
        }




        #region GetFormInput Members

        public string[] getFormInputParameter()
        {
            StringBuilder formData = new StringBuilder();
            formData.Append(custFirstName.Text);
            formData.Append(custLastName.Text);
            formData.Append(custMobile.Text);
            formData.Append(custEmail.Text);
            formData.Append(custAreaComboBox.Text);
            return formData.ToString().Split('|'); ;

        }

        #endregion

        #region GetFormInput Members

        string[] GetFormInput.getFormInputParameter()
        {
            
            
            StringBuilder formData = new StringBuilder();
            formData.Append(custFirstName.Text+"|");
            formData.Append(custLastName.Text + "|");
            formData.Append(custMobile.Text + "|");
            formData.Append(custEmail.Text + "|");
            formData.Append(custAddGroupBox.Text + "|");
            formData.Append(custAreaComboBox.Text + "|");
            formData.Append(custDistrictComboBox.Text + "|");
            formData.Append(custStateComboBox.Text);
            String s = formData.ToString();
            return s.Split('|');
            
        }

        #endregion


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void custStateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            stateSelected=custStateComboBox.SelectedItem.ToString();
            custDistrictComboBox.Items.Clear();
            try
            {

                FillFormWithData comboboxDataReader = new FillFormWithData();
                MySqlDataReader reader = comboboxDataReader.getDataInComboBox("district", "DISTRICT_NAME", "STATE_NAME", stateSelected);
                while (reader.Read())
                {
                    custDistrictComboBox.Items.Add(reader.GetString("DISTRICT_NAME"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void custDistrictComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            distSelected = custDistrictComboBox.SelectedItem.ToString();
            custAreaComboBox.Items.Clear();
            try
            {

                FillFormWithData comboboxDataReader = new FillFormWithData();
                MySqlDataReader reader = comboboxDataReader.getDataInComboBox("area", "AREA_NAME", "STATE_NAME", stateSelected, "DISTRICT_NAME", distSelected);
                while (reader.Read())
                {
                    custAreaComboBox.Items.Add(reader.GetString("AREA_NAME"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void custArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            areaSelected = custAreaComboBox.SelectedItem.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Minimized;
        }

    private void AddCustomerFrm_KeyDown(object sender, KeyEventArgs e)
       
{
    if (e.KeyCode == Keys.Escape)
    {
        this.Close();
    }
}

        private void custFirstName_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void custFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void custLastName_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void custMobile_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void custEmail_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void profilepictureBox_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void addStateBtn_Click(object sender, EventArgs e)
        {

            AddStateFrm addStateFrm = new AddStateFrm();
            addStateFrm.ShowDialog();
        }
        
        private void addDistrictBtn_Click(object sender, EventArgs e)
        {
            AddDistrictFrm addDistrictFrm = new AddDistrictFrm();
            addDistrictFrm.ShowDialog();
        }

        private void addAreaBtn_Click(object sender, EventArgs e)
        {
            AddAreaFrm addAreaFrm = new AddAreaFrm();
            addAreaFrm.ShowDialog();

        }

        private void custStateComboBox_DropDown(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            custStateComboBox.Items.Clear();
            try
            {

                FillFormWithData comboboxDataReader = new FillFormWithData();
                MySqlDataReader reader = comboboxDataReader.getDataInComboBox("state", "STATE_NAME");
                while (reader.Read())
                {
                    custStateComboBox.Items.Add(reader.GetString("STATE_NAME"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void custDistrictComboBox_DropDown(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            stateSelected = custStateComboBox.SelectedItem.ToString();
            custDistrictComboBox.Items.Clear();
            try
            {

                FillFormWithData comboboxDataReader = new FillFormWithData();
                MySqlDataReader reader = comboboxDataReader.getDataInComboBox("district", "DISTRICT_NAME", "STATE_NAME", stateSelected);
                while (reader.Read())
                {
                    custDistrictComboBox.Items.Add(reader.GetString("DISTRICT_NAME"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void custAreaComboBox_DropDown(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            stateSelected = custStateComboBox.SelectedItem.ToString();
            distSelected = custDistrictComboBox.SelectedItem.ToString();
            custAreaComboBox.Items.Clear();
            try
            {

                FillFormWithData comboboxDataReader = new FillFormWithData();
                MySqlDataReader reader = comboboxDataReader.getDataInComboBox("area", "AREA_NAME", "STATE_NAME", stateSelected,"DISTRICT_NAME",distSelected);
                while (reader.Read())
                {
                    custAreaComboBox.Items.Add(reader.GetString("AREA_NAME"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

  
        }

    
}
