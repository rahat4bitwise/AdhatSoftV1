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
        DataAccessUtility dataAccessUtility = new DataAccessUtility(); 
        
    public MySqlConnection getConnection()
    {
        con = dataBaseConnection.getMySqlDBConnection();
        return con;
    }
    public String getUserInfoCoulmn()
    {
        userInfoColumn = "username,password,userType";
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
        whereQuery = " where username= '" + field1 + "' and password= '" + field2 + "'"+";";
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
                user.Username = reader.GetString("username");
                user.Password = reader.GetString("password");
                user.UserCategory = reader.GetString("userType");
            }
            con.Close();
            
        }
        catch (Exception ex)
        {

            MessageBox.Show("Can not open connection ! " + ex);
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
