namespace EasyShopkeeping
{
    partial class GetNewCategoryInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctgry_Txt = new System.Windows.Forms.TextBox();
            this.saveCategoryBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // ctgry_Txt
            // 
            this.ctgry_Txt.Location = new System.Drawing.Point(117, 19);
            this.ctgry_Txt.Name = "ctgry_Txt";
            this.ctgry_Txt.Size = new System.Drawing.Size(184, 20);
            this.ctgry_Txt.TabIndex = 1;
            // 
            // saveCategoryBtn
            // 
            this.saveCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCategoryBtn.Image = global::EasyShopkeeping.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Save;
            this.saveCategoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveCategoryBtn.Location = new System.Drawing.Point(357, 6);
            this.saveCategoryBtn.Name = "saveCategoryBtn";
            this.saveCategoryBtn.Size = new System.Drawing.Size(93, 42);
            this.saveCategoryBtn.TabIndex = 3;
            this.saveCategoryBtn.Text = "Save";
            this.saveCategoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveCategoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveCategoryBtn.UseVisualStyleBackColor = true;
            this.saveCategoryBtn.Click += new System.EventHandler(this.saveCategoryBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.ctgry_Txt);
            this.groupBox1.Controls.Add(this.saveCategoryBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Cateogy Name";
            // 
            // GetNewCategoryInput
            // 
            this.AcceptButton = this.saveCategoryBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 77);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetNewCategoryInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetNewCategoryInput";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GetNewCategoryInput_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctgry_Txt;
        private System.Windows.Forms.Button saveCategoryBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}