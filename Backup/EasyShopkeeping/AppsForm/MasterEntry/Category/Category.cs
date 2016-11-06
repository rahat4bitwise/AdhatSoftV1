using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EasyShopkeeping.DAO.DataUtility;

namespace EasyShopkeeping
{
    public partial class Category : Form
    {
        String ctgry_Id;
        String ctgry_Name;
        static int cnt=0;
        FillDataGridView fillData = new FillDataGridView();
        public Category()
        {
            InitializeComponent();
           
        }

        private void Category_Load(object sender, EventArgs e)
        {
           
        }



        private void newCtgry_Btn_Click(object sender, EventArgs e)
        {
            GetNewCategoryInput getNewCategoryInput = new GetNewCategoryInput(this.dataGridView1);

            getNewCategoryInput.Show();
        }

        private void getCategoryView_Click(object sender, EventArgs e)
        {
            ctgry_Txt.Text = "";
            deleteBtn.Enabled = true;
            updateBtn.Enabled = true;
            saveBtn.Enabled = false;
            
            //fillDataGridView.fillDataGridView(this.dataGridView1);
            fillData.fillDataGridView(this.dataGridView1);
        }

        

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            InsertCategory insertCategory = new InsertCategory();
            if (ctgry_Txt.Text != "")
            {
                if (insertCategory.insertCategory(ctgry_Txt.Text))
                {
                    ctgry_Txt.Text = " ";
                    fillData.fillDataGridView(this.dataGridView1);
                    MessageBox.Show("Category:" + ctgry_Txt.Text + " is added to Database");
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
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Getting ctgry_Id
            ctgry_Id = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            ctgry_Txt.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
           
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (ctgry_Id != "")
            {
                DeleteCategory deleteCategory = new DeleteCategory();
                if (deleteCategory.deleteCategory(ctgry_Id))
                {
                    ctgry_Txt.Text = "";
                    MessageBox.Show("Category " + ctgry_Txt.Text + " is Deleted from Database");
                    cnt = 0;
                    
                    fillData.fillDataGridView(this.dataGridView1);
                }
                else
                {
                    MessageBox.Show("Error!! Category:" + ctgry_Txt.Text + " is not Deleted from Database");
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if ((ctgry_Txt.Text == ctgry_Name) || (ctgry_Txt.Text == " "))
            {
                MessageBox.Show("Please Update With New Value");
            }

             if ((ctgry_Txt.Text != "") && (ctgry_Txt.Text != ctgry_Name))
                
            {
                UpdateCategory updateCategory = new UpdateCategory();
                if (updateCategory.updateCategory(ctgry_Id, ctgry_Txt.Text))
                {
                    ctgry_Txt.Text = "";
                    MessageBox.Show("Category is Updated to Database");
                    cnt = 0;
                    
                    fillData.fillDataGridView(this.dataGridView1);
                }
                else
                {
                    MessageBox.Show("Error!! Category:" + ctgry_Txt.Text + " is not Updated to Database");
                }
            }
            

        }

        private void ctgry_Txt_TextChanged(object sender, EventArgs e)
        {
            
            if (cnt == 0)
            {
                ctgry_Name = ctgry_Txt.Text;
                cnt = 1;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            fillData.fillDataGridView(this.dataGridView1,seacrchText.Text);
        }

        
      
    }
}
