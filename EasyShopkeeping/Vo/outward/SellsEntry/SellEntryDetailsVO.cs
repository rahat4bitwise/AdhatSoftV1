using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyShopkeeping.TableVO
{
    class SellEntryDetails
    {
        private ArrayList sellsEntryForTraderVO;

        public SellEntryDetails()
        {
            sellsEntryForTraderVO = new ArrayList();         
        }
        
        private String sellItemName;

        public String SellItemName
        {
            get { return sellItemName; }
            set { sellItemName = value; }
        }
        private String Rate;

        public String Rate1
        {
            get { return Rate; }
            set { Rate = value; }
        }
        private String quantity;

        public String Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private String totalAmount;

        public String TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
        private String LOT_ID;

        public String LOT_ID1
        {
            get { return LOT_ID; }
            set { LOT_ID = value; }
        }
        private String WT_TXT;

        public String WT_TXT1
        {
            get { return WT_TXT; }
            set { WT_TXT = value; }
        }

        private String WT_BOX_TYPE;

        public String WT_BOX_TYPE1
        {
            get { return WT_BOX_TYPE; }
            set { WT_BOX_TYPE = value; }
        }

        private String sell_txn_id;
        public String sell_txn_id1
        {
            get { return sell_txn_id; }
            set { sell_txn_id = value; }
        }
        private String sell_date;
        public String sell_date1
        {
            get { return sell_date; }
            set { sell_date = value; }
        }

        private String tot_bal;
        public String tot_bal1
        {
            get { return tot_bal; }
            set { tot_bal = value; }
        }
        private String tot_sold;
        public String tot_sold1
        {
            get { return tot_sold; }
            set { tot_sold = value; }
        }

        public ArrayList SellsEntryForTraderVO
        {
            get { return sellsEntryForTraderVO; }
            set { sellsEntryForTraderVO = value; }
        }
    
        

    }
}
