using EasyShopkeeping.DAO.DataUtility;
using EasyShopkeeping.TableVO;
using EasyShopkeeping.Utility;
using EasyShopkeeping.Utility.Excepetions;
using EasyShopkeeping.Vo;
using EasyShopkeeping.Vo.outward.SellsEntry;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopkeeping
{
    class SellsEntryDataLoad: DataLoadUtility
    {
        DataAccessUtility dataAccessUtility = new DataAccessUtility();
        DataBaseConnection dataBaseConnection = new DataBaseConnection();
        MySqlConnection con;

        String insertQuery1="";
        String insertQuery2="";
        String insertQuery3="";
        String updateQuery;
        String table1 = "cust_sells_data";
        String table2 = "trader_sells_book";
        String table3 = "cust_ledger";
        String table4 = "lot_status";
   
        Boolean finalResult = false;
        SellsEntryForCustomerVO sellsEntryForCustomerVO;
        MySqlTransaction myTrans;

        public Boolean saveSellsData(SellsEntryForCustomerVO sellsEntryForCustomerVO)
        {
            this.sellsEntryForCustomerVO = sellsEntryForCustomerVO;

            try
            {
                con = dataBaseConnection.getMySqlDBConnection();
                con.Open();
                MySqlCommand myCommand = con.CreateCommand();

                // Start a local transaction
                myTrans = con.BeginTransaction();
                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                myCommand.Connection = con;
                myCommand.Transaction = myTrans;
                String CST_INVC_ID="INVCID"+GenerateUniqueID.RandomString(8);
                String CUST_ID = sellsEntryForCustomerVO.Cust_id;
                String INVOICE_DATE = sellsEntryForCustomerVO.Date;
                double amount = 0;
                // Inserting Data into Cust sells_data table
                foreach (SellEntryDetails sellEntryDetails in sellsEntryForCustomerVO.SellEntryDetails)
                {
                    
                    String TOT_AMNT = sellEntryDetails.TotalAmount;
                    amount = amount + Convert.ToDouble(TOT_AMNT);
                    String QTY = sellEntryDetails.Quantity;
                    String RATE = sellEntryDetails.Rate1;
                    String WT_BOX_TYPE = sellEntryDetails.WT_BOX_TYPE1;
                    String WT_TXT = sellEntryDetails.WT_TXT1;
                    String SELL_TXN_ID=sellEntryDetails.sell_txn_id1;
                    String SELL_DATE = sellEntryDetails.sell_date1;
                    String ITEM_NAME=sellEntryDetails.SellItemName;
                    insertQuery1 = "insert into " + table1 + " values('" + CUST_ID + "','" + CST_INVC_ID + "','" + INVOICE_DATE + "','" + TOT_AMNT + "','" + SELL_TXN_ID +
                        "','" + ITEM_NAME + "','" + QTY + "','" + RATE + "','"+SELL_DATE+"','N','N','"+WT_BOX_TYPE+"','"+WT_TXT+"');";
                    Console.WriteLine(insertQuery1);
                    if (!(dataAccessUtility.iscolumnAlreadyPresent(table1, "SELL_TXN_ID", SELL_TXN_ID)))
                    {
                        insertData(insertQuery1, con);
                        Console.WriteLine("Sells Entry For Each Lot :"+SELL_TXN_ID);
                    }
                    else
                    {
                        MessageBox.Show("Some Thing Wrong !! Please Try Again");
                        return false;
                    }

                    
                    // Inserting Data into trader_sells_book table
                    foreach (SellsEntryForTraderVO sellsEntryForTraderVO in sellEntryDetails.SellsEntryForTraderVO)
                    {
                      
                        String TRDR_ID = sellsEntryForTraderVO.TRDR_ID1;
                        String G_ENTRY_ID = sellsEntryForTraderVO.G_ENTRY_ID1;
                        String STOCK_ID = sellsEntryForTraderVO.STOCK_ID1;
                        String LOT_ID = sellsEntryForTraderVO.LOT_ID1;
                        insertQuery2 = "insert into " + table2 + " values('" + TRDR_ID + "','" + G_ENTRY_ID + "','" + STOCK_ID + "','" + LOT_ID + "','" + TOT_AMNT +
                        "','" + SELL_DATE + "','" + SELL_TXN_ID +"');";
                        Console.WriteLine("trader_sells_book Query:" + insertQuery2);
                        insertData(insertQuery2, con);

                        //Update lot_status
                        String TOT_BAL = sellEntryDetails.tot_bal1;
                        String TOT_SOLD = sellEntryDetails.tot_sold1;
                        String TOT_SOLD_IND;
                        if (int.Parse(TOT_BAL) == 0)
                        {
                            TOT_SOLD_IND = "Y";
                        }
                        else
                        {
                            TOT_SOLD_IND = "N";
                        }

                        updateQuery = "update " + table4 + " set TOT_SOLD='" + TOT_SOLD + "',TOT_BAL='" + TOT_BAL + "',TOT_SOLD_IND='" + TOT_SOLD_IND + "' where LOT_ID='"
                            + LOT_ID + "' and G_ENTRY_ID='" + G_ENTRY_ID+"'";
                        insertData(updateQuery, con);
  

                    }
                
                }

                //Setting Total Bill Amount
                sellsEntryForCustomerVO.TotalAmountToday = amount.ToString();
                Console.WriteLine("Total Bill:" + sellsEntryForCustomerVO.TotalAmountToday);
                //Save Data into Customer Ledger
                String TOT_BILL_AMNT = sellsEntryForCustomerVO.TotalAmountToday;
                String BLNC_CLEAR = "N";
                insertQuery3 = "insert into " + table3 + " values('" + CST_INVC_ID + "','" + CUST_ID + "','" + INVOICE_DATE + "','" + TOT_BILL_AMNT + "','" + BLNC_CLEAR + "');";
                Console.WriteLine("cust_ledger Query:" + insertQuery3);
                insertData(insertQuery3, con);
               

                myTrans.Commit();
                Console.WriteLine("All records are written to database.");
                finalResult = true;
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
    }
}
