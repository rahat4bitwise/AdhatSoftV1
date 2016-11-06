using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyShopkeeping.Utility.Excepetions
{
    class CustomException:Exception
    {
        public CustomException(String message) : base(message)
        {
            
        }
    }
}
