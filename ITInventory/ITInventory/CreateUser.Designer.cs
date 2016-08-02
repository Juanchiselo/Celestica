namespace ITInventory
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.tabUsers = new ITInventory.TablessControl();
            this.tabCreateUser = new System.Windows.Forms.TabPage();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.lblUsersTitle = new System.Windows.Forms.Label();
            this.chkIsAdmin = new System.Windows.Forms.CheckBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPCID = new System.Windows.Forms.Label();
            this.tabSearchUser = new System.Windows.Forms.TabPage();
            this.cboResults = new System.Windows.Forms.ComboBox();
            this.cboCriteria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.lblCriteria = new System.Windows.Forms.Label();
            this.tabUsers.SuspendLayout();
            this.tabCreateUser.SuspendLayout();
            this.tabSearchUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.tabCreateUser);
            this.tabUsers.Controls.Add(this.tabSearchUser);
            this.tabUsers.Location = new System.Drawing.Point(0, 0);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.SelectedIndex = 0;
            this.tabUsers.Size = new System.Drawing.Size(528, 448);
            this.tabUsers.TabIndex = 96;
            // 
            // tabCreateUser
            // 
            this.tabCreateUser.Controls.Add(this.btnDeleteUser);
            this.tabCreateUser.Controls.Add(this.btnUpdateUser);
            this.tabCreateUser.Controls.Add(this.lblUsersTitle);
            this.tabCreateUser.Controls.Add(this.chkIsAdmin);
            this.tabCreateUser.Controls.Add(this.txtLastName);
            this.tabCreateUser.Controls.Add(this.label3);
            this.tabCreateUser.Controls.Add(this.txtFirstName);
            this.tabCreateUser.Controls.Add(this.label2);
            this.tabCreateUser.Controls.Add(this.txtPassword);
            this.tabCreateUser.Controls.Add(this.label1);
            this.tabCreateUser.Controls.Add(this.btnCreate);
            this.tabCreateUser.Controls.Add(this.txtUsername);
            this.tabCreateUser.Controls.Add(this.lblPCID);
            this.tabCreateUser.Location = new System.Drawing.Point(4, 29);
            this.tabCreateUser.Name = "tabCreateUser";
            this.tabCreateUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateUser.Size = new System.Drawing.Size(520, 415);
            this.tabCreateUser.TabIndex = 0;
            this.tabCreateUser.Text = "Create User";
            this.tabCreateUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(288, 328);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(176, 43);
            this.btnDeleteUser.TabIndex = 120;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Visible = false;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Location = new System.Drawing.Point(64, 328);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(176, 43);
            this.btnUpdateUser.TabIndex = 119;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Visible = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // lblUsersTitle
            // 
            this.lblUsersTitle.AutoSize = true;
            this.lblUsersTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblUsersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersTitle.ForeColor = System.Drawing.Color.Black;
            this.lblUsersTitle.Location = new System.Drawing.Point(176, 32);
            this.lblUsersTitle.Name = "lblUsersTitle";
            this.lblUsersTitle.Size = new System.Drawing.Size(153, 29);
            this.lblUsersTitle.TabIndex = 106;
            this.lblUsersTitle.Text = "Create User";
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.AutoSize = true;
            this.chkIsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsAdmin.Location = new System.Drawing.Point(170, 271);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkIsAdmin.Size = new System.Drawing.Size(152, 29);
            this.chkIsAdmin.TabIndex = 100;
            this.chkIsAdmin.Text = "Administrator";
            this.chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(226, 213);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(211, 26);
            this.txtLastName.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 105;
            this.label3.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(226, 171);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(211, 26);
            this.txtFirstName.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 104;
            this.label2.Text = "First Name:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(226, 129);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(211, 26);
            this.txtPassword.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 103;
            this.label1.Text = "Password:";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(138, 333);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(245, 43);
            this.btnCreate.TabIndex = 101;
            this.btnCreate.Text = "Create User";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(226, 86);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(211, 26);
            this.txtUsername.TabIndex = 96;
            // 
            // lblPCID
            // 
            this.lblPCID.AutoSize = true;
            this.lblPCID.BackColor = System.Drawing.Color.White;
            this.lblPCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCID.Location = new System.Drawing.Point(98, 87);
            this.lblPCID.Name = "lblPCID";
            this.lblPCID.Size = new System.Drawing.Size(108, 25);
            this.lblPCID.TabIndex = 102;
            this.lblPCID.Text = "Username:";
            // 
            // tabSearchUser
            // 
            this.tabSearchUser.Controls.Add(this.cboResults);
            this.tabSearchUser.Controls.Add(this.cboCriteria);
            this.tabSearchUser.Controls.Add(this.label5);
            this.tabSearchUser.Controls.Add(this.label8);
            this.tabSearchUser.Controls.Add(this.btnEditUser);
            this.tabSearchUser.Controls.Add(this.lblCriteria);
            this.tabSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSearchUser.Location = new System.Drawing.Point(4, 29);
            this.tabSearchUser.Name = "tabSearchUser";
            this.tabSearchUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchUser.Size = new System.Drawing.Size(520, 415);
            this.tabSearchUser.TabIndex = 1;
            this.tabSearchUser.Text = "Search User";
            this.tabSearchUser.UseVisualStyleBackColor = true;
            // 
            // cboResults
            // 
            this.cboResults.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboResults.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboResults.FormattingEnabled = true;
            this.cboResults.Items.AddRange(new object[] {
            "Name",
            "Username"});
            this.cboResults.Location = new System.Drawing.Point(216, 128);
            this.cboResults.Name = "cboResults";
            this.cboResults.Size = new System.Drawing.Size(248, 33);
            this.cboResults.Sorted = true;
            this.cboResults.TabIndex = 119;
            // 
            // cboCriteria
            // 
            this.cboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriteria.FormattingEnabled = true;
            this.cboCriteria.Items.AddRange(new object[] {
            "Username",
            "Name"});
            this.cboCriteria.Location = new System.Drawing.Point(216, 88);
            this.cboCriteria.Name = "cboCriteria";
            this.cboCriteria.Size = new System.Drawing.Size(248, 33);
            this.cboCriteria.TabIndex = 118;
            this.cboCriteria.SelectedIndexChanged += new System.EventHandler(this.cboCriteria_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(169, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 29);
            this.label5.TabIndex = 117;
            this.label5.Text = "Search User";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 114;
            this.label8.Text = "Results:";
            // 
            // btnEditUser
            // 
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.Location = new System.Drawing.Point(120, 184);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(245, 43);
            this.btnEditUser.TabIndex = 112;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // lblCriteria
            // 
            this.lblCriteria.AutoSize = true;
            this.lblCriteria.BackColor = System.Drawing.Color.White;
            this.lblCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteria.Location = new System.Drawing.Point(91, 90);
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Size = new System.Drawing.Size(80, 25);
            this.lblCriteria.TabIndex = 113;
            this.lblCriteria.Text = "Criteria:";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 437);
            this.Controls.Add(this.tabUsers);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.tabUsers.ResumeLayout(false);
            this.tabCreateUser.ResumeLayout(false);
            this.tabCreateUser.PerformLayout();
            this.tabSearchUser.ResumeLayout(false);
            this.tabSearchUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TablessControl tabUsers;
        private System.Windows.Forms.TabPage tabCreateUser;
        private System.Windows.Forms.Label lblUsersTitle;
        private System.Windows.Forms.CheckBox chkIsAdmin;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPCID;
        private System.Windows.Forms.TabPage tabSearchUser;
        private System.Windows.Forms.ComboBox cboCriteria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Label lblCriteria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboResults;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
    }
}