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
    public partial class FrmMenuPrinicpal : Form
    {
        public FrmMenuPrinicpal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.FrmSuma suma = new Formularios.FrmSuma();
            suma.ShowDialog();
        }

        private void BtnProm_Click(object sender, EventArgs e)
        {
            Formularios.FrmProm prom = new Formularios.FrmProm();
            prom.ShowDialog();
        }

        private void BtnMiam_Click(object sender, EventArgs e)
        {
            Formularios.FrmMiam fender = new Formularios.FrmMiam();
            fender.ShowDialog();
        }

        private void BtnMiakm_Click(object sender, EventArgs e)
        {
            Formularios.FrmMiaKm gibson = new Formularios.FrmMiaKm();
            gibson.ShowDialog();
        }

        private void BtnLpsaDolar_Click(object sender, EventArgs e)
        {
            Formularios.FrmLpsaDolar ibanez = new Formularios.FrmLpsaDolar();
            ibanez.ShowDialog();
        }

        private void BtnLpsaEuros_Click(object sender, EventArgs e)
        {
            Formularios.FrmLpsaEuros onix = new Formularios.FrmLpsaEuros();
            onix.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Formularios.FrmTotalp gio = new Formularios.FrmTotalp();
            gio.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSalario_Click(object sender, EventArgs e)
        {
            Formularios.FrmSalario squier = new Formularios.FrmSalario();
            squier.ShowDialog();
        }

        private void BtnHxt_Click(object sender, EventArgs e)
        {
            Formularios.FrmHorasExtra tubescremer = new Formularios.FrmHorasExtra();
            tubescremer.ShowDialog();

        }

        private void BtnGalt_Click(object sender, EventArgs e)
        {
            Formularios.FrmGalt dusenberg = new Formularios.FrmGalt();
            dusenberg.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
