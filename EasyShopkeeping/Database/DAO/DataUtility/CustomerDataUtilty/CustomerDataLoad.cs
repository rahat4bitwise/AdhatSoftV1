using EasyShopkeeping.DAO.DataUtility;
using EasyShopkeeping.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopkeeping
{
    class CustomerDataLoad : DataLoadUtility
    {
        CopyUtils copyUtils = new CopyUtils();
        DataAccessUtility dataAccessUtility = new DataAccessUtility();
        String insertQuery;
        String updateQuery;
        String tableName = "customer_data";
        String CUST_FNAME;
        String CUST_LNAME;
        String CUST_MOB;
        String CUST_EMAIL;
        String CUST_STATE;
        String CUST_DISTRICT;
        String CUST_AREA;
        String CUST_IMG_LOC;
        String CUST_IMG_FILENAME;
        Boolean result = false;
       
        public Boolean saveCustomerData(String CUST_FNAME, String CUST_LNAME, String CUST_MOB, String CUST_EMAIL, String CUST_STATE, String CUST_DISTRICT, String CUST_AREA, String CUST_IMG_LOC)
        {
          
            this.CUST_FNAME = CUST_FNAME.Trim();
            this.CUST_LNAME = CUST_LNAME.Trim();
            this.CUST_MOB = CUST_MOB.Trim();
            this.CUST_EMAIL = CUST_EMAIL.Trim();
            this.CUST_STATE = CUST_STATE;
            this.CUST_DISTRICT = CUST_DISTRICT;
            this.CUST_AREA = CUST_AREA;
            this.CUST_IMG_LOC = CUST_IMG_LOC;
            String CUST_ID = GenerateUniqueID.RandomString(8);

            if (!(String.IsNullOrEmpty(CUST_IMG_LOC)))
            {
               
                String fileExtension = Path.GetExtension(CUST_IMG_LOC);
                this.CUST_IMG_FILENAME = CUST_ID  + fileExtension;
                if(!(copyUtils.copyImag(CUST_IMG_LOC, CUST_IMG_FILENAME)))
                    return false;
           
               
            }
            else
            {
                this.CUST_IMG_FILENAME = "";
            }
            
            //String CUST_ID = "5L9OSNKD";
            insertQuery = "insert into " + tableName + " values('" + CUST_FNAME + "','" + CUST_LNAME + "','" + CUST_MOB + "','" + CUST_EMAIL + "','" + CUST_STATE + "','" + CUST_DISTRICT + "','" + CUST_AREA + "','" + AppConstant.IMG_TRAGET_PATH + "','" + CUST_IMG_FILENAME + "', " + " '"+CUST_ID+"');";
            if (!(dataAccessUtility.iscolumnAlreadyPresent(tableName, "CUST_ID", CUST_ID)))
            {
                result = insertData(insertQuery);

            }
            else
                MessageBox.Show("SomeThing Went Wrong!! Please try Again");

            return result;
        }

        public Boolean updateCustomerData(String CUST_FNAME, String CUST_LNAME, String CUST_MOB, String CUST_EMAIL, String CUST_STATE, String CUST_DISTRICT, String CUST_AREA, String CUST_IMG_LOC,String CUST_ID)
        {
          
            this.CUST_FNAME = CUST_FNAME.Trim();
            this.CUST_LNAME = CUST_LNAME.Trim();
            this.CUST_MOB = CUST_MOB.Trim();
            this.CUST_EMAIL = CUST_EMAIL.Trim();
            this.CUST_STATE = CUST_STATE;
            this.CUST_DISTRICT = CUST_DISTRICT;
            this.CUST_AREA = CUST_AREA;
            this.CUST_IMG_LOC = CUST_IMG_LOC;
            String CUSTID=CUST_ID;
           
            if (!(String.IsNullOrEmpty(CUST_IMG_LOC)))
            {
                String fileExtension = Path.GetExtension(CUST_IMG_LOC);
                this.CUST_IMG_FILENAME = CUST_ID + fileExtension;
                if (copyUtils.copyImag(CUST_IMG_LOC, CUST_IMG_FILENAME))
                {
                    updateQuery = "update " + tableName + " set CUST_FNAME='" + CUST_FNAME + "',CUST_LNAME='" + CUST_LNAME + "',CUST_MOB='" + CUST_MOB + "',CUST_EMAIL='" + CUST_EMAIL
                    + "',CUST_STATE='" + CUST_STATE + "',CUST_DISTRICT='" + CUST_DISTRICT + "',CUST_AREA='" + CUST_AREA + "',CUST_IMG_LOC='" + AppConstant.IMG_TRAGET_PATH
                    + "',CUST_IMG_FILENAME='" + CUST_IMG_FILENAME + "' where CUST_ID='" + CUSTID + "' ";
                    Console.Write(updateQuery);
                }
            }
            else
            {
               updateQuery = "update " + tableName + " set CUST_FNAME='"+CUST_FNAME+"',CUST_LNAME='"+ CUST_LNAME+"',CUST_MOB='"+ CUST_MOB+"',CUST_EMAIL='"+ CUST_EMAIL
                + "',CUST_STATE='" + CUST_STATE + "',CUST_DISTRICT='" + CUST_DISTRICT + "',CUST_AREA='" + CUST_AREA + "' where CUST_ID='" + CUSTID + "' ";
               
               Console.Write(updateQuery);
            }
            
            
                result = insertData(updateQuery);
                return result;
        }



    }

}
