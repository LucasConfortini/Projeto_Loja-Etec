namespace Lavest
{
    partial class frmClienteInad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteInad));
            this.View_ClientesInadimplentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDataSet = new Lavest.lojaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_ClientesInadimplentesTableAdapter = new Lavest.lojaDataSetTableAdapters.View_ClientesInadimplentesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_ClientesInadimplentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // View_ClientesInadimplentesBindingSource
            // 
            this.View_ClientesInadimplentesBindingSource.DataMember = "View_ClientesInadimplentes";
            this.View_ClientesInadimplentesBindingSource.DataSource = this.lojaDataSet;
            // 
            // lojaDataSet
            // 
            this.lojaDataSet.DataSetName = "lojaDataSet";
            this.lojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_ClientesInadimplentesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Lavest.RelClientesInadimplentes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(656, 481);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // View_ClientesInadimplentesTableAdapter
            // 
            this.View_ClientesInadimplentesTableAdapter.ClearBeforeFill = true;
            // 
            // frmClienteInad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 481);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClienteInad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Inadimplentes";
            this.Load += new System.EventHandler(this.frmClienteInad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_ClientesInadimplentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_ClientesInadimplentesBindingSource;
        private lojaDataSet lojaDataSet;
        private lojaDataSetTableAdapters.View_ClientesInadimplentesTableAdapter View_ClientesInadimplentesTableAdapter;
    }
}