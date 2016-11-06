using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyShopkeeping.Utility.Common
{
    class DateHelper
    {
        public static String dateToStringddMMyyyy(DateTime date)
        {
            String da = date.ToString("dd-MM-yyyy");

            String dateddMMyyyy = date.ToShortDateString();
            //dateddMMyyyy = dateddMMyyyy.Replace('/', '-');
            dateddMMyyyy = dateddMMyyyy.Replace("/", "");
            Console.WriteLine("dateFromHelper"+dateddMMyyyy);
            return da;
        }
        public static String getSqlString(DateTime date)
        {

            String dateddMMyyyy = date.ToString("yyyy-MM-dd");
            Console.WriteLine("getSqlString" + dateddMMyyyy);
            return dateddMMyyyy;
        }

    }
}
