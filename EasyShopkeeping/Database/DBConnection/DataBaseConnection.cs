using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace EasyShopkeeping
{
    class DataBaseConnection:Database
    {
        //MySqlConnection con;

        public DataBaseConnection()
        {

        }
        public String getMySqlConnectionStrings()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
            return connectionString;
        }

        public MySqlConnection getMySqlDBConnection()
        {
            return new MySqlConnection(getMySqlConnectionStrings());
        }

    }
}
