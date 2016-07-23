namespace ITInventory
{
    partial class FrmDatabaseSetUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatabaseSetUp));
            this.lblUID = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.BackColor = System.Drawing.Color.White;
            this.lblUID.Location = new System.Drawing.Point(383, 288);
            this.lblUID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(124, 29);
            this.lblUID.TabIndex = 93;
            this.lblUID.Text = "Username";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.BackColor = System.Drawing.Color.White;
            this.lblServerName.Location = new System.Drawing.Point(383, 176);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(84, 29);
            this.lblServerName.TabIndex = 91;
            this.lblServerName.Text = "Server";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(420, 436);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(381, 58);
            this.btnCreate.TabIndex = 88;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(541, 176);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(326, 35);
            this.txtServerName.TabIndex = 86;
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.BackColor = System.Drawing.Color.White;
            this.lblDatabaseName.Location = new System.Drawing.Point(383, 232);
            this.lblDatabaseName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(115, 29);
            this.lblDatabaseName.TabIndex = 90;
            this.lblDatabaseName.Text = "Database";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(541, 232);
            this.txtDatabaseName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(326, 35);
            this.txtDatabaseName.TabIndex = 86;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(541, 288);
            this.txtUID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(326, 35);
            this.txtUID.TabIndex = 86;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(383, 343);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 29);
            this.lblPassword.TabIndex = 93;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(541, 343);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(326, 35);
            this.txtPassword.TabIndex = 94;
            // 
            // FrmDatabaseSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 630);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUID);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblDatabaseName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmDatabaseSetUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Set Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.Label lblServerName;
        public System.Windows.Forms.Button btnCreate;
        public System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblDatabaseName;
        public System.Windows.Forms.TextBox txtDatabaseName;
        public System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
    }
}