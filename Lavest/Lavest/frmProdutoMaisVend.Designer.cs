namespace Lavest
{
    partial class frmProdutoMaisVend
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutoMaisVend));
            this.View_ProdutosMaisVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDataSet = new Lavest.lojaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_ProdutosMaisVendidosTableAdapter = new Lavest.lojaDataSetTableAdapters.View_ProdutosMaisVendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_ProdutosMaisVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // View_ProdutosMaisVendidosBindingSource
            // 
            this.View_ProdutosMaisVendidosBindingSource.DataMember = "View_ProdutosMaisVendidos";
            this.View_ProdutosMaisVendidosBindingSource.DataSource = this.lojaDataSet;
            // 
            // lojaDataSet
            // 
            this.lojaDataSet.DataSetName = "lojaDataSet";
            this.lojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.View_ProdutosMaisVendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Lavest.RelProdutosMaisVendidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(656, 481);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // View_ProdutosMaisVendidosTableAdapter
            // 
            this.View_ProdutosMaisVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // frmProdutoMaisVend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 481);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdutoMaisVend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Produtos Mais Vendidos";
            this.Load += new System.EventHandler(this.frmProdutoMaisVend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_ProdutosMaisVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_ProdutosMaisVendidosBindingSource;
        private lojaDataSet lojaDataSet;
        private lojaDataSetTableAdapters.View_ProdutosMaisVendidosTableAdapter View_ProdutosMaisVendidosTableAdapter;
    }
}