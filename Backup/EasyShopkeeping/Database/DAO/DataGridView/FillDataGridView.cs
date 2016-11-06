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
                MySqlDataReader reader = cmd.ExecuteReader();
                //MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(getCattegoryQuery, con);
                //DataSet ds = new DataSet();
                //mySqlDataAdapter.Fill(ds, "product_category");
                //dataGridView1.DataSource = ds;
                //dataGridView1.DataMember = "product_category";
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[1].HeaderCell.Value = "Category";
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].ReadOnly = true;

                }
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Can not open connection ! " + ex);
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
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].ReadOnly = true;

                }
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Can not open connection ! " + ex);
            }
        }

    }
}
