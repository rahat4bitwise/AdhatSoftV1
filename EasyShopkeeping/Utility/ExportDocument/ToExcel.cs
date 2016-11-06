using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyShopkeeping.Utility.ExportDocument
{
    class ToExcel
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);  
        /// <summary>
        /// Exports the datagridview values to Excel.
        /// </summary>
        public void exportToExcel(DataGridView dataGridView, String exelFileName, int[] columnsIndexPrinted)
        {
            // Creating a Excel object.
            
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            

            try
            {

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;
                //MessageBox.Show(dataGridView.Columns.Count.ToString() + " " + dataGridView.Rows.Count.ToString());
                //Loop through each row and read value from each column.
                //sMicrosoft.Office.Interop.Excel.Range columnsNameRange;
                

               for (int i = 0; i < columnsIndexPrinted.Length; i++)
                    {
                        
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView.Columns[columnsIndexPrinted[i]].HeaderText;     
                            cellColumnIndex++; 
               }

               Microsoft.Office.Interop.Excel.Range formatRange;
               formatRange = worksheet.get_Range("a1");
               formatRange.EntireRow.Font.Bold = true;
                //worksheet.Rows.Font.Bold = true;
               //columnsNameRange = worksheet.Range[worksheet.Cells[cellRowIndex, cellColumnIndex]];
               //columnsNameRange.Font.Bold = true;
               cellRowIndex++;
               cellColumnIndex = 1;

                foreach (DataGridViewRow Datarow in dataGridView.Rows)
                {

                    for (int i = 0; i < columnsIndexPrinted.Length; i++)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = Datarow.Cells[columnsIndexPrinted[i]].Value.ToString();
                        cellColumnIndex++;
                    }

                       cellRowIndex++;
                       cellColumnIndex = 1;
                       
                }
                
                

                //Getting the location and file name of the excel to save from user.
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;
                saveDialog.FileName = exelFileName;
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }               
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }
    }
    }