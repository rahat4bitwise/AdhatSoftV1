namespace EasyShopkeeping.AppsForm.MasterEntry.Category
{
    partial class AddItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addItemSaveBtn = new System.Windows.Forms.Button();
            this.addItemCategorycomboBox = new System.Windows.Forms.ComboBox();
            this.itemNameTxt = new System.Windows.Forms.TextBox();
            this.addItemCancelBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Item Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Item Name";
            // 
            // addItemSaveBtn
            // 
            this.addItemSaveBtn.Location = new System.Drawing.Point(84, 111);
            this.addItemSaveBtn.Name = "addItemSaveBtn";
            this.addItemSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemSaveBtn.TabIndex = 3;
            this.addItemSaveBtn.Text = "Save";
            this.addItemSaveBtn.UseVisualStyleBackColor = true;
            this.addItemSaveBtn.Click += new System.EventHandler(this.addItemSaveBtn_Click);
            // 
            // addItemCategorycomboBox
            // 
            this.addItemCategorycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addItemCategorycomboBox.FormattingEnabled = true;
            this.addItemCategorycomboBox.Location = new System.Drawing.Point(123, 30);
            this.addItemCategorycomboBox.Name = "addItemCategorycomboBox";
            this.addItemCategorycomboBox.Size = new System.Drawing.Size(121, 21);
            this.addItemCategorycomboBox.TabIndex = 4;
            this.addItemCategorycomboBox.SelectedIndexChanged += new System.EventHandler(this.addItemCategorycomboBox_SelectedIndexChanged);
            // 
            // itemNameTxt
            // 
            this.itemNameTxt.Location = new System.Drawing.Point(123, 65);
            this.itemNameTxt.Name = "itemNameTxt";
            this.itemNameTxt.Size = new System.Drawing.Size(121, 20);
            this.itemNameTxt.TabIndex = 5;
            this.itemNameTxt.TextChanged += new System.EventHandler(this.itemNameTxt_TextChanged);
            // 
            // addItemCancelBtn
            // 
            this.addItemCancelBtn.Location = new System.Drawing.Point(169, 111);
            this.addItemCancelBtn.Name = "addItemCancelBtn";
            this.addItemCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemCancelBtn.TabIndex = 6;
            this.addItemCancelBtn.Text = "Cancel";
            this.addItemCancelBtn.UseVisualStyleBackColor = true;
            this.addItemCancelBtn.Click += new System.EventHandler(this.addItemCancelBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(307, 161);
            this.Controls.Add(this.addItemCancelBtn);
            this.Controls.Add(this.itemNameTxt);
            this.Controls.Add(this.addItemCategorycomboBox);
            this.Controls.Add(this.addItemSaveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddItem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addItemSaveBtn;
        private System.Windows.Forms.ComboBox addItemCategorycomboBox;
        private System.Windows.Forms.TextBox itemNameTxt;
        private System.Windows.Forms.Button addItemCancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}