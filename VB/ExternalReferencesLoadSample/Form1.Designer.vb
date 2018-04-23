Namespace ExternalReferencesLoadSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
            Me.spreadsheetFormulaBarControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            DirectCast(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.spreadsheetFormulaBarControl1)
            Me.panelControl1.Controls.Add(Me.simpleButton1)
            Me.panelControl1.Controls.Add(Me.radioGroup1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(784, 96)
            Me.panelControl1.TabIndex = 0
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(284, 49)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(192, 23)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "Load file with external references"
            ' 
            ' radioGroup1
            ' 
            Me.radioGroup1.EditValue = "full"
            Me.radioGroup1.Location = New System.Drawing.Point(2, 28)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { _
                New DevExpress.XtraEditors.Controls.RadioGroupItem("full", "Use full path to reference an external workbook"), _
                New DevExpress.XtraEditors.Controls.RadioGroupItem("filename", "Use file name in a reference"), _
                New DevExpress.XtraEditors.Controls.RadioGroupItem("custom", "Use a custom name in a reference") _
            })
            Me.radioGroup1.Size = New System.Drawing.Size(264, 58)
            Me.radioGroup1.TabIndex = 0
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 96)
            Me.spreadsheetControl1.Name = "spreadsheetControl1"
            Me.spreadsheetControl1.Size = New System.Drawing.Size(784, 345)
            Me.spreadsheetControl1.TabIndex = 1
            Me.spreadsheetControl1.Text = "spreadsheetControl1"
            ' 
            ' spreadsheetFormulaBarControl1
            ' 
            Me.spreadsheetFormulaBarControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.spreadsheetFormulaBarControl1.Location = New System.Drawing.Point(2, 2)
            Me.spreadsheetFormulaBarControl1.MinimumSize = New System.Drawing.Size(0, 20)
            Me.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1"
            Me.spreadsheetFormulaBarControl1.Size = New System.Drawing.Size(780, 20)
            Me.spreadsheetFormulaBarControl1.SpreadsheetControl = Me.spreadsheetControl1
            Me.spreadsheetFormulaBarControl1.TabIndex = 2
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 441)
            Me.Controls.Add(Me.spreadsheetControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            DirectCast(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private radioGroup1 As DevExpress.XtraEditors.RadioGroup
        Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private spreadsheetFormulaBarControl1 As DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl
    End Class
End Namespace