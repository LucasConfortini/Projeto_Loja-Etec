namespace Lavest
{
    partial class FrmCadFornecedor
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
            System.Windows.Forms.Label cod_forncLabel;
            System.Windows.Forms.Label nome_forncLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label end_forncLabel;
            System.Windows.Forms.Label foneLabel;
            System.Windows.Forms.Label celularLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadFornecedor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cod_forncTextBox = new System.Windows.Forms.TextBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDataSet = new Lavest.lojaDataSet();
            this.nome_forncTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.end_forncTextBox = new System.Windows.Forms.TextBox();
            this.foneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fornecedorTableAdapter = new Lavest.lojaDataSetTableAdapters.fornecedorTableAdapter();
            this.tableAdapterManager = new Lavest.lojaDataSetTableAdapters.TableAdapterManager();
            this.fornecedorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fornecedorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            cod_forncLabel = new System.Windows.Forms.Label();
            nome_forncLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            end_forncLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingNavigator)).BeginInit();
            this.fornecedorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cod_forncLabel
            // 
            cod_forncLabel.AutoSize = true;
            cod_forncLabel.Font = new System.Drawing.Font("Verdana", 11.25F);
            cod_forncLabel.Location = new System.Drawing.Point(5, 25);
            cod_forncLabel.Name = "cod_forncLabel";
            cod_forncLabel.Size = new System.Drawing.Size(67, 18);
            cod_forncLabel.TabIndex = 0;
            cod_forncLabel.Text = "Código:";
            // 
            // nome_forncLabel
            // 
            nome_forncLabel.AutoSize = true;
            nome_forncLabel.Font = new System.Drawing.Font("Verdana", 11.25F);
            nome_forncLabel.Location = new System.Drawing.Point(5, 51);
            nome_forncLabel.Name = "nome_forncLabel";
            nome_forncLabel.Size = new System.Drawing.Size(60, 18);
            nome_forncLabel.TabIndex = 2;
            nome_forncLabel.Text = "Nome:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Verdana", 11.25F);
            emailLabel.Location = new System.Drawing.Point(5, 77);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(54, 18);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Font = new System.Drawing.Font("Verdana", 11.25F);
            cepLabel.Location = new System.Drawing.Point(6, 105);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(44, 18);
            cepLabel.TabIndex = 8;
            cepLabel.Text = "CEP:";
            // 
            // end_forncLabel
            // 
            end_forncLabel.AutoSize = true;
            end_forncLabel.Font = new System.Drawing.Font("Verdana", 11.25F);
            end_forncLabel.Location = new System.Drawing.Point(6, 129);
            end_forncLabel.Name = "end_forncLabel";
            end_forncLabel.Size = new System.Drawing.Size(84, 18);
            end_forncLabel.TabIndex = 10;
            end_forncLabel.Text = "Endereço:";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Font = new System.Drawing.Font("Verdana", 11.25F);
            foneLabel.Location = new System.Drawing.Point(5, 155);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(78, 18);
            foneLabel.TabIndex = 12;
            foneLabel.Text = "Telefone:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new System.Drawing.Font("Verdana", 11.25F);
            celularLabel.Location = new System.Drawing.Point(6, 181);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(65, 18);
            celularLabel.TabIndex = 14;
            celularLabel.Text = "Celular:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(cod_forncLabel);
            this.groupBox1.Controls.Add(this.cod_forncTextBox);
            this.groupBox1.Controls.Add(nome_forncLabel);
            this.groupBox1.Controls.Add(this.nome_forncTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(cepLabel);
            this.groupBox1.Controls.Add(this.cepMaskedTextBox);
            this.groupBox1.Controls.Add(end_forncLabel);
            this.groupBox1.Controls.Add(this.end_forncTextBox);
            this.groupBox1.Controls.Add(foneLabel);
            this.groupBox1.Controls.Add(this.foneMaskedTextBox);
            this.groupBox1.Controls.Add(celularLabel);
            this.groupBox1.Controls.Add(this.celularMaskedTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(14, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro Fornecedor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cod_forncTextBox
            // 
            this.cod_forncTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "cod_fornc", true));
            this.cod_forncTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cod_forncTextBox.Location = new System.Drawing.Point(78, 23);
            this.cod_forncTextBox.Name = "cod_forncTextBox";
            this.cod_forncTextBox.Size = new System.Drawing.Size(61, 20);
            this.cod_forncTextBox.TabIndex = 1;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            this.fornecedorBindingSource.DataSource = this.lojaDataSet;
            // 
            // lojaDataSet
            // 
            this.lojaDataSet.DataSetName = "lojaDataSet";
            this.lojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nome_forncTextBox
            // 
            this.nome_forncTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "nome_fornc", true));
            this.nome_forncTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nome_forncTextBox.Location = new System.Drawing.Point(78, 49);
            this.nome_forncTextBox.Name = "nome_forncTextBox";
            this.nome_forncTextBox.Size = new System.Drawing.Size(233, 20);
            this.nome_forncTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.emailTextBox.Location = new System.Drawing.Point(78, 75);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(233, 20);
            this.emailTextBox.TabIndex = 7;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "cep", true));
            this.cepMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cepMaskedTextBox.Location = new System.Drawing.Point(78, 101);
            this.cepMaskedTextBox.Mask = "00000-000";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(62, 20);
            this.cepMaskedTextBox.TabIndex = 9;
            // 
            // end_forncTextBox
            // 
            this.end_forncTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "end_fornc", true));
            this.end_forncTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.end_forncTextBox.Location = new System.Drawing.Point(96, 127);
            this.end_forncTextBox.Name = "end_forncTextBox";
            this.end_forncTextBox.Size = new System.Drawing.Size(200, 20);
            this.end_forncTextBox.TabIndex = 11;
            // 
            // foneMaskedTextBox
            // 
            this.foneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "fone", true));
            this.foneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.foneMaskedTextBox.Location = new System.Drawing.Point(96, 153);
            this.foneMaskedTextBox.Mask = "(00)0000-0000";
            this.foneMaskedTextBox.Name = "foneMaskedTextBox";
            this.foneMaskedTextBox.Size = new System.Drawing.Size(90, 20);
            this.foneMaskedTextBox.TabIndex = 13;
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "celular", true));
            this.celularMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.celularMaskedTextBox.Location = new System.Drawing.Point(96, 179);
            this.celularMaskedTextBox.Mask = "(00)00000-0000";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(90, 20);
            this.celularMaskedTextBox.TabIndex = 15;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.compraTableAdapter = null;
            ////this.tableAdapterManager.conta_recentesTableAdapter = null;
            this.tableAdapterManager.contas_pagarTableAdapter = null;
            this.tableAdapterManager.contas_pessoaisTableAdapter = null;
            this.tableAdapterManager.fornecedorTableAdapter = this.fornecedorTableAdapter;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.itens_compraTableAdapter = null;
            this.tableAdapterManager.itens_vendaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lavest.lojaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // fornecedorBindingNavigator
            // 
            this.fornecedorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fornecedorBindingNavigator.BindingSource = this.fornecedorBindingSource;
            this.fornecedorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fornecedorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fornecedorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fornecedorBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.fornecedorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fornecedorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fornecedorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fornecedorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fornecedorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fornecedorBindingNavigator.Name = "fornecedorBindingNavigator";
            this.fornecedorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fornecedorBindingNavigator.Size = new System.Drawing.Size(433, 25);
            this.fornecedorBindingNavigator.TabIndex = 1;
            this.fornecedorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::Lavest.Properties.Resources.sinal_;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.bindingNavigatorMoveNextItem.Text = "Proximo";
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
            // fornecedorBindingNavigatorSaveItem
            // 
            this.fornecedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fornecedorBindingNavigatorSaveItem.Image = global::Lavest.Properties.Resources._6a0120a9370e90970b014e5f81703d970c_800wi;
            this.fornecedorBindingNavigatorSaveItem.Name = "fornecedorBindingNavigatorSaveItem";
            this.fornecedorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fornecedorBindingNavigatorSaveItem.Text = "Save Data";
            this.fornecedorBindingNavigatorSaveItem.Click += new System.EventHandler(this.fornecedorBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Lavest.Properties.Resources._17_512;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Lavest.Properties.Resources.Custom_Icon_Design_Pretty_Office_9_Edit_validated;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Lavest.Properties.Resources.search_shot_interface_symbol_with_a_magnifier_tool_318_55166;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Lavest.Properties.Resources.Crystal_Clear_action_exit_svg;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // FrmCadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 388);
            this.ControlBox = false;
            this.Controls.Add(this.fornecedorBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCadFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de fonecedor";
            this.Load += new System.EventHandler(this.FrmCadFornecedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingNavigator)).EndInit();
            this.fornecedorBindingNavigator.ResumeLayout(false);
            this.fornecedorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private lojaDataSet lojaDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private lojaDataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private lojaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fornecedorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fornecedorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cod_forncTextBox;
        private System.Windows.Forms.TextBox nome_forncTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
        private System.Windows.Forms.TextBox end_forncTextBox;
        private System.Windows.Forms.MaskedTextBox foneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}