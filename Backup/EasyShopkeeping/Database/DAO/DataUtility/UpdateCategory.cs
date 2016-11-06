using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopkeeping.DAO.DataUtility
{
    class UpdateCategory
    {
        DataUpdateUtility dataUpdateUtility = new DataUpdateUtility();
        String updateQuery;
        String tableName = "product_category";
        String product_category_id;
        String product_category_name;
        public Boolean updateCategory(String category_id,String category_name)
        {
            product_category_id = category_id;
            product_category_name = category_name;
            updateQuery = "update " + tableName + " set product_category_name='" + product_category_name + "' where product_category_id='" + product_category_id + "';";
            //MessageBox.Show(updateQuery);
            Boolean result = dataUpdateUtility.updateRow(updateQuery);
            return result;
        }
    }
}
