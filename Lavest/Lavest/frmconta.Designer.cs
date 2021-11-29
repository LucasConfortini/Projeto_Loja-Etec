namespace Lavest
{
    partial class frmconta
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
            System.Windows.Forms.Label num_contaLabel;
            System.Windows.Forms.Label descri_pessoalLabel;
            System.Windows.Forms.Label valor_pagLabel;
            System.Windows.Forms.Label valor_pagarLabel;
            System.Windows.Forms.Label data_vencLabel;
            System.Windows.Forms.Label data_pagLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data_pagMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.contas_pessoaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDataSet = new Lavest.lojaDataSet();
            this.data_vencMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.num_contaTextBox = new System.Windows.Forms.TextBox();
            this.descri_pessoalTextBox = new System.Windows.Forms.TextBox();
            this.valor_pagTextBox = new System.Windows.Forms.TextBox();
            this.valor_pagarTextBox = new System.Windows.Forms.TextBox();
            this.contas_pessoaisTableAdapter = new Lavest.lojaDataSetTableAdapters.contas_pessoaisTableAdapter();
            this.tableAdapterManager = new Lavest.lojaDataSetTableAdapters.TableAdapterManager();
            this.contas_pessoaisBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.contas_pessoaisBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            num_contaLabel = new System.Windows.Forms.Label();
            descri_pessoalLabel = new System.Windows.Forms.Label();
            valor_pagLabel = new System.Windows.Forms.Label();
            valor_pagarLabel = new System.Windows.Forms.Label();
            data_vencLabel = new System.Windows.Forms.Label();
            data_pagLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contas_pessoaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_pessoaisBindingNavigator)).BeginInit();
            this.contas_pessoaisBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // num_contaLabel
            // 
            num_contaLabel.AutoSize = true;
            num_contaLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_contaLabel.Location = new System.Drawing.Point(6, 26);
            num_contaLabel.Name = "num_contaLabel";
            num_contaLabel.Size = new System.Drawing.Size(148, 18);
            num_contaLabel.TabIndex = 0;
            num_contaLabel.Text = "Número da Conta:";
            // 
            // descri_pessoalLabel
            // 
            descri_pessoalLabel.AutoSize = true;
            descri_pessoalLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descri_pessoalLabel.Location = new System.Drawing.Point(6, 52);
            descri_pessoalLabel.Name = "descri_pessoalLabel";
            descri_pessoalLabel.Size = new System.Drawing.Size(87, 18);
            descri_pessoalLabel.TabIndex = 2;
            descri_pessoalLabel.Text = "Descriçao:";
            // 
            // valor_pagLabel
            // 
            valor_pagLabel.AutoSize = true;
            valor_pagLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_pagLabel.Location = new System.Drawing.Point(6, 76);
            valor_pagLabel.Name = "valor_pagLabel";
            valor_pagLabel.Size = new System.Drawing.Size(95, 18);
            valor_pagLabel.TabIndex = 4;
            valor_pagLabel.Text = "Valor Pago:";
            // 
            // valor_pagarLabel
            // 
            valor_pagarLabel.AutoSize = true;
            valor_pagarLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_pagarLabel.Location = new System.Drawing.Point(220, 78);
            valor_pagarLabel.Name = "valor_pagarLabel";
            valor_pagarLabel.Size = new System.Drawing.Size(114, 18);
            valor_pagarLabel.TabIndex = 6;
            valor_pagarLabel.Text = "Valor a Pagar:";
            // 
            // data_vencLabel
            // 
            data_vencLabel.AutoSize = true;
            data_vencLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_vencLabel.Location = new System.Drawing.Point(6, 116);
            data_vencLabel.Name = "data_vencLabel";
            data_vencLabel.Size = new System.Drawing.Size(143, 18);
            data_vencLabel.TabIndex = 8;
            data_vencLabel.Text = "Data Vencimento:";
            // 
            // data_pagLabel
            // 
            data_pagLabel.AutoSize = true;
            data_pagLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_pagLabel.Location = new System.Drawing.Point(234, 116);
            data_pagLabel.Name = "data_pagLabel";
            data_pagLabel.Size = new System.Drawing.Size(163, 18);
            data_pagLabel.TabIndex = 10;
            data_pagLabel.Text = "Data de Pagamento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data_pagMaskedTextBox);
            this.groupBox1.Controls.Add(this.data_vencMaskedTextBox);
            this.groupBox1.Controls.Add(num_contaLabel);
            this.groupBox1.Controls.Add(this.num_contaTextBox);
            this.groupBox1.Controls.Add(descri_pessoalLabel);
            this.groupBox1.Controls.Add(this.descri_pessoalTextBox);
            this.groupBox1.Controls.Add(valor_pagLabel);
            this.groupBox1.Controls.Add(this.valor_pagTextBox);
            this.groupBox1.Controls.Add(valor_pagarLabel);
            this.groupBox1.Controls.Add(this.valor_pagarTextBox);
            this.groupBox1.Controls.Add(data_vencLabel);
            this.groupBox1.Controls.Add(data_pagLabel);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contas";
            // 
            // data_pagMaskedTextBox
            // 
            this.data_pagMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_pessoaisBindingSource, "data_pag", true));
            this.data_pagMaskedTextBox.Location = new System.Drawing.Point(403, 114);
            this.data_pagMaskedTextBox.Mask = "00/00/0000";
            this.data_pagMaskedTextBox.Name = "data_pagMaskedTextBox";
            this.data_pagMaskedTextBox.Size = new System.Drawing.Size(73, 20);
            this.data_pagMaskedTextBox.TabIndex = 15;
            this.data_pagMaskedTextBox.ValidatingType = typeof(System.DateTime);
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
            // data_vencMaskedTextBox
            // 
            this.data_vencMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_pessoaisBindingSource, "data_venc", true));
            this.data_vencMaskedTextBox.Location = new System.Drawing.Point(155, 114);
            this.data_vencMaskedTextBox.Mask = "00/00/0000";
            this.data_vencMaskedTextBox.Name = "data_vencMaskedTextBox";
            this.data_vencMaskedTextBox.Size = new System.Drawing.Size(73, 20);
            this.data_vencMaskedTextBox.TabIndex = 13;
            this.data_vencMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // num_contaTextBox
            // 
            this.num_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_pessoaisBindingSource, "num_conta", true));
            this.num_contaTextBox.Location = new System.Drawing.Point(160, 24);
            this.num_contaTextBox.Name = "num_contaTextBox";
            this.num_contaTextBox.Size = new System.Drawing.Size(37, 20);
            this.num_contaTextBox.TabIndex = 1;
            // 
            // descri_pessoalTextBox
            // 
            this.descri_pessoalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_pessoaisBindingSource, "descri_pessoal", true));
            this.descri_pessoalTextBox.Location = new System.Drawing.Point(124, 50);
            this.descri_pessoalTextBox.Name = "descri_pessoalTextBox";
            this.descri_pessoalTextBox.Size = new System.Drawing.Size(200, 20);
            this.descri_pessoalTextBox.TabIndex = 3;
            // 
            // valor_pagTextBox
            // 
            this.valor_pagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_pessoaisBindingSource, "valor_pag", true));
            this.valor_pagTextBox.Location = new System.Drawing.Point(124, 76);
            this.valor_pagTextBox.Name = "valor_pagTextBox";
            this.valor_pagTextBox.Size = new System.Drawing.Size(90, 20);
            this.valor_pagTextBox.TabIndex = 5;
            // 
            // valor_pagarTextBox
            // 
            this.valor_pagarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contas_pessoaisBindingSource, "valor_pagar", true));
            this.valor_pagarTextBox.Location = new System.Drawing.Point(340, 78);
            this.valor_pagarTextBox.Name = "valor_pagarTextBox";
            this.valor_pagarTextBox.Size = new System.Drawing.Size(90, 20);
            this.valor_pagarTextBox.TabIndex = 7;
            // 
            // contas_pessoaisTableAdapter
            // 
            this.contas_pessoaisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.compraTableAdapter = null;
            this.tableAdapterManager.conta_receberTableAdapter = null;
            this.tableAdapterManager.contas_pagarTableAdapter = null;
            this.tableAdapterManager.contas_pessoaisTableAdapter = this.contas_pessoaisTableAdapter;
            this.tableAdapterManager.fornecedorTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.itens_compraTableAdapter = null;
            this.tableAdapterManager.itens_vendaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lavest.lojaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // contas_pessoaisBindingNavigator
            // 
            this.contas_pessoaisBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contas_pessoaisBindingNavigator.BindingSource = this.contas_pessoaisBindingSource;
            this.contas_pessoaisBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contas_pessoaisBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contas_pessoaisBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contas_pessoaisBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton3});
            this.contas_pessoaisBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contas_pessoaisBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contas_pessoaisBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contas_pessoaisBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contas_pessoaisBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contas_pessoaisBindingNavigator.Name = "contas_pessoaisBindingNavigator";
            this.contas_pessoaisBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contas_pessoaisBindingNavigator.Size = new System.Drawing.Size(535, 25);
            this.contas_pessoaisBindingNavigator.TabIndex = 1;
            this.contas_pessoaisBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::Lavest.Properties.Resources.sinal_1;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar Conta";
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
            // contas_pessoaisBindingNavigatorSaveItem
            // 
            this.contas_pessoaisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contas_pessoaisBindingNavigatorSaveItem.Image = global::Lavest.Properties.Resources._6a0120a9370e90970b014e5f81703d970c_800wi;
            this.contas_pessoaisBindingNavigatorSaveItem.Name = "contas_pessoaisBindingNavigatorSaveItem";
            this.contas_pessoaisBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contas_pessoaisBindingNavigatorSaveItem.Text = "Save Data";
            this.contas_pessoaisBindingNavigatorSaveItem.Click += new System.EventHandler(this.contas_pessoaisBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Lavest.Properties.Resources._17_512;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "cancelar";
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
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(82, 22);
            this.toolStripButton4.Text = "Contas Pagas";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(105, 22);
            this.toolStripButton5.Text = "Contas não Pagas";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // frmconta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 190);
            this.ControlBox = false;
            this.Controls.Add(this.contas_pessoaisBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmconta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas Pessoais";
            this.Load += new System.EventHandler(this.frmconta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contas_pessoaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_pessoaisBindingNavigator)).EndInit();
            this.contas_pessoaisBindingNavigator.ResumeLayout(false);
            this.contas_pessoaisBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private lojaDataSet lojaDataSet;
        private System.Windows.Forms.BindingSource contas_pessoaisBindingSource;
        private lojaDataSetTableAdapters.contas_pessoaisTableAdapter contas_pessoaisTableAdapter;
        private lojaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contas_pessoaisBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contas_pessoaisBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox data_pagMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox data_vencMaskedTextBox;
        private System.Windows.Forms.TextBox num_contaTextBox;
        private System.Windows.Forms.TextBox descri_pessoalTextBox;
        private System.Windows.Forms.TextBox valor_pagTextBox;
        private System.Windows.Forms.TextBox valor_pagarTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}