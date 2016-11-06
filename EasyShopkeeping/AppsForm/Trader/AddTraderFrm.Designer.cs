namespace EasyShopkeeping.AppsForm.Trader
{
    partial class AddTraderFrm
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
            this.traderLastNameTxt = new System.Windows.Forms.TextBox();
            this.traderMobileTxt = new System.Windows.Forms.TextBox();
            this.traderEmailTxt = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.traderFirstNameTxt = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.addTradeResetBtn = new System.Windows.Forms.Button();
            this.addCustomerSaveBtn = new System.Windows.Forms.Button();
            this.custAddGroupBox = new System.Windows.Forms.GroupBox();
            this.traderTradeMartTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.traderPinTxt = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.Label();
            this.traderDistComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.traderStateComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.custAddGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // traderLastNameTxt
            // 
            this.traderLastNameTxt.Location = new System.Drawing.Point(88, 40);
            this.traderLastNameTxt.Name = "traderLastNameTxt";
            this.traderLastNameTxt.Size = new System.Drawing.Size(181, 22);
            this.traderLastNameTxt.TabIndex = 2;
            // 
            // traderMobileTxt
            // 
            this.traderMobileTxt.Location = new System.Drawing.Point(88, 68);
            this.traderMobileTxt.Name = "traderMobileTxt";
            this.traderMobileTxt.Size = new System.Drawing.Size(181, 22);
            this.traderMobileTxt.TabIndex = 3;
            // 
            // traderEmailTxt
            // 
            this.traderEmailTxt.Location = new System.Drawing.Point(88, 96);
            this.traderEmailTxt.Name = "traderEmailTxt";
            this.traderEmailTxt.Size = new System.Drawing.Size(181, 22);
            this.traderEmailTxt.TabIndex = 4;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(8, 46);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(76, 16);
            this.lastName.TabIndex = 14;
            this.lastName.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mobile :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email :";
            // 
            // traderFirstNameTxt
            // 
            this.traderFirstNameTxt.Location = new System.Drawing.Point(88, 14);
            this.traderFirstNameTxt.Name = "traderFirstNameTxt";
            this.traderFirstNameTxt.Size = new System.Drawing.Size(181, 22);
            this.traderFirstNameTxt.TabIndex = 1;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(9, 20);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(76, 16);
            this.firstName.TabIndex = 7;
            this.firstName.Text = "First Name:";
            // 
            // addTradeResetBtn
            // 
            this.addTradeResetBtn.Location = new System.Drawing.Point(176, 262);
            this.addTradeResetBtn.Name = "addTradeResetBtn";
            this.addTradeResetBtn.Size = new System.Drawing.Size(93, 23);
            this.addTradeResetBtn.TabIndex = 10;
            this.addTradeResetBtn.Text = "Reset";
            this.addTradeResetBtn.UseVisualStyleBackColor = true;
            // 
            // addCustomerSaveBtn
            // 
            this.addCustomerSaveBtn.Location = new System.Drawing.Point(88, 262);
            this.addCustomerSaveBtn.Name = "addCustomerSaveBtn";
            this.addCustomerSaveBtn.Size = new System.Drawing.Size(82, 23);
            this.addCustomerSaveBtn.TabIndex = 9;
            this.addCustomerSaveBtn.Text = "Save";
            this.addCustomerSaveBtn.UseVisualStyleBackColor = true;
            this.addCustomerSaveBtn.Click += new System.EventHandler(this.addCustomerSaveBtn_Click);
            // 
            // custAddGroupBox
            // 
            this.custAddGroupBox.BackColor = System.Drawing.Color.LightSalmon;
            this.custAddGroupBox.Controls.Add(this.addTradeResetBtn);
            this.custAddGroupBox.Controls.Add(this.traderTradeMartTxt);
            this.custAddGroupBox.Controls.Add(this.addCustomerSaveBtn);
            this.custAddGroupBox.Controls.Add(this.label1);
            this.custAddGroupBox.Controls.Add(this.traderPinTxt);
            this.custAddGroupBox.Controls.Add(this.pin);
            this.custAddGroupBox.Controls.Add(this.traderDistComboBox);
            this.custAddGroupBox.Controls.Add(this.firstName);
            this.custAddGroupBox.Controls.Add(this.traderFirstNameTxt);
            this.custAddGroupBox.Controls.Add(this.lastName);
            this.custAddGroupBox.Controls.Add(this.traderLastNameTxt);
            this.custAddGroupBox.Controls.Add(this.label6);
            this.custAddGroupBox.Controls.Add(this.traderMobileTxt);
            this.custAddGroupBox.Controls.Add(this.label2);
            this.custAddGroupBox.Controls.Add(this.traderEmailTxt);
            this.custAddGroupBox.Controls.Add(this.label4);
            this.custAddGroupBox.Controls.Add(this.traderStateComboBox);
            this.custAddGroupBox.Controls.Add(this.label3);
            this.custAddGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custAddGroupBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.custAddGroupBox.Location = new System.Drawing.Point(57, 12);
            this.custAddGroupBox.Name = "custAddGroupBox";
            this.custAddGroupBox.Size = new System.Drawing.Size(404, 308);
            this.custAddGroupBox.TabIndex = 15;
            this.custAddGroupBox.TabStop = false;
            this.custAddGroupBox.Text = "Enter Trader Details";
            // 
            // traderTradeMartTxt
            // 
            this.traderTradeMartTxt.Location = new System.Drawing.Point(88, 123);
            this.traderTradeMartTxt.Name = "traderTradeMartTxt";
            this.traderTradeMartTxt.Size = new System.Drawing.Size(181, 22);
            this.traderTradeMartTxt.TabIndex = 5;
            this.traderTradeMartTxt.TextChanged += new System.EventHandler(this.traderTradeMartTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Trade Mark";
            // 
            // traderPinTxt
            // 
            this.traderPinTxt.Location = new System.Drawing.Point(88, 211);
            this.traderPinTxt.Name = "traderPinTxt";
            this.traderPinTxt.Size = new System.Drawing.Size(181, 22);
            this.traderPinTxt.TabIndex = 8;
            this.traderPinTxt.TextChanged += new System.EventHandler(this.traderPinTxt_TextChanged);
            // 
            // pin
            // 
            this.pin.AutoSize = true;
            this.pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin.Location = new System.Drawing.Point(9, 217);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(33, 16);
            this.pin.TabIndex = 13;
            this.pin.Text = "Pin :";
            // 
            // traderDistComboBox
            // 
            this.traderDistComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.traderDistComboBox.FormattingEnabled = true;
            this.traderDistComboBox.Items.AddRange(new object[] {
            "Bihar",
            "UP",
            "Maharashtra",
            "West Bengal",
            "Jharkand"});
            this.traderDistComboBox.Location = new System.Drawing.Point(88, 181);
            this.traderDistComboBox.Name = "traderDistComboBox";
            this.traderDistComboBox.Size = new System.Drawing.Size(181, 24);
            this.traderDistComboBox.TabIndex = 7;
            this.traderDistComboBox.SelectedIndexChanged += new System.EventHandler(this.traderDistComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "State :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "District :";
            // 
            // traderStateComboBox
            // 
            this.traderStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.traderStateComboBox.FormattingEnabled = true;
            this.traderStateComboBox.Location = new System.Drawing.Point(88, 151);
            this.traderStateComboBox.Name = "traderStateComboBox";
            this.traderStateComboBox.Size = new System.Drawing.Size(181, 24);
            this.traderStateComboBox.TabIndex = 6;
            this.traderStateComboBox.SelectedIndexChanged += new System.EventHandler(this.traderStateComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EasyShopkeeping.Properties.Resources.closeIco;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(483, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddTraderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EasyShopkeeping.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(521, 351);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.custAddGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "AddTraderFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTraderFrm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddTraderFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddTraderFrm_KeyDown);
            this.custAddGroupBox.ResumeLayout(false);
            this.custAddGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox traderLastNameTxt;
        private System.Windows.Forms.TextBox traderMobileTxt;
        private System.Windows.Forms.TextBox traderEmailTxt;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox traderFirstNameTxt;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Button addTradeResetBtn;
        private System.Windows.Forms.Button addCustomerSaveBtn;
        private System.Windows.Forms.GroupBox custAddGroupBox;
        private System.Windows.Forms.ComboBox traderDistComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox traderStateComboBox;
        private System.Windows.Forms.Label pin;
        private System.Windows.Forms.TextBox traderPinTxt;
        private System.Windows.Forms.TextBox traderTradeMartTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}