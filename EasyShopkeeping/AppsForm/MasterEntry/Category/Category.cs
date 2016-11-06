using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EasyShopkeeping.DAO.DataUtility;
using EasyShopkeeping.Utility.ExportDocument;

namespace EasyShopkeeping
{
    public partial class Category : Form
    {
        String ctgry_Id;
        String ctgry_Name;
        static int cnt=0;
        FillDataGridView fillData = new FillDataGridView();
        ToExcel toExcel = new ToExcel();
        public Category()
        {
            InitializeComponent();
           
        }

        private void Category_Load(object sender, EventArgs e)
        {
            fillData.fillDataGridView(this.dataGridView1);
            if (dataGridView1.Rows.Count > 0)
            {
                //Bind your grid here
                message_label.Visible = false;
            }
            else
            {
                message_label.Visible = true; // label for "Record Not Found"

            }

            //ctgry_Id = this.dataGridView1.Rows[0].Cells[0].Value.ToString();
            //ctgry_Txt.Text = this.dataGridView1.Rows[0].Cells[1].Value.ToString();
        }



        private void newCtgry_Btn_Click(object sender, EventArgs e)
        {
            GetNewCategoryInput getNewCategoryInput = new GetNewCategoryInput(this.dataGridView1);

            getNewCategoryInput.Show();
        }

        private void getCategoryView_Click(object sender, EventArgs e)
        {
            ctgry_Txt.Text = "";
            fillData.fillDataGridView(this.dataGridView1);
            if (dataGridView1.Rows.Count > 0)
            {
                //Bind your grid here
                message_label.Visible = false;
            }
            else
            {
                message_label.Visible = true; // label for "Record Not Found"
               
            }
        }

        

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(ctgry_Txt.Text))
            {
                MessageBox.Show("Please Enter Category Name");                  
                
            }
            else
            {
                 InsertCategory insertCategory = new InsertCategory();
                if (insertCategory.insertCategory(ctgry_Txt.Text))
                {
                   
                    fillData.fillDataGridView(this.dataGridView1);
                    MessageBox.Show("Category:" + ctgry_Txt.Text + " is added to Database");
                    ctgry_Txt.Text = "";
                }
                else
                {
                    MessageBox.Show("Error!! Category:" + ctgry_Txt.Text + " is not added to Database");
                }  
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
            if (string.IsNullOrEmpty(ctgry_Id) || string.IsNullOrEmpty(ctgry_Txt.Text))
            {
                MessageBox.Show("Oops Category is not selected !! Click on Category"); 
            }
            else
                {
                    DialogResult dialogResult = MessageBox.Show("Are You Sure To Delete ", "Deleting Category", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                   
                    DeleteCategory deleteCategory = new DeleteCategory();
                if (deleteCategory.deleteCategory(ctgry_Id))
                {
                    MessageBox.Show("Category " + ctgry_Txt.Text + " is Deleted from Database");
                    cnt = 0;
                    fillData.fillDataGridView(this.dataGridView1);
                    ctgry_Txt.Text = "";
                }
                else
                {
                    MessageBox.Show("Error!! Category:" + ctgry_Txt.Text + " is not Deleted from Database");
                }
                    }   
                
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ctgry_Id) || string.IsNullOrEmpty(ctgry_Txt.Text))
            {
                MessageBox.Show("Oops Category is not selected !! Click on Category");
            }

            else
                
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure ", "Deleting Category", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    UpdateCategory updateCategory = new UpdateCategory();
                    if (updateCategory.updateCategory(ctgry_Id, ctgry_Txt.Text))
                    {

                        MessageBox.Show("Category is Updated to Database");
                        cnt = 0;
                        fillData.fillDataGridView(this.dataGridView1);
                        ctgry_Txt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error!! Category:" + ctgry_Txt.Text + " is not Updated to Database");
                    }
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


        private void exportToExcelBtn_Click(object sender, EventArgs e)
        {
            //DatGridView ColumnIndex Starts from 0 index
            //SPecify the column index of DataGrid to be exported sto Excel Sheet
            int [] columnsIndexPrinted={1};
            toExcel.exportToExcel(this.dataGridView1, "CategoryList", columnsIndexPrinted);
        }

        private void dataGridView1_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
      
    }
}
