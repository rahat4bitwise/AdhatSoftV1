namespace EasyShopkeeping.AppsForm.Outward
{
    partial class AddSellsDetailFrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerLbl = new System.Windows.Forms.Label();
            this.itemLbl = new System.Windows.Forms.Label();
            this.qtyTxt = new System.Windows.Forms.TextBox();
            this.rateTxt = new System.Windows.Forms.TextBox();
            this.totAmntTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.traderLbl = new System.Windows.Forms.Label();
            this.lotNo = new System.Windows.Forms.Label();
            this.lotBalLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(97, 227);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quatity";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total";
            // 
            // customerLbl
            // 
            this.customerLbl.AutoSize = true;
            this.customerLbl.Location = new System.Drawing.Point(167, 67);
            this.customerLbl.Name = "customerLbl";
            this.customerLbl.Size = new System.Drawing.Size(55, 13);
            this.customerLbl.TabIndex = 9;
            this.customerLbl.Text = "custName";
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Location = new System.Drawing.Point(167, 102);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(54, 13);
            this.itemLbl.TabIndex = 10;
            this.itemLbl.Text = "itemName";
            // 
            // qtyTxt
            // 
            this.qtyTxt.Location = new System.Drawing.Point(167, 130);
            this.qtyTxt.Name = "qtyTxt";
            this.qtyTxt.Size = new System.Drawing.Size(100, 20);
            this.qtyTxt.TabIndex = 13;
            this.qtyTxt.TextChanged += new System.EventHandler(this.qtyTxt_TextChanged);
            // 
            // rateTxt
            // 
            this.rateTxt.Location = new System.Drawing.Point(167, 156);
            this.rateTxt.Name = "rateTxt";
            this.rateTxt.Size = new System.Drawing.Size(100, 20);
            this.rateTxt.TabIndex = 14;
            this.rateTxt.TextChanged += new System.EventHandler(this.rateTxt_TextChanged);
            // 
            // totAmntTxt
            // 
            this.totAmntTxt.Location = new System.Drawing.Point(167, 182);
            this.totAmntTxt.Name = "totAmntTxt";
            this.totAmntTxt.Size = new System.Drawing.Size(100, 20);
            this.totAmntTxt.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Trader";
            // 
            // traderLbl
            // 
            this.traderLbl.AutoSize = true;
            this.traderLbl.Location = new System.Drawing.Point(385, 68);
            this.traderLbl.Name = "traderLbl";
            this.traderLbl.Size = new System.Drawing.Size(38, 13);
            this.traderLbl.TabIndex = 18;
            this.traderLbl.Text = "Trader";
            // 
            // lotNo
            // 
            this.lotNo.AutoSize = true;
            this.lotNo.Location = new System.Drawing.Point(293, 102);
            this.lotNo.Name = "lotNo";
            this.lotNo.Size = new System.Drawing.Size(73, 13);
            this.lotNo.TabIndex = 19;
            this.lotNo.Text = "Total Balance";
            // 
            // lotBalLbl
            // 
            this.lotBalLbl.AutoSize = true;
            this.lotBalLbl.Location = new System.Drawing.Point(385, 102);
            this.lotBalLbl.Name = "lotBalLbl";
            this.lotBalLbl.Size = new System.Drawing.Size(37, 13);
            this.lotBalLbl.TabIndex = 20;
            this.lotBalLbl.Text = "LotBal";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddSellsDetailFrm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 262);
            this.Controls.Add(this.lotBalLbl);
            this.Controls.Add(this.lotNo);
            this.Controls.Add(this.traderLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totAmntTxt);
            this.Controls.Add(this.rateTxt);
            this.Controls.Add(this.qtyTxt);
            this.Controls.Add(this.itemLbl);
            this.Controls.Add(this.customerLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.button1);
            this.Name = "AddSellsDetailFrm";
            this.Text = "AddSellsDetailFrm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddSellsDetailFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label customerLbl;
        private System.Windows.Forms.Label itemLbl;
        private System.Windows.Forms.TextBox qtyTxt;
        private System.Windows.Forms.TextBox rateTxt;
        private System.Windows.Forms.TextBox totAmntTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label traderLbl;
        private System.Windows.Forms.Label lotNo;
        private System.Windows.Forms.Label lotBalLbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}