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
    public partial class FrmComment : Form
    {
        string comment;

        public FrmComment()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MainForm.comment = txtComment.Text;
            this.Close();
        }
    }
}
