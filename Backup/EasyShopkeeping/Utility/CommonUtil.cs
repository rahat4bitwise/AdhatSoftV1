using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyShopkeeping.Utility
{
    class CommonUtil: Calculation
    {
        public String trimString(String str)
        {
            return str.Trim();
        }
        public int countChar(String str)
        {
            return str.Trim().Length;
        }
        
    }
}
