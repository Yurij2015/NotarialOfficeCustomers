
namespace NotarialOfficeCustomers
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(357, 320);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(149, 24);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Вход в систему";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NotarialOfficeCustomers.Properties.Resources.NotarialOffice;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3,
            this.radMenuItem4});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(527, 20);
            this.radMenu1.TabIndex = 4;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "О программе";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Вход в систему";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Закрыть";
            this.radMenuItem3.Click += new System.EventHandler(this.radMenuItem3_Click);
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Быстрая запись";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(357, 79);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(149, 24);
            this.radButton2.TabIndex = 5;
            this.radButton2.Text = "Быстрая запись";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(357, 109);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(149, 24);
            this.radButton3.TabIndex = 6;
            this.radButton3.Text = "Закрыть";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 359);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ИС электронной записи клиентов нотариальной конторы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
    }
}

