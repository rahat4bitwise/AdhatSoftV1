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

namespace EasyShopkeeping.AppsForm.General
{
    public partial class AddDistrictFrm : Form
    {
        public AddDistrictFrm()
        {
            InitializeComponent();
        }
        String stateSelected;
        private void addDistrictCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addDistrictSaveBtn_Click(object sender, EventArgs e)
        {
            String STATE = stateSelected;
            String DISTRICT = distName_Txt.Text.ToString();
            if (String.IsNullOrEmpty(STATE))
            {
                errorProvider1.SetError(addDistrictStateComboBox, "Select State!");
                return;
            }
            if (String.IsNullOrEmpty(DISTRICT))
             {
                 errorProvider1.SetError(distName_Txt, "Enter District Name");
                 return;
             }
            if (Validation.IsContainSPace((DISTRICT)))
            {
                errorProvider1.SetError(distName_Txt, "Enter DIstrict Without Space");
                return;
            }
            DataLoadUtility dataLoadUtility = new DataLoadUtility();
            String districtId = distName_Txt.Text.ToString().Substring(0, 2) + distName_Txt.Text.ToString();
            String sqlQuery = "insert into district values ('" + districtId + "','" + STATE + "','"+DISTRICT+"');";
            if (!(dataLoadUtility.insertData(sqlQuery)))
            {
                MessageBox.Show("District Not Saved");
            }
            else
            {
                MessageBox.Show("District Saved");
                this.Close();
            }
        }

        private void AddDistrictFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void AddDistrictFrm_Load(object sender, EventArgs e)
        {
            try
            {

                FillFormWithData comboboxDataReader = new FillFormWithData();
                MySqlDataReader reader = comboboxDataReader.getDataInComboBox("state", "STATE_NAME");
                if (!(reader.HasRows))
                {
                    addDistrictStateComboBox.Items.Add("Not Found In Databases");
                }
                while (reader.Read())
                {
                    addDistrictStateComboBox.Items.Add(reader.GetString("STATE_NAME"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addDistrictStateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            stateSelected = addDistrictStateComboBox.SelectedItem.ToString();
        }
    }
}
