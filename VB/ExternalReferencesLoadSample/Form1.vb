Imports DevExpress.Spreadsheet
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace ExternalReferencesLoadSample
    Partial Public Class Form1
        Inherits Form

        ' Creating Workbook in code requires a reference to the DevExpress.Docs.vX.Y.dll assembly and a license to DevExpress Universal Subscription or DevExpress Document Server.
        ' Alternatively, you can create another SpreadsheetControl and use its Document property.
        Private myWorkbook As Workbook
        Private Shared shortName As String = "Workbook1.xlsx"
        Private Shared fullName As String = Environment.CurrentDirectory & "\" & shortName

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
'            #Region "#externalworkbook"
            Select Case radioGroup1.EditValue.ToString()
                Case "full"
                ' Option 1. To reference an external workbook, use the full path.
                    myWorkbook = New Workbook()
                    myWorkbook.LoadDocument(fullName)
                Case "filename"
                ' Option 2. To reference an external workbook, use the file name only.
                    myWorkbook = New Workbook()
                    myWorkbook.LoadDocument(shortName)
                Case "custom"
                ' Option 3. To reference an external workbook, use a custom "MyExtBook" name.
                    myWorkbook = New Workbook()
                    myWorkbook.LoadDocument(shortName)
                    myWorkbook.Options.Save.CurrentFileName = "MyExtBook"
            End Select

            spreadsheetControl1.Document.LoadDocument("Workbook2.xlsx")
            spreadsheetControl1.Document.DocumentSettings.Calculation.Mode = CalculationMode.Automatic

            ' Adjust the external reference which already exists in the loaded workbook.
            spreadsheetControl1.Document.ExternalWorkbooks.Replace(0, myWorkbook)

            ' Insert a formula with an external reference that uses the full path.
            spreadsheetControl1.Document.Worksheets(0).Cells("B1").Formula = String.Format("SUM('{0}\{1}'!test)", Environment.CurrentDirectory, shortName)
            spreadsheetControl1.Document.Calculate()
'            #End Region ' #externalworkbook
            spreadsheetControl1.ActiveWorksheet.SelectedCell = spreadsheetControl1.ActiveWorksheet.Cells("B1")
        End Sub
    End Class
End Namespace
