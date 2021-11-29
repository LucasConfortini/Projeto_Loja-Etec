namespace Lavest
{
    partial class FrmVenda
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
            System.Windows.Forms.Label cod_vendaLabel;
            System.Windows.Forms.Label dta_vendaLabel;
            System.Windows.Forms.Label tipo_vendaLabel;
            System.Windows.Forms.Label cod_cliLabel;
            System.Windows.Forms.Label cod_funcLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.view_TotalVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDataSet = new Lavest.lojaDataSet();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.totalLabel1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboFunc = new System.Windows.Forms.ComboBox();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dta_vendaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tipo_vendaComboBox = new System.Windows.Forms.ComboBox();
            this.cod_vendaTextBox = new System.Windows.Forms.TextBox();
            this.vendaTableAdapter = new Lavest.lojaDataSetTableAdapters.vendaTableAdapter();
            this.tableAdapterManager = new Lavest.lojaDataSetTableAdapters.TableAdapterManager();
            this.vendaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vendaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.clienteTableAdapter = new Lavest.lojaDataSetTableAdapters.clienteTableAdapter();
            this.funcionarioTableAdapter = new Lavest.lojaDataSetTableAdapters.funcionarioTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PanelFinalizar = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtArredondamento = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroParcela = new System.Windows.Forms.NumericUpDown();
            this.txtValorParcela = new System.Windows.Forms.TextBox();
            this.RadioPrazo = new System.Windows.Forms.RadioButton();
            this.radioVista = new System.Windows.Forms.RadioButton();
            this.btnOKCONTA = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtestoque = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtqtde = new System.Windows.Forms.TextBox();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.txtcodpro = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.viewItensVendaDataGridView = new System.Windows.Forms.DataGridView();
            this.viewItensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewItensVendaTableAdapter = new Lavest.lojaDataSetTableAdapters.ViewItensVendaTableAdapter();
            this.produtoTableAdapter = new Lavest.lojaDataSetTableAdapters.produtoTableAdapter();
            this.itens_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itens_vendaTableAdapter = new Lavest.lojaDataSetTableAdapters.itens_vendaTableAdapter();
            this.view_TotalVendaTableAdapter = new Lavest.lojaDataSetTableAdapters.View_TotalVendaTableAdapter();
            this.conta_receberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conta_receberTableAdapter = new Lavest.lojaDataSetTableAdapters.conta_receberTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cod_vendaLabel = new System.Windows.Forms.Label();
            dta_vendaLabel = new System.Windows.Forms.Label();
            tipo_vendaLabel = new System.Windows.Forms.Label();
            cod_cliLabel = new System.Windows.Forms.Label();
            cod_funcLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view_TotalVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingNavigator)).BeginInit();
            this.vendaBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PanelFinalizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroParcela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewItensVendaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewItensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conta_receberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_vendaLabel
            // 
            cod_vendaLabel.AutoSize = true;
            cod_vendaLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_vendaLabel.Location = new System.Drawing.Point(8, 27);
            cod_vendaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cod_vendaLabel.Name = "cod_vendaLabel";
            cod_vendaLabel.Size = new System.Drawing.Size(149, 18);
            cod_vendaLabel.TabIndex = 0;
            cod_vendaLabel.Text = "Número da Venda:";
            // 
            // dta_vendaLabel
            // 
            dta_vendaLabel.AutoSize = true;
            dta_vendaLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dta_vendaLabel.Location = new System.Drawing.Point(684, 69);
            dta_vendaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dta_vendaLabel.Name = "dta_vendaLabel";
            dta_vendaLabel.Size = new System.Drawing.Size(100, 18);
            dta_vendaLabel.TabIndex = 2;
            dta_vendaLabel.Text = "Data venda:";
            // 
            // tipo_vendaLabel
            // 
            tipo_vendaLabel.AutoSize = true;
            tipo_vendaLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipo_vendaLabel.Location = new System.Drawing.Point(684, 117);
            tipo_vendaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tipo_vendaLabel.Name = "tipo_vendaLabel";
            tipo_vendaLabel.Size = new System.Drawing.Size(96, 18);
            tipo_vendaLabel.TabIndex = 4;
            tipo_vendaLabel.Text = "Tipo venda:";
            // 
            // cod_cliLabel
            // 
            cod_cliLabel.AutoSize = true;
            cod_cliLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_cliLabel.Location = new System.Drawing.Point(92, 74);
            cod_cliLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cod_cliLabel.Name = "cod_cliLabel";
            cod_cliLabel.Size = new System.Drawing.Size(65, 18);
            cod_cliLabel.TabIndex = 8;
            cod_cliLabel.Text = "Cliente:";
            // 
            // cod_funcLabel
            // 
            cod_funcLabel.AutoSize = true;
            cod_funcLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_funcLabel.Location = new System.Drawing.Point(57, 113);
            cod_funcLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cod_funcLabel.Name = "cod_funcLabel";
            cod_funcLabel.Size = new System.Drawing.Size(100, 18);
            cod_funcLabel.TabIndex = 10;
            cod_funcLabel.Text = "Funcionário:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(609, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 15);
            label4.TabIndex = 246;
            label4.Text = "Estoque";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(212, 20);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 15);
            label5.TabIndex = 244;
            label5.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(426, 20);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 15);
            label3.TabIndex = 243;
            label3.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(131, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 15);
            label2.TabIndex = 242;
            label2.Text = "Código";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(531, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 241;
            label1.Text = "Preço";
            // 
            // view_TotalVendaBindingSource
            // 
            this.view_TotalVendaBindingSource.DataMember = "View_TotalVenda";
            this.view_TotalVendaBindingSource.DataSource = this.lojaDataSet;
            // 
            // lojaDataSet
            // 
            this.lojaDataSet.DataSetName = "lojaDataSet";
            this.lojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.button1);
            this.GroupBox1.Controls.Add(this.totalLabel1);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.ComboFunc);
            this.GroupBox1.Controls.Add(this.ComboCliente);
            this.GroupBox1.Controls.Add(this.dta_vendaMaskedTextBox);
            this.GroupBox1.Controls.Add(this.tipo_vendaComboBox);
            this.GroupBox1.Controls.Add(cod_vendaLabel);
            this.GroupBox1.Controls.Add(this.cod_vendaTextBox);
            this.GroupBox1.Controls.Add(dta_vendaLabel);
            this.GroupBox1.Controls.Add(tipo_vendaLabel);
            this.GroupBox1.Controls.Add(cod_cliLabel);
            this.GroupBox1.Controls.Add(cod_funcLabel);
            this.GroupBox1.Enabled = false;
            this.GroupBox1.Location = new System.Drawing.Point(38, 39);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(997, 208);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Vendas";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Lavest.Properties.Resources.adduser_49611;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(50, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // totalLabel1
            // 
            this.totalLabel1.AutoSize = true;
            this.totalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_TotalVendaBindingSource, "Total", true));
            this.totalLabel1.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.totalLabel1.Location = new System.Drawing.Point(802, 155);
            this.totalLabel1.Name = "totalLabel1";
            this.totalLabel1.Size = new System.Drawing.Size(0, 32);
            this.totalLabel1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(656, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total: R$";
            // 
            // ComboFunc
            // 
            this.ComboFunc.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "cod_func", true));
            this.ComboFunc.DataSource = this.funcionarioBindingSource;
            this.ComboFunc.DisplayMember = "NOME_FUNC";
            this.ComboFunc.FormattingEnabled = true;
            this.ComboFunc.Location = new System.Drawing.Point(169, 113);
            this.ComboFunc.Margin = new System.Windows.Forms.Padding(4);
            this.ComboFunc.Name = "ComboFunc";
            this.ComboFunc.Size = new System.Drawing.Size(490, 26);
            this.ComboFunc.TabIndex = 15;
            this.ComboFunc.ValueMember = "COD_FUNC";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.lojaDataSet;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.lojaDataSet;
            // 
            // ComboCliente
            // 
            this.ComboCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "cod_cli", true));
            this.ComboCliente.DataSource = this.clienteBindingSource;
            this.ComboCliente.DisplayMember = "NOME_CLI";
            this.ComboCliente.FormattingEnabled = true;
            this.ComboCliente.Location = new System.Drawing.Point(169, 66);
            this.ComboCliente.Margin = new System.Windows.Forms.Padding(4);
            this.ComboCliente.Name = "ComboCliente";
            this.ComboCliente.Size = new System.Drawing.Size(490, 26);
            this.ComboCliente.TabIndex = 14;
            this.ComboCliente.ValueMember = "COD_CLI";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.lojaDataSet;
            // 
            // dta_vendaMaskedTextBox
            // 
            this.dta_vendaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "dta_venda", true));
            this.dta_vendaMaskedTextBox.Location = new System.Drawing.Point(808, 65);
            this.dta_vendaMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dta_vendaMaskedTextBox.Mask = "00/00/0000";
            this.dta_vendaMaskedTextBox.Name = "dta_vendaMaskedTextBox";
            this.dta_vendaMaskedTextBox.Size = new System.Drawing.Size(118, 26);
            this.dta_vendaMaskedTextBox.TabIndex = 13;
            this.dta_vendaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // tipo_vendaComboBox
            // 
            this.tipo_vendaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "tipo_venda", true));
            this.tipo_vendaComboBox.FormattingEnabled = true;
            this.tipo_vendaComboBox.Items.AddRange(new object[] {
            "Aberta",
            "Orçamento",
            "Finalizada"});
            this.tipo_vendaComboBox.Location = new System.Drawing.Point(808, 113);
            this.tipo_vendaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tipo_vendaComboBox.Name = "tipo_vendaComboBox";
            this.tipo_vendaComboBox.Size = new System.Drawing.Size(156, 26);
            this.tipo_vendaComboBox.TabIndex = 12;
            // 
            // cod_vendaTextBox
            // 
            this.cod_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "cod_venda", true));
            this.cod_vendaTextBox.Location = new System.Drawing.Point(169, 24);
            this.cod_vendaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cod_vendaTextBox.Name = "cod_vendaTextBox";
            this.cod_vendaTextBox.Size = new System.Drawing.Size(78, 26);
            this.cod_vendaTextBox.TabIndex = 1;
            this.cod_vendaTextBox.TextChanged += new System.EventHandler(this.cod_vendaTextBox_TextChanged);
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.compraTableAdapter = null;
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
            this.tableAdapterManager.vendaTableAdapter = this.vendaTableAdapter;
            // 
            // vendaBindingNavigator
            // 
            this.vendaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendaBindingNavigator.BindingSource = this.vendaBindingSource;
            this.vendaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.vendaBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.vendaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendaBindingNavigator.Name = "vendaBindingNavigator";
            this.vendaBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.vendaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendaBindingNavigator.Size = new System.Drawing.Size(1028, 25);
            this.vendaBindingNavigator.TabIndex = 1;
            this.vendaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::Lavest.Properties.Resources.sinal_1;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar cadastro";
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
            this.bindingNavigatorDeleteItem.Image = global::Lavest.Properties.Resources.Recycle_Bin_Full;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
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
            // vendaBindingNavigatorSaveItem
            // 
            this.vendaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendaBindingNavigatorSaveItem.Image = global::Lavest.Properties.Resources._6a0120a9370e90970b014e5f81703d970c_800wi;
            this.vendaBindingNavigatorSaveItem.Name = "vendaBindingNavigatorSaveItem";
            this.vendaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vendaBindingNavigatorSaveItem.Text = "Salvar";
            this.vendaBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendaBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Lavest.Properties.Resources._17_512;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Cancelar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Lavest.Properties.Resources.Custom_Icon_Design_Pretty_Office_9_Edit_validated;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Editar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Lavest.Properties.Resources.Crystal_Clear_action_exit_svg;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Sair";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PanelFinalizar);
            this.groupBox2.Controls.Add(this.btnFinalizar);
            this.groupBox2.Controls.Add(this.txtNomeProduto);
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Controls.Add(this.txtestoque);
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.txtpreco);
            this.groupBox2.Controls.Add(this.txtqtde);
            this.groupBox2.Controls.Add(this.btn_localizar);
            this.groupBox2.Controls.Add(this.txtcodpro);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.viewItensVendaDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(38, 230);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(987, 503);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens da Venda";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // PanelFinalizar
            // 
            this.PanelFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelFinalizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelFinalizar.Controls.Add(this.label10);
            this.PanelFinalizar.Controls.Add(this.label9);
            this.PanelFinalizar.Controls.Add(this.label8);
            this.PanelFinalizar.Controls.Add(this.label7);
            this.PanelFinalizar.Controls.Add(this.txtArredondamento);
            this.PanelFinalizar.Controls.Add(this.txtData);
            this.PanelFinalizar.Controls.Add(this.txtNumeroParcela);
            this.PanelFinalizar.Controls.Add(this.txtValorParcela);
            this.PanelFinalizar.Controls.Add(this.RadioPrazo);
            this.PanelFinalizar.Controls.Add(this.radioVista);
            this.PanelFinalizar.Controls.Add(this.btnOKCONTA);
            this.PanelFinalizar.Location = new System.Drawing.Point(263, 92);
            this.PanelFinalizar.Name = "PanelFinalizar";
            this.PanelFinalizar.Size = new System.Drawing.Size(461, 319);
            this.PanelFinalizar.TabIndex = 249;
            this.PanelFinalizar.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Parcela";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Arredondamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Valor";
            // 
            // txtArredondamento
            // 
            this.txtArredondamento.Location = new System.Drawing.Point(182, 178);
            this.txtArredondamento.Name = "txtArredondamento";
            this.txtArredondamento.Size = new System.Drawing.Size(100, 26);
            this.txtArredondamento.TabIndex = 6;
            this.txtArredondamento.TextChanged += new System.EventHandler(this.txtArredondamento_TextChanged);
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(178, 88);
            this.txtData.MinDate = new System.DateTime(2016, 11, 9, 0, 0, 0, 0);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(125, 26);
            this.txtData.TabIndex = 5;
            // 
            // txtNumeroParcela
            // 
            this.txtNumeroParcela.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNumeroParcela.Location = new System.Drawing.Point(178, 133);
            this.txtNumeroParcela.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumeroParcela.Name = "txtNumeroParcela";
            this.txtNumeroParcela.Size = new System.Drawing.Size(120, 26);
            this.txtNumeroParcela.TabIndex = 4;
            this.txtNumeroParcela.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumeroParcela.ValueChanged += new System.EventHandler(this.txtNumeroParcela_ValueChanged);
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.Location = new System.Drawing.Point(136, 219);
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.Size = new System.Drawing.Size(193, 26);
            this.txtValorParcela.TabIndex = 3;
            // 
            // RadioPrazo
            // 
            this.RadioPrazo.AutoSize = true;
            this.RadioPrazo.Location = new System.Drawing.Point(257, 45);
            this.RadioPrazo.Name = "RadioPrazo";
            this.RadioPrazo.Size = new System.Drawing.Size(84, 22);
            this.RadioPrazo.TabIndex = 2;
            this.RadioPrazo.TabStop = true;
            this.RadioPrazo.Text = "A Prazo";
            this.RadioPrazo.UseVisualStyleBackColor = true;
            // 
            // radioVista
            // 
            this.radioVista.AutoSize = true;
            this.radioVista.Location = new System.Drawing.Point(76, 45);
            this.radioVista.Name = "radioVista";
            this.radioVista.Size = new System.Drawing.Size(77, 22);
            this.radioVista.TabIndex = 1;
            this.radioVista.TabStop = true;
            this.radioVista.Text = "À Vista";
            this.radioVista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioVista.UseVisualStyleBackColor = true;
            this.radioVista.CheckedChanged += new System.EventHandler(this.radioVista_CheckedChanged);
            // 
            // btnOKCONTA
            // 
            this.btnOKCONTA.Location = new System.Drawing.Point(178, 262);
            this.btnOKCONTA.Name = "btnOKCONTA";
            this.btnOKCONTA.Size = new System.Drawing.Size(104, 33);
            this.btnOKCONTA.TabIndex = 0;
            this.btnOKCONTA.Text = "OK";
            this.btnOKCONTA.UseVisualStyleBackColor = true;
            this.btnOKCONTA.Click += new System.EventHandler(this.btnOKCONTA_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(868, 451);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(96, 34);
            this.btnFinalizar.TabIndex = 248;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Location = new System.Drawing.Point(215, 35);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(187, 26);
            this.txtNomeProduto.TabIndex = 247;
            // 
            // txtestoque
            // 
            this.txtestoque.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestoque.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtestoque.Location = new System.Drawing.Point(609, 37);
            this.txtestoque.Name = "txtestoque";
            this.txtestoque.ReadOnly = true;
            this.txtestoque.Size = new System.Drawing.Size(66, 22);
            this.txtestoque.TabIndex = 245;
            this.txtestoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtpreco.Location = new System.Drawing.Point(513, 37);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(72, 22);
            this.txtpreco.TabIndex = 237;
            this.txtpreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpreco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpreco_KeyDown);
            // 
            // txtqtde
            // 
            this.txtqtde.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtde.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtqtde.Location = new System.Drawing.Point(423, 37);
            this.txtqtde.Name = "txtqtde";
            this.txtqtde.Size = new System.Drawing.Size(66, 22);
            this.txtqtde.TabIndex = 236;
            this.txtqtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqtde.Enter += new System.EventHandler(this.txtqtde_Enter);
            this.txtqtde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqtde_KeyDown);
            // 
            // btn_localizar
            // 
            this.btn_localizar.BackgroundImage = global::Lavest.Properties.Resources.search_shot_interface_symbol_with_a_magnifier_tool_318_55166;
            this.btn_localizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_localizar.FlatAppearance.BorderSize = 0;
            this.btn_localizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_localizar.Location = new System.Drawing.Point(751, 36);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(25, 23);
            this.btn_localizar.TabIndex = 240;
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // txtcodpro
            // 
            this.txtcodpro.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodpro.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtcodpro.Location = new System.Drawing.Point(126, 37);
            this.txtcodpro.Name = "txtcodpro";
            this.txtcodpro.Size = new System.Drawing.Size(66, 22);
            this.txtcodpro.TabIndex = 234;
            this.txtcodpro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcodpro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodpro_KeyDown);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = global::Lavest.Properties.Resources.iconmenos;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(716, 36);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(25, 23);
            this.btn_delete.TabIndex = 239;
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
            this.btn_add.Location = new System.Drawing.Point(681, 36);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(25, 23);
            this.btn_add.TabIndex = 238;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // viewItensVendaDataGridView
            // 
            this.viewItensVendaDataGridView.AllowUserToAddRows = false;
            this.viewItensVendaDataGridView.AllowUserToDeleteRows = false;
            this.viewItensVendaDataGridView.AutoGenerateColumns = false;
            this.viewItensVendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewItensVendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.viewItensVendaDataGridView.DataSource = this.viewItensVendaBindingSource;
            this.viewItensVendaDataGridView.Location = new System.Drawing.Point(21, 74);
            this.viewItensVendaDataGridView.Name = "viewItensVendaDataGridView";
            this.viewItensVendaDataGridView.ReadOnly = true;
            this.viewItensVendaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewItensVendaDataGridView.Size = new System.Drawing.Size(943, 360);
            this.viewItensVendaDataGridView.TabIndex = 0;
            this.viewItensVendaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewItensVendaDataGridView_CellClick);
            // 
            // viewItensVendaBindingSource
            // 
            this.viewItensVendaBindingSource.DataMember = "ViewItensVenda";
            this.viewItensVendaBindingSource.DataSource = this.lojaDataSet;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.lojaDataSet;
            // 
            // viewItensVendaTableAdapter
            // 
            this.viewItensVendaTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // itens_vendaBindingSource
            // 
            this.itens_vendaBindingSource.DataMember = "itens_venda";
            this.itens_vendaBindingSource.DataSource = this.lojaDataSet;
            // 
            // itens_vendaTableAdapter
            // 
            this.itens_vendaTableAdapter.ClearBeforeFill = true;
            // 
            // view_TotalVendaTableAdapter
            // 
            this.view_TotalVendaTableAdapter.ClearBeforeFill = true;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "num_item";
            this.dataGridViewTextBoxColumn1.HeaderText = "Número do item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "num_venda";
            this.dataGridViewTextBoxColumn2.HeaderText = "Número da venda";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cod_prod";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código do produto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Valor Unitário";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn6.HeaderText = "Valor Unitário";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SubTotal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn7.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 756);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.vendaBindingNavigator);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_TotalVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingNavigator)).EndInit();
            this.vendaBindingNavigator.ResumeLayout(false);
            this.vendaBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PanelFinalizar.ResumeLayout(false);
            this.PanelFinalizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroParcela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewItensVendaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewItensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conta_receberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private lojaDataSet lojaDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private lojaDataSetTableAdapters.vendaTableAdapter vendaTableAdapter;
        private lojaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vendaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vendaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cod_vendaTextBox;
        private System.Windows.Forms.ComboBox tipo_vendaComboBox;
        private System.Windows.Forms.MaskedTextBox dta_vendaMaskedTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ComboBox ComboFunc;
        private System.Windows.Forms.ComboBox ComboCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private lojaDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private lojaDataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource viewItensVendaBindingSource;
        private lojaDataSetTableAdapters.ViewItensVendaTableAdapter viewItensVendaTableAdapter;
        private System.Windows.Forms.DataGridView viewItensVendaDataGridView;
        private System.Windows.Forms.TextBox txtestoque;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtqtde;
        private System.Windows.Forms.TextBox txtcodpro;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_localizar;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private lojaDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource itens_vendaBindingSource;
        private lojaDataSetTableAdapters.itens_vendaTableAdapter itens_vendaTableAdapter;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Panel PanelFinalizar;
        private System.Windows.Forms.TextBox txtValorParcela;
        private System.Windows.Forms.RadioButton RadioPrazo;
        private System.Windows.Forms.RadioButton radioVista;
        private System.Windows.Forms.Button btnOKCONTA;
        private System.Windows.Forms.NumericUpDown txtNumeroParcela;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.BindingSource view_TotalVendaBindingSource;
        private lojaDataSetTableAdapters.View_TotalVendaTableAdapter view_TotalVendaTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtArredondamento;
        private System.Windows.Forms.Label totalLabel1;
        private System.Windows.Forms.BindingSource conta_receberBindingSource;
        private lojaDataSetTableAdapters.conta_receberTableAdapter conta_receberTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}