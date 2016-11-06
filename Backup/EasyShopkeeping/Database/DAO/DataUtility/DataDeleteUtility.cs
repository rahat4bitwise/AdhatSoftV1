using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EasyShopkeeping.DAO.DataUtility
{
    class DataDeleteUtility: DataBaseConnection
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        MySqlConnection con;
        public Boolean deleteRow(String sqlString)
        {
            int result = 0;
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

                MessageBox.Show("DataBase Error::" + ex);
            }
            if (result > 0)
                return true;
            else
                return false;
        }
    }
}
