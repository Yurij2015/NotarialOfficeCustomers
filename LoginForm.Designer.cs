namespace NotarialOfficeCustomers
{
    partial class LoginForm
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
            this.nContextMenu1 = new Nevron.UI.WinForm.Controls.NContextMenu();
            this.userName = new Telerik.WinControls.UI.RadButtonTextBox();
            this.userPassword = new Telerik.WinControls.UI.RadButtonTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.userName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(126, 35);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(133, 20);
            this.userName.TabIndex = 2;
            this.userName.Text = "admin";
            this.userName.TextChanged += new System.EventHandler(this.radButtonTextBox1_TextChanged);
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(126, 73);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(133, 20);
            this.userPassword.TabIndex = 3;
            this.userPassword.Text = "123456";
            this.userPassword.TextChanged += new System.EventHandler(this.radButtonTextBox2_TextChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 35);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(40, 18);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Логин:";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 74);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(47, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Пароль:";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(170, 147);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 6;
            this.radButton1.Text = "Войти";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(12, 147);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(110, 24);
            this.radButton2.TabIndex = 7;
            this.radButton2.Text = "Закрыть";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(159, 11);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(61, 18);
            this.radLabel3.TabIndex = 8;
            this.radLabel3.Text = "user 12345";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 183);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userName);
            this.Name = "LoginForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Nevron.UI.WinForm.Controls.NContextMenu nContextMenu1;
        private Telerik.WinControls.UI.RadButtonTextBox userName;
        private Telerik.WinControls.UI.RadButtonTextBox userPassword;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
