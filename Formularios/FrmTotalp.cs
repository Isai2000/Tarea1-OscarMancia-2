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
    public partial class FrmTotalp : Form
    {
        public FrmTotalp()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCant.Clear();
            TxtPrecu.Clear();
            TxtTotalp.Clear();
            TxtCant.Focus();

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtCant.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese un dato");
                TxtCant.Focus();
                return;
            }

            if (TxtPrecu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese un dato");
                TxtPrecu.Focus();
                return;
            }

            double cant, precu, totalp;
            cant = Convert.ToDouble(TxtCant.Text);
            precu = Convert.ToDouble(TxtPrecu.Text);

            totalp = cant * precu;

            TxtTotalp.Text = totalp.ToString();
        
        }
    }
}
