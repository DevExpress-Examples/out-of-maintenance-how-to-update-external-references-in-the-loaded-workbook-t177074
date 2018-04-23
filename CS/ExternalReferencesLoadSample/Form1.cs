using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternalReferencesLoadSample
{
    public partial class Form1 : Form
    {
        // Creating Workbook in code requires a reference to the DevExpress.Docs.vX.Y.dll assembly and a license to DevExpress Universal Subscription or DevExpress Document Server.
        // Alternatively, you can create another SpreadsheetControl and use its Document property.
        Workbook myWorkbook;
        static string shortName = "Workbook1.xlsx";
        static string fullName = Environment.CurrentDirectory + "\\" + shortName;

        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            #region #externalworkbook
            switch (radioGroup1.EditValue.ToString())
            {
                case "full":
                // Option 1. To reference an external workbook, use the full path.
                    myWorkbook = new Workbook();
                    myWorkbook.LoadDocument(fullName);
                    break;
                case "filename":
                // Option 2. To reference an external workbook, use the file name only.
                    myWorkbook = new Workbook();
                    myWorkbook.LoadDocument(shortName);
                    break;
                case "custom":
                // Option 3. To reference an external workbook, use a custom "MyExtBook" name.
                    myWorkbook = new Workbook();
                    myWorkbook.LoadDocument(shortName);
                    myWorkbook.Options.Save.CurrentFileName = "MyExtBook";
                    break;
            }
            
            spreadsheetControl1.Document.LoadDocument("Workbook2.xlsx");
            spreadsheetControl1.Document.DocumentSettings.Calculation.Mode = CalculationMode.Automatic;

            // Adjust the external reference which already exists in the loaded workbook.
            spreadsheetControl1.Document.ExternalWorkbooks.Replace(0, myWorkbook);

            // Insert a formula with an external reference that uses the full path.
            spreadsheetControl1.Document.Worksheets[0].Cells["B1"].Formula = String.Format("SUM('{0}\\{1}'!test)", Environment.CurrentDirectory, shortName);
            spreadsheetControl1.Document.Calculate();
            #endregion #externalworkbook
            spreadsheetControl1.ActiveWorksheet.SelectedCell = spreadsheetControl1.ActiveWorksheet.Cells["B1"];
        }
    }
}
