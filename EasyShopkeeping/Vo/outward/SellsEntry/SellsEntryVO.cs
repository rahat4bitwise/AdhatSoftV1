using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyShopkeeping.TableVO
{
    class SellsEntryVO
    {
        public String cust_name;
        private String date;
        private Double totalAmount;
        private ArrayList sellEntryDetails;
        SellsEntryVO()
        {
            sellEntryDetails = new ArrayList();
        }
        public String Cust_name
        {
            get
            { return this.cust_name; }
            set
            { this.cust_name = value; }
        }
        public String Date
        {
            get
            { return this.date; }
            set
            { this.date = value; }
        }
        public Double TotalAmount
        {
            get
            { return this.totalAmount; }
            set
            { this.totalAmount = value; }
        }
  
       
    }
}
