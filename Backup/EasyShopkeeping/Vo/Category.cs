using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyShopkeeping.Vo
{
    class Category
    {
        private String product_category_id;

        public String Product_category_id
        {
            get { return product_category_id; }
            set { product_category_id = value; }
        }
        private String product_category_name;

        public String Product_category_name
        {
            get { return product_category_name; }
            set { product_category_name = value; }
        }
    }
}
