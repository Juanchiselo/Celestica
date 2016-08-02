namespace ITInventory
{
    partial class FrmSetAssetTag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetAssetTag));
            this.txtAssetTag = new System.Windows.Forms.TextBox();
            this.lblAssetTag = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAssetTag
            // 
            this.txtAssetTag.Location = new System.Drawing.Point(327, 223);
            this.txtAssetTag.Name = "txtAssetTag";
            this.txtAssetTag.Size = new System.Drawing.Size(245, 35);
            this.txtAssetTag.TabIndex = 81;
            // 
            // lblAssetTag
            // 
            this.lblAssetTag.AutoSize = true;
            this.lblAssetTag.BackColor = System.Drawing.Color.White;
            this.lblAssetTag.Location = new System.Drawing.Point(149, 232);
            this.lblAssetTag.Name = "lblAssetTag";
            this.lblAssetTag.Size = new System.Drawing.Size(121, 29);
            this.lblAssetTag.TabIndex = 83;
            this.lblAssetTag.Text = "Asset Tag";
            // 
            // cboBrand
            // 
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Items.AddRange(new object[] {
            "Dell",
            "HP",
            "Lenovo"});
            this.cboBrand.Location = new System.Drawing.Point(327, 167);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(245, 37);
            this.cboBrand.Sorted = true;
            this.cboBrand.TabIndex = 80;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(149, 176);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(77, 29);
            this.lblBrand.TabIndex = 82;
            this.lblBrand.Text = "Brand";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(248, 328);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(245, 40);
            this.btnSet.TabIndex = 84;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(216, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(283, 46);
            this.lblTitle.TabIndex = 85;
            this.lblTitle.Text = "Set Asset Tag";
            // 
            // FrmSetAssetTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(729, 442);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtAssetTag);
            this.Controls.Add(this.lblAssetTag);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.lblBrand);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmSetAssetTag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Asset Tag In Bios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtAssetTag;
        private System.Windows.Forms.Label lblAssetTag;
        public System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.Label lblBrand;
        public System.Windows.Forms.Button btnSet;
        public System.Windows.Forms.Label lblTitle;
    }
}