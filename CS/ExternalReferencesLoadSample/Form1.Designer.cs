namespace ExternalReferencesLoadSample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.spreadsheetFormulaBarControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.spreadsheetFormulaBarControl1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.radioGroup1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(784, 96);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(284, 49);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(192, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Load file with external references";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = "full";
            this.radioGroup1.Location = new System.Drawing.Point(2, 28);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("full", "Use full path to reference an external workbook"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("filename", "Use file name in a reference"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("custom", "Use a custom name in a reference")});
            this.radioGroup1.Size = new System.Drawing.Size(264, 58);
            this.radioGroup1.TabIndex = 0;
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 96);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Size = new System.Drawing.Size(784, 345);
            this.spreadsheetControl1.TabIndex = 1;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // spreadsheetFormulaBarControl1
            // 
            this.spreadsheetFormulaBarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spreadsheetFormulaBarControl1.Location = new System.Drawing.Point(2, 2);
            this.spreadsheetFormulaBarControl1.MinimumSize = new System.Drawing.Size(0, 20);
            this.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1";
            this.spreadsheetFormulaBarControl1.Size = new System.Drawing.Size(780, 20);
            this.spreadsheetFormulaBarControl1.SpreadsheetControl = this.spreadsheetControl1;
            this.spreadsheetFormulaBarControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.spreadsheetControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl spreadsheetFormulaBarControl1;
    }
}