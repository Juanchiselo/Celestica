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
        MD5 md5 = MD5.Create();
        User user;
        string localUsername = "administrator";
        string localPassword = "##2fun4cls";
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
            for (int i = 0; i < sites.Count; i++)
                cboSite.Items.Add(sites[i]);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
            cboDomain.SelectedIndex = 0;
            domain = cboDomain.Text;
            bwSites.RunWorkerAsync();
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
            //ActiveDirectory.Instance.GetUserInformation(txtUsername.Text, cboDomain.Text, cboSite.Text);

            if (ActiveDirectory.Instance.Authenticate(txtUsername.Text, txtPassword.Text, cboDomain.Text)
               || dataTable.Rows.Count != 0
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
                {
                    user = new User(txtUsername.Text, localUsername, "Celestica", true, 0);
                }

                MainForm frmAdd = new MainForm();
                frmAdd.user = user;
                frmAdd.lblUsername.Text = user.FirstName + " " + user.LastName;

                if (user.IsAdmin)
                {
                    frmAdd.mnuDatabase.Visible = true;
                    //frmAdd.mnuPreventiveMaintenance.Visible = false;
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
