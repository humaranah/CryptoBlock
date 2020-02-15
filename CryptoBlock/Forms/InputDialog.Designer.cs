namespace CryptoBlock
{
    partial class NewFileDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.DialogCancelButton = new System.Windows.Forms.Button();
            this.DialogAcceptButton = new System.Windows.Forms.Button();
            this.ShowCharactersCheckbox = new System.Windows.Forms.CheckBox();
            this.ImportPanel = new System.Windows.Forms.Panel();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ImportTextField = new System.Windows.Forms.TextBox();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 15);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordField
            // 
            this.PasswordField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordField.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.Location = new System.Drawing.Point(82, 12);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(235, 23);
            this.PasswordField.TabIndex = 1;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // DialogCancelButton
            // 
            this.DialogCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DialogCancelButton.Location = new System.Drawing.Point(242, 106);
            this.DialogCancelButton.Name = "DialogCancelButton";
            this.DialogCancelButton.Size = new System.Drawing.Size(75, 23);
            this.DialogCancelButton.TabIndex = 2;
            this.DialogCancelButton.Text = "Cancel";
            this.DialogCancelButton.UseVisualStyleBackColor = true;
            // 
            // DialogAcceptButton
            // 
            this.DialogAcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DialogAcceptButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DialogAcceptButton.Location = new System.Drawing.Point(161, 106);
            this.DialogAcceptButton.Name = "DialogAcceptButton";
            this.DialogAcceptButton.Size = new System.Drawing.Size(75, 23);
            this.DialogAcceptButton.TabIndex = 3;
            this.DialogAcceptButton.Text = "Create";
            this.DialogAcceptButton.UseVisualStyleBackColor = true;
            this.DialogAcceptButton.Click += new System.EventHandler(this.OnAcceptClicked);
            // 
            // ShowCharactersCheckbox
            // 
            this.ShowCharactersCheckbox.AutoSize = true;
            this.ShowCharactersCheckbox.Location = new System.Drawing.Point(203, 38);
            this.ShowCharactersCheckbox.Name = "ShowCharactersCheckbox";
            this.ShowCharactersCheckbox.Size = new System.Drawing.Size(107, 17);
            this.ShowCharactersCheckbox.TabIndex = 4;
            this.ShowCharactersCheckbox.Text = "Show Characters";
            this.ShowCharactersCheckbox.UseVisualStyleBackColor = true;
            this.ShowCharactersCheckbox.CheckedChanged += new System.EventHandler(this.OnShowCharactersClicked);
            // 
            // ImportPanel
            // 
            this.ImportPanel.Controls.Add(this.ImportButton);
            this.ImportPanel.Controls.Add(this.ImportTextField);
            this.ImportPanel.Location = new System.Drawing.Point(15, 61);
            this.ImportPanel.Name = "ImportPanel";
            this.ImportPanel.Size = new System.Drawing.Size(302, 29);
            this.ImportPanel.TabIndex = 5;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(224, 3);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(75, 23);
            this.ImportButton.TabIndex = 1;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.OnImportClicked);
            // 
            // ImportTextField
            // 
            this.ImportTextField.Location = new System.Drawing.Point(3, 5);
            this.ImportTextField.Name = "ImportTextField";
            this.ImportTextField.ReadOnly = true;
            this.ImportTextField.Size = new System.Drawing.Size(215, 20);
            this.ImportTextField.TabIndex = 0;
            // 
            // openDialog
            // 
            this.openDialog.DefaultExt = "txt";
            this.openDialog.Filter = "Archivos de texto|*.txt";
            // 
            // NewFileDialog
            // 
            this.AcceptButton = this.DialogAcceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
            this.ClientSize = new System.Drawing.Size(329, 141);
            this.ControlBox = false;
            this.Controls.Add(this.ImportPanel);
            this.Controls.Add(this.ShowCharactersCheckbox);
            this.Controls.Add(this.DialogAcceptButton);
            this.Controls.Add(this.DialogCancelButton);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.PasswordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewFileDialog";
            this.Text = "Create new file";
            this.ImportPanel.ResumeLayout(false);
            this.ImportPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button DialogCancelButton;
        private System.Windows.Forms.Button DialogAcceptButton;
        private System.Windows.Forms.CheckBox ShowCharactersCheckbox;
        private System.Windows.Forms.Panel ImportPanel;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox ImportTextField;
    }
}