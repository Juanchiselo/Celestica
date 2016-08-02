using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ITInventory
{
    public partial class FrmSetAssetTag : Form
    {
        public FrmSetAssetTag()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            switch(cboBrand.Text)
            {
                case "Dell":
                    SetAssetTagDell(txtAssetTag.Text);
                    break;
                case "HP":
                    SetAssetTagHP(txtAssetTag.Text);
                    break;
                case "Lenovo":
                    SetAssetTagLenovo(txtAssetTag.Text);
                    break;
            }

            DialogResult dialogResult = MessageBox.Show("Your computer needs to be restarted for this to take effect \n"
                + "Would you like to restart now?", "Yes or not?", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "/s /t 0");
            }
            else
            {
                MessageBox.Show("Ok but don't blame me if it doesn't work!");
            }
        }

        private void SetAssetTagDell(string assetTag)
        {
            StreamWriter writer = new StreamWriter("cctkcmd.bat");
            writer.WriteLine("@echo off");
            writer.WriteLine("set arch=x86");
            writer.WriteLine("if defined programfiles(x86) (set arch=x86_64)");
            writer.WriteLine("cd \"%0\\..\\%arch%\"".Replace(@"\\", @"\"));
            writer.WriteLine("cctk.exe --asset=" + assetTag);
            writer.WriteLine("del %0");
            writer.Close();

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cctkcmd.bat";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            MessageBox.Show(process.ExitCode.ToString());
        }

        private void SetAssetTagHP(string assetTag)
        {

        }

        private void SetAssetTagLenovo(string assetTag)
        {

        }
    }
}
