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
    public partial class FrmHorasExtra : Form
    {
        public FrmHorasExtra()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtHrxt.Clear();
            TxtValor.Clear();
            TxtSal.Clear();

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtHrxt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese un dato");
                TxtHrxt.Focus();
                return;
            }

            if (TxtValor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese un dato");
                TxtValor.Focus();
                return;
            }

            double hrxt, valor, sal;
            hrxt = Convert.ToDouble(TxtHrxt.Text);
            valor = Convert.ToDouble(TxtValor.Text);

            sal = hrxt * valor;

            TxtSal.Text = sal.ToString();
        }
    }
}
