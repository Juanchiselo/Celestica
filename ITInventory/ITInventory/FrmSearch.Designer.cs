namespace ITInventory
{
    partial class FrmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearch));
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.cboSearchParameter = new System.Windows.Forms.ComboBox();
            this.lblParametersTitle = new System.Windows.Forms.Label();
            this.lblParameter = new System.Windows.Forms.Label();
            this.btnSearchParameter = new System.Windows.Forms.Button();
            this.lblSearchParameter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(248, 168);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(200, 30);
            this.txtParameter.TabIndex = 170;
            // 
            // cboSearchParameter
            // 
            this.cboSearchParameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchParameter.FormattingEnabled = true;
            this.cboSearchParameter.Items.AddRange(new object[] {
            "Type",
            "Brand",
            "Model",
            "Location",
            "Serial",
            "Asset Tag",
            "OS",
            "PCID",
            "Belongs To",
            "User"});
            this.cboSearchParameter.Location = new System.Drawing.Point(248, 120);
            this.cboSearchParameter.Name = "cboSearchParameter";
            this.cboSearchParameter.Size = new System.Drawing.Size(200, 33);
            this.cboSearchParameter.TabIndex = 163;
            // 
            // lblParametersTitle
            // 
            this.lblParametersTitle.AutoSize = true;
            this.lblParametersTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblParametersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametersTitle.ForeColor = System.Drawing.Color.Black;
            this.lblParametersTitle.Location = new System.Drawing.Point(240, 48);
            this.lblParametersTitle.Name = "lblParametersTitle";
            this.lblParametersTitle.Size = new System.Drawing.Size(95, 29);
            this.lblParametersTitle.TabIndex = 162;
            this.lblParametersTitle.Text = "Search";
            // 
            // lblParameter
            // 
            this.lblParameter.AutoSize = true;
            this.lblParameter.BackColor = System.Drawing.Color.White;
            this.lblParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParameter.Location = new System.Drawing.Point(128, 168);
            this.lblParameter.Name = "lblParameter";
            this.lblParameter.Size = new System.Drawing.Size(108, 25);
            this.lblParameter.TabIndex = 161;
            this.lblParameter.Text = "Parameter:";
            // 
            // btnSearchParameter
            // 
            this.btnSearchParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchParameter.Location = new System.Drawing.Point(176, 232);
            this.btnSearchParameter.Name = "btnSearchParameter";
            this.btnSearchParameter.Size = new System.Drawing.Size(245, 43);
            this.btnSearchParameter.TabIndex = 159;
            this.btnSearchParameter.Text = "Search Parameter";
            this.btnSearchParameter.UseVisualStyleBackColor = true;
            this.btnSearchParameter.Click += new System.EventHandler(this.btnSearchParameter_Click);
            // 
            // lblSearchParameter
            // 
            this.lblSearchParameter.AutoSize = true;
            this.lblSearchParameter.BackColor = System.Drawing.Color.White;
            this.lblSearchParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchParameter.Location = new System.Drawing.Point(56, 120);
            this.lblSearchParameter.Name = "lblSearchParameter";
            this.lblSearchParameter.Size = new System.Drawing.Size(176, 25);
            this.lblSearchParameter.TabIndex = 160;
            this.lblSearchParameter.Text = "Search Parameter:";
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 327);
            this.Controls.Add(this.txtParameter);
            this.Controls.Add(this.cboSearchParameter);
            this.Controls.Add(this.lblParametersTitle);
            this.Controls.Add(this.lblParameter);
            this.Controls.Add(this.btnSearchParameter);
            this.Controls.Add(this.lblSearchParameter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.ComboBox cboSearchParameter;
        private System.Windows.Forms.Label lblParametersTitle;
        private System.Windows.Forms.Label lblParameter;
        private System.Windows.Forms.Button btnSearchParameter;
        private System.Windows.Forms.Label lblSearchParameter;
    }
}