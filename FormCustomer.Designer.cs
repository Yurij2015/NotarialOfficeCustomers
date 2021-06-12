namespace NotarialOfficeCustomers
{
    partial class FormCustomer
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.notarialOfficeCustemersDataSet = new NotarialOfficeCustomers.NotarialOfficeCustemersDataSet();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new NotarialOfficeCustomers.NotarialOfficeCustemersDataSetTableAdapters.employeeTableAdapter();
            this.radBindingNavigator1 = new Telerik.WinControls.UI.RadBindingNavigator();
            this.radBindingNavigator1RowElement = new Telerik.WinControls.UI.CommandBarRowElement();
            this.radBindingNavigator1FirstStrip = new Telerik.WinControls.UI.CommandBarStripElement();
            this.radBindingNavigator1MoveFirstItem = new Telerik.WinControls.UI.CommandBarButton();
            this.radBindingNavigator1MovePreviousItem = new Telerik.WinControls.UI.CommandBarButton();
            this.radBindingNavigator1PositionItem = new Telerik.WinControls.UI.CommandBarTextBox();
            this.radBindingNavigator1CountItem = new Telerik.WinControls.UI.CommandBarLabel();
            this.radBindingNavigator1MoveNextItem = new Telerik.WinControls.UI.CommandBarButton();
            this.radBindingNavigator1MoveLastItem = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarSeparator4 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radBindingNavigator1SecondStrip = new Telerik.WinControls.UI.CommandBarStripElement();
            this.radBindingNavigator1AddNewItem = new Telerik.WinControls.UI.CommandBarButton();
            this.radBindingNavigator1DeleteItem = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator5 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new NotarialOfficeCustomers.NotarialOfficeCustemersDataSetTableAdapters.customerTableAdapter();
            this.commandBarButton2 = new Telerik.WinControls.UI.CommandBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.notarialOfficeCustemersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // notarialOfficeCustemersDataSet
            // 
            this.notarialOfficeCustemersDataSet.DataSetName = "NotarialOfficeCustemersDataSet";
            this.notarialOfficeCustemersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "id";
            gridViewDecimalColumn1.HeaderText = "id";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "id";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "fullName";
            gridViewTextBoxColumn1.HeaderText = "ФИО клиента";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "fullName";
            gridViewTextBoxColumn1.Width = 251;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "phone";
            gridViewTextBoxColumn2.HeaderText = "Номер телефона";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "phone";
            gridViewTextBoxColumn2.Width = 182;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "adress";
            gridViewTextBoxColumn3.HeaderText = "Адрес";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "adress";
            gridViewTextBoxColumn3.Width = 182;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "gender";
            gridViewTextBoxColumn4.HeaderText = "Пол";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "gender";
            gridViewTextBoxColumn4.Width = 93;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "passport";
            gridViewTextBoxColumn5.HeaderText = "Паспорт";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "passport";
            gridViewTextBoxColumn5.Width = 99;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "email";
            gridViewTextBoxColumn6.HeaderText = "Email";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "email";
            gridViewTextBoxColumn6.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn6.Width = 164;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.radGridView1.MasterTemplate.DataSource = this.customerBindingSource;
            sortDescriptor1.PropertyName = "email";
            this.radGridView1.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(1001, 359);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.ThemeName = "Fluent";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.notarialOfficeCustemersDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // radBindingNavigator1
            // 
            this.radBindingNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radBindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radBindingNavigator1.Name = "radBindingNavigator1";
            this.radBindingNavigator1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.radBindingNavigator1RowElement});
            this.radBindingNavigator1.Size = new System.Drawing.Size(667, 20);
            this.radBindingNavigator1.TabIndex = 0;
            this.radBindingNavigator1.ThemeName = "Fluent";
            // 
            // radBindingNavigator1RowElement
            // 
            this.radBindingNavigator1RowElement.MinSize = new System.Drawing.Size(25, 25);
            this.radBindingNavigator1RowElement.Name = "radBindingNavigator1RowElement";
            this.radBindingNavigator1RowElement.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.radBindingNavigator1FirstStrip,
            this.radBindingNavigator1SecondStrip});
            // 
            // radBindingNavigator1FirstStrip
            // 
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
            // 
            // radBindingNavigator1MoveFirstItem
            // 
            this.radBindingNavigator1MoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MoveFirstItem.Image")));
            this.radBindingNavigator1MoveFirstItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.radBindingNavigator1MoveFirstItem.Name = "radBindingNavigator1MoveFirstItem";
            this.radBindingNavigator1MoveFirstItem.SvgImageXml = resources.GetString("radBindingNavigator1MoveFirstItem.SvgImageXml");
            // 
            // radBindingNavigator1MovePreviousItem
            // 
            this.radBindingNavigator1MovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MovePreviousItem.Image")));
            this.radBindingNavigator1MovePreviousItem.Name = "radBindingNavigator1MovePreviousItem";
            this.radBindingNavigator1MovePreviousItem.SvgImageXml = resources.GetString("radBindingNavigator1MovePreviousItem.SvgImageXml");
            // 
            // radBindingNavigator1PositionItem
            // 
            this.radBindingNavigator1PositionItem.Name = "radBindingNavigator1PositionItem";
            // 
            // radBindingNavigator1CountItem
            // 
            this.radBindingNavigator1CountItem.Name = "radBindingNavigator1CountItem";
            this.radBindingNavigator1CountItem.Text = "of {0}";
            // 
            // radBindingNavigator1MoveNextItem
            // 
            this.radBindingNavigator1MoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MoveNextItem.Image")));
            this.radBindingNavigator1MoveNextItem.Name = "radBindingNavigator1MoveNextItem";
            this.radBindingNavigator1MoveNextItem.SvgImageXml = resources.GetString("radBindingNavigator1MoveNextItem.SvgImageXml");
            // 
            // radBindingNavigator1MoveLastItem
            // 
            this.radBindingNavigator1MoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1MoveLastItem.Image")));
            this.radBindingNavigator1MoveLastItem.Name = "radBindingNavigator1MoveLastItem";
            this.radBindingNavigator1MoveLastItem.SvgImageXml = resources.GetString("radBindingNavigator1MoveLastItem.SvgImageXml");
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // commandBarSeparator2
            // 
            this.commandBarSeparator2.Name = "commandBarSeparator2";
            this.commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // commandBarSeparator3
            // 
            this.commandBarSeparator3.Name = "commandBarSeparator3";
            this.commandBarSeparator3.VisibleInOverflowMenu = false;
            // 
            // commandBarSeparator4
            // 
            this.commandBarSeparator4.Name = "commandBarSeparator4";
            this.commandBarSeparator4.VisibleInOverflowMenu = false;
            // 
            // radBindingNavigator1SecondStrip
            // 
            this.radBindingNavigator1SecondStrip.DesiredLocation = ((System.Drawing.PointF)(resources.GetObject("radBindingNavigator1SecondStrip.DesiredLocation")));
            this.radBindingNavigator1SecondStrip.DisplayName = "radBindingNavigator1SecondStrip";
            this.radBindingNavigator1SecondStrip.EnableDragging = false;
            // 
            // 
            // 
            this.radBindingNavigator1SecondStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radBindingNavigator1SecondStrip.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.radBindingNavigator1AddNewItem,
            this.commandBarSeparator5,
            this.radBindingNavigator1DeleteItem});
            this.radBindingNavigator1SecondStrip.MinSize = new System.Drawing.Size(0, 0);
            // 
            // 
            // 
            this.radBindingNavigator1SecondStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // radBindingNavigator1AddNewItem
            // 
            this.radBindingNavigator1AddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1AddNewItem.Image")));
            this.radBindingNavigator1AddNewItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.radBindingNavigator1AddNewItem.Name = "radBindingNavigator1AddNewItem";
            this.radBindingNavigator1AddNewItem.SvgImageXml = resources.GetString("radBindingNavigator1AddNewItem.SvgImageXml");
            // 
            // radBindingNavigator1DeleteItem
            // 
            this.radBindingNavigator1DeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("radBindingNavigator1DeleteItem.Image")));
            this.radBindingNavigator1DeleteItem.Name = "radBindingNavigator1DeleteItem";
            this.radBindingNavigator1DeleteItem.SvgImageXml = resources.GetString("radBindingNavigator1DeleteItem.SvgImageXml");
            // 
            // commandBarSeparator5
            // 
            this.commandBarSeparator5.Name = "commandBarSeparator5";
            this.commandBarSeparator5.VisibleInOverflowMenu = false;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.notarialOfficeCustemersDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
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
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 397);
            this.Controls.Add(this.radBindingNavigator1);
            this.Controls.Add(this.radGridView1);
            this.Name = "FormCustomer";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Клиенты нотариальной конторы";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notarialOfficeCustemersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NotarialOfficeCustemersDataSet notarialOfficeCustemersDataSet;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private NotarialOfficeCustemersDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
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
        private System.Windows.Forms.BindingSource customerBindingSource;
        private NotarialOfficeCustemersDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton2;
    }
}
