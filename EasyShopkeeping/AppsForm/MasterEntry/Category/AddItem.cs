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

namespace EasyShopkeeping.AppsForm.MasterEntry.Category
{
    public partial class AddItem : Form
    {

        String itemCategorySelected;
        public AddItem()
        {
            InitializeComponent();
        }

        private void addItemSaveBtn_Click(object sender, EventArgs e)
        {
            String ITEM_CATEGORY = itemCategorySelected;
            String ITEM_NAME = itemNameTxt.Text.ToString();
            if (String.IsNullOrEmpty(ITEM_CATEGORY))
            {
                errorProvider1.SetError(addItemCategorycomboBox, "Select Item Category First !");
                return;
            }
            if (String.IsNullOrEmpty(ITEM_NAME))
            {
                errorProvider1.SetError(itemNameTxt, "Enter Item Name");
                return;
            }
            DataLoadUtility dataLoadUtility = new DataLoadUtility();
            String ITEM_ID = GenerateUniqueID.RandomString(5);
            String sqlQuery = "insert into item_details values ('" + ITEM_ID + "','" + ITEM_NAME + "','" + ITEM_CATEGORY + "');";
            if (!(dataLoadUtility.insertData(sqlQuery)))
            {
                MessageBox.Show("Item  Not Saved");
            }
            else
            {
                MessageBox.Show("Item Saved");
                this.Close();
            }


        }

        private void addItemCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemNameTxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void AddItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void addItemCategorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            itemCategorySelected = addItemCategorycomboBox.SelectedItem.ToString();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            try
            {

                FillFormWithData comboboxDataReader = new FillFormWithData();
                MySqlDataReader reader = comboboxDataReader.getDataInComboBox("product_category", "PRODUCT_CATEGORY_NAME");
                if(!(reader.HasRows))
                {
                    addItemCategorycomboBox.Items.Add("Not Found In Databases");
                }
                while (reader.Read())
                {
                    addItemCategorycomboBox.Items.Add(reader.GetString("PRODUCT_CATEGORY_NAME"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
