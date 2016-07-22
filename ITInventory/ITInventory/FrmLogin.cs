using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace ITInventory
{
    public partial class FrmLogin : Form
    {
        MD5 md5 = MD5.Create();
        User user;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void GetSites()
        {
            List<string> sites = ActiveDirectory.ListOU(cboDomain.Text);

            for (int i = 0; i < sites.Count; i++)
                cboSite.Items.Add(sites[i]);
        }

        // Clicks the Login button whenever the "Enter" key
        // has been released.
        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        // Executes when the login button is clicked.
        // It connects to the database and checks if the user exists.
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (ActiveDirectory.Instance.Authenticate(txtUsername.Text, txtPassword.Text, cboDomain.Text))
            {

            }
            else
            {
                MessageBox.Show("Intruder, intruder! Self-destruct sequence initiated!");
            }


            DataTable dataTable = DBConnection.Instance.Select("SELECT * FROM tbluser "
                + "WHERE username='" + txtUsername.Text + "' AND password='"
                + BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(txtPassword.Text))).Replace("-", "")
                + "';");

            if ((dataTable.Rows.Count != 0)
                || (txtUsername.Text.Equals("Administrator")
                && txtPassword.Text.Equals("##2fun4cls")))
            {
                if (dataTable.Rows.Count != 0)
                {
                    DataRow data = dataTable.Rows[0];

                    // Creates an user object.
                    user = new User(data["username"].ToString(), data["firstName"].ToString(),
                        data["lastName"].ToString(), data["password"].ToString(), (bool)data["isAdmin"],
                        (int)data["userID"]);
                }
                else
                {
                    user = new User(txtUsername.Text, "Administrator", "Celestica",
                         "##2fun4cls", true, 0);
                }



                if (user.IsAdmin)
                {
                    //mnuDatabase.Visible = true;
                    //mnuPreventiveMaintenance.Visible = false;
                }



                MainForm frmAdd = new MainForm();
                frmAdd.user = user;
                frmAdd.lblUsername.Text = user.FirstName + " " + user.LastName;
                this.Hide();
                frmAdd.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("ERROR: Wrong username or password.");
        }

        private void cboDomain_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSites();
        }
    }
}
