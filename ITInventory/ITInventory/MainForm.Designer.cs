namespace ITInventory
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mnuMain = new System.Windows.Forms.MainMenu(this.components);
            this.mnuInventory = new System.Windows.Forms.MenuItem();
            this.mnuAdd = new System.Windows.Forms.MenuItem();
            this.mnuView = new System.Windows.Forms.MenuItem();
            this.mnuCheckAssetTag = new System.Windows.Forms.MenuItem();
            this.mnuSearch = new System.Windows.Forms.MenuItem();
            this.mnuDatabase = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.mnuCreateUser = new System.Windows.Forms.MenuItem();
            this.mnuEditUser = new System.Windows.Forms.MenuItem();
            this.mnuParameters = new System.Windows.Forms.MenuItem();
            this.mnuAddParameter = new System.Windows.Forms.MenuItem();
            this.mnuEditParameter = new System.Windows.Forms.MenuItem();
            this.mnuBulkAdd = new System.Windows.Forms.MenuItem();
            this.tabMenus = new ITInventory.TablessControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAutoCollect = new System.Windows.Forms.Button();
            this.btnComment = new System.Windows.Forms.Button();
            this.txtBelongsTo = new System.Windows.Forms.TextBox();
            this.lblBelongsTo = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAssetTag = new System.Windows.Forms.TextBox();
            this.lblAssetTag = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstPeripherals = new System.Windows.Forms.CheckedListBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cboOS = new System.Windows.Forms.ComboBox();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.lblOS = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPeripherals = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtPCID = new System.Windows.Forms.TextBox();
            this.lblPCID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPreventiveMaintenance = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblUsernameGoal = new System.Windows.Forms.Label();
            this.tabMenus.SuspendLayout();
            this.tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPreventiveMaintenance.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuInventory,
            this.mnuDatabase});
            // 
            // mnuInventory
            // 
            this.mnuInventory.Index = 0;
            this.mnuInventory.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAdd,
            this.mnuBulkAdd,
            this.mnuView,
            this.mnuCheckAssetTag,
            this.mnuSearch});
            this.mnuInventory.Text = "Inventory";
            // 
            // mnuAdd
            // 
            this.mnuAdd.Index = 0;
            this.mnuAdd.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftA;
            this.mnuAdd.Text = "Add Asset";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuView
            // 
            this.mnuView.Index = 2;
            this.mnuView.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftV;
            this.mnuView.Text = "View";
            this.mnuView.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuCheckAssetTag
            // 
            this.mnuCheckAssetTag.Index = 3;
            this.mnuCheckAssetTag.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftC;
            this.mnuCheckAssetTag.Text = "Check Asset Tag";
            this.mnuCheckAssetTag.Click += new System.EventHandler(this.mnuCheckAssetTag_Click);
            // 
            // mnuSearch
            // 
            this.mnuSearch.Index = 4;
            this.mnuSearch.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mnuSearch.Text = "Search";
            this.mnuSearch.Click += new System.EventHandler(this.mnuSearch_Click);
            // 
            // mnuDatabase
            // 
            this.mnuDatabase.Index = 1;
            this.mnuDatabase.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11,
            this.mnuParameters});
            this.mnuDatabase.Text = "Database";
            this.mnuDatabase.Visible = false;
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuCreateUser,
            this.mnuEditUser});
            this.menuItem11.Text = "Users";
            // 
            // mnuCreateUser
            // 
            this.mnuCreateUser.Index = 0;
            this.mnuCreateUser.Text = "Create User";
            this.mnuCreateUser.Click += new System.EventHandler(this.mnuCreateUser_Click);
            // 
            // mnuEditUser
            // 
            this.mnuEditUser.Index = 1;
            this.mnuEditUser.Text = "Edit User";
            this.mnuEditUser.Visible = false;
            this.mnuEditUser.Click += new System.EventHandler(this.mnuEditUser_Click);
            // 
            // mnuParameters
            // 
            this.mnuParameters.Index = 1;
            this.mnuParameters.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAddParameter,
            this.mnuEditParameter});
            this.mnuParameters.Text = "Parameters";
            // 
            // mnuAddParameter
            // 
            this.mnuAddParameter.Index = 0;
            this.mnuAddParameter.Text = "Add Parameter";
            this.mnuAddParameter.Click += new System.EventHandler(this.mnuAddParameter_Click);
            // 
            // mnuEditParameter
            // 
            this.mnuEditParameter.Index = 1;
            this.mnuEditParameter.Text = "Edit Parameter";
            this.mnuEditParameter.Visible = false;
            this.mnuEditParameter.Click += new System.EventHandler(this.mnuRemoveParameter_Click);
            // 
            // mnuBulkAdd
            // 
            this.mnuBulkAdd.Index = 1;
            this.mnuBulkAdd.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftB;
            this.mnuBulkAdd.Text = "Bulk Add";
            this.mnuBulkAdd.Click += new System.EventHandler(this.mnuBulkAdd_Click);
            // 
            // tabMenus
            // 
            this.tabMenus.Controls.Add(this.tabAdd);
            this.tabMenus.Controls.Add(this.tabPreventiveMaintenance);
            this.tabMenus.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabMenus.Location = new System.Drawing.Point(-8, -4);
            this.tabMenus.Multiline = true;
            this.tabMenus.Name = "tabMenus";
            this.tabMenus.SelectedIndex = 0;
            this.tabMenus.Size = new System.Drawing.Size(966, 700);
            this.tabMenus.TabIndex = 1;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.btnUpdate);
            this.tabAdd.Controls.Add(this.btnAutoCollect);
            this.tabAdd.Controls.Add(this.btnComment);
            this.tabAdd.Controls.Add(this.txtBelongsTo);
            this.tabAdd.Controls.Add(this.lblBelongsTo);
            this.tabAdd.Controls.Add(this.btnClear);
            this.tabAdd.Controls.Add(this.txtAssetTag);
            this.tabAdd.Controls.Add(this.lblAssetTag);
            this.tabAdd.Controls.Add(this.txtSerial);
            this.tabAdd.Controls.Add(this.lblSerial);
            this.tabAdd.Controls.Add(this.lblTitle);
            this.tabAdd.Controls.Add(this.cboType);
            this.tabAdd.Controls.Add(this.label9);
            this.tabAdd.Controls.Add(this.lstPeripherals);
            this.tabAdd.Controls.Add(this.lblUsername);
            this.tabAdd.Controls.Add(this.cboOS);
            this.tabAdd.Controls.Add(this.cboModel);
            this.tabAdd.Controls.Add(this.cboBrand);
            this.tabAdd.Controls.Add(this.cboLocation);
            this.tabAdd.Controls.Add(this.lblOS);
            this.tabAdd.Controls.Add(this.btnAdd);
            this.tabAdd.Controls.Add(this.lblPeripherals);
            this.tabAdd.Controls.Add(this.lblBrand);
            this.tabAdd.Controls.Add(this.lblModel);
            this.tabAdd.Controls.Add(this.lblLocation);
            this.tabAdd.Controls.Add(this.txtPCID);
            this.tabAdd.Controls.Add(this.lblPCID);
            this.tabAdd.Controls.Add(this.pictureBox1);
            this.tabAdd.Location = new System.Drawing.Point(4, 38);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(958, 658);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(352, 584);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(245, 40);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAutoCollect
            // 
            this.btnAutoCollect.Location = new System.Drawing.Point(632, 472);
            this.btnAutoCollect.Name = "btnAutoCollect";
            this.btnAutoCollect.Size = new System.Drawing.Size(245, 40);
            this.btnAutoCollect.TabIndex = 87;
            this.btnAutoCollect.Text = "Magical Button";
            this.btnAutoCollect.UseVisualStyleBackColor = true;
            this.btnAutoCollect.Visible = false;
            this.btnAutoCollect.Click += new System.EventHandler(this.btnAutoCollect_Click);
            // 
            // btnComment
            // 
            this.btnComment.Location = new System.Drawing.Point(632, 584);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(245, 40);
            this.btnComment.TabIndex = 12;
            this.btnComment.Text = "Comment";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // txtBelongsTo
            // 
            this.txtBelongsTo.Location = new System.Drawing.Point(368, 528);
            this.txtBelongsTo.Name = "txtBelongsTo";
            this.txtBelongsTo.Size = new System.Drawing.Size(211, 35);
            this.txtBelongsTo.TabIndex = 9;
            this.txtBelongsTo.Visible = false;
            // 
            // lblBelongsTo
            // 
            this.lblBelongsTo.AutoSize = true;
            this.lblBelongsTo.BackColor = System.Drawing.Color.White;
            this.lblBelongsTo.Location = new System.Drawing.Point(216, 536);
            this.lblBelongsTo.Name = "lblBelongsTo";
            this.lblBelongsTo.Size = new System.Drawing.Size(138, 29);
            this.lblBelongsTo.TabIndex = 84;
            this.lblBelongsTo.Text = "Belongs To";
            this.lblBelongsTo.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(352, 584);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(245, 40);
            this.btnClear.TabIndex = 83;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAssetTag
            // 
            this.txtAssetTag.Location = new System.Drawing.Point(368, 384);
            this.txtAssetTag.Name = "txtAssetTag";
            this.txtAssetTag.Size = new System.Drawing.Size(211, 35);
            this.txtAssetTag.TabIndex = 6;
            // 
            // lblAssetTag
            // 
            this.lblAssetTag.AutoSize = true;
            this.lblAssetTag.BackColor = System.Drawing.Color.White;
            this.lblAssetTag.Location = new System.Drawing.Point(216, 392);
            this.lblAssetTag.Name = "lblAssetTag";
            this.lblAssetTag.Size = new System.Drawing.Size(121, 29);
            this.lblAssetTag.TabIndex = 81;
            this.lblAssetTag.Text = "Asset Tag";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(368, 336);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(211, 35);
            this.txtSerial.TabIndex = 5;
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.BackColor = System.Drawing.Color.White;
            this.lblSerial.Location = new System.Drawing.Point(216, 344);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(76, 29);
            this.lblSerial.TabIndex = 79;
            this.lblSerial.Text = "Serial";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(384, 72);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 46);
            this.lblTitle.TabIndex = 78;
            this.lblTitle.Text = "Add Asset";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(368, 144);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(211, 37);
            this.cboType.Sorted = true;
            this.cboType.TabIndex = 1;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(216, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 29);
            this.label9.TabIndex = 76;
            this.label9.Text = "Type";
            // 
            // lstPeripherals
            // 
            this.lstPeripherals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPeripherals.CheckOnClick = true;
            this.lstPeripherals.FormattingEnabled = true;
            this.lstPeripherals.Items.AddRange(new object[] {
            "Mouse",
            "Keyboard",
            "Scanner",
            "Camera",
            "Power Supply",
            "Docking Station"});
            this.lstPeripherals.Location = new System.Drawing.Point(656, 216);
            this.lstPeripherals.Name = "lstPeripherals";
            this.lstPeripherals.Size = new System.Drawing.Size(256, 240);
            this.lstPeripherals.TabIndex = 75;
            this.lstPeripherals.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(48, 40);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 29);
            this.lblUsername.TabIndex = 50;
            this.lblUsername.Text = "Username";
            // 
            // cboOS
            // 
            this.cboOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOS.FormattingEnabled = true;
            this.cboOS.Location = new System.Drawing.Point(368, 432);
            this.cboOS.Name = "cboOS";
            this.cboOS.Size = new System.Drawing.Size(211, 37);
            this.cboOS.Sorted = true;
            this.cboOS.TabIndex = 7;
            this.cboOS.Visible = false;
            // 
            // cboModel
            // 
            this.cboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModel.DropDownWidth = 350;
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(368, 240);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(211, 37);
            this.cboModel.Sorted = true;
            this.cboModel.TabIndex = 3;
            // 
            // cboBrand
            // 
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(368, 192);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(211, 37);
            this.cboBrand.Sorted = true;
            this.cboBrand.TabIndex = 2;
            this.cboBrand.SelectedIndexChanged += new System.EventHandler(this.cboBrand_SelectedIndexChanged);
            // 
            // cboLocation
            // 
            this.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Location = new System.Drawing.Point(368, 288);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(211, 37);
            this.cboLocation.Sorted = true;
            this.cboLocation.TabIndex = 4;
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.BackColor = System.Drawing.Color.White;
            this.lblOS.Location = new System.Drawing.Point(216, 440);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(48, 29);
            this.lblOS.TabIndex = 40;
            this.lblOS.Text = "OS";
            this.lblOS.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(72, 584);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(245, 40);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPeripherals
            // 
            this.lblPeripherals.AutoSize = true;
            this.lblPeripherals.BackColor = System.Drawing.Color.White;
            this.lblPeripherals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeripherals.Location = new System.Drawing.Point(688, 176);
            this.lblPeripherals.Name = "lblPeripherals";
            this.lblPeripherals.Size = new System.Drawing.Size(148, 29);
            this.lblPeripherals.TabIndex = 34;
            this.lblPeripherals.Text = "Peripherals";
            this.lblPeripherals.Visible = false;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(216, 200);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(77, 29);
            this.lblBrand.TabIndex = 33;
            this.lblBrand.Text = "Brand";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.White;
            this.lblModel.Location = new System.Drawing.Point(216, 248);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(81, 29);
            this.lblModel.TabIndex = 32;
            this.lblModel.Text = "Model";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(216, 296);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(104, 29);
            this.lblLocation.TabIndex = 31;
            this.lblLocation.Text = "Location";
            // 
            // txtPCID
            // 
            this.txtPCID.Location = new System.Drawing.Point(368, 480);
            this.txtPCID.Name = "txtPCID";
            this.txtPCID.Size = new System.Drawing.Size(211, 35);
            this.txtPCID.TabIndex = 8;
            this.txtPCID.Visible = false;
            // 
            // lblPCID
            // 
            this.lblPCID.AutoSize = true;
            this.lblPCID.BackColor = System.Drawing.Color.White;
            this.lblPCID.Location = new System.Drawing.Point(216, 488);
            this.lblPCID.Name = "lblPCID";
            this.lblPCID.Size = new System.Drawing.Size(69, 29);
            this.lblPCID.TabIndex = 29;
            this.lblPCID.Text = "PCID";
            this.lblPCID.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(608, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // tabPreventiveMaintenance
            // 
            this.tabPreventiveMaintenance.Controls.Add(this.textBox4);
            this.tabPreventiveMaintenance.Controls.Add(this.textBox3);
            this.tabPreventiveMaintenance.Controls.Add(this.textBox2);
            this.tabPreventiveMaintenance.Controls.Add(this.label17);
            this.tabPreventiveMaintenance.Controls.Add(this.button4);
            this.tabPreventiveMaintenance.Controls.Add(this.comboBox9);
            this.tabPreventiveMaintenance.Controls.Add(this.label16);
            this.tabPreventiveMaintenance.Controls.Add(this.label10);
            this.tabPreventiveMaintenance.Controls.Add(this.checkedListBox2);
            this.tabPreventiveMaintenance.Controls.Add(this.checkedListBox1);
            this.tabPreventiveMaintenance.Controls.Add(this.label15);
            this.tabPreventiveMaintenance.Controls.Add(this.comboBox8);
            this.tabPreventiveMaintenance.Controls.Add(this.button3);
            this.tabPreventiveMaintenance.Controls.Add(this.label11);
            this.tabPreventiveMaintenance.Controls.Add(this.label13);
            this.tabPreventiveMaintenance.Controls.Add(this.label14);
            this.tabPreventiveMaintenance.Controls.Add(this.lblUsernameGoal);
            this.tabPreventiveMaintenance.Location = new System.Drawing.Point(4, 38);
            this.tabPreventiveMaintenance.Name = "tabPreventiveMaintenance";
            this.tabPreventiveMaintenance.Size = new System.Drawing.Size(958, 658);
            this.tabPreventiveMaintenance.TabIndex = 2;
            this.tabPreventiveMaintenance.Text = "Preventive Maintenance";
            this.tabPreventiveMaintenance.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(201, 206);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 35);
            this.textBox4.TabIndex = 81;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(62, 383);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(384, 150);
            this.textBox3.TabIndex = 76;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 35);
            this.textBox2.TabIndex = 53;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(64, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(316, 29);
            this.label17.TabIndex = 80;
            this.label17.Text = "Last Checked on 05/16/2016";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(567, 549);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(245, 32);
            this.button4.TabIndex = 79;
            this.button4.Text = "Comment History";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox9
            // 
            this.comboBox9.BackColor = System.Drawing.Color.White;
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "Physical Damage",
            "Software Issue",
            "Other"});
            this.comboBox9.Location = new System.Drawing.Point(179, 337);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(211, 37);
            this.comboBox9.TabIndex = 78;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(57, 337);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 29);
            this.label16.TabIndex = 77;
            this.label16.Text = "Category:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(620, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 29);
            this.label10.TabIndex = 75;
            this.label10.Text = "Printer PM";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Cleaned Printhead",
            "Cleaned Inside of Printer",
            "Printing Quality Validated",
            "Printer Updated on Worksheet",
            "No Printer"});
            this.checkedListBox2.Location = new System.Drawing.Point(538, 383);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(287, 150);
            this.checkedListBox2.TabIndex = 74;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Validated Computer Name",
            "Connected to Celestica Network",
            "McAfee Installed and Updated",
            "Viper Link",
            "Chrome Installed",
            "Working Mouse",
            "Working Keyboard",
            "Working Scanner",
            "Newpass#01 Sticker",
            "PCID Sticker",
            "Cleaned Inside Workstation",
            "Cable Management"});
            this.checkedListBox1.Location = new System.Drawing.Point(538, 80);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(287, 240);
            this.checkedListBox1.TabIndex = 73;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(620, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 29);
            this.label15.TabIndex = 68;
            this.label15.Text = "Activities";
            // 
            // comboBox8
            // 
            this.comboBox8.BackColor = System.Drawing.Color.White;
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "PSU",
            "PCN",
            "Repair",
            "Packout"});
            this.comboBox8.Location = new System.Drawing.Point(200, 145);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(211, 37);
            this.comboBox8.TabIndex = 64;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 549);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 32);
            this.button3.TabIndex = 62;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 29);
            this.label11.TabIndex = 56;
            this.label11.Text = "Ticket Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(23, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 29);
            this.label13.TabIndex = 54;
            this.label13.Text = "Location";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(28, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 29);
            this.label14.TabIndex = 52;
            this.label14.Text = "PCID";
            // 
            // lblUsernameGoal
            // 
            this.lblUsernameGoal.AutoSize = true;
            this.lblUsernameGoal.BackColor = System.Drawing.Color.White;
            this.lblUsernameGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameGoal.Location = new System.Drawing.Point(27, 28);
            this.lblUsernameGoal.Name = "lblUsernameGoal";
            this.lblUsernameGoal.Size = new System.Drawing.Size(472, 29);
            this.lblUsernameGoal.TabIndex = 51;
            this.lblUsernameGoal.Text = "Jose Sandoval, You need 3 more for today.";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 658);
            this.Controls.Add(this.tabMenus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mnuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Celestica IT Inventory and Preventive Maintenance";
            this.tabMenus.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPreventiveMaintenance.ResumeLayout(false);
            this.tabPreventiveMaintenance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MainMenu mnuMain;
        private System.Windows.Forms.MenuItem mnuInventory;
        private System.Windows.Forms.TabPage tabPreventiveMaintenance;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblUsernameGoal;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblPeripherals;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblPCID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TablessControl tabMenus;
        private System.Windows.Forms.MenuItem mnuDatabase;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem mnuCreateUser;
        private System.Windows.Forms.MenuItem mnuEditUser;
        private System.Windows.Forms.MenuItem mnuAdd;
        private System.Windows.Forms.MenuItem mnuParameters;
        private System.Windows.Forms.MenuItem mnuAddParameter;
        private System.Windows.Forms.MenuItem mnuEditParameter;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblAssetTag;
        private System.Windows.Forms.MenuItem mnuView;
        private System.Windows.Forms.Label lblBelongsTo;
        private System.Windows.Forms.MenuItem mnuCheckAssetTag;
        private System.Windows.Forms.MenuItem mnuSearch;
        public System.Windows.Forms.ComboBox cboType;
        public System.Windows.Forms.ComboBox cboOS;
        public System.Windows.Forms.ComboBox cboModel;
        public System.Windows.Forms.ComboBox cboBrand;
        public System.Windows.Forms.ComboBox cboLocation;
        public System.Windows.Forms.TextBox txtPCID;
        public System.Windows.Forms.TextBox txtSerial;
        public System.Windows.Forms.TextBox txtAssetTag;
        public System.Windows.Forms.TextBox txtBelongsTo;
        public System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.CheckedListBox lstPeripherals;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnComment;
        public System.Windows.Forms.Button btnAutoCollect;
        private System.Windows.Forms.MenuItem mnuBulkAdd;
    }
}

