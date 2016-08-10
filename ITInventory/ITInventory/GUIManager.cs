using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ITInventory
{
    class GUIManager
    {
        private static readonly GUIManager instance = new GUIManager();

        public static GUIManager Instance
        {
            get { return instance; }
        }
        
        public void PopulateComboBox(ComboBox comboBox, List<string> items)
        {
            // Deletes all existing items.
            comboBox.Items.Clear();

            // Adds the items to the ComboBox.
            foreach (string item in items)
                comboBox.Items.Add(item);
        }

        public void PopulateComboBox(ComboBox comboBox, DataTable dataTable)
        {
            // Deletes all existing items.
            comboBox.Items.Clear();

            // Adds the items to the ComboBox.
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (!dataTable.Rows[i].Field<string>(0).Equals(""))
                    comboBox.Items.Add(dataTable.Rows[i].Field<string>(0));
            }
        }

        public void StartLoadingComboBox(ComboBox comboBox, 
            PictureBox pictureBox)
        {
            comboBox.Enabled = false;
            comboBox.Items.Clear();
            comboBox.Items.Add("Loading...");
            comboBox.SelectedIndex = 0;
            pictureBox.Visible = true;
        }

        public void StopLoadingComboBox(ComboBox comboBox,
            PictureBox pictureBox)
        {
            pictureBox.Visible = false;
            comboBox.Enabled = true;
        }


    }
}
