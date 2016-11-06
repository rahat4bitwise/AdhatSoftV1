using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyShopkeeping
{
    class DBAccessConstant
    {
        public static readonly String SELECT_ITEM_QUERY = "select * from item_details";
        public static readonly String SELECT_STATE_QUERY = "select * from state";
        public static readonly String SELECT_DISTRICT_QUERY = "select * from district";
        public static readonly String SELECT_AREA_QUERY = "select * from area";
    }
}
