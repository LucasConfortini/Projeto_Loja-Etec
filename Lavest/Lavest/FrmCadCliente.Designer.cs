namespace Lavest
{
    partial class FrmCadCliente
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
            System.Windows.Forms.Label cOD_CLILabel;
            System.Windows.Forms.Label nOME_CLILabel;
            System.Windows.Forms.Label eND_CLILabel;
            System.Windows.Forms.Label dATA_NASCLabel;
            System.Windows.Forms.Label nATURA_CLILabel;
            System.Windows.Forms.Label lIMITE_CLILabel;
            System.Windows.Forms.Label rEF_CLILabel;
            System.Windows.Forms.Label cPF_CLILabel;
            System.Windows.Forms.Label fONE_CLILabel;
            System.Windows.Forms.Label eMAIL_CLILabel;
            System.Windows.Forms.Label cEP_CLILabel;
            System.Windows.Forms.Label rG_CLILabel;
            System.Windows.Forms.Label cEL_CLILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cEL_CLIMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDataSet = new Lavest.lojaDataSet();
            this.txtnatu = new System.Windows.Forms.TextBox();
            this.cEP_CLIMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fONE_CLIMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rG_CLIMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cPF_CLIMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dATA_NASCMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cOD_CLITextBox = new System.Windows.Forms.TextBox();
            this.nOME_CLITextBox = new System.Windows.Forms.TextBox();
            this.eND_CLITextBox = new System.Windows.Forms.TextBox();
            this.lIMITE_CLITextBox = new System.Windows.Forms.TextBox();
            this.rEF_CLITextBox = new System.Windows.Forms.TextBox();
            this.eMAIL_CLITextBox = new System.Windows.Forms.TextBox();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.clienteTableAdapter = new Lavest.lojaDataSetTableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new Lavest.lojaDataSetTableAdapters.TableAdapterManager();
            cOD_CLILabel = new System.Windows.Forms.Label();
            nOME_CLILabel = new System.Windows.Forms.Label();
            eND_CLILabel = new System.Windows.Forms.Label();
            dATA_NASCLabel = new System.Windows.Forms.Label();
            nATURA_CLILabel = new System.Windows.Forms.Label();
            lIMITE_CLILabel = new System.Windows.Forms.Label();
            rEF_CLILabel = new System.Windows.Forms.Label();
            cPF_CLILabel = new System.Windows.Forms.Label();
            fONE_CLILabel = new System.Windows.Forms.Label();
            eMAIL_CLILabel = new System.Windows.Forms.Label();
            cEP_CLILabel = new System.Windows.Forms.Label();
            rG_CLILabel = new System.Windows.Forms.Label();
            cEL_CLILabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cOD_CLILabel
            // 
            cOD_CLILabel.AutoSize = true;
            cOD_CLILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cOD_CLILabel.Location = new System.Drawing.Point(6, 25);
            cOD_CLILabel.Name = "cOD_CLILabel";
            cOD_CLILabel.Size = new System.Drawing.Size(60, 18);
            cOD_CLILabel.TabIndex = 0;
            cOD_CLILabel.Text = "Código:";
            cOD_CLILabel.Visible = false;
            // 
            // nOME_CLILabel
            // 
            nOME_CLILabel.AutoSize = true;
            nOME_CLILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOME_CLILabel.Location = new System.Drawing.Point(6, 51);
            nOME_CLILabel.Name = "nOME_CLILabel";
            nOME_CLILabel.Size = new System.Drawing.Size(53, 18);
            nOME_CLILabel.TabIndex = 2;
            nOME_CLILabel.Text = "Nome:";
            // 
            // eND_CLILabel
            // 
            eND_CLILabel.AutoSize = true;
            eND_CLILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eND_CLILabel.Location = new System.Drawing.Point(6, 77);
            eND_CLILabel.Name = "eND_CLILabel";
            eND_CLILabel.Size = new System.Drawing.Size(76, 18);
            eND_CLILabel.TabIndex = 4;
            eND_CLILabel.Text = "Endereço:";
            // 
            // dATA_NASCLabel
            // 
            dATA_NASCLabel.AutoSize = true;
            dATA_NASCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dATA_NASCLabel.Location = new System.Drawing.Point(6, 104);
            dATA_NASCLabel.Name = "dATA_NASCLabel";
            dATA_NASCLabel.Size = new System.Drawing.Size(144, 18);
            dATA_NASCLabel.TabIndex = 6;
            dATA_NASCLabel.Text = "Data de nascimento:";
            // 
            // nATURA_CLILabel
            // 
            nATURA_CLILabel.AutoSize = true;
            nATURA_CLILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nATURA_CLILabel.Location = new System.Drawing.Point(6, 130);
            nATURA_CLILabel.Name = "nATURA_CLILabel";
            nATURA_CLILabel.Size = new System.Drawing.Size(94, 18);
            nATURA_CLILabel.TabIndex = 8;
            nATURA_CLILabel.Text = "Naturalidade:";
            // 
            // lIMITE_CLILabel
            // 
            lIMITE_CLILabel.AutoSize = true;
            lIMITE_CLILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lIMITE_CLILabel.Location = new System.Drawing.Point(6, 158);
            lIMITE_CLILabel.Name = "lIMITE_CLILabel";
            lIMITE_CLILabel.Size = new System.Drawing.Size(51, 18);
            lIMITE_CLILabel.TabIndex = 10;
            lIMITE_CLILabel.Text = "Limite:";
            // 
            // rEF_CLILabel
            // 
            rEF_CLILabel.AutoSize = true;
            rEF_CLILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rEF_CLILabel.Location = new System.Drawing.Point(6, 184);
            rEF_CLILabel.Name = "rEF_CLILabel";
            rEF_CLILabel.Size = new System.Drawing.Size(83, 18);
            rEF_CLILabel.TabIndex = 12;
            rEF_CLILabel.Text = "Referência:";
            // 
            // cPF_CLILabel
            // 
            cPF_CLILabel.AutoSize = true;
            cPF_CLILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPF_CLILabel.Location = new System.Drawing.Point(6, 210);
            cPF_CLILabel.Name = "cPF_CLILabel";
            cPF_CLILabel.Size = new System.Drawing.Size(42, 18);
            cPF_CLILabel.TabIndex = 14;
            cPF_CLILabel.Text = "CPF:";
            // 
            // fONE_CLILabel
            // 
            fONE_CLILabel.AutoSize = true;
            fONE_CLILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fONE_CLILabel.Location = new System.Drawing.Point(5, 238);
            fONE_CLILabel.Name = "fONE_CLILabel";
            fONE_CLILabel.Size = new System.Drawing.Size(69, 18);
            fONE_CLILabel.TabIndex = 18;
            fONE_CLILabel.Text = "Telefone:";
            // 
            // eMAIL_CLILabel
            // 
            eMAIL_CLILabel.AutoSize = true;
            eMAIL_CLILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMAIL_CLILabel.Location = new System.Drawing.Point(6, 265);
            eMAIL_CLILabel.Name = "eMAIL_CLILabel";
            eMAIL_CLILabel.Size = new System.Drawing.Size(49, 18);
            eMAIL_CLILabel.TabIndex = 20;
            eMAIL_CLILabel.Text = "Email:";
            // 
            // cEP_CLILabel
            // 
            cEP_CLILabel.AutoSize = true;
            cEP_CLILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cEP_CLILabel.Location = new System.Drawing.Point(6, 293);
            cEP_CLILabel.Name = "cEP_CLILabel";
            cEP_CLILabel.Size = new System.Drawing.Size(43, 18);
            cEP_CLILabel.TabIndex = 22;
            cEP_CLILabel.Text = "CEP:";
            // 
            // rG_CLILabel
            // 
            rG_CLILabel.AutoSize = true;
            rG_CLILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rG_CLILabel.Location = new System.Drawing.Point(230, 208);
            rG_CLILabel.Name = "rG_CLILabel";
            rG_CLILabel.Size = new System.Drawing.Size(35, 18);
            rG_CLILabel.TabIndex = 24;
            rG_CLILabel.Text = "RG:";
            // 
            // cEL_CLILabel
            // 
            cEL_CLILabel.AutoSize = true;
            cEL_CLILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            cEL_CLILabel.Location = new System.Drawing.Point(230, 238);
            cEL_CLILabel.Name = "cEL_CLILabel";
            cEL_CLILabel.Size = new System.Drawing.Size(58, 18);
            cEL_CLILabel.TabIndex = 32;
            cEL_CLILabel.Text = "Celular:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(cEL_CLILabel);
            this.groupBox1.Controls.Add(this.cEL_CLIMaskedTextBox);
            this.groupBox1.Controls.Add(this.txtnatu);
            this.groupBox1.Controls.Add(this.cEP_CLIMaskedTextBox);
            this.groupBox1.Controls.Add(this.fONE_CLIMaskedTextBox);
            this.groupBox1.Controls.Add(this.rG_CLIMaskedTextBox);
            this.groupBox1.Controls.Add(this.cPF_CLIMaskedTextBox);
            this.groupBox1.Controls.Add(this.dATA_NASCMaskedTextBox);
            this.groupBox1.Controls.Add(cOD_CLILabel);
            this.groupBox1.Controls.Add(this.cOD_CLITextBox);
            this.groupBox1.Controls.Add(nOME_CLILabel);
            this.groupBox1.Controls.Add(this.nOME_CLITextBox);
            this.groupBox1.Controls.Add(eND_CLILabel);
            this.groupBox1.Controls.Add(this.eND_CLITextBox);
            this.groupBox1.Controls.Add(dATA_NASCLabel);
            this.groupBox1.Controls.Add(nATURA_CLILabel);
            this.groupBox1.Controls.Add(lIMITE_CLILabel);
            this.groupBox1.Controls.Add(this.lIMITE_CLITextBox);
            this.groupBox1.Controls.Add(rEF_CLILabel);
            this.groupBox1.Controls.Add(this.rEF_CLITextBox);
            this.groupBox1.Controls.Add(cPF_CLILabel);
            this.groupBox1.Controls.Add(fONE_CLILabel);
            this.groupBox1.Controls.Add(eMAIL_CLILabel);
            this.groupBox1.Controls.Add(this.eMAIL_CLITextBox);
            this.groupBox1.Controls.Add(cEP_CLILabel);
            this.groupBox1.Controls.Add(rG_CLILabel);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cEL_CLIMaskedTextBox
            // 
            this.cEL_CLIMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CEL_CLI", true));
            this.cEL_CLIMaskedTextBox.Location = new System.Drawing.Point(294, 236);
            this.cEL_CLIMaskedTextBox.Mask = "(00)00000-0000";
            this.cEL_CLIMaskedTextBox.Name = "cEL_CLIMaskedTextBox";
            this.cEL_CLIMaskedTextBox.Size = new System.Drawing.Size(90, 20);
            this.cEL_CLIMaskedTextBox.TabIndex = 33;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.lojaDataSet;
            // 
            // lojaDataSet
            // 
            this.lojaDataSet.DataSetName = "lojaDataSet";
            this.lojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtnatu
            // 
            this.txtnatu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "NATURA_CLI", true));
            this.txtnatu.Location = new System.Drawing.Point(107, 130);
            this.txtnatu.Name = "txtnatu";
            this.txtnatu.Size = new System.Drawing.Size(181, 20);
            this.txtnatu.TabIndex = 32;
            this.txtnatu.TextChanged += new System.EventHandler(this.txtnatu_TextChanged);
            // 
            // cEP_CLIMaskedTextBox
            // 
            this.cEP_CLIMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CEP_CLI", true));
            this.cEP_CLIMaskedTextBox.Location = new System.Drawing.Point(88, 288);
            this.cEP_CLIMaskedTextBox.Mask = "00000-000";
            this.cEP_CLIMaskedTextBox.Name = "cEP_CLIMaskedTextBox";
            this.cEP_CLIMaskedTextBox.Size = new System.Drawing.Size(62, 20);
            this.cEP_CLIMaskedTextBox.TabIndex = 31;
            // 
            // fONE_CLIMaskedTextBox
            // 
            this.fONE_CLIMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "FONE_CLI", true));
            this.fONE_CLIMaskedTextBox.Location = new System.Drawing.Point(107, 236);
            this.fONE_CLIMaskedTextBox.Mask = "(00)0000-0000";
            this.fONE_CLIMaskedTextBox.Name = "fONE_CLIMaskedTextBox";
            this.fONE_CLIMaskedTextBox.Size = new System.Drawing.Size(90, 20);
            this.fONE_CLIMaskedTextBox.TabIndex = 30;
            // 
            // rG_CLIMaskedTextBox
            // 
            this.rG_CLIMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "RG_CLI", true));
            this.rG_CLIMaskedTextBox.Location = new System.Drawing.Point(294, 206);
            this.rG_CLIMaskedTextBox.Name = "rG_CLIMaskedTextBox";
            this.rG_CLIMaskedTextBox.Size = new System.Drawing.Size(90, 20);
            this.rG_CLIMaskedTextBox.TabIndex = 28;
            // 
            // cPF_CLIMaskedTextBox
            // 
            this.cPF_CLIMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPF_CLI", true));
            this.cPF_CLIMaskedTextBox.Location = new System.Drawing.Point(107, 208);
            this.cPF_CLIMaskedTextBox.Mask = "000.000.000-00";
            this.cPF_CLIMaskedTextBox.Name = "cPF_CLIMaskedTextBox";
            this.cPF_CLIMaskedTextBox.Size = new System.Drawing.Size(90, 20);
            this.cPF_CLIMaskedTextBox.TabIndex = 27;
            // 
            // dATA_NASCMaskedTextBox
            // 
            this.dATA_NASCMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "DATA_NASC", true));
            this.dATA_NASCMaskedTextBox.Location = new System.Drawing.Point(156, 102);
            this.dATA_NASCMaskedTextBox.Mask = "00/00/0000";
            this.dATA_NASCMaskedTextBox.Name = "dATA_NASCMaskedTextBox";
            this.dATA_NASCMaskedTextBox.Size = new System.Drawing.Size(80, 20);
            this.dATA_NASCMaskedTextBox.TabIndex = 26;
            this.dATA_NASCMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // cOD_CLITextBox
            // 
            this.cOD_CLITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "COD_CLI", true));
            this.cOD_CLITextBox.Location = new System.Drawing.Point(72, 26);
            this.cOD_CLITextBox.Name = "cOD_CLITextBox";
            this.cOD_CLITextBox.Size = new System.Drawing.Size(53, 20);
            this.cOD_CLITextBox.TabIndex = 1;
            this.cOD_CLITextBox.Visible = false;
            // 
            // nOME_CLITextBox
            // 
            this.nOME_CLITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "NOME_CLI", true));
            this.nOME_CLITextBox.Location = new System.Drawing.Point(88, 49);
            this.nOME_CLITextBox.Name = "nOME_CLITextBox";
            this.nOME_CLITextBox.Size = new System.Drawing.Size(200, 20);
            this.nOME_CLITextBox.TabIndex = 3;
            // 
            // eND_CLITextBox
            // 
            this.eND_CLITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "END_CLI", true));
            this.eND_CLITextBox.Location = new System.Drawing.Point(88, 78);
            this.eND_CLITextBox.Name = "eND_CLITextBox";
            this.eND_CLITextBox.Size = new System.Drawing.Size(200, 20);
            this.eND_CLITextBox.TabIndex = 5;
            // 
            // lIMITE_CLITextBox
            // 
            this.lIMITE_CLITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "LIMITE_CLI", true));
            this.lIMITE_CLITextBox.Location = new System.Drawing.Point(107, 156);
            this.lIMITE_CLITextBox.Name = "lIMITE_CLITextBox";
            this.lIMITE_CLITextBox.Size = new System.Drawing.Size(181, 20);
            this.lIMITE_CLITextBox.TabIndex = 11;
            // 
            // rEF_CLITextBox
            // 
            this.rEF_CLITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "REF_CLI", true));
            this.rEF_CLITextBox.Location = new System.Drawing.Point(107, 182);
            this.rEF_CLITextBox.Name = "rEF_CLITextBox";
            this.rEF_CLITextBox.Size = new System.Drawing.Size(181, 20);
            this.rEF_CLITextBox.TabIndex = 13;
            // 
            // eMAIL_CLITextBox
            // 
            this.eMAIL_CLITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "EMAIL_CLI", true));
            this.eMAIL_CLITextBox.Location = new System.Drawing.Point(88, 262);
            this.eMAIL_CLITextBox.Name = "eMAIL_CLITextBox";
            this.eMAIL_CLITextBox.Size = new System.Drawing.Size(200, 20);
            this.eMAIL_CLITextBox.TabIndex = 21;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clienteBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripButton3});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(433, 25);
            this.clienteBindingNavigator.TabIndex = 1;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::Lavest.Properties.Resources.sinal_1;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar Cadastro";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número de cadastros";
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
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
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
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteBindingNavigatorSaveItem.Image = global::Lavest.Properties.Resources._6a0120a9370e90970b014e5f81703d970c_800wi;
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clienteBindingNavigatorSaveItem.Text = "Salvar";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
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
            this.toolStripButton4.Text = "Localizar um cliente";
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
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.compraTableAdapter = null;
            //this.tableAdapterManager.conta_recentesTableAdapter = null;
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
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(433, 389);
            this.ControlBox = false;
            this.Controls.Add(this.clienteBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cliente";
            this.Load += new System.EventHandler(this.FrmCadCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private lojaDataSet lojaDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private lojaDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private lojaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox dATA_NASCMaskedTextBox;
        private System.Windows.Forms.TextBox cOD_CLITextBox;
        private System.Windows.Forms.TextBox nOME_CLITextBox;
        private System.Windows.Forms.TextBox eND_CLITextBox;
        private System.Windows.Forms.TextBox lIMITE_CLITextBox;
        private System.Windows.Forms.TextBox rEF_CLITextBox;
        private System.Windows.Forms.TextBox eMAIL_CLITextBox;
        private System.Windows.Forms.MaskedTextBox cEP_CLIMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox fONE_CLIMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox rG_CLIMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cPF_CLIMaskedTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TextBox txtnatu;
        private System.Windows.Forms.MaskedTextBox cEL_CLIMaskedTextBox;
    }
}