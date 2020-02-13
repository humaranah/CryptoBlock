using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoBlock
{
    public partial class InputDialog : Form
    {
        public InputDialog(string titulo = "", bool importar = false)
        {
            InitializeComponent();
            this.Text = titulo;
            pnlImportar.Visible = importar;
        }

        private void clicAceptar(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                MessageBox.Show("La contraseña está en blanco.");
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void seleccionMostrar(object sender, EventArgs e)
        {
            if (chkMostrar.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        public String Contraseña
        {
            get
            {
                return txtContraseña.Text;
            }
        }

        public String RutaImportar
        {
            get
            {
                return txtImportar.Text;
            }
        }

        private void clicImportar(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                txtImportar.Text = openDialog.FileName;
            }
        }
    }
}
