using CryptoBlock.Models;
using CryptoBlock.Services;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CryptoBlock
{
    public partial class MainWinidow : Form
    {
        private readonly TextViewModel _textViewModel;
        private readonly CryptoFileServiceFacade _cryptoServiceFacade;

        public MainWinidow()
        {
            _cryptoServiceFacade = new CryptoFileServiceFacade(
                new FileService(),
                new ShaCryptoService(),
                new RijndaelCryptoService());
            InitializeComponent();
            _textViewModel = new TextViewModel();
        }

        protected override void OnLoad(EventArgs e)
        {
            TextArea.Font = Properties.Settings.Default.EditorFont;
            WordWrapOption.Checked = Properties.Settings.Default.WordWrap;
            Height = Properties.Settings.Default.Height;
            Width = Properties.Settings.Default.Width;
            base.OnLoad(e);
        }

        private bool Save()
        {
            if (_textViewModel.FileStatus == FileStatus.NotCreated)
            {
                if (saveDialog.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }

                _textViewModel.FilePath = saveDialog.FileName;
            }

            if (_textViewModel.FileStatus == FileStatus.NotCreated || _textViewModel.FileStatus == FileStatus.Modified)
            {
                _cryptoServiceFacade.SaveFile(_textViewModel.FilePath, _textViewModel.FileContent, _textViewModel.Base64Key);
                _textViewModel.FileStatus = FileStatus.Saved;
            }

            return true;
        }

        private bool IsValidState(object sender, EventArgs e)
        {
            if (_textViewModel.FileStatus == FileStatus.NotCreated || _textViewModel.FileStatus == FileStatus.Modified)
            {
                DialogResult result = MessageBox.Show("¿Desea guardar el archivo?",
                    "Archivo sin guardar", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        return Save();
                    case DialogResult.No:
                        return true;
                }

                return false;
            }

            return true;
        }

        private void OnCreateFile(object sender, EventArgs e)
        {
            if (!IsValidState(sender, e))
            {
                return;
            }

            var dialog = new InputDialog("Create file", true)
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _textViewModel.Base64Key = _cryptoServiceFacade.EncryptPassword(dialog.Contraseña);
                TextArea.Enabled = true;

                if (dialog.RutaImportar == "")
                {
                    TextArea.Text = "";
                    ActiveControl = TextArea;
                }
                else
                {
                    TextArea.Lines = _cryptoServiceFacade
                        .ImportFromTextFile(dialog.RutaImportar)
                        .ToArray();
                }

                Name = "new* - " + Constants.ApplicationTitle;
                _textViewModel.FileStatus = FileStatus.NotCreated;
            }
        }

        private void OnOpenFile(object sender, EventArgs e)
        {
            string[] lines;
            InputDialog dialog;

            if (!IsValidState(sender, e))
                return;

            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _textViewModel.FilePath = openDialog.FileName;
                dialog = new InputDialog("Open file");
                dialog.StartPosition = FormStartPosition.CenterParent;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _textViewModel.Base64Key = _cryptoServiceFacade.EncryptPassword(dialog.Contraseña);
                    lines = _cryptoServiceFacade
                        .LoadFile(_textViewModel.FilePath, _textViewModel.Base64Key)
                        .ToArray();

                    if (lines != null)
                        TextArea.Lines = lines;
                    TextArea.Enabled = true;
                    Text = Path.GetFileNameWithoutExtension(openDialog.FileName) + " - " + Constants.ApplicationTitle;
                    _textViewModel.FileStatus = FileStatus.Saved;
                }
            }
        }

        private void OnSaveFile(object sender, EventArgs e)
        {
            Save();
            Text = Path.GetFileNameWithoutExtension(openDialog.FileName) + " - " + Constants.ApplicationTitle;
        }

        private void OnChangePassword(object sender, EventArgs e)
        {
            if (_textViewModel.FileStatus == FileStatus.Null)
            {
                return;
            }
            InputDialog dialog = new InputDialog("New password");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _textViewModel.Base64Key = _cryptoServiceFacade.EncryptPassword(dialog.Contraseña);
                Save();
                MessageBox.Show("Password updated!");
                _textViewModel.FileStatus = FileStatus.Saved;
            }
        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }

        private void OnCopyButtonClick(object sender, EventArgs e)
        {
            SendKeys.Send("^c");
        }

        private void OnCutButtonClick(object sender, EventArgs e)
        {
            SendKeys.Send("^x");
        }

        private void OnPasteButtonClick(object sender, EventArgs e)
        {
            SendKeys.Send("^v");
        }

        private void OnSelectAllButtonClick(object sender, EventArgs e)
        {
            TextArea.SelectAll();
        }

        private void OnFontButtonClick(object sender, EventArgs e)
        {
            if (_textViewModel.FileStatus == FileStatus.Null)
            {
                return;
            }

            fontDialog.Font = TextArea.Font;
            if (fontDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextArea.Font = fontDialog.Font;
                Properties.Settings.Default.EditorFont = TextArea.Font;
                Properties.Settings.Default.Save();
            }
        }

        private void OnViewHelpButtonClick(object sender, EventArgs e)
        {

        }

        private void OnAboutButtonClick(object sender, EventArgs e)
        {
            AboutDialog dialog = new AboutDialog();
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ShowDialog();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (_textViewModel.FileStatus == FileStatus.Saved)
            {
                _textViewModel.FileStatus = FileStatus.Modified;
            }

            Text = Path.GetFileNameWithoutExtension(openDialog.FileName) + "* - " + Constants.ApplicationTitle;
            _textViewModel.FileContent = TextArea.Lines.ToList();
        }

        private void OnWordWrapButtonClick(object sender, EventArgs e)
        {
            WordWrapOption.Checked = !WordWrapOption.Checked;
            Properties.Settings.Default.Save();
        }

        private void OnExportFile(object sender, EventArgs e)
        {
            if (_textViewModel.FileStatus == FileStatus.Null)
            {
                return;
            }
            var dialog = new SaveFileDialog
            {
                Filter = "Archivo de texto|*.txt"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _cryptoServiceFacade.ExportToTextFile(dialog.FileName, TextArea.Lines);
            }
        }

        private void OnCheckWordWrap(object sender, EventArgs e)
        {
            TextArea.WordWrap = WordWrapOption.Checked;
            Properties.Settings.Default.WordWrap = WordWrapOption.Checked;
        }

        private void OnCloseWindow(object sender, FormClosingEventArgs e)
        {
            if (!IsValidState(sender, e))
                e.Cancel = true;
        }

        private void OnResize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.Width = Width;
                Properties.Settings.Default.Height = Height;
                Properties.Settings.Default.Save();
            }
        }
    }
}
