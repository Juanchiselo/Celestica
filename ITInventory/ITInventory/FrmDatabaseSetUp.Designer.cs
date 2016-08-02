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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bwCreateDatabase = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.BackColor = System.Drawing.Color.White;
            this.lblUID.Location = new System.Drawing.Point(122, 384);
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
            this.lblServerName.Location = new System.Drawing.Point(122, 272);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(84, 29);
            this.lblServerName.TabIndex = 91;
            this.lblServerName.Text = "Server";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(159, 532);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(381, 58);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create Database";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(280, 272);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(5);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(326, 35);
            this.txtServerName.TabIndex = 0;
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.BackColor = System.Drawing.Color.White;
            this.lblDatabaseName.Location = new System.Drawing.Point(122, 328);
            this.lblDatabaseName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(115, 29);
            this.lblDatabaseName.TabIndex = 90;
            this.lblDatabaseName.Text = "Database";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(280, 328);
            this.txtDatabaseName.Margin = new System.Windows.Forms.Padding(5);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(326, 35);
            this.txtDatabaseName.TabIndex = 1;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(280, 384);
            this.txtUID.Margin = new System.Windows.Forms.Padding(5);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(326, 35);
            this.txtUID.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(122, 439);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 29);
            this.lblPassword.TabIndex = 93;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(280, 439);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(326, 35);
            this.txtPassword.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(384, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(328, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 95;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(208, 184);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(335, 46);
            this.lblTitle.TabIndex = 96;
            this.lblTitle.Text = "Create Database";
            // 
            // bwCreateDatabase
            // 
            this.bwCreateDatabase.WorkerReportsProgress = true;
            this.bwCreateDatabase.WorkerSupportsCancellation = true;
            this.bwCreateDatabase.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCreateDatabase_DoWork);
            this.bwCreateDatabase.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwCreateDatabase_ProgressChanged);
            this.bwCreateDatabase.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCreateDatabase_RunWorkerCompleted);
            // 
            // FrmDatabaseSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 630);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox2);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDatabaseSetUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Set Up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblTitle;
        private System.ComponentModel.BackgroundWorker bwCreateDatabase;
    }
}