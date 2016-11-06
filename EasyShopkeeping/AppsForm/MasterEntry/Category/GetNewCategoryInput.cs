using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EasyShopkeeping.Utility;

namespace EasyShopkeeping
{
    public partial class GetNewCategoryInput : Form
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public GetNewCategoryInput()
        {
                      
        }
        DataGridView dataGridView;
        public GetNewCategoryInput(DataGridView dataGridView)
        {
            InitializeComponent();

            this.dataGridView=dataGridView;
            

        }

        FillDataGridView fillData = new FillDataGridView();
        Validation validate = new Validation();  
        private void GetNewCategoryInput_Load(object sender, EventArgs e)
        {
            this.ctgry_Txt.Focus();


        }

        private void saveCategoryBtn_Click(object sender, EventArgs e)
        {
            InsertCategory insertCategory = new InsertCategory();

            if (!(validate.IsBlank(ctgry_Txt.Text)))
            {
                if (insertCategory.insertCategory(ctgry_Txt.Text))
                {
                    //ctgry_Txt.Text = " ";
                    fillData.fillDataGridView(this.dataGridView);
                    MessageBox.Show("Category:" + ctgry_Txt.Text + " is added to Database");
                    this.ctgry_Txt.Focus();
                    ctgry_Txt.Text = "";
                }
                else
                {
                    MessageBox.Show("Error!! Category:" + ctgry_Txt.Text + " is not added to Database");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Category Name");
            }

        }

        
    }
}
