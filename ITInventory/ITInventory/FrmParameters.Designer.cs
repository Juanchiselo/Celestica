namespace ITInventory
{
    partial class FrmParameters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParameters));
            this.lblParameterType = new System.Windows.Forms.Label();
            this.btnAddParameter = new System.Windows.Forms.Button();
            this.lblParameter = new System.Windows.Forms.Label();
            this.lblParametersTitle = new System.Windows.Forms.Label();
            this.cboParameterType = new System.Windows.Forms.ComboBox();
            this.cboParameter = new System.Windows.Forms.ComboBox();
            this.btnRemoveParameter = new System.Windows.Forms.Button();
            this.btnEditParameter = new System.Windows.Forms.Button();
            this.btnUpdateParameter = new System.Windows.Forms.Button();
            this.lblExtraParameter = new System.Windows.Forms.Label();
            this.cboExtraParameter = new System.Windows.Forms.ComboBox();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblParameterType
            // 
            this.lblParameterType.AutoSize = true;
            this.lblParameterType.BackColor = System.Drawing.Color.White;
            this.lblParameterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParameterType.Location = new System.Drawing.Point(80, 104);
            this.lblParameterType.Name = "lblParameterType";
            this.lblParameterType.Size = new System.Drawing.Size(158, 25);
            this.lblParameterType.TabIndex = 148;
            this.lblParameterType.Text = "Parameter Type:";
            // 
            // btnAddParameter
            // 
            this.btnAddParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddParameter.Location = new System.Drawing.Point(176, 256);
            this.btnAddParameter.Name = "btnAddParameter";
            this.btnAddParameter.Size = new System.Drawing.Size(245, 43);
            this.btnAddParameter.TabIndex = 147;
            this.btnAddParameter.Text = "Add Parameter";
            this.btnAddParameter.UseVisualStyleBackColor = true;
            this.btnAddParameter.Click += new System.EventHandler(this.btnAddParameter_Click);
            // 
            // lblParameter
            // 
            this.lblParameter.AutoSize = true;
            this.lblParameter.BackColor = System.Drawing.Color.White;
            this.lblParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParameter.Location = new System.Drawing.Point(128, 152);
            this.lblParameter.Name = "lblParameter";
            this.lblParameter.Size = new System.Drawing.Size(108, 25);
            this.lblParameter.TabIndex = 149;
            this.lblParameter.Text = "Parameter:";
            // 
            // lblParametersTitle
            // 
            this.lblParametersTitle.AutoSize = true;
            this.lblParametersTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblParametersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametersTitle.ForeColor = System.Drawing.Color.Black;
            this.lblParametersTitle.Location = new System.Drawing.Point(208, 48);
            this.lblParametersTitle.Name = "lblParametersTitle";
            this.lblParametersTitle.Size = new System.Drawing.Size(187, 29);
            this.lblParametersTitle.TabIndex = 150;
            this.lblParametersTitle.Text = "Add Parameter";
            // 
            // cboParameterType
            // 
            this.cboParameterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParameterType.FormattingEnabled = true;
            this.cboParameterType.Items.AddRange(new object[] {
            "Brand",
            "Model",
            "Location",
            "OS",
            "Type"});
            this.cboParameterType.Location = new System.Drawing.Point(248, 104);
            this.cboParameterType.Name = "cboParameterType";
            this.cboParameterType.Size = new System.Drawing.Size(200, 33);
            this.cboParameterType.TabIndex = 151;
            this.cboParameterType.SelectedIndexChanged += new System.EventHandler(this.cboParameterType_SelectedIndexChanged);
            // 
            // cboParameter
            // 
            this.cboParameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParameter.FormattingEnabled = true;
            this.cboParameter.Location = new System.Drawing.Point(248, 152);
            this.cboParameter.Name = "cboParameter";
            this.cboParameter.Size = new System.Drawing.Size(200, 33);
            this.cboParameter.TabIndex = 152;
            this.cboParameter.Visible = false;
            // 
            // btnRemoveParameter
            // 
            this.btnRemoveParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveParameter.Location = new System.Drawing.Point(288, 256);
            this.btnRemoveParameter.Name = "btnRemoveParameter";
            this.btnRemoveParameter.Size = new System.Drawing.Size(245, 43);
            this.btnRemoveParameter.TabIndex = 153;
            this.btnRemoveParameter.Text = "Remove Parameter";
            this.btnRemoveParameter.UseVisualStyleBackColor = true;
            this.btnRemoveParameter.Visible = false;
            this.btnRemoveParameter.Click += new System.EventHandler(this.btnRemoveParameter_Click);
            // 
            // btnEditParameter
            // 
            this.btnEditParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditParameter.Location = new System.Drawing.Point(32, 256);
            this.btnEditParameter.Name = "btnEditParameter";
            this.btnEditParameter.Size = new System.Drawing.Size(245, 43);
            this.btnEditParameter.TabIndex = 154;
            this.btnEditParameter.Text = "Edit Parameter";
            this.btnEditParameter.UseVisualStyleBackColor = true;
            this.btnEditParameter.Visible = false;
            this.btnEditParameter.Click += new System.EventHandler(this.btnEditParameter_Click);
            // 
            // btnUpdateParameter
            // 
            this.btnUpdateParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateParameter.Location = new System.Drawing.Point(32, 256);
            this.btnUpdateParameter.Name = "btnUpdateParameter";
            this.btnUpdateParameter.Size = new System.Drawing.Size(245, 43);
            this.btnUpdateParameter.TabIndex = 155;
            this.btnUpdateParameter.Text = "Update Parameter";
            this.btnUpdateParameter.UseVisualStyleBackColor = true;
            this.btnUpdateParameter.Visible = false;
            this.btnUpdateParameter.Click += new System.EventHandler(this.btnUpdateParameter_Click);
            // 
            // lblExtraParameter
            // 
            this.lblExtraParameter.AutoSize = true;
            this.lblExtraParameter.BackColor = System.Drawing.Color.White;
            this.lblExtraParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraParameter.Location = new System.Drawing.Point(128, 200);
            this.lblExtraParameter.Name = "lblExtraParameter";
            this.lblExtraParameter.Size = new System.Drawing.Size(57, 25);
            this.lblExtraParameter.TabIndex = 156;
            this.lblExtraParameter.Text = "Type";
            this.lblExtraParameter.Visible = false;
            // 
            // cboExtraParameter
            // 
            this.cboExtraParameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExtraParameter.FormattingEnabled = true;
            this.cboExtraParameter.Location = new System.Drawing.Point(248, 200);
            this.cboExtraParameter.Name = "cboExtraParameter";
            this.cboExtraParameter.Size = new System.Drawing.Size(200, 33);
            this.cboExtraParameter.TabIndex = 157;
            this.cboExtraParameter.Visible = false;
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(248, 152);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(200, 30);
            this.txtParameter.TabIndex = 158;
            // 
            // FrmParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 333);
            this.Controls.Add(this.txtParameter);
            this.Controls.Add(this.cboExtraParameter);
            this.Controls.Add(this.lblExtraParameter);
            this.Controls.Add(this.btnUpdateParameter);
            this.Controls.Add(this.btnEditParameter);
            this.Controls.Add(this.btnRemoveParameter);
            this.Controls.Add(this.cboParameter);
            this.Controls.Add(this.cboParameterType);
            this.Controls.Add(this.lblParametersTitle);
            this.Controls.Add(this.lblParameter);
            this.Controls.Add(this.btnAddParameter);
            this.Controls.Add(this.lblParameterType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmParameters";
            this.Text = "Parameters";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmParameters_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParameterType;
        private System.Windows.Forms.Button btnAddParameter;
        private System.Windows.Forms.Label lblParameter;
        private System.Windows.Forms.Label lblParametersTitle;
        private System.Windows.Forms.ComboBox cboParameterType;
        private System.Windows.Forms.ComboBox cboParameter;
        private System.Windows.Forms.Button btnRemoveParameter;
        private System.Windows.Forms.Button btnEditParameter;
        private System.Windows.Forms.Button btnUpdateParameter;
        private System.Windows.Forms.Label lblExtraParameter;
        private System.Windows.Forms.ComboBox cboExtraParameter;
        private System.Windows.Forms.TextBox txtParameter;
    }
}