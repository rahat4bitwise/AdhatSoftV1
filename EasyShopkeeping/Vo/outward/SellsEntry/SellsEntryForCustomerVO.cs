using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyShopkeeping.Vo
{
    class SellsEntryForCustomerVO
    {
        private String cust_id;
        private String date;
        private String totalAmountToday;
        private String cust_name;
        private ArrayList sellEntryDetails;
        
        public SellsEntryForCustomerVO()
        {
            sellEntryDetails = new ArrayList();      

        }

        public String Cust_id
        {
            get { return cust_id; }
            set { cust_id = value; }
        }
        public String Date
        {
            get { return date; }
            set { date = value; }
        }

        public String TotalAmountToday
        {
            get { return totalAmountToday; }
            set { totalAmountToday = value; }
        }

        public String Cust_name
        {
            get { return cust_name; }
            set { cust_name = value; }
        }


        public ArrayList SellEntryDetails
        {
            get { return sellEntryDetails; }
            set { sellEntryDetails = value; }
        }


       

    }
}
