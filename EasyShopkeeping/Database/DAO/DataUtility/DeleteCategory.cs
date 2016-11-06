using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopkeeping.DAO.DataUtility
{
    class DeleteCategory

    {
        DataDeleteUtility dataDeleteUtility = new DataDeleteUtility();
        String deleteQuery;
        String tableName = "product_category";
        String product_category_id;
        
        public Boolean deleteCategory(String category_id)
        {
            product_category_id = category_id;
            
            deleteQuery = "delete from " + tableName + " where product_category_id='" + product_category_id + "';";
            //MessageBox.Show(deleteQuery);
            Boolean result = dataDeleteUtility.deleteRow(deleteQuery);
            return result;
        }
    }
}
