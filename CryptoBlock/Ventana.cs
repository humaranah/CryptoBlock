using CryptoBlock.Models;
using System;
using System.Windows.Forms;

namespace CryptoBlock
{
    public partial class Ventana : Form
    {
        private string contraseña = null;
        private string ruta = "";
        private EstadoArchivo estado = EstadoArchivo.Nulo;
        private string titulo = Constants.ApplicationTitle;

        public Ventana()
        {
            InitializeComponent();
            this.Text = titulo;
            cargarConfiguración();
        }

        private void cargarConfiguración()
        {
            txtTexto.Font = Properties.Settings.Default.EditorFont;
            chkAjuste.Checked = Properties.Settings.Default.WordWrap;
            this.Height = Properties.Settings.Default.Height;
            this.Width = Properties.Settings.Default.Width;
        }

        private bool guardar()
        {
            switch (estado)
            {
                case EstadoArchivo.SinCrear:
                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        ruta = saveDialog.FileName;
                        CryptoText.Guardar(txtTexto.Lines, contraseña, ruta);
                        estado = EstadoArchivo.Guardado;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case EstadoArchivo.SinGuardar:
                    CryptoText.Guardar(txtTexto.Lines, contraseña, ruta);
                    estado = EstadoArchivo.Guardado;
                    break;
            }
            return true;
        }

        private bool evalEstado(object sender, EventArgs e)
        {
            if (estado == EstadoArchivo.SinCrear || estado == EstadoArchivo.SinGuardar)
            {
                DialogResult result = MessageBox.Show("¿Desea guardar el archivo?",
                    "Archivo sin guardar", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        return guardar();
                    case System.Windows.Forms.DialogResult.No:
                        return true;
                }
                return false;
            }
            return true;
        }

        private void clicNuevo(object sender, EventArgs e)
        {
            if (!evalEstado(sender, e))
                return;
            InputDialog dialog = new InputDialog("Crear Archivo", true);
            dialog.StartPosition = FormStartPosition.CenterParent;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                contraseña = dialog.Contraseña;
                txtTexto.Enabled = true;
                if (dialog.RutaImportar != "")
                {
                    txtTexto.Lines = CryptoText.Importar(dialog.RutaImportar);
                }
                else
                {
                    txtTexto.Text = "";
                    this.ActiveControl = txtTexto;
                }
                this.Text = "nuevo* - " + titulo;
                estado = EstadoArchivo.SinCrear;
            }
        }

        private void clicAbrir(object sender, EventArgs e)
        {
            String[] lines;
            InputDialog dialog;

            if (!evalEstado(sender, e))
                return;

            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ruta = openDialog.FileName;
                dialog = new InputDialog("Abrir Archivo");
                dialog.StartPosition = FormStartPosition.CenterParent;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    contraseña = dialog.Contraseña;
                    /*try
                    {
                        lines = CryptoText.Abrir(dialog.Contraseña, ruta);
                    }
                    catch
                    {
                        MessageBox.Show("Error al abrir el archivo\n¿Contraseña incorrecta?");
                        return;
                    }*/
                    lines = CryptoText.Abrir(dialog.Contraseña, ruta);
                    if (lines != null)
                        txtTexto.Lines = lines;
                    txtTexto.Enabled = true;
                    this.Text = System.IO.Path.GetFileNameWithoutExtension(openDialog.FileName) + " - " + titulo;
                    estado = EstadoArchivo.Guardado;
                }
            }
        }

        private void clicGuardar(object sender, EventArgs e)
        {
            guardar();
            this.Text = System.IO.Path.GetFileNameWithoutExtension(openDialog.FileName) + " - " + titulo;
        }

        private void clicCambiarClave(object sender, EventArgs e)
        {
            if (estado == EstadoArchivo.Nulo)
            {
                return;
            }
            InputDialog dialog = new InputDialog("Nueva Contraseña");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                contraseña = dialog.Contraseña;
                guardar();
                MessageBox.Show("La contraseña se guardó con éxito");
                estado = EstadoArchivo.Guardado;
            }
        }

        private void clicSalir(object sender, EventArgs e)
        {
            Close();
        }

        private void clicCopiar(object sender, EventArgs e)
        {
            SendKeys.Send("^c");
        }

        private void clicCortar(object sender, EventArgs e)
        {
            SendKeys.Send("^x");
        }

        private void clicPegar(object sender, EventArgs e)
        {
            SendKeys.Send("^v");
        }

        private void clicSeleccionarTodo(object sender, EventArgs e)
        {
            txtTexto.SelectAll();
        }

        private void clicFuente(object sender, EventArgs e)
        {
            if (estado == EstadoArchivo.Nulo)
            {
                return;
            }
            fontDialog.Font = txtTexto.Font;
            if (fontDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTexto.Font = fontDialog.Font;
                Properties.Settings.Default.EditorFont = txtTexto.Font;
                Properties.Settings.Default.Save();
            }
        }

        private void clicVerAyuda(object sender, EventArgs e)
        {

        }

        private void clicAcerca(object sender, EventArgs e)
        {
            AboutDialog dialog = new AboutDialog();
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ShowDialog();
        }

        private void cambioTexto(object sender, EventArgs e)
        {
            if (estado == EstadoArchivo.Guardado)
                estado = EstadoArchivo.SinGuardar;
            this.Text = System.IO.Path.GetFileNameWithoutExtension(openDialog.FileName) + "* - " + titulo;
        }

        private void clicAjuste(object sender, EventArgs e)
        {
            chkAjuste.Checked = !chkAjuste.Checked;
            Properties.Settings.Default.Save();
        }

        private void clicExportar(object sender, EventArgs e)
        {
            if (estado == EstadoArchivo.Nulo)
                return;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Archivo de texto|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CryptoText.Exportar(txtTexto.Lines, dialog.FileName);
            }
        }

        private void checkAjuste(object sender, EventArgs e)
        {
            txtTexto.WordWrap = chkAjuste.Checked;
            Properties.Settings.Default.WordWrap = chkAjuste.Checked;
        }

        private void cerrarVentana(object sender, FormClosingEventArgs e)
        {
            if (!evalEstado(sender, e))
                e.Cancel = true;
        }

        private void cambiarTamaño(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.Width = this.Width;
                Properties.Settings.Default.Height = this.Height;
                Properties.Settings.Default.Save();
            }
        }
    }
}
