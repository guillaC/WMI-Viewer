using System;
using System.Windows.Forms;

namespace WMI_view
{
    public partial class frmDescription : Form
    {
        public frmDescription(String item, String description)
        {
            InitializeComponent();
            this.Text = "Description: " + item;
            this.textBoxDescription.Text = description;
        }
    }
}
