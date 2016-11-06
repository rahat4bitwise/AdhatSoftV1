using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EasyShopkeeping
{
    class UserInfoDAO:DataBaseConnection
    {

        String tableName = "user_info";
        String userInfoColumn;
        String selectQuery;
        String fromTable;
        String whereQuery;
        MySqlConnection con;
        DataBaseConnection dataBaseConnection= new DataBaseConnection();
        User user = new User();

        private static readonly log4net.ILog log =log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
    public MySqlConnection getConnection()
    {
        con = dataBaseConnection.getMySqlDBConnection();
        return con;
    }
    public String getUserInfoCoulmn()
    {
        userInfoColumn = "USERNAME,PASSWORD,USER_TYPE";
        return userInfoColumn;
    }
    public String buildUsernamePasswordQuery()
    {
       selectQuery="select "+getUserInfoCoulmn()+" ";
       fromTable = "from "+tableName;
       return selectQuery + fromTable;
    }
    public String getUserInfoQuery(String field1, String field2)
    {
        whereQuery = " where USERNAME= '" + field1 + "' and PASSWORD= '" + field2 + "'"+";";
        return buildUsernamePasswordQuery() + whereQuery;
    }
    public Boolean validateUser(String username,String password)
    {
        try
        {
            MySqlConnection con = this.getConnection();
            con.Open();
            string userInfoQuery = getUserInfoQuery(username, password);
            MySqlCommand cmd = new MySqlCommand(userInfoQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                user.Username = reader.GetString("USERNAME");
                user.Password = reader.GetString("PASSWORD");
                user.UserCategory = reader.GetString("USER_TYPE");
            }
            con.Close();
           // log.Info("Connection Closed");
            
        }
        catch (Exception ex)
        {

            MessageBox.Show("Database Exception Occured!! Please contact Developer" );
            log.Info("DataBase Exception Ocured");
            log.Info(ex);
            System.Environment.Exit(0);
        }
      
        if ((username == user.Username) && (password == user.Password))
            return true;
        else
            return false;
        
    }
    public String getUserype()
    {
        return user.UserCategory;
    }


    }
}
