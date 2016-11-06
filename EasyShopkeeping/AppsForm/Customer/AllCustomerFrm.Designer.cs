namespace EasyShopkeeping.AppsForm.Customer
{
    partial class AllCustomerFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.custId = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.TextBox();
            this.district = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.mobile = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.updateProfilePicBtn = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.Label();
            this.imgLoc = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.editButn = new System.Windows.Forms.Button();
            this.profiepictureBox = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.exportToExcelBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profiepictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AllowUserToResizeColumns = false;
            this.customerDataGridView.AllowUserToResizeRows = false;
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.customerDataGridView.Location = new System.Drawing.Point(5, 52);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerDataGridView.Size = new System.Drawing.Size(742, 461);
            this.customerDataGridView.TabIndex = 0;
            this.customerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::EasyShopkeeping.Properties.Resources.mimizedIcon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1164, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 40);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::EasyShopkeeping.Properties.Resources.closeIco;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1213, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 38);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.custId);
            this.panel1.Controls.Add(this.area);
            this.panel1.Controls.Add(this.district);
            this.panel1.Controls.Add(this.state);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.mobile);
            this.panel1.Controls.Add(this.lastName);
            this.panel1.Controls.Add(this.firstName);
            this.panel1.Controls.Add(this.printBtn);
            this.panel1.Controls.Add(this.updateProfilePicBtn);
            this.panel1.Controls.Add(this.fileName);
            this.panel1.Controls.Add(this.imgLoc);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.editButn);
            this.panel1.Controls.Add(this.profiepictureBox);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(753, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 461);
            this.panel1.TabIndex = 7;
            // 
            // custId
            // 
            this.custId.AutoSize = true;
            this.custId.Location = new System.Drawing.Point(21, 384);
            this.custId.Name = "custId";
            this.custId.Size = new System.Drawing.Size(36, 13);
            this.custId.TabIndex = 32;
            this.custId.Text = "custId";
            this.custId.Visible = false;
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(95, 233);
            this.area.Name = "area";
            this.area.ReadOnly = true;
            this.area.Size = new System.Drawing.Size(181, 20);
            this.area.TabIndex = 31;
            this.area.KeyDown += new System.Windows.Forms.KeyEventHandler(this.area_KeyDown);
            // 
            // district
            // 
            this.district.Location = new System.Drawing.Point(95, 197);
            this.district.Name = "district";
            this.district.ReadOnly = true;
            this.district.Size = new System.Drawing.Size(181, 20);
            this.district.TabIndex = 30;
            this.district.KeyDown += new System.Windows.Forms.KeyEventHandler(this.district_KeyDown);
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(95, 156);
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Size = new System.Drawing.Size(181, 20);
            this.state.TabIndex = 29;
            this.state.KeyDown += new System.Windows.Forms.KeyEventHandler(this.state_KeyDown);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(95, 119);
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Size = new System.Drawing.Size(181, 20);
            this.email.TabIndex = 28;
            this.email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.email_KeyDown);
            // 
            // mobile
            // 
            this.mobile.Location = new System.Drawing.Point(95, 83);
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            this.mobile.Size = new System.Drawing.Size(181, 20);
            this.mobile.TabIndex = 27;
            this.mobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mobile_KeyDown);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(95, 52);
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            this.lastName.Size = new System.Drawing.Size(181, 20);
            this.lastName.TabIndex = 26;
            this.lastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastName_KeyDown);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(95, 24);
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Size = new System.Drawing.Size(181, 20);
            this.firstName.TabIndex = 25;
            this.firstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstName_KeyDown);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(300, 286);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 23);
            this.printBtn.TabIndex = 24;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            // 
            // updateProfilePicBtn
            // 
            this.updateProfilePicBtn.Location = new System.Drawing.Point(359, 145);
            this.updateProfilePicBtn.Name = "updateProfilePicBtn";
            this.updateProfilePicBtn.Size = new System.Drawing.Size(75, 23);
            this.updateProfilePicBtn.TabIndex = 23;
            this.updateProfilePicBtn.Text = "Upload";
            this.updateProfilePicBtn.UseVisualStyleBackColor = true;
            this.updateProfilePicBtn.Visible = false;
            this.updateProfilePicBtn.Click += new System.EventHandler(this.updateProfilePicBtn_Click);
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(21, 356);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(51, 13);
            this.fileName.TabIndex = 22;
            this.fileName.Text = "FileName";
            this.fileName.Visible = false;
            // 
            // imgLoc
            // 
            this.imgLoc.AutoSize = true;
            this.imgLoc.Location = new System.Drawing.Point(21, 334);
            this.imgLoc.Name = "imgLoc";
            this.imgLoc.Size = new System.Drawing.Size(65, 13);
            this.imgLoc.TabIndex = 21;
            this.imgLoc.Text = "ImgLocation";
            this.imgLoc.Visible = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(207, 286);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 20;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(111, 286);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // editButn
            // 
            this.editButn.Location = new System.Drawing.Point(10, 286);
            this.editButn.Name = "editButn";
            this.editButn.Size = new System.Drawing.Size(75, 23);
            this.editButn.TabIndex = 18;
            this.editButn.Text = "Edit";
            this.editButn.UseVisualStyleBackColor = true;
            this.editButn.Click += new System.EventHandler(this.editButn_Click);
            // 
            // profiepictureBox
            // 
            this.profiepictureBox.Image = global::EasyShopkeeping.Properties.Resources.profileImg;
            this.profiepictureBox.Location = new System.Drawing.Point(330, 3);
            this.profiepictureBox.Name = "profiepictureBox";
            this.profiepictureBox.Size = new System.Drawing.Size(126, 136);
            this.profiepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profiepictureBox.TabIndex = 17;
            this.profiepictureBox.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Area";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "District";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mobile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.searchText);
            this.panel2.Controls.Add(this.exportToExcelBtn);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1248, 42);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search Customer";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(277, 19);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(282, 20);
            this.searchText.TabIndex = 10;
            this.searchText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // exportToExcelBtn
            // 
            this.exportToExcelBtn.Location = new System.Drawing.Point(3, 3);
            this.exportToExcelBtn.Name = "exportToExcelBtn";
            this.exportToExcelBtn.Size = new System.Drawing.Size(99, 37);
            this.exportToExcelBtn.TabIndex = 9;
            this.exportToExcelBtn.Text = "Export To Excel";
            this.exportToExcelBtn.UseVisualStyleBackColor = true;
            this.exportToExcelBtn.Click += new System.EventHandler(this.exportToExcelBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AllCustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EasyShopkeeping.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1256, 514);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customerDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllCustomerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Customer Details";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AllCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profiepictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox profiepictureBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button editButn;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label imgLoc;
        private System.Windows.Forms.Button updateProfilePicBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button exportToExcelBtn;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.TextBox district;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label custId;
    }
}