    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace EasyShopkeeping
{
    class FillDataGridView : DataBaseConnection
    {
        MySqlConnection con;
		String queryString;
		DataGridView dataGridView;
        DataBaseConnection dataBaseConnection= new DataBaseConnection();

       
        public void fillDataGridView(DataGridView dataGridView)
        {
            DataGridView dataGridView1 = dataGridView;
            try
            {
                con = dataBaseConnection.getMySqlDBConnection();
                con.Open();
                string getCattegoryQuery = "select * from product_category";
                MySqlCommand cmd = new MySqlCommand(getCattegoryQuery, con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Rows[0].Selected = true;
                //MySqlDataReader reader = cmd.ExecuteReader();
                //MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(getCattegoryQuery, con);
                //DataSet ds = new DataSet();
                //mySqlDataAdapter.Fill(ds, "product_category");
                //dataGridView1.DataSource = ds;
                //dataGridView1.DataMember = "product_category";
                
                
               
                    if(dataGridView1.ColumnCount == 0)
                    { 
                    dataGridView1.ColumnCount = 1;
                    dataGridView1.Columns[0].Name = "No Category Found";
                    string[] row = new string[] { "" };
                    dataGridView1.Rows.Add(row);   
                
                }
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Can not open connection ! " + ex.Message.ToString());
            }
        }
        public void fillDataGridView(DataGridView dataGridView,String searchText)
        {
            DataGridView dataGridView1 = dataGridView;
            try
            {
                con = dataBaseConnection.getMySqlDBConnection();
                con.Open();
                string getCattegoryQuery = "select * from product_category where product_category_name like '" + searchText + "%'";
                MySqlCommand cmd = new MySqlCommand(getCattegoryQuery, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[1].HeaderCell.Value = "Category";
                   

                }
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Excpetion Occured ! " + ex.Message);
            }
        }


         public void fillDataGridView(DataGridView dataGridView,String tableName,String[] columnsToPull,String[] columnNameToDisplay,int[] columnIndexToHide)
        {
            DataGridView dataGridView1 = dataGridView;
            String columnString="";
            for (int i = 0; i < columnsToPull.Length; i++)
            {
                columnString = columnString + " " + columnsToPull[i] + ",";
            }
			columnString=columnString.Remove(columnString.Length-1);
            queryString = "select " + columnString + " from " + tableName;
            fillDataGridView(dataGridView,queryString, columnNameToDisplay, columnIndexToHide);
        }

         public void fillDataGridView(DataGridView dataGridView, String tableName, String[] columnsToPull, String[] columnNameToDisplay, int[] columnIndexToHide,String columnToBeSearch,String searchText )
         {
             DataGridView dataGridView1 = dataGridView;
             String columnString = "";
             for (int i = 0; i < columnsToPull.Length; i++)
             {
                 columnString = columnString + " " + columnsToPull[i] + ",";
             }
             columnString = columnString.Remove(columnString.Length - 1);
             queryString = "select " + columnString + " from " + tableName +" where "+ columnToBeSearch+" like '" + searchText + "%'";
             fillDataGridView(dataGridView,queryString, columnNameToDisplay, columnIndexToHide);
         }

         public void fillDataGridView(DataGridView dataGridView, String tableName, String[] columnsToPull, String[] columnNameToDisplay, int[] columnIndexToHide, String whereCondition)
         {
             this.dataGridView = dataGridView;
             String columnString = "";
             for (int i = 0; i < columnsToPull.Length; i++)
             {
                 columnString = columnString + " " + columnsToPull[i] + ",";
             }
             columnString = columnString.Remove(columnString.Length - 1);
			 queryString = "select " + columnString + " from " + tableName + " where " + whereCondition;

             fillDataGridView(dataGridView,queryString, columnNameToDisplay, columnIndexToHide);
             
         }
         public void fillDataGridView(DataGridView dataGridView, String queryString, String[] columnNameToDisplay, int[] columnIndexToHide,String whereCondition)
         {

             queryString = queryString+ " where " + whereCondition;
             fillDataGridView(dataGridView,queryString, columnNameToDisplay, columnIndexToHide);
         }
  public void fillDataGridView(DataGridView dataGridView, String queryString,String[] columnNameToDisplay, int[] columnIndexToHide)
         {
           
             this.dataGridView = dataGridView;
             fillDataGridView(queryString, columnNameToDisplay, columnIndexToHide);
    }

  public void fillDataGridView(String queryString, String[] columnNameToDisplay, int[] columnIndexToHide)
  {

      try
      {
          con = dataBaseConnection.getMySqlDBConnection();
          con.Open();

          //Console.Write(queryString);
          MySqlCommand cmd = new MySqlCommand(queryString, con);
          MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
          DataTable dt = new DataTable();
          sda.Fill(dt);
          dataGridView.DataSource = dt;
          if (dataGridView.ColumnCount > 0)
          {
              for (int i = 0; i < columnNameToDisplay.Length; i++)
              {
                  dataGridView.Columns[i].HeaderCell.Value = columnNameToDisplay[i];
              }

          }
          if (dataGridView.ColumnCount > 0)
          {
              for (int i = 0; i < columnIndexToHide.Length; i++)
              {
                  dataGridView.Columns[columnIndexToHide[i]].Visible = false;
              }
          }

          if (dataGridView.ColumnCount == 0)
          {
              dataGridView.ColumnCount = 1;
              dataGridView.Columns[0].Name = "No Data Found";
              string[] row = new string[] { "" };
              dataGridView.Rows.Add(row);

          }
          con.Close();

      }
      catch (Exception ex)
      {

          MessageBox.Show("Can not open connection ! " + ex.Message.ToString());
      }
  }
    }

}
