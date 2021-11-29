namespace Lavest
{
    partial class FrmProduto
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
            System.Windows.Forms.Label cod_prodLabel;
            System.Windows.Forms.Label desc_prodLabel;
            System.Windows.Forms.Label custo_prodLabel;
            System.Windows.Forms.Label qtd_prodLabel;
            System.Windows.Forms.Label qtd_minLabel;
            System.Windows.Forms.Label valor_vendaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cod_prodTextBox = new System.Windows.Forms.TextBox();
            this.desc_prodTextBox = new System.Windows.Forms.TextBox();
            this.qtd_prodTextBox = new System.Windows.Forms.TextBox();
            this.qtd_minTextBox = new System.Windows.Forms.TextBox();
            this.produtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produtoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDataSet = new Lavest.lojaDataSet();
            this.produtoTableAdapter = new Lavest.lojaDataSetTableAdapters.produtoTableAdapter();
            this.tableAdapterManager = new Lavest.lojaDataSetTableAdapters.TableAdapterManager();
            this.vendaTableAdapter1 = new Lavest.lojaDataSetTableAdapters.vendaTableAdapter();
            this.valor_vendaTextBox1 = new System.Windows.Forms.TextBox();
            this.custo_prodTextBox1 = new System.Windows.Forms.TextBox();
            cod_prodLabel = new System.Windows.Forms.Label();
            desc_prodLabel = new System.Windows.Forms.Label();
            custo_prodLabel = new System.Windows.Forms.Label();
            qtd_prodLabel = new System.Windows.Forms.Label();
            qtd_minLabel = new System.Windows.Forms.Label();
            valor_vendaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).BeginInit();
            this.produtoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_prodLabel
            // 
            cod_prodLabel.AutoSize = true;
            cod_prodLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_prodLabel.Location = new System.Drawing.Point(6, 16);
            cod_prodLabel.Name = "cod_prodLabel";
            cod_prodLabel.Size = new System.Drawing.Size(67, 18);
            cod_prodLabel.TabIndex = 0;
            cod_prodLabel.Text = "Código:";
            // 
            // desc_prodLabel
            // 
            desc_prodLabel.AutoSize = true;
            desc_prodLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            desc_prodLabel.Location = new System.Drawing.Point(6, 42);
            desc_prodLabel.Name = "desc_prodLabel";
            desc_prodLabel.Size = new System.Drawing.Size(87, 18);
            desc_prodLabel.TabIndex = 2;
            desc_prodLabel.Text = "Descrição:";
            // 
            // custo_prodLabel
            // 
            custo_prodLabel.AutoSize = true;
            custo_prodLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            custo_prodLabel.Location = new System.Drawing.Point(6, 68);
            custo_prodLabel.Name = "custo_prodLabel";
            custo_prodLabel.Size = new System.Drawing.Size(59, 18);
            custo_prodLabel.TabIndex = 4;
            custo_prodLabel.Text = "Custo:";
            // 
            // qtd_prodLabel
            // 
            qtd_prodLabel.AutoSize = true;
            qtd_prodLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtd_prodLabel.Location = new System.Drawing.Point(6, 94);
            qtd_prodLabel.Name = "qtd_prodLabel";
            qtd_prodLabel.Size = new System.Drawing.Size(99, 18);
            qtd_prodLabel.TabIndex = 6;
            qtd_prodLabel.Text = "Quantidade:";
            // 
            // qtd_minLabel
            // 
            qtd_minLabel.AutoSize = true;
            qtd_minLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtd_minLabel.Location = new System.Drawing.Point(6, 120);
            qtd_minLabel.Name = "qtd_minLabel";
            qtd_minLabel.Size = new System.Drawing.Size(158, 18);
            qtd_minLabel.TabIndex = 8;
            qtd_minLabel.Text = "Quantidade mínima:";
            // 
            // valor_vendaLabel
            // 
            valor_vendaLabel.AutoSize = true;
            valor_vendaLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_vendaLabel.Location = new System.Drawing.Point(6, 146);
            valor_vendaLabel.Name = "valor_vendaLabel";
            valor_vendaLabel.Size = new System.Drawing.Size(126, 18);
            valor_vendaLabel.TabIndex = 10;
            valor_vendaLabel.Text = "Valor da venda:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.custo_prodTextBox1);
            this.groupBox1.Controls.Add(this.valor_vendaTextBox1);
            this.groupBox1.Controls.Add(cod_prodLabel);
            this.groupBox1.Controls.Add(this.cod_prodTextBox);
            this.groupBox1.Controls.Add(desc_prodLabel);
            this.groupBox1.Controls.Add(this.desc_prodTextBox);
            this.groupBox1.Controls.Add(custo_prodLabel);
            this.groupBox1.Controls.Add(qtd_prodLabel);
            this.groupBox1.Controls.Add(this.qtd_prodTextBox);
            this.groupBox1.Controls.Add(qtd_minLabel);
            this.groupBox1.Controls.Add(this.qtd_minTextBox);
            this.groupBox1.Controls.Add(valor_vendaLabel);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 419);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cod_prodTextBox
            // 
            this.cod_prodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "cod_prod", true));
            this.cod_prodTextBox.Location = new System.Drawing.Point(169, 16);
            this.cod_prodTextBox.Name = "cod_prodTextBox";
            this.cod_prodTextBox.Size = new System.Drawing.Size(53, 20);
            this.cod_prodTextBox.TabIndex = 1;
            // 
            // desc_prodTextBox
            // 
            this.desc_prodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "desc_prod", true));
            this.desc_prodTextBox.Location = new System.Drawing.Point(169, 42);
            this.desc_prodTextBox.Name = "desc_prodTextBox";
            this.desc_prodTextBox.Size = new System.Drawing.Size(100, 20);
            this.desc_prodTextBox.TabIndex = 3;
            this.desc_prodTextBox.TextChanged += new System.EventHandler(this.desc_prodTextBox_TextChanged);
            // 
            // qtd_prodTextBox
            // 
            this.qtd_prodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "qtd_prod", true));
            this.qtd_prodTextBox.Location = new System.Drawing.Point(169, 92);
            this.qtd_prodTextBox.Name = "qtd_prodTextBox";
            this.qtd_prodTextBox.Size = new System.Drawing.Size(53, 20);
            this.qtd_prodTextBox.TabIndex = 7;
            // 
            // qtd_minTextBox
            // 
            this.qtd_minTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "qtd_min", true));
            this.qtd_minTextBox.Location = new System.Drawing.Point(169, 118);
            this.qtd_minTextBox.Name = "qtd_minTextBox";
            this.qtd_minTextBox.Size = new System.Drawing.Size(53, 20);
            this.qtd_minTextBox.TabIndex = 9;
            // 
            // produtoBindingNavigator
            // 
            this.produtoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produtoBindingNavigator.BindingSource = this.produtoBindingSource;
            this.produtoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produtoBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripButton3});
            this.produtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtoBindingNavigator.Name = "produtoBindingNavigator";
            this.produtoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtoBindingNavigator.Size = new System.Drawing.Size(433, 25);
            this.produtoBindingNavigator.TabIndex = 1;
            this.produtoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::Lavest.Properties.Resources.sinal_;
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
            this.bindingNavigatorMoveFirstItem.Text = "Ir para o primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Anterior";
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
            this.bindingNavigatorMoveNextItem.Text = "Próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Ir para o último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // produtoBindingNavigatorSaveItem
            // 
            this.produtoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtoBindingNavigatorSaveItem.Image = global::Lavest.Properties.Resources._6a0120a9370e90970b014e5f81703d970c_800wi;
            this.produtoBindingNavigatorSaveItem.Name = "produtoBindingNavigatorSaveItem";
            this.produtoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produtoBindingNavigatorSaveItem.Text = "Salvar";
            this.produtoBindingNavigatorSaveItem.Click += new System.EventHandler(this.produtoBindingNavigatorSaveItem_Click);
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
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Lavest.Properties.Resources.search_shot_interface_symbol_with_a_magnifier_tool_318_55166;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Localizar um produto";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
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
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.lojaDataSet;
            // 
            // lojaDataSet
            // 
            this.lojaDataSet.DataSetName = "lojaDataSet";
            this.lojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.compraTableAdapter = null;
            //this.tableAdapterManager.conta_recentesTableAdapter = null;
            this.tableAdapterManager.contas_pagarTableAdapter = null;
            this.tableAdapterManager.contas_pessoaisTableAdapter = null;
            this.tableAdapterManager.fornecedorTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.itens_compraTableAdapter = null;
            this.tableAdapterManager.itens_vendaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lavest.lojaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // vendaTableAdapter1
            // 
            this.vendaTableAdapter1.ClearBeforeFill = true;
            // 
            // valor_vendaTextBox1
            // 
            this.valor_vendaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "valor_venda", true));
            this.valor_vendaTextBox1.Location = new System.Drawing.Point(169, 144);
            this.valor_vendaTextBox1.Name = "valor_vendaTextBox1";
            this.valor_vendaTextBox1.Size = new System.Drawing.Size(100, 20);
            this.valor_vendaTextBox1.TabIndex = 14;
            // 
            // custo_prodTextBox1
            // 
            this.custo_prodTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "custo_prod", true));
            this.custo_prodTextBox1.Location = new System.Drawing.Point(169, 66);
            this.custo_prodTextBox1.Name = "custo_prodTextBox1";
            this.custo_prodTextBox1.Size = new System.Drawing.Size(100, 20);
            this.custo_prodTextBox1.TabIndex = 15;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 459);
            this.ControlBox = false;
            this.Controls.Add(this.produtoBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).EndInit();
            this.produtoBindingNavigator.ResumeLayout(false);
            this.produtoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private lojaDataSet lojaDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private lojaDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private lojaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produtoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produtoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cod_prodTextBox;
        private System.Windows.Forms.TextBox desc_prodTextBox;
        private System.Windows.Forms.TextBox qtd_prodTextBox;
        private System.Windows.Forms.TextBox qtd_minTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private lojaDataSetTableAdapters.vendaTableAdapter vendaTableAdapter1;
        private System.Windows.Forms.TextBox custo_prodTextBox1;
        private System.Windows.Forms.TextBox valor_vendaTextBox1;
    }
}