namespace Lavest
{
    partial class FrmCadFuncionario
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
            System.Windows.Forms.Label cOD_FUNCLabel;
            System.Windows.Forms.Label nOME_FUNCLabel;
            System.Windows.Forms.Label eND_FUNCLabel;
            System.Windows.Forms.Label nASC_FUNCLabel;
            System.Windows.Forms.Label cPF_FUNCLabel;
            System.Windows.Forms.Label fONE_FUNCLabel;
            System.Windows.Forms.Label eMAIL_CLILabel;
            System.Windows.Forms.Label rG_FUNCLabel;
            System.Windows.Forms.Label sALARIO_FUNCLabel;
            System.Windows.Forms.Label lOGIN_FUNCLabel;
            System.Windows.Forms.Label cEL_FUNCLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadFuncionario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cEL_FUNCMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaDataSet = new Lavest.lojaDataSet();
            this.nASC_FUNCMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cPF_FUNCMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rG_FUNCMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fONE_FUNCMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cOD_FUNCTextBox = new System.Windows.Forms.TextBox();
            this.nOME_FUNCTextBox = new System.Windows.Forms.TextBox();
            this.eND_FUNCTextBox = new System.Windows.Forms.TextBox();
            this.eMAIL_CLITextBox = new System.Windows.Forms.TextBox();
            this.sALARIO_FUNCTextBox = new System.Windows.Forms.TextBox();
            this.lOGIN_FUNCTextBox = new System.Windows.Forms.TextBox();
            this.funcionarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.funcionarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.funcionarioTableAdapter = new Lavest.lojaDataSetTableAdapters.funcionarioTableAdapter();
            this.tableAdapterManager = new Lavest.lojaDataSetTableAdapters.TableAdapterManager();
            cOD_FUNCLabel = new System.Windows.Forms.Label();
            nOME_FUNCLabel = new System.Windows.Forms.Label();
            eND_FUNCLabel = new System.Windows.Forms.Label();
            nASC_FUNCLabel = new System.Windows.Forms.Label();
            cPF_FUNCLabel = new System.Windows.Forms.Label();
            fONE_FUNCLabel = new System.Windows.Forms.Label();
            eMAIL_CLILabel = new System.Windows.Forms.Label();
            rG_FUNCLabel = new System.Windows.Forms.Label();
            sALARIO_FUNCLabel = new System.Windows.Forms.Label();
            lOGIN_FUNCLabel = new System.Windows.Forms.Label();
            cEL_FUNCLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).BeginInit();
            this.funcionarioBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cOD_FUNCLabel
            // 
            cOD_FUNCLabel.AutoSize = true;
            cOD_FUNCLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cOD_FUNCLabel.Location = new System.Drawing.Point(7, 23);
            cOD_FUNCLabel.Name = "cOD_FUNCLabel";
            cOD_FUNCLabel.Size = new System.Drawing.Size(67, 18);
            cOD_FUNCLabel.TabIndex = 0;
            cOD_FUNCLabel.Text = "Código:";
            // 
            // nOME_FUNCLabel
            // 
            nOME_FUNCLabel.AutoSize = true;
            nOME_FUNCLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOME_FUNCLabel.Location = new System.Drawing.Point(7, 52);
            nOME_FUNCLabel.Name = "nOME_FUNCLabel";
            nOME_FUNCLabel.Size = new System.Drawing.Size(60, 18);
            nOME_FUNCLabel.TabIndex = 2;
            nOME_FUNCLabel.Text = "Nome:";
            // 
            // eND_FUNCLabel
            // 
            eND_FUNCLabel.AutoSize = true;
            eND_FUNCLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eND_FUNCLabel.Location = new System.Drawing.Point(7, 82);
            eND_FUNCLabel.Name = "eND_FUNCLabel";
            eND_FUNCLabel.Size = new System.Drawing.Size(84, 18);
            eND_FUNCLabel.TabIndex = 4;
            eND_FUNCLabel.Text = "Endereço:";
            // 
            // nASC_FUNCLabel
            // 
            nASC_FUNCLabel.AutoSize = true;
            nASC_FUNCLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nASC_FUNCLabel.Location = new System.Drawing.Point(6, 248);
            nASC_FUNCLabel.Name = "nASC_FUNCLabel";
            nASC_FUNCLabel.Size = new System.Drawing.Size(141, 18);
            nASC_FUNCLabel.TabIndex = 6;
            nASC_FUNCLabel.Text = "Data nascimento:";
            // 
            // cPF_FUNCLabel
            // 
            cPF_FUNCLabel.AutoSize = true;
            cPF_FUNCLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPF_FUNCLabel.Location = new System.Drawing.Point(7, 192);
            cPF_FUNCLabel.Name = "cPF_FUNCLabel";
            cPF_FUNCLabel.Size = new System.Drawing.Size(44, 18);
            cPF_FUNCLabel.TabIndex = 8;
            cPF_FUNCLabel.Text = "CPF:";
            // 
            // fONE_FUNCLabel
            // 
            fONE_FUNCLabel.AutoSize = true;
            fONE_FUNCLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fONE_FUNCLabel.Location = new System.Drawing.Point(7, 218);
            fONE_FUNCLabel.Name = "fONE_FUNCLabel";
            fONE_FUNCLabel.Size = new System.Drawing.Size(78, 18);
            fONE_FUNCLabel.TabIndex = 10;
            fONE_FUNCLabel.Text = "Telefone:";
            // 
            // eMAIL_CLILabel
            // 
            eMAIL_CLILabel.AutoSize = true;
            eMAIL_CLILabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMAIL_CLILabel.Location = new System.Drawing.Point(7, 107);
            eMAIL_CLILabel.Name = "eMAIL_CLILabel";
            eMAIL_CLILabel.Size = new System.Drawing.Size(54, 18);
            eMAIL_CLILabel.TabIndex = 12;
            eMAIL_CLILabel.Text = "Email:";
            // 
            // rG_FUNCLabel
            // 
            rG_FUNCLabel.AutoSize = true;
            rG_FUNCLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rG_FUNCLabel.Location = new System.Drawing.Point(7, 166);
            rG_FUNCLabel.Name = "rG_FUNCLabel";
            rG_FUNCLabel.Size = new System.Drawing.Size(37, 18);
            rG_FUNCLabel.TabIndex = 14;
            rG_FUNCLabel.Text = "RG:";
            // 
            // sALARIO_FUNCLabel
            // 
            sALARIO_FUNCLabel.AutoSize = true;
            sALARIO_FUNCLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sALARIO_FUNCLabel.Location = new System.Drawing.Point(7, 271);
            sALARIO_FUNCLabel.Name = "sALARIO_FUNCLabel";
            sALARIO_FUNCLabel.Size = new System.Drawing.Size(65, 18);
            sALARIO_FUNCLabel.TabIndex = 16;
            sALARIO_FUNCLabel.Text = "Salário:";
            // 
            // lOGIN_FUNCLabel
            // 
            lOGIN_FUNCLabel.AutoSize = true;
            lOGIN_FUNCLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lOGIN_FUNCLabel.Location = new System.Drawing.Point(7, 138);
            lOGIN_FUNCLabel.Name = "lOGIN_FUNCLabel";
            lOGIN_FUNCLabel.Size = new System.Drawing.Size(54, 18);
            lOGIN_FUNCLabel.TabIndex = 22;
            lOGIN_FUNCLabel.Text = "Login:";
            // 
            // cEL_FUNCLabel
            // 
            cEL_FUNCLabel.AutoSize = true;
            cEL_FUNCLabel.Font = new System.Drawing.Font("Verdana", 11.25F);
            cEL_FUNCLabel.Location = new System.Drawing.Point(211, 218);
            cEL_FUNCLabel.Name = "cEL_FUNCLabel";
            cEL_FUNCLabel.Size = new System.Drawing.Size(65, 18);
            cEL_FUNCLabel.TabIndex = 26;
            cEL_FUNCLabel.Text = "Celular:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(cEL_FUNCLabel);
            this.groupBox1.Controls.Add(this.cEL_FUNCMaskedTextBox);
            this.groupBox1.Controls.Add(this.nASC_FUNCMaskedTextBox);
            this.groupBox1.Controls.Add(this.cPF_FUNCMaskedTextBox);
            this.groupBox1.Controls.Add(this.rG_FUNCMaskedTextBox);
            this.groupBox1.Controls.Add(this.fONE_FUNCMaskedTextBox);
            this.groupBox1.Controls.Add(cOD_FUNCLabel);
            this.groupBox1.Controls.Add(this.cOD_FUNCTextBox);
            this.groupBox1.Controls.Add(nOME_FUNCLabel);
            this.groupBox1.Controls.Add(this.nOME_FUNCTextBox);
            this.groupBox1.Controls.Add(eND_FUNCLabel);
            this.groupBox1.Controls.Add(this.eND_FUNCTextBox);
            this.groupBox1.Controls.Add(nASC_FUNCLabel);
            this.groupBox1.Controls.Add(cPF_FUNCLabel);
            this.groupBox1.Controls.Add(fONE_FUNCLabel);
            this.groupBox1.Controls.Add(eMAIL_CLILabel);
            this.groupBox1.Controls.Add(this.eMAIL_CLITextBox);
            this.groupBox1.Controls.Add(rG_FUNCLabel);
            this.groupBox1.Controls.Add(sALARIO_FUNCLabel);
            this.groupBox1.Controls.Add(this.sALARIO_FUNCTextBox);
            this.groupBox1.Controls.Add(lOGIN_FUNCLabel);
            this.groupBox1.Controls.Add(this.lOGIN_FUNCTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(14, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro Funcionário";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cEL_FUNCMaskedTextBox
            // 
            this.cEL_FUNCMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "CEL_FUNC", true));
            this.cEL_FUNCMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cEL_FUNCMaskedTextBox.Location = new System.Drawing.Point(282, 216);
            this.cEL_FUNCMaskedTextBox.Mask = "(00)00000-0000";
            this.cEL_FUNCMaskedTextBox.Name = "cEL_FUNCMaskedTextBox";
            this.cEL_FUNCMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cEL_FUNCMaskedTextBox.TabIndex = 27;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.lojaDataSet;
            // 
            // lojaDataSet
            // 
            this.lojaDataSet.DataSetName = "lojaDataSet";
            this.lojaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nASC_FUNCMaskedTextBox
            // 
            this.nASC_FUNCMaskedTextBox.BackColor = System.Drawing.Color.White;
            this.nASC_FUNCMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "NASC_FUNC", true));
            this.nASC_FUNCMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nASC_FUNCMaskedTextBox.Location = new System.Drawing.Point(153, 246);
            this.nASC_FUNCMaskedTextBox.Mask = "00/00/0000";
            this.nASC_FUNCMaskedTextBox.Name = "nASC_FUNCMaskedTextBox";
            this.nASC_FUNCMaskedTextBox.Size = new System.Drawing.Size(93, 20);
            this.nASC_FUNCMaskedTextBox.TabIndex = 11;
            this.nASC_FUNCMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.nASC_FUNCMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.nASC_FUNCMaskedTextBox_MaskInputRejected);
            // 
            // cPF_FUNCMaskedTextBox
            // 
            this.cPF_FUNCMaskedTextBox.BackColor = System.Drawing.Color.White;
            this.cPF_FUNCMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "CPF_FUNC", true));
            this.cPF_FUNCMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cPF_FUNCMaskedTextBox.Location = new System.Drawing.Point(112, 190);
            this.cPF_FUNCMaskedTextBox.Mask = "000.000.000-00";
            this.cPF_FUNCMaskedTextBox.Name = "cPF_FUNCMaskedTextBox";
            this.cPF_FUNCMaskedTextBox.Size = new System.Drawing.Size(104, 20);
            this.cPF_FUNCMaskedTextBox.TabIndex = 9;
            // 
            // rG_FUNCMaskedTextBox
            // 
            this.rG_FUNCMaskedTextBox.BackColor = System.Drawing.Color.White;
            this.rG_FUNCMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "RG_FUNC", true));
            this.rG_FUNCMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rG_FUNCMaskedTextBox.Location = new System.Drawing.Point(112, 164);
            this.rG_FUNCMaskedTextBox.Name = "rG_FUNCMaskedTextBox";
            this.rG_FUNCMaskedTextBox.Size = new System.Drawing.Size(104, 20);
            this.rG_FUNCMaskedTextBox.TabIndex = 8;
            // 
            // fONE_FUNCMaskedTextBox
            // 
            this.fONE_FUNCMaskedTextBox.BackColor = System.Drawing.Color.White;
            this.fONE_FUNCMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "FONE_FUNC", true));
            this.fONE_FUNCMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fONE_FUNCMaskedTextBox.Location = new System.Drawing.Point(112, 216);
            this.fONE_FUNCMaskedTextBox.Mask = "(00)0000-0000";
            this.fONE_FUNCMaskedTextBox.Name = "fONE_FUNCMaskedTextBox";
            this.fONE_FUNCMaskedTextBox.Size = new System.Drawing.Size(93, 20);
            this.fONE_FUNCMaskedTextBox.TabIndex = 10;
            // 
            // cOD_FUNCTextBox
            // 
            this.cOD_FUNCTextBox.BackColor = System.Drawing.Color.White;
            this.cOD_FUNCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "COD_FUNC", true));
            this.cOD_FUNCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cOD_FUNCTextBox.Location = new System.Drawing.Point(112, 20);
            this.cOD_FUNCTextBox.Name = "cOD_FUNCTextBox";
            this.cOD_FUNCTextBox.Size = new System.Drawing.Size(61, 20);
            this.cOD_FUNCTextBox.TabIndex = 1;
            // 
            // nOME_FUNCTextBox
            // 
            this.nOME_FUNCTextBox.BackColor = System.Drawing.Color.White;
            this.nOME_FUNCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "NOME_FUNC", true));
            this.nOME_FUNCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nOME_FUNCTextBox.Location = new System.Drawing.Point(112, 48);
            this.nOME_FUNCTextBox.Name = "nOME_FUNCTextBox";
            this.nOME_FUNCTextBox.Size = new System.Drawing.Size(233, 20);
            this.nOME_FUNCTextBox.TabIndex = 3;
            // 
            // eND_FUNCTextBox
            // 
            this.eND_FUNCTextBox.BackColor = System.Drawing.Color.White;
            this.eND_FUNCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "END_FUNC", true));
            this.eND_FUNCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.eND_FUNCTextBox.Location = new System.Drawing.Point(112, 80);
            this.eND_FUNCTextBox.Name = "eND_FUNCTextBox";
            this.eND_FUNCTextBox.Size = new System.Drawing.Size(233, 20);
            this.eND_FUNCTextBox.TabIndex = 5;
            // 
            // eMAIL_CLITextBox
            // 
            this.eMAIL_CLITextBox.BackColor = System.Drawing.Color.White;
            this.eMAIL_CLITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "EMAIL_CLI", true));
            this.eMAIL_CLITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.eMAIL_CLITextBox.Location = new System.Drawing.Point(112, 108);
            this.eMAIL_CLITextBox.Name = "eMAIL_CLITextBox";
            this.eMAIL_CLITextBox.Size = new System.Drawing.Size(233, 20);
            this.eMAIL_CLITextBox.TabIndex = 6;
            // 
            // sALARIO_FUNCTextBox
            // 
            this.sALARIO_FUNCTextBox.BackColor = System.Drawing.Color.White;
            this.sALARIO_FUNCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "SALARIO_FUNC", true));
            this.sALARIO_FUNCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sALARIO_FUNCTextBox.Location = new System.Drawing.Point(112, 269);
            this.sALARIO_FUNCTextBox.Name = "sALARIO_FUNCTextBox";
            this.sALARIO_FUNCTextBox.Size = new System.Drawing.Size(93, 20);
            this.sALARIO_FUNCTextBox.TabIndex = 12;
            // 
            // lOGIN_FUNCTextBox
            // 
            this.lOGIN_FUNCTextBox.BackColor = System.Drawing.Color.White;
            this.lOGIN_FUNCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "LOGIN_FUNC", true));
            this.lOGIN_FUNCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lOGIN_FUNCTextBox.Location = new System.Drawing.Point(112, 136);
            this.lOGIN_FUNCTextBox.Name = "lOGIN_FUNCTextBox";
            this.lOGIN_FUNCTextBox.Size = new System.Drawing.Size(233, 20);
            this.lOGIN_FUNCTextBox.TabIndex = 7;
            // 
            // funcionarioBindingNavigator
            // 
            this.funcionarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.funcionarioBindingNavigator.BackColor = System.Drawing.SystemColors.Control;
            this.funcionarioBindingNavigator.BindingSource = this.funcionarioBindingSource;
            this.funcionarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.funcionarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.funcionarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.funcionarioBindingNavigatorSaveItem,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButton4,
            this.toolStripButton3});
            this.funcionarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.funcionarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.funcionarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.funcionarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.funcionarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.funcionarioBindingNavigator.Name = "funcionarioBindingNavigator";
            this.funcionarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.funcionarioBindingNavigator.Size = new System.Drawing.Size(433, 25);
            this.funcionarioBindingNavigator.TabIndex = 1;
            this.funcionarioBindingNavigator.Text = "bindingNavigator1";
            this.funcionarioBindingNavigator.RefreshItems += new System.EventHandler(this.funcionarioBindingNavigator_RefreshItems);
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
            this.bindingNavigatorDeleteItem.Text = "Excluir ";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Tahoma", 8.25F);
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
            // funcionarioBindingNavigatorSaveItem
            // 
            this.funcionarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.funcionarioBindingNavigatorSaveItem.Image = global::Lavest.Properties.Resources._6a0120a9370e90970b014e5f81703d970c_800wi;
            this.funcionarioBindingNavigatorSaveItem.Name = "funcionarioBindingNavigatorSaveItem";
            this.funcionarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.funcionarioBindingNavigatorSaveItem.Text = "Salvar ";
            this.funcionarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.funcionarioBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Lavest.Properties.Resources._17_512;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Cancelar ";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Lavest.Properties.Resources.search_shot_interface_symbol_with_a_magnifier_tool_318_55166;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Localizar um funcionário";
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
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.funcionarioTableAdapter = this.funcionarioTableAdapter;
            this.tableAdapterManager.itens_compraTableAdapter = null;
            this.tableAdapterManager.itens_vendaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lavest.lojaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // FrmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(433, 388);
            this.ControlBox = false;
            this.Controls.Add(this.funcionarioBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de funcionário";
            this.Load += new System.EventHandler(this.FrmCadFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).EndInit();
            this.funcionarioBindingNavigator.ResumeLayout(false);
            this.funcionarioBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private lojaDataSet lojaDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private lojaDataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private lojaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator funcionarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton funcionarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cOD_FUNCTextBox;
        private System.Windows.Forms.TextBox nOME_FUNCTextBox;
        private System.Windows.Forms.TextBox eND_FUNCTextBox;
        private System.Windows.Forms.TextBox eMAIL_CLITextBox;
        private System.Windows.Forms.TextBox sALARIO_FUNCTextBox;
        private System.Windows.Forms.TextBox lOGIN_FUNCTextBox;
        private System.Windows.Forms.MaskedTextBox nASC_FUNCMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cPF_FUNCMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox rG_FUNCMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox fONE_FUNCMaskedTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.MaskedTextBox cEL_FUNCMaskedTextBox;
    }
}