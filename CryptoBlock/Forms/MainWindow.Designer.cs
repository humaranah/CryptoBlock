namespace CryptoBlock
{
    partial class MainWinidow
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWinidow));
            this.MainMenuBar = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMenuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportMenuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ChangePasswordMenuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyMenuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.CutMenuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllMenuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WordWrapMenuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.FontMenuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewHelpMenuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.TextArea = new System.Windows.Forms.TextBox();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.MainMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuBar
            // 
            this.MainMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu,
            this.FormatMenu,
            this.HelpMenu});
            this.MainMenuBar.Location = new System.Drawing.Point(0, 0);
            this.MainMenuBar.Name = "MainMenuBar";
            this.MainMenuBar.Size = new System.Drawing.Size(694, 24);
            this.MainMenuBar.TabIndex = 0;
            this.MainMenuBar.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateMenuEntry,
            this.OpenMenuEntry,
            this.SaveMenuEntry,
            this.toolStripSeparator1,
            this.ExportMenuEntry,
            this.toolStripSeparator4,
            this.ChangePasswordMenuEntry,
            this.toolStripSeparator3,
            this.Exit});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // CreateMenuEntry
            // 
            this.CreateMenuEntry.Name = "CreateMenuEntry";
            this.CreateMenuEntry.Size = new System.Drawing.Size(180, 22);
            this.CreateMenuEntry.Text = "Create (Ctrl+&N)";
            this.CreateMenuEntry.Click += new System.EventHandler(this.OnCreateFile);
            // 
            // OpenMenuEntry
            // 
            this.OpenMenuEntry.Name = "OpenMenuEntry";
            this.OpenMenuEntry.Size = new System.Drawing.Size(180, 22);
            this.OpenMenuEntry.Text = "&Open";
            this.OpenMenuEntry.Click += new System.EventHandler(this.OnOpenFile);
            // 
            // SaveMenuEntry
            // 
            this.SaveMenuEntry.Name = "SaveMenuEntry";
            this.SaveMenuEntry.Size = new System.Drawing.Size(180, 22);
            this.SaveMenuEntry.Text = "&Save";
            this.SaveMenuEntry.Click += new System.EventHandler(this.OnSaveFile);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ExportMenuEntry
            // 
            this.ExportMenuEntry.Name = "ExportMenuEntry";
            this.ExportMenuEntry.Size = new System.Drawing.Size(180, 22);
            this.ExportMenuEntry.Text = "Expor&t text";
            this.ExportMenuEntry.Click += new System.EventHandler(this.OnExportFile);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // ChangePasswordMenuEntry
            // 
            this.ChangePasswordMenuEntry.Name = "ChangePasswordMenuEntry";
            this.ChangePasswordMenuEntry.Size = new System.Drawing.Size(180, 22);
            this.ChangePasswordMenuEntry.Text = "Change password";
            this.ChangePasswordMenuEntry.Click += new System.EventHandler(this.OnChangePassword);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.OnExit);
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyMenuEntry,
            this.CutMenuEntry,
            this.PasteMenuEntry,
            this.toolStripSeparator2,
            this.SelectAllMenuEntry});
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(39, 20);
            this.EditMenu.Text = "Edit";
            // 
            // CopyMenuEntry
            // 
            this.CopyMenuEntry.Name = "CopyMenuEntry";
            this.CopyMenuEntry.Size = new System.Drawing.Size(180, 22);
            this.CopyMenuEntry.Text = "&Copy";
            this.CopyMenuEntry.Click += new System.EventHandler(this.OnCopyButtonClick);
            // 
            // CutMenuEntry
            // 
            this.CutMenuEntry.Name = "CutMenuEntry";
            this.CutMenuEntry.Size = new System.Drawing.Size(180, 22);
            this.CutMenuEntry.Text = "Cut (Ctrl+&X)";
            this.CutMenuEntry.Click += new System.EventHandler(this.OnCutButtonClick);
            // 
            // PasteMenuEntry
            // 
            this.PasteMenuEntry.Name = "PasteMenuEntry";
            this.PasteMenuEntry.Size = new System.Drawing.Size(180, 22);
            this.PasteMenuEntry.Text = "Paste (Ctrl+&V)";
            this.PasteMenuEntry.Click += new System.EventHandler(this.OnPasteButtonClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // SelectAllMenuEntry
            // 
            this.SelectAllMenuEntry.Name = "SelectAllMenuEntry";
            this.SelectAllMenuEntry.Size = new System.Drawing.Size(180, 22);
            this.SelectAllMenuEntry.Text = "Select all";
            this.SelectAllMenuEntry.Click += new System.EventHandler(this.OnSelectAllButtonClick);
            // 
            // FormatMenu
            // 
            this.FormatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordWrapMenuEntry,
            this.FontMenuEntry});
            this.FormatMenu.Name = "FormatMenu";
            this.FormatMenu.Size = new System.Drawing.Size(57, 20);
            this.FormatMenu.Text = "Format";
            // 
            // WordWrapMenuEntry
            // 
            this.WordWrapMenuEntry.Name = "WordWrapMenuEntry";
            this.WordWrapMenuEntry.Size = new System.Drawing.Size(180, 22);
            this.WordWrapMenuEntry.Text = "Word wrap";
            this.WordWrapMenuEntry.CheckedChanged += new System.EventHandler(this.OnCheckWordWrap);
            this.WordWrapMenuEntry.Click += new System.EventHandler(this.OnWordWrapButtonClick);
            // 
            // FontMenuEntry
            // 
            this.FontMenuEntry.Name = "FontMenuEntry";
            this.FontMenuEntry.Size = new System.Drawing.Size(180, 22);
            this.FontMenuEntry.Text = "&Font";
            this.FontMenuEntry.Click += new System.EventHandler(this.OnFontButtonClick);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewHelpMenuEntry,
            this.AboutMenuEntry});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpMenu.Text = "Help";
            // 
            // ViewHelpMenuEntry
            // 
            this.ViewHelpMenuEntry.Name = "ViewHelpMenuEntry";
            this.ViewHelpMenuEntry.Size = new System.Drawing.Size(180, 22);
            this.ViewHelpMenuEntry.Text = "View Help (Ctrl+&H)";
            this.ViewHelpMenuEntry.Click += new System.EventHandler(this.OnViewHelpButtonClick);
            // 
            // AboutMenuEntry
            // 
            this.AboutMenuEntry.Name = "AboutMenuEntry";
            this.AboutMenuEntry.Size = new System.Drawing.Size(180, 22);
            this.AboutMenuEntry.Text = "About...";
            this.AboutMenuEntry.Click += new System.EventHandler(this.OnAboutButtonClick);
            // 
            // TextArea
            // 
            this.TextArea.AcceptsTab = true;
            this.TextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextArea.Enabled = false;
            this.TextArea.Location = new System.Drawing.Point(0, 24);
            this.TextArea.Multiline = true;
            this.TextArea.Name = "TextArea";
            this.TextArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextArea.Size = new System.Drawing.Size(694, 464);
            this.TextArea.TabIndex = 1;
            this.TextArea.WordWrap = false;
            this.TextArea.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // openDialog
            // 
            this.openDialog.DefaultExt = "etf";
            this.openDialog.FileName = "openFileDialog1";
            this.openDialog.Filter = "Archivo de texto encriptado|*.etf|Todos los archivos|*.*";
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "etf";
            this.saveDialog.Filter = "Archivo de texto encriptado|*.etf|Todos los archivos|*.*";
            // 
            // fontDialog
            // 
            this.fontDialog.Color = System.Drawing.SystemColors.ControlText;
            // 
            // MainWinidow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 488);
            this.Controls.Add(this.TextArea);
            this.Controls.Add(this.MainMenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenuBar;
            this.Name = "MainWinidow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnCloseWindow);
            this.ResizeEnd += new System.EventHandler(this.OnResize);
            this.MainMenuBar.ResumeLayout(false);
            this.MainMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuBar;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem CreateMenuEntry;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuEntry;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuEntry;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordMenuEntry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuEntry;
        private System.Windows.Forms.ToolStripMenuItem CutMenuEntry;
        private System.Windows.Forms.ToolStripMenuItem PasteMenuEntry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SelectAllMenuEntry;
        private System.Windows.Forms.ToolStripMenuItem FormatMenu;
        private System.Windows.Forms.ToolStripMenuItem FontMenuEntry;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewHelpMenuEntry;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuEntry;
        private System.Windows.Forms.TextBox TextArea;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem WordWrapMenuEntry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExportMenuEntry;
    }
}

