namespace ITInventory
{
    partial class FrmCheckAssetTag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckAssetTag));
            this.txtAssetTag = new System.Windows.Forms.TextBox();
            this.lblAssetTag = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAssetTag
            // 
            this.txtAssetTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetTag.Location = new System.Drawing.Point(136, 112);
            this.txtAssetTag.Name = "txtAssetTag";
            this.txtAssetTag.Size = new System.Drawing.Size(211, 30);
            this.txtAssetTag.TabIndex = 34;
            this.txtAssetTag.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAssetTag_KeyUp);
            this.txtAssetTag.Leave += new System.EventHandler(this.txtAssetTag_Leave);
            // 
            // lblAssetTag
            // 
            this.lblAssetTag.BackColor = System.Drawing.Color.White;
            this.lblAssetTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetTag.Location = new System.Drawing.Point(176, 48);
            this.lblAssetTag.Name = "lblAssetTag";
            this.lblAssetTag.Size = new System.Drawing.Size(124, 40);
            this.lblAssetTag.TabIndex = 33;
            this.lblAssetTag.Text = "Asset Tag";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(120, 168);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(245, 40);
            this.btnCheck.TabIndex = 50;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // FrmCheckAssetTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 258);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtAssetTag);
            this.Controls.Add(this.lblAssetTag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCheckAssetTag";
            this.Text = "Check Asset Tag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAssetTag;
        private System.Windows.Forms.Label lblAssetTag;
        private System.Windows.Forms.Button btnCheck;
    }
}