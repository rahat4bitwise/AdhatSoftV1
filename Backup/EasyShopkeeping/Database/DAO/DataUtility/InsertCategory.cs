using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EasyShopkeeping
{
    class InsertCategory

    {
        DataLoadUtility dataLoadUtility = new DataLoadUtility();
        String insertQuery;
        String tableName = "product_category";
        String product_category_id;
        String product_category_name;
        String category;
        public Boolean insertCategory(String category_name)
        {
            category = category_name.Trim();
            product_category_id = category.ToLower() + DateTime.Now.ToString("yyyyMMdd");
            product_category_name = category.TrimStart();
            insertQuery = "insert into " + tableName + " values('" + product_category_id + "','" + product_category_name + "');";
            Boolean result=dataLoadUtility.insertData(insertQuery);
            return result;      
        }

       
    }
}
