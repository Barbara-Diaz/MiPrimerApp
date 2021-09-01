using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerApp
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
           
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
           
            textNombre.Clear();
            textContrasenia.Clear();
            principal form = new principal();
            form.ShowDialog();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
