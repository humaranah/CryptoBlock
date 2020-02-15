using System;
using System.Windows.Forms;

namespace CryptoBlock
{
    public partial class NewFileDialog : Form
    {
        public NewFileDialog(string title = "", bool isImportPanelVisible = false)
        {
            InitializeComponent();
            Text = title;
            ImportPanel.Visible = isImportPanelVisible;
        }

        private void OnAcceptClicked(object sender, EventArgs e)
        {
            if (PasswordField.Text == "")
            {
                MessageBox.Show("Password can't be empty.");
                return;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void OnShowCharactersClicked(object sender, EventArgs e)
        {
            if (ShowCharactersCheckbox.Checked)
            {
                PasswordField.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordField.UseSystemPasswordChar = true;
            }
        }

        public string Password
        {
            get
            {
                return PasswordField.Text;
            }
        }

        public string Path
        {
            get
            {
                return ImportTextField.Text;
            }
        }

        private void OnImportClicked(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog(this) == DialogResult.OK)
            {
                ImportTextField.Text = openDialog.FileName;
            }
        }
    }
}
