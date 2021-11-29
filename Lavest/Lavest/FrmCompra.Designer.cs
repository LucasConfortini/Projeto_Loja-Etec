namespace Lavest
{
    partial class FrmCompra
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
            System.Windows.Forms.Label cod_compraLabel;
            System.Windows.Forms.Label dta_compraLabel;
            System.Windows.Forms.Label sit_compraLabel;
            System.Windows.Forms.Label valor_totalLabel;
            System.Windows.Forms.Label cod_forncLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompra));
            this.groupBoxc = new System.Windows.Forms.GroupBox();
            this.sit_compraComboBox = new System.Windows.Forms.ComboBox();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDataSet = new Lavest.lojaDataSet();
            this.comboFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dta_compraMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cod_compraTextBox = new System.Windows.Forms.TextBox();
            this.valor_totalTextBox = new System.Windows.Forms.TextBox();
            this.compraTableAdapter = new Lavest.lojaDataSetTableAdapters.compraTableAdapter();
            this.tableAdapterManager = new Lavest.lojaDataSetTableAdapters.TableAdapterManager();
            this.compraBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.compraBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtestoque = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtqtde = new System.Windows.Forms.TextBox();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.txtcodpro = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.view_ItensCompraDataGridView = new System.Windows.Forms.DataGridView();
            this.view_ItensCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorTableAdapter = new Lavest.lojaDataSetTableAdapters.fornecedorTableAdapter();
            this.view_ItensCompraTableAdapter = new Lavest.lojaDataSetTableAdapters.View_ItensCompraTableAdapter();
            this.itens_compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itens_compraTableAdapter = new Lavest.lojaDataSetTableAdapters.itens_compraTableAdapter();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new Lavest.lojaDataSetTableAdapters.produtoTableAdapter();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.contas_pagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contas_pagarTableAdapter = new Lavest.lojaDataSetTableAdapters.contas_pagarTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            cod_compraLabel = new System.Windows.Forms.Label();
            dta_compraLabel = new System.Windows.Forms.Label();
            sit_compraLabel = new System.Windows.Forms.Label();
            valor_totalLabel = new System.Windows.Forms.Label();
            cod_forncLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBoxc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingNavigator)).BeginInit();
            this.compraBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_ItensCompraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ItensCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_pagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_compraLabel
            // 
            cod_compraLabel.AutoSize = true;
            cod_compraLabel.Location = new System.Drawing.Point(15, 39);
            cod_compraLabel.Name = "cod_compraLabel";
            cod_compraLabel.Size = new System.Drawing.Size(67, 18);
            cod_compraLabel.TabIndex = 0;
            cod_compraLabel.Text = "Código:";
            // 
            // dta_compraLabel
            // 
            dta_compraLabel.AutoSize = true;
            dta_compraLabel.Location = new System.Drawing.Point(330, 39);
            dta_compraLabel.Name = "dta_compraLabel";
            dta_compraLabel.Size = new System.Drawing.Size(138, 18);
            dta_compraLabel.TabIndex = 2;
            dta_compraLabel.Text = "Data da Compra:";
            // 
            // sit_compraLabel
            // 
            sit_compraLabel.AutoSize = true;
            sit_compraLabel.Location = new System.Drawing.Point(15, 74);
            sit_compraLabel.Name = "sit_compraLabel";
            sit_compraLabel.Size = new System.Drawing.Size(79, 18);
            sit_compraLabel.TabIndex = 4;
            sit_compraLabel.Text = "Situação:";
            // 
            // valor_totalLabel
            // 
            valor_totalLabel.AutoSize = true;
            valor_totalLabel.Location = new System.Drawing.Point(15, 106);
            valor_totalLabel.Name = "valor_totalLabel";
            valor_totalLabel.Size = new System.Drawing.Size(53, 18);
            valor_totalLabel.TabIndex = 6;
            valor_totalLabel.Text = "Valor:";
            // 
            // cod_forncLabel
            // 
            cod_forncLabel.AutoSize = true;
            cod_forncLabel.Location = new System.Drawing.Point(330, 74);
            cod_forncLabel.Name = "cod_forncLabel";
            cod_forncLabel.Size = new System.Drawing.Size(150, 18);
            cod_forncLabel.TabIndex = 8;
            cod_forncLabel.Text = "Nome Fornecedor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(538, 16);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 15);
            label4.TabIndex = 259;
            label4.Text = "Estoque";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(141, 16);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 15);
            label5.TabIndex = 257;
            label5.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(355, 16);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 15);
            label3.TabIndex = 256;
            label3.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(60, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 15);
            label2.TabIndex = 255;
            label2.Text = "Código";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(460, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 254;
            label1.Text = "Preço";
            // 
            // groupBoxc
            // 
            this.groupBoxc.Controls.Add(this.button2);
            this.groupBoxc.Controls.Add(this.button1);
            this.groupBoxc.Controls.Add(this.sit_compraComboBox);
            this.groupBoxc.Controls.Add(this.comboFornecedor);
            this.groupBoxc.Controls.Add(this.dta_compraMaskedTextBox);
            this.groupBoxc.Controls.Add(cod_compraLabel);
            this.groupBoxc.Controls.Add(this.cod_compraTextBox);
            this.groupBoxc.Controls.Add(dta_compraLabel);
            this.groupBoxc.Controls.Add(sit_compraLabel);
            this.groupBoxc.Controls.Add(valor_totalLabel);
            this.groupBoxc.Controls.Add(this.valor_totalTextBox);
            this.groupBoxc.Controls.Add(cod_forncLabel);
            this.groupBoxc.Enabled = false;
            this.groupBoxc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxc.Location = new System.Drawing.Point(12, 37);
            this.groupBoxc.Name = "groupBoxc";
            this.groupBoxc.Size = new System.Drawing.Size(819, 161);
            this.groupBoxc.TabIndex = 0;
            this.groupBoxc.TabStop = false;
            this.groupBoxc.Text = "Cadastro de Compra";
            this.groupBoxc.Enter += new System.EventHandler(this.groupBoxc_Enter);
            // 
            // sit_compraComboBox
            // 
            this.sit_compraComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "sit_compra", true));
            this.sit_compraComboBox.FormattingEnabled = true;
            this.sit_compraComboBox.Items.AddRange(new object[] {
            "Aberta",
            "Finalizada"});
            this.sit_compraComboBox.Location = new System.Drawing.Point(100, 66);
            this.sit_compraComboBox.Name = "sit_compraComboBox";
            this.sit_compraComboBox.Size = new System.Drawing.Size(121, 26);
            this.sit_compraComboBox.TabIndex = 11;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "compra";
            this.compraBindingSource.DataSource = this.lojaDataSet;
            // 
            // lojaDataSet
            // 
            this.lojaDataSet.DataSetName = "lojaDataSet";
            this.lojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboFornecedor
            // 
            this.comboFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.compraBindingSource, "cod_fornc", true));
            this.comboFornecedor.DataSource = this.fornecedorBindingSource;
            this.comboFornecedor.DisplayMember = "nome_fornc";
            this.comboFornecedor.FormattingEnabled = true;
            this.comboFornecedor.Location = new System.Drawing.Point(493, 66);
            this.comboFornecedor.Name = "comboFornecedor";
            this.comboFornecedor.Size = new System.Drawing.Size(121, 26);
            this.comboFornecedor.TabIndex = 10;
            this.comboFornecedor.ValueMember = "cod_fornc";
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            this.fornecedorBindingSource.DataSource = this.lojaDataSet;
            // 
            // dta_compraMaskedTextBox
            // 
            this.dta_compraMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "dta_compra", true));
            this.dta_compraMaskedTextBox.Location = new System.Drawing.Point(493, 31);
            this.dta_compraMaskedTextBox.Mask = "00/00/0000";
            this.dta_compraMaskedTextBox.Name = "dta_compraMaskedTextBox";
            this.dta_compraMaskedTextBox.Size = new System.Drawing.Size(100, 26);
            this.dta_compraMaskedTextBox.TabIndex = 9;
            this.dta_compraMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // cod_compraTextBox
            // 
            this.cod_compraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "cod_compra", true));
            this.cod_compraTextBox.Location = new System.Drawing.Point(100, 31);
            this.cod_compraTextBox.Name = "cod_compraTextBox";
            this.cod_compraTextBox.Size = new System.Drawing.Size(54, 26);
            this.cod_compraTextBox.TabIndex = 1;
            this.cod_compraTextBox.TextChanged += new System.EventHandler(this.cod_compraTextBox_TextChanged);
            // 
            // valor_totalTextBox
            // 
            this.valor_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "valor_total", true));
            this.valor_totalTextBox.Location = new System.Drawing.Point(100, 103);
            this.valor_totalTextBox.Name = "valor_totalTextBox";
            this.valor_totalTextBox.Size = new System.Drawing.Size(200, 26);
            this.valor_totalTextBox.TabIndex = 7;
            this.valor_totalTextBox.TextChanged += new System.EventHandler(this.valor_totalTextBox_TextChanged);
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.compraTableAdapter = this.compraTableAdapter;
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
            // compraBindingNavigator
            // 
            this.compraBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.compraBindingNavigator.BindingSource = this.compraBindingSource;
            this.compraBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.compraBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.compraBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripButton3,
            this.compraBindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.toolStripButton2});
            this.compraBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.compraBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.compraBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.compraBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.compraBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.compraBindingNavigator.Name = "compraBindingNavigator";
            this.compraBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.compraBindingNavigator.Size = new System.Drawing.Size(839, 25);
            this.compraBindingNavigator.TabIndex = 1;
            this.compraBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::Lavest.Properties.Resources.sinal_;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::Lavest.Properties.Resources._17_512;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Cancelar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Lavest.Properties.Resources.Recycle_Bin_Full;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Excluir";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // compraBindingNavigatorSaveItem
            // 
            this.compraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.compraBindingNavigatorSaveItem.Image = global::Lavest.Properties.Resources._6a0120a9370e90970b014e5f81703d970c_800wi;
            this.compraBindingNavigatorSaveItem.Name = "compraBindingNavigatorSaveItem";
            this.compraBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.compraBindingNavigatorSaveItem.Text = "Salvar";
            this.compraBindingNavigatorSaveItem.Click += new System.EventHandler(this.compraBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Lavest.Properties.Resources.Custom_Icon_Design_Pretty_Office_9_Edit_validated;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Editar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Lavest.Properties.Resources.Crystal_Clear_action_exit_svg;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Sair";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomeProduto);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.txtestoque);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtpreco);
            this.groupBox1.Controls.Add(this.txtqtde);
            this.groupBox1.Controls.Add(this.btn_localizar);
            this.groupBox1.Controls.Add(this.txtcodpro);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.view_ItensCompraDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 339);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens da Compra";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Location = new System.Drawing.Point(144, 31);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(187, 26);
            this.txtNomeProduto.TabIndex = 260;
            // 
            // txtestoque
            // 
            this.txtestoque.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestoque.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtestoque.Location = new System.Drawing.Point(538, 33);
            this.txtestoque.Name = "txtestoque";
            this.txtestoque.ReadOnly = true;
            this.txtestoque.Size = new System.Drawing.Size(66, 22);
            this.txtestoque.TabIndex = 258;
            this.txtestoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtpreco.Location = new System.Drawing.Point(442, 33);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(72, 22);
            this.txtpreco.TabIndex = 250;
            this.txtpreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpreco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpreco_KeyDown);
            // 
            // txtqtde
            // 
            this.txtqtde.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtde.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtqtde.Location = new System.Drawing.Point(352, 33);
            this.txtqtde.Name = "txtqtde";
            this.txtqtde.Size = new System.Drawing.Size(66, 22);
            this.txtqtde.TabIndex = 249;
            this.txtqtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqtde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqtde_KeyDown);
            // 
            // btn_localizar
            // 
            this.btn_localizar.BackgroundImage = global::Lavest.Properties.Resources.search_shot_interface_symbol_with_a_magnifier_tool_318_55166;
            this.btn_localizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_localizar.FlatAppearance.BorderSize = 0;
            this.btn_localizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_localizar.Location = new System.Drawing.Point(680, 32);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(25, 23);
            this.btn_localizar.TabIndex = 253;
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // txtcodpro
            // 
            this.txtcodpro.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodpro.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtcodpro.Location = new System.Drawing.Point(55, 33);
            this.txtcodpro.Name = "txtcodpro";
            this.txtcodpro.Size = new System.Drawing.Size(66, 22);
            this.txtcodpro.TabIndex = 248;
            this.txtcodpro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcodpro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodpro_KeyDown);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = global::Lavest.Properties.Resources.iconmenos;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(645, 32);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(25, 23);
            this.btn_delete.TabIndex = 252;
            this.btn_delete.Text = "-";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::Lavest.Properties.Resources.sinal_de_mais_em_um_circulo_preto_318_41856;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(610, 32);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(25, 23);
            this.btn_add.TabIndex = 251;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // view_ItensCompraDataGridView
            // 
            this.view_ItensCompraDataGridView.AllowUserToAddRows = false;
            this.view_ItensCompraDataGridView.AllowUserToDeleteRows = false;
            this.view_ItensCompraDataGridView.AutoGenerateColumns = false;
            this.view_ItensCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_ItensCompraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.view_ItensCompraDataGridView.DataSource = this.view_ItensCompraBindingSource;
            this.view_ItensCompraDataGridView.Location = new System.Drawing.Point(6, 63);
            this.view_ItensCompraDataGridView.Name = "view_ItensCompraDataGridView";
            this.view_ItensCompraDataGridView.ReadOnly = true;
            this.view_ItensCompraDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_ItensCompraDataGridView.Size = new System.Drawing.Size(804, 264);
            this.view_ItensCompraDataGridView.TabIndex = 0;
            this.view_ItensCompraDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_ItensCompraDataGridView_CellClick);
            // 
            // view_ItensCompraBindingSource
            // 
            this.view_ItensCompraBindingSource.DataMember = "View_ItensCompra";
            this.view_ItensCompraBindingSource.DataSource = this.lojaDataSet;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // view_ItensCompraTableAdapter
            // 
            this.view_ItensCompraTableAdapter.ClearBeforeFill = true;
            // 
            // itens_compraBindingSource
            // 
            this.itens_compraBindingSource.DataMember = "itens_compra";
            this.itens_compraBindingSource.DataSource = this.lojaDataSet;
            // 
            // itens_compraTableAdapter
            // 
            this.itens_compraTableAdapter.ClearBeforeFill = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.lojaDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(735, 549);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(96, 34);
            this.btnFinalizar.TabIndex = 249;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
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
            this.dataGridViewTextBoxColumn1.DataPropertyName = "num_itemC";
            this.dataGridViewTextBoxColumn1.HeaderText = "Número do Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "desc_prod";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição do Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "qtd_itemC";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade de Item";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor_unit";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor Unitário";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cod_prod";
            this.dataGridViewTextBoxColumn5.HeaderText = "Código do Produto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cod_compra";
            this.dataGridViewTextBoxColumn6.HeaderText = "Código da Compra";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 180;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "subtotal";
            this.dataGridViewTextBoxColumn7.HeaderText = "Sub Total";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "Adicionar Fornecedor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 53);
            this.button2.TabIndex = 13;
            this.button2.Text = "Adicionar Produto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 587);
            this.ControlBox = false;
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.compraBindingNavigator);
            this.Controls.Add(this.groupBoxc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            this.groupBoxc.ResumeLayout(false);
            this.groupBoxc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingNavigator)).EndInit();
            this.compraBindingNavigator.ResumeLayout(false);
            this.compraBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_ItensCompraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ItensCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_pagarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxc;
        private lojaDataSet lojaDataSet;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private lojaDataSetTableAdapters.compraTableAdapter compraTableAdapter;
        private lojaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator compraBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton compraBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cod_compraTextBox;
        private System.Windows.Forms.TextBox valor_totalTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox dta_compraMaskedTextBox;
        private System.Windows.Forms.ComboBox comboFornecedor;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private lojaDataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.ComboBox sit_compraComboBox;
        private System.Windows.Forms.BindingSource view_ItensCompraBindingSource;
        private lojaDataSetTableAdapters.View_ItensCompraTableAdapter view_ItensCompraTableAdapter;
        private System.Windows.Forms.DataGridView view_ItensCompraDataGridView;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtestoque;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtqtde;
        private System.Windows.Forms.Button btn_localizar;
        private System.Windows.Forms.TextBox txtcodpro;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.BindingSource itens_compraBindingSource;
        private lojaDataSetTableAdapters.itens_compraTableAdapter itens_compraTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private lojaDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.BindingSource contas_pagarBindingSource;
        private lojaDataSetTableAdapters.contas_pagarTableAdapter contas_pagarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}