using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;

namespace ITInventory
{
    public partial class FrmLogin : Form
    {
        User user;
        string localUsername = System.Configuration.ConfigurationManager.AppSettings["localUsername"];
        string localPassword = System.Configuration.ConfigurationManager.AppSettings["localPassword"];
        List<string> sites;
        string domain = "";
        DataTable dataTable = null;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void GetSites()
        {
            sites = ActiveDirectory.ListOU(domain);            
        }
        
        // Executes when the login button is clicked.
        // It connects to the database and checks if the user exists.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bwLogin.RunWorkerAsync();
        }

        private void cboDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void bwSites_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker.CancellationPending == true)
                e.Cancel = true;
            else
                GetSites();                
        }

        private void bwSites_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cboSite.Items.Clear();

            // Adds the sites found in the selected domain to
            // the Site combobox.
            for (int i = 0; i < sites.Count; i++)
                cboSite.Items.Add(sites[i]);

            cboSite.Enabled = true;
            picLoading.Visible = false;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            cboSite.Enabled = false;
            cboSite.Items.Add("Loading...");
            cboSite.SelectedIndex = 0;
            picLoading.Visible = true;

            if(DBConnection.Instance.DoesDatabaseExist())
            {
                cboDomain.SelectedIndex = 0;
                domain = cboDomain.Text;
                bwSites.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("The database does not exist.\n"
                    + "Please log in with the local user.");
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            bwSites.CancelAsync();
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
               && (txtPassword.Text.Equals(localPassword))))
            {
                if (dataTable.Rows.Count != 0)
                {
                    DataRow data = dataTable.Rows[0];

                    // Creates an user object.
                    user = new User(data["username"].ToString(), data["firstName"].ToString(),
                        data["lastName"].ToString(), (bool)data["isAdmin"],
                        (int)data["userID"]);
                }
                else
                    user = new User(txtUsername.Text, localUsername, "Celestica", true, 0);

                // Instantiates the main form.
                MainForm frmAdd = new MainForm();
                frmAdd.user = user;
                frmAdd.lblUsername.Text = user.FirstName + " " + user.LastName;

                if (user.IsAdmin)
                {
                    frmAdd.mnuDatabase.Visible = true;
                    frmAdd.mnuPreventiveMaintenance.Visible = true;
                }

                this.Hide();
                frmAdd.ShowDialog();
                this.Close();
            }
            else
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("ERROR: Wrong username or password.");
            }
        }
    }
}
