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
            this.mnuBulkAdd = new System.Windows.Forms.MenuItem();
            this.mnuView = new System.Windows.Forms.MenuItem();
            this.mnuCheckAssetTag = new System.Windows.Forms.MenuItem();
            this.mnuSearch = new System.Windows.Forms.MenuItem();
            this.mnuCreateMasterPalletSheet = new System.Windows.Forms.MenuItem();
            this.mnuDatabase = new System.Windows.Forms.MenuItem();
            this.mnuDatabaseSetUp = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.mnuCreateUser = new System.Windows.Forms.MenuItem();
            this.mnuEditUser = new System.Windows.Forms.MenuItem();
            this.mnuParameters = new System.Windows.Forms.MenuItem();
            this.mnuAddParameter = new System.Windows.Forms.MenuItem();
            this.mnuEditParameter = new System.Windows.Forms.MenuItem();
            this.mnuPreventiveMaintenance = new System.Windows.Forms.MenuItem();
            this.mnuTools = new System.Windows.Forms.MenuItem();
            this.mnuSetAssetTagBIOS = new System.Windows.Forms.MenuItem();
            this.bwBrand = new System.ComponentModel.BackgroundWorker();
            this.bwModel = new System.ComponentModel.BackgroundWorker();
            this.bwAdd = new System.ComponentModel.BackgroundWorker();
            this.tabMenus = new ITInventory.TablessControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.picLoadingModel = new System.Windows.Forms.PictureBox();
            this.picLoadingBrand = new System.Windows.Forms.PictureBox();
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
            this.txtPCIDPM = new System.Windows.Forms.TextBox();
            this.tablessControl1 = new ITInventory.TablessControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboLocationPM = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblUsernameGoal = new System.Windows.Forms.Label();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.tabMenus.SuspendLayout();
            this.tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadingModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadingBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPreventiveMaintenance.SuspendLayout();
            this.tablessControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuInventory,
            this.mnuDatabase,
            this.mnuPreventiveMaintenance,
            this.mnuTools,
            this.mnuAbout});
            // 
            // mnuInventory
            // 
            this.mnuInventory.Index = 0;
            this.mnuInventory.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAdd,
            this.mnuBulkAdd,
            this.mnuView,
            this.mnuCheckAssetTag,
            this.mnuSearch,
            this.mnuCreateMasterPalletSheet});
            this.mnuInventory.Text = "Inventory";
            // 
            // mnuAdd
            // 
            this.mnuAdd.Index = 0;
            this.mnuAdd.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftA;
            this.mnuAdd.Text = "Add Asset";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuBulkAdd
            // 
            this.mnuBulkAdd.Index = 1;
            this.mnuBulkAdd.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftB;
            this.mnuBulkAdd.Text = "Bulk Add";
            this.mnuBulkAdd.Click += new System.EventHandler(this.mnuBulkAdd_Click);
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
            this.mnuSearch.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.mnuSearch.Text = "Search";
            this.mnuSearch.Click += new System.EventHandler(this.mnuSearch_Click);
            // 
            // mnuCreateMasterPalletSheet
            // 
            this.mnuCreateMasterPalletSheet.Index = 5;
            this.mnuCreateMasterPalletSheet.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftM;
            this.mnuCreateMasterPalletSheet.Text = "Create Master Pallet Sheet";
            this.mnuCreateMasterPalletSheet.Click += new System.EventHandler(this.mnuCreateMasterPalletSheet_Click);
            // 
            // mnuDatabase
            // 
            this.mnuDatabase.Index = 1;
            this.mnuDatabase.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuDatabaseSetUp,
            this.menuItem11,
            this.mnuParameters});
            this.mnuDatabase.Text = "Database";
            this.mnuDatabase.Visible = false;
            // 
            // mnuDatabaseSetUp
            // 
            this.mnuDatabaseSetUp.Index = 0;
            this.mnuDatabaseSetUp.Text = "Set Up";
            this.mnuDatabaseSetUp.Click += new System.EventHandler(this.mnuDatabaseSetUp_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 1;
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
            this.mnuParameters.Index = 2;
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
            // mnuPreventiveMaintenance
            // 
            this.mnuPreventiveMaintenance.Index = 2;
            this.mnuPreventiveMaintenance.Text = "Preventive Maintenance";
            this.mnuPreventiveMaintenance.Click += new System.EventHandler(this.mnuPreventiveMaintenance_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.Index = 3;
            this.mnuTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuSetAssetTagBIOS});
            this.mnuTools.Text = "Tools";
            // 
            // mnuSetAssetTagBIOS
            // 
            this.mnuSetAssetTagBIOS.Index = 0;
            this.mnuSetAssetTagBIOS.Text = "Set Asset Tag In BIOS";
            this.mnuSetAssetTagBIOS.Click += new System.EventHandler(this.mnuSetAssetTagBIOS_Click);
            // 
            // bwBrand
            // 
            this.bwBrand.WorkerReportsProgress = true;
            this.bwBrand.WorkerSupportsCancellation = true;
            this.bwBrand.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwBrand_DoWork);
            this.bwBrand.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwBrand_RunWorkerCompleted);
            // 
            // bwModel
            // 
            this.bwModel.WorkerReportsProgress = true;
            this.bwModel.WorkerSupportsCancellation = true;
            this.bwModel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwModel_DoWork);
            this.bwModel.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwModel_RunWorkerCompleted);
            // 
            // bwAdd
            // 
            this.bwAdd.WorkerReportsProgress = true;
            this.bwAdd.WorkerSupportsCancellation = true;
            this.bwAdd.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAdd_DoWork);
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
            this.tabAdd.Controls.Add(this.picLoadingModel);
            this.tabAdd.Controls.Add(this.picLoadingBrand);
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
            // picLoadingModel
            // 
            this.picLoadingModel.BackColor = System.Drawing.Color.Transparent;
            this.picLoadingModel.Image = ((System.Drawing.Image)(resources.GetObject("picLoadingModel.Image")));
            this.picLoadingModel.Location = new System.Drawing.Point(168, 248);
            this.picLoadingModel.Name = "picLoadingModel";
            this.picLoadingModel.Size = new System.Drawing.Size(40, 40);
            this.picLoadingModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoadingModel.TabIndex = 89;
            this.picLoadingModel.TabStop = false;
            this.picLoadingModel.Visible = false;
            // 
            // picLoadingBrand
            // 
            this.picLoadingBrand.BackColor = System.Drawing.Color.Transparent;
            this.picLoadingBrand.Image = ((System.Drawing.Image)(resources.GetObject("picLoadingBrand.Image")));
            this.picLoadingBrand.Location = new System.Drawing.Point(168, 200);
            this.picLoadingBrand.Name = "picLoadingBrand";
            this.picLoadingBrand.Size = new System.Drawing.Size(40, 40);
            this.picLoadingBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoadingBrand.TabIndex = 88;
            this.picLoadingBrand.TabStop = false;
            this.picLoadingBrand.Visible = false;
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
            this.btnAutoCollect.Text = "Auto Collect";
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
            this.tabPreventiveMaintenance.Controls.Add(this.txtPCIDPM);
            this.tabPreventiveMaintenance.Controls.Add(this.tablessControl1);
            this.tabPreventiveMaintenance.Controls.Add(this.textBox4);
            this.tabPreventiveMaintenance.Controls.Add(this.textBox3);
            this.tabPreventiveMaintenance.Controls.Add(this.label17);
            this.tabPreventiveMaintenance.Controls.Add(this.button4);
            this.tabPreventiveMaintenance.Controls.Add(this.cboCategory);
            this.tabPreventiveMaintenance.Controls.Add(this.label16);
            this.tabPreventiveMaintenance.Controls.Add(this.cboLocationPM);
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
            // txtPCIDPM
            // 
            this.txtPCIDPM.Location = new System.Drawing.Point(192, 144);
            this.txtPCIDPM.Name = "txtPCIDPM";
            this.txtPCIDPM.Size = new System.Drawing.Size(211, 35);
            this.txtPCIDPM.TabIndex = 85;
            // 
            // tablessControl1
            // 
            this.tablessControl1.Controls.Add(this.tabPage3);
            this.tablessControl1.Controls.Add(this.tabPage4);
            this.tablessControl1.Location = new System.Drawing.Point(528, 40);
            this.tablessControl1.Name = "tablessControl1";
            this.tablessControl1.SelectedIndex = 0;
            this.tablessControl1.Size = new System.Drawing.Size(376, 536);
            this.tablessControl1.TabIndex = 84;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkedListBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(368, 494);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Desktop Activities";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.checkedListBox1.Location = new System.Drawing.Point(0, 8);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(384, 600);
            this.checkedListBox1.TabIndex = 73;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkedListBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(368, 503);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Printer Activities";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.checkedListBox2.Location = new System.Drawing.Point(0, 8);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(384, 540);
            this.checkedListBox2.TabIndex = 74;
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
            this.button4.Location = new System.Drawing.Point(592, 592);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(245, 48);
            this.button4.TabIndex = 79;
            this.button4.Text = "Comment History";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.Color.White;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(179, 337);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(211, 37);
            this.cboCategory.TabIndex = 78;
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
            // cboLocationPM
            // 
            this.cboLocationPM.BackColor = System.Drawing.Color.White;
            this.cboLocationPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocationPM.FormattingEnabled = true;
            this.cboLocationPM.Location = new System.Drawing.Point(192, 96);
            this.cboLocationPM.Name = "cboLocationPM";
            this.cboLocationPM.Size = new System.Drawing.Size(211, 37);
            this.cboLocationPM.Sorted = true;
            this.cboLocationPM.TabIndex = 64;
            this.cboLocationPM.SelectedIndexChanged += new System.EventHandler(this.cboLocationPM_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 592);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 40);
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
            this.label13.Location = new System.Drawing.Point(24, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 29);
            this.label13.TabIndex = 54;
            this.label13.Text = "Location";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(32, 144);
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
            // mnuAbout
            // 
            this.mnuAbout.Index = 4;
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 654);
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
            ((System.ComponentModel.ISupportInitialize)(this.picLoadingModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadingBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPreventiveMaintenance.ResumeLayout(false);
            this.tabPreventiveMaintenance.PerformLayout();
            this.tablessControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MainMenu mnuMain;
        private System.Windows.Forms.TabPage tabPreventiveMaintenance;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox cboLocationPM;
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
        public System.Windows.Forms.MenuItem mnuInventory;
        public System.Windows.Forms.MenuItem mnuDatabase;
        private System.Windows.Forms.MenuItem mnuDatabaseSetUp;
        public System.Windows.Forms.MenuItem mnuPreventiveMaintenance;
        private System.ComponentModel.BackgroundWorker bwBrand;
        private System.ComponentModel.BackgroundWorker bwModel;
        private System.ComponentModel.BackgroundWorker bwAdd;
        public System.Windows.Forms.PictureBox picLoadingModel;
        public System.Windows.Forms.PictureBox picLoadingBrand;
        private TablessControl tablessControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.MenuItem mnuTools;
        private System.Windows.Forms.MenuItem mnuSetAssetTagBIOS;
        private System.Windows.Forms.TextBox txtPCIDPM;
        private System.Windows.Forms.MenuItem mnuCreateMasterPalletSheet;
        private System.Windows.Forms.MenuItem mnuAbout;
    }
}