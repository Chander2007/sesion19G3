using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiPrimerForm.Formularios;

namespace MiPrimerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mnu100_Click(object sender, EventArgs e)
        {
            Opacity = 1;
        }

        private void Mnu95_Click(object sender, EventArgs e)
        {
            Opacity = 0.95;
        }

        private void Mnu90_Click(object sender, EventArgs e)
        {
            Opacity = 0.9;
        }

        private void Mnu85_Click(object sender, EventArgs e)
        {
            Opacity = 0.85;
        }

        private void Mnu80_Click(object sender, EventArgs e)
        {
            Opacity = 0.8;
        }

        private void MnuRojo_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void MnuAzul_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void MnuVerde_Click(object sender, EventArgs e)
        {
            BackColor= Color.Green;
        }

        private void MnuOrigina_Click(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.ShowDialog();
        }

        private void MnuProducto_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            frm.ShowDialog();
        }

        private void formulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
