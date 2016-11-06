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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerFrm));
            this.custAddGroupBox = new System.Windows.Forms.GroupBox();
            this.custState = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.custSubArea = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.custDistrict = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addAreaBtn = new System.Windows.Forms.Button();
            this.custArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.custFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.custEmail = new System.Windows.Forms.TextBox();
            this.custMobile = new System.Windows.Forms.TextBox();
            this.custLastName = new System.Windows.Forms.TextBox();
            this.profilepictureBox = new System.Windows.Forms.PictureBox();
            this.addProfileImgBtn = new System.Windows.Forms.Button();
            this.addCustomerSaveBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.custImgLocation = new System.Windows.Forms.Label();
            this.custAddGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // custAddGroupBox
            // 
            this.custAddGroupBox.Controls.Add(this.custState);
            this.custAddGroupBox.Controls.Add(this.label6);
            this.custAddGroupBox.Controls.Add(this.button1);
            this.custAddGroupBox.Controls.Add(this.custSubArea);
            this.custAddGroupBox.Controls.Add(this.label5);
            this.custAddGroupBox.Controls.Add(this.custDistrict);
            this.custAddGroupBox.Controls.Add(this.label2);
            this.custAddGroupBox.Controls.Add(this.addAreaBtn);
            this.custAddGroupBox.Controls.Add(this.custArea);
            this.custAddGroupBox.Controls.Add(this.label1);
            this.custAddGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custAddGroupBox.Location = new System.Drawing.Point(76, 172);
            this.custAddGroupBox.Name = "custAddGroupBox";
            this.custAddGroupBox.Size = new System.Drawing.Size(392, 206);
            this.custAddGroupBox.TabIndex = 0;
            this.custAddGroupBox.TabStop = false;
            this.custAddGroupBox.Text = "Address";
            // 
            // custState
            // 
            this.custState.FormattingEnabled = true;
            this.custState.Items.AddRange(new object[] {
            "Bihar",
            "UP",
            "Maharashtra",
            "West Bengal",
            "Jharkand"});
            this.custState.Location = new System.Drawing.Point(138, 163);
            this.custState.Name = "custState";
            this.custState.Size = new System.Drawing.Size(121, 24);
            this.custState.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "State :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Sub Area";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // custSubArea
            // 
            this.custSubArea.FormattingEnabled = true;
            this.custSubArea.Location = new System.Drawing.Point(138, 82);
            this.custSubArea.Name = "custSubArea";
            this.custSubArea.Size = new System.Drawing.Size(121, 24);
            this.custSubArea.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sub Area:";
            // 
            // custDistrict
            // 
            this.custDistrict.FormattingEnabled = true;
            this.custDistrict.Items.AddRange(new object[] {
            "Gaya",
            "Aurangabad",
            "Jehanabad",
            "Patna",
            "Nawada",
            "Nalanda"});
            this.custDistrict.Location = new System.Drawing.Point(138, 121);
            this.custDistrict.Name = "custDistrict";
            this.custDistrict.Size = new System.Drawing.Size(121, 24);
            this.custDistrict.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "District :";
            // 
            // addAreaBtn
            // 
            this.addAreaBtn.Location = new System.Drawing.Point(266, 37);
            this.addAreaBtn.Name = "addAreaBtn";
            this.addAreaBtn.Size = new System.Drawing.Size(112, 23);
            this.addAreaBtn.TabIndex = 2;
            this.addAreaBtn.Text = "Add Area";
            this.addAreaBtn.UseVisualStyleBackColor = true;
            // 
            // custArea
            // 
            this.custArea.FormattingEnabled = true;
            this.custArea.Location = new System.Drawing.Point(138, 41);
            this.custArea.Name = "custArea";
            this.custArea.Size = new System.Drawing.Size(121, 24);
            this.custArea.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area:";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(72, 23);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(76, 16);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First Name:";
            // 
            // custFirstName
            // 
            this.custFirstName.Location = new System.Drawing.Point(164, 23);
            this.custFirstName.Name = "custFirstName";
            this.custFirstName.Size = new System.Drawing.Size(304, 20);
            this.custFirstName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mobile :";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(72, 61);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(76, 16);
            this.lastName.TabIndex = 6;
            this.lastName.Text = "Last Name:";
            // 
            // custEmail
            // 
            this.custEmail.Location = new System.Drawing.Point(164, 134);
            this.custEmail.Name = "custEmail";
            this.custEmail.Size = new System.Drawing.Size(304, 20);
            this.custEmail.TabIndex = 7;
            // 
            // custMobile
            // 
            this.custMobile.Location = new System.Drawing.Point(164, 97);
            this.custMobile.Name = "custMobile";
            this.custMobile.Size = new System.Drawing.Size(304, 20);
            this.custMobile.TabIndex = 8;
            // 
            // custLastName
            // 
            this.custLastName.Location = new System.Drawing.Point(164, 61);
            this.custLastName.Name = "custLastName";
            this.custLastName.Size = new System.Drawing.Size(304, 20);
            this.custLastName.TabIndex = 9;
            // 
            // profilepictureBox
            // 
            this.profilepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profilepictureBox.Image")));
            this.profilepictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("profilepictureBox.InitialImage")));
            this.profilepictureBox.Location = new System.Drawing.Point(507, 23);
            this.profilepictureBox.Name = "profilepictureBox";
            this.profilepictureBox.Size = new System.Drawing.Size(198, 197);
            this.profilepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilepictureBox.TabIndex = 10;
            this.profilepictureBox.TabStop = false;
            // 
            // addProfileImgBtn
            // 
            this.addProfileImgBtn.Location = new System.Drawing.Point(536, 226);
            this.addProfileImgBtn.Name = "addProfileImgBtn";
            this.addProfileImgBtn.Size = new System.Drawing.Size(138, 23);
            this.addProfileImgBtn.TabIndex = 11;
            this.addProfileImgBtn.Text = "Add Profile Image";
            this.addProfileImgBtn.UseVisualStyleBackColor = true;
            this.addProfileImgBtn.Click += new System.EventHandler(this.addProfileImgBtn_Click);
            // 
            // addCustomerSaveBtn
            // 
            this.addCustomerSaveBtn.Location = new System.Drawing.Point(76, 407);
            this.addCustomerSaveBtn.Name = "addCustomerSaveBtn";
            this.addCustomerSaveBtn.Size = new System.Drawing.Size(112, 23);
            this.addCustomerSaveBtn.TabIndex = 12;
            this.addCustomerSaveBtn.Text = "Save";
            this.addCustomerSaveBtn.UseVisualStyleBackColor = true;
            this.addCustomerSaveBtn.Click += new System.EventHandler(this.addCustomerSaveBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(238, 407);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // custImgLocation
            // 
            this.custImgLocation.AutoSize = true;
            this.custImgLocation.Location = new System.Drawing.Point(590, 264);
            this.custImgLocation.Name = "custImgLocation";
            this.custImgLocation.Size = new System.Drawing.Size(97, 13);
            this.custImgLocation.TabIndex = 14;
            this.custImgLocation.Text = "custImageLocation";
            this.custImgLocation.Visible = false;
            // 
            // AddCustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(887, 465);
            this.Controls.Add(this.custImgLocation);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.addCustomerSaveBtn);
            this.Controls.Add(this.addProfileImgBtn);
            this.Controls.Add(this.profilepictureBox);
            this.Controls.Add(this.custLastName);
            this.Controls.Add(this.custMobile);
            this.Controls.Add(this.custEmail);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.custFirstName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.custAddGroupBox);
            this.Name = "AddCustomerFrm";
            this.Text = "CustomerForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.custAddGroupBox.ResumeLayout(false);
            this.custAddGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox custArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox custSubArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox custDistrict;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox custState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox profilepictureBox;
        private System.Windows.Forms.Button addProfileImgBtn;
        private System.Windows.Forms.Button addCustomerSaveBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label custImgLocation;
    }
}