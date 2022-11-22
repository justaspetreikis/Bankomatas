using Bankomatas.Repozitorijos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomatas.Forms
{
    public partial class form_Pasirinkimai : Form
    {
        public form_Pasirinkimai()
        {
            InitializeComponent();
        }

        private void button_Iseiti_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_saskaitosLikutis_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_Pasirinkimai_Load(object sender, EventArgs e)
        {
            var _bankoKorteleRepozitorija = new BankoKorteleRepozitorija();
            var kortele = _bankoKorteleRepozitorija.GrazintiKortelesDuomenis(Form_bankomatas.kortelesNumeris);

            tb_saskaitosLikutis.Text = kortele.PiniguSuma.ToString() + " EUR";
        }

        private void button_inestiPinigus_Click(object sender, EventArgs e)
        {
            var inestiPinigus = new InestiPinigusForm();
            this.Hide();
            inestiPinigus.ShowDialog();
        }

        private void button_pakeisitPin_Click(object sender, EventArgs e)
        {
            var pinKeitimas = new form_KeistiPin();
            this.Hide();
            pinKeitimas.ShowDialog();
        }

        private void button_isimtiPinigus_Click(object sender, EventArgs e)
        {
            var piniguIsemimas = new form_PiniguIsemimas();
            this.Hide();
            piniguIsemimas.ShowDialog();
        }

        private void button_transakcijos_Click(object sender, EventArgs e)
        {
            var transkacijos = new form_Transakcijos();
            this.Hide();
            transkacijos.ShowDialog();
        }
    }
}
