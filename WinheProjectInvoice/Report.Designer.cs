namespace WinheProjectInvoice
{
    partial class Report
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Proc_GetdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new WinheProjectInvoice.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Proc_GetdataTableAdapter = new WinheProjectInvoice.DataSet1TableAdapters.Proc_GetdataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Proc_GetdataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Proc_GetdataBindingSource
            // 
            this.Proc_GetdataBindingSource.DataMember = "Proc_Getdata";
            this.Proc_GetdataBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Proc_GetdataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinheProjectInvoice.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(22, 22);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1007, 707);
            this.reportViewer1.TabIndex = 0;
            // 
            // Proc_GetdataTableAdapter
            // 
            this.Proc_GetdataTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 741);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Proc_GetdataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Proc_GetdataBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.Proc_GetdataTableAdapter Proc_GetdataTableAdapter;
    }
}