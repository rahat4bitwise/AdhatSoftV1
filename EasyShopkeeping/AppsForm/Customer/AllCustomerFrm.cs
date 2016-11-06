using EasyShopkeeping.DAO.DataUtility;
using EasyShopkeeping.Utility;
using EasyShopkeeping.Utility.ExportDocument;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopkeeping.AppsForm.Customer
{
    public partial class AllCustomerFrm : Form
    {
        String custImgLoc;
        Validation validate = new Validation();
        String tableName = "customer_data";
        String[] columnsToPull = new String[] { "CUST_FNAME", "CUST_LNAME", "CUST_MOB", "CUST_EMAIL", "CUST_STATE", "CUST_DISTRICT", "CUST_AREA", "CUST_IMG_LOC", "CUST_IMG_FILENAME","CUST_ID" };
        String[] columnNameToDisplay = new String[] { "First Name", "Last Name", "Mobile No", "Email", "State", "District", "Area", "ImageLoc", "FileName" };
        int[] columnIndexToHide = new int[] { 7,8,9};
        FillDataGridView fillData = new FillDataGridView();
        ToExcel toExcel = new ToExcel();
        public AllCustomerFrm()
        {
            InitializeComponent();
        }

        private void AllCustomer_Load(object sender, EventArgs e)
        {

            fillData.fillDataGridView(this.customerDataGridView, this.tableName, this.columnsToPull,this.columnNameToDisplay,this.columnIndexToHide);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Minimized;
        }

        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            custImgLoc = "";
            updateProfilePicBtn.Visible = false;
            SaveBtn.Visible = false;
            firstName.ReadOnly = true;
            lastName.ReadOnly = true;
            mobile.ReadOnly = true;
            email.ReadOnly = true;
            state.ReadOnly = true;
            district.ReadOnly = true;
            area.ReadOnly = true;
            profiepictureBox.Image = Properties.Resources.profileImg;
            SaveBtn.Visible = false;
            if (e.RowIndex >= 0)
            {
                firstName.Text = this.customerDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                lastName.Text = this.customerDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                mobile.Text = this.customerDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                email.Text = this.customerDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                state.Text = this.customerDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                district.Text = this.customerDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                area.Text = this.customerDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                imgLoc.Text = this.customerDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                fileName.Text = this.customerDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                custId.Text = this.customerDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            if(!(String.IsNullOrEmpty(imgLoc.Text.ToString())) && !(String.IsNullOrEmpty(fileName.Text.ToString())))
            {
                try {
                    String file = AppConstant.IMG_TRAGET_PATH +"/"+ fileName.Text.ToString();
                    if (File.Exists(file))
                    {
                        Image image = Image.FromFile(file);
                        profiepictureBox.Image = image;
                    }
                    else
                        MessageBox.Show("SomeOne has deleted the profile pic\nCheck the file at:\n" + file);
                    
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                
            }
        }

        private void editButn_Click(object sender, EventArgs e)
        {
            updateProfilePicBtn.Visible = true;
            SaveBtn.Visible = true;
            firstName.ReadOnly = false;
            lastName.ReadOnly = false;
            mobile.ReadOnly = false;
            email.ReadOnly = false;
            state.ReadOnly = false;
            district.ReadOnly = false;
            area.ReadOnly = false;
           
        }

        private void updateProfilePicBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                profiepictureBox.Image = new Bitmap(open.FileName);
                // image file path
                custImgLoc = open.FileName;

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            String CUST_FNAME = firstName.Text.ToString();
            String CUST_LNAME = lastName.Text.ToString();
            String CUST_MOB = mobile.Text.ToString();
            String CUST_EMAIL = email.Text.ToString();
            String CUST_STATE = state.Text.ToString();
            String CUST_DISTRICT = district.Text.ToString(); ;
            String CUST_AREA = area.Text.ToString(); ;
            String CUST_IMG_LOC = custImgLoc;
            String CUST_ID = custId.Text.ToString();
            if (string.IsNullOrEmpty(CUST_FNAME))
            {
                errorProvider1.SetError(firstName, "FirstName required!");
                firstName.Focus();
                return;

            }

            else if (!(validate.IsAlpha(CUST_FNAME)))
            {
                errorProvider1.SetError(firstName, "FirstName Should be albhabet!");
                firstName.Clear();
                firstName.Focus();
                return;
            }
            else if (!(String.IsNullOrEmpty(CUST_LNAME)) && !(validate.IsAlpha(CUST_LNAME)))
            {
                errorProvider1.SetError(lastName, "LastName Should be albhabet!");
                lastName.Clear();
                lastName.Focus();
                return;
            }
            else if (!(String.IsNullOrEmpty(CUST_MOB)) && !(validate.IsNumeric(CUST_MOB)))
            {

                errorProvider1.SetError(mobile, "Mobile No Should be Numeric");
                mobile.Clear();
                mobile.Focus();
                return;
            }
            else if (!(String.IsNullOrEmpty(CUST_MOB)) && !(CUST_MOB.Length == 10))
            {
                errorProvider1.SetError(mobile, "Mobile No Should contain 10 Digit");
                mobile.Clear();
                mobile.Focus();
                return;

            }
            else if (!(String.IsNullOrEmpty(CUST_EMAIL)) && !(validate.IsValidEmail(CUST_EMAIL)))
            {

                errorProvider1.SetError(email, "Email Is not Valid");
                email.Clear();
                email.Focus();
                return;
            }

            else if (String.IsNullOrEmpty(CUST_STATE))
            {
                errorProvider1.SetError(state, "Enter State!");
                return;
            }

            else if (String.IsNullOrEmpty(CUST_DISTRICT))
            {
                errorProvider1.SetError(district, "Enter District!");
                return;
            }
            else if (String.IsNullOrEmpty(CUST_AREA))
            {
                errorProvider1.SetError(area, "Enter Area!");
                return;
            }


            CustomerDataLoad customerDataLoad = new CustomerDataLoad();
            if (!(String.IsNullOrEmpty(custImgLoc)))
            {
                MessageBox.Show(custImgLoc);
                if (customerDataLoad.updateCustomerData(CUST_FNAME, CUST_LNAME, CUST_MOB, CUST_EMAIL, CUST_STATE, CUST_DISTRICT, CUST_AREA, CUST_IMG_LOC,CUST_ID))
                {
                    MessageBox.Show("Customer Data Updated Successfully");
                    fillData.fillDataGridView(this.customerDataGridView, this.tableName, this.columnsToPull, this.columnNameToDisplay, this.columnIndexToHide);
                    disableCustDetailsEditable();
                }
                else
                    MessageBox.Show("Error!! Customer Data Not Updated");
            }
            else
            {
                CUST_IMG_LOC = "";
                if (customerDataLoad.updateCustomerData(CUST_FNAME, CUST_LNAME, CUST_MOB, CUST_EMAIL, CUST_STATE, CUST_DISTRICT, CUST_AREA,CUST_IMG_LOC,CUST_ID))
                {
                    MessageBox.Show("Customer Data Updated Successfully");
                    fillData.fillDataGridView(this.customerDataGridView, this.tableName, this.columnsToPull, this.columnNameToDisplay, this.columnIndexToHide);
                    disableCustDetailsEditable();
                }
                else
                    MessageBox.Show("Error!! Customer Data Not Updated");
            }
 
           
            
        }

        public void disableCustDetailsEditable()
        {
            updateProfilePicBtn.Visible = false;
            SaveBtn.Visible = false;
            firstName.ReadOnly = true;
            lastName.ReadOnly = true;
            mobile.ReadOnly = true;
            email.ReadOnly = true;
            state.ReadOnly = true;
            district.ReadOnly = true;
            area.ReadOnly = true;

        }

        private void firstName_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void lastName_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void mobile_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void email_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void state_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void district_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void area_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fillData.fillDataGridView(this.customerDataGridView, this.tableName, this.columnsToPull, this.columnNameToDisplay, this.columnIndexToHide,"CUST_FNAME",searchText.Text);
        }

        private void exportToExcelBtn_Click(object sender, EventArgs e)
        {
            int[] columnsIndexPrinted = { 9,0,1,2,3,4,5,6 };
            toExcel.exportToExcel(this.customerDataGridView, "AllCustomerDetails", columnsIndexPrinted);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure to Delete", "Delete the customer details", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataDeleteUtility dataDeleteUtility = new DataDeleteUtility();
                String CUST_ID = custId.Text.ToString();
                String delteQuery = "delete from customer_data where CUST_ID='" + CUST_ID + "'";
                if(dataDeleteUtility.deleteRow(delteQuery))
                {
                    MessageBox.Show("Cutomer Data Deleted Successfully");
                    fillData.fillDataGridView(this.customerDataGridView, this.tableName, this.columnsToPull, this.columnNameToDisplay, this.columnIndexToHide);
                }
                else
                {
                    MessageBox.Show("Error!! Cutomer Data Not Deleted Successfully");
                }


            }
        }

    }
}
