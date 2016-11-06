namespace EasyShopkeeping.AppsForm.General
{
    partial class AddAreaFrm
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
            this.addAreaDistrictcomboBox = new System.Windows.Forms.ComboBox();
            this.addAreaStatecomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addAreaCancelBtn = new System.Windows.Forms.Button();
            this.areaName_Txt = new System.Windows.Forms.TextBox();
            this.addAreaSaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.addDistictBtn = new System.Windows.Forms.Button();
            this.AreaName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // AreaName
            // 
            this.AreaName.BackColor = System.Drawing.SystemColors.Info;
            this.AreaName.Controls.Add(this.addDistictBtn);
            this.AreaName.Controls.Add(this.addAreaDistrictcomboBox);
            this.AreaName.Controls.Add(this.addAreaStatecomboBox);
            this.AreaName.Controls.Add(this.label3);
            this.AreaName.Controls.Add(this.label2);
            this.AreaName.Controls.Add(this.addAreaCancelBtn);
            this.AreaName.Controls.Add(this.areaName_Txt);
            this.AreaName.Controls.Add(this.addAreaSaveBtn);
            this.AreaName.Controls.Add(this.label1);
            this.AreaName.Location = new System.Drawing.Point(1, 12);
            this.AreaName.Name = "AreaName";
            this.AreaName.Size = new System.Drawing.Size(421, 174);
            this.AreaName.TabIndex = 5;
            this.AreaName.TabStop = false;
            this.AreaName.Enter += new System.EventHandler(this.AreaName_Enter);
            // 
            // addAreaDistrictcomboBox
            // 
            this.addAreaDistrictcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addAreaDistrictcomboBox.FormattingEnabled = true;
            this.addAreaDistrictcomboBox.Location = new System.Drawing.Point(146, 58);
            this.addAreaDistrictcomboBox.Name = "addAreaDistrictcomboBox";
            this.addAreaDistrictcomboBox.Size = new System.Drawing.Size(184, 21);
            this.addAreaDistrictcomboBox.TabIndex = 8;
            this.addAreaDistrictcomboBox.SelectedIndexChanged += new System.EventHandler(this.addAreaDistrictcomboBox_SelectedIndexChanged);
            // 
            // addAreaStatecomboBox
            // 
            this.addAreaStatecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addAreaStatecomboBox.FormattingEnabled = true;
            this.addAreaStatecomboBox.Location = new System.Drawing.Point(146, 27);
            this.addAreaStatecomboBox.Name = "addAreaStatecomboBox";
            this.addAreaStatecomboBox.Size = new System.Drawing.Size(184, 21);
            this.addAreaStatecomboBox.TabIndex = 7;
            this.addAreaStatecomboBox.SelectedIndexChanged += new System.EventHandler(this.addAreaStatecomboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select District";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select State";
            // 
            // addAreaCancelBtn
            // 
            this.addAreaCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addAreaCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAreaCancelBtn.Image = global::EasyShopkeeping.Properties.Resources.round_error_warning_button_clip_art3;
            this.addAreaCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAreaCancelBtn.Location = new System.Drawing.Point(197, 126);
            this.addAreaCancelBtn.Name = "addAreaCancelBtn";
            this.addAreaCancelBtn.Size = new System.Drawing.Size(87, 42);
            this.addAreaCancelBtn.TabIndex = 4;
            this.addAreaCancelBtn.Text = "Cancel";
            this.addAreaCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addAreaCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addAreaCancelBtn.UseVisualStyleBackColor = true;
            this.addAreaCancelBtn.Click += new System.EventHandler(this.addAreaCancelBtn_Click);
            // 
            // areaName_Txt
            // 
            this.areaName_Txt.Location = new System.Drawing.Point(146, 91);
            this.areaName_Txt.Name = "areaName_Txt";
            this.areaName_Txt.Size = new System.Drawing.Size(184, 20);
            this.areaName_Txt.TabIndex = 1;
            // 
            // addAreaSaveBtn
            // 
            this.addAreaSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAreaSaveBtn.Image = global::EasyShopkeeping.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Save;
            this.addAreaSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAreaSaveBtn.Location = new System.Drawing.Point(78, 126);
            this.addAreaSaveBtn.Name = "addAreaSaveBtn";
            this.addAreaSaveBtn.Size = new System.Drawing.Size(93, 42);
            this.addAreaSaveBtn.TabIndex = 3;
            this.addAreaSaveBtn.Text = "Save";
            this.addAreaSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addAreaSaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addAreaSaveBtn.UseVisualStyleBackColor = true;
            this.addAreaSaveBtn.Click += new System.EventHandler(this.addAreaSaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Area Name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // addDistictBtn
            // 
            this.addDistictBtn.Location = new System.Drawing.Point(336, 56);
            this.addDistictBtn.Name = "addDistictBtn";
            this.addDistictBtn.Size = new System.Drawing.Size(75, 23);
            this.addDistictBtn.TabIndex = 9;
            this.addDistictBtn.Text = "Add District";
            this.addDistictBtn.UseVisualStyleBackColor = true;
            this.addDistictBtn.Visible = false;
            this.addDistictBtn.Click += new System.EventHandler(this.addDistictBtn_Click);
            // 
            // AddAreaFrm
            // 
            this.AcceptButton = this.addAreaSaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.addAreaCancelBtn;
            this.ClientSize = new System.Drawing.Size(434, 188);
            this.Controls.Add(this.AreaName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAreaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddArea";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddArea_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddAreaFrm_KeyDown);
            this.AreaName.ResumeLayout(false);
            this.AreaName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AreaName;
        private System.Windows.Forms.Button addAreaCancelBtn;
        private System.Windows.Forms.TextBox areaName_Txt;
        private System.Windows.Forms.Button addAreaSaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox addAreaDistrictcomboBox;
        private System.Windows.Forms.ComboBox addAreaStatecomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button addDistictBtn;

    }
}