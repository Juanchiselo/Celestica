using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;

namespace ITInventory
{
    public partial class FrmLogin : Form
    {
        User user;
        string localUsername = System.Configuration.ConfigurationManager.AppSettings["localUsername"];
        string localPassword = System.Configuration.ConfigurationManager.AppSettings["localPassword"];
        List<string> sites = new List<string>();
        string selectedDomain = "";
        DataTable dataTable = null;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Splits the comma delimited values for the domain key,
            // and saves each entry into the domains array.
            string[] domains = System.Configuration
                .ConfigurationManager.AppSettings["domains"].Split(',');

            // Adds each domain to the domain combobox.
            foreach (string domain in domains)
                cboDomain.Items.Add(domain);

            // Selects the first value for the key.
            cboDomain.SelectedIndex = 0;
            selectedDomain = cboDomain.Text;
        }

        private void cboDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDomain.Enabled = false;
            cboSite.Items.Clear();
            cboSite.Items.Add("Loading...");
            cboSite.SelectedIndex = 0;
            cboSite.Enabled = false;
            picLoading.Visible = true;
            bwSites.RunWorkerAsync();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bwLogin.RunWorkerAsync();
        }
        
        #region Background Workers

        private void bwSites_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {          
            sites = ActiveDirectory.ListOU(selectedDomain);
        }

        private void bwSites_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cboSite.Items.Clear();

            // Adds the sites found in the selected domain to
            // the Site combobox.
            for (int i = 0; i < sites.Count; i++)
                cboSite.Items.Add(sites[i]);

            picLoading.Visible = false;
            cboSite.Enabled = true;
            cboDomain.Enabled = true;
        }

        private void bwLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            dataTable = DBConnection.Instance.Select("SELECT * FROM tbluser "
                    + "WHERE username='" + txtUsername.Text + "';");
        }

        private void bwLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (ActiveDirectory.Instance.Authenticate(txtUsername.Text, txtPassword.Text, cboDomain.Text)
               && dataTable.Rows.Count != 0
               || (txtUsername.Text.Equals(localUsername)
               && txtPassword.Text.Equals(localPassword)))
            {
                if (dataTable.Rows.Count != 0)
                {
                    DataRow data = dataTable.Rows[0];

                    // Creates an user object.
                    user = new User(data["username"].ToString(), data["firstName"].ToString(),
                        data["lastName"].ToString(), (bool)data["isAdmin"], (int)data["userID"]);
                }
                else
                    user = new User(txtUsername.Text, localUsername, "Celestica", true, 0);

                // Instantiates the main form.
                MainForm frmMain = new MainForm();
                frmMain.user = user;
                frmMain.lblUsername.Text = user.FirstName + " " + user.LastName;

                if (user.IsAdmin)
                {
                    frmMain.mnuDatabase.Visible = true;
                    frmMain.mnuPreventiveMaintenance.Visible = true;
                }

                this.Hide();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("ERROR: Wrong username or password.");
            }
        }

        #endregion
    }
}
