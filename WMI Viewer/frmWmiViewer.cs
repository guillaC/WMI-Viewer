using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WMI_view
{
    public partial class frmWmiViewer : Form
    {
        private Dictionary<String, Dictionary<String, String>> result;

        public frmWmiViewer()
        {
            InitializeComponent();
            result = new Dictionary<String, Dictionary<String, String>>();
            updateLbox();
        }

        private void updateLbox()
        {
            result = WMIGetter.select("SELECT * FROM Meta_Class");
            foreach (String key in result.Keys) lbClasses.Items.Add(key.Substring(key.IndexOf(":") + 1));   
        }

        private void updateLview(String query)
        {
            lvData.Columns.Clear();
            lvData.Items.Clear();
            Cursor = Cursors.WaitCursor;
            result = WMIGetter.select(query);
            if (result.Count == 0)
            {
                Cursor = Cursors.Default;
                return;
            }
            foreach (String column in result[result.ElementAt(0).Key].Keys) lvData.Columns.Add(column);
            foreach (Dictionary<String, String> entry in result.Values)
            {
                ListViewItem lvi = new ListViewItem(entry.Values.ToArray());
                lvData.Items.Add(lvi);
            }
            Cursor = Cursors.Default;
        }

        private void lbClasses_DoubleClick(object sender, EventArgs e)
        {
            if (lbClasses.SelectedItems.Count == 1)
            {
                string query = "SELECT * FROM " + lbClasses.SelectedItems[0].ToString();
                updateLview(query);
                tbQuerry.Text = query;
            }
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            updateLview(tbQuerry.Text);
        }
    }
}
