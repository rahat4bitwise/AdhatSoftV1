namespace EasyShopkeeping.AppsForm.General
{
    partial class AddDistrictFrm
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
            this.AreaName = new System.Windows.Forms.GroupBox();
            this.addDistrictCancelBtn = new System.Windows.Forms.Button();
            this.distName_Txt = new System.Windows.Forms.TextBox();
            this.addDistrictSaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addDistrictStateComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.AreaName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // AreaName
            // 
            this.AreaName.BackColor = System.Drawing.SystemColors.Info;
            this.AreaName.Controls.Add(this.addDistrictStateComboBox);
            this.AreaName.Controls.Add(this.label2);
            this.AreaName.Controls.Add(this.addDistrictCancelBtn);
            this.AreaName.Controls.Add(this.distName_Txt);
            this.AreaName.Controls.Add(this.addDistrictSaveBtn);
            this.AreaName.Controls.Add(this.label1);
            this.AreaName.Location = new System.Drawing.Point(3, 12);
            this.AreaName.Name = "AreaName";
            this.AreaName.Size = new System.Drawing.Size(367, 137);
            this.AreaName.TabIndex = 6;
            this.AreaName.TabStop = false;
            // 
            // addDistrictCancelBtn
            // 
            this.addDistrictCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addDistrictCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDistrictCancelBtn.Image = global::EasyShopkeeping.Properties.Resources.round_error_warning_button_clip_art3;
            this.addDistrictCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDistrictCancelBtn.Location = new System.Drawing.Point(196, 95);
            this.addDistrictCancelBtn.Name = "addDistrictCancelBtn";
            this.addDistrictCancelBtn.Size = new System.Drawing.Size(87, 42);
            this.addDistrictCancelBtn.TabIndex = 4;
            this.addDistrictCancelBtn.Text = "Cancel";
            this.addDistrictCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addDistrictCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addDistrictCancelBtn.UseVisualStyleBackColor = true;
            this.addDistrictCancelBtn.Click += new System.EventHandler(this.addDistrictCancelBtn_Click);
            // 
            // distName_Txt
            // 
            this.distName_Txt.Location = new System.Drawing.Point(137, 61);
            this.distName_Txt.Name = "distName_Txt";
            this.distName_Txt.Size = new System.Drawing.Size(184, 20);
            this.distName_Txt.TabIndex = 1;
            // 
            // addDistrictSaveBtn
            // 
            this.addDistrictSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDistrictSaveBtn.Image = global::EasyShopkeeping.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Save;
            this.addDistrictSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDistrictSaveBtn.Location = new System.Drawing.Point(76, 95);
            this.addDistrictSaveBtn.Name = "addDistrictSaveBtn";
            this.addDistrictSaveBtn.Size = new System.Drawing.Size(93, 42);
            this.addDistrictSaveBtn.TabIndex = 3;
            this.addDistrictSaveBtn.Text = "Save";
            this.addDistrictSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addDistrictSaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addDistrictSaveBtn.UseVisualStyleBackColor = true;
            this.addDistrictSaveBtn.Click += new System.EventHandler(this.addDistrictSaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter District Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select State";
            // 
            // addDistrictStateComboBox
            // 
            this.addDistrictStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addDistrictStateComboBox.FormattingEnabled = true;
            this.addDistrictStateComboBox.Location = new System.Drawing.Point(137, 22);
            this.addDistrictStateComboBox.Name = "addDistrictStateComboBox";
            this.addDistrictStateComboBox.Size = new System.Drawing.Size(184, 21);
            this.addDistrictStateComboBox.TabIndex = 6;
            this.addDistrictStateComboBox.SelectedIndexChanged += new System.EventHandler(this.addDistrictStateComboBox_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddDistrictFrm
            // 
            this.AcceptButton = this.addDistrictSaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 151);
            this.Controls.Add(this.AreaName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDistrictFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddDistrict";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddDistrictFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddDistrictFrm_KeyDown);
            this.AreaName.ResumeLayout(false);
            this.AreaName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AreaName;
        private System.Windows.Forms.Button addDistrictCancelBtn;
        private System.Windows.Forms.TextBox distName_Txt;
        private System.Windows.Forms.Button addDistrictSaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox addDistrictStateComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}