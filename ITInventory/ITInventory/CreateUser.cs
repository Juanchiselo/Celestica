using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ITInventory
{
    public partial class frmUsers : Form
    {
        MD5 md5 = MD5.Create();
        DataTable table = null;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if(txtFirstName.Text != "" && txtLastName.Text != ""
                && txtPassword.Text !="" && txtUsername.Text != "")
            {
                string query = "INSERT INTO tbluser (username, password, "
                + "isAdmin, firstName, lastName) VALUES ('" + txtUsername.Text
                + "', '"
                + BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(txtPassword.Text)))
                .Replace("-", "") + "', " + chkIsAdmin.Checked + ", '" + txtFirstName.Text
                + "', '" + txtLastName.Text + "')";

                DBConnection.Instance.Insert(query);

                MessageBox.Show("User created successfully!", "User success");

                this.Close();
            }
            else
            {
                MessageBox.Show("A field was left empty.");
            }
        }

        private void cboCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Resets the cboResulsts.
            cboResults.Text = "";
            cboResults.Items.Clear();

            if (cboCriteria.Text.Equals("Username"))
                table = DBConnection.Instance.Select("SELECT username FROM tbluser;");
            if (cboCriteria.Text.Equals("Name"))
                table = DBConnection.Instance.Select("SELECT CONCAT(firstName, ' ', lastName) FROM tbluser;");

            for (int i = 0; i < table.Rows.Count; i++)
                cboResults.Items.Add(table.Rows[i].Field<string>(0));
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            string criteria = null;
            string result = null;

            if (cboCriteria.Text.Equals("Username"))
            {
                criteria = "username";
                result = cboResults.Text;
            }
            if (cboCriteria.Text.Equals("Name"))
            {
                criteria = "";
            }

            //connection.Select("SELECT * FROM tbluser WHERE ");

            lblUsersTitle.Text = "Edit User";
            btnCreate.Visible = false;
            btnUpdateUser.Visible = true;
            btnDeleteUser.Visible = true;

            tabUsers.SelectedTab = tabCreateUser;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {

        }
    }
}
