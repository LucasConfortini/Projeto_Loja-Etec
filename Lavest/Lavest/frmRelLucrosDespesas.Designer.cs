namespace Lavest
{
    partial class frmRelLucrosDespesas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelLucrosDespesas));
            this.contas_pessoaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDataSet = new Lavest.lojaDataSet();
            this.contas_pagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conta_receberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.contas_pessoaisTableAdapter = new Lavest.lojaDataSetTableAdapters.contas_pessoaisTableAdapter();
            this.contas_pagarTableAdapter = new Lavest.lojaDataSetTableAdapters.contas_pagarTableAdapter();
            this.conta_receberTableAdapter = new Lavest.lojaDataSetTableAdapters.conta_receberTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.contas_pessoaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_pagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conta_receberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contas_pessoaisBindingSource
            // 
            this.contas_pessoaisBindingSource.DataMember = "contas_pessoais";
            this.contas_pessoaisBindingSource.DataSource = this.lojaDataSet;
            // 
            // lojaDataSet
            // 
            this.lojaDataSet.DataSetName = "lojaDataSet";
            this.lojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contas_pagarBindingSource
            // 
            this.contas_pagarBindingSource.DataMember = "contas_pagar";
            this.contas_pagarBindingSource.DataSource = this.lojaDataSet;
            // 
            // conta_receberBindingSource
            // 
            this.conta_receberBindingSource.DataMember = "conta_receber";
            this.conta_receberBindingSource.DataSource = this.lojaDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.contas_pessoaisBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.contas_pagarBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.conta_receberBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Lavest.RelLucrosDespesas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 47);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(646, 424);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // contas_pessoaisTableAdapter
            // 
            this.contas_pessoaisTableAdapter.ClearBeforeFill = true;
            // 
            // contas_pagarTableAdapter
            // 
            this.contas_pagarTableAdapter.ClearBeforeFill = true;
            // 
            // conta_receberTableAdapter
            // 
            this.conta_receberTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label2.Location = new System.Drawing.Point(305, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Inicial";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Lavest.Properties.Resources.Custom_Icon_Design_Pretty_Office_8_Accept;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(598, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 31);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(392, 20);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(200, 20);
            this.dtFinal.TabIndex = 7;
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(99, 18);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(200, 20);
            this.dtInicial.TabIndex = 6;
            // 
            // frmRelLucrosDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtFinal);
            this.Controls.Add(this.dtInicial);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelLucrosDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Lucros e Despesas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelLucrosDespesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contas_pessoaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_pagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conta_receberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource contas_pessoaisBindingSource;
        private lojaDataSet lojaDataSet;
        private System.Windows.Forms.BindingSource contas_pagarBindingSource;
        private System.Windows.Forms.BindingSource conta_receberBindingSource;
        private lojaDataSetTableAdapters.contas_pessoaisTableAdapter contas_pessoaisTableAdapter;
        private lojaDataSetTableAdapters.contas_pagarTableAdapter contas_pagarTableAdapter;
        private lojaDataSetTableAdapters.conta_receberTableAdapter conta_receberTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
    }
}