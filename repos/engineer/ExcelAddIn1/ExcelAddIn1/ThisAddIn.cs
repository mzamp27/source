using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace ExcelAddIn1
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //this.Application.WorkbookBeforeSave += new Microsoft.Office.Interop.Excel.AppEvents_WorkbookBeforeSaveEventHandler(Application_WorkbookBeforeSave);
            //method for exporting info to excel 
            void DisplayInExcel(IEnumerable<Account> accounts)
            {
                var excelApp = new Excel.Application();
                // Make the object visible.
                excelApp.Visible = true;

                // Create a new, empty workbook and add it to the collection returned 
                // by property Workbooks. The new workbook becomes the active workbook.
                // Add has an optional parameter for specifying a praticular template. 
                // Because no argument is sent in this example, Add creates a new workbook. 
                excelApp.Workbooks.Add();

                // This example uses a single workSheet. The explicit type casting is
                // removed in a later procedure.
                Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

                // Establish column headings in cells A1 and B1.
                workSheet.Cells[1, "A"] = "ID Number";
                workSheet.Cells[1, "B"] = "Current Balance";

                var row = 1;
                foreach (var acct in accounts)
                {
                    row++;
                    workSheet.Cells[row, "A"] = acct.ID;
                    workSheet.Cells[row, "B"] = acct.Balance;
                }

                workSheet.Columns[1].AutoFit();
                workSheet.Columns[2].AutoFit();


            }

            var bankAccounts = new List<Account>
            {
                new Account
                {
                  ID = 345678,
                  Balance = 541.27
                },
                new Account
                {
                  ID = 1230221,
                  Balance = -127.44
                }
            };
            DisplayInExcel(bankAccounts);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        void Application_WorkbookBeforeSave(Microsoft.Office.Interop.Excel.Workbook Wb, bool SaveAsUI, ref bool Cancel)
        {
            Excel.Worksheet activeWorksheet = ((Excel.Worksheet)Application.ActiveSheet);
            Excel.Range firstRow = activeWorksheet.get_Range("A1");
            firstRow.EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown);
            Excel.Range newFirstRow = activeWorksheet.get_Range("A1");
            newFirstRow.Value2 = "This text was added by using code";
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
