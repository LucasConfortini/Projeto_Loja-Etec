namespace Lavest
{
    partial class frmContasPagarCompra
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
            this.lojaDataSet = new Lavest.lojaDataSet();
            this.view_ContasPagarComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ContasPagarComprasTableAdapter = new Lavest.lojaDataSetTableAdapters.View_ContasPagarComprasTableAdapter();
            this.tableAdapterManager = new Lavest.lojaDataSetTableAdapters.TableAdapterManager();
            this.view_ContasPagarComprasDataGridView = new System.Windows.Forms.DataGridView();
            this.contas_pagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contas_pagarTableAdapter = new Lavest.lojaDataSetTableAdapters.contas_pagarTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ContasPagarComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ContasPagarComprasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_pagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lojaDataSet
            // 
            this.lojaDataSet.DataSetName = "lojaDataSet";
            this.lojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_ContasPagarComprasBindingSource
            // 
            this.view_ContasPagarComprasBindingSource.DataMember = "View_ContasPagarCompras";
            this.view_ContasPagarComprasBindingSource.DataSource = this.lojaDataSet;
            // 
            // view_ContasPagarComprasTableAdapter
            // 
            this.view_ContasPagarComprasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.compraTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.conta_receberTableAdapter = null;
            this.tableAdapterManager.contas_pagarTableAdapter = null;
            this.tableAdapterManager.contas_pessoaisTableAdapter = null;
            this.tableAdapterManager.fornecedorTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.itens_compraTableAdapter = null;
            this.tableAdapterManager.itens_vendaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lavest.lojaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // view_ContasPagarComprasDataGridView
            // 
            this.view_ContasPagarComprasDataGridView.AllowUserToAddRows = false;
            this.view_ContasPagarComprasDataGridView.AllowUserToDeleteRows = false;
            this.view_ContasPagarComprasDataGridView.AutoGenerateColumns = false;
            this.view_ContasPagarComprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_ContasPagarComprasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.view_ContasPagarComprasDataGridView.DataSource = this.view_ContasPagarComprasBindingSource;
            this.view_ContasPagarComprasDataGridView.Location = new System.Drawing.Point(8, 11);
            this.view_ContasPagarComprasDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.view_ContasPagarComprasDataGridView.Name = "view_ContasPagarComprasDataGridView";
            this.view_ContasPagarComprasDataGridView.ReadOnly = true;
            this.view_ContasPagarComprasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_ContasPagarComprasDataGridView.Size = new System.Drawing.Size(776, 264);
            this.view_ContasPagarComprasDataGridView.TabIndex = 1;
            this.view_ContasPagarComprasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_ContasPagarComprasDataGridView_CellContentClick);
            this.view_ContasPagarComprasDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_ContasPagarComprasDataGridView_CellDoubleClick);
            // 
            // contas_pagarBindingSource
            // 
            this.contas_pagarBindingSource.DataMember = "contas_pagar";
            this.contas_pagarBindingSource.DataSource = this.lojaDataSet;
            // 
            // contas_pagarTableAdapter
            // 
            this.contas_pagarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_conpag";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Compra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_fornc";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Fornecedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "data_venc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data vencimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor_conpag";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor da Conta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dta_pag";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data pagamento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 175;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "valor_pago";
            this.dataGridViewTextBoxColumn6.HeaderText = "Valor Pago";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Lavest.Properties.Resources.Crystal_Clear_action_exit_svg;
            this.pictureBox1.Location = new System.Drawing.Point(766, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmContasPagarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 305);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.view_ContasPagarComprasDataGridView);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmContasPagarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Pagar";
            this.Load += new System.EventHandler(this.frmContasPagarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ContasPagarComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ContasPagarComprasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_pagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private lojaDataSet lojaDataSet;
        private System.Windows.Forms.BindingSource view_ContasPagarComprasBindingSource;
        private lojaDataSetTableAdapters.View_ContasPagarComprasTableAdapter view_ContasPagarComprasTableAdapter;
        private lojaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView view_ContasPagarComprasDataGridView;
        private System.Windows.Forms.BindingSource contas_pagarBindingSource;
        private lojaDataSetTableAdapters.contas_pagarTableAdapter contas_pagarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}