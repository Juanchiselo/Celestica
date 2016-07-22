using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITInventory
{
    public partial class FrmCheckAssetTag : Form
    {
        private DataTable dataTable = null;

        public FrmCheckAssetTag()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string query = "SELECT assetTag FROM tblinventory WHERE assetTag='"
                + txtAssetTag.Text + "';";

            string message = "";

            dataTable = DBConnection.Instance.Select(query);

            if(dataTable.Rows.Count != 0)
                message = txtAssetTag.Text + " already exists.";
            else
                message = txtAssetTag.Text + " does not exist.";

            MessageBox.Show(message);

            txtAssetTag.Text = "";

            txtAssetTag.Focus();
        }

        private void txtAssetTag_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtAssetTag_Leave(object sender, EventArgs e)
        {
            btnCheck.PerformClick();
        }

        private void txtAssetTag_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCheck.PerformClick();
        }
    }
}
