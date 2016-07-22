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
    public partial class FrmParameters : Form
    {
        DataTable dataTable = null;
        string query = null;
        string oldParameter = null;
        string parameterType = null;
        int extraParameterID = 0;

        public FrmParameters()
        {
            InitializeComponent();
        }

        private void btnAddParameter_Click(object sender, EventArgs e)
        {
            if(cboExtraParameter.Visible && cboExtraParameter.Text != "")
            {
                if (cboParameterType.Text.Equals("Brand"))
                {
                    query = "SELECT typeID FROM tbltype WHERE type='"
                        + cboExtraParameter.Text + "'";

                    extraParameterID = DBConnection.Instance.Select(query).Rows[0].Field<Int32>(0);

                    query = "INSERT INTO tbl" + cboParameterType.Text.ToLower()
                        + " (" + cboParameterType.Text.ToLower() + ", typeID)"
                        + " VALUES ('" + txtParameter.Text + "', " + extraParameterID + ");";
                }
                else
                {
                    query = "SELECT brandID FROM tblbrand WHERE brand='"
                        + cboExtraParameter.Text + "'";

                    extraParameterID = DBConnection.Instance.Select(query).Rows[0].Field<Int32>(0);

                    query = "INSERT INTO tbl" + cboParameterType.Text.ToLower()
                        + " (" + cboParameterType.Text.ToLower() + ", brandID)"
                        + " VALUES ('" + txtParameter.Text + "', " + extraParameterID + ");";
                }
            }
            else
            {
                query = "INSERT INTO tbl" + cboParameterType.Text.ToLower()
                        + " (" + cboParameterType.Text.ToLower() + ")"
                        + " VALUES ('" + txtParameter.Text + "');";
            }

            if (!txtParameter.Text.Equals("")
                && !cboParameterType.Text.Equals("")
                && ((cboExtraParameter.Visible && !cboExtraParameter.Text.Equals(""))
                || (!cboExtraParameter.Visible && cboExtraParameter.Text.Equals(""))))
            {
                if (DBConnection.Instance.Insert(query))
                {
                    MessageBox.Show("Parameter was added successfully.");
                    this.Close();
                }
                else
                    MessageBox.Show("ERROR: Adding parameter failed.");
            }
            else
                MessageBox.Show("ERROR: Parameter box empty or Parameter Type not selected.");
        }

        private void cboParameterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboParameter.Text = "";
            cboParameter.Items.Clear();
            cboExtraParameter.Items.Clear();

            if (lblParametersTitle.Text.Equals("Edit Parameter"))
            {
                query = "SELECT " + cboParameterType.Text.ToLower() + " FROM "
                    + "tbl" + cboParameterType.Text.ToLower();

                dataTable = DBConnection.Instance.Select(query);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                    cboParameter.Items.Add(dataTable.Rows[i].Field<string>(0));
            }

            parameterType = cboParameterType.Text;

            if(parameterType.Equals("Brand")
                || parameterType.Equals("Model"))
            {
                lblExtraParameter.Visible = true;
                cboExtraParameter.Visible = true;

                if (parameterType.Equals("Brand"))
                {
                    lblExtraParameter.Text = "Type";
                    query = "SELECT type FROM tbltype";
                }
                else
                {
                    lblExtraParameter.Text = "Brand";
                    query = "SELECT brand from tblbrand GROUP BY brand";
                }

                dataTable = DBConnection.Instance.Select(query);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                    cboExtraParameter.Items.Add(dataTable.Rows[i].Field<string>(0));
            }
            else
            {
                lblExtraParameter.Visible = false;
                cboExtraParameter.Visible = false;
            }
        }

        private void btnEditParameter_Click(object sender, EventArgs e)
        {
            oldParameter = cboParameter.Text;
            cboParameter.DropDownStyle = ComboBoxStyle.Simple;
            btnEditParameter.Visible = false;
            btnUpdateParameter.Visible = true;
        }

        private void btnRemoveParameter_Click(object sender, EventArgs e)
        {
            if(cboParameterType.Text != ""
                && cboParameter.Text != "")
            {
                query = "DELETE FROM tbl" + cboParameterType.Text.ToLower()
                    + " WHERE " + cboParameterType.Text.ToLower() + "='"
                    + cboParameter.Text + "';";

                DBConnection.Instance.Delete(query);

                MessageBox.Show("Parameter \"" + cboParameter.Text
                       + "\" was deleted successfully from the \"" + cboParameterType.Text
                       + "\" table.");
                
                this.Close();
            }
        }

        private void btnUpdateParameter_Click(object sender, EventArgs e)
        {
            if (cboParameter.Text != ""
                && cboParameterType.Text != "")
            {
                query = "UPDATE tbl" + cboParameterType.Text.ToLower()
                    + " SET " + cboParameterType.Text.ToLower() + "='"
                    + cboParameter.Text + "' WHERE " + cboParameterType.Text.ToLower() + "='"
                    + oldParameter + "';";

                DBConnection.Instance.Update(query);

                MessageBox.Show("Parameter \"" + oldParameter
                        + "\" was updated successfully to "
                        + "\"" + cboParameter.Text + "\" on the \"" + cboParameterType.Text
                        + "\" table.");
                
                this.Close();
            }
            else
                MessageBox.Show("ERROR: Parameter box empty or Parameter Type not selected.");
        }

        private void FrmParameters_FormClosed(object sender, FormClosedEventArgs e)
        {
            lblParametersTitle.Text = "Add Parameter";
            btnAddParameter.Visible = true;
            btnUpdateParameter.Visible = false;
            btnRemoveParameter.Visible = false;
            btnEditParameter.Visible = false;
            cboParameter.Items.Clear();
            txtParameter.Text = "";
            cboParameterType.SelectedItem = null;
            cboExtraParameter.SelectedItem = null;

            MainForm.RefreshForm();
        }
    }
}
