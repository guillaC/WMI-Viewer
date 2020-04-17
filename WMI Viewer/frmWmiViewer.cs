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
            updateLbox();
        }

        private void updateLbox()
        {
            Dictionary<String, Dictionary<String, String>> result = new Dictionary<String, Dictionary<String, String>>();
            result = WMIGetter.select("SELECT * FROM Meta_Class");
            foreach (String key in result.Keys) lbClasses.Items.Add(key.Substring(key.IndexOf(":") + 1));
        }

        private void lvClear()
        {
            lvInstances.Columns.Clear();
            lvInstances.Items.Clear();

            lvProperties.Items.Clear();
            lvMethods.Items.Clear();
        }

        private void updateLViewProperties(string pClass)
        {
            List<List<String>> result = new List<List<String>>();
            result = WMIGetter.getProperties(pClass);
            if (result == null) return;

            foreach (List<String> entry in result)
            {
                lvProperties.Items.Add(new ListViewItem(entry.ToArray()));
            }
        }

        private void updateLViewMethods(string pClass)
        {
            List<List<String>> result = new List<List<String>>();
            result = WMIGetter.getMethods(pClass);
            if (result == null) return;

            foreach (List<String> entry in result)
            {
                lvMethods.Items.Add(new ListViewItem(entry.ToArray()));
            }
        }

        private void updateLViewInstances(String query)
        {
            Cursor = Cursors.WaitCursor;
            result = WMIGetter.select(query);
            if (result.Count == 0)
            {
                Cursor = Cursors.Default;
                return;
            }
<<<<<<< HEAD
            foreach (String column in result[result.ElementAt(0).Key].Keys) lvInstances.Columns.Add(column);
=======
            foreach (String column in result[result.ElementAt(0).Key].Keys) lvData.Columns.Add(column);
>>>>>>> 665ab9995c3d308e5e9ab63280a992ac8e73824b
            foreach (Dictionary<String, String> entry in result.Values)
            {
                ListViewItem lvi = new ListViewItem(entry.Values.ToArray());
                lvInstances.Items.Add(lvi);
            }
            Cursor = Cursors.Default;
        }

        private void lbClasses_DoubleClick(object sender, EventArgs e)
        {
            if (lbClasses.SelectedItems.Count == 1)
            {
                string pClass = lbClasses.SelectedItems[0].ToString();
                string query = "SELECT * FROM " + pClass;

                lvClear();

                updateLViewInstances(query);
                updateLViewProperties(pClass);
                updateLViewMethods(pClass);
                
                tbQuerry.Text = query;
            }
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            updateLViewInstances(tbQuerry.Text);
        }

        private void lvProperties_DoubleClick(object sender, EventArgs e)
        {
            if (lvProperties.SelectedItems.Count == 1 && lvProperties.SelectedItems[0].SubItems.Count == 4)
            {
                    frmDescription frmDescription = new frmDescription(lvProperties.SelectedItems[0].Text, lvProperties.SelectedItems[0].SubItems[3].Text);
                    frmDescription.ShowDialog();
            }
        }

        private void lvMethods_DoubleClick(object sender, EventArgs e)
        {
            if (lvMethods.SelectedItems.Count == 1 && lvMethods.SelectedItems[0].SubItems.Count == 2)
            {
                frmDescription frmDescription = new frmDescription(lvMethods.SelectedItems[0].Text, lvMethods.SelectedItems[0].SubItems[1].Text);
                frmDescription.ShowDialog();
            }
        }
    }
}
