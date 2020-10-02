using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1.Formularios
{
    public partial class FrmLpsaEuros : Form
    {
        public FrmLpsaEuros()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtLps.Clear();
            TxtEuros.Clear();
            TxtLps.Focus();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtLps.Text.Trim().Length == 0)
            {
                MessageBox.Show("No a ingresado ningun numero");
                TxtLps.Focus();
                return;
            }

            double lps, euros;
            lps = Convert.ToDouble(TxtLps.Text);

            euros = lps * 0.034;

            TxtEuros.Text = euros.ToString();
        }
    }
}
