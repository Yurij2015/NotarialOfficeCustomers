namespace NotarialOfficeCustomers
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.positonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notarialOfficeCustemersDataSet = new NotarialOfficeCustomers.NotarialOfficeCustemersDataSet();
            this.radBindingNavigator1 = new Telerik.WinControls.UI.RadBindingNavigator();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radBindingNavigator1RowElement = new Telerik.WinControls.UI.CommandBarRowElement();
            this.radBindingNavigator1FirstStrip = new Telerik.WinControls.UI.CommandBarStripElement();
            this.radBindingNavigator1MoveFirstItem = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radBindingNavigator1MovePreviousItem = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radBindingNavigator1PositionItem = new Telerik.WinControls.UI.CommandBarTextBox();
            this.radBindingNavigator1CountItem = new Telerik.WinControls.UI.CommandBarLabel();
            this.commandBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radBindingNavigator1MoveNextItem = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator4 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radBindingNavigator1MoveLastItem = new Telerik.WinControls.UI.CommandBarButton();
            this.radBindingNavigator1SecondStrip = new Telerik.WinControls.UI.CommandBarStripElement();
            this.radBindingNavigator1AddNewItem = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator5 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radBindingNavigator1DeleteItem = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton2 = new Telerik.WinControls.UI.CommandBarButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.nDataGridView1 = new Nevron.UI.WinForm.Controls.NDataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeeTableAdapter = new NotarialOfficeCustomers.NotarialOfficeCustemersDataSetTableAdapters.employeeTableAdapter();
            this.positonTableAdapter = new NotarialOfficeCustomers.NotarialOfficeCustemersDataSetTableAdapters.positonTableAdapter();
            this.positonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.positonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notarialOfficeCustemersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // positonBindingSource
            // 
            this.positonBindingSource.DataMember = "positon";
            this.positonBindingSource.DataSource = this.notarialOfficeCustemersDataSet;
            // 
            // notarialOfficeCustemersDataSet
            // 
            this.notarialOfficeCustemersDataSet.DataSetName = "NotarialOfficeCustemersDataSet";
            this.notarialOfficeCustemersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radBindingNavigator1
            // 
            this.radBindingNavigator1.BindingSource = this.employeeBindingSource;
            this.radBindingNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radBindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radBindingNavigator1.Name = "radBindingNavigator1";
            this.radBindingNavigator1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.radBindingNavigator1RowElement});
            this.radBindingNavigator1.Size = new System.Drawing.Size(943, 30);
            this.radBindingNavigator1.TabIndex = 2;
            this.radBindingNavigator1.ThemeName = "Fluent";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.notarialOfficeCustemersDataSet;
            // 
            // radBindingNavigator1RowElement
            // 
            this.radBindingNavigator1RowElement.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1RowElement.MinSize = new System.Drawing.Size(25, 25);
            this.radBindingNavigator1RowElement.Name = "radBindingNavigator1RowElement";
            this.radBindingNavigator1RowElement.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.radBindingNavigator1FirstStrip,
            this.radBindingNavigator1SecondStrip});
            this.radBindingNavigator1RowElement.Text = "";
            this.radBindingNavigator1RowElement.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1RowElement.UseCompatibleTextRendering = false;
            // 
            // radBindingNavigator1FirstStrip
            // 
            this.radBindingNavigator1FirstStrip.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1FirstStrip.DisplayName = "radBindingNavigator1FirstStrip";
            this.radBindingNavigator1FirstStrip.EnableDragging = false;
            // 
            // 
            // 
            this.radBindingNavigator1FirstStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radBindingNavigator1FirstStrip.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.radBindingNavigator1MoveFirstItem,
            this.commandBarSeparator1,
            this.radBindingNavigator1MovePreviousItem,
            this.commandBarSeparator2,
            this.radBindingNavigator1PositionItem,
            this.radBindingNavigator1CountItem,
            this.commandBarSeparator3,
            this.radBindingNavigator1MoveNextItem,
            this.commandBarSeparator4,
            this.radBindingNavigator1MoveLastItem});
            this.radBindingNavigator1FirstStrip.MinSize = new System.Drawing.Size(0, 0);
            // 
            // 
            // 
            this.radBindingNavigator1FirstStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radBindingNavigator1FirstStrip.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1FirstStrip.UseCompatibleTextRendering = false;
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.radBindingNavigator1FirstStrip.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.radBindingNavigator1FirstStrip.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // radBindingNavigator1MoveFirstItem
            // 
            this.radBindingNavigator1MoveFirstItem.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1MoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MoveFirstItem.Image")));
            this.radBindingNavigator1MoveFirstItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.radBindingNavigator1MoveFirstItem.Name = "radBindingNavigator1MoveFirstItem";
            this.radBindingNavigator1MoveFirstItem.SvgImageXml = resources.GetString("radBindingNavigator1MoveFirstItem.SvgImageXml");
            this.radBindingNavigator1MoveFirstItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1MoveFirstItem.UseCompatibleTextRendering = false;
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.commandBarSeparator1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator1.UseCompatibleTextRendering = false;
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // radBindingNavigator1MovePreviousItem
            // 
            this.radBindingNavigator1MovePreviousItem.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1MovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MovePreviousItem.Image")));
            this.radBindingNavigator1MovePreviousItem.Name = "radBindingNavigator1MovePreviousItem";
            this.radBindingNavigator1MovePreviousItem.SvgImageXml = resources.GetString("radBindingNavigator1MovePreviousItem.SvgImageXml");
            this.radBindingNavigator1MovePreviousItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1MovePreviousItem.UseCompatibleTextRendering = false;
            // 
            // commandBarSeparator2
            // 
            this.commandBarSeparator2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator2.Name = "commandBarSeparator2";
            this.commandBarSeparator2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator2.UseCompatibleTextRendering = false;
            this.commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // radBindingNavigator1PositionItem
            // 
            this.radBindingNavigator1PositionItem.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1PositionItem.Name = "radBindingNavigator1PositionItem";
            this.radBindingNavigator1PositionItem.Text = "0";
            this.radBindingNavigator1PositionItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1PositionItem.UseCompatibleTextRendering = false;
            // 
            // radBindingNavigator1CountItem
            // 
            this.radBindingNavigator1CountItem.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1CountItem.Name = "radBindingNavigator1CountItem";
            this.radBindingNavigator1CountItem.Text = "of 0";
            this.radBindingNavigator1CountItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1CountItem.UseCompatibleTextRendering = false;
            // 
            // commandBarSeparator3
            // 
            this.commandBarSeparator3.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator3.Name = "commandBarSeparator3";
            this.commandBarSeparator3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator3.UseCompatibleTextRendering = false;
            this.commandBarSeparator3.VisibleInOverflowMenu = false;
            // 
            // radBindingNavigator1MoveNextItem
            // 
            this.radBindingNavigator1MoveNextItem.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1MoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MoveNextItem.Image")));
            this.radBindingNavigator1MoveNextItem.Name = "radBindingNavigator1MoveNextItem";
            this.radBindingNavigator1MoveNextItem.SvgImageXml = resources.GetString("radBindingNavigator1MoveNextItem.SvgImageXml");
            this.radBindingNavigator1MoveNextItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1MoveNextItem.UseCompatibleTextRendering = false;
            // 
            // commandBarSeparator4
            // 
            this.commandBarSeparator4.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator4.Name = "commandBarSeparator4";
            this.commandBarSeparator4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator4.UseCompatibleTextRendering = false;
            this.commandBarSeparator4.VisibleInOverflowMenu = false;
            // 
            // radBindingNavigator1MoveLastItem
            // 
            this.radBindingNavigator1MoveLastItem.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1MoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MoveLastItem.Image")));
            this.radBindingNavigator1MoveLastItem.Name = "radBindingNavigator1MoveLastItem";
            this.radBindingNavigator1MoveLastItem.SvgImageXml = resources.GetString("radBindingNavigator1MoveLastItem.SvgImageXml");
            this.radBindingNavigator1MoveLastItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1MoveLastItem.UseCompatibleTextRendering = false;
            // 
            // radBindingNavigator1SecondStrip
            // 
            this.radBindingNavigator1SecondStrip.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1SecondStrip.DisplayName = "radBindingNavigator1SecondStrip";
            this.radBindingNavigator1SecondStrip.EnableDragging = false;
            // 
            // 
            // 
            this.radBindingNavigator1SecondStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radBindingNavigator1SecondStrip.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.radBindingNavigator1AddNewItem,
            this.commandBarSeparator5,
            this.radBindingNavigator1DeleteItem,
            this.commandBarButton2});
            this.radBindingNavigator1SecondStrip.MinSize = new System.Drawing.Size(0, 0);
            // 
            // 
            // 
            this.radBindingNavigator1SecondStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radBindingNavigator1SecondStrip.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1SecondStrip.UseCompatibleTextRendering = false;
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.radBindingNavigator1SecondStrip.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.radBindingNavigator1SecondStrip.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // radBindingNavigator1AddNewItem
            // 
            this.radBindingNavigator1AddNewItem.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1AddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1AddNewItem.Image")));
            this.radBindingNavigator1AddNewItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.radBindingNavigator1AddNewItem.Name = "radBindingNavigator1AddNewItem";
            this.radBindingNavigator1AddNewItem.SvgImageXml = resources.GetString("radBindingNavigator1AddNewItem.SvgImageXml");
            this.radBindingNavigator1AddNewItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1AddNewItem.UseCompatibleTextRendering = false;
            // 
            // commandBarSeparator5
            // 
            this.commandBarSeparator5.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator5.Name = "commandBarSeparator5";
            this.commandBarSeparator5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator5.UseCompatibleTextRendering = false;
            this.commandBarSeparator5.VisibleInOverflowMenu = false;
            // 
            // radBindingNavigator1DeleteItem
            // 
            this.radBindingNavigator1DeleteItem.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1DeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1DeleteItem.Image")));
            this.radBindingNavigator1DeleteItem.Name = "radBindingNavigator1DeleteItem";
            this.radBindingNavigator1DeleteItem.SvgImageXml = resources.GetString("radBindingNavigator1DeleteItem.SvgImageXml");
            this.radBindingNavigator1DeleteItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radBindingNavigator1DeleteItem.UseCompatibleTextRendering = false;
            // 
            // commandBarButton2
            // 
            this.commandBarButton2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton2.DisplayName = "commandBarButton2";
            this.commandBarButton2.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton2.Image")));
            this.commandBarButton2.Name = "commandBarButton2";
            this.commandBarButton2.Text = "Сохранить";
            this.commandBarButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton2.UseCompatibleTextRendering = false;
            this.commandBarButton2.Click += new System.EventHandler(this.commandBarButton2_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 36);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowSearchRow = true;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "id";
            gridViewDecimalColumn1.HeaderText = "Номер";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "id";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 47;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "fullName";
            gridViewTextBoxColumn1.HeaderText = "ФИО сотрудника";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "fullName";
            gridViewTextBoxColumn1.Width = 121;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "birthDate";
            gridViewDateTimeColumn1.HeaderText = "Дата рождения";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "birthDate";
            gridViewDateTimeColumn1.Width = 96;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "phone";
            gridViewTextBoxColumn2.HeaderText = "Номер телефона";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "phone";
            gridViewTextBoxColumn2.Width = 104;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "adress";
            gridViewTextBoxColumn3.HeaderText = "Адрес";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "adress";
            gridViewTextBoxColumn3.Width = 161;
            gridViewComboBoxColumn1.DataSource = this.positonBindingSource;
            gridViewComboBoxColumn1.DataType = typeof(int);
            gridViewComboBoxColumn1.DisplayMember = "positionName";
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "position";
            gridViewComboBoxColumn1.HeaderText = "Должность";
            gridViewComboBoxColumn1.Name = "position";
            gridViewComboBoxColumn1.ValueMember = "id";
            gridViewComboBoxColumn1.Width = 106;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "specialization";
            gridViewTextBoxColumn4.HeaderText = "Специализация";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "specialization";
            gridViewTextBoxColumn4.Width = 121;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "detail";
            gridViewTextBoxColumn5.HeaderText = "Детали";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "detail";
            gridViewTextBoxColumn5.Width = 173;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewComboBoxColumn1,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.radGridView1.MasterTemplate.DataSource = this.employeeBindingSource;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(943, 455);
            this.radGridView1.TabIndex = 3;
            this.radGridView1.Click += new System.EventHandler(this.radGridView1_Click);
            // 
            // nDataGridView1
            // 
            this.nDataGridView1.AutoGenerateColumns = false;
            this.nDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.nDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.fullNameDataGridViewTextBoxColumn1,
            this.birthDateDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.adressDataGridViewTextBoxColumn1,
            this.positionDataGridViewTextBoxColumn1});
            this.nDataGridView1.DataSource = this.employeeBindingSource;
            this.nDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.nDataGridView1.Location = new System.Drawing.Point(0, 497);
            this.nDataGridView1.Name = "nDataGridView1";
            this.nDataGridView1.Size = new System.Drawing.Size(629, 90);
            this.nDataGridView1.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            this.fullNameDataGridViewTextBoxColumn1.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn1.HeaderText = "ФИО сотрудника";
            this.fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            // 
            // birthDateDataGridViewTextBoxColumn1
            // 
            this.birthDateDataGridViewTextBoxColumn1.DataPropertyName = "birthDate";
            this.birthDateDataGridViewTextBoxColumn1.HeaderText = "Дата рождения";
            this.birthDateDataGridViewTextBoxColumn1.Name = "birthDateDataGridViewTextBoxColumn1";
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Номер телефона";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            // 
            // adressDataGridViewTextBoxColumn1
            // 
            this.adressDataGridViewTextBoxColumn1.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn1.HeaderText = "Адрес";
            this.adressDataGridViewTextBoxColumn1.Name = "adressDataGridViewTextBoxColumn1";
            // 
            // positionDataGridViewTextBoxColumn1
            // 
            this.positionDataGridViewTextBoxColumn1.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn1.DataSource = this.positonBindingSource;
            this.positionDataGridViewTextBoxColumn1.DisplayMember = "positionName";
            this.positionDataGridViewTextBoxColumn1.HeaderText = "Должность";
            this.positionDataGridViewTextBoxColumn1.Name = "positionDataGridViewTextBoxColumn1";
            this.positionDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.positionDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.positionDataGridViewTextBoxColumn1.ValueMember = "id";
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // positonTableAdapter
            // 
            this.positonTableAdapter.ClearBeforeFill = true;
            // 
            // positonBindingSource1
            // 
            this.positonBindingSource1.DataMember = "positon";
            this.positonBindingSource1.DataSource = this.notarialOfficeCustemersDataSet;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 490);
            this.Controls.Add(this.nDataGridView1);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radBindingNavigator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmployee";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Сотрудники нотариальной конторы";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.positonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notarialOfficeCustemersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadBindingNavigator radBindingNavigator1;
        private Telerik.WinControls.UI.CommandBarRowElement radBindingNavigator1RowElement;
        private Telerik.WinControls.UI.CommandBarStripElement radBindingNavigator1FirstStrip;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1MoveFirstItem;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1MovePreviousItem;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator2;
        private Telerik.WinControls.UI.CommandBarTextBox radBindingNavigator1PositionItem;
        private Telerik.WinControls.UI.CommandBarLabel radBindingNavigator1CountItem;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator3;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1MoveNextItem;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator4;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1MoveLastItem;
        private Telerik.WinControls.UI.CommandBarStripElement radBindingNavigator1SecondStrip;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1AddNewItem;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator5;
        private Telerik.WinControls.UI.CommandBarButton radBindingNavigator1DeleteItem;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private NotarialOfficeCustemersDataSet notarialOfficeCustemersDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private NotarialOfficeCustemersDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource positonBindingSource;
        private NotarialOfficeCustemersDataSetTableAdapters.positonTableAdapter positonTableAdapter;
        private Nevron.UI.WinForm.Controls.NDataGridView nDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn positionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource positonBindingSource1;
    }
}
