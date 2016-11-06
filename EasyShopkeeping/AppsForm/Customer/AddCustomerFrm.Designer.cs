namespace EasyShopkeeping.AppsForm.Customer
{
    partial class AddCustomerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerFrm));
            this.custAddGroupBox = new System.Windows.Forms.GroupBox();
            this.addDistrictBtn = new System.Windows.Forms.Button();
            this.addStateBtn = new System.Windows.Forms.Button();
            this.custStateComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addAreaBtn = new System.Windows.Forms.Button();
            this.custDistrictComboBox = new System.Windows.Forms.ComboBox();
            this.custAreaComboBox = new System.Windows.Forms.ComboBox();
            this.firstName = new System.Windows.Forms.Label();
            this.custFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.custEmail = new System.Windows.Forms.TextBox();
            this.custMobile = new System.Windows.Forms.TextBox();
            this.custLastName = new System.Windows.Forms.TextBox();
            this.addProfileImgBtn = new System.Windows.Forms.Button();
            this.addCustomerSaveBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profilepictureBox = new System.Windows.Forms.PictureBox();
            this.custAddGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // custAddGroupBox
            // 
            this.custAddGroupBox.Controls.Add(this.addDistrictBtn);
            this.custAddGroupBox.Controls.Add(this.addStateBtn);
            this.custAddGroupBox.Controls.Add(this.custStateComboBox);
            this.custAddGroupBox.Controls.Add(this.label6);
            this.custAddGroupBox.Controls.Add(this.label2);
            this.custAddGroupBox.Controls.Add(this.label1);
            this.custAddGroupBox.Controls.Add(this.addAreaBtn);
            this.custAddGroupBox.Controls.Add(this.custDistrictComboBox);
            this.custAddGroupBox.Controls.Add(this.custAreaComboBox);
            this.custAddGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custAddGroupBox.Location = new System.Drawing.Point(76, 172);
            this.custAddGroupBox.Name = "custAddGroupBox";
            this.custAddGroupBox.Size = new System.Drawing.Size(392, 172);
            this.custAddGroupBox.TabIndex = 0;
            this.custAddGroupBox.TabStop = false;
            this.custAddGroupBox.Text = "Address";
            // 
            // addDistrictBtn
            // 
            this.addDistrictBtn.Location = new System.Drawing.Point(231, 85);
            this.addDistrictBtn.Name = "addDistrictBtn";
            this.addDistrictBtn.Size = new System.Drawing.Size(112, 23);
            this.addDistrictBtn.TabIndex = 10;
            this.addDistrictBtn.Text = "Add District";
            this.addDistrictBtn.UseVisualStyleBackColor = true;
            this.addDistrictBtn.Click += new System.EventHandler(this.addDistrictBtn_Click);
            // 
            // addStateBtn
            // 
            this.addStateBtn.Location = new System.Drawing.Point(231, 42);
            this.addStateBtn.Name = "addStateBtn";
            this.addStateBtn.Size = new System.Drawing.Size(112, 23);
            this.addStateBtn.TabIndex = 9;
            this.addStateBtn.Text = "Add State";
            this.addStateBtn.UseVisualStyleBackColor = true;
            this.addStateBtn.Click += new System.EventHandler(this.addStateBtn_Click);
            // 
            // custStateComboBox
            // 
            this.custStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custStateComboBox.FormattingEnabled = true;
            this.custStateComboBox.Location = new System.Drawing.Point(88, 42);
            this.custStateComboBox.Name = "custStateComboBox";
            this.custStateComboBox.Size = new System.Drawing.Size(121, 24);
            this.custStateComboBox.Sorted = true;
            this.custStateComboBox.TabIndex = 5;
            this.custStateComboBox.DropDown += new System.EventHandler(this.custStateComboBox_DropDown);
            this.custStateComboBox.SelectedIndexChanged += new System.EventHandler(this.custStateComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "State :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "District :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area:";
            // 
            // addAreaBtn
            // 
            this.addAreaBtn.Location = new System.Drawing.Point(231, 133);
            this.addAreaBtn.Name = "addAreaBtn";
            this.addAreaBtn.Size = new System.Drawing.Size(112, 23);
            this.addAreaBtn.TabIndex = 0;
            this.addAreaBtn.Text = "Add Area";
            this.addAreaBtn.UseVisualStyleBackColor = true;
            this.addAreaBtn.Click += new System.EventHandler(this.addAreaBtn_Click);
            // 
            // custDistrictComboBox
            // 
            this.custDistrictComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custDistrictComboBox.FormattingEnabled = true;
            this.custDistrictComboBox.Location = new System.Drawing.Point(88, 84);
            this.custDistrictComboBox.Name = "custDistrictComboBox";
            this.custDistrictComboBox.Size = new System.Drawing.Size(121, 24);
            this.custDistrictComboBox.Sorted = true;
            this.custDistrictComboBox.TabIndex = 6;
            this.custDistrictComboBox.DropDown += new System.EventHandler(this.custDistrictComboBox_DropDown);
            this.custDistrictComboBox.SelectedIndexChanged += new System.EventHandler(this.custDistrictComboBox_SelectedIndexChanged);
            // 
            // custAreaComboBox
            // 
            this.custAreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custAreaComboBox.FormattingEnabled = true;
            this.custAreaComboBox.Location = new System.Drawing.Point(88, 132);
            this.custAreaComboBox.Name = "custAreaComboBox";
            this.custAreaComboBox.Size = new System.Drawing.Size(121, 24);
            this.custAreaComboBox.Sorted = true;
            this.custAreaComboBox.TabIndex = 7;
            this.custAreaComboBox.DropDown += new System.EventHandler(this.custAreaComboBox_DropDown);
            this.custAreaComboBox.SelectedIndexChanged += new System.EventHandler(this.custArea_SelectedIndexChanged);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(11, 23);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(76, 16);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First Name:";
            // 
            // custFirstName
            // 
            this.custFirstName.Location = new System.Drawing.Point(91, 19);
            this.custFirstName.Name = "custFirstName";
            this.custFirstName.Size = new System.Drawing.Size(304, 20);
            this.custFirstName.TabIndex = 1;
            this.custFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.custFirstName_KeyDown);
            this.custFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.custFirstName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mobile :";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(11, 60);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(76, 16);
            this.lastName.TabIndex = 6;
            this.lastName.Text = "Last Name:";
            // 
            // custEmail
            // 
            this.custEmail.Location = new System.Drawing.Point(91, 128);
            this.custEmail.Name = "custEmail";
            this.custEmail.Size = new System.Drawing.Size(304, 20);
            this.custEmail.TabIndex = 4;
            this.custEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.custEmail_KeyDown);
            // 
            // custMobile
            // 
            this.custMobile.Location = new System.Drawing.Point(91, 91);
            this.custMobile.Name = "custMobile";
            this.custMobile.Size = new System.Drawing.Size(304, 20);
            this.custMobile.TabIndex = 3;
            this.custMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.custMobile_KeyDown);
            // 
            // custLastName
            // 
            this.custLastName.Location = new System.Drawing.Point(91, 56);
            this.custLastName.Name = "custLastName";
            this.custLastName.Size = new System.Drawing.Size(304, 20);
            this.custLastName.TabIndex = 2;
            this.custLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.custLastName_KeyDown);
            // 
            // addProfileImgBtn
            // 
            this.addProfileImgBtn.Location = new System.Drawing.Point(536, 226);
            this.addProfileImgBtn.Name = "addProfileImgBtn";
            this.addProfileImgBtn.Size = new System.Drawing.Size(138, 23);
            this.addProfileImgBtn.TabIndex = 9;
            this.addProfileImgBtn.Text = "Add Profile Image";
            this.addProfileImgBtn.UseVisualStyleBackColor = true;
            this.addProfileImgBtn.Click += new System.EventHandler(this.addProfileImgBtn_Click);
            // 
            // addCustomerSaveBtn
            // 
            this.addCustomerSaveBtn.Location = new System.Drawing.Point(127, 362);
            this.addCustomerSaveBtn.Name = "addCustomerSaveBtn";
            this.addCustomerSaveBtn.Size = new System.Drawing.Size(112, 23);
            this.addCustomerSaveBtn.TabIndex = 10;
            this.addCustomerSaveBtn.Text = "Save";
            this.addCustomerSaveBtn.UseVisualStyleBackColor = true;
            this.addCustomerSaveBtn.Click += new System.EventHandler(this.addCustomerSaveBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(245, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.custFirstName);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.custLastName);
            this.groupBox1.Controls.Add(this.custMobile);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.custEmail);
            this.groupBox1.Location = new System.Drawing.Point(73, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 154);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Details";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::EasyShopkeeping.Properties.Resources.mimizedIcon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(801, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 27);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EasyShopkeeping.Properties.Resources.closeIco;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(847, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 27);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // profilepictureBox
            // 
            this.profilepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profilepictureBox.Image")));
            this.profilepictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("profilepictureBox.InitialImage")));
            this.profilepictureBox.Location = new System.Drawing.Point(536, 23);
            this.profilepictureBox.Name = "profilepictureBox";
            this.profilepictureBox.Size = new System.Drawing.Size(198, 197);
            this.profilepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilepictureBox.TabIndex = 10;
            this.profilepictureBox.TabStop = false;
            this.profilepictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.profilepictureBox_MouseUp);
            // 
            // AddCustomerFrm
            // 
            this.AcceptButton = this.addCustomerSaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(887, 465);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.addCustomerSaveBtn);
            this.Controls.Add(this.addProfileImgBtn);
            this.Controls.Add(this.profilepictureBox);
            this.Controls.Add(this.custAddGroupBox);
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.Name = "AddCustomerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddCustomerFrm_KeyDown);
            this.custAddGroupBox.ResumeLayout(false);
            this.custAddGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilepictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox custAddGroupBox;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox custFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox custEmail;
        private System.Windows.Forms.TextBox custMobile;
        private System.Windows.Forms.TextBox custLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addAreaBtn;
        private System.Windows.Forms.ComboBox custAreaComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox custDistrictComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox profilepictureBox;
        private System.Windows.Forms.Button addProfileImgBtn;
        private System.Windows.Forms.Button addCustomerSaveBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button addDistrictBtn;
        private System.Windows.Forms.Button addStateBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox custStateComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}