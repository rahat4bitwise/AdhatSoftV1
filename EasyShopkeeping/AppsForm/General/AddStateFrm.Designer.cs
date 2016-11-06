namespace EasyShopkeeping.AppsForm.General
{
    partial class AddStateFrm
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
            this.StateName = new System.Windows.Forms.GroupBox();
            this.addStateCancelBtn = new System.Windows.Forms.Button();
            this.stateName_Txt = new System.Windows.Forms.TextBox();
            this.addStateSaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.StateName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // StateName
            // 
            this.StateName.BackColor = System.Drawing.SystemColors.Info;
            this.StateName.Controls.Add(this.addStateCancelBtn);
            this.StateName.Controls.Add(this.stateName_Txt);
            this.StateName.Controls.Add(this.addStateSaveBtn);
            this.StateName.Controls.Add(this.label1);
            this.StateName.Location = new System.Drawing.Point(2, 12);
            this.StateName.Name = "StateName";
            this.StateName.Size = new System.Drawing.Size(364, 104);
            this.StateName.TabIndex = 7;
            this.StateName.TabStop = false;
            this.StateName.Enter += new System.EventHandler(this.StateName_Enter);
            // 
            // addStateCancelBtn
            // 
            this.addStateCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addStateCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStateCancelBtn.Image = global::EasyShopkeeping.Properties.Resources.round_error_warning_button_clip_art3;
            this.addStateCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStateCancelBtn.Location = new System.Drawing.Point(222, 50);
            this.addStateCancelBtn.Name = "addStateCancelBtn";
            this.addStateCancelBtn.Size = new System.Drawing.Size(87, 42);
            this.addStateCancelBtn.TabIndex = 4;
            this.addStateCancelBtn.Text = "Cancel";
            this.addStateCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addStateCancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addStateCancelBtn.UseVisualStyleBackColor = true;
            this.addStateCancelBtn.Click += new System.EventHandler(this.addStateCancelBtn_Click);
            // 
            // stateName_Txt
            // 
            this.stateName_Txt.Location = new System.Drawing.Point(139, 19);
            this.stateName_Txt.Name = "stateName_Txt";
            this.stateName_Txt.Size = new System.Drawing.Size(184, 20);
            this.stateName_Txt.TabIndex = 1;
            this.stateName_Txt.TextChanged += new System.EventHandler(this.stateName_Txt_TextChanged);
            // 
            // addStateSaveBtn
            // 
            this.addStateSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStateSaveBtn.Image = global::EasyShopkeeping.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Save;
            this.addStateSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStateSaveBtn.Location = new System.Drawing.Point(77, 50);
            this.addStateSaveBtn.Name = "addStateSaveBtn";
            this.addStateSaveBtn.Size = new System.Drawing.Size(93, 42);
            this.addStateSaveBtn.TabIndex = 3;
            this.addStateSaveBtn.Text = "Save";
            this.addStateSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addStateSaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addStateSaveBtn.UseVisualStyleBackColor = true;
            this.addStateSaveBtn.Click += new System.EventHandler(this.addStateSaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter State Name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddStateFrm
            // 
            this.AcceptButton = this.addStateSaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 109);
            this.Controls.Add(this.StateName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStateFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddState";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddStateFrm_KeyDown_1);
            this.StateName.ResumeLayout(false);
            this.StateName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StateName;
        private System.Windows.Forms.Button addStateCancelBtn;
        private System.Windows.Forms.TextBox stateName_Txt;
        private System.Windows.Forms.Button addStateSaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}