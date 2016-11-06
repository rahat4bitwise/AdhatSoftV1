using EasyShopkeeping.DAO.DataUtility;
using EasyShopkeeping.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopkeeping
{
    class TraderDataLoad:DataLoadUtility
    {
        CopyUtils copyUtils = new CopyUtils();
        DataAccessUtility dataAccessUtility = new DataAccessUtility();
        String insertQuery;
        String updateQuery;
        String tableName = "trader_info";
        String TRDR_FNAME;
        String TRDR_LNAME;
        String TRDR_MOB;
        String TRDR_EMAIL;
        String TRDR_STATE;
        String TRDR_DIST;
        String TRDR_TMARK;
        String TRDR_ID;
        String TRDR_PIN;
        Boolean result = false;
       
        public Boolean saveTraderData(String TRDR_FNAME, String TRDR_LNAME, String TRDR_MOB, String TRDR_EMAIL, String TRDR_TMARK,String TRDR_STATE, String TRDR_DIST,String TRDR_PIN)
        {
          
            this.TRDR_FNAME = TRDR_FNAME.Trim();
            this.TRDR_LNAME = TRDR_LNAME.Trim();
            this.TRDR_MOB = TRDR_MOB.Trim();
            this.TRDR_EMAIL = TRDR_EMAIL.Trim();
            this.TRDR_TMARK = TRDR_TMARK.Trim();
            this.TRDR_STATE = TRDR_STATE;
            this.TRDR_DIST = TRDR_DIST;
            this.TRDR_PIN=TRDR_PIN.Trim();
           
            String TRDR_ID = "TID"+GenerateUniqueID.RandomString(8);

            insertQuery = "insert into " + tableName + " values('" +TRDR_ID+"', '"+ TRDR_FNAME + "','" + TRDR_LNAME + "','" + TRDR_MOB + "','" + TRDR_EMAIL + "','" +TRDR_TMARK+"','"+ TRDR_STATE + "','" + TRDR_DIST + "','" + TRDR_PIN+"');";
            if (!(dataAccessUtility.iscolumnAlreadyPresent(tableName, "TRDR_ID", TRDR_ID)))
            {
                result = insertData(insertQuery);

            }
            else
                MessageBox.Show("SomeThing Went Wrong!! Please try Again");

            return result;
        }

        public Boolean updateCustomerData(String TRDR_FNAME, String TRDR_LNAME, String TRDR_MOB, String TRDR_EMAIL, String TRDR_TMARK,String TRDR_STATE, String TRDR_DIST, String TRDR_PIN, String TRDR_ID)
        {
          
            this.TRDR_FNAME = TRDR_FNAME.Trim();
            this.TRDR_LNAME = TRDR_LNAME.Trim();
            this.TRDR_MOB = TRDR_MOB.Trim();
            this.TRDR_EMAIL = TRDR_EMAIL.Trim();
            this.TRDR_TMARK = TRDR_TMARK.Trim();
            this.TRDR_STATE = TRDR_STATE;
            this.TRDR_DIST = TRDR_DIST;
            this.TRDR_PIN=TRDR_PIN.Trim();
            this.TRDR_ID=TRDR_ID;
           
            updateQuery = "update " + tableName + " set TRDR_FNAME='" + TRDR_FNAME + "',TRDR_LNAME='" + TRDR_LNAME + "',TRDR_MOB='" + TRDR_MOB + "',TRDR_EMAIL='" + TRDR_EMAIL+
            "',TRDR_STATE='" + TRDR_STATE + "',TRDR_DIST='" + TRDR_DIST + "',TRDR_PIN='" + TRDR_PIN  + "',TRDR_TMARK='" + TRDR_TMARK + "' where TRDR_ID='" + TRDR_ID + "' ";
                    Console.Write(updateQuery);
                result = insertData(updateQuery);
                return result;
        }

    }
}
