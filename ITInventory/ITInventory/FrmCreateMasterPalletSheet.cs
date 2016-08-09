using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITInventory
{
    public partial class FrmCreateMasterPalletSheet : Form
    {
        public FrmCreateMasterPalletSheet()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!txtAssetTag.Text.Equals(""))
            {
                string query = "SELECT assetTag, type, brand, model, serial "
                + "FROM tblInventory "
                + "LEFT JOIN tbltype ON tblinventory.typeID = tbltype.typeID "
                + "LEFT JOIN tblbrand ON tblinventory.brandID = tblbrand.brandID "
                + "LEFT JOIN tblmodel ON tblinventory.modelID = tblmodel.modelID "
                + "WHERE assetTag = '" + txtAssetTag.Text + "';";

                DataTable dataTable = DBConnection.Instance.Select(query);

                if (dataTable.Rows.Count != 0)
                {
                    DataRow dataRow = dataTable.Rows[0];

                    dgdTable.Rows.Add(dataRow["assetTag"], dataRow["type"],
                        dataRow["brand"], dataRow["model"], dataRow["serial"]);
                }
                else
                {
                    MessageBox.Show("Asset tag " + txtAssetTag.Text
                        + " does not exist.");
                }
            }
            else
                MessageBox.Show("ERROR: Asset tag was not entered.");

            txtAssetTag.Text = "";
            txtAssetTag.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgdTable.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dgdTable.SelectedRows)
                    dgdTable.Rows.RemoveAt(row.Index);
            }
            else
                MessageBox.Show("ERROR: No rows are selected.");           
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var stringBuilder = new StringBuilder();

            var headers = dgdTable.Columns.Cast<DataGridViewColumn>();
            stringBuilder.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));
            
            foreach (DataGridViewRow row in dgdTable.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                stringBuilder.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }

            SaveToCSV(stringBuilder);
        }

        private bool SaveToCSV(StringBuilder stringBuilder)
        {
            string filename = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv)|*.csv";
            saveFileDialog.FileName = "Output.csv";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch(IOException exception)
                    {
                        MessageBox.Show("ERROR: " + exception.Message);
                        return false;
                    }
                }
                
                System.IO.File.WriteAllText(saveFileDialog.FileName,
                    stringBuilder.ToString());
            }
            return true;
        }

        private void txtAssetTag_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.PerformClick();
        }
    }
}
