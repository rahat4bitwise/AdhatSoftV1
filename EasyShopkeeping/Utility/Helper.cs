using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyShopkeeping.Utility
{
    class Helper
    {
        public String nullToEmpty(String val)
        {
            if(String.IsNullOrEmpty(val))
            {
                return "";

            }
            else
                return "("+val+")";
        }
    }
}
