using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EasyShopkeeping.DAO.DataUtility
{
    class DataAccessUtility : DataBaseConnection
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        MySqlConnection con;
            
            
         public ArrayList fetchData(String table, String columns, String where,Object vo)
        {
            return null;

        }
         public Boolean iscolumnAlreadyPresent(String tableName, String columnName, String coulNameValue)
         {
             con = dataBaseConnection.getMySqlDBConnection();
             try { 
             con.Open();
            String sqlStr="select count(*) from "+tableName+" where "+columnName+" = '"+coulNameValue+"'";
             MySqlCommand cmd = new MySqlCommand(sqlStr, con);
             int recordCount = Convert.ToInt32(cmd.ExecuteScalar());
             if (recordCount>0)
             {
       
                 return true;
             }
             else
             {
                 
                 return false;
             }
             }
             catch (Exception E) { MessageBox.Show(E.Message); }
             return false;
         }
         public Boolean iscolumnAlreadyPresent(String tableName, String columnName1, String columnName2, String columnName3, String coulNameValue1,String coulNameValue2, String coulNameValue3)
         {
             con = dataBaseConnection.getMySqlDBConnection();
             try
             {
                 con.Open();
                 String sqlStr = "select count(*) from " + tableName + " where " + columnName1 + " = '" + coulNameValue1 + "' and "+ columnName2 + " = '" + coulNameValue2 + "' and "+ columnName3 + " = '" + coulNameValue3 + "'";
                 MySqlCommand cmd = new MySqlCommand(sqlStr, con);
                 int recordCount = Convert.ToInt32(cmd.ExecuteScalar());
                 if (recordCount > 0)
                 {

                     return true;
                 }
                 else
                 {

                     return false;
                 }
             }
             catch (Exception E) { MessageBox.Show(E.Message); }
             return false;
         }
         public MySqlDataReader accessColumnData(String sql)
         {
             MySqlDataReader reader;
             try
             {
                 con = dataBaseConnection.getMySqlDBConnection();
                 con.Open();
                 MySqlCommand cmd = new MySqlCommand(sql, con);
                 reader = cmd.ExecuteReader();
                 return reader;
                 con.Close();
                 
             }
             catch (Exception ex)
             {

                 MessageBox.Show("DataBase Error::" + ex);
                 return null;
             }
            


         }
    }
}
