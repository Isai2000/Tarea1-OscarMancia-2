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
    public partial class FrmSuma : Form
    {
        public FrmSuma()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtN1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese un dato");
                TxtN1.Focus();
                return;
            }

            if (TxtN2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese un dato");
                TxtN2.Focus();
                return;
            }

            if (TxtN3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese un dato");
                TxtN3.Focus();
                return;
            }

            double n1, n2, n3, rest;
            n1 = Convert.ToDouble(TxtN1.Text);
            n2 = Convert.ToDouble(TxtN2.Text);
            n3 = Convert.ToDouble(TxtN3.Text);

            rest = n1 + n2 + n3;

            TxtRest.Text = rest.ToString();
        
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtN1.Clear();
            TxtN2.Clear();
            TxtN3.Clear();
            TxtRest.Clear();
            TxtN1.Focus();
        }
    }
}
