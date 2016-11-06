using EasyShopkeeping.DAO.DataUtility;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace EasyShopkeeping
{
    class FillFormWithData
    {
        DataAccessUtility dataAccessUtility = new DataAccessUtility();
     
        public MySqlDataReader getDataInComboBox(String tableName,String column)
        {
            string query = "select "+column+" from "+tableName;
            MySqlDataReader mySqlDataReader = dataAccessUtility.accessColumnData(query);
            if (mySqlDataReader != null)
                return mySqlDataReader;
            else
                return null;
        }

        public MySqlDataReader getDataInComboBox(String tableName, String column,String whereCoulmn,String conditionValue)
        {
            string query = "select " + column + " from " + tableName + " where " + whereCoulmn + "='" + conditionValue+"'";
            MySqlDataReader mySqlDataReader = dataAccessUtility.accessColumnData(query);
            if (mySqlDataReader != null)
                return mySqlDataReader;
            else
                return null;
        }

        public MySqlDataReader getDataInComboBox(String tableName, String column, String whereCoulmn1, String conditionValue1,String whereCoulmn2, String conditionValue2)
        {
            string query = "select " + column + " from " + tableName + " where " + whereCoulmn1 + "='" + conditionValue1 + "' and " + whereCoulmn2 + "='" + conditionValue2 + "'";
            MySqlDataReader mySqlDataReader = dataAccessUtility.accessColumnData(query);
            if (mySqlDataReader != null)
                return mySqlDataReader;
            else
                return null;
        }
 
    }
}
