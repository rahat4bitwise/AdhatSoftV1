using EasyShopkeeping.AppsForm.Customer;
using EasyShopkeeping.Utility;
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
    public partial class AddStateFrm : Form
    {
        public AddStateFrm()
        {
            InitializeComponent();   
        }
     

        private void addStateSaveBtn_Click(object sender, EventArgs e)
        {
            String STATE = stateName_Txt.Text.ToString();
            if (String.IsNullOrEmpty(STATE))
            {
                errorProvider1.SetError(stateName_Txt, "Enter State!");
                return;
            }
            if (Validation.IsContainSPace((STATE)))
            {
                errorProvider1.SetError(stateName_Txt, "Enter Stace Without Space");
                return;
            }
            DataLoadUtility dataLoadUtility = new DataLoadUtility();
            String stateId = stateName_Txt.Text.ToString().Substring(0, 2) + stateName_Txt.Text.ToString();
            String sqlQuery = "insert into state values ('" + stateId + "','" + STATE + "');";
            if (!(dataLoadUtility.insertData(sqlQuery)))
            {
                MessageBox.Show("State Not Saved");
            }
            else
            {
                MessageBox.Show("State Saved");
               
                this.Close();
            }
        }

        private void addStateCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StateName_Enter(object sender, EventArgs e)
        {

        }

        private void AddStateFrm_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void stateName_Txt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

    }
}
