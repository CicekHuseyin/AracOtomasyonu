
namespace Otomsayon
{
    partial class AracRapor
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
            this.TblAracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AracOtomasyonDataSet = new Otomsayon.AracOtomasyonDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TblAracTableAdapter = new Otomsayon.AracOtomasyonDataSetTableAdapters.TblAracTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TblAracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AracOtomasyonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TblAracBindingSource
            // 
            this.TblAracBindingSource.DataMember = "TblArac";
            this.TblAracBindingSource.DataSource = this.AracOtomasyonDataSet;
            // 
            // AracOtomasyonDataSet
            // 
            this.AracOtomasyonDataSet.DataSetName = "AracOtomasyonDataSet";
            this.AracOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblAracBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Otomsayon.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1159, 369);
            this.reportViewer1.TabIndex = 0;
            // 
            // TblAracTableAdapter
            // 
            this.TblAracTableAdapter.ClearBeforeFill = true;
            // 
            // AracRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1159, 369);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AracRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracRapor";
            this.Load += new System.EventHandler(this.AracRaporla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblAracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AracOtomasyonDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblAracBindingSource;
        private AracOtomasyonDataSet AracOtomasyonDataSet;
        private AracOtomasyonDataSetTableAdapters.TblAracTableAdapter TblAracTableAdapter;
    }
}