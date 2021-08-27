<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128613928/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T177074)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ExternalReferencesLoadSample/Form1.cs) (VB: [Form1.vb](./VB/ExternalReferencesLoadSample/Form1.vb))
<!-- default file list end -->
# How to update external references in the loaded workbook.


When the SpreadsheetControl loads a workbook containing external references, they are added to the <a href="http://help.devexpress.com/#CoreLibraries/DevExpressSpreadsheetIWorkbook_ExternalWorkbookstopic">IWorkbook.ExternalWorkbooks</a> collection. However, the external references, created in this manner, are not "live". The references contain cached data and the SpreadsheetControl cannot update them.<br />To make a reference updateable, it should be replaced with a reference to a workbook instance. <br />Note that the use of the <a href="http://help.devexpress.com/#DocumentServer/clsDevExpressSpreadsheetWorkbooktopic">Workbook</a> class instance in production code requires a license to the <a href="https://www.devexpress.com/Products/NET/Document-Server/">Office File API</a> or the <a href="https://www.devexpress.com/Products/NET/Document-Server/pricing.xml">DevExpress Universal Subscription</a>. <br /><br />This example demonstrates how to accomplish this. To create a workbook instance, load a workbook file into an instance of the <a href="http://help.devexpress.com/#DocumentServer/clsDevExpressSpreadsheetWorkbooktopic">Workbook</a> class (or into another SpreadsheetControl instance). <br />Subsequently the <a href="http://help.devexpress.com/#CoreLibraries/DevExpressSpreadsheetExternalWorkbookCollection_Replacetopic">ExternalWorkbookCollection.Replace</a> method is used to replace the cached reference with a live external reference.<br />Note that a workbook name in the external reference should be identical to the <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraSpreadsheetWorkbookSaveOptions_CurrentFileNametopic">WorkbookSaveOptions.CurrentFileName</a> property of the referenced workbook instance when the workbook is added to the <strong>ExternalWorkbookCollection</strong>. That is, if the workbook instance is created by loading a file using a full path, the reference should contain the full path, e.g. <strong>'C:\Temp\[Book1.xlsx]Sheet1'!B3</strong>. The string with the reference created in this manner might be too long and inconvenient in use. The <strong>Workbook.Options.Save.CurrentFileName</strong> property of a referenced workbook enables you to specify a name that is easier to read, for example, "<strong>MyExternalWorkBook</strong>". Replace the corresponding item of the <strong>ExternalWorkbookCollection</strong> with an instance of the workbook with a custom <strong>CurrentFileName</strong>, and use it in external references instead of the file name, e.g.  [<strong>MyExternalWorkBook</strong>]<strong>Sheet1!B3</strong>.

<br/>


