namespace CryptoBlock
{
    partial class AboutDialog
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
            this.ProgramNameLabel = new System.Windows.Forms.Label();
            this.DescriptionTextArea = new System.Windows.Forms.TextBox();
            this.CreatedByLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.UpdatedLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.SourceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ProgramNameLabel
            // 
            this.ProgramNameLabel.AutoSize = true;
            this.ProgramNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramNameLabel.Location = new System.Drawing.Point(12, 9);
            this.ProgramNameLabel.Name = "ProgramNameLabel";
            this.ProgramNameLabel.Size = new System.Drawing.Size(322, 37);
            this.ProgramNameLabel.TabIndex = 0;
            this.ProgramNameLabel.Text = "CryptoBlock v0.9.5 [DEV]";
            // 
            // DescriptionTextArea
            // 
            this.DescriptionTextArea.BackColor = System.Drawing.Color.White;
            this.DescriptionTextArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionTextArea.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextArea.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.DescriptionTextArea.Location = new System.Drawing.Point(12, 58);
            this.DescriptionTextArea.Multiline = true;
            this.DescriptionTextArea.Name = "DescriptionTextArea";
            this.DescriptionTextArea.ReadOnly = true;
            this.DescriptionTextArea.ShortcutsEnabled = false;
            this.DescriptionTextArea.Size = new System.Drawing.Size(541, 148);
            this.DescriptionTextArea.TabIndex = 1;
            this.DescriptionTextArea.TabStop = false;
            this.DescriptionTextArea.Text = "The ideal text editor to protect important information such as passwords!\r\n\r\nIt u" +
    "ses the SHA256 and AES (Rijndael) encryptions for better security.\r\n\r\n* Developm" +
    "ent version.";
            // 
            // CreatedByLabel
            // 
            this.CreatedByLabel.AutoSize = true;
            this.CreatedByLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedByLabel.Location = new System.Drawing.Point(345, 236);
            this.CreatedByLabel.Name = "CreatedByLabel";
            this.CreatedByLabel.Size = new System.Drawing.Size(208, 21);
            this.CreatedByLabel.TabIndex = 2;
            this.CreatedByLabel.Text = "Created By: Humberto Arana";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(478, 272);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Cerrar";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.OnClose);
            // 
            // UpdatedLabel
            // 
            this.UpdatedLabel.AutoSize = true;
            this.UpdatedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatedLabel.Location = new System.Drawing.Point(8, 271);
            this.UpdatedLabel.Name = "UpdatedLabel";
            this.UpdatedLabel.Size = new System.Drawing.Size(169, 21);
            this.UpdatedLabel.TabIndex = 4;
            this.UpdatedLabel.Text = "Updated: Feb. 15, 2020";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedLabel.Location = new System.Drawing.Point(8, 250);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(162, 21);
            this.CreatedLabel.TabIndex = 5;
            this.CreatedLabel.Text = "Created: Jan. 20, 2013";
            // 
            // SourceLinkLabel
            // 
            this.SourceLinkLabel.AutoSize = true;
            this.SourceLinkLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceLinkLabel.Location = new System.Drawing.Point(345, 272);
            this.SourceLinkLabel.Name = "SourceLinkLabel";
            this.SourceLinkLabel.Size = new System.Drawing.Size(54, 20);
            this.SourceLinkLabel.TabIndex = 6;
            this.SourceLinkLabel.TabStop = true;
            this.SourceLinkLabel.Text = "Source";
            this.SourceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SourceLinkLabelClicked);
            // 
            // AboutDialog
            // 
            this.AcceptButton = this.CloseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 307);
            this.Controls.Add(this.SourceLinkLabel);
            this.Controls.Add(this.CreatedLabel);
            this.Controls.Add(this.UpdatedLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CreatedByLabel);
            this.Controls.Add(this.DescriptionTextArea);
            this.Controls.Add(this.ProgramNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.Text = "Acerca de CryptoBlock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProgramNameLabel;
        private System.Windows.Forms.TextBox DescriptionTextArea;
        private System.Windows.Forms.Label CreatedByLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label UpdatedLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.LinkLabel SourceLinkLabel;
    }
}