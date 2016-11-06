using EasyShopkeeping.AppsForm.Customer;
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
    public partial class AddAreaFrm : Form
    {
        public AddAreaFrm()
        {
            InitializeComponent();
        }
        String stateSelected;
        String distSelected;

        private void addAreaCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void AddArea_Load(object sender, EventArgs e)
        {
            try
            {

                FillFormWithData comboboxDataReader = new FillFormWithData();
                MySqlDataReader reader = comboboxDataReader.getDataInComboBox("state", "STATE_NAME");
                while (reader.Read())
                {
                    addAreaStatecomboBox.Items.Add(reader.GetString("STATE_NAME"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddAreaFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void addAreaSaveBtn_Click(object sender, EventArgs e)
        {
            String STATE = stateSelected;
            String DISTRICT = distSelected;
            String AREA = areaName_Txt.Text.ToString();
            if (String.IsNullOrEmpty(STATE))
            {
                errorProvider1.SetError(addAreaStatecomboBox, "Select State!");
                return;
            }
            if (String.IsNullOrEmpty(DISTRICT))
            {
                errorProvider1.SetError(addAreaDistrictcomboBox, "Select District!");
                return;
            }
            if (String.IsNullOrEmpty(AREA))
            {
                errorProvider1.SetError(areaName_Txt, "Enter Area!");
                return;
            }
            if (Validation.IsContainSPace((AREA)))
            {
                errorProvider1.SetError(areaName_Txt, "Enter Area Without Space");
                return;
            }
            DataLoadUtility dataLoadUtility = new DataLoadUtility();
            String areaId = areaName_Txt.Text.ToString().Substring(0, 2) + areaName_Txt.Text.ToString();
            String sqlQuery = "insert into area values ('" + areaId + "','" + STATE + "','" + DISTRICT + "','" + AREA + "');";
            if (!(dataLoadUtility.insertData(sqlQuery)))
            {
                MessageBox.Show("Area Not Saved");
            }
            else
            {
                MessageBox.Show("Area Saved");
                this.Close();
            }
        }

        private void AreaName_Enter(object sender, EventArgs e)
        {

        }

        private void addAreaStatecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            stateSelected = addAreaStatecomboBox.SelectedItem.ToString();
            addAreaDistrictcomboBox.Items.Clear();
            try
            {

                FillFormWithData comboboxDataReader = new FillFormWithData();
                MySqlDataReader reader = comboboxDataReader.getDataInComboBox("district", "DISTRICT_NAME", "STATE_NAME", stateSelected);
                if (!(reader.HasRows))
                {
                    addAreaDistrictcomboBox.Items.Add("Not Found In Databases");
                    addDistictBtn.Visible = true;
                }
                while (reader.Read())
                {
                    addAreaDistrictcomboBox.Items.Add(reader.GetString("DISTRICT_NAME"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addAreaDistrictcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            distSelected = addAreaDistrictcomboBox.SelectedItem.ToString();
        }

        private void addDistictBtn_Click(object sender, EventArgs e)
        {
            AddDistrictFrm addDistrictFrm = new AddDistrictFrm();
            addDistrictFrm.Show();
            this.Close();
        }
    }
}
