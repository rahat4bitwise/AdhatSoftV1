using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using MySql.Data.MySqlClient;

namespace EasyShopkeeping
{
    class DataAccessUtility : DataBaseConnection
    {
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        
            
            
         public ArrayList fetchData(String table, String columns, String where,Object vo)
        {
            return null;

        }

        
    }
}
