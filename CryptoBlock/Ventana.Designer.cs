namespace CryptoBlock
{
    partial class Ventana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportarTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cambiarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkAjuste = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(694, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportarTextoToolStripMenuItem,
            this.toolStripSeparator4,
            this.cambiarClaveToolStripMenuItem,
            this.toolStripSeparator3,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Crear (Ctrl+&N)";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.clicNuevo);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.clicAbrir);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.clicGuardar);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exportarTextoToolStripMenuItem
            // 
            this.exportarTextoToolStripMenuItem.Name = "exportarTextoToolStripMenuItem";
            this.exportarTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportarTextoToolStripMenuItem.Text = "Expor&tar texto";
            this.exportarTextoToolStripMenuItem.Click += new System.EventHandler(this.clicExportar);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // cambiarClaveToolStripMenuItem
            // 
            this.cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarClaveToolStripMenuItem.Text = "Ca&mbiar contraseña";
            this.cambiarClaveToolStripMenuItem.Click += new System.EventHandler(this.clicCambiarClave);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.clicSalir);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.toolStripSeparator2,
            this.seleccionarTodoToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.copiarToolStripMenuItem.Text = "&Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.clicCopiar);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cortarToolStripMenuItem.Text = "Cortar (Ctrl+&X)";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.clicCortar);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pegarToolStripMenuItem.Text = "Pegar (Ctrl+&V)";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.clicPegar);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.seleccionarTodoToolStripMenuItem.Text = "S&elecionar todo";
            this.seleccionarTodoToolStripMenuItem.Click += new System.EventHandler(this.clicSeleccionarTodo);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chkAjuste,
            this.fuenteToolStripMenuItem});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // chkAjuste
            // 
            this.chkAjuste.Name = "chkAjuste";
            this.chkAjuste.Size = new System.Drawing.Size(151, 22);
            this.chkAjuste.Text = "Ajuste de línea";
            this.chkAjuste.CheckedChanged += new System.EventHandler(this.checkAjuste);
            this.chkAjuste.Click += new System.EventHandler(this.clicAjuste);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.fuenteToolStripMenuItem.Text = "&Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.clicFuente);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temasToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // temasToolStripMenuItem
            // 
            this.temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            this.temasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.temasToolStripMenuItem.Text = "Ver la ayuda (Ctrl+&H)";
            this.temasToolStripMenuItem.Click += new System.EventHandler(this.clicVerAyuda);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.acercaDeToolStripMenuItem.Text = "Ace&rca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.clicAcerca);
            // 
            // txtTexto
            // 
            this.txtTexto.AcceptsTab = true;
            this.txtTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTexto.Enabled = false;
            this.txtTexto.Location = new System.Drawing.Point(0, 24);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTexto.Size = new System.Drawing.Size(694, 464);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.WordWrap = false;
            this.txtTexto.TextChanged += new System.EventHandler(this.cambioTexto);
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
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 488);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Ventana";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cerrarVentana);
            this.ResizeEnd += new System.EventHandler(this.cambiarTamaño);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem chkAjuste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportarTextoToolStripMenuItem;
    }
}

