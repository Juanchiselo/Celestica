using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace ITInventory
{
    public partial class MainForm : Form
    {
        DataTable dataTable = null;
        public User user = null;
        public string oldAssetTag = "";
        string query = null;
        private static MainForm instance;
        public static string comment = "";
        bool autoFilling = false;
        public Item item = null;
        private static Item inventoryItem = null;
        private bool bulkAdd = false;

        FrmParameters frmParameters = new FrmParameters();

        internal static Item InventoryItem
        {
            get{ return inventoryItem;}
            set{ inventoryItem = value;}
        }

        public MainForm()
        {
            InitializeComponent();
            instance = this;
            PopulateOptions();
            
        }
        
        private void mnuPreventiveMaintenance_Click(object sender, EventArgs e)
        {
            lblUsernameGoal.Text = lblUsername.Text + ", you need 3 more done for today.";
            tabMenus.SelectedTab = tabPreventiveMaintenance;
        }

        private void mnuRemoveStation_Click(object sender, EventArgs e)
        {
            Console.Write("Remove station clicked");

            FrmParameters frmRemoveStation = new FrmParameters();
            frmRemoveStation.ShowDialog();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            frmCommentHistory frmComment = new frmCommentHistory();
            frmComment.ShowDialog();
        }

        private void mnuCreateUser_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers();
            frmUsers.ShowDialog();
        }

        private void mnuEditUser_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers();
            TablessControl tabUsers = null;

            foreach (Control control in frmUsers.Controls)
            {
                if(control is TablessControl)
                {
                    tabUsers = (TablessControl) control;
                }
            }


            tabUsers.SelectedTab = tabUsers.TabPages["tabSearchUser"];
            frmUsers.ShowDialog();
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Add Asset";
            btnUpdate.Visible = false;
            btnAdd.Visible = true;
            btnClear.Visible = true;
            bulkAdd = false;
            btnClear.PerformClick();
        }

        private void mnuAddParameter_Click(object sender, EventArgs e)
        {
            frmParameters.ShowDialog();
        }

        private void mnuRemoveParameter_Click(object sender, EventArgs e)
        {
            ComboBox cboParameter = null;

            foreach (Control control in frmParameters.Controls)
            {
                if (control.Name.Equals("lblParametersTitle"))
                    control.Text = "Edit Parameter";

                if (control.Name.Equals("btnAddParameter"))
                    control.Visible = false;

                if (control.Name.Equals("btnEditParameter"))
                    control.Visible = true;

                if (control.Name.Equals("btnRemoveParameter"))
                    control.Visible = true;

                if (control.Name.Equals("cboParameter"))
                {
                    cboParameter = (ComboBox)control;
                    cboParameter.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            
            frmParameters.ShowDialog();
        }

        public static void RefreshForm()
        {
            instance.UnpopulateOptions();
            instance.PopulateOptions();
        }

        public void PopulateOptions()
        {
            query = "SELECT type FROM tbltype";

            dataTable = DBConnection.Instance.Select(query);

            for (int i = 0; i < dataTable.Rows.Count; i++)
                cboType.Items.Add(dataTable.Rows[i].Field<string>(0));

            
            query = "SELECT location FROM tbllocation";

            dataTable = DBConnection.Instance.Select(query);

            for (int i = 0; i < dataTable.Rows.Count; i++)
                cboLocation.Items.Add(dataTable.Rows[i].Field<string>(0));

            query = "SELECT os FROM tblos";

            dataTable = DBConnection.Instance.Select(query);

            for (int i = 0; i < dataTable.Rows.Count; i++)
                cboOS.Items.Add(dataTable.Rows[i].Field<string>(0));
        }

        private void UnpopulateOptions()
        {
            cboType.Items.Clear();
            cboBrand.Items.Clear();
            cboModel.Items.Clear();
            cboLocation.Items.Clear();
            cboOS.Items.Clear();
            comment = "";
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBrand.SelectedItem = null;
            cboLocation.SelectedItem = null;
            cboModel.SelectedItem = null;
            cboOS.SelectedItem = null;
            cboBrand.Items.Clear();
            cboModel.Items.Clear();
           
            if (cboType.Text.Equals("Laptop")
                || cboType.Text.Equals("Desktop")
                || cboType.Text.Equals("Tablet")
                || cboType.Text.Equals("Stick"))
            {
                lblOS.Visible = true;
                cboOS.Visible = true;
                lblPCID.Visible = true;
                txtPCID.Visible = true;
                lblPeripherals.Visible = true;
                lstPeripherals.Visible = true;
                btnAutoCollect.Visible = true;

                if(cboType.Text.Equals("Laptop"))
                {
                    lblBelongsTo.Visible = true;
                    txtBelongsTo.Visible = true;
                }
                else
                {
                    lblBelongsTo.Visible = false;
                    txtBelongsTo.Visible = false;
                }
            }
            else
            {
                lblOS.Visible = false;
                cboOS.Visible = false;
                lblPCID.Visible = false;
                txtPCID.Visible = false;
                lblPeripherals.Visible = false;
                lstPeripherals.Visible = false;
                lblBelongsTo.Visible = false;
                txtBelongsTo.Visible = false;
                btnAutoCollect.Visible = false;
            }

            if (autoFilling)
                return;

            if(!cboType.Text.Equals(""))
            {
                query = "SELECT typeID FROM tbltype WHERE type='" + cboType.Text + "'";
                int typeID = DBConnection.Instance.Select(query).Rows[0].Field<Int32>(0);


                query = "SELECT brand FROM tblbrand WHERE typeID='" + typeID + "'";
                dataTable = DBConnection.Instance.Select(query);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                    cboBrand.Items.Add(dataTable.Rows[i].Field<string>(0));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            query = "SELECT typeID FROM tbltype WHERE type='" + cboType.Text + "';";

            dataTable = DBConnection.Instance.Select(query);
            
            int typeID = dataTable.Rows[0].Field<Int32>(0);


            query = "SELECT brandID FROM tblbrand WHERE brand='" + cboBrand.Text + "';";

            dataTable = DBConnection.Instance.Select(query);

            int brandID = dataTable.Rows[0].Field<Int32>(0);


            query = "SELECT modelID FROM tblmodel WHERE model='" + cboModel.Text + "';";

            dataTable = DBConnection.Instance.Select(query);

            int modelID = dataTable.Rows[0].Field<Int32>(0);


            query = "SELECT locationID FROM tbllocation WHERE location='" + cboLocation.Text + "';";

            dataTable = DBConnection.Instance.Select(query);

            int locationID = dataTable.Rows[0].Field<Int32>(0);

            query = "SELECT userID FROM tbluser WHERE username='" + user.Username + "';";

            dataTable = DBConnection.Instance.Select(query);

            int userID = dataTable.Rows[0].Field<Int32>(0);

            if (cboType.Text.Equals("Laptop")
                || cboType.Text.Equals("Desktop")
                || cboType.Text.Equals("Tablet"))
            {
                query = "SELECT osID FROM tblos WHERE os='" + cboOS.Text + "';";

                bool hasMouse = false;
                bool hasKeyboard = false;
                bool hasScanner = false;
                bool hasCamera = false;
                bool hasPSU = false;
                bool hasDockingStation = false;

                dataTable = DBConnection.Instance.Select(query);

                int osID = dataTable.Rows[0].Field<Int32>(0);

                for (int i = 0; i < lstPeripherals.Items.Count; i++)
                {
                    if (lstPeripherals.GetItemCheckState(i) == CheckState.Checked)
                    {
                        switch (lstPeripherals.Items[i].ToString())
                        {
                            case "Mouse":
                                hasMouse = true;
                                break;
                            case "Keyboard":
                                hasKeyboard = true;
                                break;
                            case "Scanner":
                                hasScanner = true;
                                break;
                            case "Camera":
                                hasCamera = true;
                                break;
                            case "Power Supply":
                                hasPSU = true;
                                break;
                            case "Docking Station":
                                hasDockingStation = true;
                                break;
                            default:
                                break;
                        }
                    }
                }

                query = "INSERT INTO tblinventory (typeID, brandID, modelID, locationID, "
                    + "serial, osID, PCID, userID, assetTag, hasMouse, hasKeyboard, hasScanner, hasCamera, hasPSU, "
                    + "hasDockingStation, comment, belongsTo) VALUES(" + typeID + ", " + brandID
                    + ", " + modelID + ", " + locationID + ", '" + txtSerial.Text
                    + "', " + osID + ", '" + txtPCID.Text + "', " + userID + ", '" + txtAssetTag.Text
                    + "', " + hasMouse + ", " + hasKeyboard + ", " + hasScanner + ", " + hasCamera
                    + ", " + hasPSU + ", " + hasDockingStation + ", '" + comment + "', '" + txtBelongsTo.Text + "');";
            }
            else
            {
                query = "INSERT INTO tblinventory (typeID, brandID, modelID, locationID, "
                    + "serial, userID, assetTag, comment) VALUES(" + typeID + ", " + brandID
                    + ", " + modelID + ", " + locationID + ", '" + txtSerial.Text
                    + "'," + userID + ", '" + txtAssetTag.Text + "', '" + comment + "');";
            }

            if (DBConnection.Instance.Insert(query))
                MessageBox.Show("Asset was added successfully.");
            else
                MessageBox.Show("ERROR: Adding asset failed.");

            if (!bulkAdd)
            {
                btnClear.PerformClick();
                MainForm.RefreshForm();
            }
            else
            {
                txtSerial.Clear();
                txtAssetTag.Clear();
                txtSerial.Focus();
            }
                        
            autoFilling = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboType.SelectedItem = null;
            cboBrand.SelectedItem = null;
            cboLocation.SelectedItem = null;
            cboModel.SelectedItem = null;
            cboOS.SelectedItem = null;
            txtAssetTag.Text = "";
            txtPCID.Text = "";
            txtSerial.Text = "";
            txtBelongsTo.Text = "";

            foreach (int i in lstPeripherals.CheckedIndices)
                lstPeripherals.SetItemCheckState(i, CheckState.Unchecked);
        }

        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboModel.Items.Clear();

            if (autoFilling)
                return;

            if (!cboBrand.Text.Equals(""))
            {
                query = "SELECT brandID FROM tblbrand WHERE brand='" + cboBrand.Text + "'";
                int brandID = DBConnection.Instance.Select(query).Rows[0].Field<Int32>(0);


                query = "SELECT model FROM tblmodel WHERE brandID='" + brandID + "'";
                dataTable = DBConnection.Instance.Select(query);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                    cboModel.Items.Add(dataTable.Rows[i].Field<string>(0));
            }
        }

        private void mnuView_Click(object sender, EventArgs e)
        {
            FrmViewDatabase frmViewDatabase = new FrmViewDatabase();
            frmViewDatabase.ShowDialog(this);
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            FrmComment frmComment = new FrmComment();
            frmComment.ShowDialog();
        }

        private void btnAutoCollect_Click(object sender, EventArgs e)
        {
            //autoFilling = true;

            txtPCID.Text = Environment.MachineName;

            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("SELECT * FROM Win32_Computersystem");

            //foreach (ManagementObject process in searcher.Get())
            //{
            //    process.Get();
            //    cboBrand.Items.Insert(0, (string)process["Manufacturer"]);
            //    cboBrand.SelectedIndex = 0;
            //    cboModel.Items.Insert(0, (string)process["Model"]);
            //    cboModel.SelectedIndex = 0;
            //}

            searcher =
                new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");

            foreach (ManagementObject process in searcher.Get())
            {
                process.Get();
                txtSerial.Text = (string)process["SerialNumber"];
            }

            //searcher =
            //    new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");

            //foreach (ManagementObject process in searcher.Get())
            //{
            //    process.Get();
            //    cboOS.Items.Insert(0, (string)process["Caption"]);
            //    cboOS.SelectedIndex = 0;
            //}
        }

        private void mnuCheckAssetTag_Click(object sender, EventArgs e)
        {
            FrmCheckAssetTag frmCheckAssetTag = new FrmCheckAssetTag();
            frmCheckAssetTag.ShowDialog();
        }
       
        private void mnuSearch_Click(object sender, EventArgs e)
        {
            FrmSearch frmSearch = new FrmSearch();
            frmSearch.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool hasMouse = false;
            bool hasKeyboard = false;
            bool hasScanner = false;
            bool hasCamera = false;
            bool hasPSU = false;
            bool hasDockingStation = false;

            for (int i = 0; i < lstPeripherals.Items.Count; i++)
            {
                if (lstPeripherals.GetItemCheckState(i) == CheckState.Checked)
                {
                    switch (lstPeripherals.Items[i].ToString())
                    {
                        case "Mouse":
                            hasMouse = true;
                            break;
                        case "Keyboard":
                            hasKeyboard = true;
                            break;
                        case "Scanner":
                            hasScanner = true;
                            break;
                        case "Camera":
                            hasCamera = true;
                            break;
                        case "Power Supply":
                            hasPSU = true;
                            break;
                        case "Docking Station":
                            hasDockingStation = true;
                            break;
                        default:
                            break;
                    }
                }
            }
            query = "UPDATE tblinventory "
                + "SET typeID = (SELECT typeID FROM tblType WHERE type = '" + cboType.Text + "'), "
                + "brandID = (SELECT brandID FROM tblBrand WHERE brand = '" + cboBrand.Text + "' "
                + "AND typeID = (SELECT typeID FROM tblType WHERE type = '" + cboType.Text + "')), "
                + "modelID = (SELECT modelID FROM tblModel WHERE model = '" + cboModel.Text + "'), "
                + "locationID = (SELECT locationID FROM tbllocation WHERE location = '" + cboLocation.Text + "'), "
                + "serial = '" + txtSerial.Text + "', "
                + "assetTag = '" + txtAssetTag.Text + "', "
                + "osID = (SELECT osID FROM tblOS WHERE os = '" + cboOS.Text + "'), "
                + "pcid = '" + txtPCID.Text + "', "
                + "belongsTo = '" + txtBelongsTo.Text + "', "
                + "hasMouse = " + hasMouse + ", "
                + "hasKeyboard = " + hasKeyboard + ", "
                + "hasScanner = " + hasScanner + ", "
                + "hasCamera = " + hasCamera + ", "
                + "hasPSU = " + hasPSU + ", "
                + "hasDockingStation = " + hasDockingStation + ", "
                + "lastEditedBy = " + user.ID + " "
                + "WHERE assetTag = '" + oldAssetTag + "';";
            
            if (DBConnection.Instance.Update(query))
                MessageBox.Show("Asset was updated successfully.");
            else
                MessageBox.Show("ERROR: Updating asset failed.");
        }

        private void mnuBulkAdd_Click(object sender, EventArgs e)
        {
            bulkAdd = true;
            lblTitle.Text = "Bulk Add";
        }

        private void mnuDatabaseSetUp_Click(object sender, EventArgs e)
        {
            FrmDatabaseSetUp frmDatabaseSetUp = new FrmDatabaseSetUp();
            frmDatabaseSetUp.ShowDialog();
        }
    }

    public class TablessControl : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }
    }




}
