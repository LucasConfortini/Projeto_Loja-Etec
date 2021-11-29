namespace Lavest
{
    partial class frmQuitarContaReceber
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
            this.view_ContaReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ContaReceberTableAdapter = new Lavest.lojaDataSetTableAdapters.View_ContaReceberTableAdapter();
            this.tableAdapterManager = new Lavest.lojaDataSetTableAdapters.TableAdapterManager();
            this.view_ContaReceberDataGridView = new System.Windows.Forms.DataGridView();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.conta_receberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conta_receberTableAdapter = new Lavest.lojaDataSetTableAdapters.conta_receberTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ContaReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ContaReceberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conta_receberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lojaDataSet
            // 
            this.lojaDataSet.DataSetName = "lojaDataSet";
            this.lojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_ContaReceberBindingSource
            // 
            this.view_ContaReceberBindingSource.DataMember = "View_ContaReceber";
            this.view_ContaReceberBindingSource.DataSource = this.lojaDataSet;
            // 
            // view_ContaReceberTableAdapter
            // 
            this.view_ContaReceberTableAdapter.ClearBeforeFill = true;
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
            // view_ContaReceberDataGridView
            // 
            this.view_ContaReceberDataGridView.AllowUserToAddRows = false;
            this.view_ContaReceberDataGridView.AllowUserToDeleteRows = false;
            this.view_ContaReceberDataGridView.AutoGenerateColumns = false;
            this.view_ContaReceberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_ContaReceberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.view_ContaReceberDataGridView.DataSource = this.view_ContaReceberBindingSource;
            this.view_ContaReceberDataGridView.Location = new System.Drawing.Point(11, 41);
            this.view_ContaReceberDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.view_ContaReceberDataGridView.Name = "view_ContaReceberDataGridView";
            this.view_ContaReceberDataGridView.ReadOnly = true;
            this.view_ContaReceberDataGridView.Size = new System.Drawing.Size(776, 264);
            this.view_ContaReceberDataGridView.TabIndex = 1;
            this.view_ContaReceberDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_ContaReceberDataGridView_CellDoubleClick);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(208, 6);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(198, 26);
            this.txtNomeCliente.TabIndex = 2;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.txtNomeCliente_TextChanged);
            // 
            // conta_receberBindingSource
            // 
            this.conta_receberBindingSource.DataMember = "conta_receber";
            this.conta_receberBindingSource.DataSource = this.lojaDataSet;
            // 
            // conta_receberTableAdapter
            // 
            this.conta_receberTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o nome do cliente:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Lavest.Properties.Resources.Crystal_Clear_action_exit_svg;
            this.pictureBox1.Location = new System.Drawing.Point(772, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_con";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código da Conta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_CLI";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "num_parc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Número de Parcelas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor_con";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor da Conta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dta_venc";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data de Vencimento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dta_rec";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data de Recebimento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "valor_rec";
            this.dataGridViewTextBoxColumn7.HeaderText = "Valor a Receber";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 175;
            // 
            // frmQuitarContaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 336);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.view_ContaReceberDataGridView);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmQuitarContaReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.frmQuitarContaReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ContaReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ContaReceberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conta_receberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lojaDataSet lojaDataSet;
        private System.Windows.Forms.BindingSource view_ContaReceberBindingSource;
        private lojaDataSetTableAdapters.View_ContaReceberTableAdapter view_ContaReceberTableAdapter;
        private lojaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView view_ContaReceberDataGridView;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.BindingSource conta_receberBindingSource;
        private lojaDataSetTableAdapters.conta_receberTableAdapter conta_receberTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}