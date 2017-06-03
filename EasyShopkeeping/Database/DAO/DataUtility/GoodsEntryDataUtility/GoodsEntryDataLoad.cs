using EasyShopkeeping.DAO.DataUtility;
using EasyShopkeeping.Utility;
using EasyShopkeeping.Utility.Excepetions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopkeeping
{
    class GoodsEntryDataLoad : DataLoadUtility
    {
        DataAccessUtility dataAccessUtility = new DataAccessUtility();
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        MySqlConnection con;
        
       
        String insertQuery;
        String updateQuery;
        String tableName = "goods_entry";
        String TRDR_ID;
        String ITEM_NAME;
        String WT_BOX_TYPE;
        String WT_TXT;
        String LOT_1;
        String LOT_2;
        String LOT_3;
        String LOT_4;
        String LOT_5;
        String LOGISTIC_DETAILS;
        String SHORT_BOX;
        String QTY_RCVD;
        String ORIGIN;
        string VEHICLE_NO;
        String FARE_RATE;
        String TOTAL_FARE;
        String RECV_DATE;
        String TRDR_FNAME_TMARK;
        String LOT_NO_SHORT;
        Boolean result1 = false;
        Boolean result2 = false;
        Boolean result3 = false;
        Boolean finalResult = false;
        MySqlTransaction myTrans;

        public Boolean saveGoodsEntryData(String TRDR_ID, String ITEM_NAME, String WT_BOX_TYPE, String WT_TXT, String LOT_1, String LOT_2, String LOT_3, String LOT_4, String LOT_5,
            String LOGISTIC_DETAILS, String SHORT_BOX, String QTY_RCVD, String ORIGIN, String VEHICLE_NO, String FARE_RATE, String TOTAL_FARE, String RECV_DATE, String TRDR_FNAME_TMARK, String LOT_NO_SHORT)
        {

            this.TRDR_ID = TRDR_ID.Trim();
            this.ITEM_NAME = ITEM_NAME.Trim();
            this.WT_BOX_TYPE = WT_BOX_TYPE.Trim();
            this.WT_TXT = WT_TXT.Trim();
            this.LOT_1 = LOT_1;
            this.LOT_2 = LOT_2;
            this.LOT_3 = LOT_3;
            this.LOT_4 = LOT_4;
            this.LOT_5 = LOT_5;
            this.LOGISTIC_DETAILS = LOGISTIC_DETAILS;
            this.VEHICLE_NO = VEHICLE_NO;
            this.FARE_RATE = FARE_RATE;
            this.TOTAL_FARE = TOTAL_FARE;
            this.SHORT_BOX = SHORT_BOX;
            this.ORIGIN = ORIGIN;
            this.RECV_DATE = RECV_DATE;
            this.QTY_RCVD = QTY_RCVD;
            this.TRDR_FNAME_TMARK = TRDR_FNAME_TMARK;
            this.LOT_NO_SHORT = LOT_NO_SHORT;

            //Entry of goods_entry details 
            String G_ENTRY_ID = "GETRYID" + GenerateUniqueID.RandomString(8);
         try{   
            con = dataBaseConnection.getMySqlDBConnection();
            con.Open();
            MySqlCommand myCommand = con.CreateCommand();
           
            // Start a local transaction
            myTrans = con.BeginTransaction();
            // Must assign both transaction object and connection
           // to Command object for a pending local transaction
         myCommand.Connection = con;
         myCommand.Transaction = myTrans;
          
            insertQuery = "insert into " + tableName + " values('" + G_ENTRY_ID + "','" + TRDR_ID + "','" + ITEM_NAME + "','" + WT_TXT + "','" + LOT_1
                + "','" + LOT_2 + "','" + LOT_3 + "','" + LOT_4 + "','" + LOT_5 + "','"+ LOGISTIC_DETAILS + "','"+VEHICLE_NO+"','"+FARE_RATE+"','"
                +TOTAL_FARE+"','"+QTY_RCVD+"','"+ORIGIN+"','"+RECV_DATE+"','"+SHORT_BOX+"','"+WT_BOX_TYPE+"','"+TRDR_FNAME_TMARK+"','"+LOT_NO_SHORT+"');";
            Console.WriteLine("Query:" + insertQuery);
            if (!(dataAccessUtility.iscolumnAlreadyPresent(tableName, "G_ENTRY_ID", G_ENTRY_ID)))
            {
             insertData(insertQuery,con);
             Console.WriteLine("Goods Entry Inserted");
            }
            else
                throw (new CustomException("Some Thing Wrong !! Please Try Again"));
            //Entry of stock details for each Lot
            String stockTable = "stock_details";
            String LOTID_1 = "LOT" + GenerateUniqueID.RandomString(8);
            String LOTID_2 = "LOT" + GenerateUniqueID.RandomString(8);
            String LOTID_3 = "LOT" + GenerateUniqueID.RandomString(8);
            String LOTID_4 = "LOT" + GenerateUniqueID.RandomString(8);
            String LOTID_5 = "LOT" + GenerateUniqueID.RandomString(8);
            String STOCK_ID = "STOCK" + GenerateUniqueID.RandomString(8);
            String[] lotIds = new String[] { LOTID_1, LOTID_2, LOTID_3, LOTID_4, LOTID_5 };
            String [] lotBoxes = new String[] { this.LOT_1, this.LOT_2, this.LOT_3, this.LOT_4, this.LOT_5 };
            String SHORT_LOT_IND = "N";
            if (!(String.IsNullOrEmpty(this.LOT_NO_SHORT)))
            {
                SHORT_LOT_IND = "Y," + lotIds[int.Parse(this.LOT_NO_SHORT)-1];
            }
            insertQuery = "insert into " + stockTable + " values('" + G_ENTRY_ID + "','" + LOTID_1 + "','" + LOTID_2 + "','" + LOTID_3 + "','" + LOTID_4
                  + "','" + LOTID_5 + "','" + STOCK_ID + "','" + SHORT_LOT_IND + "');";
            
            if (!(dataAccessUtility.iscolumnAlreadyPresent(stockTable, "STOCK_ID", STOCK_ID)))
            {
              insertData(insertQuery,con);
              Console.WriteLine("StockQuery:" + insertQuery);
            }
            else
            {
            MessageBox.Show("Some Thing Wrong !! Please Try Again");
            return false;
            }

            //Entry of lots details into lot details
            String lotDetailsTable = "lot_status";
            if(SHORT_LOT_IND.Contains("Y"))
                {
                    int index=int.Parse(this.LOT_NO_SHORT)-1;
                    int shortbox=int.Parse(this.SHORT_BOX);
                    lotBoxes[index] = (int.Parse(lotBoxes[index]) - shortbox).ToString();
                }

            for (int i =0; i < lotIds.Length; i++)
            {
                int lotSerial = 0;
                if (String.IsNullOrEmpty(lotBoxes[i]))
                {
                    lotSerial = i + 1;
                    continue;
                    
                }
                 
                lotSerial = i + 1;
                insertQuery = "insert into " + lotDetailsTable + " values('" + lotIds[i] + "','" + lotBoxes[i] + "','" + G_ENTRY_ID + "','0','" + lotBoxes[i] + "','" + lotSerial+ "','N');";
                insertData(insertQuery,con);
                Console.WriteLine("Lot_details_Query:" + insertQuery);     

            }
            myTrans.Commit();
            Console.WriteLine("All records are written to database.");
            finalResult = true ;
            return finalResult;

            }
            catch (Exception e)
            {
                finalResult = false;
                try
                {
                    myTrans.Rollback();
                    return finalResult;
                }
                catch (MySqlException ex)
                {
                    if (myTrans.Connection != null)
                    {
                        Console.WriteLine("An exception of type " + ex.GetType() +
                        " was encountered while attempting to roll back the transaction.");
                    }
                    
                }

                Console.WriteLine("An exception of type " + e.GetType() + " was encountered while inserting the data.");
                Console.WriteLine("Neither record was written to database.");
                return finalResult;
                
            }
            finally
            {
                con.Close();
                
            }
        }

        public Boolean updateGoodsEntryData(String TRDR_ID, String ITEM_NAME, String WT_BOX_TYPE, String WT_TXT, String LOT_1, String LOT_2, String LOT_3, String LOT_4, String CUST_ID)
        {

            this.TRDR_ID = TRDR_ID.Trim();
            this.ITEM_NAME = ITEM_NAME.Trim();
            this.WT_BOX_TYPE = WT_BOX_TYPE.Trim();
            this.WT_TXT = WT_TXT.Trim();
            this.LOT_1 = LOT_1;
            this.LOT_2 = LOT_2;
            this.LOT_3 = LOT_3;
            this.LOT_4 = LOT_4;
            String CUSTID = CUST_ID;

           
                updateQuery = "update " + tableName + " set TRDR_ID='" + TRDR_ID + "',ITEM_NAME='" + ITEM_NAME + "',WT_BOX_TYPE='" + WT_BOX_TYPE + "',WT_TXT='" + WT_TXT
                 + "',LOT_1='" + LOT_1 + "',LOT_2='" + LOT_2 + "',LOT_3='" + LOT_3 + "' where CUST_ID='" + CUSTID + "' ";


            //result = insertData(updateQuery);
            return result1;
        }
    }
}
