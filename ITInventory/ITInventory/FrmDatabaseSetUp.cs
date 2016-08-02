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
    public partial class FrmDatabaseSetUp : Form
    {
        public FrmDatabaseSetUp()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bwCreateDatabase.RunWorkerAsync();
        }

        private void bwCreateDatabase_DoWork(object sender, DoWorkEventArgs e)
        {
            DBConnection.Instance.CreateDatabase(txtServerName.Text,
                txtDatabaseName.Text, txtUID.Text, txtPassword.Text);           
        }

        private void bwCreateDatabase_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            MessageBox.Show(e.ProgressPercentage.ToString() + "% Completed.");
        }

        private void bwCreateDatabase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Database created sucessfully!");
        }
    }
}
