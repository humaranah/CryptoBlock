using System;
using System.Windows.Forms;

namespace CryptoBlock
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void OnClose(object sender, EventArgs e) => Close();

        private void SourceLinkLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SourceLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/humaranah/CryptoBlock");
        }
    }
}
