namespace CryptoBlock
{
    partial class InputDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chkMostrar = new System.Windows.Forms.CheckBox();
            this.pnlImportar = new System.Windows.Forms.Panel();
            this.txtImportar = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlImportar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseña.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(82, 12);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(235, 23);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(242, 106);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Location = new System.Drawing.Point(161, 106);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.clicAceptar);
            // 
            // chkMostrar
            // 
            this.chkMostrar.AutoSize = true;
            this.chkMostrar.Location = new System.Drawing.Point(203, 38);
            this.chkMostrar.Name = "chkMostrar";
            this.chkMostrar.Size = new System.Drawing.Size(114, 17);
            this.chkMostrar.TabIndex = 4;
            this.chkMostrar.Text = "Mostrar caracteres";
            this.chkMostrar.UseVisualStyleBackColor = true;
            this.chkMostrar.CheckedChanged += new System.EventHandler(this.seleccionMostrar);
            // 
            // pnlImportar
            // 
            this.pnlImportar.Controls.Add(this.btnImportar);
            this.pnlImportar.Controls.Add(this.txtImportar);
            this.pnlImportar.Location = new System.Drawing.Point(15, 61);
            this.pnlImportar.Name = "pnlImportar";
            this.pnlImportar.Size = new System.Drawing.Size(302, 29);
            this.pnlImportar.TabIndex = 5;
            // 
            // txtImportar
            // 
            this.txtImportar.Location = new System.Drawing.Point(3, 5);
            this.txtImportar.Name = "txtImportar";
            this.txtImportar.ReadOnly = true;
            this.txtImportar.Size = new System.Drawing.Size(215, 20);
            this.txtImportar.TabIndex = 0;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(224, 3);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.clicImportar);
            // 
            // openDialog
            // 
            this.openDialog.DefaultExt = "txt";
            this.openDialog.Filter = "Archivos de texto|*.txt";
            // 
            // InputDialog
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(329, 141);
            this.ControlBox = false;
            this.Controls.Add(this.pnlImportar);
            this.Controls.Add(this.chkMostrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputDialog";
            this.Text = "Crear archivo";
            this.pnlImportar.ResumeLayout(false);
            this.pnlImportar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chkMostrar;
        private System.Windows.Forms.Panel pnlImportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtImportar;
    }
}