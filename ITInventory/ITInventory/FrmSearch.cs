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
    public partial class FrmSearch : Form
    {
        DataTable dataTable = null;
        string query = "";

        public FrmSearch()
        {
            InitializeComponent();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearchParameter_Click(object sender, EventArgs e)
        {
            query = "SELECT tbllocation.location FROM tblinventory "
                + "LEFT JOIN tbllocation ON tblinventory.locationID = tbllocation.locationID "
                + "WHERE PCID='" + txtParameter.Text + "';";
            
            dataTable = DBConnection.Instance.Select(query);

            if(dataTable.Rows.Count != 0)
            {
                MessageBox.Show("PCID \"" + txtParameter.Text + "\" is located in \""
                + dataTable.Rows[0].Field<string>(0) + "\".");
            }
            else
            {
                MessageBox.Show("PCID \"" + txtParameter.Text + "\" does not exist.");
            }
        }
    }
}
