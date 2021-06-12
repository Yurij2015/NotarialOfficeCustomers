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
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new NotarialOfficeCustomers.NotarialOfficeCustemersDataSetTableAdapters.customerTableAdapter();
            this.commandBarButton2 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.radBindingNavigator2 = new Telerik.WinControls.UI.RadBindingNavigator();
            this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarButton1 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator6 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarButton3 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator7 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarTextBox1 = new Telerik.WinControls.UI.CommandBarTextBox();
            this.commandBarLabel1 = new Telerik.WinControls.UI.CommandBarLabel();
            this.commandBarSeparator8 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarButton4 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator9 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarButton5 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarButton6 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator10 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.commandBarButton7 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton8 = new Telerik.WinControls.UI.CommandBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.notarialOfficeCustemersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingNavigator2)).BeginInit();
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
            gridViewDecimalColumn1.HeaderText = "Номер";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "id";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn1.Width = 77;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "fullName";
            gridViewTextBoxColumn1.HeaderText = "ФИО клиента";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "fullName";
            gridViewTextBoxColumn1.Width = 235;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "phone";
            gridViewTextBoxColumn2.HeaderText = "Номер телефона";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "phone";
            gridViewTextBoxColumn2.Width = 171;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "adress";
            gridViewTextBoxColumn3.HeaderText = "Адрес";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "adress";
            gridViewTextBoxColumn3.Width = 171;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "gender";
            gridViewTextBoxColumn4.HeaderText = "Пол";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "gender";
            gridViewTextBoxColumn4.Width = 87;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "passport";
            gridViewTextBoxColumn5.HeaderText = "Паспорт";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "passport";
            gridViewTextBoxColumn5.Width = 92;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "email";
            gridViewTextBoxColumn6.HeaderText = "Email";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "email";
            gridViewTextBoxColumn6.Width = 153;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.radGridView1.MasterTemplate.DataSource = this.customerBindingSource;
            sortDescriptor1.PropertyName = "id";
            this.radGridView1.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(1001, 359);
            this.radGridView1.TabIndex = 0;
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
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.DisplayName = "commandBarRowElement1";
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Name = "commandBarRowElement1";
            this.commandBarRowElement1.Text = "";
            this.commandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.UseCompatibleTextRendering = false;
            // 
            // radBindingNavigator2
            // 
            this.radBindingNavigator2.BindingSource = this.customerBindingSource;
            this.radBindingNavigator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radBindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.radBindingNavigator2.Name = "radBindingNavigator2";
            this.radBindingNavigator2.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement2});
            this.radBindingNavigator2.Size = new System.Drawing.Size(1001, 30);
            this.radBindingNavigator2.TabIndex = 2;
            this.radBindingNavigator2.ThemeName = "Fluent";
            this.radBindingNavigator2.Click += new System.EventHandler(this.radBindingNavigator2_Click);
            // 
            // commandBarRowElement2
            // 
            this.commandBarRowElement2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement2.Name = "radBindingNavigator1RowElement";
            this.commandBarRowElement2.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1,
            this.commandBarStripElement2});
            this.commandBarRowElement2.Text = "";
            this.commandBarRowElement2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement2.UseCompatibleTextRendering = false;
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.DisplayName = "radBindingNavigator1FirstStrip";
            this.commandBarStripElement1.EnableDragging = false;
            // 
            // 
            // 
            this.commandBarStripElement1.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarButton1,
            this.commandBarSeparator6,
            this.commandBarButton3,
            this.commandBarSeparator7,
            this.commandBarTextBox1,
            this.commandBarLabel1,
            this.commandBarSeparator8,
            this.commandBarButton4,
            this.commandBarSeparator9,
            this.commandBarButton5});
            this.commandBarStripElement1.MinSize = new System.Drawing.Size(0, 0);
            // 
            // 
            // 
            this.commandBarStripElement1.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.commandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.UseCompatibleTextRendering = false;
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement1.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement1.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // commandBarButton1
            // 
            this.commandBarButton1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton1.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton1.Image")));
            this.commandBarButton1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.commandBarButton1.Name = "commandBarButton1";
            this.commandBarButton1.SvgImageXml = resources.GetString("commandBarButton1.SvgImageXml");
            this.commandBarButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton1.UseCompatibleTextRendering = false;
            // 
            // commandBarSeparator6
            // 
            this.commandBarSeparator6.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator6.Name = "commandBarSeparator6";
            this.commandBarSeparator6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator6.UseCompatibleTextRendering = false;
            this.commandBarSeparator6.VisibleInOverflowMenu = false;
            // 
            // commandBarButton3
            // 
            this.commandBarButton3.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton3.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton3.Image")));
            this.commandBarButton3.Name = "commandBarButton3";
            this.commandBarButton3.SvgImageXml = resources.GetString("commandBarButton3.SvgImageXml");
            this.commandBarButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton3.UseCompatibleTextRendering = false;
            // 
            // commandBarSeparator7
            // 
            this.commandBarSeparator7.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator7.Name = "commandBarSeparator7";
            this.commandBarSeparator7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator7.UseCompatibleTextRendering = false;
            this.commandBarSeparator7.VisibleInOverflowMenu = false;
            // 
            // commandBarTextBox1
            // 
            this.commandBarTextBox1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarTextBox1.Name = "commandBarTextBox1";
            this.commandBarTextBox1.Text = "0";
            this.commandBarTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarTextBox1.UseCompatibleTextRendering = false;
            // 
            // commandBarLabel1
            // 
            this.commandBarLabel1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarLabel1.Name = "commandBarLabel1";
            this.commandBarLabel1.Text = "of 0";
            this.commandBarLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarLabel1.UseCompatibleTextRendering = false;
            // 
            // commandBarSeparator8
            // 
            this.commandBarSeparator8.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator8.Name = "commandBarSeparator8";
            this.commandBarSeparator8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator8.UseCompatibleTextRendering = false;
            this.commandBarSeparator8.VisibleInOverflowMenu = false;
            // 
            // commandBarButton4
            // 
            this.commandBarButton4.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton4.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton4.Image")));
            this.commandBarButton4.Name = "commandBarButton4";
            this.commandBarButton4.SvgImageXml = resources.GetString("commandBarButton4.SvgImageXml");
            this.commandBarButton4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton4.UseCompatibleTextRendering = false;
            // 
            // commandBarSeparator9
            // 
            this.commandBarSeparator9.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator9.Name = "commandBarSeparator9";
            this.commandBarSeparator9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator9.UseCompatibleTextRendering = false;
            this.commandBarSeparator9.VisibleInOverflowMenu = false;
            // 
            // commandBarButton5
            // 
            this.commandBarButton5.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton5.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton5.Image")));
            this.commandBarButton5.Name = "commandBarButton5";
            this.commandBarButton5.SvgImageXml = resources.GetString("commandBarButton5.SvgImageXml");
            this.commandBarButton5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton5.UseCompatibleTextRendering = false;
            // 
            // commandBarStripElement2
            // 
            this.commandBarStripElement2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement2.DisplayName = "radBindingNavigator1SecondStrip";
            this.commandBarStripElement2.EnableDragging = false;
            // 
            // 
            // 
            this.commandBarStripElement2.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.commandBarStripElement2.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarButton6,
            this.commandBarSeparator10,
            this.commandBarButton7,
            this.commandBarButton8});
            this.commandBarStripElement2.MinSize = new System.Drawing.Size(0, 0);
            // 
            // 
            // 
            this.commandBarStripElement2.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.commandBarStripElement2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement2.UseCompatibleTextRendering = false;
            ((Telerik.WinControls.UI.RadCommandBarGrip)(this.commandBarStripElement2.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadCommandBarOverflowButton)(this.commandBarStripElement2.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // commandBarButton6
            // 
            this.commandBarButton6.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton6.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton6.Image")));
            this.commandBarButton6.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.commandBarButton6.Name = "commandBarButton6";
            this.commandBarButton6.SvgImageXml = resources.GetString("commandBarButton6.SvgImageXml");
            this.commandBarButton6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton6.UseCompatibleTextRendering = false;
            // 
            // commandBarSeparator10
            // 
            this.commandBarSeparator10.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator10.Name = "commandBarSeparator10";
            this.commandBarSeparator10.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator10.UseCompatibleTextRendering = false;
            this.commandBarSeparator10.VisibleInOverflowMenu = false;
            // 
            // commandBarButton7
            // 
            this.commandBarButton7.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton7.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton7.Image")));
            this.commandBarButton7.Name = "commandBarButton7";
            this.commandBarButton7.SvgImageXml = resources.GetString("commandBarButton7.SvgImageXml");
            this.commandBarButton7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton7.UseCompatibleTextRendering = false;
            // 
            // commandBarButton8
            // 
            this.commandBarButton8.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton8.DisplayName = "commandBarButton2";
            this.commandBarButton8.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton8.Image")));
            this.commandBarButton8.Name = "commandBarButton8";
            this.commandBarButton8.Text = "Сохранить";
            this.commandBarButton8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton8.UseCompatibleTextRendering = false;
            this.commandBarButton8.Click += new System.EventHandler(this.commandBarButton8_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 397);
            this.Controls.Add(this.radBindingNavigator2);
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
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBindingNavigator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NotarialOfficeCustemersDataSet notarialOfficeCustemersDataSet;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private NotarialOfficeCustemersDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton2;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.RadBindingNavigator radBindingNavigator2;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton1;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator6;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton3;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator7;
        private Telerik.WinControls.UI.CommandBarTextBox commandBarTextBox1;
        private Telerik.WinControls.UI.CommandBarLabel commandBarLabel1;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator8;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton4;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator9;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton5;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement2;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton6;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator10;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton7;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton8;
    }
}
