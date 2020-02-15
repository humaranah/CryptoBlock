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
            if (string.IsNullOrEmpty(PasswordField.Text))
            {
                MessageBox.Show("Password can't be empty.");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void OnShowCharactersClicked(object sender, EventArgs e)
        {
            PasswordField.UseSystemPasswordChar = !ShowCharactersCheckbox.Checked;
        }

        public string Password => PasswordField.Text;

        public string Path => ImportTextField.Text;

        private void OnImportClicked(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog(this) == DialogResult.OK)
            {
                ImportTextField.Text = openDialog.FileName;
            }
        }
    }
}
