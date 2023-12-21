using System;
using System.Windows.Forms;

namespace ArticTimer
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
