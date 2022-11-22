using Bankomatas.Class;
using Bankomatas.Repozitorijos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomatas.Forms
{
    public partial class form_Transakcijos : Form
    {
        public form_Transakcijos()
        {
            InitializeComponent();
        }

        private void button_Prideti_Click(object sender, EventArgs e)
        {
            var _transkacija = new TransakcijaRepositorija();
            var transakcijos = _transkacija.GrazintiVisuKorteliuLista();
            transakcijos.Sort((x, y) => DateTime.Compare(y.OperacijosLaikas, x.OperacijosLaikas));

            List<Transakcija> vienosKortelės = new List<Transakcija>();
            foreach (var transakcija in transakcijos)
            {
                if (transakcija.KortelesNumeris == Guid.Parse(Form_bankomatas.kortelesNumeris))
                {
                    vienosKortelės.Add(transakcija);
                }
            }

            dataGridView1.DataSource = vienosKortelės;

        }
        private void button_Paskutines5_Click(object sender, EventArgs e)
        {
            var _transkacija = new TransakcijaRepositorija();
            var transakcijos = _transkacija.GrazintiVisuKorteliuLista();

            List<Transakcija> vienosKortelės = new List<Transakcija>();

            transakcijos.Sort((x, y) => DateTime.Compare(y.OperacijosLaikas, x.OperacijosLaikas));

            foreach (var transakcija in transakcijos)
            {
               if (transakcija.KortelesNumeris == Guid.Parse(Form_bankomatas.kortelesNumeris) && vienosKortelės.Count < 5)
               {
                   vienosKortelės.Add(transakcija);
               }
            }

            dataGridView1.DataSource = vienosKortelės;
        }

        private void buttonPiniguInesimai_Click(object sender, EventArgs e)
        {
            var _transkacija = new TransakcijaRepositorija();
            var transakcijos = _transkacija.GrazintiVisuKorteliuLista();
            transakcijos.Sort((x, y) => DateTime.Compare(y.OperacijosLaikas, x.OperacijosLaikas));

            List<Transakcija> vienosKortelės = new List<Transakcija>();
            foreach (var transakcija in transakcijos)
            {
                if (transakcija.KortelesNumeris == Guid.Parse(Form_bankomatas.kortelesNumeris) && transakcija.OperacijosTipas == "deposit")
                {
                    vienosKortelės.Add(transakcija);
                }
            }

            dataGridView1.DataSource = vienosKortelės;
        }

        private void button_PiniguIsemimai_Click(object sender, EventArgs e)
        {
            var _transkacija = new TransakcijaRepositorija();
            var transakcijos = _transkacija.GrazintiVisuKorteliuLista();
            transakcijos.Sort((x, y) => DateTime.Compare(y.OperacijosLaikas, x.OperacijosLaikas));

            List<Transakcija> vienosKortelės = new List<Transakcija>();
            foreach (var transakcija in transakcijos)
            {
                if (transakcija.KortelesNumeris == Guid.Parse(Form_bankomatas.kortelesNumeris) && transakcija.OperacijosTipas == "withdraw")
                {
                    vienosKortelės.Add(transakcija);
                }
            }

            dataGridView1.DataSource = vienosKortelės;
        }

        private void button_Gristi_Click(object sender, EventArgs e)
        {
            var pasirinkimai = new form_Pasirinkimai();
            this.Hide();
            pasirinkimai.ShowDialog();
        }
    }
}
