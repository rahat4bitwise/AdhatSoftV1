using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EasyShopkeeping
{
    class DataLoadUtility : DataBaseConnection
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        MySqlConnection con;
        public Boolean insertData(String sqlString)
        {
            int result=0;
            try
            {
                con = dataBaseConnection.getMySqlDBConnection();
                MySqlCommand cmd = new MySqlCommand(sqlString, con);
                con.Open();
                result = cmd.ExecuteNonQuery();
                con.Close();
                

            }
            catch (Exception ex)
            {
                String errorMessage = ex.Message;
                if (errorMessage.Contains("Duplicate Entry"))
                {
                    MessageBox.Show("DataBase Error: Duplicate Entry");
                }
                MessageBox.Show("DB Error::" + ex.Message);
            }
            if (result > 0)
                return true;
            else
                return false;
        }

        public void insertData(String sqlString, MySqlConnection conn)
        {

            try
            {
                //con = dataBaseConnection.getMySqlDBConnection();
                MySqlCommand cmd = new MySqlCommand(sqlString, conn);
                // con.Open();
                cmd.ExecuteNonQuery();
                // con.Close();
            }catch(Exception ex1)
            {
                MessageBox.Show("DB Error::" + ex1.Message);
                throw;
            }

         }


    }
}
