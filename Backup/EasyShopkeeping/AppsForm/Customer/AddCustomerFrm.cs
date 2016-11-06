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

namespace EasyShopkeeping.AppsForm.Customer
{
    public partial class AddCustomerFrm : Form,GetFormInput
    {
        public AddCustomerFrm()
        {
            InitializeComponent();
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
                custImgLocation.Text = open.FileName;
            } 
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void addCustomerSaveBtn_Click(object sender, EventArgs e)
        {
           String [] FormInput= getFormInputParameter();
           for (int i = 0; i < FormInput.Length; i++)
               MessageBox.Show(FormInput[i]);
            AddCustomer addCustomer = new AddCustomerFrm();
           
        }




        #region GetFormInput Members

        public string[] getFormInputParameter()
        {
            StringBuilder formData = new StringBuilder();
            formData.Append(custFirstName.Text);
            formData.Append(custLastName.Text);
            formData.Append(custMobile.Text);
            formData.Append(custEmail.Text);
            formData.Append(custArea.Text);

        }

        #endregion

        #region GetFormInput Members

        string[] GetFormInput.getFormInputParameter()
        {
            
            
            StringBuilder formData = new StringBuilder();
            formData.Append(custFirstName.txt+"|");
            formData.Append(custLastName.txt + "|");
            formData.Append(custMobile.txt + "|");
            formData.Append(custEmail.txt + "|");
            formData.Append(custAddGroupBox.txt + "|");
            formData.Append(custArea.txt + "|");
            formData.Append(custSubArea.txt + "|");
            formData.Append(custDistrict.txt + "|");
            formData.Append(custState.txt);
            String s = formData.ToString;
            return s.Split('|');
            
        }

        #endregion
    }
}
