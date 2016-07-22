using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITInventory
{
    public partial class FrmViewDatabase : Form
    {
        public FrmViewDatabase()
        {
            InitializeComponent();
        }

        private void FrmViewDatabase_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBConnection.Instance.ViewTable("tblinventory");

            dataGridView1.RowHeadersWidth = 70;

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.CurrentCell != null
                && dataGridView1.CurrentCell.Value.ToString().Equals("Edit"))
            {
                Item inventoryItem = new Item();
                MainForm.InventoryItem = inventoryItem;
                this.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;

            Item item = new Item();

            string query = "SELECT *, "
                + "CONCAT(tbluser.firstName, ' ', tbluser.lastName) AS name FROM tblinventory "
                + "LEFT JOIN tbltype ON tblinventory.typeID = tbltype.typeID "
                + "LEFT JOIN tblbrand ON tblinventory.brandID = tblbrand.brandID "
                + "LEFT JOIN tblmodel ON tblinventory.modelID = tblmodel.modelID "
                + "LEFT JOIN tbllocation ON tblinventory.locationID = tbllocation.locationID "
                + "LEFT JOIN tbluser ON tblinventory.userID = tbluser.userID "
                + "LEFT JOIN tblos ON tblinventory.osID = tblos.osID "
                + "WHERE assetTag = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "';";

            DataTable dataTable = DBConnection.Instance.Select(query);
            bool[] peripherals = new bool[6];

            foreach(DataRow row in dataTable.Rows)
            {
                item.AssetTag = row["assetTag"].ToString();
                item.Serial = row["serial"].ToString();
                item.PCID = row["pcid"].ToString();
                item.Type = row["type"].ToString();
                item.Brand = row["brand"].ToString();
                item.Model = row["model"].ToString();
                item.Location = row["location"].ToString();
                item.Comment = row["comment"].ToString();
                item.BelongsTo = row["belongsTo"].ToString();
                item.User = row["name"].ToString();
                item.OS = row["os"].ToString();
                peripherals[0] = (bool) row["hasMouse"];
                peripherals[1] = (bool)row["hasKeyboard"];
                peripherals[2] = (bool)row["hasScanner"];
                peripherals[3] = (bool)row["hasCamera"];
                peripherals[4] = (bool)row["hasPSU"];
                peripherals[5] = (bool)row["hasDockingStation"];
            }

            item.peripherals = peripherals;
            
            mainForm.lblTitle.Text = "Edit Asset";
            mainForm.txtAssetTag.Text = item.AssetTag;
            mainForm.txtSerial.Text = item.Serial;
            mainForm.txtBelongsTo.Text = item.BelongsTo;
            mainForm.txtPCID.Text = item.PCID;
            mainForm.cboType.SelectedIndex = mainForm.cboType.FindStringExact(item.Type);
            mainForm.cboLocation.SelectedIndex = mainForm.cboLocation.FindStringExact(item.Location);
            mainForm.cboOS.SelectedIndex = mainForm.cboOS.FindStringExact(item.OS);
            mainForm.cboBrand.SelectedIndex = mainForm.cboBrand.FindStringExact(item.Brand);
            mainForm.cboModel.SelectedIndex = mainForm.cboModel.FindStringExact(item.Model);
            
            for(int i = 0; i < peripherals.Length; i++)
            {
                mainForm.lstPeripherals.SetItemChecked(i, item.peripherals[i]);
            }

            mainForm.oldAssetTag = item.AssetTag;

            mainForm.btnAdd.Visible = false;
            mainForm.btnClear.Visible = false;
            mainForm.btnUpdate.Visible = true;
            this.Close();
        }
    }
}
